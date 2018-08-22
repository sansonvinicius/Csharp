using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2108_CodeFirst.Modelos
{
    class Categoria
    {
        //Chave primária: O Entity reconhece se usar a palavra Id/ID/id ou nomeClasseID(CategoriaID)
        [Key]//Data Notation para chave primária
        public int CategoriaID { get; set; }
        [Required]//Data Notation que não permite null
        [StringLength(30)]//Data Notation tamanho da String
        public string Nome { get; set; }
        public string Descricao { get; set; }

        //Relacionamento Categoria <--> Produto

       //Vários produtos para uma categoria
        public virtual ICollection<Produto> _Produtos { get; set; }



    }
}
