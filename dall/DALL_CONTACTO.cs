using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dall
{
    public class DALL_CONTACTO
    {
        public bool GuardarMensaje(consulta pconsulta)
        {
            bool bGuardado = false;
            consulta Oconsulta = new consulta();

            int iAdmin = 0;

            try
            {
                using (var context = new expedientes_jbjEntities())
                {

                    //CREEAR ADMIN

                    //iAdmin = (from p in context.usuarios where p.id_usuario.Equals(pusuario.id_usuario) select p.id_usuario).Count();
                    //if (iAdmin == 0)
                    //{
                        Oconsulta.id_consulta = 0;
                        Oconsulta.nombre = pconsulta.nombre;
                        Oconsulta.fecha = DateTime.Now;
                        Oconsulta.asunto = pconsulta.asunto;
                        Oconsulta.correo = pconsulta.correo;
                        Oconsulta.texto = pconsulta.texto;

                        context.AddToconsultas(Oconsulta);
                    //}
                    //else
                    //{
                    //    Ousuario = context.usuarios.Where(p => p.id_usuario.Equals(pusuario.id_usuario)).FirstOrDefault();
                    //    if (Ousuario != null)
                    //    {

                    //        Ousuario.Nombres = pusuario.Nombres;
                    //        Ousuario.Telefono = pusuario.Telefono;
                    //        Ousuario.Apellidos = pusuario.Apellidos;
                    //        Ousuario.Correo = pusuario.Correo;
                    //        Ousuario.Domicilio = pusuario.Domicilio;
                    //        Ousuario.no_ced = pusuario.no_ced;
                    //        Ousuario.cod_autorizacion = pusuario.cod_autorizacion;
                    //        Ousuario.asignacions = pusuario.asignacions;
                    //        Ousuario.contra = pusuario.contra;
                    //        Ousuario.Edad = pusuario.Edad;
                    //        Ousuario.Edo_civil = pusuario.Edo_civil;
                    //        Ousuario.tipo = pusuario.tipo;
                    //        Ousuario.Oficio = pusuario.Oficio;

                    //    }
                    //}
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

        public bool guardardetconsul (detalle_consulta pdet)
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
                    Oconsulta.id_usuario= pdet.id_usuario;
                    Oconsulta.id_detconsulta = 0;
                    Oconsulta.id_consulta = lstmaxxon;
                    context.AddTodetalle_consulta(Oconsulta);
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

        public bool guardaradjconsul(adj_consultas pdet)
        {
            int lstmaxxon;
            bool bGuardado = false;
            adj_consultas Oconsulta = new adj_consultas();

            int iAdmin = 0;

            try
            {
                using (var context = new expedientes_jbjEntities())
                {
                    lstmaxxon = (from p in context.consultas select p.id_consulta).Max();
                    Oconsulta.Fichero = pdet.Fichero;
                    Oconsulta.id_adjunto = 0;
                    Oconsulta.id_consulta = lstmaxxon;
                }

                return bGuardado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Object llenarbandejagrid(int id1)
        {

            try
            {

                using (var context = new expedientes_jbjEntities())
                {
                    var lstCatterm = (from p in context.consultas
                                      join y in context.detalle_consulta on p.id_consulta equals y.id_consulta
                                      join q in context.usuarios on y.id_usuario equals q.id_usuario
                                     where q.id_usuario.Equals(id1)

                                      select new
                                      {
                                          id=p.id_consulta,
                                          asunto=p.asunto,
                                          nombre=p.nombre,
                                          fecha=p.fecha
                                      }).ToList();
                    return lstCatterm;

                }
                //se retorna la lista

            }
            catch (Exception)
            {
                throw;
            }
        }
        public consulta llenarcontroles(int tipo)
        {
            consulta lista = new consulta();
            try
            {
                using (var context = new expedientes_jbjEntities())
                {
                    lista = (from p in context.consultas where p.id_consulta.Equals(tipo) select p).FirstOrDefault();
                }
                return lista;
            }

            catch (Exception)
            {

                throw;
            }
        }

        public List<usuario> traerusuarios()
        {
            List<usuario> lista = new List<usuario>();
            try
            {
                using (var context = new expedientes_jbjEntities())
                {
                    lista = (from p in context.usuarios where p.tipo.Equals("1")||p.tipo.Equals("2") select p).ToList();
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