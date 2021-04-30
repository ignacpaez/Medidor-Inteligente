using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDAL.DAL
{
    public class MedidorDAL
    {
        MedidoresDBEntities dbMedidores = new MedidoresDBEntities();
        public void Add(Medidor m)
        {
            dbMedidores.Medidor.Add(m);
            dbMedidores.SaveChanges();
        }
        
        public List<Medidor> GetAll()
        {
            return dbMedidores.Medidor.ToList();
        }

        public List<Medidor> GetAll(string tipo)
        {
            var query = from c in dbMedidores.Medidor where c.Tipo == tipo select c;
            return query.ToList();
        }

        
    }
}
