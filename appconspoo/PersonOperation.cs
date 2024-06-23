
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

namespace appconspoo
{
    public class PersonOperation
    {
        public void insert(List<Person> listPersonIn)
        {
            Person person = new Person();

            Console.WriteLine("INGRESE NOMBRE:");
            person.firtsName = Console.ReadLine();

            Console.WriteLine("INGRESE APELLIDO:");
            person.surName = Console.ReadLine();

            Console.WriteLine("INGRESE DNI:");
            person.dni = Console.ReadLine();

          
            listPersonIn.Add(person);
            Console.Write("");
            Console.WriteLine("Registro realizado correctamente");
        }
        public static Boolean evaluar(List<Person> listPersonIn)
        {
            foreach (Person item in listPersonIn)
            {
               string expr = item.dni;
                string filtro = @"/[0-9]{8}$/";
                Regex rgx = new Regex(filtro);
                if (rgx.IsMatch(expr))
                    return true;
               
            }
            return false;

        }
        public void showAll(List<Person> listPersonIn)
        {
            int contador=1;
            foreach (Person item in listPersonIn)
            {
                
                    Console.WriteLine("Persona "+contador+": "+ item.firtsName + " " + item.surName + " " + "(" + item.dni + ")");
                contador++;
            }
        }
        public void deleteByDni(List<Person> listPersonIn)
        {
            string dni;
            Console.WriteLine("Ingrese el DNI de la persona a eliminar ");
            dni = Console.ReadLine();

            int index = 0;
            bool existsPerson = false;
            foreach (Person item in listPersonIn)
            {
                if (item.dni==dni)
                {
                    existsPerson = true;
                    break;
                }
                index++;
            }
            if (existsPerson)
            {
                listPersonIn.RemoveAt(index);
                Console.Write("");
                Console.WriteLine("Registro ELIMINADO correctamente");
            }
            else
            {
                Console.WriteLine("Registro NO encontrado");
            }
               

        }
        public void edit(List<Person> listPersonIn)
        {
            string dni;

            Console.Write("Ingrese el DNI de la persona a editar: ");
            dni = Console.ReadLine();

            int index = 0;
            bool existsPerson = false;

            foreach (Person item in listPersonIn)
            {
                if (item.dni == dni)
                {
                    existsPerson = true;

                    break;
                }

                index++;
            }

            Console.WriteLine("");

            if (existsPerson)
            {
                Console.Write("Ingrese el nuevo nombre: ");
                listPersonIn[index].firtsName = Console.ReadLine();

                Console.Write("Ingrese el nuevo apellido: ");
                listPersonIn[index].surName = Console.ReadLine();

                Console.Write("Ingrese el nuevo DNI: ");
                listPersonIn[index].dni = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("Datos editados correctamente.");
            }
            else
            {
                Console.WriteLine("Registro no encontrado.");
            }
        }

    }
}
