namespace program;

public interface IPokemon
{
    string Nombre { get; }
    int Vida { get; }
    List<IHabilidad> Habilidades { get; }
    ITipo TipoPrincipal { get; }
    ITipo TipoSecundario { get; }
    IHabilidad HabilidadCargando { get; set; }
    void AprenderHabilidad(IHabilidad habilidad);
}