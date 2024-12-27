using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception_Handling
{
    internal class CustExp1 : Exception
    {
       
        // Zero Not Allowed Exception
        //public CustExp1(string message) : base(message) { }
        //public override string ToString()
        //{
        //    return  Message;
        //}

        //Name Not Found Exception
        public CustExp1(string message) : base(message) { }
        public override string ToString()
        {
            return Message;
        }
    }
}
