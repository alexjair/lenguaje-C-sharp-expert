using ConsoleApp;

clsAlumno objEstudiante = new clsAlumno("Juan",18,18.41,"Sistemas");
objEstudiante.nombre = "July";
objEstudiante.edad = 36;
objEstudiante.nota = 18.50;
objEstudiante.grado = "Secundaria";

clsAlumno objCachimbo = new clsAlumno("Laura", 19, 13.41, "Contabilidad");
objCachimbo.nombre = "Jair";
objCachimbo.edad = 23;
objCachimbo.nota = 15.50;
objCachimbo.grado = "Primaria";

Console.WriteLine(objEstudiante.nombre);
Console.WriteLine(objEstudiante.edad);
Console.WriteLine(objEstudiante.nota);
Console.WriteLine(objEstudiante.grado);

Console.WriteLine(objCachimbo.nombre);
Console.WriteLine(objCachimbo.edad);
Console.WriteLine(objCachimbo.nota);
Console.WriteLine(objCachimbo.grado);