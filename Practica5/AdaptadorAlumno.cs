using System;

namespace Practica5
{
	
	public class AdaptadorAlumno: Student
	{
		IAlumno alumno;
		
		public AdaptadorAlumno(IAlumno a){
			this.alumno = a;
		}
		
		public string getName(){
			return alumno.getNombre();
		}
		
		public int yourAnswerIs(int question){
			return alumno.responderPregunta(question);
		}
		
		public void setScore(int score){
			alumno.setCalificacion(score);
		}
		
		public string showResult(){
			return alumno.mostrarCalificacion();
		}
		
		public bool equals(Student student){
			return alumno.SosIgual(((AdaptadorAlumno)student).alumno);
		}
		
		public bool lessThan(Student student){
			return alumno.SosMenor(((AdaptadorAlumno)student).alumno);
		}
		
		public bool greaterThan(Student student){
			return alumno.SosMayor(((AdaptadorAlumno)student).alumno);
		}
		
	}
	
}
