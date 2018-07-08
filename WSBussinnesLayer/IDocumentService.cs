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
