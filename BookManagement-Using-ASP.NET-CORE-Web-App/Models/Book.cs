using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement_Using_ASP.NET_CORE_Web_App.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Book Name :")]
        public string BookName { get; set; }

        [DisplayName("Author Name :")]
        [Required]
        public string Author { get; set; }

        [DisplayName("Price Of Book :")]
        [Required]
        public float? Cost { get; set; }

        [DisplayName("Added On :")]
        [DisplayFormat(DataFormatString = "{0:MM-YYYY}", ApplyFormatInEditMode = true)]
        public DateTime AddedOn { get; set; } = DateTime.Now;

        [DisplayName("Seller Name :")]
        [Required]
        public string SellerName { get; set; }
    }
}
