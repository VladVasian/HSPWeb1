using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Client.Models
{
    public class User
    {
        public int Id { get; set; }
        public int Mgnr { get; set; }
        public int MBNO { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Suffix { get; set; }
        public string Company { get; set; }
        public bool ActivityStatus { get; set; }
        public string Status { get; set; }
        public string PayerStatus { get; set; }
        public double Payment { get; set; }
        public string City { get; set; }
        public int BankAccountID { get; set; }
    }
}
