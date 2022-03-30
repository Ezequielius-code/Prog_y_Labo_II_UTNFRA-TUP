using System;

namespace BibliotecaDeClases
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta() 
        {
            return tinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            short tintaDisponible = GetTinta();

            dibujo = "";

            if (tintaDisponible == 0)
            {
                return false;
            }

            for (int i = 0; i < gasto; i++)
            {
                if (tintaDisponible == 0)
                {
                    break;
                }

                dibujo += "*";
                tintaDisponible--;
            }

            SetTinta(tintaDisponible);
            return true;
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        private void SetTinta(short tinta)
        {
            if (tinta >= 0 && tinta <= cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }
        }
    }
}
