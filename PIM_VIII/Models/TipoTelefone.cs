namespace PIM_VIII.Models
{
    public class TipoTelefone
    {
        protected int _id;
        private string _tipo;

        public int ID { get { return this._id; } set { this._id = value; } }
        public string Tipo { get { return this._tipo; } set { this._tipo = value; } }

        public TipoTelefone()
        {
        }
        
        public TipoTelefone(string tipo)
        {
            Tipo = tipo;
        }

        public TipoTelefone(int ID, string tipo) : this(tipo)
        {
            this.ID = ID;
        }
    }
}