using System;

namespace BibliotecaDeClases
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            return ($"El producto {p.GetMarca()} tiene un precio de {p.GetPrecio()} y un codigo de barras de {p.codigoDeBarra}");
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2) // dos productos van a ser iguales si sus marcas y codigos de barras son iguales
        {
            return p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra;  //preguntar por este metodo la parte de codigoDeBarra
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, string marca) //van a ser igual siempre y cuando la marca de mi objeto sea igual a la marca que le pase como parametro
        {
            return p.marca == marca;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
    }
}
