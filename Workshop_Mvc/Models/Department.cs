using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace Workshop_Mvc.Models
{
    public class Department
    {
        public int id { get; set; }
        public string nome { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotSellers(DateTime ini, DateTime fin)
        {
            return Sellers.Sum(seller => seller.TotSales(ini, fin));
        }
    }
}
