using System;

namespace encapsular
{
    public class persona{
        private string nombre;
        private DateTime fechNac;
        private int edad;

        public void registrar (string persona){
            nombre = persona;
        }
        public int calcular(DateTime fecha){
            fechNac = fecha;
            edad =  ((TimeSpan)(DateTime.Now-fechNac)).Days;
            return edad;
        }

    }
    public class television{
        private string marca;
        int pulgada , precio;

        public int Pulgada { get{return pulgada;} set{pulgada = Pulgada;} }
        public int Precio { get{return precio;} set{precio = Precio;} }
        public string Marca { get{return marca;} set{marca = Marca;} }

        public int precioSo (int precio){
            this.Precio = precio;
            return Precio;

        }
        public string ReMarca (string marca){
            Marca = marca;
            return Marca;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
           persona p = new persona();
           p.calcular(21/10/2002);
        }
    }
}
