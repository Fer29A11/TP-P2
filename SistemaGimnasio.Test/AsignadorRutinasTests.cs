using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;
namespace SistemaGimnasio.Test
{
    public class AsignadorRutinasTests
    {
        [Fact]
        public void AsignarRutinaAUsuario_DebeAsignarRutinaCorrectamente()
        {
            // Arrange
            Usuario usuario = new Usuario("Ana", 28, "Cardio");
            Rutina rutinaCardio = new Rutina("Rutina de Cardio", 50);
            AsignadorRutina asignador = new AsignadorRutina();
            // Act
            asignador.AsignarRutina(usuario, rutinaCardio);

            // Assert
            Assert.Equal(rutinaCardio, usuario.RutinaAsignada);
        }

        [Fact]
        public void AsignarUsuarioAEntrenador_DebeAsignarUsuarioCorrectamente()
        {
            // Arrange
            Usuario usuario = new Usuario("Miguel", 35, "Fuerza");
            Entrenador entrenador = new Entrenador("Pedro", "Fuerza");
            AsignadorRutina asignador = new AsignadorRutina();
            // Act
            asignador.AsignarUsuarioAEntrenador(usuario, entrenador);
            // Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());
        }
    }
}