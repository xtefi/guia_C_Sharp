﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            if(c == 's' || c == 'S')
            {
                return true;
            }
            else return false;
        }
    }
}
