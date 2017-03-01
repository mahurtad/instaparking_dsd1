using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosPC4
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IOrdenesCompra" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IOrdenesCompra
    {
        [OperationContract]
        List<OrdenesCompraBe> ListarOrdenes();
        [OperationContract]
        List<OrdenesCompraBe> ListarOrdenesProveedor(string CodPro);
        [OperationContract]
        List<OrdenesCompraBe> ListarOrdenesEstado(string Estado);
    }

    [DataContract]
    [Serializable]
    public class OrdenesCompraBe
    {
        [DataMember]
        public string NumOco { get; set; }
        [DataMember]
        public DateTime FechaOco { get; set; }
        [DataMember]
        public string CodProv { get; set; }
        [DataMember]
        public DateTime FecAte { get; set; }
        [DataMember]
        public string EstaOco { get; set; }
        [DataMember]
        public string RazonProv { get; set; }
        [DataMember]
        public string DistrProv { get; set; }
        [DataMember]
        public string DireccionProv { get; set; }
    
    }

}
