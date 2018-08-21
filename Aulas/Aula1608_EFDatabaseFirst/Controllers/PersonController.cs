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

        void Editar(int id, Person novosDadosPerson)
        {
            //Procura por id e atualiza os dados em novoDadosPerson
            Person personAntigo = BuscarPorId(id);

            if(personAntigo != null)
            {
                personAntigo.FirstName = novosDadosPerson.FirstName;
                personAntigo.LastName = novosDadosPerson.LastName;
                personAntigo.Title = novosDadosPerson.Title;

                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Entry(personAntigo).State = System.Data.Entity.EntityState.Modified;

                //Não esquecer o save changes no final do método
                contexto.SaveChanges();
            }
        }
        List<Person>PesquisarPorFirstName(string firstName)
        {

            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            //LINQ
            //var lista = from p in contexto.Person
            // select p;
            //esse é o select * from person

            var lista = from p in contexto.Person
                        where p.FirstName == firstName
                        select p;

            return lista.ToList();
        }
    }
}
