using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDAL.DAL
{
    public class TrabajadorDAL
    {
        private MedidoresDBEntities dbMedidores = new MedidoresDBEntities();

        public bool VerificarLogin(string correo, string password)
        {
            bool med = false;
            var query = from c in dbMedidores.Trabajador where c.Correo.Equals (correo) && c.Clave.Equals(password) select c;
            if (query.ToList().Count == 1)
            {
                med = true;
            }
            return med;
        }
    }
}
