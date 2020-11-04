using System;

namespace Practica7
{
    public class GeneradorDeDatosAleatorios: Manejador
    {
        private static GeneradorDeDatosAleatorios lector = null;

        private GeneradorDeDatosAleatorios(Manejador siguiente): base(siguiente){ }

        override public int numeroAleatorio(int rangoMaximo)
        {
            Random nroRandom = new Random();
            int numero = nroRandom.Next(0,rangoMaximo);
            return numero;
        }

        override public string stringAleatorio(int cantCaracter) 
        {
            string letras = "abcdefghijklmnopqrstuvwxyz";
            string palAleatorio = "";
            char[] letra = new char[cantCaracter];

            Random indiceAleatorio = new Random();

            for (int i = 0; i < cantCaracter; i++)
                letra[i] = letras[indiceAleatorio.Next(0, letras.Length)];

            for (int i = 0; i < letra.Length; i++)
                palAleatorio += letra[i];

            return palAleatorio;

        }

        public static GeneradorDeDatosAleatorios getInstance(Manejador responsable){
            if(lector == null)
                lector = new GeneradorDeDatosAleatorios(responsable);
            return lector;
        }

    }

}

