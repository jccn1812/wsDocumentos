namespace DTO
{
    public class Documento
    {
        private int _IdDocumento;
        private string _nombreDocumento;
        private string _nombreAutor;
        private string _ruta;
        private string _fechaCreacion;

        public int IdDocumento
        {
            get { return _IdDocumento; }
            set { _IdDocumento = value; }
        }
        
        public string NombreDocumento
        {
            get { return _nombreDocumento; }
            set { _nombreDocumento = value; }
        }
        
        
        public string NombreAutor
        {
            get { return _nombreAutor; }
            set { _nombreAutor = value; }
        }

        public string Ruta
        {
            get { return _ruta; }
            set { _ruta = value; }
        }

        public string FechaCreacion
        {
            get { return _fechaCreacion; }
            set { _fechaCreacion = value; }
        }


        public string Resumen { get; set; }

        public string Tipo { get; set; }
    }
}
