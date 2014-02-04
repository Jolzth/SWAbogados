using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dall;
namespace BLL_ABOGADOS
{
    public class BLL_HONORARIO
    {
        public bool Guardar(honorario oUsuario)
        {
            bool bguardado = false;
            DALL_HONORARIO dall = new DALL_HONORARIO();
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

        public List<honorario> llenargridtipo(string tipo)
        {
            List<honorario> lista = new List<honorario>();
            DALL_HONORARIO dall = new DALL_HONORARIO();
            try
            {
                using (var context = new expedientes_jbjEntities())
                {
                    lista = dall.llenargridtipo(tipo);
                }
                return lista;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public List<honorario> llenargridtipotodos()
        {
            List<honorario> lista = new List<honorario>();
            DALL_HONORARIO dall = new DALL_HONORARIO();
            try
            {
                using (var context = new expedientes_jbjEntities())
                {
                    lista = dall.llenargridtipotodos();
                }
                return lista;
            }

            catch (Exception)
            {

                throw;
            }
        }
        
        
    }
}