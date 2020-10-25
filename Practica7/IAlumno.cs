using System;

namespace Practica7
{
    public interface IAlumno: IComparable
    {
        string getNombre();
        int getDNI();
        int getLegajo();
        double getPromedio();
        int getCalificacion();
        void setNombre(string nombre);
        void setDNI(int dni);
        void setLegajo(int legajo);
        void setPromedio(double promedio);
        void setCalificacion(int calif);
        int responderPregunta(int pregunta);
        string mostrarCalificacion();

    }

}