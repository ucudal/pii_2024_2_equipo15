namespace program;

public class Tipos : ITipo
{
    public string Nombre { get; }

    private Dictionary<string, double> ventaja;

   
    public Tipos(string nombre, Dictionary<string, double> ventajas)
    {
        Nombre = nombre;
        ventaja = ventajas;
    }

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