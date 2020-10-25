using System;

namespace Practica7
{
    class LectorDeDatos: Manejador
    {
        static private LectorDeDatos lector = null;

        public LectorDeDatos(Manejador siguiente): base(siguiente){}

        private LectorDeDatos(){}

        override public int numeroPorTeclado(){
            Console.WriteLine("Ingrese numero: ");
            int numero = int.Parse(Console.ReadLine());
            return numero;
        } 

        override public double doublePorTeclado(){
            Console.WriteLine("Ingrese numero: ");
            double numero = double.Parse(Console.ReadLine());
            return numero;
        }

        override public string stringPorTeclado(){
            Console.WriteLine("Ingrese palabra: ");
            string cadena = Console.ReadLine();
            return cadena;
        }

        public static LectorDeDatos getInstance(){
            if(lector == null)
                lector = new LectorDeDatos();
            return lector;
        }

    }
    
}