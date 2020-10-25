using System;

namespace Practica3
{
	class Program
	{
		public static void Main(string[] args)
		{
			//----- Ejercicio 9 -----
			IColeccionable cola = new Cola();
			//Opcion 1, crea Numeros. Opcion 2, crea Alumnos. Opcion 3, crea Vendedores
			Llenar(cola,2);
			Informar(cola,2);
			
			//----- Ejercicio 14 -----
            /*Cola vendedores = new Cola();
            Gerente gerente = new Gerente();
            Llenar(vendedores,3);            //Opcion 3 es para crear Vendedores
            //hacer que gerente sea observador de todos los vendedores
            jornadaDeVentas(vendedores);
            gerente.Cerrar();*/
            
            
			Console.WriteLine("Pulse una tecla para continuar...");
			Console.ReadKey();
		}
		
		//----- Ejercicio 6 -----
		public static void Llenar(IColeccionable coleccionable, int opcion){

			int cantVeces = 0;
			
			while (cantVeces < 20){
				IComparable comparable = FabricaDeComparables.crearAleatorio(opcion);
				coleccionable.Agregar(comparable);
				cantVeces ++;
			}

		}

		//----- Ejercicio 6 -----
		public static void Informar(IColeccionable coleccionable, int opcion){
			Console.WriteLine("Elementos: " + coleccionable.Cuantos());
			Console.WriteLine("Minimo: " + coleccionable.Minimo());
			Console.WriteLine("Maximo: " + coleccionable.Maximo());
			
			IComparable comparable = FabricaDeComparables.crearPorTeclado(opcion);

			if (coleccionable.Contiene(comparable))
				Console.WriteLine("El elemento leído esta en la coleccion");
			else
				Console.WriteLine("El elemento leído no está en la colección");

		}
		
		//----- Ejercicio 13 -----
		public static void jornadaDeVentas(Iterable vendedores){
			
			int cantVeces = 0;
			Iterador iterador = vendedores.crearIterador();
			Random nroAzar = new Random();
			
			while(cantVeces < 20){
				iterador.primero();
				while(!iterador.fin()){
					IComparable vendedor = iterador.actual();
					int monto = nroAzar.Next(1,10000);
					((Vendedor)vendedor).Venta(monto);
					iterador.siguiente();
				}
				cantVeces++;
			}
		}
		
	}
	
}