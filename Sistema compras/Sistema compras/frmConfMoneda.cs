using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_compras
{
    public partial class frmConfMoneda : Form
    {
        public frmConfMoneda()
        {
            InitializeComponent();
        }

        private void frmConfMoneda_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(new ComboItem("Quetzal", 0));
            comboBox1.Items.Add(new ComboItem("Dolar", 1));
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboItem item = comboBox1.Items[e.Index] as ComboItem;
           e.DrawBackground();
           if (item.ImageIndex >= 0 && item.ImageIndex < imageList1.Images.Count)
               e.Graphics.DrawImage(imageList1.Images[item.ImageIndex], new PointF(e.Bounds.Left, e.Bounds.Top));
           e.Graphics.DrawString(item.Etiqueta, e.Font, new SolidBrush(e.ForeColor), new PointF(e.Bounds.Left + imageList1.ImageSize.Width + 1, e.Bounds.Top));

        
        }
    }
}
