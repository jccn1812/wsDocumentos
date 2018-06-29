using System.Collections.Generic;

namespace DTO
{
    public class Documentos
    {
        private int _CuentaDocumentos;
        private List<Documento> _ListaDocumentos = new List<Documento>();

        public List<Documento> ListaDocumentos
        {
            get { return _ListaDocumentos; }
            set { _ListaDocumentos = value; }
        }

        public int CuentaDocumentos
        {
            get { return _CuentaDocumentos; }
            set { _CuentaDocumentos = value; }
        }
        

    }
}
