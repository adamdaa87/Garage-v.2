using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_v._2.Menus
{
    public class MenuOption
    {
        public string OptionName { get; set; }
        public Action Action { get; set; }
        public Menu SubMenu { get; set; }

        public MenuOption(string optionName, Action action)
        {
            OptionName = optionName;
            Action = action;
            SubMenu = null;
        }

        public MenuOption(string optionName, Menu subMenu)
        {
            OptionName = optionName;
            Action = null;
            SubMenu = subMenu;
        }
    }
}
