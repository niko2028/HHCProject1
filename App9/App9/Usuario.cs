using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace App9
{
    class Usuario
    {
        public Usuario()
        {

        }
        [PrimaryKey, AutoIncrement]
        public int IdUsuario { set; get; }
        [Unique]
        public string Mail { set; get; }
        public string Clave { set; get; }
        public string EMail
        {
            get { return string.Format("{0}", this.Mail); }
        }
        public string ClaveEdited
        {
            get { return string.Format("{0}", this.Clave); }
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}", EMail, ClaveEdited);
        }
    }
}
