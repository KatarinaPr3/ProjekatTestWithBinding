//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjekatTestWithBinding.Model
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Windows;

    public partial class OrderDetail
    {
        public int orderid { get; set; }
        public int productid { get; set; }
        public decimal unitprice { get; set; }
        public short qty { get; set; }
        public decimal discount { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }

        public static TEST_DOOEntities db = new TEST_DOOEntities();
        public static void SaveList(ObservableCollection<OrderDetail> listDetails)
        {
            foreach (OrderDetail item in listDetails)
            {
                db.OrderDetails.Add(item);
                

            }
            db.SaveChanges();
            MessageBox.Show("Added Successfully");
        }
    }
}
