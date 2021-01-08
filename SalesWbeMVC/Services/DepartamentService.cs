using SalesWbeMVC.Data;
using SalesWbeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWbeMVC.Services
{
    public class DepartamentService
    {

        private readonly SalesWbeMVCContext _context;

        public DepartamentService(SalesWbeMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
