using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seguradoraVeiculo
{
    public class Moto : Veiculo
    {
public int Cilindradas { get; set; }
        public override double CalcularSeguro()
        {
   
                return ValorVeiculo * 0.03;
            }
        

    }
}
