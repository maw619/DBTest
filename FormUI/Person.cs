﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Person
    { 
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }


        public string FullInfo
        {
            get
               {
                return $"{firstName} {lastName}";
               }

            
        }




    }
}
