using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfS_UNIVO_APP_Android
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign)]
    public interface IService1
    {
        [OperationContract(ProtectionLevel =System.Net.Security.ProtectionLevel.Sign)]
        void SegruridadPorControlGranular();

        [OperationContract]
        String ComprobarEstudiante(String usuario, String clave);

        [OperationContract]
        Boolean MateriasInscritas(String carnet, String clave);

        [OperationContract]
        void Notas(String carnet, String clave);

        [OperationContract]
        void PagosRealizados(String carnet, String clave);

        [OperationContract]
        void PerfilEstudiante(String carnet, String clave);
        
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
