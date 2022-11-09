/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 02/05/2019
 * Time: 15:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Factory_method
{
	public abstract class FabricaDeProfesores
	{
		public const int LOCAL = 1;
		public const int VISITANTE = 2;
		public const int SUPLENTE = 3;
		
		public static int profesorPorDefecto = LOCAL;
		
		public static Profesor crearProfesorPreseteado(){
			return crearProfesor(profesorPorDefecto);
		}
		
		public static Profesor crearProfesor(int queProfesor){
			FabricaDeProfesores fabrica = null;
		
			switch(queProfesor){
				case LOCAL: 
			        fabrica = new FabricaDeProfesorLocal();
			        break;
				case VISITANTE:
			        fabrica = new FabricaDeProfesorVisitante();
			        break;
			    case SUPLENTE:
			        fabrica = new FabricaDeProfesorSuplente();
			        break;
		}
		return fabrica.crearProfesor();
	}
		
	public abstract Profesor crearProfesor();
	
	}


public class FabricaDeProfesorLocal : FabricaDeProfesores{
	override public Profesor crearProfesor(){
		return new ProfesorLocal();
	}
}

public class FabricaDeProfesorVisitante : FabricaDeProfesores{
	override public Profesor crearProfesor(){
		return new ProfesorVisitante();
	}
}

public class FabricaDeProfesorSuplente : FabricaDeProfesores{
	override public Profesor crearProfesor(){
		return new ProfesorSuplente();
	}
}

	}