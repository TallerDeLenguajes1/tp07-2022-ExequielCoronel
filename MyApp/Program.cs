using System;
using System.Collections.Generic;

namespace tpn7_Coronel_Francisco_Exequiel
{
    class Program
    {
        static void Main(string[] args)
        {
            int marca = 0, contador=1, realizada=0, indice=0, cantidad=0;
            double tiempo=0;
            List<Tarea> TareasP = new List<Tarea>();
            var TareasR = new List<Tarea>();
            
            Random rnd = new Random();

            do
            {   
                Tarea T = new Tarea();
                System.Console.WriteLine("Escriba una descripción a su nueva tarea: ");
                T.Descripcion=Console.ReadLine();
                T.Id = contador;
                T.Duracion = rnd.Next(10,100);
                do
                {
                    System.Console.WriteLine("\n¿Desea añadir otra tarea? 1=SI, 0=NO\n");
                    marca=Convert.ToInt32(Console.ReadLine());
                }while(marca!=0 && marca!=1);   
                TareasP.Add(T);
                contador+=1; 
            }while(marca!=0);
            
            //Muevo las tareas de Pendientes a Realizadas
            foreach(Tarea item in TareasP)
            {
                Console.WriteLine($"--------------------------\n\tID Tarea: {item.Id} \nDuración: {item.Duracion} \nDescripción: {item.Descripcion}\n--------------------------");
                do
                {
                    Console.WriteLine("Realizo la tarea? 1=SI, 0=NO");
                    realizada = Convert.ToInt32(Console.ReadLine());
                }while(realizada!=0 && realizada!=1);
                if(realizada==1)
                {
                    TareasR.Add(item);
                }
            }
            foreach(var item in TareasR)
            {
                TareasP.Remove(item);
            }

            //Busco la tarea en pendientes por su descripcion
            System.Console.WriteLine("\nIngrese la tarea a buscar en pendientes: ");
            string descripcion = Console.ReadLine();
            foreach (Tarea item in TareasP)
            {
                if(descripcion == item.Descripcion)
                {
                    System.Console.WriteLine("Tarea encontrada!");
                    break;
                }    
            }

            //Muestro la cantidad de horas trabajadas 
            foreach(Tarea item in TareasR)
            {
                tiempo+=item.Duracion;
            }
            tiempo/=60;
            Console.WriteLine($"Cantidad de horas trabajadas: {tiempo.ToString("N1")}");
            
           


        }
    }
}
