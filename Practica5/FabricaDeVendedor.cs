using System;

namespace Practica5
{
    public class FabricaDeVendedor: FabricaDeComparables
    {
        public override IComparable crearComparable(){
            
            //Crea un Vendedor por defecto
            string nombre = "qwerty";
            int dni = 1234;
            int sueldo = 1000;

            return new Vendedor(nombre,dni,sueldo);
            
        }

        public override IComparable crearAleatorio(){
            
            GeneradorDeDatosAleatorios gdda = new GeneradorDeDatosAleatorios();

            string nombre = gdda.stringAleatorio(5);
            int dni = gdda.numeroAleatorio(100);
            int sueldo = gdda.numeroAleatorio(1000);

            return new Vendedor(nombre,dni,sueldo);
            
        }

        public override IComparable crearPorTeclado(){
            
            LectorDeDatos ldd = new LectorDeDatos();

            string nombre = ldd.stringPorTeclado();
            int dni = ldd.numeroPorTeclado();
            int sueldo = ldd.numeroPorTeclado();

            return new Vendedor(nombre,dni,sueldo);
            
        }
        
    }

}