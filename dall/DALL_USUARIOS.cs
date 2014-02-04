using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dall
{
    public class DALL_USUARIOS
    {
        public bool Guardar(usuario pusuario)
        {
            bool bGuardado = false;
            usuario Ousuario = new usuario();
            
            int iAdmin = 0;
            
            try
            {
                using (var context = new expedientes_jbjEntities())
                {
                    
                    //CREEAR ADMIN
                    
                        iAdmin = (from p in context.usuarios where p.id_usuario.Equals(pusuario.id_usuario) select p.id_usuario).Count();
                        if (iAdmin == 0)
                       {
                            Ousuario.id_usuario = 0;   
                            Ousuario.Nombres = pusuario.Nombres;
                            Ousuario.Telefono = pusuario.Telefono;
                            Ousuario.Apellidos = pusuario.Apellidos;
                            Ousuario.Correo = pusuario.Correo;
                            Ousuario.Domicilio = pusuario.Domicilio;
                            Ousuario.no_ced = pusuario.no_ced;
                            Ousuario.cod_autorizacion = pusuario.cod_autorizacion;
                            
                            Ousuario.contra = pusuario.contra;
                            Ousuario.Edad = pusuario.Edad;
                            Ousuario.Edo_civil = pusuario.Edo_civil;
                            Ousuario.tipo = pusuario.tipo;
                            Ousuario.Oficio = pusuario.Oficio;
                            context.AddTousuarios(Ousuario);
                        }
                        else
                        {
                            Ousuario = context.usuarios.Where(p => p.id_usuario.Equals(pusuario.id_usuario)).FirstOrDefault();
                            if (Ousuario != null)
                            {

                                Ousuario.Nombres = pusuario.Nombres;
                                Ousuario.Telefono = pusuario.Telefono;
                                Ousuario.Apellidos = pusuario.Apellidos;
                                Ousuario.Correo = pusuario.Correo;
                                Ousuario.Domicilio = pusuario.Domicilio;
                                Ousuario.no_ced = pusuario.no_ced;
                                Ousuario.cod_autorizacion = pusuario.cod_autorizacion;
                                Ousuario.asignacions = pusuario.asignacions;
                                Ousuario.contra = pusuario.contra;
                                Ousuario.Edad = pusuario.Edad;
                                Ousuario.Edo_civil = pusuario.Edo_civil;
                                Ousuario.tipo = pusuario.tipo;
                                Ousuario.Oficio = pusuario.Oficio;
                                
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
    }
}