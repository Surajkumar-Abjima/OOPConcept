using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcept {
    abstract class AbstractAnimal {
        public abstract void MakeSound();//abstract method (no implementation)

        public void Sleep()  /*Concrete method(implementation)*/{ 
            Console.WriteLine("Sleeping....");
            }

    }

    class Dog : AbstractAnimal {
        public override void MakeSound() {
            Console.WriteLine("Woof! Woof!");
        }


    }

}


