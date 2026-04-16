namespace practica2.Veterinaria01;
public class Animal
{
    public string Nombre { get; set; }
    public string Especie { get; set; }
    public int Edad { get; set; }

 public Animal (string nombre, string especie, int edad){
        Nombre = nombre;
        Especie = especie;
        Edad =edad;

    }
    public string ObtenerInfo()
    {
        return $"{Nombre} | {Especie} | {Edad} años";
    }   
}