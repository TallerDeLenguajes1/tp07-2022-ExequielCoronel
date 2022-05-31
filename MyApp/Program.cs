using System;
using System.Collections.Generic;

namespace tpn7
{
    class Program
    {
        static void Main(string[] args)
        {
            int marca=0, contador=1;
            Random rnd = new Random();
            List<Tarea> TareasP = new List<Tarea>();
            List<Tarea> TareasR = new List<Tarea>();
            Tarea tarea = new Tarea();

            //Añado tareas a la Lista de tareas pendientes
            do
            {
                Console.WriteLine($"Ingrese la descripción de la tarea {contador}: ");
                tarea.descripcion=Console.ReadLine();
                tarea.duracion=rnd.Next(10,101);
                tarea.id=contador;
                contador=contador+1;
                TareasP.Add(tarea);
                Console.WriteLine("Desea ingresar otra tarea?:\n1:SI\n0:NO");
                marca=Convert.ToInt32(Console.ReadLine());
            }while (marca!=0);

            marca=0;

            //Mueve las tareas de Lista de Pendientes a Realizadas
            foreach (Tarea item in TareasP)
            {
                Console.WriteLine($"Realizo la tarea? 1:SI, 0:NO\n ID: {item.id}\n Descripción: {item.descripcion}\n Duración: {item.duracion}");
                marca=Convert.ToInt32(Console.ReadLine());
                if(marca==1)
                {
                    TareasR.Add(item);
                    TareasP.Remove(item);
                }
            }

            foreach(Tarea item in TareasP)
            {
                Console.WriteLine("Esriba la descripción de la tarea a buscar: ");
                string aBuscar = Console.ReadLine();
                if(aBuscar==item.descripcion)
                {
                    Console.WriteLine("Se encontro la tarea!");
                }
            }

            int cantHoras=0;
            foreach(Tarea item in TareasR)
            {
                cantHoras+=item.duracion;
            }
            Console.WriteLine($"Cantidad horas trabajadas: {cantHoras}");

        }
    }
}
