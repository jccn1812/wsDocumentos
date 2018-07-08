using DTO;

namespace WSDAOLayer
{
    public interface IDocumentDao
    {
         Documento DocumentById(FiltroDocumento filtro);
         Documentos ListaDocumentos();
         Documentos DocumentByName(FiltroDocumento filtro);
         Documentos DocumentByDate(FiltroDocumento filtro);
    }
}
