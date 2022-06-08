using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_10_CompositeOffice
{
    class Leaf: Component
    {
        public override string Operation()
        {
            return "Leaf";
        }

        public override bool IsComposite()
        {
            return false;
        }
    } 

    class Divan : Component
    {
        private double price = 5000;
        private string name = "Divan";
         
        public override string Operation()
        {
            return $"- {name} - {price} грн";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }

    class Magazine : Component
    {
        private double price = 85;
        private string name = "Komp Magazine"; 
          
        public override string Operation()
        {
            return $"- {name} - {price} грн";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }

    class HDD : Component
    {
        private double price = 1000;
        private string name = "HDD1000";
         
        public override string Operation()
        {
            return $"- {name} - {price} грн";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }

    class Instrument : Component
    {
        private double price = 300;
        private string name = "Office Instr";
         
        public override string Operation()
        {
            return $"- {name} - {price} грн";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }

    class Kyler : Component
    {
        private double price = 1300;
        private string name = "Kyller";

        public override string Operation()
        {
            return $"- {name} - {price} грн";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }

    class Tablee : Component
    {
        private double price = 800;
        private string name = "Стол";

        public override string Operation()
        {
            return $"- {name} - {price} грн";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }

    class Doska : Component
    {
        private double price = 500;
        private string name = "Доска";

        public override string Operation()
        {
            return $"- {name} - {price} грн";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }

    class Plakats : Component
    {
        private double price = 400;
        private string name = "Плакаты";

        public override string Operation()
        {
            return $"- {name} - {price} грн";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }

    class CofeAvto : Component
    {
        private double price = 2000;
        private string name = "Кофейный автомат";

        public override string Operation()
        {
            return $"- {name} - {price} грн";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }

    class Cheir : Component
    {
        private double price = 600;
        private string name = "Стул";

        public override string Operation()
        {
            return $"- {name} - {price} грн";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }

    class Frigiretor : Component
    {
        private double price = 10000;
        private string name = "Холодильник";

        public override string Operation()
        {
            return $"- {name} - {price} грн";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }

    class Ymival : Component
    {
        private double price = 5000;
        private string name = "Умывальник";

        public override string Operation()
        {
            return $"- {name} - {price} грн";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
} 