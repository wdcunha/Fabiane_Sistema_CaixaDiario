using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabiane_Sistema_CaixaDiario
{
    public partial class Form1 : Form
    {
        CDFEntities db;
        char tipo;
        DateTime timeNow = DateTime.Now;
        Competencia comp;
        TipoParteEnvolvida tPEnv;

        public Form1()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelEmpresa.Enabled = false;
            panelComp.Enabled = false;
            panelPEnv.Enabled = false;

            btnSalvarEmpresa.Enabled = false;

            dateTimePickerComp.Format = DateTimePickerFormat.Custom;
            dateTimePickerComp.CustomFormat = "MMMM/yyyy";
            dateTimePickerComp.ShowUpDown = true; // to prevent the calendar from being displayed


            db = new CDFEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.Configuration.LazyLoadingEnabled = false;

            competenciaBindingSource.DataSource = db.Competencias.Include("MovimentacaosComp").ToList();

            empresaBindingSource.DataSource = db.Empresas.Include("MovimentacaosEmp").ToList();

            parteEnvolvidaBindingSource.DataSource = db.ParteEnvolvidas.Include("MovimentacaosPEnv").ToList();

            tipoParteEnvolvidaBindingSource.DataSource = db.TipoParteEnvolvidas.Include("TPEnv").ToList();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeNow = DateTime.Now;
            lblTime.Text = timeNow.ToString("F");
        }

        private void btnIncluirComp_Click(object sender, EventArgs e)
        {
            panelComp.Enabled = true;
            btnEditarEmpresa.Enabled = false;
            btnIncluirComp.Enabled = false;

            dateTimePickerComp.Focus();

            comp = new Competencia();
            db.Competencias.Add(comp);
            comp.DataRegistro = timeNow;
            
            //Convert.ToDateTime(this.competenciaTextBox.Text).ToShortDateString().ToString().Substring(3);

            //competenciaTextBox.Text = Convert.ToDateTime(comp.CompNome).ToShortDateString().ToString().Substring(3);

            competenciaBindingSource.Add(comp);
            competenciaBindingSource.MoveLast();

            tipo = 'i';
        }

        private async void btnSalvarComp_Click(object sender, EventArgs e)
        {
            try
            {
                comp.CompNome = Convert.ToDateTime(this.dateTimePickerComp.Value);

                await db.SaveChangesAsync();
                panelComp.Enabled = false;
                btnIncluirComp.Enabled = true;
                btnEditComp.Enabled = true;

                DataGridViewCompetencia.Refresh();

                switch ( tipo )
                {
                    case 'i':
                        MessageBox.Show("Competência cadastrada com sucesso!", "Concluído!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                    case 'e':
                        MessageBox.Show("Competência alterada com sucesso!", "Concluído!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                }

            }
            catch ( Exception ex )
            {

                MessageBox.Show(ex.Message, "Erro ao Salvar Competência!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditComp_Click(object sender, EventArgs e)
        {
            panelComp.Enabled = true;
            btnEditComp.Enabled = false;
            dateTimePickerComp.Focus();

            tipo = 'e';
        }

        private void btnCancelComp_Click(object sender, EventArgs e)
        {
            panelComp.Enabled = false;
            btnEditComp.Enabled = true;
            btnIncluirComp.Enabled = true;
            competenciaBindingSource.ResetBindings(false);

            foreach ( DbEntityEntry entry in db.ChangeTracker.Entries() )
            {
                switch ( entry.State )
                {
                    case System.Data.Entity.EntityState.Added:
                        entry.State = System.Data.Entity.EntityState.Detached;
                        break;
                    case System.Data.Entity.EntityState.Modified:
                        entry.State = System.Data.Entity.EntityState.Unchanged;
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }

            DataGridViewCompetencia.Refresh();
            //competenciaBindingSource.ResetItem();

        }

        private void DataGridViewCompetencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( DataGridViewCompetencia.Columns[e.ColumnIndex].Name == "Delete" )
            {
                if ( MessageBox.Show("Tem certeza de que deseja apagar o registro selecionado?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
                {
                    //db.Competencias.Remove(competenciaBindingSource.Current as Competencia);
                    competenciaBindingSource.RemoveCurrent();
                }
            }
        }

        private void textBoxPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( string.IsNullOrEmpty(textBoxPesquisa.Text) )
            {
                competenciaBindingSource.DataSource = db.Competencias.Include("MovimentacaosComp").ToList();
            }
            else
            {
                var query = from pesq in db.Competencias.Include("MovimentacaosComp")
                            where pesq.CompNome == Convert.ToDateTime(textBoxPesquisa.Text) //.Contains(textBoxPesquisa.Text)
                            select pesq;
                //        competenciaBindingSource.DataSource = query.ToList();
            }

        }

        private void btnIncluirEmpresa_Click(object sender, EventArgs e)
        {
            btnIncluirEmpresa.Enabled = false;
            panelEmpresa.Enabled = true;
            nomeFantasiaTextBox.Focus();

            Empresa emp = new Empresa();
            db.Empresas.Add(emp);
            empresaBindingSource.Add(emp);
            empresaBindingSource.MoveLast();

            tipo = 'i';

        }

        private async void btnSalvarEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                await db.SaveChangesAsync();
                panelEmpresa.Enabled = false;
                btnIncluirEmpresa.Enabled = true;
                btnEditarEmpresa.Enabled = true;

                empresaDataGridView.Refresh();

                switch ( tipo )
                {
                    case 'i':
                        MessageBox.Show("Empresa cadastrada com sucesso!", "Concluído!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                    case 'e':
                        MessageBox.Show("Empresa alterada com sucesso!", "Concluído!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                }

            }
            catch ( Exception ex )
            {

                MessageBox.Show(ex.Message, "Erro ao Salvar Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarEmpresa_Click(object sender, EventArgs e)
        {
            panelEmpresa.Enabled = true;
            btnEditarEmpresa.Enabled = false;
            nomeFantasiaTextBox.Focus();

            tipo = 'e';

        }

        private void btnCancelarEmpresa_Click(object sender, EventArgs e)
        {
            panelEmpresa.Enabled = false;
            btnEditarEmpresa.Enabled = true;
            btnIncluirEmpresa.Enabled = true;
            empresaBindingSource.ResetBindings(false);

            foreach ( DbEntityEntry entry in db.ChangeTracker.Entries() )
            {
                switch ( entry.State )
                {
                    case System.Data.Entity.EntityState.Added:
                        entry.State = System.Data.Entity.EntityState.Detached;
                        break;
                    case System.Data.Entity.EntityState.Modified:
                        entry.State = System.Data.Entity.EntityState.Unchanged;
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }

            empresaDataGridView.Refresh();
        }

        /////Defines shorcuts for this application
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch ( keyData )
            {
                case Keys.F2:
                    btnIncluirComp_Click(null, null);
                    return true;
            }
            KeyEventArgs e = new KeyEventArgs(keyData);
            if ( e.Control && e.KeyCode == Keys.I )
            {
                btnSalvarComp_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);

            //http://stackoverflow.com/questions/2474397/hotkey-to-button-in-c-sharp-windows-application
            //
        }

        private async void btnSalvarPEnv_Click(object sender, EventArgs e)
        {
            try
            {
                await db.SaveChangesAsync();
                panelPEnv.Enabled = false;
                btnIncluirPEnv.Enabled = true;
                btnEditarPEnv.Enabled = true;

                tipoParteEnvolvidaDataGridView.Refresh();

                switch ( tipo )
                {
                    case 'i':
                        MessageBox.Show("Tipo da Parte Envolvida cadastrada com sucesso!", "Trabalho Concluído!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                    case 'e':
                        MessageBox.Show("Tipo da Parte Envolvida alterada com sucesso!", "Trabalho Concluído!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                }

            }
            catch ( Exception ex )
            {

                MessageBox.Show(ex.Message, "Erro ao salvar Tipo da Parte Envolvida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIncluirPEnv_Click(object sender, EventArgs e)
        {
            panelPEnv.Enabled = true;
            btnEditarPEnv.Enabled = false;
            btnIncluirPEnv.Enabled = false;

            descricaoPEnv.Focus();

            ////// *** begin adding process in DB
            tPEnv = new TipoParteEnvolvida();
            db.TipoParteEnvolvidas.Add(tPEnv);
            tPEnv.DataRegistro = timeNow;

            ////// *** begin adding process in binding source
            tipoParteEnvolvidaBindingSource.Add(tPEnv);
            tipoParteEnvolvidaBindingSource.MoveLast();

            tipo = 'i';

        }

        private void btnCancPEnv_Click(object sender, EventArgs e)
        {
            panelPEnv.Enabled = false;
            btnEditarPEnv.Enabled = true;
            btnIncluirPEnv.Enabled = true;
            tipoParteEnvolvidaBindingSource.ResetBindings(false);

            foreach ( DbEntityEntry entry in db.ChangeTracker.Entries() )
            {
                switch ( entry.State )
                {
                    case System.Data.Entity.EntityState.Added:
                        entry.State = System.Data.Entity.EntityState.Detached;
                        break;
                    case System.Data.Entity.EntityState.Modified:
                        entry.State = System.Data.Entity.EntityState.Unchanged;
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }

            tipoParteEnvolvidaDataGridView.Refresh();
        }
        
        private void btnEditarPEnv_Click(object sender, EventArgs e)
        {
            panelPEnv.Enabled = true;
            btnEditarPEnv.Enabled = false;
            descricaoPEnv.Focus();

            tipo = 'e';
        }

        private void ShowCompetencia()
        {
            Competencia objComp = competenciaBindingSource.Current as Competencia;

            if ( objComp != null )
            {
                competenciaBindingSource.DataSource = objComp.MovimentacaosComp.ToList();
            }
        }
    }
}
