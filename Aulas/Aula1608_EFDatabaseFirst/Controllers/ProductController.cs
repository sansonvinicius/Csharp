using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1608_EFDatabaseFirst.Controllers
{
    class ProductController
    {
        void Inserir (Product prod)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            contexto.Product.Add(prod);
            contexto.SaveChanges();
        }

        List<Product> ListarTodosProdutos()
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Product.ToList();
        }

        Product BuscarPorId(int id)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Product.Find(id);
        }

        void Excluir(int id)
        {
            Product prodExcluir = BuscarPorId(id);

            if (prodExcluir != null)
            {
                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Product.Remove(prodExcluir);
                contexto.SaveChanges();
            }
        }

        void Editar(int id, Product novosDadosProduct)
        {
            //Procura por id e atualiza os dados em novoDadosPerson
            Product productAntigo = BuscarPorId(id);

            if (productAntigo != null)
            {
                productAntigo.Color = novosDadosProduct.Color;
                productAntigo.Size = novosDadosProduct.Size;
                productAntigo.ListPrice = novosDadosProduct.ListPrice;

                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Entry(productAntigo).State = System.Data.Entity.EntityState.Modified;

                //Não esquecer o save changes no final do método
                contexto.SaveChanges();
            }
        }

        List<Product> PesquisarPorColor(string color)
        {

            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            
            var listaProdutos = from prod in contexto.Product
                        where prod.Color == color
                        select prod;

            return listaProdutos.ToList();
        }

    }
}
