using System;

namespace Practica6
{
    public class FabricaDeAlumnoProxy: FabricaDeComparables
    {
        public override IComparable crearComparable(){
            
            //Crea un AlumnoProxy por defecto
            Random opcionAzar = new Random();

            int opcion = opcionAzar.Next(3,5);
            string nombre = "qwerty";
            int dni = 1234;

            return new AlumnoProxy(opcion,nombre,dni);

        }

        public override IComparable crearAleatorio(){
            
            GeneradorDeDatosAleatorios g = new GeneradorDeDatosAleatorios();
            Random opcionAzar = new Random();
            
            int opcion = opcionAzar.Next(3,5);
            string nombre = g.stringAleatorio(5);
            int dni = g.numeroAleatorio(1000);

            return new AlumnoProxy(opcion,nombre,dni);
        }

        public override IComparable crearPorTeclado(){
            
            LectorDeDatos ldd = new LectorDeDatos();

            int opcion = ldd.numeroPorTeclado();
            string nombre = ldd.stringPorTeclado();
            int dni = ldd.numeroPorTeclado();

            return new AlumnoProxy(opcion,nombre,dni);

        }
        
    }

}