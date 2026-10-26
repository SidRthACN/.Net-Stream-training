using System;

namespace Module1
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        protected Customer(int customerId, string customerName)
        {
            Console.WriteLine(
                "Parent Constructor called with values {0}, {1}",
                customerId,
                customerName);

            CustomerId = customerId;
            CustomerName = customerName;
        }
    }

    class RegularCustomer : Customer
    {
        public string PaymentMethod { get; set; }

        public RegularCustomer(
            int customerId,
            string customerName,
            string paymentMethod)
            : base(customerId, customerName)
        {
            Console.WriteLine(
                "Child Constructor called with values {0}, {1}, {2}",
                customerId,
                customerName,
                paymentMethod);

            PaymentMethod = paymentMethod;
        }
    }
}