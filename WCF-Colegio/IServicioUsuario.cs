using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WCF_Colegio
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUsuario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUsuario
    {
        [OperationContract]
        Boolean InsertUsuario(UsuarioBE objUsuarioBE);

        [OperationContract]
        Boolean UpdateUsuario(UsuarioBE objUsuarioBE);

        [OperationContract]
        Boolean DeleteUsuario(Int16 strId);

        [OperationContract]
        List <UsuarioBE> GetAllUsuario();

        [OperationContract]
        UsuarioBE GetUsuario(Int32 strId);

       [OperationContract]
        UsuarioBE GetRol(string usuario, string clave);


    }

    [DataContract]
    [Serializable]

    public class UsuarioBE
    {
        //Todo
        private short mvarid_usuario;
        private String mvarnom_us;
        private String mvarape_us;
        private Int16 mvarid_rol;
        private String mvarlog_usuario;
        private String mvarlog_clave;
        private String mvardes_referencia;
        private Int16 mvarid_referencia;
        private Boolean mvarest_usario;
        private DateTime mvarfecha_registro;

        [DataMember]
        
        public short Mvarid_usuario { get => mvarid_usuario; set => mvarid_usuario = value; }

        [DataMember]

        public String Mvarnom_us { get => mvarnom_us; set => mvarnom_us = value; }

        [DataMember]

        public String Mvarape_us { get => mvarape_us; set => mvarape_us = value; }

        [DataMember]

        public Int16 Mvarid_rol { get => mvarid_rol; set => mvarid_rol = value; }

        [DataMember]

        public String Mvarlog_usuario { get => mvarlog_usuario; set => mvarlog_usuario = value; }

        [DataMember]

        public String Mvarlog_clave { get => mvarlog_clave; set => mvarlog_clave = value; }

        [DataMember]

        public String Mvardes_referencia { get => mvardes_referencia; set => mvardes_referencia = value; }

        [DataMember]

        public short Mvarid_referencia { get => mvarid_referencia; set => mvarid_referencia = value; }

        

        [DataMember]

        public DateTime Mvarfecha_registro { get => mvarfecha_registro; set => mvarfecha_registro = value; }

    }
}
