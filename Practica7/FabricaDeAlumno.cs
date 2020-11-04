using System;

namespace Practica7
{
    public class FabricaDeAlumno: FabricaDeComparables
    { 
        public FabricaDeAlumno(Manejador responsable){
            base.responsable = responsable;
        }

        public override IComparable crearComparable(){
            
            //Crea un Alumno desde archivo
            string nombre = responsable.stringDesdeArchivo(5);
            int dni = (int)responsable.numeroDesdeArchivo(1000);
            int legajo = (int)responsable.numeroDesdeArchivo(2000);
            double promedio = responsable.numeroDesdeArchivo(10);

            return new Alumno(nombre,dni,legajo,promedio);
            
        }

        public override IComparable crearAleatorio(){

            string nombre = responsable.stringAleatorio(5);
            int dni = responsable.numeroAleatorio(1000);
            int legajo = responsable.numeroAleatorio(2000);
            double promedio = responsable.numeroAleatorio(10);

            return new Alumno(nombre,dni,legajo,promedio);
            
        }

        public override IComparable crearPorTeclado(){

            string nombre = responsable.stringPorTeclado();
            int dni = responsable.numeroPorTeclado();
            int legajo = responsable.numeroPorTeclado();
            double promedio = responsable.doublePorTeclado();

            return new Alumno(nombre,dni,legajo,promedio);
        }
        
    }

}