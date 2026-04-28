namespace practica2.Gimnasio02;
public class Socio
{
    public string Nombre {get; set;}
    public string NumeroSocio {get; set;}
    public bool Estado {get; set;}
    
    public Socio(string nombre, string numerosocio, bool estado)
    {
        Nombre = nombre;
        NumeroSocio = numerosocio;
        Estado = estado;
    } 
}