Algoritmo BonificacionFinal
	Definir  unidadesVendidas, antiguedad Como Entero;
	Definir sueldoBase, bonificacion, sueldofinal Como Real
	
	sueldoBase <- 2200000
	bonificacion <- 200000
	sueldofinal <- sueldoBase
	
	Escribir "Ingrese la cantidad de unidades vendidas en el mes: ";
	Leer unidadesVendidas
	Escribir "Ingrese los años antiguedad en la empresa: ";
	Leer antiguedad;
	
	Si unidadesVendidas > 50 Y antiguedad > 2 Entonces
		sueldofinal <- sueldoBase + bonificacion;
		Escribir "¡Felicidades! Ha cumplido con las metas de ventas! tienes una bonificacion de: ", bonificacion ;
	FinSi
	Escribir "Tu salario de este mes es de: $" , sueldofinal;
FinAlgoritmo
