using System;

namespace Practica6
{
    public interface IAlumno
    {
        int getLegajo();
        double getPromedio();
        int getCalificacion();
        void setCalificacion(int calif);
        int responderPregunta(int pregunta);
        string mostrarCalificacion();

    }

}