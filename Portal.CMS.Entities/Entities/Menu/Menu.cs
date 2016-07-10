﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Portal.CMS.Entities.Entities.Menu
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }

        [Required]
        public string MenuName { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}