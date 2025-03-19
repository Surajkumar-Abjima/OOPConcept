using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcept {
    interface InterfaceVehicle {
        void Start();//by default a abstract method withod implementation

    }
    class Car : InterfaceVehicle {
        public void Start() {
            Console.WriteLine("Car is starting...");
        }
    }

    class Car2 : Car {
        public void Model() {
            Console.WriteLine("Ferrari");
        }
    }
}
