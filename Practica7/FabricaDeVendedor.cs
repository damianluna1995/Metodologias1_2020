using System;

namespace Practica7
{
    public class FabricaDeVendedor: FabricaDeComparables
    {
        Manejador responsable;

        public override IComparable crearComparable(){
            
            //Crea un Vendedor desde archivo
            string nombre = responsable.stringDesdeArchivo(5);
            int dni = (int)responsable.numeroDesdeArchivo(1000);
            int sueldo = (int)responsable.numeroDesdeArchivo(5000);

            return new Vendedor(nombre,dni,sueldo);
            
        }

        public override IComparable crearAleatorio(){
            
            /*GeneradorDeDatosAleatorios gdda = new GeneradorDeDatosAleatorios();
            string nombre = gdda.stringAleatorio(5);
            int dni = gdda.numeroAleatorio(100);
            int sueldo = gdda.numeroAleatorio(1000);
            return new Vendedor(nombre,dni,sueldo);*/

            string nombre = responsable.stringAleatorio(5);
            int dni = responsable.numeroAleatorio(100);
            int sueldo = responsable.numeroAleatorio(1000);

            return new Vendedor(nombre,dni,sueldo);
            
        }

        public override IComparable crearPorTeclado(){
            
            /*LectorDeDatos ldd = new LectorDeDatos();
            string nombre = ldd.stringPorTeclado();
            int dni = ldd.numeroPorTeclado();
            int sueldo = ldd.numeroPorTeclado();
            return new Vendedor(nombre,dni,sueldo);*/

            string nombre = responsable.stringPorTeclado();
            int dni = responsable.numeroPorTeclado();
            int sueldo = responsable.numeroPorTeclado();
            
            return new Vendedor(nombre,dni,sueldo);
            
        }
        
    }

}