using DesignPatterns.Composite.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.MenuComponents
{
    public class Menu : MenuComponent
    {
        private List<MenuComponent> menuComponents = new List<MenuComponent>();

        private string name;

        private string description;

        private IEnumerator<MenuComponent> iterator = null;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return menuComponents[i];
        }

        public override string Name
        {
            get
            {
                return name;
            }
        }

        public override string Description
        {
            get
            {
                return description;
            }
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.WriteLine("{0}, {1}", Name.ToUpper(), Description);
            Console.WriteLine("-----------");
            foreach (var menuComponent in menuComponents)
            {
                menuComponent.Print();
            }
        }

        public override IEnumerator<MenuComponent> GetEnumerator()
        {
            if (iterator == null)
            {
                iterator = new CompositeIterator(menuComponents.GetEnumerator());
            }

            return iterator;
        }
    }
}
