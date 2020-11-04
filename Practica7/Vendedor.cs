using System;
using System.Collections.Generic;

namespace Practica7
{
    public class Vendedor: Persona, IObservado
    {
        private int sueldoBasico;
        private double bonus;
        private int monto;
        List<IObservador> observadores = new List<IObservador>();

        public Vendedor(string n, int d, int s): base(n,d){
            this.sueldoBasico = s;
            bonus = 1;
        }

        public void Venta(int monto){
            this.Notificar();
            this.monto = monto; 
        }

        public void aumentaBonus(){
            bonus *= 1.10;
        }

        public int getSueldoBasico(){
            return this.sueldoBasico;
        }

        public double getBonus(){
            return this.bonus;
        }

        public int getMonto(){
            return this.monto;
        }

        public void setSueldoBasico(int sueldo){
            this.sueldoBasico = sueldo;
        }

        public void setBonus(double bonus){
            this.bonus = bonus;
        }
        
        public void setMonto(int monto){
            this.monto = monto;
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
        	observadores.Add(observador);
        }

    }

}