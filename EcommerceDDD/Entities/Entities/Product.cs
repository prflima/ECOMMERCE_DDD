using Entities.Notifications;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("Product")]
    public class Product : Notifies
    {
        [Column("PRD_ID")]
        [Display(Name = "Code")]
        public int Id { get; set; }

        [Column("PRD_NAME")]
        [MaxLength(255)]
        [Display(Name = "Name")]
        public string Name { get; set; }


        [Column("PRD_DESCRIPTION")]
        [MaxLength(150)]
        [Display(Name = "Description")]
        public string Description { get; set; }


        [Column("PRD_NOTE")]
        [MaxLength(20000)]
        [Display(Name = "Note")]
        public string Note { get; set; }

        [Column("PRD_STOCK")]
        [Display(Name = "Available Stock")]
        public int QtdStock { get; set; }

        [Display(Name = "User")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Column("PRD_VALUE")]
        [Display(Name = "Value")]
        public decimal Value { get; set; }

        [Column("PRD_STATE")]
        [Display(Name = "State")]
        public bool State { get; set; }

        [Column("PRD_REGISTER_DATE")]
        [Display(Name = "Register Date")]
        public DateTime RegisterDate { get; set; }

        [Column("PRD_REGISTER_UPDATE")]
        [Display(Name = "Register Update")]
        public DateTime RegisterUpdate { get; set; }

    }
}
