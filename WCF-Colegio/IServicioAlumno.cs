using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Colegio
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioAlumno" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioAlumno
    {
        [OperationContract]
        Boolean RegistrarNotas(AlumnoBE objAlumnoBE);

        [OperationContract]
        Boolean InsertAlumno(AlumnoBE objAlumnoBE);

        [OperationContract]
        Boolean UpdateAlumno(AlumnoBE objAlumnoBE);

        [OperationContract]
        Boolean DeleteAlumno(Int16 strId);

        [OperationContract]
        List<AlumnoBE> GetAllAlumnos();

        [OperationContract]
        AlumnoBE GetAlumno(Int16 strId);

        [OperationContract]
        List<AlumnoBE> BuscarAlumnos(String ape);

        [OperationContract]
        List<AlumnoBE> GetNotas(Int32 idCur, Int32 idAlum, Int32 idPer);

        [OperationContract]
        List<AlumnoBE> GetPeriodos();

    }

    [DataContract]
    [Serializable]
    public class AlumnoBE
    {
        // TODO
        private short mvarid_alumno;
        private Int16 mvarvalorcod_al;
        private String mvarcod_al;
        private String mvarnom_al;
        private String mvarape_al;
        private String mvardocide_al;
        private DateTime mvarfecnac_al;
        private String mvarsex_al;
        private String mvarnom_distrito;
        private Int16 mvarid_distrito;
        private String mvardir_al;
        private bool mvaract_al;
        private DateTime mvarfecres_al;
        private DateTime fecha_ult_mod;
        private String usu_ult_mod;
        private Int32 mvaridcurso;
        private Int32 mvarnota;

        private Int32 mvarid_curso;
        private Int32 mvarnota1;
        private Int32 mvarnota2;
        private Int32 mvarnota3;
        private Int32 mvarfinal;
        private Double mvarpromedio;
        private String mvarretro;

        private Int32 mvarid_periodo;
        private String mvardes_periodo;
       

        [DataMember]
        public short Mvarid_alumno { get => mvarid_alumno; set => mvarid_alumno = value; }
        [DataMember]
        public short Mvarvalorcod_al { get => mvarvalorcod_al; set => mvarvalorcod_al = value; }
        [DataMember] 
        public string Mvarcod_al { get => mvarcod_al; set => mvarcod_al = value; }
        [DataMember] 
        public string Mvarnom_al { get => mvarnom_al; set => mvarnom_al = value; }
        [DataMember] 
        public string Mvarape_al { get => mvarape_al; set => mvarape_al = value; }
        [DataMember] 
        public string Mvardocide_al { get => mvardocide_al; set => mvardocide_al = value; }
        [DataMember] 
        public DateTime Mvarfecnac_al { get => mvarfecnac_al; set => mvarfecnac_al = value; }
        [DataMember]
        public string Mvarsex_al { get => mvarsex_al; set => mvarsex_al = value; }
     
        [DataMember] 
        public string Mvardir_al { get => mvardir_al; set => mvardir_al = value; }

        [DataMember]
        public string Usu_ult_mod { get => usu_ult_mod; set => usu_ult_mod = value; }

        [DataMember]
        public DateTime Fecha_ult_mod { get => fecha_ult_mod; set => fecha_ult_mod = value; }
        [DataMember] 
        public DateTime Mvarfecres_al { get => mvarfecres_al; set => mvarfecres_al = value; }

        [DataMember]
        public int Mvaridcurso { get => mvaridcurso; set => mvaridcurso = value; }
        [DataMember]
        public int Mvarnota { get => mvarnota; set => mvarnota = value; }
        [DataMember]
        public bool Mvaract_al { get => mvaract_al; set => mvaract_al = value; }
        [DataMember]
        public String Mvarnom_distrito { get => mvarnom_distrito; set => mvarnom_distrito = value; }
        [DataMember]
        public Int16 Mvarid_distrito { get => mvarid_distrito; set => mvarid_distrito = value; }

        [DataMember]
        public int Mvarid_curso { get => mvarid_curso; set => mvarid_curso = value; }
        
        [DataMember]
        public int Mvarnota1 { get => mvarnota1; set => mvarnota1 = value; }
        [DataMember]
        public int Mvarnota2 { get => mvarnota2; set => mvarnota2 = value; }
        [DataMember]
        public int Mvarnota3 { get => mvarnota3; set => mvarnota3 = value; }
        [DataMember]
        public int Mvarfinal { get => mvarfinal; set => mvarfinal = value; }
        [DataMember]
        public double Mvarpromedio { get => mvarpromedio; set => mvarpromedio = value; }
        [DataMember]
        public string Mvarretro { get => mvarretro; set => mvarretro = value; }
        [DataMember]
        public Int32 Mvarid_periodo { get => mvarid_periodo; set => mvarid_periodo = value; }
        [DataMember]
        public string Mvardes_periodo { get => mvardes_periodo; set => mvardes_periodo = value; }
    }
}

