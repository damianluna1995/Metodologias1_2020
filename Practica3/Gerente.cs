using System;
using System.Collections.Generic;

namespace Practica3
{
    class Gerente: IObservador
    {
        List<Vendedor> mejores = new List<Vendedor>();

        public List<Vendedor> GetVendedores(){
            return this.mejores;
        }
        
        public void Cerrar(){

            for (int i = 0; i < mejores.Count; i++)
            {
                Console.WriteLine("Nombre: " + mejores[i].getNombre() + " DNI: " + mejores[i].getDNI()
                + " bonus: " + mejores[i].getBonus());
            }
        }

        public void Venta(double monto, Vendedor vendedor){

            if(monto > 5000){
                mejores.Add(vendedor);
                vendedor.aumentaBonus();
            }
        }

        public void Actualizar(IObservado observado){
        	//double monto = ((Vendedor)observado).Venta();
        }

    }
    
}