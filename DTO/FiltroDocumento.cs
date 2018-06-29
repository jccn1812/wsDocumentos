using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class FiltroDocumento
    {

        private int _IdDocumento;

        public int IdDocumento
        {
            get { return _IdDocumento; }
            set { _IdDocumento = value; }
        }

        public string NombreDocumento { get; set; }

        public string fechaInicial { get; set; }

        public string fechaFinal { get; set; }


    }
}
