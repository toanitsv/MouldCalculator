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
        private List<OffDay_Supplier_Mapping> _OffDayList_Supplier_Day;
        public List<OffDay_Supplier_Mapping> OffDayList_Supplier_Day
        {
            get => _OffDayList_Supplier_Day;
            set
            {
                _OffDayList_Supplier_Day = value;
                OnPropertyChanged();
            }
        }

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

        private ObservableCollection<Component> _ComponentList;
        public ObservableCollection<Component> ComponentList
        {
            get => _ComponentList;
            set
            {
                _ComponentList = value;
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


        private int _SupplierID;
        public int SupplierID
        {
            get => _SupplierID;
            set
            {
                _SupplierID = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public ICommand RemoveSupplierCommand { get; set; }

        public OffDayViewModel()
        {
            DisplayDate = DateTime.Now;
            // Read
            OffDayList      = new ObservableCollection<OffDay>(DataProvider.Ins.DB.OffDays);
            ComponentList = new ObservableCollection<Component>(DataProvider.Ins.DB.Components);

            // Add
            AddCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(DisplayDate.ToString()))
                    return false;

                var dayValidation = OffDayList.Where(w => w.Date.Value.Date == DisplayDate.Value.Date);
                if (dayValidation == null || dayValidation.Count() != 0)
                    return false;

                return true;

            }, (p) =>
            {
                // Add off day to OffDayList
                var offDayAdd = new OffDay() {  Date = DisplayDate, Description = Description, CreatedTime = DateTime.Now };
                DataProvider.Ins.DB.OffDays.Add(offDayAdd);
                DataProvider.Ins.DB.SaveChanges();
                OffDayList.Add(offDayAdd);
            });

            // Edit
            EditCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                
            });

            // Load Suppliers has DisplayDate is OffDay.
            var offDay = OffDayList.SingleOrDefault(s => s.Date.Value.Date == DisplayDate.Value.Date);
            if (offDay != null)
            {
                OffDayList_Supplier_Day = new List<OffDay_Supplier_Mapping>(DataProvider.Ins.DB.OffDay_Supplier_Mapping).Where(w => w.OffDayID == offDay.OffDayID).ToList();

                // Show Items
                foreach (var offDayMapping in OffDayList_Supplier_Day)
                {
                    
                }
            }

            // Test
            RemoveSupplierCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
            });
        }
    }
}
