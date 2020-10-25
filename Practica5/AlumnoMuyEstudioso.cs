using System;

namespace Practica5
{
	
	public class AlumnoMuyEstudioso: Alumno
	{
		public AlumnoMuyEstudioso(string n, int d, int l, double p): base(n,d,l,p){}
		
		override public int responderPregunta(int pregunta){
			return pregunta % 3;
		}

		
	}
}
