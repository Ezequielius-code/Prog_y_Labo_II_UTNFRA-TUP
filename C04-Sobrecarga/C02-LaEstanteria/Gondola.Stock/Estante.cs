using System;
using System.Text;

namespace Gondola.Stock
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder detalleEstante = new StringBuilder();
            detalleEstante.AppendLine("*********************************************************************************");
            detalleEstante.AppendLine($"*\t\t\t\tUbicación estante: {e.ubicacionEstante}\t\t\t\t*");
            detalleEstante.AppendLine("*********************************************************************************");

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] is not null)
                {
                    detalleEstante.AppendLine(Producto.MostrarProducto(e.productos[i]));
                    detalleEstante.AppendLine("---------------------------------------------------------------------------------");
                }
            }

            return detalleEstante.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            if (e is not null && p is not null)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if (e.productos is not null)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e == p)
                    {
                        e.productos[i] = null;
                        break;
                    }
                }
            }
            return e;
        }
    }
}
