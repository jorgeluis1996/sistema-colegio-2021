using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Colegio
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IService3" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService3
    {
        [OperationContract]
        void DoWork();
    }
}
