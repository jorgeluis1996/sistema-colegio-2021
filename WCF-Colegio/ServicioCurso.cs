using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data.Entity.Core;

namespace WCF_Colegio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCurso" en el código y en el archivo de configuración a la vez.
    public class ServicioCurso : IServicioCurso
    {
        /*public Boolean InsertCurso(CursoBE objCursoBE)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();

            try
            {
                var query = bdcolegio.usp_RegistrarCurso(objCursoBE.Descripcion, objCursoBE.Codigo, objCursoBE.Nivel);

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
        */

        public Boolean RegistrarCurso(CursoBE objCursoBE)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                CURSO objCurso = new CURSO();


                objCurso.Descripcion = objCursoBE.Descripcion;
                objCurso.CODIGO = objCursoBE.Codigo;
                objCurso.IDNivel = objCursoBE.IdNivel;
                objCurso.FechaRegistro = objCursoBE.FechaRegistro;
                objCurso.Activo = objCursoBE.Activocur;
               

                bdcolegio.CURSO.Add(objCurso);

                bdcolegio.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public Boolean UpdateCurso(CursoBE objCursoBE)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                var query = bdcolegio.usp_EditarCurso(objCursoBE.IdCurso, objCursoBE.Descripcion,objCursoBE.Activocur);

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

        public Boolean DeleteCurso(short strId)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();

            try
            {
                bdcolegio.usp_EliminarCurso(strId);
                bdcolegio.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<CursoBE> GetCursos()
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                List<CursoBE> objListaCursos = new List<CursoBE>();

                var query = (from oCurso in bdcolegio.CURSO                                                      
                             select oCurso);
                foreach (var objCurso in query)
                {
                    CursoBE objCursoBE = new CursoBE();
                    objCursoBE.IdCurso = (short)objCurso.IdCurso;
                    objCursoBE.Descripcion = objCurso.Descripcion;
                    objCursoBE.Codigo = objCurso.CODIGO;
                    objCursoBE.Activocur = objCurso.Activo.Value;
                    objCursoBE.FechaRegistro = Convert.ToDateTime(objCurso.FechaRegistro);
                    objCursoBE.IdNivel = (short)objCurso.IDNivel;               

                    objListaCursos.Add(objCursoBE);
                }

                return objListaCursos;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CursoBE GetCurso(Int32 strId)
        {
            BDCOLEGIOEntities MiColegio = new BDCOLEGIOEntities();

            try
            {
                CURSO objCurso = (

                from oCurso in MiColegio.CURSO
                where oCurso.IdCurso == strId
                select oCurso
                ).FirstOrDefault();

                CursoBE objCursoBE = new CursoBE();
                objCursoBE.IdCurso = Convert.ToInt16(objCurso.IdCurso);
                objCursoBE.Codigo = objCurso.CODIGO;
                objCursoBE.Descripcion = objCurso.Descripcion;
                objCursoBE.FechaRegistro = Convert.ToDateTime(objCurso.FechaRegistro);
                objCursoBE.Activocur = objCurso.Activo.Value;
                objCursoBE.IdNivel = Convert.ToInt16(objCurso.IDNivel);
              

                return objCursoBE;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //OBTENER NIVELES
        public List<CursoBE> GetNiveles()
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                List<CursoBE> objListaNiveles = new List<CursoBE>();

                var query = (from oNivel in bdcolegio.NIVEL
                             select oNivel);
                foreach (var objNivel in query)
                {
                    CursoBE objCursoBE = new CursoBE();
                    objCursoBE.IdNivel = (short)objNivel.Nivel1;
                    objCursoBE.Nivel = objNivel.desNivel;


                    objListaNiveles.Add(objCursoBE);
                }

                return objListaNiveles;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CursoBE DetalleCursoNivel(Int16 strId)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                CURSO objCurso = (

                from oCurso in bdcolegio.CURSO
                where oCurso.IdCurso == strId
                select oCurso
                ).FirstOrDefault();

                CursoBE objCursoBE = new CursoBE();
                objCursoBE.IdCurso = (short)objCurso.IdCurso;
                objCursoBE.Descripcion = objCurso.Descripcion;
                objCursoBE.Codigo = objCurso.CODIGO;
                objCursoBE.IdNivel = Convert.ToInt16(objCurso.IDNivel);
                

                return objCursoBE;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
