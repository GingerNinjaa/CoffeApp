using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeApp.Models
{
   public class Menus
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public List<SubMenu> SubMenus { get; set; }
    }
}
