using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seguradoraVeiculo
{
    public class Seguro
    {
        private bool seguroAtivo = false;

        public double CalcularSeguro(Veiculo veiculo)
        {
            ArgumentOutOfRangeExceptiif(seguroAtivo)
                {
                throw InvalidOperationException(Já existe um seguro em andamento);
            }
            seguroAtivo = true;
return veiculo.CalcularSeguro(); 
        }

    }
}
    