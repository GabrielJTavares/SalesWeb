using SalesWbeMVC.Data;
using SalesWbeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWbeMVC.Services
{
    public class SellerService
    {
        private readonly SalesWbeMVCContext _context;

        public SellerService(SalesWbeMVCContext context)
        {
            _context = context;
        } 

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            obj.Departament = _context.Departament.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
        
    }
}
