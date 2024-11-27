using NUnit.Framework;
using program;

namespace LibraryTests
{
    /// <summary>
    /// Pruebas para la clase estática GameManager.
    /// </summary>
    
    public class GameManagerTests
    {
        /// <summary>
        /// Configura el estado inicial antes de cada prueba.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            // Limpiar la lista de entrenadores antes de cada prueba
            typeof(GameManager)
                .GetField("entrenadores", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                ?.SetValue(null, new List<Entrenador>());
        }

        /// <summary>
        /// Prueba que un entrenador se pueda agregar correctamente.
        /// </summary>
        [Test]
        public void AgregarEntrenador_NuevoEntrenador_SeAgregaExitosamente()
        {
            string resultado = GameManager.AgregarEntrenador("Ichigo");
            Assert.That(resultado, Is.EqualTo("El entrenador Ichigo se ha unido."));
            Assert.That(GameManager.ObtenerEntrenador("Ichigo")?.Nombre, Is.EqualTo("Ichigo"));
        }

        /// <summary>
        /// Prueba que no se pueda agregar un entrenador duplicado.
        /// </summary>
        [Test]
        public void AgregarEntrenador_EntrenadorDuplicado_NoSeAgrega()
        {
            GameManager.AgregarEntrenador("Ichigo");
            string resultado = GameManager.AgregarEntrenador("Ichigo");
            Assert.That(resultado, Is.EqualTo("El entrenador Ichigo ya está registrado."));
        }

        /// <summary>
        /// Prueba que se pueda obtener un entrenador por su nombre.
        /// </summary>
        [Test]
        public void ObtenerEntrenador_EntrenadorExistente_DevuelveEntrenador()
        {
            GameManager.AgregarEntrenador("Ichigo");
            Entrenador? entrenador = GameManager.ObtenerEntrenador("Ichigo");
            Assert.That(entrenador?.Nombre, Is.EqualTo("Ichigo"));
        }

        /// <summary>
        /// Prueba que ObtenerEntrenador devuelve null si no existe el entrenador.
        /// </summary>
        [Test]
        public void ObtenerEntrenador_EntrenadorNoExistente_DevuelveNull()
        {
            Entrenador? entrenador = GameManager.ObtenerEntrenador("Urahara");
            Assert.That(entrenador, Is.Null);
        }

        /// <summary>
        /// Prueba que ObtenerNombresEntrenadores devuelve la lista de nombres correctamente.
        /// </summary>
        [Test]
        public void ObtenerNombresEntrenadores_DevuelveNombresCorrectamente()
        {
            GameManager.AgregarEntrenador("Ichigo");
            GameManager.AgregarEntrenador("Urahara");
            List<string> nombres = GameManager.ObtenerNombresEntrenadores();
            Assert.That(nombres, Is.EquivalentTo(new List<string> { "Ichigo", "Urahara" }));
        }

        /// <summary>
        /// Prueba que EmparejarAleatorio devuelve un entrenador distinto del excluido.
        /// </summary>
        [Test]
        public void EmparejarAleatorio_DevuelveEntrenadorDistintoDelExcluido()
        {
            GameManager.AgregarEntrenador("Ichigo");
            GameManager.AgregarEntrenador("Urahara");
            Entrenador? emparejado = GameManager.EmparejarAleatorio("Ichigo");
            Assert.That(emparejado?.Nombre, Is.EqualTo("Urahara"));
        }

        /// <summary>
        /// Prueba que EmparejarAleatorio devuelve null si no hay entrenadores disponibles.
        /// </summary>
        [Test]
        public void EmparejarAleatorio_SinEntrenadoresDisponibles_DevuelveNull()
        {
            GameManager.AgregarEntrenador("Ichigo");
            Entrenador? emparejado = GameManager.EmparejarAleatorio("Ichigo");
            Assert.That(emparejado, Is.Null);
        }

        /// <summary>
        /// Prueba que un entrenador se pueda eliminar correctamente.
        /// </summary>
        [Test]
        public void EliminarEntrenador_EntrenadorExistente_SeEliminaExitosamente()
        {
            GameManager.AgregarEntrenador("Ichigo");
            string resultado = GameManager.EliminarEntrenador("Ichigo");
            Assert.That(resultado, Is.EqualTo("El entrenador Ichigo ha sido eliminado."));
            Assert.That(GameManager.ObtenerEntrenador("Ichigo"), Is.Null);
        }

        /// <summary>
        /// Prueba que no se pueda eliminar un entrenador que no existe.
        /// </summary>
        [Test]
        public void EliminarEntrenador_EntrenadorNoExistente_NoSeElimina()
        {
            string resultado = GameManager.EliminarEntrenador("Urahara");
            Assert.That(resultado, Is.EqualTo("El entrenador Urahara no existe."));
        }
    }
}