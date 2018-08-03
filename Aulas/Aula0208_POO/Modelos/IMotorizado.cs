using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelos
{
    interface IMotorizado
    {
        //Velocidade é como se fosse uma variável de Imotorizado
        int Velocidade { get; set; }
        void Acelerar();
        void Frenar();

    }
}
