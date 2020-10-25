using System;

namespace Practica4
{
    public class FabricaDeAlumno: FabricaDeComparables
    {
        public override IComparable crearComparable(){
            
            //Crea un Alumno por defecto
            string nombre = "qwerty";
            int dni = 1234;
            int legajo = 111;
            double promedio = 7.8;

            return new Alumno(nombre,dni,legajo,promedio);
            
        }

        public override IComparable crearAleatorio(){
            
            GeneradorDeDatosAleatorios gdda = new GeneradorDeDatosAleatorios();

            string nombre = gdda.stringAleatorio(5);
            int dni = gdda.numeroAleatorio(100);
            int legajo = gdda.numeroAleatorio(200);
            double promedio = gdda.numeroAleatorio(10);

            return new Alumno(nombre,dni,legajo,promedio);
            
        }

        public override IComparable crearPorTeclado(){
            
            LectorDeDatos ldd = new LectorDeDatos();

            string nombre = ldd.stringPorTeclado();
            int dni = ldd.numeroPorTeclado();
            int legajo = ldd.numeroPorTeclado();
            double promedio = ldd.doublePorTeclado();

            return new Alumno(nombre,dni,legajo,promedio);
            
        }
        
    }

}