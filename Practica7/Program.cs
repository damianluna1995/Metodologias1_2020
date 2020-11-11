using System;

namespace Practica7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Teacher t = new Teacher(); 
            IComparable a = (AlumnoProxy)FabricaDeComparables.crearAleatorio(5); //opcion AlumnoProxy
            Student s = new AdaptadorAlumno((IAlumno)a);
            t.goToClass(s);
            t.teachingAClass();*/

            //----- Ejercicio de Examén -----

            Pila p = new Pila();
            Cola c = new Cola();
            ColeccionMultiple cm = new ColeccionMultiple(p,c);
            
            ColeccionMultipleCompuesto cmc = new ColeccionMultipleCompuesto();
            cmc.agregarHijo(p);
            cmc.agregarHijo(c);
            cmc.agregarHijo(cm);

            Llenar(cmc);
            Informar(cmc);

            Console.WriteLine("Pulse una tecla para continuar...");
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

    }

}
