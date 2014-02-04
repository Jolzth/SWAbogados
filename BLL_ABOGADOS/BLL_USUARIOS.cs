using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dall;
namespace BLL_ABOGADOS
{
    public class BLL_USUARIOS
    {
        public bool Guardar(usuario oUsuario)
        {
            bool bguardado = false;
            DALL_USUARIOS dall = new DALL_USUARIOS();
            try
            {
                bguardado = dall.Guardar(oUsuario);
                
                return bguardado;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}