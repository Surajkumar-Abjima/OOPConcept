using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcept.Coupling
{
    class Order
    {
        private readonly INotificationService notificationService;
        public Order(INotificationService notificationService) {
            this.notificationService=notificationService; ;
        }
        public void PlaceOrder() {
            //EmailSender emailSender = new EmailSender();
            //emailSender.SendEmail("Order placed successfully");

            notificationService.SendNotification("Order placed Successfully");
        }
    }
}
