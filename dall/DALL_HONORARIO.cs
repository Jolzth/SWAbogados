using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dall
{
    public class DALL_HONORARIO
    {
        public bool Guardar(honorario phonorario)
        {
            bool bGuardado = false;
            honorario Ohonorario = new honorario();

            int iAdmin = 0;

            try
            {
                using (var context = new expedientes_jbjEntities())
                {



                    iAdmin = (from p in context.honorarios where p.id_honorario.Equals(phonorario.id_honorario) select p.id_honorario).Count();
                    if (iAdmin == 0)
                    {
                        Ohonorario.id_honorario = 0;
                        Ohonorario.Honorario1= phonorario.Honorario1;
                        Ohonorario.Calificacion_legal = phonorario.Calificacion_legal;
                        Ohonorario.Tipo_callegal = phonorario.Tipo_callegal;
                       
                        context.AddTohonorarios(Ohonorario);
                    }
                    else
                    {
                        Ohonorario = context.honorarios.Where(p => p.id_honorario.Equals(phonorario.id_honorario)).FirstOrDefault();
                        if (Ohonorario != null)
                        {
                            Ohonorario.Honorario1 = phonorario.Honorario1;
                            Ohonorario.Calificacion_legal = phonorario.Calificacion_legal;
                            Ohonorario.Tipo_callegal = phonorario.Tipo_callegal;

                        }
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

        public List<honorario> llenargridtipo(string tipo)
        {
            List<honorario> lista = new List<honorario>();
            try
            {
                using (var context = new expedientes_jbjEntities())
                {
                    lista = (from p in context.honorarios where p.Tipo_callegal.Equals(tipo) select p).ToList();
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
            try
            {
                using (var context = new expedientes_jbjEntities())
                {
                    lista = (from p in context.honorarios select p).ToList();
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