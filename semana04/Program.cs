using System;
using System.Collections.Generic;

namespace AgendaPersonal
{
    // Clase que representa un contacto
    class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public Contacto(string nombre, string telefono, string correo)
        {
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
        }

        public void MostrarContacto()
        {
            Console.WriteLine("Nombre   : " + Nombre);
            Console.WriteLine("Teléfono : " + Telefono);
            Console.WriteLine("Correo   : " + Correo);
            Console.WriteLine("-----------------------------");
        }
    }

    class Program
    {
        // Lista (vector) de contactos precargados
        static List<Contacto> agenda = new List<Contacto>()
        {
            new Contacto(
                "Diana Cedeño",
                "0999977165",
                "susanadcedeno.2015@gmail.com"
            ),
            new Contacto(
                "Dario Manzaba",
                "0980006570",
                "manzaba19918078@gmail.com"
            ),
            new Contacto(
                "Andres Vera",
                "0993351321",
                "Yo.rolo.jeje@gmail.com"
            )
        };

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("===== AGENDA TELEFÓNICA =====");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Buscar contacto por nombre");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarContacto();
                        break;
                    case 2:
                        MostrarAgenda();
                        break;
                    case 3:
                        BuscarContacto();
                        break;
                    case 4:
                        Console.WriteLine("Programa finalizado.");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 4);
        }

        static void AgregarContacto()
        {
            Console.Clear();
            Console.WriteLine("=== AGREGAR CONTACTO ===");

            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese teléfono: ");
            string telefono = Console.ReadLine();

            Console.Write("Ingrese correo: ");
            string correo = Console.ReadLine();

            agenda.Add(new Contacto(nombre, telefono, correo));

            Console.WriteLine("\nContacto agregado correctamente.");
        }

        static void MostrarAgenda()
        {
            Console.Clear();
            Console.WriteLine("=== LISTA DE CONTACTOS ===");

            if (agenda.Count == 0)
            {
                Console.WriteLine("No existen contactos registrados.");
            }
            else
            {
                foreach (Contacto contacto in agenda)
                {
                    contacto.MostrarContacto();
                }
            }
        }

        static void BuscarContacto()
        {
            Console.Clear();
            Console.WriteLine("=== BUSCAR CONTACTO ===");

            Console.Write("Ingrese el nombre a buscar: ");
            string nombreBuscado = Console.ReadLine();

            bool encontrado = false;

            foreach (Contacto contacto in agenda)
            {
                if (contacto.Nombre.Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    contacto.MostrarContacto();
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }
    }
}
