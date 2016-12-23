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
        Movimentacao mov;
        private ParteEnvolvida PEnv;
        private TipoParteEnvolvida tPEnv;
        private TipoMovimentacao tMov;


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
            panelTPEnv.Enabled = false;
            panelTMov.Enabled = false;
            panelMov.Enabled = false;

            btnSalvarEmpresa.Enabled = false;
            btnCancelarEmpresa.Enabled = false;

            dateTimePickerComp.Format = DateTimePickerFormat.Custom;
            dateTimePickerComp.CustomFormat = "MMMM/yyyy";
            dateTimePickerComp.ShowUpDown = true; // to prevent the calendar from being displayed

            //dataDateTimePickerDataMov.ShowUpDown = true;



            /*set DateTimePicker in datagridview from competencia
            dtpComp = new DateTimePicker();
            dtpComp.Format = DateTimePickerFormat.Custom;
            dtpComp.CustomFormat = "MMMM/yyyy";
            dtpComp.Visible = true;
            dtpComp.Width = 250;
            dtpComp.ShowUpDown = true; // to prevent the calendar from being displayed
            DataGridViewCompetencia.Controls.Add(dtpComp);
            //till here *******************************************************************

            //here calls methods for the code that allow to get date from the datetimepicker
            /*dtpComp.ValueChanged += this.dtpComp_ValueChanged;
            DataGridViewCompetencia.CellBeginEdit += this.DataGridViewCompetencia_CellBeginEdit;
            DataGridViewCompetencia.CellEndEdit += this.DataGridViewCompetencia_CellEndEdit;*/

            DataGridViewCompetencia.Columns[1].DefaultCellStyle.Format = "MMMM/yyyy"; //format date in datagrid for competência
            dataGridViewMov.Columns[6].DefaultCellStyle.Format = "MMMM/yyyy"; 
            dataGridViewMov.Columns[3].DefaultCellStyle.Format = "C";

            //mskbxValorMov.Mask = "$ 999,999.00";
            //mskbxValorMov.TextAlign = "right";
            //txtIdMov.Text = String.Format("C");

            //cmbEmpMov.ValueMember = "0";
            //cmbCompMov

            db = new CDFEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.Configuration.LazyLoadingEnabled = false;

            competenciaBindingSource.DataSource = db.Competencias.Include("MovimentacaosComp").ToList();

            empresaBindingSource.DataSource = db.Empresas.Include("MovimentacaosEmp").ToList();

            parteEnvolvidaBindingSource.DataSource = db.ParteEnvolvidas.Include("TipoParteEnvolvidas").ToList();

            tipoParteEnvolvidaBindingSource.DataSource = db.TipoParteEnvolvidas.Include("TPEnv").ToList();

            tipoMovimentacaoBindingSource.DataSource = db.TipoMovimentacaos.Include("MovimentacaosTpMov").ToList();

            movimentacaoBindingSource.DataSource = db.Movimentacaos.Include("Competencias").ToList();
            movimentacaoBindingSource.DataSource = db.Movimentacaos.Include("Empresas").ToList();
            movimentacaoBindingSource.DataSource = db.Movimentacaos.Include("ParteEnvolvidas").ToList();
            movimentacaoBindingSource.DataSource = db.Movimentacaos.Include("TipoMovimentacaos").ToList();
      }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeNow = DateTime.Now;
            lblTime.Text = timeNow.ToString("F");
        }


        ///
        /// <summary> ***********************************************************************************
        ///
        ///     C O M P E T Ê N C I A
        ///     
        /// </summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////
        ///

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
            if ( DataGridViewCompetencia.Columns[e.ColumnIndex].Name == "DeleteColumn")
            {
                if ( MessageBox.Show("Tem certeza de que deseja apagar o registro selecionado?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
                {
                    db.Competencias.Remove(competenciaBindingSource.Current as Competencia);
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

        /// <summary> ***********************************************************************************
        ///  E M P R E S A
        /// </summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////
                    
        private void btnIncluirEmpresa_Click(object sender, EventArgs e)
        {
            btnIncluirEmpresa.Enabled = false;
            btnEditarEmpresa.Enabled = false;
            panelEmpresa.Enabled = true;
            btnSalvarEmpresa.Enabled = true;
            btnCancelarEmpresa.Enabled = true;
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
                btnSalvarEmpresa.Enabled = false;
                btnCancelarEmpresa.Enabled = false;
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
            btnCancelarEmpresa.Enabled = false;
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

            // http://stackoverflow.com/questions/2474397/hotkey-to-button-in-c-sharp-windows-application
            //
        }

        ///
        /// <summary> ***********************************************************************************
        ///  PARTE ENVOLVIDA
        /// </summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////
        ///

        private async void btnSalvarPEnv_Click(object sender, EventArgs e)
        {
            try
            {
                await db.SaveChangesAsync();
                panelPEnv.Enabled = false;
                btnSalvarPEnv.Enabled = false;
                btnCancelPEnv.Enabled = false;
                btnIncluirPEnv.Enabled = true;
                btnEditPEnv.Enabled = true;

                parteEnvolvidaDataGridView.Refresh();

                switch ( tipo )
                {
                    case 'i':
                        MessageBox.Show("Parte Envolvida cadastrada com sucesso!", "Trabalho Concluído!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                    case 'e':
                        MessageBox.Show("Parte Envolvida alterada com sucesso!", "Trabalho Concluído!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                }

            }
            catch ( Exception ex )
            {

                MessageBox.Show(ex.Message, "Erro ao salvar Parte Envolvida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIncluirPEnv_Click(object sender, EventArgs e)
        {
            panelPEnv.Enabled = true;
            btnEditPEnv.Enabled = false;
            btnIncluirPEnv.Enabled = false;

            txtNomePEnv.Focus();

            ////// *** begin adding process in DB
            PEnv = new ParteEnvolvida();
            db.ParteEnvolvidas.Add(PEnv);
            PEnv.DataRegistro = timeNow;

            ////// *** begin adding process in binding source
            parteEnvolvidaBindingSource.Add(PEnv);
            parteEnvolvidaBindingSource.MoveLast();

            tipo = 'i';

        }

        private void btnCancPEnv_Click(object sender, EventArgs e)
        {
            panelPEnv.Enabled = false;
            btnEditPEnv.Enabled = true;
            btnIncluirPEnv.Enabled = true;
            parteEnvolvidaBindingSource.ResetBindings(false);

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

            parteEnvolvidaDataGridView.Refresh();
        }
        
        private void btnEditarPEnv_Click(object sender, EventArgs e)
        {
            panelPEnv.Enabled = true;
            btnEditPEnv.Enabled = false;
            txtNomePEnv.Focus();

            tipo = 'e';
        }
        
        
        ///
        /// <summary> ***********************************************************************************
        /// Tipo Parte Envolvida
        /// </summary>
        /// 


        private async void btnSalvarTPEnv_Click(object sender, EventArgs e)
        {
            try
            {
                await db.SaveChangesAsync();
                panelTPEnv.Enabled = false;
                btnIncluirTPEnv.Enabled = true;
                btnEditTPEnv.Enabled = true;

                tipoParteEnvolvidaDataGridView.Refresh();

                switch (tipo)
                {
                    case 'i':
                        MessageBox.Show("Tipo Parte Envolvida cadastrada com sucesso!", "Trabalho Concluído!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                    case 'e':
                        MessageBox.Show("Tipo da Parte Envolvida alterada com sucesso!", "Trabalho Concluído!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro ao salvar Tipo da Parte Envolvida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIncluirTPEnv_Click(object sender, EventArgs e)
        {
            panelTPEnv.Enabled = true;
            btnEditTPEnv.Enabled = false;
            btnIncluirTPEnv.Enabled = false;

            descricaoTPEnv.Focus();

            ////// *** begin adding process in DB
            tPEnv = new TipoParteEnvolvida();
            db.TipoParteEnvolvidas.Add(tPEnv);
            tPEnv.DataRegistro = timeNow;

            ////// *** begin adding process in binding source
            tipoParteEnvolvidaBindingSource.Add(tPEnv);
            tipoParteEnvolvidaBindingSource.MoveLast();

            tipo = 'i';

        }

        private void btnCancTPEnv_Click(object sender, EventArgs e)
        {
            panelTPEnv.Enabled = false;
            btnEditTPEnv.Enabled = true;
            btnIncluirTPEnv.Enabled = true;
            tipoParteEnvolvidaBindingSource.ResetBindings(false);

            foreach (DbEntityEntry entry in db.ChangeTracker.Entries())
            {
                switch (entry.State)
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

        private void btnEditarTPEnv_Click(object sender, EventArgs e)
        {
            panelTPEnv.Enabled = true;
            btnEditTPEnv.Enabled = false;
            descricaoTPEnv.Focus();

            tipo = 'e';
        }

        ///
        /// <summary> ***********************************************************************************
        /// Tipo Movimentação
        /// </summary>
        /// *********************************************************************************************


        private async void btnSalvarTMov_Click(object sender, EventArgs e)
        {
            try
            {
                await db.SaveChangesAsync();
                panelTMov.Enabled = false;
                btnIncluirTMov.Enabled = true;
                btnEditTMov.Enabled = true;

                tipoMovimentacaoDataGridView.Refresh();

                switch (tipo)
                {
                    case 'i':
                        MessageBox.Show("Tipo de Movimentação cadastrada com sucesso!", "Trabalho Concluído!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                    case 'e':
                        MessageBox.Show("Tipo de Movimentação alterada com sucesso!", "Trabalho Concluído!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro ao salvar Tipo de Movimentação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIncluirTMov_Click(object sender, EventArgs e)
        {
            panelTMov.Enabled = true;
            btnEditTMov.Enabled = false;
            btnIncluirTMov.Enabled = false;



            descricaoTMov.Focus();

            ////// *** begin adding process in DB
            tMov = new TipoMovimentacao();
            db.TipoMovimentacaos.Add(tMov);
            //tPEnv.DataRegistro = timeNow; tem que criar campos na tabela para registro de data e usuário

            ////// *** begin adding process in binding source
            tipoMovimentacaoBindingSource.Add(tMov);
            tipoMovimentacaoBindingSource.MoveLast();

            tipo = 'i';

        }

        private void btnCancTMov_Click(object sender, EventArgs e)
        {
            panelTMov.Enabled = false;
            btnEditTMov.Enabled = true;
            btnIncluirTMov.Enabled = true;
            tipoMovimentacaoBindingSource.ResetBindings(false);

            foreach (DbEntityEntry entry in db.ChangeTracker.Entries())
            {
                switch (entry.State)
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

            tipoMovimentacaoDataGridView.Refresh();
        }

        private void btnEditarTMov_Click(object sender, EventArgs e)
        {
            panelTMov.Enabled = true;
            btnEditTMov.Enabled = false;
            descricaoTMov.Focus();

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

        /// <summary> ***********************************************************************************
        ///  M O V I M E N T A Ç Ã O
        /// </summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////

        private void btnIncluirMov_Click(object sender, EventArgs e)
        {
            btnIncluirMov.Enabled = false;
            btnEditMov.Enabled = false;
            panelMov.Enabled = true;

            numericBox1.Text = null;
            txtDescricaoMov.Clear();

            numericBox1.Focus();

            Movimentacao mov = new Movimentacao();
            db.Movimentacaos.Add(mov);
            mov.DataRegistro= timeNow;
                       
            movimentacaoBindingSource.Add(mov);
            movimentacaoBindingSource.MoveLast();

            tipo = 'i';

        }

        private async void btnSalvarMov_Click(object sender, EventArgs e)
        {
            try
            {
                //mov.Competencia_fk = cmbCompMov.SelectedIndex;
                //mov.Empresa_fk = cmbEmpMov.SelectedIndex;

                await db.SaveChangesAsync();

                switch (tipo)
                {
                    case 'i':
                        MessageBox.Show("Movimentação cadastrada com sucesso!", "Concluído!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                    case 'e':
                        MessageBox.Show("Movimentação alterada com sucesso!", "Concluído!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro ao Salvar Movimentação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            panelMov.Enabled = false;
            btnIncluirMov.Enabled = true;
            btnEditMov.Enabled = true;

            dataGridViewMov.Refresh();


        }

        private void btnEditMov_Click(object sender, EventArgs e)
        {
            panelMov.Enabled = true;
            btnEditMov.Enabled = false;
            numericBox1.Focus();

            tipo = 'e';

        }

        private void btnCancelMov_Click(object sender, EventArgs e)
        {
            panelMov.Enabled = false;
            btnEditMov.Enabled = true;
            btnIncluirMov.Enabled = true;

            movimentacaoBindingSource.ResetBindings(false);

            foreach (DbEntityEntry entry in db.ChangeTracker.Entries())
            {
                switch (entry.State)
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
            MessageBox.Show("Movimentação cancelada como selecionado!", "Cancelado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            numericBox1.Text = null;
            txtDescricaoMov.Text = null;
            dataGridViewMov.Refresh();
        }

        private void dataGridViewMov_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMov.Columns[e.ColumnIndex].Name == "dgvExcluirMov")
            {
                if (MessageBox.Show("Tem certeza de que deseja apagar o registro selecionado?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //db.Competencias.Remove(competenciaBindingSource.Current as Competencia);
                    movimentacaoBindingSource.RemoveCurrent();
                }
            }

        }

        /// <summary>
        /// SHOW DATATIMEPICKER in datagridviewcompetencia to present the format MMMM/yyyy
        /// https://www.youtube.com/watch?v=r7Ff1Jn3OO4
        /// </summary>
        /// 
        /*
        private void DataGridViewCompetencia_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if((DataGridViewCompetencia.Focused) && DataGridViewCompetencia.CurrentCell.ColumnIndex == 1)
                {
                    dtpComp.Location = DataGridViewCompetencia.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                    dtpComp.Visible = true;
                    if(DataGridViewCompetencia.CurrentCell.Value != DBNull.Value)
                    {
                        dtpComp.Value = (DateTime)DataGridViewCompetencia.CurrentCell.Value;
                    }
                 
                else{
                        dtpComp.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }*/


        /*
         private void DataGridViewCompetencia_CellEndEdit(object sender, DataGridViewCellEventArgs e)
         {
             try
             {
                 if ((DataGridViewCompetencia.Focused) && DataGridViewCompetencia.CurrentCell.ColumnIndex == 1)
                 {
                     DataGridViewCompetencia.CurrentCell.Value = dtpComp.Value.Date;
                 }
             }
             catch (Exception ex)
             {

                 MessageBox.Show(ex.Message);
             }
         }

         private void dtpComp_ValueChanged(object sender, EventArgs e)
         {
             DataGridViewCompetencia.CurrentCell.Value = dtpComp.Text;
         }*/
    }
}
