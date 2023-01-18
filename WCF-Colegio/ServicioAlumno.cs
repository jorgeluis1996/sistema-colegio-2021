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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioAlumno" en el código y en el archivo de configuración a la vez.
    public class ServicioAlumno : IServicioAlumno
    {

        public Boolean RegistrarNotas(AlumnoBE objAlumnoBE)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                Notas objAlumno = new Notas();

                
                objAlumno.Nota1 = objAlumnoBE.Mvarnota1;
                objAlumno.Nota2 = objAlumnoBE.Mvarnota2;
                objAlumno.Nota3 = objAlumnoBE.Mvarnota3;
                objAlumno.Final = objAlumnoBE.Mvarfinal;
                objAlumno.Retroalimentacion = objAlumnoBE.Mvarretro;
                objAlumno.IdAlumno = objAlumnoBE.Mvarid_alumno;
                objAlumno.IdCurso = objAlumnoBE.Mvarid_curso;
                objAlumno.IDPeriodo = objAlumnoBE.Mvarid_periodo;

                bdcolegio.Notas.Add(objAlumno);

                bdcolegio.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public bool DeleteAlumno(Int16 strId)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                bdcolegio.usp_EliminarAlumno(strId);
                bdcolegio.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AlumnoBE> GetAllAlumnos()
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                List<AlumnoBE> objListaAlumno = new List<AlumnoBE>();
                var query = bdcolegio.usp_ListarAlumno();

                foreach (var objAlumno in query)
                {
                    AlumnoBE objAlumnoBE = new AlumnoBE();
                    
                    objAlumnoBE.Mvarid_alumno = (short) objAlumno.IdAlumno;
                    objAlumnoBE.Mvarnom_al = objAlumno.Nombres;
                    objAlumnoBE.Mvarape_al = objAlumno.Apellidos;
                    objAlumnoBE.Mvarcod_al = objAlumno.Codigo;
                    objAlumnoBE.Mvardocide_al = objAlumno.DocumentoIdentidad;
                    objAlumnoBE.Mvarfecnac_al = Convert.ToDateTime(objAlumno.FechaNacimiento);
                    objAlumnoBE.Mvarsex_al= objAlumno.Sexo;
                    objAlumnoBE.Mvarnom_distrito =objAlumno.nombre;
                    objAlumnoBE.Mvardir_al = objAlumno.Direccion;
                    objAlumnoBE.Mvaract_al = objAlumno.Activo.Value;
                    //objAlumnoBE.Mvarfecres_al = Convert.ToDateTime(objAlumno.FechaNacimiento);
                    objAlumnoBE.Mvaridcurso = Convert.ToInt32(objAlumno.Curso);
                    objAlumnoBE.Mvarnota = Convert.ToInt32(objAlumno.Nota);

                    objListaAlumno.Add(objAlumnoBE);
                }

                return objListaAlumno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Boolean InsertAlumno(AlumnoBE objAlumnoBE)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                var query = bdcolegio.usp_RegistrarAlumno(objAlumnoBE.Mvarnom_al, objAlumnoBE.Mvarape_al,
                    objAlumnoBE.Mvardocide_al, objAlumnoBE.Mvarfecnac_al, objAlumnoBE.Mvarsex_al,
                    objAlumnoBE.Mvarid_distrito, objAlumnoBE.Mvardir_al);

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

        public bool UpdateAlumno(AlumnoBE objAlumnoBE)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();

            try
            {
                var query = bdcolegio.usp_EditarAlumno(objAlumnoBE.Mvarid_alumno, 
                    objAlumnoBE.Mvarcod_al, objAlumnoBE.Mvarnom_al, objAlumnoBE.Mvarape_al,
                    objAlumnoBE.Mvardocide_al, objAlumnoBE.Mvarfecnac_al, objAlumnoBE.Mvarsex_al,
                    objAlumnoBE.Mvarid_distrito, objAlumnoBE.Mvardir_al, objAlumnoBE.Mvaract_al, objAlumnoBE.Usu_ult_mod);

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

        public AlumnoBE GetAlumno(Int16 strId)
        {
            BDCOLEGIOEntities MiColegio = new BDCOLEGIOEntities();

            try
            {
                ALUMNO objAlumno = (

                from oAlumno in MiColegio.ALUMNO
                where oAlumno.IdAlumno == strId
                select oAlumno
                ).FirstOrDefault();

                AlumnoBE objAlumnoBE = new AlumnoBE();
                objAlumnoBE.Mvarid_alumno = Convert.ToInt16(objAlumno.IdAlumno);
                objAlumnoBE.Mvarvalorcod_al = Convert.ToInt16(objAlumno.ValorCodigo);
                objAlumnoBE.Mvarcod_al = objAlumno.Codigo;
                objAlumnoBE.Mvarnom_al = objAlumno.Nombres;
                objAlumnoBE.Mvarape_al = objAlumno.Apellidos;
                objAlumnoBE.Mvardocide_al = objAlumno.DocumentoIdentidad;
                objAlumnoBE.Mvarfecnac_al = Convert.ToDateTime(objAlumno.FechaNacimiento);
                objAlumnoBE.Mvarsex_al = objAlumno.Sexo;
                objAlumnoBE.Mvarnom_distrito = objAlumno.idDistrito.ToString();
                objAlumnoBE.Mvaract_al = objAlumno.Activo.Value;
                objAlumnoBE.Mvardir_al = objAlumno.Direccion;
                objAlumnoBE.Mvarfecres_al = Convert.ToDateTime(objAlumno.FechaRegistro);
                objAlumnoBE.Mvaridcurso = Convert.ToInt32(objAlumno.Curso);
                objAlumnoBE.Mvarnota = Convert.ToInt32(objAlumno.Nota);
                return objAlumnoBE;

            }


            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<AlumnoBE> BuscarAlumnos(String ape) 
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                List<AlumnoBE> objListaAlumno = new List<AlumnoBE>();
                var query = bdcolegio.sp_filtroAlumno(ape);

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
                    objAlumnoBE.Mvardir_al = objAlumno.Direccion;
                    objAlumnoBE.Mvarnom_distrito = objAlumno.nombre;
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

        public List<AlumnoBE> GetNotas(int idCur, int idAlum, int idPer)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                List<AlumnoBE> objListaNota = new List<AlumnoBE>();
                var query = bdcolegio.get_notas(idCur,idAlum, idPer);

                foreach (var objAlumno in query)
                {
                    AlumnoBE objAlumnoBE = new AlumnoBE();

                    objAlumnoBE.Mvarnota1 = objAlumno.Nota1;
                    objAlumnoBE.Mvarnota2 = objAlumno.Nota2;
                    objAlumnoBE.Mvarnota3 = objAlumno.Nota3;
                    objAlumnoBE.Mvarfinal = objAlumno.Final;                   

                    objListaNota.Add(objAlumnoBE);
                }

                return objListaNota;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //OBTENER PERIODO
        public List<AlumnoBE> GetPeriodos()
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                List<AlumnoBE> objListaPeriodos = new List<AlumnoBE>();

                var query = (from oPeriodo in bdcolegio.PERIODO
                             select oPeriodo);
                foreach (var objPeriodo in query)
                {
                    AlumnoBE objAlumnoBE = new AlumnoBE();
                    objAlumnoBE.Mvarid_periodo = (short)objPeriodo.IDPeriodo;
                    objAlumnoBE.Mvardes_periodo = objPeriodo.DesPeriodo;


                    objListaPeriodos.Add(objAlumnoBE);
                }

                return objListaPeriodos;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }

}
