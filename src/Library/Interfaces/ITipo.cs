namespace program;

public interface ITipo
{
    string Nombre { get; }
    double EsEfectivoOPocoEfectivo(ITipo otroTipo);
}