namespace program
{
    public class Objeto
    {
        public string Nombre { get; }
        public Action<Pokemon> AplicarEfecto { get; }

        public Objeto(string nombre, Action<Pokemon> aplicarEfecto)
        {
            Nombre = nombre;
            AplicarEfecto = aplicarEfecto;
        }

        public string Usar(Pokemon objetivo)
        {
            AplicarEfecto(objetivo);
            return $"{Nombre} fue usado en {objetivo.Nombre}.";
        }
    }

}