using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDAL.DAL
{
    public class RegionesDAL
    {
        MedidoresDBEntities dbMedidores = new MedidoresDBEntities();

        public List<Region> GetAll()
        {
           return dbMedidores.Region.ToList();
        }
    }
}
