using System;

namespace Practica7
{
    public abstract class FabricaDeComparables: IFabricaDeComparables 
    {
        protected Manejador responsable;

        public static IComparable crearComparable(int opcion){

            FabricaDeComparables fabrica = null;

            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeNumero(crearCadenaDeResp());
                    break;
                case 2:
                    fabrica = new FabricaDeVendedor(crearCadenaDeResp());
                    break;
                case 3:
                    fabrica = new FabricaDeAlumno(crearCadenaDeResp());
                    break;
                case 4:
                    fabrica = new FabricaDeAME(crearCadenaDeResp());
                    break;
                case 5:
                    fabrica = new FabricaDeAlumnoProxy(crearCadenaDeResp());
                    break;
                case 6:
                    fabrica = new FabricaDeAlumnoComposite(crearCadenaDeResp());
                    break;
            }
            return fabrica.crearComparable();
        }

        public static IComparable crearAleatorio(int opcion){

            FabricaDeComparables fabrica = null;

            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeNumero(crearCadenaDeResp());
                    break;
                case 2:
                    fabrica = new FabricaDeVendedor(crearCadenaDeResp());
                    break;
                case 3:
                    fabrica = new FabricaDeAlumno(crearCadenaDeResp());
                    break;
                case 4:
                    fabrica = new FabricaDeAME(crearCadenaDeResp());
                    break;
                case 5:
                    fabrica = new FabricaDeAlumnoProxy(crearCadenaDeResp());
                    break;
                case 6:
                    fabrica = new FabricaDeAlumnoComposite(crearCadenaDeResp());
                    break;
            }
            return fabrica.crearAleatorio();
        }

        public static IComparable crearPorTeclado(int opcion){

            FabricaDeComparables fabrica = null;
                
            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeNumero(crearCadenaDeResp());
                    break;
                case 2:
                    fabrica = new FabricaDeVendedor(crearCadenaDeResp());
                    break;
                case 3:
                    fabrica = new FabricaDeAlumno(crearCadenaDeResp());
                    break;
                case 4:
                    fabrica = new FabricaDeAME(crearCadenaDeResp());
                    break;
                case 5:
                    fabrica = new FabricaDeAlumnoProxy(crearCadenaDeResp());
                    break;
                case 6:
                    fabrica = new FabricaDeAlumnoComposite(crearCadenaDeResp());
                    break;
            }
            return fabrica.crearPorTeclado();
        }

        private static Manejador crearCadenaDeResp(){

            Manejador manejador = GeneradorDeDatosAleatorios.getInstance(null);

            manejador = LectorDeArchivos.getInstance(manejador);

            manejador = LectorDeDatos.getInstance(manejador); 

            return manejador;

        }

        public abstract IComparable crearComparable();

        public abstract IComparable crearAleatorio();

        public abstract IComparable crearPorTeclado();

    }

}