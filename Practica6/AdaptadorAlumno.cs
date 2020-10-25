using System;

namespace Practica6
{
	
	public class AdaptadorAlumno: Student
	{
		Alumno alumno;
		
		public AdaptadorAlumno(Alumno a){
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

	public class AdaptadorAME: Student
	{
		AlumnoMuyEstudioso ame;
		
		public AdaptadorAME(AlumnoMuyEstudioso a){
			this.ame = a;
		}
		
		public string getName(){
			return ame.getNombre();
		}
		
		public int yourAnswerIs(int question){
			return ame.responderPregunta(question);
		}
		
		public void setScore(int score){
			ame.setCalificacion(score);
		}
		
		public string showResult(){
			return ame.mostrarCalificacion();
		}
		
		public bool equals(Student student){
			return ame.SosIgual(((AdaptadorAME)student).ame);
		}
		
		public bool lessThan(Student student){
			return ame.SosMenor(((AdaptadorAME)student).ame);
		}
		
		public bool greaterThan(Student student){
			return ame.SosMayor(((AdaptadorAME)student).ame);
		}

	}
	
}
