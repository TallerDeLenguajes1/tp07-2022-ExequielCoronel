using System;

namespace tpn7_Coronel_Francisco_Exequiel
{
    public class Tarea
    {
        //DATOS
        private int id, duracion;
        private string descripcion;

        public int Id { get => id; set => id = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        //CONSTRUCTOR
        public Tarea()
        {
            id = 0;
            duracion = 0;
            descripcion = null;
        }   
    }
}