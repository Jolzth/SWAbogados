using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dall
{
    public class DALL_ASIGNACION
    {
        public bool Guardar(asignacion pasignacion)
        {
            bool bGuardado = false;
            asignacion Oasignacion = new asignacion();

            int iAdmin = 0;

            try
            {
                using (var context = new expedientes_jbjEntities())
                {



                    iAdmin = (from p in context.asignacions where p.id_asignacion.Equals(pasignacion.id_asignacion) select p.id_asignacion).Count();
                    if (iAdmin == 0)
                    {
                    Oasignacion.id_asignacion = 0;
                    Oasignacion.id_gestion = pasignacion.id_gestion;
                    Oasignacion.id_usuario = pasignacion.id_usuario;
                    context.AddToasignacions(Oasignacion);
                    }
                  
                    context.SaveChanges();
                    bGuardado = true;
                }

                return bGuardado;

            }






            catch (Exception)
            {

                throw;
            }





        }

        public bool guardardetconsul(detalle_consulta pdet)
        {
            int lstmaxxon;
            bool bGuardado = false;
            detalle_consulta Oconsulta = new detalle_consulta();

            int iAdmin = 0;

            try
            {
                using (var context = new expedientes_jbjEntities())
                {
                    lstmaxxon = (from p in context.consultas select p.id_consulta).Max();
                    Oconsulta.id_usuario = pdet.id_usuario;
                    Oconsulta.id_detconsulta = 0;
                    Oconsulta.id_consulta = lstmaxxon;
                }

                return bGuardado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //public object mostrarGestionesAsignadas(int id) {
        //    try
        //    {

        //        using (var context = new expedientes_jbjEntities())
        //        {
        //            var lstCatterm = (from p in context.asignacions
        //                              join y in context.detalle_consulta on p.id_consulta equals y.id_consulta
        //                              join q in context.usuarios on y.id_usuario equals q.id_usuario
        //                              where q.id_usuario.Equals(id)

        //                              select new
        //                              {
        //                                  id = p.id_consulta,
        //                                  asunto = p.asunto,
        //                                  nombre = p.nombre,
        //                                  fecha = p.fecha
        //                              }).ToList();
        //            return lstCatterm;

        //        }
        //        //se retorna la lista

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}