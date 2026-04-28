namespace practica2.Gimnasio02;
public class Gimnasio
{
    public List <Socio> Socios {get; set;} = new List<Socio>();
    
    public int Capacidad {get; set;}
    public int DefinirCantidad(int cantidad)
    {
        Capacidad = cantidad;
        return Capacidad;
    }
    public Socio DarAltaSocio(Socio socio)
    {
        int capacidad = 0;
        foreach (Socio s in Socios)
        {
            capacidad = capacidad + 1;
        }
        if (capacidad < Capacidad)
        {
            Socios.Add(socio);
            return socio;
        } else
        {
          return null!;  
        }
    }
    public Socio DarBajaSocio(string numerosocio)
    {
        Socio bajasocio = BuscarSocio(numerosocio);
        if (bajasocio != null)
        {
            Socios.Remove(bajasocio);
        }
        return bajasocio!;
    }
    public Socio MarcarCuota(string numerosocio, bool condicion){
        Socio estadosocio = BuscarSocio(numerosocio);
        if (estadosocio != null)
        {
            estadosocio.Estado = condicion;
        }
        return estadosocio!; 
    }
    public int ContarSociosCuota()
    {
        int c = 0;
        foreach (Socio s in Socios)
        {
            if (s.Estado == true)
            {
                c = c + 1;
            }
        }
        return c;
    }
    private Socio BuscarSocio(string numerosocio)
    {
       
        foreach (Socio s in Socios)
        {
            if (s.NumeroSocio == numerosocio)
            {
                return s;
            }
        }
     return null!;
    }
}