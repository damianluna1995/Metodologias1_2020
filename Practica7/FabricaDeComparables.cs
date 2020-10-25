using System;

namespace Practica7
{
    public abstract class FabricaDeComparables: IFabricaDeComparables
    {
        public static IComparable crearComparable(int opcion){

            FabricaDeComparables fabrica = null;

            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeNumero();
                    break;
                case 2:
                    fabrica = new FabricaDeAlumno();
                    break;
                case 3:
                    fabrica = new FabricaDeVendedor();
                    break;
                case 4:
                    fabrica = new FabricaDeAME();
                    break;
            }
            return fabrica.crearComparable();
        }

        public static IComparable crearAleatorio(int opcion){

            FabricaDeComparables fabrica = null;

            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeNumero();
                    break;
                case 2:
                    fabrica = new FabricaDeAlumno();
                    break;
                case 3:
                    fabrica = new FabricaDeVendedor();
                    break;
                case 4:
                    fabrica = new FabricaDeAME();
                    break;
            }
            return fabrica.crearAleatorio();
        }

        public static IComparable crearPorTeclado(int opcion){

            FabricaDeComparables fabrica = null;

            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeNumero();
                    break;
                case 2:
                    fabrica = new FabricaDeAlumno();
                    break;
                case 3:
                    fabrica = new FabricaDeVendedor();
                    break;
                case 4:
                    fabrica = new FabricaDeAME();
                    break;
            }
            return fabrica.crearPorTeclado();
        }

        public abstract IComparable crearComparable();

        public abstract IComparable crearAleatorio();

        public abstract IComparable crearPorTeclado();

    }

}