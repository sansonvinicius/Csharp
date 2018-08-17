using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1608_EFDatabaseFirst.Controllers
{
    class PersonController
    {
        void Inserir(Person p)
        {
            //A view chama a controller para consultar os dados na model.
            //Pega esse nome AdventuteWork... da model da AdventureWorks2016Model.Context.cs
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            contexto.Person.Add(p);
            contexto.SaveChanges();
        }

        List<Person> ListarTodosPerson()
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Person.ToList();
        }

        Person BuscarPorId(int id)
        {
            //Estanciando contexto
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Person.Find(id);
            //contexto.Person(tabela)
            //O método Find() só faz pesquisa pela chave.

        }

        void Excluir(int id)
        {
            Person pExcluir = BuscarPorId(id);

            if(pExcluir != null)
            {
                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Person.Remove(pExcluir);
                contexto.SaveChanges();


            }
        }
    }
}
