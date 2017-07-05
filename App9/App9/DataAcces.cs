using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite.Net;
using System.IO;

namespace App9
{
    class DataAcces : IDisposable
    {
        private SQLiteConnection connection;

        public DataAcces()
        {
            var config = DependencyService.Get<IConfig>();
            connection = new SQLiteConnection(config.Plataforma,
            System.IO.Path.Combine(config.DirectorioDB, "Usuario.db3"));
            connection.CreateTable<Usuario>();
        }
        public void InsertUsuario(Usuario usuario)
        {
            connection.Insert(usuario);
        }
        public void UpdateUsuario(Usuario usuario)
        {
            connection.Update(usuario);
        }
        public void DeleteUsuario(Usuario usuario)
        {
            connection.Delete(usuario);
        }
        public Usuario GetUsuario(string mail)
        {

            return connection.Table<Usuario>().FirstOrDefault(c => c.Mail == mail);
        }
        public List<Usuario> GetUsuarios(string mail)
        {

            return connection.Table<Usuario>().OrderBy(c => c.Mail).ToList();
        }
        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
