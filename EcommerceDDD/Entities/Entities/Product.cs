using Entities.Notifications;
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
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Column("PRD_VALUE")]
        [Display(Name = "Value")]
        public decimal Value { get; set; }

        [Column("PRD_STATE")]
        [Display(Name = "State")]
        public bool State { get; set; }
    }
}
