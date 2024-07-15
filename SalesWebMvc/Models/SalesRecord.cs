using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id  { get; set; }
        public DateTime Date { get; set;  }
        public double Amount  { get; set; }
        public SalesStatus Status { get; set; }
        public Saller Saller { get; set; }

        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Saller saller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status ;
            Saller = saller;
        }
    }
}
