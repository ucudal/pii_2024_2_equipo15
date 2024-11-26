namespace program
{
    public interface IPokemon
    {
        string Nombre { get; }
        int Vida { get; set; }
        int VidaBase { get; set; }
        int Velocidad { get; set; }
        int Ataque { get; set; }
        int Defensa { get; set; }
        ITipo TipoPrincipal { get; }
        IHabilidad HabilidadCargando { get; set; }
        string Estado { get; set; }
        List<IHabilidad> Habilidades { get; }
        void AprenderHabilidad(IHabilidad habilidad);
        IHabilidad? ObtenerHabilidad(string nombreHabilidad);
    }
}