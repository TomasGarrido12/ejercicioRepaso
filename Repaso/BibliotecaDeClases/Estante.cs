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
            string s1 = string.Join("",(Producto)e.productos); //necesito castear los tipos a productos pero no me deja
            //return ($"El estante tiene una ubicacion {e.ubicacionDelEstante} y un producto {e.productos}");
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
            if (e.ubicacionDelEstante > e.productos.Length)
            {
                foreach (Producto producto in e.productos)
                {
                    if (e == p)
                    {
                        return false;
                    }
                }
                e.productos.Append(p);
                return true;
            }
            return false;

        }
    }
}
