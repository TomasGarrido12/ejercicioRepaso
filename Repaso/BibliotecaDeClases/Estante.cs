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
        public static string MostrarEstante(Estante e, Producto p) // necesito hacer una sobrecargar del metodo MostrarProducto
        {           
              return  ($"La ubicacion del estante es {e.ubicacionDelEstante} y el producto es {p.GetMarca()}");
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool EstaEnElEstante = true;

            foreach (Producto producto in e.productos)
            {
                if (producto == p)
                {
                    return EstaEnElEstante;
                }
            }
            return false;

        }

        public static bool operator !=(Estante e, Producto p) // chequear la logica
        {
            foreach (Producto producto in e.productos)
            {
                if (!(producto==p))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator +(Estante e, Producto p) // me falta la sobre carga de sustraer
        {
            e.productos.Append(p);
            return true;
        }
    }
}
