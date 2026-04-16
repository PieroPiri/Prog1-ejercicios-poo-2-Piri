    namespace practica2.Veterinaria01;
    public class Veterinaria
    {
        private List <Animal> Animales {get;set;} = new List<Animal>();

        public string RegistrarPaciente(Animal animal)
        {
            Animales.Add(animal);
            return animal.Nombre;
        }
        public string DarBajaPaciente(string nombre)
        {
         Animal borrarAnimal = BuscarPaciente(nombre);
        if (borrarAnimal != null)
        {
            Animales.Remove(borrarAnimal);
            return borrarAnimal.Nombre;
        } else
        {
            return "No se encontró el paciente con ese nombre";
        }

        }
        public Animal BuscarPaciente(string nombre)
        {
            foreach (Animal a in Animales )
            {
                if (a.Nombre.ToLower() == nombre.ToLower())
            {
                 return a;
            }   
            }
            return null!;
        }   
        public List<string> MostrarTodas()
        {
             List <string> Nombres = new List <string>();
             foreach (Animal a in Animales) {
           Nombres.Add(a.Nombre);
        }
        return Nombres;
        }
        }