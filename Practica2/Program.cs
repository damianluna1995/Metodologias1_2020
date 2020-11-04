using System;

namespace Practica2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //----- Ejercicio 1 -----
            /*Alumno a = new Alumno("qqq",123,456,9.0);
            Alumno b = new Alumno("qqq",444,765,8.7);
            
            IEstrategiaDeComparacion e1 = new EstrategiaPorNombre();
            Console.WriteLine(e1.SosIgual(a,b));

            IEstrategiaDeComparacion e2 = new EstrategiaPorDNI();
            Console.WriteLine(e2.SosMayor(a,b));

            IEstrategiaDeComparacion e3 = new EstrategiaPorLegajo();
            Console.WriteLine(e3.SosMenor(a,b));

            IEstrategiaDeComparacion e4 = new EstrategiaPorPromedio();
            Console.WriteLine(e4.SosIgual(a,b));*/


            //----- Ejercicio 2 ----- (Ejercicio 17 de la Practica 1)
            /*Pila pila4 = new Pila();
            Cola cola4 = new Cola();
            ColeccionMultiple colec_mul3 = new ColeccionMultiple(pila4, cola4);
            IEstrategiaDeComparacion iedc = new EstrategiaPorLegajo(); 
            //Estrategia de comparacion por defecto en la Clase Alumno es por Promedio
            LlenarAlumnos(pila4, iedc);
            LlenarAlumnos(cola4, iedc);
            Informar(colec_mul3);*/

            //----- Ejercicio 8 -----

            //Problemas con el diccionario
            IEstrategiaDeComparacion iedc = new EstrategiaPorLegajo();
            
            //Pila pila = new Pila();
            //Cola cola = new Cola();
            //Conjunto conjunto = new Conjunto();
            Diccionario diccionario = new Diccionario();
            //LlenarAlumnos(pila,iedc);
            //LlenarAlumnos(cola,iedc);
            //LlenarAlumnos(conjunto,iedc);
            LlenarAlumnos(diccionario,iedc);
            //ImprimirElementos(pila);
            Console.WriteLine("");
            //ImprimirElementos(cola);
            Console.WriteLine("");
            //ImprimirElementos(conjunto);
            //ImprimirElementos(diccionario);

            //----- Ejercicio 10 -----
            /*IEstrategiaDeComparacion iedc = new EstrategiaPorNombre();
            IEstrategiaDeComparacion iedc2 = new EstrategiaPorLegajo();
            IEstrategiaDeComparacion iedc3 = new EstrategiaPorPromedio();
            IEstrategiaDeComparacion iedc4 = new EstrategiaPorDNI();

            Pila pila = new Pila();
            LlenarAlumnos(pila,iedc);
            CambiarEstrategia(pila, iedc);
            Informar(pila);
            CambiarEstrategia(pila, iedc2);
            Informar(pila);
            CambiarEstrategia(pila, iedc3);
            Informar(pila);
            CambiarEstrategia(pila, iedc4);
            Informar(pila);*/

            
            Console.ReadKey();
        }

        //----- Ejercicio 2 ----- (Modificación del Ejercicio 16 de la Practica 1)
        public static void LlenarAlumnos(IColeccionable coleccionable, IEstrategiaDeComparacion iedc){

            //Revisar la parte de nombres al azar
            int cantVeces = 0; 
            Random r = new Random();
            
            while (cantVeces < 20){
                int dni = r.Next(1,50);
                int leg = r.Next(1,25);
                int prom = r.Next(1,10);
                Alumno comparable = new Alumno("ghijk",dni,leg,prom);
                //Lo que recibe por parametro es una estrategia de comparacion por Legajo
                comparable.setEstrategia(iedc); 
                coleccionable.Agregar(comparable);
                cantVeces ++;
            }

        }

        //----- Metodo Informar del ejercicio 17, Practica 1 -----
        public static void Informar(IColeccionable coleccionable){
            Console.WriteLine("Elementos: " + coleccionable.Cuantos());
            Console.WriteLine("Minimo: " + coleccionable.Minimo()); //Por defecto informa cual es el menor promedio
            Console.WriteLine("Maximo: " + coleccionable.Maximo()); //Por defecto informa cual es el mayor promedio

            Console.WriteLine("Escribir nombre...");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escribir dni...");
            int dni = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribir legajo...");
            int legajo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribir promedio...");
            double promedio = Convert.ToDouble(Console.ReadLine());

            IComparable alumno = new Alumno(nombre,dni,legajo,promedio);
            if (coleccionable.Contiene(alumno))
                Console.WriteLine("El elemento leído esta en la coleccion");
            else
                Console.WriteLine("El elemento leído no está en la colección");

        }

        //----- Ejercicio 7 -----
        public static void ImprimirElementos(Iterable coleccionable){

            Iterador iterador = coleccionable.crearIterador();
            iterador.primero();
            while (!iterador.fin()){
                IComparable comparable = iterador.actual();
                Console.WriteLine(comparable);
                iterador.siguiente();    
            }
        }

        //----- Ejercicio 9 -----
        public static void CambiarEstrategia(Iterable coleccionable, IEstrategiaDeComparacion iedc){
            
            Iterador iterador = coleccionable.crearIterador();
            iterador.primero();
            while (!iterador.fin()){
                IComparable comparable = iterador.actual();
                ((Alumno)comparable).setEstrategia(iedc);
                Console.WriteLine(comparable);
                iterador.siguiente();    
            }            
        }

    }

}