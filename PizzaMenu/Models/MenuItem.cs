using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PizzaMenu.Models
{
    [Table("MenuItems")]
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name= "Availabe For Purchase")]
        public bool Active { get; set; }
        [Column(TypeName ="decimal(12, 4)"), Display(Name = "Price"),]
        public decimal BasePrice { get; set; }
        public int CookTime { get; set; }
        [Display(Name = "Date Added"), DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime DateAdded { get; set; }
        [Display(Name = "Modified"), DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime? DateModified { get; set; }
        [Display(Name = "Archived"), DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime? DateDeactivated { get; set; }
    }
}
