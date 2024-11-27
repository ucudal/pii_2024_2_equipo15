namespace program
{
    /// <summary>
    /// Representa un tipo elemental en el sistema de batalla de Pokémon, como Agua, Fuego o Planta.
    /// </summary>
    public class Tipos : ITipo
    {
        /// <summary>
        /// Nombre del tipo elemental.
        /// </summary>
        public string Nombre { get; }
        public static List<string> RestriccionDePokemon = new List<string>();


        /// <summary>
        /// Diccionario que contiene las ventajas de este tipo contra otros tipos.
        /// </summary>
        private Dictionary<string, double> ventaja;

        /// <summary>
        /// Constructor para inicializar un tipo elemental con su nombre y ventajas.
        /// </summary>
        /// <param name="nombre">Nombre del tipo elemental.</param>
        /// <param name="ventajas">Diccionario que define las ventajas y desventajas frente a otros tipos.</param>
        public Tipos(string nombre, Dictionary<string, double> ventajas)
        {
            Nombre = nombre;
            ventaja = ventajas;
        }

        /// <summary>
        /// Calcula la efectividad de este tipo contra otro tipo dado.
        /// </summary>
        /// <param name="otroTipo">El tipo del oponente contra el cual se evalúa la efectividad.</param>
        /// <returns>
        /// Un valor numérico que indica la efectividad:
        /// <list type="bullet">
        /// <item><term>2.0</term><description>Super efectivo.</description></item>
        /// <item><term>0.5</term><description>Poco efectivo.</description></item>
        /// <item><term>1.0</term><description>Efectividad normal (neutral).</description></item>
        /// <item><term>0.0</term><description>Sin efecto.</description></item>
        /// </list>
        /// </returns>
        public double EsEfectivoOPocoEfectivo(ITipo otroTipo)
        {
            string nombreDelOtroElemento = otroTipo.Nombre;
            bool existeVentaja = ventaja.ContainsKey(nombreDelOtroElemento);
            double efectividad;
            if (existeVentaja)
            {
                efectividad = ventaja[nombreDelOtroElemento];
            }
            else
            {
                efectividad = 1.0;
            }
            return efectividad;
        }
    }
}
