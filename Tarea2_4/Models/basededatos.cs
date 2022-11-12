using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
using Tarea2_4.Models;
using System.Threading.Tasks;

namespace Tarea2_4.Models
{
    public class basededatos
    {
        readonly SQLiteAsyncConnection db;
        public basededatos()
        {
        }


        public basededatos(String pathbasedatos)
        {
            db = new SQLiteAsyncConnection(pathbasedatos);

            // Creación de tablas de base de datos
            db.CreateTableAsync<contructor>();

        }


        
        public Task<List<contructor>> listaempleados()
        {

            return db.Table<contructor>().ToListAsync();
        }

        // Buscar empleados por ID
        public Task<contructor> ObtenerEmpleado(Int32 pcodigo)
        {
            return db.Table<contructor>().Where(i => i.codigo == pcodigo).FirstOrDefaultAsync();
        }


        // Salvar o actualizar empleado

        public Task<Int32> EmpleadoGuardar(contructor emple)
        {
            if (emple.codigo != 0)
            {
                return db.UpdateAsync(emple);
            }
            else
            {
                return db.InsertAsync(emple);
            }
        }

        public Task<Int32> EmpleadoBorrar(contructor emple)
        {
            return db.DeleteAsync(emple);
        }





    }
}
