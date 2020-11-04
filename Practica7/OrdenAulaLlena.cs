using System;

namespace Practica7
{
    public class OrdenAulaLlena: IOrdenEnAula1
    {
        Aula aula;

        public OrdenAulaLlena(Aula a){
            this.aula = a;
        }

        public void Ejecutar(){
            aula.ClaseLista();
        }
        
    }

}