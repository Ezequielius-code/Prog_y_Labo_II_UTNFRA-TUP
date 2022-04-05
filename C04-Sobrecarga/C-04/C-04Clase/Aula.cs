using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_04Clase
{
    public class Aula
    {
        private Persona[] personas;

        public Aula()
        {
            personas = new Persona[4];
        }

        public static Aula operator + (Aula aula, Persona persona)
        {
            if (persona != aula)
            {
                for (int i = 0; i < aula.personas.Length; i++)
                {
                    if (aula.personas[i] is null)
                    {
                        aula.personas[i] = persona;
                        return aula;
                    }
                }
            }

            return aula;
        }
        public static bool operator + (Persona persona, Aula aula)
        {
            if (persona != aula)
            {
                for (int i = 0; i < aula.personas.Length; i++)
                {
                    if (aula.personas[i] is null)
                    {
                        aula.personas[i] = persona;
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator == (Persona persona, Aula aula)
        {
            for (int i = 0; i < aula.personas.Length; i++)
            {
                if (aula.personas[i] == persona)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static bool operator != (Persona persona, Aula aula)
        {
            return !(persona == aula);
        }
    }
}
