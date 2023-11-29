using System;

namespace _03.New_Order_Event_Example
{
    public class OrderEventArgs : EventArgs
    {
        public int OrderID { get; }
        public int OrderTotalPrice { get; }
        public string ClientEmail { get; }
        public OrderEventArgs(int orderID, int orderTotalPrice, string clientEmail)
        {
            this.OrderID = orderID;
            this.OrderTotalPrice = orderTotalPrice;
            this.ClientEmail = clientEmail;
        }
    }

    public class Order
    {
        public event EventHandler<OrderEventArgs> OrderChanged;

        public void Create(int OrderID, int OrderTotalPrice, string ClientEmail)
        {
            Console.WriteLine("New Order Created");
            OrderChanged?.Invoke(this, new OrderEventArgs(OrderID, OrderTotalPrice, ClientEmail));
        }
    }

    public class EmailService
    {
        public void Subscribe(Order order)
        {
            order.OrderChanged += HandleNewOrder;
        }

        public void Unsubscribe(Order order) 
        {
            order.OrderChanged -= HandleNewOrder;
        }
        public void HandleNewOrder(object sender, OrderEventArgs e)
        {
            Console.WriteLine("-----Email Service-----");
            Console.WriteLine($"OrderID: {e.OrderID}");
            Console.WriteLine($"OrderTotalPrice: {e.OrderTotalPrice}");
            Console.WriteLine($"ClientEmail: {e.ClientEmail}");
            Console.WriteLine("Send Email\n");
        }
    }

    public class SMSService
    {
        public void Subscribe(Order order)
        {
            order.OrderChanged += HandleNewOrder;
        }

        public void Unsubscribe(Order order)
        {
            order.OrderChanged -= HandleNewOrder;
        }
        public void HandleNewOrder(object sender, OrderEventArgs e)
        {
            Console.WriteLine("-----SMS Service-----");
            Console.WriteLine($"OrderID: {e.OrderID}");
            Console.WriteLine($"OrderTotalPrice: {e.OrderTotalPrice}");
            Console.WriteLine($"ClientEmail: {e.ClientEmail}");
            Console.WriteLine("Send SMS\n");
        }
    }

    public class ShippingService
    {
        public void Subscribe(Order order)
        {
            order.OrderChanged += HandleNewOrder;
        }

        public void Unsubscribe(Order order)
        {
            order.OrderChanged -= HandleNewOrder;
        }
        public void HandleNewOrder(object sender, OrderEventArgs e)
        {
            Console.WriteLine("-----Shipping Service-----");
            Console.WriteLine($"OrderID: {e.OrderID}");
            Console.WriteLine($"OrderTotalPrice: {e.OrderTotalPrice}");
            Console.WriteLine($"ClientEmail: {e.ClientEmail}");
            Console.WriteLine("Handle Shipping\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            EmailService emailService = new EmailService();
            SMSService smsService = new SMSService();
            ShippingService shippingService = new ShippingService();

            smsService.Subscribe(order);
            emailService.Subscribe(order);
            shippingService.Subscribe(order);

            order.Create(1, 10000, "mohamedbadwy@gmail.com");
        }
    }
}
