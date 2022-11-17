using System.ComponentModel.DataAnnotations;

namespace PIM_VIII.Models
{
    public class Telefone
    {
        protected int _id;
        private int _ddd;
        private int _numero;

        public int ID { get { return this._id; } set { this._id = value; } }

        [Display(Name = "DDD")]
        public int Ddd { get { return this._ddd; } set { this._ddd = value; } }

        [Display(Name = "Número")]
        public int Numero { get { return this._numero; } set { this._numero = value; } }

        [Display(Name = "Tipo")]
        public TipoTelefone tipo { get; set; }

        public Telefone()
        {
        }

        public Telefone(int ddd, int numero, TipoTelefone tipoTelefone)
        {
            Ddd = ddd;
            Numero = numero;
            tipo = tipoTelefone;
        }

        public Telefone(int ID, int ddd, int numero, TipoTelefone tipoTelefone) : this(ddd, numero, tipoTelefone)
        {
            this.ID = ID;
        }
    }
}