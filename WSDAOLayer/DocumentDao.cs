using System;
using System.Data.SqlClient;
using DTO;



namespace WSDAOLayer
{
    public class DocumentDao : IDocumentDao
    {
        private string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            
        public Documento DocumentById(FiltroDocumento filtro)
        {
            Documento dcto = new Documento();

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("sp_select_obtieneDocumentoPorId", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                {
                    command.Parameters.AddWithValue("@IdDocumento", filtro.IdDocumento);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dcto.IdDocumento =  Int32.Parse(reader["IdDocumento"].ToString());
                            dcto.NombreDocumento = reader["nombreDocumento"].ToString();
                            dcto.NombreAutor     = reader["nombreAutor"].ToString();
                            dcto.Ruta = reader["ruta"].ToString();
                            dcto.FechaCreacion = reader["fechaPublicacion"].ToString();
                            dcto.Resumen = reader["resumen"].ToString();
                            dcto.Tipo = reader["tipo"].ToString();

                        }
                    }
                }
            }


            return dcto;

        }

       

        public Documentos DocumentByName(FiltroDocumento filtro)
        {

            Documentos documentos = new Documentos(); ;
            int cuenta = 0;

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("sp_select_obtieneListaDocumentosPorNombre", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                {
                    command.Parameters.AddWithValue("@nombreDocumento", filtro.NombreDocumento);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Documento dcto = new Documento();

                            dcto.IdDocumento = Int32.Parse(reader["IdDocumento"].ToString());
                            dcto.NombreDocumento = reader["nombreDocumento"].ToString();
                            dcto.NombreAutor = reader["nombreAutor"].ToString();
                            dcto.Ruta = reader["ruta"].ToString();
                            dcto.FechaCreacion = reader["fechaPublicacion"].ToString();
                            dcto.Resumen = reader["resumen"].ToString();
                            dcto.Tipo = reader["tipo"].ToString();

                            if (dcto.IdDocumento != 0)
                            {
                                cuenta++;
                                documentos.ListaDocumentos.Add(dcto);
                            }

                            dcto = null;

                        }
                    }
                }

                if (cuenta != 0)
                {
                    documentos.CuentaDocumentos = cuenta;
                }

            }

            return documentos;


        }

        public Documentos ListaDocumentos()
        {
            
            Documentos documentos = new Documentos();;
            int cuenta = 0;

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("sp_select_obtieneListaDocumentos", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Documento dcto = new Documento();
            
                            dcto.IdDocumento = Int32.Parse(reader["IdDocumento"].ToString());
                            dcto.NombreDocumento = reader["nombreDocumento"].ToString();
                            dcto.NombreAutor = reader["nombreAutor"].ToString();
                            dcto.Ruta = reader["ruta"].ToString();
                            dcto.FechaCreacion = reader["fechaPublicacion"].ToString();
                            dcto.Resumen = reader["resumen"].ToString();
                            dcto.Tipo = reader["tipo"].ToString();

                            if (dcto.IdDocumento != 0)
                            {
                                cuenta++;
                                documentos.ListaDocumentos.Add(dcto);
                            }

                            dcto = null;

                        }
                    }
                }

                if (cuenta != 0)
                {
                    documentos.CuentaDocumentos = cuenta;
                }

            }

            return documentos;


        }


        public Documentos DocumentByDate(FiltroDocumento filtro)
        {

            Documentos documentos = new Documentos(); ;
            int cuenta = 0;

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("sp_select_obtieneListaDocumentosPorFecha", conn) { CommandType = System.Data.CommandType.StoredProcedure })
                {
                    command.Parameters.AddWithValue("@fechaInicial", filtro.fechaInicial);
                    command.Parameters.AddWithValue("@fechaFinal", filtro.fechaFinal);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Documento dcto = new Documento();

                            dcto.IdDocumento = Int32.Parse(reader["IdDocumento"].ToString());
                            dcto.NombreDocumento = reader["nombreDocumento"].ToString();
                            dcto.NombreAutor = reader["nombreAutor"].ToString();
                            dcto.Ruta = reader["ruta"].ToString();
                            dcto.FechaCreacion = reader["fechaPublicacion"].ToString();
                            dcto.Resumen = reader["resumen"].ToString();
                            dcto.Tipo = reader["tipo"].ToString();

                            if (dcto.IdDocumento != 0)
                            {
                                cuenta++;
                                documentos.ListaDocumentos.Add(dcto);
                            }

                            dcto = null;

                        }
                    }
                }

                if (cuenta != 0)
                {
                    documentos.CuentaDocumentos = cuenta;
                }

            }

            return documentos;


        }


    }
}
