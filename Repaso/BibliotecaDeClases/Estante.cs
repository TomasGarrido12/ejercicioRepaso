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
        public Producto[] productos;

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
        public static string MostrarEstante(Estante e) // necesito hacer una sobrecargar del metodo MostrarProducto. Quiero hacer un join con todos los elementos del array producto pero no se como
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"La ubicacion es: {e.ubicacionDelEstante}");
            for (int i = 0; i < e.productos.Length; i++)
            {
                sb.AppendLine(Producto.MostrarProducto(e.productos[i]));
            }
            return sb.ToString();
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

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p) // me falta la sobre carga de sustraer
        {
            if (e != p)//con la sobrecarga del != recorro el array de productos y me fijo que el producto no esté en el estante
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)// me fijo que en la posicion del array de productos en la cual estoy parado haya un espacio, en caso de haberlo agrego un producto en esa posicion
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
