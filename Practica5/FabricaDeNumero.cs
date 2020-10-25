using System;

namespace Practica5
{
    public class FabricaDeNumero: FabricaDeComparables
    {
        public override IComparable crearComparable(){
            
            //Creo un comparable por defecto
            int numero = 1;
            return new Numero(numero);
        }

        public override IComparable crearAleatorio(){
            
            GeneradorDeDatosAleatorios gdda = new GeneradorDeDatosAleatorios();
            int numero = gdda.numeroAleatorio(50); 
            return new Numero(numero); // retorna un numero del 1 al 50
        }

        public override IComparable crearPorTeclado(){

            LectorDeDatos ldd = new LectorDeDatos();
            return new Numero(ldd.numeroPorTeclado());
        }
        
    }

}