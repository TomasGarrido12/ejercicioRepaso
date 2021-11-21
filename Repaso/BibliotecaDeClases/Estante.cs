using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Estante
    {
        private int ubicacionDelEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionDelEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return productos;
        }
        public static string MostrarEstante(Estante e)
        {
            return ($"La ubicacion del estante es {e.ubicacionDelEstante} y el producto es {e.GetProductos()}");
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool noEstaEnElEstante = true;

            foreach (Producto producto in e.productos)
            {
                if (producto == p)
                {
                    noEstaEnElEstante = false;
                    break;
                }
            }
            if (noEstaEnElEstante)
            {
                return noEstaEnElEstante;
            }
            return false;

        }

        public static bool operator !=(Estante e, Producto p)
        {
            bool EstaEnElEstante = false;

            foreach (Producto producto in e.productos)
            {
                if (producto != p)
                {
                    EstaEnElEstante = true;
                    break;
                }
            }
            if (EstaEnElEstante)
            {
                return EstaEnElEstante;
            }
            return true;
        }

        public static bool operator +(Estante e, Producto p)
        {
            e.productos.Append(p);
            return true;
        }
    }
}
