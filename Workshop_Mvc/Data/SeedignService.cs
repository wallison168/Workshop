using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop_Mvc.Models;
using Workshop_Mvc.Models.Enums;

namespace Workshop_Mvc.Data
{
    public class SeedignService
    {
        private Workshop_MvcContext _context;
        
        public SeedignService(Workshop_MvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() || _context.SalesRecords.Any() || _context.Seller.Any())
            {
                return; // Db has been seeded
            }
            Department d1 = new Department(1, "Computador");
            Department d2 = new Department(2, "Celular");
            Department d3 = new Department(3, "Tv");
            Department d4 = new Department(1, "Livros");

            Seller s1 = new Seller(1, "wallison", "wallison@gmail.com", new DateTime(2000, 7, 1), 1500.0, d1);
            Seller s2 = new Seller(2, "wellington", "wellington@gmail.com", new DateTime(1979, 9, 30), 1800.0, d3);
            Seller s3 = new Seller(1, "gisele", "gisele@gmail.com", new DateTime(1982, 7, 30), 1600.0, d2);
            Seller s4 = new Seller(1, "gisleny", "gisleny@gmail.com", new DateTime(2001, 11, 17), 1000.0, d4);
            Seller s5 = new Seller(1, "maikon", "mk@gmail.com", new DateTime(1999, 1, 1), 1300.0, d1);
            Seller s6 = new Seller(1, "dougla", "dg@gmail.com", new DateTime(1998, 3, 10), 1550.0, d3);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2020, 9, 1), 11000.0, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2020, 9, 5), 15000.0, SaleStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2020, 9, 10), 20000.0, SaleStatus.Billed, s3);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2020, 9, 1), 18000.0, SaleStatus.Billed, s4);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2020, 9, 10), 19000.0, SaleStatus.Billed, s5);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2020, 9, 1), 17000.0, SaleStatus.Billed, s6);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecords.AddRange(sr1, sr2, sr3, sr4, sr5, sr6);

            _context.SaveChanges();
        }
    }
}
