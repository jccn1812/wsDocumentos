using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace WSBussinnesLayer
{
    public interface IDocumentService
    {
        string getDocumentoPorId(int IdDocumento);
        string getListaDocumentos();
        string getListaDocumentosPorNombre(string nombreDocumento);
        string getListaDocumentosPorFecha(string fechaInicial, string fechaFinal);
    }
}
