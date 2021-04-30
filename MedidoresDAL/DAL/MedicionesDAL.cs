using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDAL.DAL
{
    public class MedicionesDAL
    {
        MedidoresDBEntities dbMedidores = new MedidoresDBEntities();
        public List<Medicion> GetAll()
        {
           return dbMedidores.Medicion.ToList();
        }

        public void Remove(DateTime fecha)
        {
            Medicion m = dbMedidores.Medicion.Find(fecha);
            dbMedidores.Medicion.Remove(m);
            dbMedidores.SaveChanges();
        }

        public List<Medicion> GetAll(int idmedidor)
        {
            var query = from c in dbMedidores.Medicion where c.IdMedidor == idmedidor select c;
            return query.ToList();
        }
    }


}
