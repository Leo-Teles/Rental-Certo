﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Rental.WebApi.Domains
{
    public class VeiculoDomain
    {
        public int idVeiculo { get; set; }
        public EmpresaDomain empresa { get; set; }
        public string cor { get; set; }
        public string placa { get; set; }
    }
}
