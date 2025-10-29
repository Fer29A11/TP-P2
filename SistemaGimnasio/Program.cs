using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;
Console.WriteLine("Sistema de Gestión de Gimnasio");
// crear usuario

Console.WriteLine("Ingresa el nombre del usuario");
string nombreUsuario = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la edad del usuario");
int edadUsuario = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ingresa el objetivo del usuario (Fuerza, Resistencia, etc)");
string objetivoUsuario = Console.ReadLine() ?? "";

Usuario usuario = new Usuario(nombreUsuario, edadUsuario, objetivoUsuario);

// Crear entrenador

Console.WriteLine("Ingresa el nombre del entrenador");
string nombreEntrenador = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la especialidad del entrenador (Fuerza, Resistencia, etc)");
string especialidadEntrenador = Console.ReadLine() ?? "";

Entrenador entrenador = new Entrenador(nombreEntrenador, especialidadEntrenador);


// Crear rutina

Console.WriteLine("Ingresa el nombre de la rutina");
string nombreRutina = Console.ReadLine() ?? "";

Console.WriteLine("Ingrese la duración de la rutina");
int duracion = int.Parse(Console.ReadLine() ?? "");

Rutina rutina = new Rutina(nombreRutina, duracion);

// Agregar ejercicios a rutina
Console.WriteLine("¿Cuántos ejercicios deseas agregar a la rutina?");
int numEjercicios = int.Parse(Console.ReadLine() ?? "");
for (int i = 0; i < numEjercicios; i++)
{
    Console.WriteLine($"Ejercicio #{i+1}");
    Console.WriteLine("Ingresa el nombre del ejercicio: ");
    string nombreEjercicio =  Console.ReadLine() ?? "";
    Console.WriteLine("Ingresa el número de repeticiones: ");
    int repeticiones = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Ingresa el número de series: ");
    int series = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Ingresa el tiempo de descanos: ");
    int descanso = int.Parse(Console.ReadLine() ?? "");
    Ejercicio ejercicio = new Ejercicio(nombreEjercicio, repeticiones, series, descanso);
    rutina.AgregarEjercicio(ejercicio);
}

// Asignar rutina a usuario y usuario a entrenador
AsignadorRutina asignador = new AsignadorRutina();
asignador.AsignarRutina(usuario, rutina);
asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

// Mostrar resumen
Console.WriteLine($"Resumen de asignación del usuario: {usuario.Nombre}");
Console.WriteLine($"Objetivo: {usuario.Objetivo}");
Console.WriteLine($"Rutina asignada: {usuario.RutinaAsignada.Nombre}");
Console.WriteLine($"Duración: {rutina.Duracion} minutos");
Console.WriteLine("Ejercicios en la rutina:");
foreach (var ejercicio in usuario.RutinaAsignada.ObtenerEjercicios())
{
    Console.WriteLine($"- {ejercicio.Nombre}: {ejercicio.Repeticiones} repeticiones, {ejercicio.Series} series, {ejercicio.Descanso} minutos de descanso");
}
Console.WriteLine($"Entrenador asignado: {entrenador.Nombre}, Especialidad: {entrenador.Especialidad}");
