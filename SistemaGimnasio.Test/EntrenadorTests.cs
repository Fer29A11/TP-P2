using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Test
{
    public class EntrenadorTests
    {
        [Fact]
        public void AsignarUsuario_DebeAgregarUsuarioALista()
        {
            // Arrange
            Usuario usuario = new Usuario("Carlos", 30, "Cardio");
            Entrenador entrenador = new Entrenador("Luis", "Cardio");

            // Act
            entrenador.AsignarUsuario(usuario);

            // Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());
        }
    }
}