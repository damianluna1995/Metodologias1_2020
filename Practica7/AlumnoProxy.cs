using System;

namespace Practica7
{
    public class AlumnoProxy: IAlumno
    {
        IAlumno alumnoReal = null;
        int opcion;
        string nombre; 
        int dni; 
        
        public AlumnoProxy(int opcion, string nombre, int dni){
            this.opcion = opcion;
            this.nombre = nombre;
            this.dni = dni; 
        }

        public string getNombre(){ 
            return nombre; 
        }

        public int getDNI(){
            return dni;
        }

        public int getLegajo(){
            return alumnoReal.getLegajo();
        }

        public double getPromedio(){
            return alumnoReal.getPromedio();
        }

        public int getCalificacion(){
            return alumnoReal.getCalificacion();
        }

        public void setNombre(string n){
            alumnoReal.setNombre(n);
        }

        public void setDNI(int d){
            alumnoReal.setDNI(d);
        }

        public void setLegajo(int l){ 
            alumnoReal.setLegajo(l);
        }
        
        public void setPromedio(double p){
            alumnoReal.setPromedio(p);
         }

        public void setCalificacion(int calif){
            alumnoReal.setCalificacion(calif);
        }

        public int responderPregunta(int pregunta){
            if (alumnoReal == null)
                if(opcion == 2){
                    GeneradorDeDatosAleatorios g = GeneradorDeDatosAleatorios.getInstance();
                    alumnoReal = new Alumno(nombre, dni, g.numeroAleatorio(1000), g.numeroAleatorio(10));
                }
                if(opcion == 4){
                    GeneradorDeDatosAleatorios g = GeneradorDeDatosAleatorios.getInstance();
                    alumnoReal = new AlumnoMuyEstudioso(nombre, dni, g.numeroAleatorio(1000), g.numeroAleatorio(10));
                }

            return alumnoReal.responderPregunta(pregunta);
        }

        public string mostrarCalificacion(){
            return alumnoReal.mostrarCalificacion();
        }

        public bool SosIgual(IComparable comparable){
            return alumnoReal.SosIgual(comparable);
        }

        public bool SosMayor(IComparable comparable){
            return alumnoReal.SosMayor(comparable);
        }

        public bool SosMenor(IComparable comparable){
            return alumnoReal.SosMenor(comparable);
        }

    }

}