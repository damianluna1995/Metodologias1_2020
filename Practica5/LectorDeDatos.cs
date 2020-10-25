using System;

namespace Practica5
{
    class LectorDeDatos
    {
        public LectorDeDatos(){}

        public int numeroPorTeclado(){
            Console.WriteLine("Ingrese numero: ");
            int numero = int.Parse(Console.ReadLine());
            return numero;
        } 

        public double doublePorTeclado(){
            Console.WriteLine("Ingrese numero: ");
            double numero = double.Parse(Console.ReadLine());
            return numero;
        }

        public string stringPorTeclado(){
            Console.WriteLine("Ingrese palabra: ");
            string cadena = Console.ReadLine();
            return cadena;
        }

    }
    
}