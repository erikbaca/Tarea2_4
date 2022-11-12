using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
namespace Tarea2_4.Models
{
    public class contructor
    {

        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }



        [MaxLength(250)]
        public string descripcion { get; set; }


        public string ruta { get; set; }

        

    }
}
