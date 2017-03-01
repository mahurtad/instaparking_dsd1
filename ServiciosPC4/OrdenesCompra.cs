using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosPC4
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "OrdenesCompra" en el código y en el archivo de configuración a la vez.
    public class OrdenesCompra : IOrdenesCompra
    {
        VentasLeonEntities _ctx = new VentasLeonEntities();
        public List<OrdenesCompraBe> ListarOrdenes()
        {
            try
            {
                List<OrdenesCompraBe> listaOrdenes = new List<OrdenesCompraBe>();
                var query = _ctx.Tb_Orden_Compra.ToList();

                foreach (var resultado in query)
                {
                   OrdenesCompraBe obOrdenes = new OrdenesCompraBe();
                   obOrdenes.NumOco = resultado.Num_oco;
                   obOrdenes.FecAte = Convert.ToDateTime(resultado.Fec_ate);
                   obOrdenes.FechaOco = Convert.ToDateTime(resultado.Fec_oco);
                   obOrdenes.RazonProv = resultado.Tb_Proveedor.Raz_soc_prv;
                   obOrdenes.DireccionProv = resultado.Tb_Proveedor.Dir_prv;
                   obOrdenes.DistrProv = resultado.Tb_Proveedor.Tb_Distrito.Nom_dis;
                   obOrdenes.EstaOco = resultado.Est_oco;
                    listaOrdenes.Add(obOrdenes);

                }
                return listaOrdenes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<OrdenesCompraBe> ListarOrdenesProveedor(string CodPro)
        {
            try
            {
                List<OrdenesCompraBe> listaOrdenes = new List<OrdenesCompraBe>();
                var query = (from oc in _ctx.Tb_Orden_Compra where oc.Cod_prv == CodPro select oc).ToList();

                foreach (var resultado in query)
                {
                    OrdenesCompraBe obOrdenes = new OrdenesCompraBe();
                    obOrdenes.NumOco = resultado.Num_oco;
                    obOrdenes.FecAte = Convert.ToDateTime(resultado.Fec_ate);
                    obOrdenes.FechaOco = Convert.ToDateTime(resultado.Fec_oco);
                    obOrdenes.RazonProv = resultado.Tb_Proveedor.Raz_soc_prv;
                    obOrdenes.DireccionProv = resultado.Tb_Proveedor.Dir_prv;
                    obOrdenes.DistrProv = resultado.Tb_Proveedor.Tb_Distrito.Nom_dis;
                    obOrdenes.EstaOco = resultado.Est_oco;
                    listaOrdenes.Add(obOrdenes);

                }
                return listaOrdenes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<OrdenesCompraBe> ListarOrdenesEstado(string Estado)
        {
            try
            {
                List<OrdenesCompraBe> listaOrdenes = new List<OrdenesCompraBe>();
                var query = (from oc in _ctx.Tb_Orden_Compra where oc.Est_oco == Estado select oc).ToList();

                foreach (var resultado in query)
                {
                    OrdenesCompraBe obOrdenes = new OrdenesCompraBe();
                    obOrdenes.NumOco = resultado.Num_oco;
                    obOrdenes.FecAte = Convert.ToDateTime(resultado.Fec_ate);
                    obOrdenes.FechaOco = Convert.ToDateTime(resultado.Fec_oco);
                    obOrdenes.RazonProv = resultado.Tb_Proveedor.Raz_soc_prv;
                    obOrdenes.DireccionProv = resultado.Tb_Proveedor.Dir_prv;
                    obOrdenes.DistrProv = resultado.Tb_Proveedor.Tb_Distrito.Nom_dis;
                    obOrdenes.EstaOco = resultado.Est_oco;
                    listaOrdenes.Add(obOrdenes);

                }
                return listaOrdenes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
