using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;


        public SeedingService (SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
             if(_context.Departament.Any() || _context.Saller.Any() || _context.SalesRecords.Any())
            {
                return; // o banco de dados já foi populado
            }

            Departament d1 = new Departament(1, "Computers");
            Departament d2 = new Departament(2, "Eletronics");
            Departament d3 = new Departament(3, "Fashion");
            Departament d4 = new Departament(4, "books");

            Saller s1 = new Saller(1, "Denis James", "dnsmarangoni@gmail.com", new DateTime(1992, 1, 8), 3100, d1);
            Saller s2 = new Saller(2, "Dani", "dani@gmail.com", new DateTime(1995, 1, 8), 2100, d1);
            Saller s3 = new Saller(3, "Thais Ayumi", "thaisayumi@gmail.com", new DateTime(1990, 1, 8), 3500, d2);
            Saller s4 = new Saller(4, "Suelen Silva", "suelensilva@gmail.com", new DateTime(1982, 1, 8), 1100, d4);
            Saller s5 = new Saller(5, "Gabriel Barbosa", "gabrielbarbosa@gmail.com", new DateTime(2002, 1, 8), 2000, d1);
            Saller s6 = new Saller(6, "Henrique juliano", "henriquejuliano@gmail.com", new DateTime(1998, 1, 8), 1550, d3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000, SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 7), 4000, SalesStatus.Billed, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 12), 5000, SalesStatus.Billed, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 23), 9000, SalesStatus.Billed, s3);

            _context.Departament.AddRange(d1, d2, d3, d4);
            _context.Saller.AddRange(s1, s2, s3, s4,s5,s6);
            _context.SalesRecords.AddRange(r1, r2, r3, r4);


            _context.SaveChanges();
       
        
        }
    }
}
