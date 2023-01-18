using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;

namespace WCF_Colegio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioDocente" en el código y en el archivo de configuración a la vez.
    public class ServicioDocente : IServicioDocente
    {
        public bool DeleteDocente(Int32 strCod)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                bdcolegio.SP_EliminarDocente(strCod);
                bdcolegio.SaveChanges();
                return true;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DocenteBE> GetAllDocentes()
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                List<DocenteBE> objListaDocente = new List<DocenteBE>();
                var query = bdcolegio.usp_ListarDocente();

                foreach (var objDocente in query)
                {

                    DocenteBE objDocenteBE = new DocenteBE();

                    objDocenteBE.Id_Docente1 = objDocente.IdDocente;
                    objDocenteBE.Nombres = objDocente.Nombres;
                    objDocenteBE.Apellidos = objDocente.Apellidos;
                    objDocenteBE.DNI1 = objDocente.DocumentoIdentidad;
                    objDocenteBE.FechaNac = Convert.ToDateTime(objDocente.FechaNacimiento);
                    objDocenteBE.Sexo = objDocente.Sexo;
                    objDocenteBE.Mvarnombre_distrito = objDocente.nombre;
                    objDocenteBE.Grado_estudio = objDocente.GradoEstudio;
                    objDocenteBE.Direccion1 = objDocente.Direccion;
                    objDocenteBE.Email = objDocente.Email;
                    objDocenteBE.Mvaract_doc = objDocente.Activo.Value;
                    objDocenteBE.Numero_tel1 = objDocente.NumeroTelefono;
                    objDocenteBE.Codigo = objDocente.Codigo;
                    objDocenteBE.Id_Curso1 = Convert.ToInt32(objDocente.IdCurso);
                    objDocenteBE.NombresApellidos = objDocente.Apellidos + ", " + objDocente.Nombres;
                        
                    


                    objListaDocente.Add(objDocenteBE);




                }
                return objListaDocente;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public bool InsertDocente(DocenteBE objDocenteBE)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                var query = bdcolegio.usp_RegistrarDocente(objDocenteBE.DNI1, objDocenteBE.Nombres,
                    objDocenteBE.Apellidos, objDocenteBE.FechaNac, objDocenteBE.Sexo,
                    objDocenteBE.Grado_estudio, objDocenteBE.Mvarid_distritro, objDocenteBE.Direccion1, objDocenteBE.Email, objDocenteBE.Numero_tel1);

                bdcolegio.SaveChanges();

                if (query == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

               
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public bool UpdateDocente(DocenteBE objDocenteBE)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();

            try
            {
                var query = bdcolegio.usp_EditarDocente(objDocenteBE.Id_Docente1,objDocenteBE.Codigo,objDocenteBE.DNI1, objDocenteBE.Nombres, objDocenteBE.Apellidos, objDocenteBE.FechaNac,
                                                        objDocenteBE.Sexo, objDocenteBE.Grado_estudio, objDocenteBE.Mvarid_distritro, objDocenteBE.Direccion1,
                                                        objDocenteBE.Email, objDocenteBE.Numero_tel1, objDocenteBE.Mvaract_doc, objDocenteBE.Usu_ult_mod);

                bdcolegio.SaveChanges();

                if (query == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public DocenteBE GetDocente(Int32 strId)
        {
            BDCOLEGIOEntities MiColegio = new BDCOLEGIOEntities();

            try
            {
                DOCENTE objDocente = (

                from oDocente in MiColegio.DOCENTE
                where oDocente.IdDocente == strId
                select oDocente
                ).FirstOrDefault();

                DocenteBE objDocenteBE = new DocenteBE();
                objDocenteBE.Id_Docente1 = Convert.ToInt16(objDocente.IdDocente);
                objDocenteBE.Valor_codigo = Convert.ToInt16(objDocente.ValorCodigo);
                objDocenteBE.Codigo = objDocente.Codigo;
                objDocenteBE.DNI1 = objDocente.DocumentoIdentidad;
                objDocenteBE.Nombres = objDocente.Nombres;
                objDocenteBE.Apellidos = objDocente.Apellidos;
                objDocenteBE.FechaNac = Convert.ToDateTime(objDocente.FechaNacimiento);
                objDocenteBE.Sexo = objDocente.Sexo;
                objDocenteBE.Grado_estudio = objDocente.GradoEstudio;
                objDocenteBE.Mvarnombre_distrito = objDocente.idDistrito.ToString();
                objDocenteBE.Mvaract_doc = objDocente.Activo.Value;
                objDocenteBE.Direccion1 = objDocente.Direccion;
                objDocenteBE.Email = objDocente.Email;
                objDocenteBE.Numero_tel1 = objDocente.NumeroTelefono;
                objDocenteBE.FechaNac = Convert.ToDateTime(objDocente.FechaRegistro);
                objDocenteBE.Id_Curso1 = Convert.ToInt32(objDocente.IdCurso);
                
                return objDocenteBE;

            }


            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<DocenteBE> BuscarDocentes(String ape)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                List<DocenteBE> objListaDocente = new List<DocenteBE>();
                var query = bdcolegio.sp_filtroDocente(ape);

                foreach (var objDocente in query)
                {

                    DocenteBE objDocenteBE = new DocenteBE();

                    objDocenteBE.Id_Docente1 = objDocente.IdDocente;
                    objDocenteBE.Nombres = objDocente.Nombres;
                    objDocenteBE.Apellidos = objDocente.Apellidos;
                    objDocenteBE.DNI1 = objDocente.DocumentoIdentidad;
                    objDocenteBE.FechaNac = Convert.ToDateTime(objDocente.FechaNacimiento);
                    objDocenteBE.Sexo = objDocente.Sexo;
                    objDocenteBE.Mvarnombre_distrito = objDocente.nombre;
                    objDocenteBE.Grado_estudio = objDocente.GradoEstudio;
                    objDocenteBE.Direccion1 = objDocente.Direccion;
                    objDocenteBE.Email = objDocente.Email;
                    objDocenteBE.Numero_tel1 = objDocente.NumeroTelefono;
                    objDocenteBE.Codigo = objDocente.Codigo;
                    objDocenteBE.Id_Curso1 = Convert.ToInt32(objDocente.IdCurso);


                    objListaDocente.Add(objDocenteBE);




                }
                return objListaDocente;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }


       

   
    }
}
