using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17_GrupoYaNoNosFaltan2.Entidades
{
    public class Estado
    {
        // Atributos
        public string nombre { get; set; }  

        // Constructor
        public Estado(string nombre)
        {
            // Inicializar atributos
            this.nombre = nombre;
        }

        //Metodos de Seteo

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return this.nombre;
        }


        // Métodos
        public bool esEnCurso()
        {
            if (nombre.Equals("En Curso"))
            { 
                return true;
            }
            else
            {
                return  false;
            }
          
        }

        public bool esFinalizada()
        {
            if (nombre.Equals("Finalizada"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
