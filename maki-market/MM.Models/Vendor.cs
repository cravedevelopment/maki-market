using System.ComponentModel.DataAnnotations;

namespace MM.Models
{
    public class Vendor
    {
        [Key]
        public int Id { get; set; }
        public string VendorName { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string TelNumber { get; set; }
        public string FaxNumber { get; set; }
    }
}