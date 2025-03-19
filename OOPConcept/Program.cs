using OOPConcept.Coupling;

namespace OOPConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Encapsulation

            //EncapBankAccount bankAccount = new EncapBankAccount(100);

            //Console.WriteLine(bankAccount.GetBalance());

            //bankAccount.Deposit(50);
            //Console.WriteLine(bankAccount.GetBalance());

            //bankAccount.withdraw(20);
            //Console.WriteLine(bankAccount.GetBalance());

            //Abstraction

            //AbstractAnimal myDog =new Dog();
            //myDog.MakeSound();
            //myDog.Sleep();


            //InterfaceVehicle vehicle = new Car();
            //Car2 vehicle2 = new Car2();

            //vehicle.Start();
            //vehicle2.Start();

            //Inheritance

            //InheritAnimal animal = new InheritAnimal();
            //animal.Eat();

            //DerivedClass hello = new DerivedClass();
            //hello.SayHello();

            var order = new Order(new SmsSender());
            order.PlaceOrder();

        }
    }
}
