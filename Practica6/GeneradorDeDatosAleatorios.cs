using System;

namespace Practica6
{
    class GeneradorDeDatosAleatorios
    {
        public GeneradorDeDatosAleatorios(){}

        public int numeroAleatorio(int rangoMaximo)
        {
            Random nroRandom = new Random();
            int numero = nroRandom.Next(1,rangoMaximo);
            return numero;
        }

        public string stringAleatorio(int cantCaracter)
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

    }

}

