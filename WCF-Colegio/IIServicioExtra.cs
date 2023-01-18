using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Colegio
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IIServicioExtra" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IIServicioExtra
    {


        [OperationContract]
        bool AsignarCursoDocente(int idCurso, int idDocente);

        [OperationContract]
        List<AlumnoBE> GetTopAlumnos(int maximo);

        [OperationContract]
        bool AsignarImagenCurso(Byte[] imagen, int idCurso);

        [OperationContract]
        List<AlumnoBE> GetAlumnosDeudores();

        [OperationContract]
       bool LoginUsuario(String usuario, String clave);

        [OperationContract]
        List<DistritoBE> ListarDistritos();
    }

    [DataContract]
    [Serializable]
    public class DistritoBE
    {
        private Int32 mvarId_distrito;
        private String mvarNombre_distritro;
        private String mvarDes_distrito;



        [DataMember]
        public int MvarId_distrito { get => mvarId_distrito; set => mvarId_distrito = value; }
        [DataMember]
        public string MvarNombre_distritro { get => mvarNombre_distritro; set => mvarNombre_distritro = value; }
        [DataMember]
        public string MvarDes_distrito { get => mvarDes_distrito; set => mvarDes_distrito = value; }


    }
}
