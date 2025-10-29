using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Test
{
    public class RutinaTests
    {
        [Fact]
        public void AgregarEjercicio_DebeAgregarALista()
        {
            //Arrange
            Rutina rutina = new Rutina("Rutina de Cardio", 45);
            Ejercicio ejercicio = new Ejercicio("Lagartijas", 12, 3, 1);
            Ejercicio ejercicio2 = new Ejercicio("Abdominales", 15, 3, 1);

            // Act
            rutina.AgregarEjercicio(ejercicio);
            rutina.AgregarEjercicio(ejercicio2);

            // Assert
            Assert.NotEmpty(rutina.ObtenerEjercicios());

        }
    }
}