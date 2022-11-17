using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_VIII.Models
{
    public class Pessoa
    {
        protected int _id;

        private string _nome;
        private long _cpf;

        public int ID { get { return this._id; } set { this._id = value; } }        
        public string Nome { get { return this._nome; } set { this._nome = value; } }
        public Endereco endereco { get; set; }

        [Display(Name = "CPF")]
        public long Cpf { get { return this._cpf; } set { this._cpf = value; } }
        
        [Display(Name = "Telefone")]
        //public List<Telefone> telefones { get; set; } = new List<Telefone>();
        public Telefone telefones { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, Endereco endereco, long cpf, Telefone t)
        {
            Nome = nome;
            this.endereco = endereco;
            Cpf = cpf;
            //AddTelefone(t);
            this.telefones = t;

        }

        public Pessoa(int ID, string nome, Endereco endereco, long cpf, Telefone t) : this(nome, endereco, cpf, t)
        {
            this.ID = ID;
        }

        //public void AddTelefone(Telefone telefone)
        //{
        //    this.telefones.Add(new Telefone(telefone.Ddd, telefone.Numero, telefone.tipo));
        //}

        //public void RemoveTelefone(Telefone telefone)
        //{
        //    this.telefones.Remove(telefone);
        //}
    }
}