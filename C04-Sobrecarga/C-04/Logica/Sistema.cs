using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Sistema
    {
        static Usuario[] registeredUsers;

        static Sistema()
        {
            registeredUsers = new Usuario[8];
        }

        private static void CargarUsuariosHardcodeados()
        {
            registeredUsers[0] = new Usuario("Pepe", "asd123");
            registeredUsers[1] = new Usuario("José", "jose14");
            registeredUsers[2] = new Usuario("Juan", "j_1234");
            registeredUsers[3] = new Usuario("Tito", "22tito");
            registeredUsers[4] = new Usuario("Mari", "Mari03");
            registeredUsers[5] = new Usuario("Tita", "array7");
            registeredUsers[6] = new Usuario("Beba", "bebu77");
            registeredUsers[7] = new Usuario("Elsa", "elsi05");
        }

        public static bool CrearNuevoUsuario(string username, string password)
        {
            //que haya espacio
            //que no exista el usuario

            registeredUsers[7] = new Usuario(username, password);
            return true;
        }

        public static bool ChequearUsuario(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            for (int i = 0; i < registeredUsers.Length; i++)
            {
                if (registeredUsers[i] != null)
                {
                    if (username.Trim().ToLower() == registeredUsers[i].GetUsername().Trim().ToLower())
                    {
                        return registeredUsers[i].ChequearPassword(password);
                    }
                }
            }

            return true;
        }
    }
}
