Algoritmo ControlVelocidad
	Definir velocidad Como Real ;
	
	Escribir "Ingrese la velocidad registrada del vehiculo (km/h):";
	Leer velocidad;
	
	Si velocidad > 80 Entonces
		Escribir "¡ALERTA! ha superado el limite de velocidad de 80 km/h.";
		Escribir "Se ha generado una fotomulta automaticamente.";
	FinSi
	
	Escribir "Evaluacion de transito finalizada.";
FinAlgoritmo
