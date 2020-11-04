using System;

namespace Practica7
{
    public class FabricaDeAlumnoComposite: FabricaDeComparables
    {
        public FabricaDeAlumnoComposite(Manejador responsable){
            base.responsable = responsable;
        }

        public override IComparable crearComparable(){
            
            //Crea un AlumnoCompuesto por defecto
            AlumnoComposite alumnoCompuesto = new AlumnoComposite();
            for (int i = 1; i <= 5; i++)
                alumnoCompuesto.agregarHijo((AlumnoProxy)FabricaDeComparables.crearComparable(5));   
                         
            return alumnoCompuesto;
        }

        public override IComparable crearAleatorio(){
            
            AlumnoComposite alumnoCompuesto = new AlumnoComposite();
            for (int i = 1; i <= 5; i++)
                alumnoCompuesto.agregarHijo((AlumnoProxy)FabricaDeComparables.crearAleatorio(5));            
            
            return alumnoCompuesto;
            
        }

        public override IComparable crearPorTeclado(){
            
            AlumnoComposite alumnoCompuesto = new AlumnoComposite();
            for (int i = 1; i <= 5; i++)
                alumnoCompuesto.agregarHijo((AlumnoProxy)FabricaDeComparables.crearPorTeclado(5));            
            
            return alumnoCompuesto;
            
        }
        
    }

}