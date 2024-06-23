using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//@autor CristianOlivera1

namespace appconspoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPerson = new List<Person>();
            PersonOperation personaOperation = new PersonOperation();
            int option = 0;

            while (option != 5)
            {

                Console.Clear();
                Console.WriteLine(" ______________________________" );
                Console.WriteLine("|   ::OPCIONES DEL PROGRAMA::  |");
                Console.WriteLine("| 1. Registrar personas Nueva  |");
                Console.WriteLine("| 2. Listar Personas           |");
                Console.WriteLine("| 3. Eliminar personas con DNI |");
                Console.WriteLine("| 4. Editar persona            |");
                Console.WriteLine("| 5. Salir                     |");
                Console.WriteLine("|______________________________|");
                Console.WriteLine("");
                Console.WriteLine("Elige una de las opciones:");

                option = int.Parse(Console.ReadLine());

                Console.WriteLine("_______________________________________");

                switch (option)
                {
                    case 1:
                        personaOperation.insert(listPerson);
                        break;
                        
                    case 2:
                        personaOperation.showAll(listPerson);
                        break;

                    case 3:
                        personaOperation.deleteByDni(listPerson);
                        break;

                    case 4:
                        personaOperation.edit(listPerson);
                        break;

                    case 5:
                        break;

                         
                }
                Console.WriteLine("_______________________________________");
                Console.ReadLine();
            }

        }
    }
}
