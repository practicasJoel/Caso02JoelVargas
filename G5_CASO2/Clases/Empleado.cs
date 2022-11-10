using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using G5_CASO2.Models;

namespace G5_CASO2.Clases
{
    public class Empleado
    {
        //  METODO PARA LISTAR
        public IEnumerable<EMPLEADO> Consultar()
        {
            using (G5_CASO2Entities db = new G5_CASO2Entities())
            {
                return db.EMPLEADO.ToList();
            }
        }

        //  METODO PARA GUARDAR
        public void Guardar(EMPLEADO modelo)
        {
            using (G5_CASO2Entities db = new G5_CASO2Entities())
            {
                db.EMPLEADO.Add(modelo);
                db.SaveChanges();
            }
        }

        //  METODO PARA MODIFICAR
        public void Modificar(EMPLEADO modelo)
        {
            using (G5_CASO2Entities db = new G5_CASO2Entities())
            {
                db.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        //  METODO PARA ELIMINAR
        public void Eliminar(EMPLEADO modelo)
        {
            using (G5_CASO2Entities db = new G5_CASO2Entities())
            {
                db.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                db.EMPLEADO.Remove(modelo);
                db.SaveChanges();
            }
        }

        // METODO PARA CONSULTAR EL ID
        public EMPLEADO Consultar(int id)
        {
            using (G5_CASO2Entities db = new G5_CASO2Entities())
            {
                return db.EMPLEADO.FirstOrDefault(x => x.ID_EMPLEADO == id);
            }
        }

    }
}