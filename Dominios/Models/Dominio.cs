using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominios.Models
{
    public class Dominio
    {

        public int Id { get; set; }
        public string Nome { get; set; }


        public Dominio(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
    }
}