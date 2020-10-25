using System;

namespace Practica3
{
    class Diccionario: IColeccionable, Iterable
    {
        ClaveValor claveValor;
        private Conjunto diccionario;
        private int contador = 0;

        public Diccionario(){
            diccionario = new Conjunto();
        }

        public Conjunto GetConjunto(){
            return this.diccionario;
        }

        public void agregar(IComparable clave, IComparable valor){

            claveValor = new ClaveValor(clave,valor);

            if(!diccionario.Pertenece(clave))
                diccionario.Agregar((IComparable)claveValor);
            else{
            	Console.WriteLine("Escriba nueva clave...");
            	int nuevaClave = int.Parse(Console.ReadLine());
            	claveValor.setClave(new Numero(nuevaClave));
            }
            
        }

        public IComparable valorDe(IComparable clave){

            for (int i = 0; i < diccionario.Cuantos(); i++)
                if(claveValor.SosIgual(clave))
                    return claveValor.getVal();
            
            return null;
        }

        public int Cuantos(){
            return diccionario.Cuantos();
        }

        public IComparable Minimo(){
            return diccionario.Minimo();
        }

        public IComparable Maximo(){
            return diccionario.Maximo();
        }

        public void Agregar(IComparable comparable){
            IComparable clave = new Numero(contador);
            agregar(clave,comparable);
            contador++;
        }

        public bool Contiene(IComparable comparable){
            return diccionario.Contiene(comparable);
        }

		public Iterador crearIterador(){
        	return new IteradorDiccionario(diccionario);
        }
        
    }

    class ClaveValor: IComparable
    {
        private IComparable clave;
        private IComparable valor;

        public ClaveValor(IComparable cla, IComparable va){
            this.clave = cla;
            this.valor = va;
        }

        public IComparable getClave(){
            return this.clave;
        }

        public IComparable getVal(){
            return this.valor;
        }

        public void setClave(IComparable comparable){
            this.clave = comparable;
        }

        public bool SosIgual(IComparable comparable){
            return this.clave.SosIgual(comparable);
        }

        public bool SosMenor(IComparable comparable){
            return this.clave.SosMenor(comparable);
        }

        public bool SosMayor(IComparable comparable){
            return this.clave.SosMayor(comparable);
        }

    }

}