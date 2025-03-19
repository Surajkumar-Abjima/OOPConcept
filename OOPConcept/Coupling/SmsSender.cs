using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcept.Coupling
{
    class SmsSender : INotificationService {
        public void SendNotification(string message) {
            Console.WriteLine("Sms message: "+message);
        }
    }
}
