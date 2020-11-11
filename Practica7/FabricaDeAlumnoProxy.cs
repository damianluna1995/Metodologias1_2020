using System;

namespace Practica7
{
    public class FabricaDeAlumnoProxy: FabricaDeComparables
    {
        Random opcionAzar = new Random();

        public FabricaDeAlumnoProxy(Manejador responsable){
            base.responsable = responsable;
        }

        //Crea un AlumnoProxy desde archivo
        public override IComparable crearComparable(){
            
            int opcion = opcionAzar.Next(3,5);
            string nombre = responsable.stringDesdeArchivo(5);
            int dni = responsable.numeroAleatorio(1000); 

            return new AlumnoProxy(opcion,nombre,dni);

        }

        public override IComparable crearAleatorio(){
            
            int opcion = opcionAzar.Next(3,5);
            string nombre = responsable.stringAleatorio(5);
            int dni = responsable.numeroAleatorio(1000);

            return new AlumnoProxy(opcion,nombre,dni);
        }

        public override IComparable crearPorTeclado(){
            
            int opcion = responsable.numeroPorTeclado();
            string nombre = responsable.stringPorTeclado();
            int dni = responsable.numeroPorTeclado();

            return new AlumnoProxy(opcion,nombre,dni);

        }
        
    }

}