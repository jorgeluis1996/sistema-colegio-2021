using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Colegio
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCurso" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCurso
    {
        /*[OperationContract]
        Boolean InsertCurso(CursoBE objCursoBE);*/

        [OperationContract]
        Boolean UpdateCurso(CursoBE objCursoBE);

        [OperationContract]
        Boolean DeleteCurso(short strId);

        [OperationContract]
        CursoBE GetCurso(Int32 strId);

        [OperationContract]
        List<CursoBE> GetCursos();

        [OperationContract]
        List<CursoBE> GetNiveles();

        [OperationContract]
        Boolean RegistrarCurso(CursoBE objCursoBE);

        [OperationContract]
        CursoBE DetalleCursoNivel(Int16 strId);



    }

    [DataContract]
    [Serializable]
    public class CursoBE
    {
        private short mvarid_curso;
        private String mvardescripcion;
        private String mvarcodigo;
        private String mvarnivel;
        private Boolean activocur;
        private DateTime mvarfecharegistro;
        private Byte[] mvarimagen;
        private Int32 idnivel;
        private string desNivel;

        [DataMember]
        public Int32 IdNivel
        {
            get { return idnivel; }
            set { idnivel = value; }
        }

        public String DesNivel
        {
            get { return desNivel; }
            set { desNivel = value; }
        }

        [DataMember]
        public short IdCurso
        {
            get { return mvarid_curso; }
            set { mvarid_curso = value; }
        }

        [DataMember]
        public String Descripcion
        {
            get { return mvardescripcion; }
            set { mvardescripcion = value; }
        }

        [DataMember]
        public String Codigo
        {
            get { return mvarcodigo; }
            set { mvarcodigo = value; }
        }

        [DataMember]
        public String Nivel
        {
            get { return mvarnivel; }
            set { mvarnivel = value; }
        }

        [DataMember]
        public DateTime FechaRegistro
        {
            get { return mvarfecharegistro; }
            set { mvarfecharegistro = value; }
        }

        [DataMember]
        public Byte[] Imagen
        {
            get { return mvarimagen; }
            set { mvarimagen = value; }
        }

        [DataMember]
        public Boolean Activocur { get => activocur; set => activocur = value; }
    }
}
