using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Gestores
{
    public class GestorRutina
    {
        private List<Rutina> rutinas;


        public GestorRutina()
        {
            rutinas = new List<Rutina>();
        }
        public void CrearRutina(string nombre, int duración)
        {
            rutinas.Add(new Rutina(nombre, duración));
        }
        public Rutina BuscarRutina(string nombre)
        {
            return rutinas.FirstOrDefault(r => r.Nombre == nombre);
        }
    }
}