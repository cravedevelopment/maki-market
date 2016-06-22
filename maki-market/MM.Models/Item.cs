using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MM.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public int ItemCode { get; set; }
        public string Description { get; set; }
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
