using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_compras
{
    class ComboItem
    {
        /* http://jmarcost.blogspot.com/2007/03/un-combobox-con-imgenes.html */

        private int _imageIndex;
        private string _etiqueta;

        public string Etiqueta
        {
            get { return _etiqueta; }
            set { _etiqueta = value; }
        }

        public int ImageIndex
        {
            get { return _imageIndex; }
            set { _imageIndex = value; }
        }

        public ComboItem(string etiqueta, int imageIndex)
        {
            this.Etiqueta = etiqueta;
            this.ImageIndex = imageIndex;
        }

        
        public override string ToString()
        {
            return Etiqueta;
        }

    }
}
