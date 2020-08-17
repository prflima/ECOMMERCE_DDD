﻿using Entities.Notifications;
using System.ComponentModel.DataAnnotations;

namespace Entities.Entities
{
    public class Base : Notifies
    {
        [Display(Name = "Code")]
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
