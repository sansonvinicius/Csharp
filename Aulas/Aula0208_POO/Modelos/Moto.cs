using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelos
{
    class Moto : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("MOTO: Acelerando pela manopla...");
            Velocidade += 10;
        }

        public void Frenar()
        {
            Console.WriteLine("MOTO: Frenando pela manopla...");
            Velocidade -= 7;
        }
    }
}
