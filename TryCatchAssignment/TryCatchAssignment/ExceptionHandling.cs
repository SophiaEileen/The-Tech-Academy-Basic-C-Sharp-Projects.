﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{

    class ExceptionHandling : Exception
    {
        public ExceptionHandling()
            : base() { }
        public ExceptionHandling(string message)
            : base(message) { }
    }
}
