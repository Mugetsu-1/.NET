using System;

namespace Lab2
{
    // Declare a delegate
    public delegate void OrderStatusHandler(string orderId, string status);

    class OrderProcessor
    {
        // Declare an event
        public event OrderStatusHandler OrderStatusChanged;

        public void ProcessOrder(string orderId)
        {
            Console.WriteLine($"\nProcessing order: {orderId}");

            // Simulate order processing stages
            UpdateStatus(orderId, "Order Received");
            System.Threading.Thread.Sleep(300);

            UpdateStatus(orderId, "Payment Confirmed");
            System.Threading.Thread.Sleep(300);

            UpdateStatus(orderId, "Preparing Shipment");
            System.Threading.Thread.Sleep(300);

            UpdateStatus(orderId, "Shipped");
            System.Threading.Thread.Sleep(300);

            UpdateStatus(orderId, "Delivered");
        }

        private void UpdateStatus(string orderId, string status)
        {
            Console.WriteLine($"  Status -> {status}");
            // Raise the event
            OrderStatusChanged?.Invoke(orderId, status);
        }
    }

    class EmailNotifier
    {
        public void OnOrderStatusChanged(string orderId, string status)
        {
            Console.WriteLine($"  [Email] Sending email for Order {orderId}: {status}");
        }
    }

    class SMSNotifier
    {
        public void OnOrderStatusChanged(string orderId, string status)
        {
            Console.WriteLine($"  [SMS] Sending SMS for Order {orderId}: {status}");
        }
    }

    class Logger
    {
        public void OnOrderStatusChanged(string orderId, string status)
        {
            Console.WriteLine($"  [Log] Order {orderId} updated to: {status}");
        }
    }

    internal class MulticastEventDemo
    {
        /*
        static void Main(string[] args)
        {
          

            OrderProcessor processor = new OrderProcessor();
            EmailNotifier email = new EmailNotifier();
            SMSNotifier sms = new SMSNotifier();
            Logger logger = new Logger();

            // Subscribe multiple handlers (multicast)
            processor.OrderStatusChanged += email.OnOrderStatusChanged;
            processor.OrderStatusChanged += sms.OnOrderStatusChanged;
            processor.OrderStatusChanged += logger.OnOrderStatusChanged;

            Console.WriteLine("Processing Order #1001 with all notifiers:");
            processor.ProcessOrder("1001");

            

            Console.WriteLine("Processing Order #1002 (Email and Logger only):");
            // Unsubscribe SMS
            processor.OrderStatusChanged -= sms.OnOrderStatusChanged;
            processor.ProcessOrder("1002");
        }
        */
    }
}
