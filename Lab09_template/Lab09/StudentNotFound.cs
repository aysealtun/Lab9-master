using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab09
{
    class StudentNotFound : Exception
    {
        public StudentNotFound()
         : base()
     { }

        public StudentNotFound(String message)
         : base(message)
 
     { }


    }
}
