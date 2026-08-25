Algoritmo VerificarMayoriaEdad
	Escribir "Ingrese su año actual"              //  Entrada
	Leer anioActual
	Escribir "Ingrese su año de nacimiento:"
	Leer anioNacimiento
	edad <- anioActual - anioNacimiento             // Proceso
	Si edad >= 18 Entonces                         // Salida y logica
		Escribir "Es mayor de edad. Edad:", edad
	SiNo
		Escribir "Es mayoir de edad. Edad:" edad
	

		
	FinSi
	
	
FinAlgoritmo
