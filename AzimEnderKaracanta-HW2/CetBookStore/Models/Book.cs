using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [StringLength(512, MinimumLength =3, ErrorMessage = "En az 3 karakter giriniz")]
        [Required]
        [Display(Name ="Kitap Adı")]
        public string Title { get; set; } // nvarchar(512), not nullable

        [Display(Name = "Sayfa Sayısı")]
        public int? PageCount { get; set; }


        [StringLength(512, MinimumLength = 3, ErrorMessage = "En az 3 karakter giriniz")]
        [Required]
        [Display(Name = "Yazarlar")]
        public string Authors { get; set; }



        [StringLength(512, MinimumLength = 3, ErrorMessage = "En az 3 karakter giriniz")]
       
        [Display(Name = "Açıklama")]
        public string Description  { get; set; }

        [Display(Name = "Fiyat")]
        [Required(ErrorMessage ="Buranın doldurulması zorunludur. Fiyat yoksa 0 yazınız")]
        public Decimal Price { get; set; }

        [Display(Name = "Basım Yılı")]
        public int PressYear { get; set; }

        [Required]
        [Display(Name = "Stok Miktarı")]
        public int StockCount { get; set; }

        
        public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]

        [Display(Name = "Kategori")]
        [Required]
        public  Category Category { get; set; }

        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreatedDate { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public Book()
        {
            CreatedDate = DateTime.Now;
          //  double result = 4.0 / 2.0; //2.0000000000000000000000001 1.9999999999999999999999998
        }

    }
}
