using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb2_API.Modeller
{
    public class PrenumerantModell
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phonenumber { get; set; }
        public string DelAdress { get; set; }
        public int Zipcode { get; set; }
        public string Town { get; set; }

    }
}