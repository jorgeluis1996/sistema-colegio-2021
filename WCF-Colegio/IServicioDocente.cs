using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Colegio
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioDocente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioDocente
    {
        [OperationContract]
        List<DocenteBE> GetAllDocentes();

        [OperationContract]
        DocenteBE GetDocente(Int32 strId);

        [OperationContract]
        Boolean InsertDocente(DocenteBE objDocenteBE);
        [OperationContract]
        Boolean UpdateDocente(DocenteBE objDocenteBE);

        [OperationContract]
        Boolean DeleteDocente(Int32 strCod);

        [OperationContract]
        List<DocenteBE> BuscarDocentes(String ape);

      
    }

    [DataContract]
    [Serializable]
    public class DocenteBE
    {
        private Int32 Id_Docente;
        private Int32 valor_codigo;
        private String codigo;
        private String DNI;
        private String nombres;
        private String apellidos;
        private DateTime fechaNac;
        private String sexo;
        private String grado_estudio;
        private Int32 mvarid_distritro;
        private String mvarnombre_distrito;
        private String Direccion;
        private String email;
        private String Numero_tel;
        private DateTime fecha_regi;
        private DateTime fecha_ult_mod;
        private String usu_ult_mod;
        private Int32 Id_Curso;
        private bool mvaract_doc;
        private string nombresapellidos;

        [DataMember]
        public Int32 Id_Docente1 { get => Id_Docente; set => Id_Docente = value; }
        [DataMember]
        public int Valor_codigo { get => valor_codigo; set => valor_codigo = value; }
        [DataMember]
        public string Codigo { get => codigo; set => codigo = value; }
        [DataMember]
        public string DNI1 { get => DNI; set => DNI = value; }
        [DataMember]
        public string Nombres { get => nombres; set => nombres = value; }
        [DataMember]
        public string Apellidos { get => apellidos; set => apellidos = value; }
        [DataMember]
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        [DataMember]
        public string Sexo { get => sexo; set => sexo = value; }
        [DataMember]
        public string Grado_estudio { get => grado_estudio; set => grado_estudio = value; }
        
        [DataMember]
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        [DataMember]
        public string Email { get => email; set => email = value; }
        [DataMember]
        public string Numero_tel1 { get => Numero_tel; set => Numero_tel = value; }
        [DataMember]
        public string Usu_ult_mod { get => usu_ult_mod; set => usu_ult_mod = value; }

        [DataMember]
        public DateTime Fecha_ult_mod { get => fecha_ult_mod; set => fecha_ult_mod = value; }
        [DataMember]
        public DateTime Fecha_regi { get => fecha_regi; set => fecha_regi = value; }
        [DataMember]
        public int Id_Curso1 { get => this.Id_Curso; set => this.Id_Curso = value; }
        [DataMember]
        public bool Mvaract_doc { get => mvaract_doc; set => mvaract_doc = value; }
        [DataMember]
        public string Mvarnombre_distrito { get => mvarnombre_distrito; set => mvarnombre_distrito = value; }
        [DataMember]
        public int Mvarid_distritro { get => this.mvarid_distritro; set => this.mvarid_distritro = value; }

        [DataMember]
        public string NombresApellidos { get => this.nombresapellidos; set => this.nombresapellidos = value; }
    }
}
