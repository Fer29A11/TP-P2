using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Test
{
    public class UsuarioTests
    {
        [Fact]
        public void AsignarRutina_DebeAsignarCorrectamente()
        {
            // Arrange
            Usuario usuario = new Usuario("Juan", 25, "Fuerza");
            Rutina rutina = new Rutina("Rutina de Fuerza", 60);

            // Act
            usuario.AsignarRutina(rutina);


            // Assert
            Assert.Equal("Rutina de Fuerza", usuario.RutinaAsignada.Nombre);
        }
    }
}