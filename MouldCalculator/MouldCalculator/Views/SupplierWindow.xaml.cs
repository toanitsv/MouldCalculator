using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Entity;
using MouldCalculator.Models;
using MouldCalculator.Controllers;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Data;
using MouldCalculator.Helper;

namespace MouldCalculator.Views
{
    /// <summary>
    /// Interaction logic for SupplierWindow.xaml
    /// </summary>
    public partial class SupplierWindow : Window
    {
        BackgroundWorker bwLoad;
        BackgroundWorker bwExecuteDb;

        public SupplierWindow()
        {
            InitializeComponent();

            bwLoad = new BackgroundWorker();
            bwLoad.DoWork += bwLoad_DoWork;
            bwLoad.RunWorkerCompleted += bwLoad_RunWorkerCompleted;

            bwExecuteDb = new BackgroundWorker();
            bwExecuteDb.DoWork += bwExecuteDb_DoWork;
            bwExecuteDb.RunWorkerCompleted += bwExecuteDb_RunWorkerCompleted;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (bwLoad.IsBusy == false)
            {
                this.Cursor = Cursors.Wait;
                bwLoad.RunWorkerAsync();
            }
        }
        private void bwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var db = new MouldEntities())
            {
                var supplierList = new ObservableCollection<Supplier>(db.Suppliers.ToList());
                e.Result = supplierList;
            }
        }
        private void bwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                return;

            var supplierList = e.Result as ObservableCollection<Supplier>;
            txtSupplierID.Text = "1611";
            txtSupplierName.Clear();
            txtSupplierDescription.Clear();
            if (supplierList.Count() > 0)
            {
                txtSupplierID.Text = (supplierList.OrderBy(o => o.SupplierID).LastOrDefault().SupplierID + 1).ToString();
                dgSupplier.ItemsSource = supplierList;
            }
            this.Cursor = null;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Validate control
            string supplierName = "";
            supplierName = txtSupplierName.Text.Trim();
            if (String.IsNullOrWhiteSpace(supplierName))
            {
                MessageBox.Show( StringHelper.GetFromResource("supplierWindowMessageValidateSupllierName"),
                                 StringHelper.GetFromResource("supplierWindowTitle"), 
                                 MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            var supplierFromView = new Supplier() {
                SupplierID = Int32.Parse(txtSupplierID.Text),
                SupplierName = supplierName,
                Description = txtSupplierDescription.Text.Trim(),
                CreatedTime = DateTime.Now
            };

            if (bwExecuteDb.IsBusy == false)
            {
                this.Cursor = Cursors.Wait;
                btnAdd.IsEnabled = false;
                object[] objects = { supplierFromView , EModeExecute.AddOrUpdate};
                bwExecuteDb.RunWorkerAsync(objects);
            }
        }

        private void bwExecuteDb_DoWork(object sender, DoWorkEventArgs e)
        {
            var objects = e.Argument as object[];
            var supplier = objects[0] as Supplier;
            var modeExecute = objects[1];

            using (var db = new MouldEntities())
            {
                var checkExist = db.Suppliers.SingleOrDefault(s => s.SupplierID == supplier.SupplierID);
                if (modeExecute.Equals(EModeExecute.AddOrUpdate))
                {
                    try
                    {
                        if (checkExist == null)
                        {
                            db.Suppliers.Add(supplier);
                        }
                        else
                        {
                            checkExist.SupplierName = supplier.SupplierName;
                            checkExist.Description = supplier.Description;
                            checkExist.ModifiedTime = DateTime.Now;
                        }
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
                if (modeExecute.Equals(EModeExecute.Remove))
                {
                    try
                    {
                        db.Suppliers.Remove(checkExist);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
        private void bwExecuteDb_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(StringHelper.GetFromResource("supplierWindowMessageExecuteDbError"), StringHelper.GetFromResource("supplierWindowTitle"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MessageBox.Show(StringHelper.GetFromResource("supplierWindowMessageExecuteDbSuccessful"), StringHelper.GetFromResource("supplierWindowTitle"), MessageBoxButton.OK, MessageBoxImage.Information);
            this.Cursor = null;
            btnAdd.IsEnabled = true;
            btnRemove.IsEnabled = false;
            // Reload
            if (bwLoad.IsBusy==false)
            {
                bwLoad.RunWorkerAsync();
            }
        }

        private void btnEditRow_Click(object sender, RoutedEventArgs e)
        {
            var rowClicked = (Supplier)dgSupplier.CurrentItem;
            if (rowClicked == null)
                return;

            epCreateSupplier.IsExpanded = true;
            txtSupplierID.Text = rowClicked.SupplierID.ToString();
            txtSupplierName.Text = rowClicked.SupplierName;
            txtSupplierDescription.Text = rowClicked.Description;

            btnRemove.IsEnabled = true;
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var supplierDelete = new Supplier() {
                SupplierID = Int32.Parse(txtSupplierID.Text)
            };

            if (MessageBox.Show(StringHelper.GetFromResource("supplierWindowMessageConfirmDelete"), StringHelper.GetFromResource("supplierWindowTitle"), MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                return;
            }

            if (bwExecuteDb.IsBusy == false)
            {
                this.Cursor = Cursors.Wait;
                btnRemove.IsEnabled = false;

                object[] objects = { supplierDelete, EModeExecute.Remove };
                bwExecuteDb.RunWorkerAsync(objects);
            }
        }

    }
    public enum EModeExecute
    {
        AddOrUpdate,
        Remove
    }

}
