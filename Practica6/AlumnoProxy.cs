using System;

namespace Practica6
{
    public class AlumnoProxy: IAlumno
    {
        IAlumno alumnoReal = null;
        int opcion;

        public AlumnoProxy(int opcion){
            this.opcion = opcion;
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

        public void setCalificacion(int calif){
            alumnoReal.setCalificacion(calif);
        }

        public int responderPregunta(int pregunta){
            if (alumnoReal == null)
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);

            return alumnoReal.responderPregunta(pregunta);
        }

        public string mostrarCalificacion(){
            return alumnoReal.mostrarCalificacion();
        }

    }

}