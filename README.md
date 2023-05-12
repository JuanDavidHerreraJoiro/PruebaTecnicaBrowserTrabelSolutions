------------------------------------------------------------------------------------------
		BROWSER TRAVEL SOLUTIONS - JUAN DAVID HERRERA JOIRO
------------------------------------------------------------------------------------------
1. Ejecutar los comandos de migracion y de creacion de base de datos.

	Ejecutar los siguientes comandos en consola del administrador de paquetes a nivel de DATOS.

		1. add-migration "Create tables"
		2. Update-Database -Verbose
------------------------------------------------------------------------------------------
2. Ejecutar el script "LibraryDB.sql" de la base de datos con los registros de las tablas - backup guardado previamente.
	
	Paso anterio opcional ya que en el script tiene la creacion de las tablas y los insert de cada una de ellas.
------------------------------------------------------------------------------------------
3. Ejecutar el back-end en .net 5 "PruebaTecnica_BrowserTravel".
	
	Para ejecutar el back-end correr desde visual studio.

		1. Aplicacion documentada en Swagger.
------------------------------------------------------------------------------------------
4. Ejecutar el Front-end en Angular 16 "BrowserTravelSolution".
	
	Para ejecutar el fron-end correr en la carpeta raiz "AppBrowserTravelSolutions" el siguiente comando.
		
		1. ng serve --o
------------------------------------------------------------------------------------------
5. Con lo anterior ya tiene toda la aplicacion corriendo en su totalidad.
------------------------------------------------------------------------------------------

Nota: Seguir la secuencia de los pasos marcados anterior mente.