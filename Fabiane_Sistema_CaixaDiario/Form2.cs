using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabiane_Sistema_CaixaDiario
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void competenciaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.competenciaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.caixaDiariaFabianeDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'caixaDiariaFabianeDataSet.Competencia' table. You can move, or remove it, as needed.
            this.competenciaTableAdapter.Fill(this.caixaDiariaFabianeDataSet.Competencia);

        }
    }
}
