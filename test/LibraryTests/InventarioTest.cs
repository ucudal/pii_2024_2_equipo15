using NUnit.Framework;
using program;
using System.Collections.Generic;

namespace Tests
{
    /// <summary>
    /// Pruebas para la clase Inventario.
    /// </summary>
    [TestFixture]
    public class InventarioTests
    {
        private Inventario inventario;
        private Pokemon pikachu;

        /// <summary>
        /// Configuración inicial para las pruebas.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            inventario = new Inventario();
            pikachu = new Pokemon("Pikachu", 180, 150, 120, 150);
        }

        /// <summary>
        /// Prueba que MostrarInventario devuelva la lista correcta de objetos.
        /// </summary>
        [Test]
        public void MostrarInventario_MuestraListaDeObjetos()
        {
            string resultado = inventario.MostrarInventario();
            Assert.That(resultado, Does.Contain("Súper poción: 4 unidades"));
            Assert.That(resultado, Does.Contain("Revivir: 1 unidades"));
            Assert.That(resultado, Does.Contain("Cura total: 2 unidades"));
        }

        /// <summary>
        /// Prueba que se pueda usar una Súper poción para curar a un Pokémon.
        /// </summary>
        [Test]
        public void UsarObjeto_SuperPocion_CuraPokemon()
        {
            pikachu.Vida = 100;
            string resultado = inventario.UsarObjeto("Súper poción", pikachu);

            Assert.That(resultado, Is.EqualTo("Súper poción fue usado en Pikachu."));
            Assert.That(pikachu.Vida, Is.EqualTo(170)); // 100 + 70
        }

        /// <summary>
        /// Prueba que usar una Súper poción no exceda la vida base del Pokémon.
        /// </summary>
        [Test]
        public void UsarObjeto_SuperPocion_NoExcedeVidaBase()
        {
            pikachu.Vida = 160;
            string resultado = inventario.UsarObjeto("Súper poción", pikachu);

            Assert.That(resultado, Is.EqualTo("Súper poción fue usado en Pikachu."));
            Assert.That(pikachu.Vida, Is.EqualTo(180)); // Vida base máxima
        }

        /// <summary>
        /// Prueba que usar Revivir en un Pokémon debilitado lo restaure correctamente.
        /// </summary>
        [Test]
        public void UsarObjeto_Revivir_RestauraVida()
        {
            pikachu.Vida = 0;
            string resultado = inventario.UsarObjeto("Revivir", pikachu);

            Assert.That(resultado, Is.EqualTo("Revivir fue usado en Pikachu."));
            Assert.That(pikachu.Vida, Is.EqualTo(90)); // Vida base / 2
        }

        /// <summary>
        /// Prueba que usar Revivir en un Pokémon no debilitado no haga nada.
        /// </summary>
        [Test]
        public void UsarObjeto_Revivir_NoDebilitado_NoHaceNada()
        {
            string resultado = inventario.UsarObjeto("Revivir", pikachu);

            Assert.That(resultado, Is.EqualTo("Pikachu no está debilitado."));
            Assert.That(pikachu.Vida, Is.EqualTo(180));
        }

        /// <summary>
        /// Prueba que usar Cura total elimine el estado del Pokémon.
        /// </summary>
        [Test]
        public void UsarObjeto_CuraTotal_EliminaEstado()
        {
            pikachu.Estado = "paralizado";
            pikachu.DuracionEstado = 3;

            string resultado = inventario.UsarObjeto("Cura total", pikachu);

            Assert.That(resultado, Is.EqualTo("Cura total fue usado en Pikachu."));
            Assert.That(pikachu.Estado, Is.Null);
            Assert.That(pikachu.DuracionEstado, Is.EqualTo(0));
        }

        /// <summary>
        /// Prueba que no se pueda usar un objeto si no queda en el inventario.
        /// </summary>
        [Test]
        public void UsarObjeto_SinUnidades_NoDisponible()
        {
            inventario.UsarObjeto("Revivir", pikachu); // Usa el único Revivir disponible
            string resultado = inventario.UsarObjeto("Revivir", pikachu);

            Assert.That(resultado, Is.EqualTo("Pikachu no está debilitado."));
        }

        /// <summary>
        /// Prueba que usar un objeto no válido devuelva el mensaje apropiado.
        /// </summary>
        [Test]
        public void UsarObjeto_NoValido_DevuelveError()
        {
            string resultado = inventario.UsarObjeto("Piedra lunar", pikachu);

            Assert.That(resultado, Is.EqualTo("No tienes Piedra lunar disponible."));
        }
        
        [Test]
        public void ProhibirObjetos()
        {
            var objetoInutil = new Objeto("Objeto inútil", p => { });
            var RestriccionDeObjeto = objetoInutil.ProhibirObjetos(objetoInutil);
            Assert.That(RestriccionDeObjeto, Is.EqualTo($"{objetoInutil.Nombre} es un objeto prohibido"));

        }
    }
}