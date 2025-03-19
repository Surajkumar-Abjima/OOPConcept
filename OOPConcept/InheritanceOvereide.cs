using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOPConcept
{
    public class InheritanceOvereide
    {
        public virtual void SayHello() {
            Console.WriteLine("Hello");
        }
    }

    public class DerivedClass : InheritanceOvereide {
        public override void SayHello() {
            Console.WriteLine("Hello User");
        }

    }

}
