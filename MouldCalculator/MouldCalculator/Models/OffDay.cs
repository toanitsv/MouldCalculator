//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MouldCalculator.Models
{
    using System;
    using System.Collections.Generic;
    using MouldCalculator.ViewModels;
    
    public partial class OffDay : BaseViewModel
    {
        public int OffDayID { get; set; }
        private Nullable<DateTime> _Date;
        public Nullable<DateTime> Date { get => _Date; set { _Date = value; OnPropertyChanged(); } }

        private string _Description;

        public string Description { get => _Description; set { _Description = value; OnPropertyChanged(); } }
        public Nullable<System.DateTime> CreatedTime { get; set; }
    }
}
