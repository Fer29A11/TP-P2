using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Gestores
{
    public class GestorEntrenador
    {
        private List<Entrenador> entrenadores;
        public GestorEntrenador()
        {
             entrenadores = new List<Entrenador>();
        }
        public void RegistrarEntrendor(string nombre, string especialidad)
        {
            entrenadores.Add(new Entrenador(nombre, especialidad));
        }
        public Entrenador BuscarEntrenador(string nombre)
        {
            return entrenadores.FirstOrDefault(e => e.Nombre == nombre);   
        }
    }
}