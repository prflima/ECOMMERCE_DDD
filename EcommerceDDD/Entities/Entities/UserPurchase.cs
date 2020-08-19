using Entities.Entities.Enums;
using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    [Table("UserPurchase")]
    public class UserPurchase : Notifies
    {
        [Column("PUR_ID")]
        [Display(Name = "Identity")]
        public int Id { get; set; }

        [Display(Name = "Product")]
        [ForeignKey("Product")]
        [Column(Order = 1)]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Column("PUR_STATUS")]
        [Display(Name = "Status")]
        public PurchaseStatus Status { get; set; }

        [Column("PUR_QTD_PRODUCT")]
        [Display(Name = "Quantity")]
        public int QtdPurchase { get; set; }

        [Display(Name = "User")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }    
    }
}
