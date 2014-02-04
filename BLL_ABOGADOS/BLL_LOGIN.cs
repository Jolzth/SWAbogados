using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dall;
namespace BLL_ABOGADOS
{
    public class BLL_LOGIN
    {
        public usuario login(string email, string pass)
        {
            usuario usu = new usuario();
            DALL_LOGIN dall = new   DALL_LOGIN();
            try
            {
                using (var context = new expedientes_jbjEntities())
                {
                    usu =dall.login(email,pass) ;


                }
                return usu;
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}