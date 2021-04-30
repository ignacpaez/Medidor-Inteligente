using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDAL.DAL
{
    public class DireccionesDAL
    {
        MedidoresDBEntities dbMedidores = new MedidoresDBEntities();

        public bool Add(Direccion d)
        {         
            bool med = false;
            try 
            {

                dbMedidores.Direccion.Add(d);
                dbMedidores.SaveChanges();
                med = true;
                return med;
            }
            catch (Exception e)
            {
                return med;
            }
        }

        public List<Direccion> GetAll()
        {
            return dbMedidores.Direccion.ToList();
        }
    }
}
