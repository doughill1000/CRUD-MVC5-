//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HazmatTracking.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hazmat
    {
        public System.Guid Id { get; set; }
        public Nullable<double> TransactionNum { get; set; }
        public Nullable<bool> Void { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Initials { get; set; }
        public string Material { get; set; }
        public string New_Distilled_Dark { get; set; }
        public Nullable<double> Quantity { get; set; }
        public string Gallon_Pound { get; set; }
        public string Destination { get; set; }
        public string RequestedBy { get; set; }
        public string Shift { get; set; }
        public string RequiredFor { get; set; }
        public string Notes { get; set; }
    }
}