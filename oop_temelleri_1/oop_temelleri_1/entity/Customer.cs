using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oop_temelleri_1.entity
{
    public class Customer
    {
        //prop + 2 defa tab tusu
        //public int MyProperty { get; set; }
        //int a; boyle olsaydi degiskendi
        //public int A {  get; set; } // artik bir property
    
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCity { get; set; }
    }
}
