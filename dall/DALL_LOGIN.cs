using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dall
{
    public class DALL_LOGIN
    {
        public usuario login(string email, string pass)
        {
           usuario usu = new usuario();
           
            try
            {
                using (var context = new expedientes_jbjEntities())
                {
                    usu = (from p in context.usuarios where p.Correo.Equals(email) && p.contra.Equals(pass) select p).FirstOrDefault();
                   
                    
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