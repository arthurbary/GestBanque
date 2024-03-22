﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaiss { get; set; }
        
        private string _test;

        public string Test
        {
            get 
            {
                return _test;
            }
            set
            {
                _test = value;
            }
        }
    }
}
