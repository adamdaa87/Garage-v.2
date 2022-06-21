using Garage_v._2.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_v._2.Menus
{
    public class Menu
    {
        private static IUI UI { get; set; }
        private static EventLog Log { get; set; }

        private static bool Initialized { get; set; } = false;
        public string MenuName { get;}
        public List<MenuOption> Options { get; }

        private int currentIndex; // zero-baserad

        private Menu(string name)
        {
            MenuName = name;
            Options = new List<MenuOption>();
            currentIndex = 0;
        }
        public void Add(MenuOption option)
        {
            Options.Add(option);
        }

        public MenuOption Run()
        {
            MenuOption option = null;
            while(option == null)
            {
                UI.DisplayMenu(this, currentIndex);
                UI.DisplayLog(Log);
                var key = UI.GetKeyFromUser();
                switch(key)
                {
                    case ConsoleKey.UpArrow:
                        if (currentIndex > 0)
                        {
                            currentIndex--;
                        }
                        break;
                        
                    case ConsoleKey.DownArrow:
                        if(currentIndex < Options.Count-1)
                        {
                            currentIndex++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        option = Options[currentIndex];
                        break;
                }
            }
            return option;
        }

        internal static void Init (IUI ui, EventLog log)
        {
            UI = ui;
            Log = log;
            Initialized = true;
        }

        public void ResetCursorIndex()
        {
            currentIndex = 0;
        }

        public static Menu Create(string name)
        {
            if (Initialized)
            {
                var menu = new Menu(name);
                return menu;
            }
            else
            {
                throw new Exception("The Menu class must be initialized before any instances can be created!");
            }
        }
    }
}
