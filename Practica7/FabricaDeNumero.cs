using System;

namespace Practica7
{
    public class FabricaDeNumero: FabricaDeComparables
    {
 
        public FabricaDeNumero(Manejador responsable){
            base.responsable = responsable;
        }

        public override IComparable crearComparable(){
            
            //Creo un Numero desde archivo
            int numero = (int)responsable.numeroDesdeArchivo(1000);
            return new Numero(numero);

        }

        public override IComparable crearAleatorio(){

            int numero = responsable.numeroAleatorio(1000);
            return new Numero(numero);

        }

        public override IComparable crearPorTeclado(){

            int numero = responsable.numeroPorTeclado();
            return new Numero(numero);
            
        }
        
    }

}