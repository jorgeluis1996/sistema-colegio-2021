using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_Colegio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "IServicioExtra" en el código y en el archivo de configuración a la vez.
    public class IServicioExtra : IIServicioExtra
    {
        
        public bool AsignarCursoDocente(int idCurso, int idDocente)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                var query = bdcolegio.set_curso_docente(idCurso, idDocente);
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

        public bool AsignarImagenCurso(Byte[] imagen, int idCurso)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                var query = bdcolegio.set_imagen_curso(imagen, idCurso);
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

        public List<AlumnoBE> GetAlumnosDeudores()
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                List<AlumnoBE> objListaAlumno = new List<AlumnoBE>();
                var query = (from oAlumno in bdcolegio.ALUMNO where oAlumno.Activo == false select oAlumno);

                foreach (var objAlumno in query)
                {
                    AlumnoBE objAlumnoBE = new AlumnoBE();

                    objAlumnoBE.Mvarid_alumno = (short)objAlumno.IdAlumno;
                    objAlumnoBE.Mvarnom_al = objAlumno.Nombres;
                    objAlumnoBE.Mvarape_al = objAlumno.Apellidos;
                    objAlumnoBE.Mvarcod_al = objAlumno.Codigo;
                    objAlumnoBE.Mvardocide_al = objAlumno.DocumentoIdentidad;
                    objAlumnoBE.Mvarfecnac_al = Convert.ToDateTime(objAlumno.FechaNacimiento);
                    objAlumnoBE.Mvarsex_al = objAlumno.Sexo;
                    objAlumnoBE.Mvarnom_distrito = objAlumno.idDistrito.ToString();
                    objAlumnoBE.Mvardir_al = objAlumno.Direccion;
                    objAlumnoBE.Mvarfecres_al = Convert.ToDateTime(objAlumno.FechaNacimiento);
                    objAlumnoBE.Mvaridcurso = Convert.ToInt32(objAlumno.Curso);
                    objAlumnoBE.Mvarnota = Convert.ToInt32(objAlumno.Nota);

                    objListaAlumno.Add(objAlumnoBE);
                }

                return objListaAlumno;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AlumnoBE> GetTopAlumnos(int maximo)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                List<AlumnoBE> objListaAlumno = new List<AlumnoBE>();
                var query = bdcolegio.get_top_alumnos(maximo);

                foreach (var objAlumno in query)
                {
                    AlumnoBE objAlumnoBE = new AlumnoBE();

                    objAlumnoBE.Mvarid_alumno = (short)objAlumno.IdAlumno;
                    objAlumnoBE.Mvarnom_al = objAlumno.Nombres;
                    objAlumnoBE.Mvarape_al = objAlumno.Apellidos;
                    objAlumnoBE.Mvarcod_al = objAlumno.Codigo;
                    objAlumnoBE.Mvardocide_al = objAlumno.DocumentoIdentidad;
                    objAlumnoBE.Mvarfecnac_al = Convert.ToDateTime(objAlumno.FechaNacimiento);
                    objAlumnoBE.Mvarsex_al = objAlumno.Sexo;
                    objAlumnoBE.Mvarnom_distrito = objAlumno.nombre;
                    objAlumnoBE.Mvardir_al = objAlumno.Direccion;
                    objAlumnoBE.Mvarfecres_al = Convert.ToDateTime(objAlumno.FechaNacimiento);
                    objAlumnoBE.Mvaridcurso = Convert.ToInt32(objAlumno.Curso);
                    objAlumnoBE.Mvarnota = Convert.ToInt32(objAlumno.Nota);

                    objListaAlumno.Add(objAlumnoBE);
                }

                return objListaAlumno;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

       public bool LoginUsuario(string usuario, string clave)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                var query = bdcolegio.login_usuario(usuario, clave).FirstOrDefault();

                if (query != null)
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

        public List<DistritoBE> ListarDistritos() 
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();

            try
            {
                List<DistritoBE> objListaDistrito = new List<DistritoBE>();
                var query = bdcolegio.sp_ListarDistritos();

                foreach (var objDistrito in query)
                {

                    DistritoBE objDistritoBE = new DistritoBE();

                    objDistritoBE.MvarId_distrito = objDistrito.idDistrito;
                    objDistritoBE.MvarNombre_distritro = objDistrito.nombre;
                    objDistritoBE.MvarDes_distrito = objDistrito.Descripcion;


                    objListaDistrito.Add(objDistritoBE);




                }
                return objListaDistrito;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
