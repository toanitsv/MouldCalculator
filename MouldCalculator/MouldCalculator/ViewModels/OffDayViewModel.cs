using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MouldCalculator.Models;
using MouldCalculator.Helper;
using System.Windows.Input;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using MouldCalculator.Views;
using System.Windows;

namespace MouldCalculator.ViewModels
{
    public class OffDayViewModel : BaseViewModel
    {
        private ObservableCollection<OffDay> _OffDayList;
        public ObservableCollection<OffDay> OffDayList
        {
            get => _OffDayList;
            set
            {
                _OffDayList = value;
                OnPropertyChanged();

            }
        }

        private ObservableCollection<Supplier> _Supplier;
        public ObservableCollection<Supplier> SupplierList
        {
            get => _Supplier;
            set
            {
                _Supplier = value;
                OnPropertyChanged();
            }
        }

        private Nullable<DateTime> _DisplayDate;
        public Nullable<DateTime> DisplayDate
        {
            get => _DisplayDate;
            set
            {
                _DisplayDate = value;
                OnPropertyChanged();
            }
        }

        private OffDay _SelectedItem;
        public OffDay SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    DisplayDate = SelectedItem.Date;
                }
            }
        }

        private string _Description;
        public string Description
        {
            get => _Description;
            set
            {
                _Description = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        

        public OffDayViewModel()
        {
            DisplayDate = DateTime.Now;
            // Read
            OffDayList      = new ObservableCollection<OffDay>(DataProvider.Ins.DB.OffDays);
            SupplierList = new ObservableCollection<Supplier>(DataProvider.Ins.DB.Suppliers);

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(DisplayDate.ToString()))
                    return false;

                var dayValidation = OffDayList.SingleOrDefault(s => s.Date.Value.Date == DisplayDate.Value.Date);
                if (dayValidation == null)
                    return false;

                return true;

            }, (p) =>
            {
                // Add off day to OffDayList
                var offDayAdd = new OffDay() { Date = DisplayDate, Description = Description, CreatedTime = DateTime.Now };
                DataProvider.Ins.DB.OffDays.Add(offDayAdd);
                DataProvider.Ins.DB.SaveChanges();
                OffDayList.Add(offDayAdd);

                // Map offday and supplier
                foreach (var supplier in SupplierList)
                {
                    var offDayMap = new OffDay_Supplier_Mapping() { OffDayID = offDayAdd.OffDayID, SupplierID = supplier.SupplierID };
                    DataProvider.Ins.DB.OffDay_Supplier_Mapping.Add(offDayMap);
                    DataProvider.Ins.DB.SaveChanges();
                }
            });

            // Edit
            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;
                return true;
            }, (p) =>
            {
            });

        }
    }
}
