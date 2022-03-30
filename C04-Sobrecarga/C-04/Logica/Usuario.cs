using System;

namespace Logica
{
    public class Usuario
    {
        private string username;
        private string password;

        public Usuario(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string GetUsername()
        {
            return username;
        }

        internal bool ChequearPassword(string password)
        {
            return this.password == password;
        }
    }
}
