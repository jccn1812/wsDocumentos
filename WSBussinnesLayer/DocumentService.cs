using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using WSDAOLayer;
using System.Web.Script.Serialization;



namespace WSBussinnesLayer
{
    public class DocumentService : IDocumentService
    {

        public string getDocumentoPorId(int IdDocumento)
        {
            FiltroDocumento documentoFiltro = new FiltroDocumento();
            documentoFiltro.IdDocumento = IdDocumento;
            IDocumentDao DocumentDao = new DocumentDao();

            Documento documento = DocumentDao.DocumentById(documentoFiltro);

            var json = new JavaScriptSerializer().Serialize(documento);
            return json;
           
        }

        public string getListaDocumentos()
        {
            IDocumentDao DocumentDao = new DocumentDao();
            Documentos listaDocumentos = DocumentDao.ListaDocumentos();

            var json = new JavaScriptSerializer().Serialize(listaDocumentos);
            return json;

        }


        public string getListaDocumentosPorNombre(string nombreDocumento)
        {
            FiltroDocumento documentoFiltro = new FiltroDocumento();
            documentoFiltro.NombreDocumento = nombreDocumento;
            IDocumentDao DocumentDao = new DocumentDao();

            Documentos documento = DocumentDao.DocumentByName(documentoFiltro);

            var json = new JavaScriptSerializer().Serialize(documento);
            return json;

        }


        public string getListaDocumentosPorFecha(string fechaInicial,string fechaFinal)
        {
            FiltroDocumento documentoFiltro = new FiltroDocumento();
            documentoFiltro.fechaInicial = fechaInicial;
            documentoFiltro.fechaFinal = fechaFinal;
            IDocumentDao DocumentDao = new DocumentDao();

            Documentos documento = DocumentDao.DocumentByDate(documentoFiltro);

            var json = new JavaScriptSerializer().Serialize(documento);
            return json;

        }


        
    }
}
