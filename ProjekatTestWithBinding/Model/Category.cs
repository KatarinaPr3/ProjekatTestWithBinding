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
    using System.Linq;
    
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int categoryid { get; set; }
        public string categoryname { get; set; }
        public string description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
        public static TEST_DOOEntities db = new TEST_DOOEntities();
        public static ObservableCollection<string> GetListCategoryNames()
        {
            var category = (from c in db.Categories
                            select c.categoryname).ToList<string>();
            ObservableCollection<string> categoryNamesList = new ObservableCollection<string>();
            foreach (string item in category)
            {
                if (!categoryNamesList.Contains(item))
                {
                    categoryNamesList.Add(item);
                }
            }
            return categoryNamesList;
        }
        
        public static List<int> GetCategoryIds()
        {
            TEST_DOOEntities db = new TEST_DOOEntities();
            var cat = (from c in db.Categories
                       select c.categoryid).ToList<int>();
            List<int> catIds = new List<int>();
            foreach (int item in cat)
            {
                if (!catIds.Contains(item))
                {
                    catIds.Add(item);

                }
            }
            return catIds;
        }

        public static int GetCategoryIdByCategoryName(string name)
        {
            TEST_DOOEntities db = new TEST_DOOEntities();
            var cat = db.Categories.Where(u => u.categoryname == name).FirstOrDefault<Category>();
            return cat is null ? 0 : cat.categoryid;
        }


    }
}
