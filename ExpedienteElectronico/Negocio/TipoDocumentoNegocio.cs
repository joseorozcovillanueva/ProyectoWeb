using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace Negocio
{
    public class TipoDocumentoNegocio
    {
        public int insertarTipoDocumento(TipoDocumento _tipoDocumento)
        {
            TipoDocumentoDao dao = new TipoDocumentoDao();

            return dao.InsertaTipoDocumento(_tipoDocumento);
        }

        public List<TipoDocumento> obtenerTipoDocumento()
        {
            TipoDocumentoDao dao = new TipoDocumentoDao();

            return dao.obtenerTipoDocumento();
        }

        public void modificaTipoDocumento(TipoDocumento _tipoDocumento)
        {
            TipoDocumentoDao dao = new TipoDocumentoDao();

            dao.modificaTipoDocumento(_tipoDocumento);
        }

        public void eliminaParametro(TipoDocumento _tipoDocumento)
        {
            TipoDocumentoDao dao = new TipoDocumentoDao();

            dao.eliminaTipoDocumento(_tipoDocumento);
        }
    }
}
