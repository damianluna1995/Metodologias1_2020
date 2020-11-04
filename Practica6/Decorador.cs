using System;
using System.Collections.Generic;

namespace Practica6
{
    public abstract class Decorador: IAlumno
    {    
        private IAlumno adicional;

        public Decorador(IAlumno a){
            this.adicional = a;
        }

        public string getNombre(){
            return adicional.getNombre();
        }

         public int getDNI(){
            return adicional.getDNI();
        }

        public int getLegajo(){
            return adicional.getLegajo();
        }

        public double getPromedio(){
            return adicional.getPromedio();
        }

        public void setNombre(string n){
            adicional.setNombre(n);
        }

        public void setDNI(int d){ 
            adicional.setDNI(d);
        }

        public void setLegajo(int l){
            adicional.setLegajo(l);
        }

        public void setPromedio(double p){
            adicional.setPromedio(p);
        }

        public int getCalificacion(){
            return adicional.getCalificacion();
        }

        public void setCalificacion(int calif){
            adicional.setCalificacion(calif);
        }

        public int responderPregunta(int pregunta){
            return adicional.responderPregunta(pregunta);
        }

        public virtual string mostrarCalificacion(){
            return adicional.mostrarCalificacion();
        }

        public bool SosIgual(IComparable comparable){
            return adicional.SosIgual(comparable);
        }

        public bool SosMenor(IComparable comparable){
            return adicional.SosMenor(comparable);
        }        

        public bool SosMayor(IComparable comparable){
            return adicional.SosMayor(comparable);
        }

    }

    public class DecNotaEnLetras : Decorador
    {
        string[] numeros = new string[10]{"UNO","DOS","TRES","CUATRO","CINCO",
        "SEIS","SIETE","OCHO","NUEVE","DIEZ"};

        public DecNotaEnLetras(IAlumno a): base(a){}

        override public string mostrarCalificacion(){

            string califDecorada = base.mostrarCalificacion();

            switch (base.getCalificacion())
            {
                case 1:
                    califDecorada = califDecorada + " " + numeros[0];
                    break;
                case 2:
                    califDecorada = califDecorada + " " + numeros[1];
                    break;
                case 3:
                    califDecorada = califDecorada + " " + numeros[2];
                    break;
                case 4:
                    califDecorada = califDecorada + " " + numeros[3];
                    break;
                case 5:
                    califDecorada = califDecorada + " " + numeros[4];
                    break;
                case 6:
                    califDecorada = califDecorada + " " + numeros[5];
                    break;
                case 7:
                    califDecorada = califDecorada + " " + numeros[6];
                    break;
                case 8:
                    califDecorada = califDecorada + " " + numeros[7];
                    break;
                case 9:
                    califDecorada = califDecorada + " " + numeros[8];
                    break;
                case 10:
                    califDecorada = califDecorada + " " + numeros[9];
                    break;
                default:
                    califDecorada = "¡¡ Error !!";
                    break;
            }
            return califDecorada;
        }
    }

    public class DecNotaConLegajo : Decorador
    {
        public DecNotaConLegajo(IAlumno a): base(a){}

        override public string mostrarCalificacion(){

            string califDecorada = base.mostrarCalificacion();
            califDecorada = califDecorada + " " + base.getLegajo();
            return califDecorada;
        }

    }

    public class DecCondicionMateria : Decorador
    {
        public DecCondicionMateria(IAlumno a): base(a){}

        override public string mostrarCalificacion(){
            
            string califDecorada = base.mostrarCalificacion();

            if(base.getCalificacion() > 0 && base.getCalificacion() < 4){
                califDecorada = califDecorada + " (DESAPROBADO)"; 
            }
            if(base.getCalificacion() >= 4  && base.getCalificacion() < 7){
                califDecorada = califDecorada + " (APROBADO)"; 
            }
            if(base.getCalificacion() >= 7 && base.getCalificacion() <= 10){
                califDecorada = califDecorada + " (PROMOCION)"; 
            }
            return califDecorada;
        }
    }

    public class DecNotaEnRecuadro : Decorador
    {
        public DecNotaEnRecuadro(IAlumno a): base(a){}

        override public string mostrarCalificacion(){

            string califDecorada = "******************************************\n" + 
                                   "**  " + base.mostrarCalificacion() + "  **\n" +
                                   "******************************************"; 
            return califDecorada;
        }
    }

}