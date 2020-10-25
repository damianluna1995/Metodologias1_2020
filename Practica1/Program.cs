using System;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            //----- Ejercicio 7 -----
            /*Pila pila1 = new Pila();
            Cola cola1 = new Cola();
            Llenar(pila1);
            Llenar(cola1);
            Informar(pila1);
            Informar(cola1);*/ 

            //----- Ejercicio 9 -----
            /*Pila pila2 = new Pila();
            Cola cola2 = new Cola();
            ColeccionMultiple colec_mul1 = new ColeccionMultiple(pila2, cola2);
            Llenar(pila2);
            Llenar(cola2);
            Informar(pila2);
            Informar(cola2);
            Informar(colec_mul1);*/

            //----- Ejercicio 13 -----
            /*Pila pila3 = new Pila();
            Cola cola3 = new Cola();
            ColeccionMultiple colec_mul2 = new ColeccionMultiple(pila3, cola3);
            LlenarPersonas(pila3);
            LlenarPersonas(cola3);
            InformarPersona(colec_mul2);*/

            //----- Ejercicio 17 -----
            /*Pila pila4 = new Pila();
            Cola cola4 = new Cola();
            ColeccionMultiple colec_mul3 = new ColeccionMultiple(pila4, cola4);
            LlenarAlumnos(pila4);
            LlenarAlumnos(cola4);
            InformarAlumno(colec_mul3);*/

            Console.ReadKey();

        }

        //----- Ejercicio 5 -----
        public static void Llenar(IColeccionable coleccionable){

            int cantVeces = 0; 
            Random r = new Random();
            
            while (cantVeces < 20){
                int nro = r.Next(1,50);
                IComparable comparable = new Numero(nro);
                coleccionable.Agregar(comparable);
                cantVeces ++;
            }

        }

        //----- Ejercicio 6 -----
        public static void Informar(IColeccionable coleccionable){
            Console.WriteLine("Elementos: " + coleccionable.Cuantos());
            Console.WriteLine("Minimo: " + coleccionable.Minimo()); 
            Console.WriteLine("Maximo: " + coleccionable.Maximo()); 
            Console.WriteLine("Escribir numero...");

            int valor = Convert.ToInt32(Console.ReadLine());

            IComparable numero = new Numero(valor);
            if (coleccionable.Contiene(numero))
                Console.WriteLine("El elemento leído esta en la coleccion");
            else
                Console.WriteLine("El elemento leído no está en la colección");

        }

        //----- Ejercicio 12 -----
        public static void LlenarPersonas(IColeccionable coleccionable){
            //Revisar la parte de nombres al azar
            Random r = new Random();
            int cantVeces = 0; 
            
            while (cantVeces < 20){

                int dni = r.Next(1,50);
                IComparable comparable = new Persona("abcdef",dni);
                coleccionable.Agregar(comparable);
                cantVeces ++;
            }

        }

        //----- Ejercicio 16 -----
        public static void LlenarAlumnos(IColeccionable coleccionable){
            //Revisar la parte de nombres al azar
            int cantVeces = 0; 
            Random r = new Random();
            
            while (cantVeces < 20){
                int dni = r.Next(1,50);
                int leg = r.Next(1,25);
                int prom = r.Next(1,10);
                IComparable comparable = new Alumno("ghijk",dni,leg,prom);
                coleccionable.Agregar(comparable);
                cantVeces ++;
            }

        }

        //----- Metodo Informar para el ejercicio 13 -----
        public static void InformarPersona(IColeccionable coleccionable){
            Console.WriteLine("Elementos: " + coleccionable.Cuantos());
            Console.WriteLine("Minimo: " + coleccionable.Minimo()); //menor dni
            Console.WriteLine("Maximo: " + coleccionable.Maximo()); //mayor dni

            Console.WriteLine("Escribir nombre...");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escribir dni...");
            int dni = Convert.ToInt32(Console.ReadLine());

            IComparable persona = new Persona(nombre,dni);
            if (coleccionable.Contiene(persona))
                Console.WriteLine("El elemento leído esta en la coleccion");
            else
                Console.WriteLine("El elemento leído no está en la colección");

        }

        //----- Metodo Informar para el ejercicio 17 -----
        public static void InformarAlumno(IColeccionable coleccionable){
            Console.WriteLine("Elementos: " + coleccionable.Cuantos());
            Console.WriteLine("Minimo: " + coleccionable.Minimo()); //menor promedio
            Console.WriteLine("Maximo: " + coleccionable.Maximo()); //mayor promedio

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

    }

}
