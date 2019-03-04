using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MouldCalculator.Helper;
using MouldCalculator.Models;

namespace MouldCalculator.ViewModels
{
    public class ComponentViewModel : BaseViewModel
    {
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

        private Component _SelectedItem;
        public Component SelectedItem {
            get => _SelectedItem;
            set {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    DisplayName = SelectedItem.ComponentName;
                }
            }
        }

        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public ComponentViewModel()
        {
            ComponentList = new ObservableCollection<Component>(DataProvider.Ins.DB.Components);

            // Add
            AddCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(DisplayName))
                    return false;

                var displayList = DataProvider.Ins.DB.Components.Where(x => x.ComponentName == DisplayName);
                if (displayList == null || displayList.Count() != 0)
                    return false;

                return true;

            }, (p) =>
            {
                var componentAdd = new Component() { ComponentName = DisplayName, CreatedTime = DateTime.Now };

                DataProvider.Ins.DB.Components.Add(componentAdd);
                DataProvider.Ins.DB.SaveChanges();

                ComponentList.Add(componentAdd);
            });

            // Edit
            EditCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(DisplayName) || SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.Components.Where(x => x.ComponentName == DisplayName);
                if (displayList == null || displayList.Count() != 0)
                    return false;

                return true;

            }, (p) =>
            {
                var component = DataProvider.Ins.DB.Components.SingleOrDefault(s => s.ComponentID == SelectedItem.ComponentID);
                component.ComponentName = DisplayName;
                DataProvider.Ins.DB.SaveChanges();

                SelectedItem.ComponentName = DisplayName;
            });

            // Delete
            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;
                return true;
            }, (p) =>
            {
                if (MessageBox.Show(StringHelper.GetFromResource("msgBoxConfirmDelete"), StringHelper.GetFromResource("componentWindowTitle"), MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                {
                    return;
                }

                var componentDelete = DataProvider.Ins.DB.Components.SingleOrDefault(s => s.ComponentID == SelectedItem.ComponentID);
                DataProvider.Ins.DB.Components.Remove(componentDelete);
                DataProvider.Ins.DB.SaveChanges();

                ComponentList.Remove(componentDelete);
            });
        }
    }
}
