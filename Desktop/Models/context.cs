using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Models
{
    class context : DbContext
    {
        private static context _context;
        public context() : base("sql") { }
        public static context aGetContext()
        {
            if (_context == null)
                _context = new context();
            return _context;
        }
    }
}
