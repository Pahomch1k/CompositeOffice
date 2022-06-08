using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_10_CompositeOffice
{
    abstract class Component
    {
        public Component() { }
         
        public abstract string Operation();
         
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }
         
        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
