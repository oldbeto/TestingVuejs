﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingVuejs.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string[] Cursos { get; set; }
    }
}