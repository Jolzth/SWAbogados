using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dall;
namespace BLL_ABOGADOS
{
    public class BLL_CONTACTO
    {
        public bool GuardarMensaje(consulta id)
         {
            bool bguardado = false;
            DALL_CONTACTO dall = new DALL_CONTACTO();
            try
            {
                bguardado = dall.GuardarMensaje(id);
                
                return bguardado;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Object ObtenerCatterminales(int id)
        {
            //creamos un nuevo objeto de la misma lista llamada lstCaplan

            //creamos un nuevo objeto haciendo referencia a la clase fyvCatalogoCatPlanDAL
            DALL_CONTACTO _dal = new DALL_CONTACTO();
            try
            {
                //en esta lista se obtendran los campos que fueron obtenidos desde la dal
                var lstCatterm = _dal.llenarbandejagrid(id);
                //reetornamos la lista
                return lstCatterm;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool guardardetconsulata(detalle_consulta id)
        {
            bool bguardado = false;
            DALL_CONTACTO dall = new DALL_CONTACTO();
            try
            {
                bguardado = dall.guardardetconsul(id);

                return bguardado;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<usuario> traerusuarios() {
           DALL_CONTACTO dall= new DALL_CONTACTO();
            List<usuario> list = new List<usuario>();
            try
            {
                list=dall.traerusuarios();
                return list;
            }
            catch (Exception)
            {
                
                throw;
            }
        
        
        }
    }

}