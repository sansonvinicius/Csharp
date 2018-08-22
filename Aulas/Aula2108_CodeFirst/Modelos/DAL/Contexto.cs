using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2108_CodeFirst.Modelos.DAL
{
    public class Contexto:DbContext
    {
        //ctor ->tab+tab : criando construtor
        public Contexto():base("nomeStringConexao")
        {

        }

    }
}
