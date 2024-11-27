namespace program
{
    public class EfectoEspeciales
    {
        public string Nombre { get; }
        public Action<Pokemon> AplicarEfecto { get; }

        public EfectoEspeciales(string nombre, Action<Pokemon> aplicarEfecto)
        {
            Nombre = nombre;
            AplicarEfecto = aplicarEfecto;
        }
    }

}