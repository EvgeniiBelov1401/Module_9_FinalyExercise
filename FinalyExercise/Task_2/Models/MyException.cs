﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    internal class MyException:Exception
    {
        public MyException()
        {
            
        }
        public MyException(string message):base(message)
        {

        }
        public MyException(string message, Exception innerException) : base(message, innerException) 
        { 

        }

    }
}
