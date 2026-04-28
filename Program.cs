using System;
using practica2.Veterinaria01;
using practica2.Gimnasio02;

/*static void Veterinaria01()
{
Console.WriteLine("¿Que operacion desea realizar? 1=Registrar Paciente, 2=Dar de baja paciente, 3=Encontrar paciente, 4=Lista de todos los pacientes activos, 0=Salir");
int cond = int.Parse(Console.ReadLine()!);
  Veterinaria v = new();
while (cond != 0){
        switch (cond)
        {
            case 1:
            Console.WriteLine("Ingrese el nombre del paciente");
            string nombre = Console.ReadLine()!;
            Console.WriteLine("Ingrese la especie del paciente");
            string especie = Console.ReadLine()!;
            Console.WriteLine("Ingrese la edad del paciente");
            int edad = int.Parse(Console.ReadLine()!);
            Animal a = new Animal(nombre,especie,edad);
            string aux = v.RegistrarPaciente(a);
            Console.WriteLine($"El paciente {aux} con edad de {a.Edad} años y especie {a.Especie} ha sido registrado con éxito ");
            break;
            case 2:
             Console.WriteLine("Ingrese el nombre del paciente a dar de baja");
             nombre = Console.ReadLine()!;
            aux = v.DarBajaPaciente(nombre);
            if (aux != "No se encontró el paciente con ese nombre")  {
            Console.WriteLine($"El paciente {aux} ha sido dado de baja con éxito");
            }
            else{
            Console.WriteLine($"{aux}");
            }
            break;
            case 3:
            Console.WriteLine("Ingrese el nombre del paciente a buscar");
            string buscar = Console.ReadLine()!;
            a = v.BuscarPaciente(buscar);
            if (a != null)
                {
                    Console.WriteLine($"El paciente {a.Nombre} se encuentra registrado");
                }
                else
                {
                    Console.WriteLine("No se encontró ningún paciente con ese nombre");
                }
            break;
            case 4:
            List <string> nombres = v.MostrarTodas();
            Console.WriteLine($"La lista de animales registrados es: {string.Join(",", nombres)}");
            break;
        }
        Console.WriteLine("¿Que operacion desea realizar? 1=Registrar Paciente, 2=Dar de baja paciente, 3=Encontrar paciente, 4=Lista de todos los pacientes activos, 0=Salir");
        cond = int.Parse(Console.ReadLine()!);
    }
}
Veterinaria01();*/

static void Gimnasio02(){
Console.WriteLine("Defina la capacidad máxima que tendrá su gimnasio:");
int cantidad = int.Parse(Console.ReadLine()!);
Console.WriteLine("¿Que operacion desea realizar? 1=Dar alta socio, 2=Dar de baja socio, 3=Marcar cuota socio, 4=Cantidad de socios con cuota al día, 0=Salir");
int cond = int.Parse(Console.ReadLine()!);
Gimnasio g = new();
g.DefinirCantidad(cantidad);
while (cond != 0){
        switch (cond)
        {
            case 1:
            bool estado;
            Console.WriteLine("Ingrese el nombre del socio");
            string socio = Console.ReadLine()!;
            Console.WriteLine("Ingrese el numero de socio");
            string numerosocio = Console.ReadLine()!;
            Console.WriteLine("Ingrese el estado de la cuota (1= Pagado 2= Debe)");
            int checkestado = int.Parse(Console.ReadLine()!);
            if (checkestado == 1)
                {
                     estado = true;
                }else
                {
                    estado = false;
                }
            Socio s = new Socio(socio,numerosocio,estado);
            Socio aux = g.DarAltaSocio(s);
            if (aux == null){
                    Console.WriteLine("No hay más espacio para ingresar más socios");
                }else {
            Console.WriteLine($"El socio {aux.Nombre}, con número {aux.NumeroSocio} ha sido registrado y tiene la cuota en {aux.Estado}");
                }
            break;
        }
        Console.WriteLine("¿Que operacion desea realizar? 1=Dar alta socio, 2=Dar de baja socio, 3=Marcar cuota socio, 4=Cantidad de socios con cuota al día, 0=Salir");
        cond = int.Parse(Console.ReadLine()!);
}
}
Gimnasio02();