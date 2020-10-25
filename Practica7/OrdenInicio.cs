using System;

namespace Practica7
{
    class OrdenInicio: IOrdenEnAula1
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