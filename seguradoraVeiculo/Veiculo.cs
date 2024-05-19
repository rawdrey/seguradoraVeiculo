using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seguradoraVeiculo
{
    public class Veiculo
    {
public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double ValorVeiculo { get; set; }
        public virtual double CalcularSeguro()
        {
            return ValorVeiculo * 0.05;
        }
    }
}
