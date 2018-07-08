using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMode.Component
{
   public class Adapter:Target
    {

        public override string Using()
        {
            return new Adaptee().AdapteeUse(); 
        }
    }


    public class Adapter1:Target
    {
        public override string Using()
        {
            return new Adaptee1().Adaptee1Use();
        }
    }


    public class Target
    {
        public virtual string Using()
        {
            return "";
        }
    }
    public class Adaptee 
    {
        public string  AdapteeUse()
        {
            return "Adapteeuse";
        }
    }
   
    public class Adaptee1
    {
        public string Adaptee1Use()
        {
            return "AdapteeUse1";
        }
    }
}
