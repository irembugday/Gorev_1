using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [StringLength(50)]
        public String CategoryName { get; set; }

        [StringLength(200)]
        public String CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; } //durum

        public ICollection<Heading> Headings { get; set; } //ilişkilendirileceği tabloyu belirttik.
    }
}
