using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_Colegio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUsuario" en el código y en el archivo de configuración a la vez.
    public class ServicioUsuario : IServicioUsuario
    {
        public bool DeleteUsuario(Int16 strId)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();

            try
            {
                USUARIO objUsuario = (
                    from oUsuario in bdcolegio.USUARIO
                    where oUsuario.IdUsuario == strId
                    select oUsuario).FirstOrDefault();

                bdcolegio.USUARIO.Remove(objUsuario);
                bdcolegio.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        public List<UsuarioBE> GetAllUsuario()
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();

            try
            {
                List<UsuarioBE> objListaUsuario = new List<UsuarioBE>();

                var query = (from oUsuario in bdcolegio.USUARIO select oUsuario);

                foreach (var objUsuario in query)
                {
                    UsuarioBE objUsuarioBE = new UsuarioBE();

                    objUsuarioBE.Mvarid_usuario = (short)objUsuario.IdUsuario;
                    objUsuarioBE.Mvarnom_us = objUsuario.Nombres;
                    objUsuarioBE.Mvarape_us = objUsuario.Apellidos;
                    objUsuarioBE.Mvarid_rol = (short)objUsuario.IdRol;
                    objUsuarioBE.Mvarlog_usuario = objUsuario.LoginUsuario;
                    objUsuarioBE.Mvarlog_clave = objUsuario.LoginClave;
                    objUsuarioBE.Mvardes_referencia = objUsuario.DescripcionReferencia;
                    objUsuarioBE.Mvarid_referencia = (short)objUsuario.IdReferencia;
                    objUsuarioBE.Mvarfecha_registro = Convert.ToDateTime(objUsuario.FechaRegistro);




                    objListaUsuario.Add(objUsuarioBE);

                }

                return objListaUsuario;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        public Boolean InsertUsuario(UsuarioBE objUsuarioBE)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();

            try
            {
                USUARIO objUsuario = new USUARIO();


                objUsuario.IdUsuario = objUsuarioBE.Mvarid_usuario;
                objUsuario.Nombres = objUsuarioBE.Mvarnom_us;
                objUsuario.Apellidos = objUsuarioBE.Mvarape_us;
                objUsuario.IdRol = objUsuarioBE.Mvarid_rol;
                objUsuario.LoginUsuario = objUsuarioBE.Mvarlog_usuario;
                objUsuario.LoginClave = objUsuarioBE.Mvarlog_clave;
                objUsuario.DescripcionReferencia = objUsuarioBE.Mvardes_referencia;
                objUsuario.IdReferencia = objUsuarioBE.Mvarid_referencia;
                objUsuario.FechaRegistro = Convert.ToDateTime(objUsuarioBE.Mvarfecha_registro);

                bdcolegio.USUARIO.Add(objUsuario);

                bdcolegio.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public bool UpdateUsuario(UsuarioBE objUsuarioBE)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();

            try
            {
                USUARIO objUsuario = (
                    from oUsuario in bdcolegio.USUARIO
                    where oUsuario.IdUsuario == objUsuarioBE.Mvarid_usuario
                    select oUsuario).FirstOrDefault();


                
                objUsuario.Nombres = objUsuarioBE.Mvarnom_us;
                objUsuario.Apellidos = objUsuarioBE.Mvarape_us;
                objUsuario.IdRol = objUsuarioBE.Mvarid_rol;
                objUsuario.LoginUsuario = objUsuarioBE.Mvarlog_usuario;
                objUsuario.LoginClave = objUsuarioBE.Mvarlog_clave;
                objUsuario.DescripcionReferencia = objUsuarioBE.Mvardes_referencia;
                objUsuario.IdReferencia = objUsuarioBE.Mvarid_referencia;
                objUsuario.FechaRegistro = Convert.ToDateTime(objUsuarioBE.Mvarfecha_registro);

                bdcolegio.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public UsuarioBE GetUsuario(Int32 strId)
        {
            BDCOLEGIOEntities MiColegio = new BDCOLEGIOEntities();

            try
            {
                USUARIO objUsuario = (

                from oUsuario in MiColegio.USUARIO
                where oUsuario.IdUsuario == strId
                select oUsuario
                ).FirstOrDefault();

                UsuarioBE objUsuarioBE = new UsuarioBE();
                objUsuarioBE.Mvarid_usuario = Convert.ToInt16(objUsuario.IdUsuario);
                objUsuarioBE.Mvarnom_us = objUsuario.Nombres;
                objUsuarioBE.Mvarape_us = objUsuario.Apellidos;
                objUsuarioBE.Mvarid_rol = Convert.ToInt16(objUsuario.IdRol);
                objUsuarioBE.Mvarlog_usuario = objUsuario.LoginUsuario;
                objUsuarioBE.Mvarlog_clave = objUsuario.LoginClave;
                objUsuarioBE.Mvardes_referencia = objUsuario.DescripcionReferencia;
                objUsuarioBE.Mvarid_referencia = Convert.ToInt16(objUsuario.IdReferencia);
                objUsuarioBE.Mvarfecha_registro = Convert.ToDateTime(objUsuario.FechaRegistro);

                return objUsuarioBE;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public UsuarioBE GetRol(string usuario, string clave)
        {
            BDCOLEGIOEntities MiColegio = new BDCOLEGIOEntities();

            try
            {

               USUARIO objUsuario = (

               from oUsuario in MiColegio.USUARIO
               where oUsuario.LoginUsuario == usuario
               && oUsuario.LoginClave == clave
               select oUsuario
               ).FirstOrDefault();

                UsuarioBE objUsuarioBE = new UsuarioBE();
                objUsuarioBE.Mvarid_rol = Convert.ToInt16(objUsuario.RolUsuario);
                
                return objUsuarioBE;


            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
