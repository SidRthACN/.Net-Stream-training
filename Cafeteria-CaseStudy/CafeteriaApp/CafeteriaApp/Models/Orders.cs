using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeteriaApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string EmployeeName { get; set; }
        public List<MenuItem> items { get; set; } = new List<MenuItem>();
        public double Total { get; set; }
        public DateTime Date { get; set; }

        public Order(int id, string employeeName)
        {
            OrderId = id;
            EmployeeName = employeeName;
            Date = DateTime.Now;
        }

        public void CalcuateTotal()
        {
            Total = items.Sum(i => i.Price);
        }

        public override string ToString()
        {
            string itemList = string.Join(", ", items.Select(i => i.Name));
            return $"Order #{OrderId} | {EmployeeName} | items: {itemList} | Total: ${Total:F2}";
        }
    }
}