using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WSBussinnesLayer;
using DTO;

namespace WSApplication
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string DocumentoPorId(int IdDocumento)
        {
            IDocumentService documentService = new DocumentService();
            string documento = documentService.getDocumentoPorId(IdDocumento);

            return documento;
            
        }

        [WebMethod]
        public string ListaDocumentos()
        {

            IDocumentService documentService = new DocumentService();
            string listaDocumentos = documentService.getListaDocumentos();

            return listaDocumentos;

        }

        [WebMethod]
        public string ListaDocumentosPorNombre(string nombreDocumento)
        {

            IDocumentService documentService = new DocumentService();
            string listaDocumentos = documentService.getListaDocumentosPorNombre(nombreDocumento);

            return listaDocumentos;

        }

        [WebMethod]
        public string ListaDocumentosPorFecha(string fechaInicio, string fechaFinal)
        {

            IDocumentService documentService = new DocumentService();
            string listaDocumentos = documentService.getListaDocumentosPorFecha(fechaInicio,fechaFinal);

            return listaDocumentos;

        }


    }
}
