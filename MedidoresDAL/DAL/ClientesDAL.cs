using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDAL.DAL
{
    public class ClientesDAL
    {
        MedidoresDBEntities dbMedidores = new MedidoresDBEntities();

        public bool Add(Cliente c)
        {
            bool med = false;
            try
            {
                
                dbMedidores.Cliente.Add(c);
                dbMedidores.SaveChanges();
                med = true;
                return med;
            }
            catch(Exception e)
            {
                return med;
            }

            
        }

        public List<Cliente> GetAll()
        {
            return dbMedidores.Cliente.ToList();
        }
    }
}
