﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seguradoraVeiculo
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }
        public override double CalcularSeguro()
        {
            return ValorVeiculo * 0.07;
        }
    }
}