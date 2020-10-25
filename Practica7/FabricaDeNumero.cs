using System;

namespace Practica7
{
    public class FabricaDeNumero: FabricaDeComparables
    {
        Manejador responsable;

        public override IComparable crearComparable(){
            
            //Creo un comparable desde archivo
            int numero = (int)responsable.numeroDesdeArchivo(1000);
            return new Numero(numero);

        }

        public override IComparable crearAleatorio(){
            
            /*GeneradorDeDatosAleatorios gdda = new GeneradorDeDatosAleatorios();
            int numero = gdda.numeroAleatorio(50); 
            return new Numero(numero);*/

            int numero = responsable.numeroAleatorio(1000);
            return new Numero(numero);

        }

        public override IComparable crearPorTeclado(){

            /*LectorDeDatos ldd = new LectorDeDatos();
            return new Numero(ldd.numeroPorTeclado());*/

            int numero = responsable.numeroPorTeclado();
            return new Numero(numero);
            
        }
        
    }

}