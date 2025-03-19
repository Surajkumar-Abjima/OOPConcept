using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcept {
    class InheritAnimal {
        public void Eat() {
            Console.WriteLine("This animal Eats food");
        }
    }

    class Cat : InheritAnimal {
        public void Meow() {
            Console.WriteLine("Cat Meows");
        }
    }
}
