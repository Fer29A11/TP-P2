using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Servicios
{
    public class AsignadorRutina
    {
        public void AsignarRutina(Usuario usuario, Rutina rutina)
        {
            usuario.AsignarRutina(rutina);
        }

        public void AsignarUsuarioAEntrenador(Usuario usuario, Entrenador entrenador)
        {
            entrenador.AsignarUsuario(usuario);
        }
    }
}
