using MaterialDesignThemes.Wpf;
using System;

namespace MenuMVVM.Models
{
    public class MenuItem
    {
        public String Name { get; private set; }
        public PackIconKind Icon { get; private set; }
        public ItemCount Count { get; private set; }

        public MenuItem(String name, PackIconKind icon, ItemCount count)
        {
            Name = name;
            Icon = icon;
            Count = count;
        }
    }
}