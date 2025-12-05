using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flashcards
{
    internal class DataController
    {
        private static string? connectionString = null;
        public DataController(string? connString) { 
            connectionString = connString;
        }


    }
}
