using System;
using System.Collections.Generic;
using System.Text;

namespace UTIMCO_DemoApp
{
    public class Menu
    {
        public MenuDescription menu;
    }

    public class MenuDescription
    {
        public String header;
        public List<Items> items;
    }
    public class Items
    {
        public int id;
        public String label;
    }
}
