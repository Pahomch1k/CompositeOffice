using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_10_CompositeOffice
{
    class Composite: Component
    {
        protected List<Component> _children = new List<Component>();
        private string name; 
         
        public Composite(string n) { name = n; }
          
        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        } 

        public override string Operation()
        {
            int i = 0;
            string result = $"{name}\n";

            foreach (Component component in _children)
            {
                result += component.Operation();
                if (i != _children.Count - 1) 
                    result += "\n"; 
                i++;
            }

            return result;
        }
    }

    class TableSec : Component
    {
        protected List<Component> _children = new List<Component>();
        private string name = "Стол секретаря";
        private double price = 3000;
         
        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            string result = $"{name} - {price} грн\n-";

            foreach (Component component in _children)
            {
                result += component.Operation();
                if (i != _children.Count - 1)
                    result += "\n";
                i++;
            }

            return result;
        }
    }

    class TableMagazine : Component
    {
        protected List<Component> _children = new List<Component>();
        private string name = "Журнаяльный столик";
        private double price = 1500;

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            string result = $"{name} - {price} грн\n-";

            foreach (Component component in _children)
            {
                result += component.Operation();
                if (i != _children.Count - 1)
                    result += "\n";
                i++;
            }

            return result;
        }
    }

    class Komp : Component
    {
        protected List<Component> _children = new List<Component>();
        private string name = "Компьютер";
        private double price = 15500;

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            string result = $"{name} - {price} грн\n-";

            foreach (Component component in _children)
            {
                result += component.Operation();
                if (i != _children.Count - 1)
                    result += "  ";
                i++;
            }

            return result;
        }
    }

    class TeacherTable : Component
    {
        protected List<Component> _children = new List<Component>();
        private string name = "Стол учителя";
        private double price = 4700;

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            string result = $"{name} - {price} грн\n-";

            foreach (Component component in _children)
            {
                result += component.Operation();
                if (i != _children.Count - 1)
                    result += "  ";
                i++;
            }

            return result;
        }
    }

    class Table : Component
    {
        protected List<Component> _children = new List<Component>();
        private string name = "Стол";
        private double price = 1000;

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            string result = $"{name} - {price} грн\n-";

            foreach (Component component in _children)
            {
                result += component.Operation();
                if (i != _children.Count - 1)
                    result += "  ";
                i++;
            }

            return result;
        }
    }
}
