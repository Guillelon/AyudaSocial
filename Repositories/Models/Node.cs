using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Models
{
    public class Node
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string Address { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public string Notes { get; set; }
        public bool Delivered { get; set; }

        public int RouteId { get; set; }
        public virtual Route Route { get; set; }

        public Node()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
