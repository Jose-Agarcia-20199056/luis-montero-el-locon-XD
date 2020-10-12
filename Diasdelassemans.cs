using System;
					
public class Program
{
	public static void Main()
	{     // dias de la semana
		   
	  // declaracion de variables
		int num;
		// datos mostrados por pantalla 
		Console.WriteLine("presione las siguientes opciones para mostrar los dias de las seman ");
		Console.WriteLine(" ");// esto lo aplicamos para un salto de linea
	    Console.WriteLine("presione 1=lunes,2=martes,3=miercoles,4=jueves,5=viernes,6=sabado,7=domingo: ");
		num = int.Parse(Console.ReadLine()); // aqui guadamos en esta variable el dato ingresado por telcado
		Console.WriteLine(" ");
		// condicionales 
		if(num ==1){
			
		 Console.WriteLine("el dia de la semana selecionado es: lunes ");
		}
		
		else if(num == 2){
			
		Console.WriteLine("el dia de la semana selecionado es: martes ");
			
		}
		
		else if(num == 3){
			
		Console.WriteLine("el dia de la semana selecionado es: miercoles ");
			
		}

	    else if(num == 4){
			
		Console.WriteLine("el dia de la semana selecionado es: jueves ");
			
		}
	 
	    else if(num == 5){
			
		Console.WriteLine("el dia de la semana selecionado es: viernes ");
			
		}
			
		else if(num == 6){
			
		Console.WriteLine("el dia de la semana selecionado es: sabado ");
			
		}
		
		else if(num == 7){
			
		Console.WriteLine("el dia de la semana selecionado es: domingo ");
			
		}
	
							
	}
}