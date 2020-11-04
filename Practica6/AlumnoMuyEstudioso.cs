using System;

namespace Practica6
{
	
	public class AlumnoMuyEstudioso: Alumno, IAlumno
	{
		public AlumnoMuyEstudioso(string n, int d, int l, double p): base(n,d,l,p){}
		
		public override int responderPregunta(int pregunta){
			return pregunta % 3;
		}

		
	}
}
