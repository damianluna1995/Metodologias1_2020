using System;
using System.Collections.Generic;

namespace Practica4
{
    class Vendedor: Persona, IObservado
    {
        private int sueldoBasico;
        private double bonus;
        List<IObservador> observadores = new List<IObservador>();

        public Vendedor(string n, int d, int s): base(n,d){
            this.sueldoBasico = s;
            bonus = 1;
        }

        public double Venta(int monto){
            //Console.WriteLine(monto);
            this.Notificar();
            return monto; 
        }

        public void aumentaBonus(){
            bonus *= 1.10;
        }

        public double getBonus(){
            return this.bonus;
        }
        
        public new bool SosIgual(IComparable comparable){
            if (this.bonus == ((Vendedor)comparable).getBonus())
                return true;
            else
                return false;
        }

        public new bool SosMenor(IComparable comparable){
            if (this.bonus < ((Vendedor)comparable).getBonus())
                return true;
            else
                return false;
        }
        
        public new bool SosMayor(IComparable comparable){
            if (this.bonus > ((Vendedor)comparable).getBonus())
                return true;
            else
                return false;
        }

        public override string ToString() {
            return base.nombre.ToString() + " " + base.dni.ToString() + " " + this.sueldoBasico.ToString() 
            + " " + this.bonus.ToString();
        }
        
        public void Notificar(){
        	foreach(IObservador observador in observadores)
        		observador.Actualizar(this);
        }
        
        public void Agregar(IObservador observador){
        	foreach(IObservador obser in observadores)
        		observadores.Add(obser);
        }

    }

}