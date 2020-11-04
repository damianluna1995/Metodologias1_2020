using System;

namespace Practica7
{
    public class OrdenInicio: IOrdenEnAula1
    {
        Aula aula;

        public OrdenInicio(Aula a){
            this.aula = a;
        }

        public void Ejecutar(){
            aula.Comenzar();
        }
        
    }

}