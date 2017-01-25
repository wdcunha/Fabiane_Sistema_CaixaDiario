namespace Fabiane_Sistema_CaixaDiario
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblCompTitle;
            System.Windows.Forms.Label lblEmpTitle;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label competenciaLabel;
            System.Windows.Forms.Label lblPesquisa;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label foneLabel;
            System.Windows.Forms.Label nomeFantasiaLabel;
            System.Windows.Forms.Label razaoSocialLabel;
            System.Windows.Forms.Label dataRegistroLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label idLabel4;
            System.Windows.Forms.Label tipoMovimentacao1Label;
            System.Windows.Forms.Label lblPEnvTitle;
            System.Windows.Forms.Label lblTPEnvTitle;
            System.Windows.Forms.Label lblTMovTitle;
            System.Windows.Forms.Label lblMovTitle;
            System.Windows.Forms.Label lblidTPEnv;
            System.Windows.Forms.Label lblDescricaoTPEnv;
            System.Windows.Forms.Label cEPLabel1;
            System.Windows.Forms.Label emailLabel1;
            System.Windows.Forms.Label enderecoLabel1;
            System.Windows.Forms.Label foneLabel1;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label tipoParteEnvolvida_fkLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label tipoMovimentacao_fkLabel;
            System.Windows.Forms.Label idLabel2;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label parteEnvolvida_fkLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelComp = new System.Windows.Forms.Panel();
            this.dateTimePickerComp = new System.Windows.Forms.DateTimePicker();
            this.competenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSalvarComp = new System.Windows.Forms.Button();
            this.btnCancelComp = new System.Windows.Forms.Button();
            this.txtIdComp = new System.Windows.Forms.TextBox();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.btnEditComp = new System.Windows.Forms.Button();
            this.btnIncluirComp = new System.Windows.Forms.Button();
            this.DataGridViewCompetencia = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPageCxDiario = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditMov = new System.Windows.Forms.Button();
            this.btnIncluirMov = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelMov = new System.Windows.Forms.Panel();
            this.numericBox1 = new NumericBox.NumericBox();
            this.movimentacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSalvarMov = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.parteEnvolvidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTMov = new System.Windows.Forms.ComboBox();
            this.tipoMovimentacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelMov = new System.Windows.Forms.Button();
            this.txtIdMov = new System.Windows.Forms.TextBox();
            this.txtDescricaoMov = new System.Windows.Forms.TextBox();
            this.dataDateTimePickerDataMov = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbCompMov = new System.Windows.Forms.ComboBox();
            this.lblCompTelaMov = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmpTelaMov = new System.Windows.Forms.Label();
            this.cmbEmpMov = new System.Windows.Forms.ComboBox();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewMov = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn67 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn68 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn69 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn71 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvExcluirMov = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSalvarEmpresa = new System.Windows.Forms.Button();
            this.empresaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteEmpColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancelarEmpresa = new System.Windows.Forms.Button();
            this.btnEditarEmpresa = new System.Windows.Forms.Button();
            this.btnIncluirEmpresa = new System.Windows.Forms.Button();
            this.panelEmpresa = new System.Windows.Forms.Panel();
            this.mskbxCEPEmp = new System.Windows.Forms.MaskedTextBox();
            this.mskbxFoneEmp = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nomeFantasiaTextBox = new System.Windows.Forms.TextBox();
            this.razaoSocialTextBox = new System.Windows.Forms.TextBox();
            this.TabParteEnvolvida = new System.Windows.Forms.TabPage();
            this.panelPEnv = new System.Windows.Forms.Panel();
            this.msktxtFone = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvarPEnv = new System.Windows.Forms.Button();
            this.btnCancelPEnv = new System.Windows.Forms.Button();
            this.msktxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.cboTPEnvolvida = new System.Windows.Forms.ComboBox();
            this.tipoParteEnvolvidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEmailPEnv = new System.Windows.Forms.TextBox();
            this.txtEnderecoPEnv = new System.Windows.Forms.TextBox();
            this.txtIdPEnv = new System.Windows.Forms.TextBox();
            this.txtNomePEnv = new System.Windows.Forms.TextBox();
            this.btnEditPEnv = new System.Windows.Forms.Button();
            this.btnIncluirPEnv = new System.Windows.Forms.Button();
            this.dataRegistroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.parteEnvolvidaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoParteEnvolvidafkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnExcluirPEnv = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabTPEnv = new System.Windows.Forms.TabPage();
            this.panelTPEnv = new System.Windows.Forms.Panel();
            this.btnSalvarTPEnv = new System.Windows.Forms.Button();
            this.btnCancTPEnv = new System.Windows.Forms.Button();
            this.descricaoTPEnv = new System.Windows.Forms.TextBox();
            this.txtIdTPEnv = new System.Windows.Forms.TextBox();
            this.btnEditTPEnv = new System.Windows.Forms.Button();
            this.btnIncluirTPEnv = new System.Windows.Forms.Button();
            this.tipoParteEnvolvidaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirTPEnv = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TabTipoMov = new System.Windows.Forms.TabPage();
            this.panelTMov = new System.Windows.Forms.Panel();
            this.btnSalvarTMov = new System.Windows.Forms.Button();
            this.btnCancelTMov = new System.Windows.Forms.Button();
            this.descricaoTMov = new System.Windows.Forms.TextBox();
            this.txtIdTMov = new System.Windows.Forms.TextBox();
            this.btnEditTMov = new System.Windows.Forms.Button();
            this.btnIncluirTMov = new System.Windows.Forms.Button();
            this.tipoMovimentacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMovimentacao1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnExcluirTMov = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            lblCompTitle = new System.Windows.Forms.Label();
            lblEmpTitle = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            competenciaLabel = new System.Windows.Forms.Label();
            lblPesquisa = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            nomeFantasiaLabel = new System.Windows.Forms.Label();
            razaoSocialLabel = new System.Windows.Forms.Label();
            dataRegistroLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            idLabel4 = new System.Windows.Forms.Label();
            tipoMovimentacao1Label = new System.Windows.Forms.Label();
            lblPEnvTitle = new System.Windows.Forms.Label();
            lblTPEnvTitle = new System.Windows.Forms.Label();
            lblTMovTitle = new System.Windows.Forms.Label();
            lblMovTitle = new System.Windows.Forms.Label();
            lblidTPEnv = new System.Windows.Forms.Label();
            lblDescricaoTPEnv = new System.Windows.Forms.Label();
            cEPLabel1 = new System.Windows.Forms.Label();
            emailLabel1 = new System.Windows.Forms.Label();
            enderecoLabel1 = new System.Windows.Forms.Label();
            foneLabel1 = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            tipoParteEnvolvida_fkLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            tipoMovimentacao_fkLabel = new System.Windows.Forms.Label();
            idLabel2 = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            parteEnvolvida_fkLabel = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.panelComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCompetencia)).BeginInit();
            this.tabPageCxDiario.SuspendLayout();
            this.panelMov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parteEnvolvidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMovimentacaoBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMov)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataGridView)).BeginInit();
            this.panelEmpresa.SuspendLayout();
            this.TabParteEnvolvida.SuspendLayout();
            this.panelPEnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoParteEnvolvidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parteEnvolvidaDataGridView)).BeginInit();
            this.tabTPEnv.SuspendLayout();
            this.panelTPEnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoParteEnvolvidaDataGridView)).BeginInit();
            this.TabTipoMov.SuspendLayout();
            this.panelTMov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMovimentacaoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompTitle
            // 
            lblCompTitle.AutoSize = true;
            lblCompTitle.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCompTitle.ForeColor = System.Drawing.Color.Navy;
            lblCompTitle.Location = new System.Drawing.Point(33, 24);
            lblCompTitle.Name = "lblCompTitle";
            lblCompTitle.Size = new System.Drawing.Size(394, 27);
            lblCompTitle.TabIndex = 1;
            lblCompTitle.Text = "Manutenção de Competências";
            // 
            // lblEmpTitle
            // 
            lblEmpTitle.AutoSize = true;
            lblEmpTitle.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEmpTitle.ForeColor = System.Drawing.Color.Navy;
            lblEmpTitle.Location = new System.Drawing.Point(33, 24);
            lblEmpTitle.Name = "lblEmpTitle";
            lblEmpTitle.Size = new System.Drawing.Size(468, 27);
            lblEmpTitle.TabIndex = 2;
            lblEmpTitle.Text = "Manutenção dos dados da Empresa";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(3, 10);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(112, 18);
            idLabel.TabIndex = 9;
            idLabel.Text = "Identificação:";
            // 
            // competenciaLabel
            // 
            competenciaLabel.AutoSize = true;
            competenciaLabel.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            competenciaLabel.Location = new System.Drawing.Point(3, 50);
            competenciaLabel.Name = "competenciaLabel";
            competenciaLabel.Size = new System.Drawing.Size(112, 18);
            competenciaLabel.TabIndex = 11;
            competenciaLabel.Text = "Competência:";
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPesquisa.Location = new System.Drawing.Point(41, 341);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new System.Drawing.Size(68, 18);
            lblPesquisa.TabIndex = 11;
            lblPesquisa.Text = "Pesquisa:";
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cEPLabel.Location = new System.Drawing.Point(812, 150);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(46, 19);
            cEPLabel.TabIndex = 16;
            cEPLabel.Text = "CEP:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(13, 101);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(60, 19);
            emailLabel.TabIndex = 18;
            emailLabel.Text = "Email:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoLabel.Location = new System.Drawing.Point(13, 146);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(90, 19);
            enderecoLabel.TabIndex = 20;
            enderecoLabel.Text = "Endereco:";
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            foneLabel.Location = new System.Drawing.Point(783, 97);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(54, 19);
            foneLabel.TabIndex = 8;
            foneLabel.Text = "Fone:";
            // 
            // nomeFantasiaLabel
            // 
            nomeFantasiaLabel.AutoSize = true;
            nomeFantasiaLabel.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeFantasiaLabel.Location = new System.Drawing.Point(13, 11);
            nomeFantasiaLabel.Name = "nomeFantasiaLabel";
            nomeFantasiaLabel.Size = new System.Drawing.Size(136, 19);
            nomeFantasiaLabel.TabIndex = 24;
            nomeFantasiaLabel.Text = "Nome Fantasia:";
            // 
            // razaoSocialLabel
            // 
            razaoSocialLabel.AutoSize = true;
            razaoSocialLabel.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            razaoSocialLabel.Location = new System.Drawing.Point(13, 56);
            razaoSocialLabel.Name = "razaoSocialLabel";
            razaoSocialLabel.Size = new System.Drawing.Size(114, 19);
            razaoSocialLabel.TabIndex = 26;
            razaoSocialLabel.Text = "Razao Social:";
            // 
            // dataRegistroLabel
            // 
            dataRegistroLabel.AutoSize = true;
            dataRegistroLabel.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataRegistroLabel.Location = new System.Drawing.Point(936, 132);
            dataRegistroLabel.Name = "dataRegistroLabel";
            dataRegistroLabel.Size = new System.Drawing.Size(107, 16);
            dataRegistroLabel.TabIndex = 3;
            dataRegistroLabel.Text = "Data Registro:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.Location = new System.Drawing.Point(936, 75);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(155, 16);
            usuarioLabel.TabIndex = 17;
            usuarioLabel.Text = "Usuario cadastrante:";
            // 
            // idLabel4
            // 
            idLabel4.AutoSize = true;
            idLabel4.Location = new System.Drawing.Point(21, 19);
            idLabel4.Name = "idLabel4";
            idLabel4.Size = new System.Drawing.Size(28, 16);
            idLabel4.TabIndex = 1;
            idLabel4.Text = "Id:";
            // 
            // tipoMovimentacao1Label
            // 
            tipoMovimentacao1Label.AutoSize = true;
            tipoMovimentacao1Label.Location = new System.Drawing.Point(21, 49);
            tipoMovimentacao1Label.Name = "tipoMovimentacao1Label";
            tipoMovimentacao1Label.Size = new System.Drawing.Size(145, 16);
            tipoMovimentacao1Label.TabIndex = 3;
            tipoMovimentacao1Label.Text = "Tipo Movimentação:";
            // 
            // lblPEnvTitle
            // 
            lblPEnvTitle.AutoSize = true;
            lblPEnvTitle.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPEnvTitle.ForeColor = System.Drawing.Color.Navy;
            lblPEnvTitle.Location = new System.Drawing.Point(46, 22);
            lblPEnvTitle.Name = "lblPEnvTitle";
            lblPEnvTitle.Size = new System.Drawing.Size(460, 27);
            lblPEnvTitle.TabIndex = 23;
            lblPEnvTitle.Text = "Manutenção das Partes Envolvidas";
            // 
            // lblTPEnvTitle
            // 
            lblTPEnvTitle.AutoSize = true;
            lblTPEnvTitle.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTPEnvTitle.ForeColor = System.Drawing.Color.Navy;
            lblTPEnvTitle.Location = new System.Drawing.Point(284, 35);
            lblTPEnvTitle.Name = "lblTPEnvTitle";
            lblTPEnvTitle.Size = new System.Drawing.Size(533, 27);
            lblTPEnvTitle.TabIndex = 5;
            lblTPEnvTitle.Text = "Manutenção do Tipo da Parte Envolvida";
            // 
            // lblTMovTitle
            // 
            lblTMovTitle.AutoSize = true;
            lblTMovTitle.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTMovTitle.ForeColor = System.Drawing.Color.Navy;
            lblTMovTitle.Location = new System.Drawing.Point(108, 59);
            lblTMovTitle.Name = "lblTMovTitle";
            lblTMovTitle.Size = new System.Drawing.Size(511, 27);
            lblTMovTitle.TabIndex = 6;
            lblTMovTitle.Text = "Manutenção do Tipo de Movimentação";
            // 
            // lblMovTitle
            // 
            lblMovTitle.AutoSize = true;
            lblMovTitle.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMovTitle.ForeColor = System.Drawing.Color.Navy;
            lblMovTitle.Location = new System.Drawing.Point(161, 12);
            lblMovTitle.Name = "lblMovTitle";
            lblMovTitle.Size = new System.Drawing.Size(324, 27);
            lblMovTitle.TabIndex = 12;
            lblMovTitle.Text = "Movimentação de Caixa";
            this.toolTip1.SetToolTip(lblMovTitle, "Lançamento de valores de entrada e saída");
            // 
            // lblidTPEnv
            // 
            lblidTPEnv.AutoSize = true;
            lblidTPEnv.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblidTPEnv.Location = new System.Drawing.Point(3, 10);
            lblidTPEnv.Name = "lblidTPEnv";
            lblidTPEnv.Size = new System.Drawing.Size(112, 18);
            lblidTPEnv.TabIndex = 9;
            lblidTPEnv.Text = "Identificação:";
            // 
            // lblDescricaoTPEnv
            // 
            lblDescricaoTPEnv.AutoSize = true;
            lblDescricaoTPEnv.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDescricaoTPEnv.Location = new System.Drawing.Point(3, 50);
            lblDescricaoTPEnv.Name = "lblDescricaoTPEnv";
            lblDescricaoTPEnv.Size = new System.Drawing.Size(86, 18);
            lblDescricaoTPEnv.TabIndex = 11;
            lblDescricaoTPEnv.Text = "Descrição:";
            // 
            // cEPLabel1
            // 
            cEPLabel1.AutoSize = true;
            cEPLabel1.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cEPLabel1.Location = new System.Drawing.Point(26, 145);
            cEPLabel1.Name = "cEPLabel1";
            cEPLabel1.Size = new System.Drawing.Size(40, 16);
            cEPLabel1.TabIndex = 21;
            cEPLabel1.Text = "CEP:";
            // 
            // emailLabel1
            // 
            emailLabel1.AutoSize = true;
            emailLabel1.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel1.Location = new System.Drawing.Point(309, 146);
            emailLabel1.Name = "emailLabel1";
            emailLabel1.Size = new System.Drawing.Size(58, 16);
            emailLabel1.TabIndex = 0;
            emailLabel1.Text = "Email:";
            // 
            // enderecoLabel1
            // 
            enderecoLabel1.AutoSize = true;
            enderecoLabel1.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoLabel1.Location = new System.Drawing.Point(26, 112);
            enderecoLabel1.Name = "enderecoLabel1";
            enderecoLabel1.Size = new System.Drawing.Size(83, 16);
            enderecoLabel1.TabIndex = 25;
            enderecoLabel1.Text = "Endereco:";
            // 
            // foneLabel1
            // 
            foneLabel1.AutoSize = true;
            foneLabel1.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            foneLabel1.Location = new System.Drawing.Point(26, 179);
            foneLabel1.Name = "foneLabel1";
            foneLabel1.Size = new System.Drawing.Size(49, 16);
            foneLabel1.TabIndex = 27;
            foneLabel1.Text = "Fone:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel1.Location = new System.Drawing.Point(26, 22);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(31, 16);
            idLabel1.TabIndex = 29;
            idLabel1.Text = "Id:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(26, 52);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(55, 16);
            nomeLabel.TabIndex = 31;
            nomeLabel.Text = "Nome:";
            // 
            // tipoParteEnvolvida_fkLabel
            // 
            tipoParteEnvolvida_fkLabel.AutoSize = true;
            tipoParteEnvolvida_fkLabel.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoParteEnvolvida_fkLabel.Location = new System.Drawing.Point(449, 19);
            tipoParteEnvolvida_fkLabel.Name = "tipoParteEnvolvida_fkLabel";
            tipoParteEnvolvida_fkLabel.Size = new System.Drawing.Size(174, 16);
            tipoParteEnvolvida_fkLabel.TabIndex = 33;
            tipoParteEnvolvida_fkLabel.Text = "Tipo Parte Envolvida:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(386, 60);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(58, 19);
            valorLabel.TabIndex = 28;
            valorLabel.Text = "Valor:";
            // 
            // tipoMovimentacao_fkLabel
            // 
            tipoMovimentacao_fkLabel.AutoSize = true;
            tipoMovimentacao_fkLabel.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoMovimentacao_fkLabel.Location = new System.Drawing.Point(652, 70);
            tipoMovimentacao_fkLabel.Name = "tipoMovimentacao_fkLabel";
            tipoMovimentacao_fkLabel.Size = new System.Drawing.Size(173, 19);
            tipoMovimentacao_fkLabel.TabIndex = 27;
            tipoMovimentacao_fkLabel.Text = "Tipo Movimentação:";
            // 
            // idLabel2
            // 
            idLabel2.AutoSize = true;
            idLabel2.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel2.Location = new System.Drawing.Point(65, 12);
            idLabel2.Name = "idLabel2";
            idLabel2.Size = new System.Drawing.Size(30, 19);
            idLabel2.TabIndex = 25;
            idLabel2.Text = "Id:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(9, 102);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(94, 19);
            descricaoLabel.TabIndex = 22;
            descricaoLabel.Text = "Descrição:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataLabel.Location = new System.Drawing.Point(47, 60);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(53, 19);
            dataLabel.TabIndex = 21;
            dataLabel.Text = "Data:";
            // 
            // parteEnvolvida_fkLabel
            // 
            parteEnvolvida_fkLabel.AutoSize = true;
            parteEnvolvida_fkLabel.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            parteEnvolvida_fkLabel.Location = new System.Drawing.Point(652, 128);
            parteEnvolvida_fkLabel.Name = "parteEnvolvida_fkLabel";
            parteEnvolvida_fkLabel.Size = new System.Drawing.Size(142, 19);
            parteEnvolvida_fkLabel.TabIndex = 31;
            parteEnvolvida_fkLabel.Text = "Parte Envolvida:";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(100, 23);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 23);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 23);
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Lavender;
            this.lblTime.Location = new System.Drawing.Point(973, 7);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTime.Size = new System.Drawing.Size(365, 18);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Time now";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Tan;
            this.tabPage2.Controls.Add(this.panelComp);
            this.tabPage2.Controls.Add(this.textBoxPesquisa);
            this.tabPage2.Controls.Add(lblPesquisa);
            this.tabPage2.Controls.Add(this.btnEditComp);
            this.tabPage2.Controls.Add(this.btnIncluirComp);
            this.tabPage2.Controls.Add(this.DataGridViewCompetencia);
            this.tabPage2.Controls.Add(lblCompTitle);
            this.tabPage2.Font = new System.Drawing.Font("Eras Medium ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1357, 702);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Competência";
            // 
            // panelComp
            // 
            this.panelComp.Controls.Add(idLabel);
            this.panelComp.Controls.Add(this.dateTimePickerComp);
            this.panelComp.Controls.Add(this.btnSalvarComp);
            this.panelComp.Controls.Add(this.btnCancelComp);
            this.panelComp.Controls.Add(this.txtIdComp);
            this.panelComp.Controls.Add(competenciaLabel);
            this.panelComp.Location = new System.Drawing.Point(38, 176);
            this.panelComp.Name = "panelComp";
            this.panelComp.Size = new System.Drawing.Size(405, 88);
            this.panelComp.TabIndex = 15;
            // 
            // dateTimePickerComp
            // 
            this.dateTimePickerComp.CustomFormat = "MMMM/yyyy";
            this.dateTimePickerComp.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.competenciaBindingSource, "CompNome", true));
            this.dateTimePickerComp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerComp.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerComp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerComp.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.dateTimePickerComp.Location = new System.Drawing.Point(147, 50);
            this.dateTimePickerComp.Name = "dateTimePickerComp";
            this.dateTimePickerComp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePickerComp.Size = new System.Drawing.Size(137, 25);
            this.dateTimePickerComp.TabIndex = 13;
            // 
            // competenciaBindingSource
            // 
            this.competenciaBindingSource.DataSource = typeof(Fabiane_Sistema_CaixaDiario.Competencia);
            // 
            // btnSalvarComp
            // 
            this.btnSalvarComp.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarComp.Location = new System.Drawing.Point(314, 10);
            this.btnSalvarComp.Name = "btnSalvarComp";
            this.btnSalvarComp.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarComp.TabIndex = 1;
            this.btnSalvarComp.Text = "&Salvar";
            this.btnSalvarComp.UseVisualStyleBackColor = true;
            this.btnSalvarComp.Click += new System.EventHandler(this.btnSalvarComp_Click);
            // 
            // btnCancelComp
            // 
            this.btnCancelComp.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelComp.Location = new System.Drawing.Point(314, 53);
            this.btnCancelComp.Name = "btnCancelComp";
            this.btnCancelComp.Size = new System.Drawing.Size(75, 23);
            this.btnCancelComp.TabIndex = 2;
            this.btnCancelComp.Text = "&Cancelar";
            this.btnCancelComp.UseVisualStyleBackColor = true;
            this.btnCancelComp.Click += new System.EventHandler(this.btnCancelComp_Click);
            // 
            // txtIdComp
            // 
            this.txtIdComp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.competenciaBindingSource, "Id", true));
            this.txtIdComp.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdComp.Location = new System.Drawing.Point(147, 7);
            this.txtIdComp.Name = "txtIdComp";
            this.txtIdComp.ReadOnly = true;
            this.txtIdComp.Size = new System.Drawing.Size(78, 25);
            this.txtIdComp.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtIdComp, "Número de identificação do registro da competência gerado automaticamente");
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisa.Location = new System.Drawing.Point(115, 338);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(313, 25);
            this.textBoxPesquisa.TabIndex = 0;
            this.textBoxPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPesquisa_KeyPress);
            // 
            // btnEditComp
            // 
            this.btnEditComp.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditComp.Location = new System.Drawing.Point(352, 276);
            this.btnEditComp.Name = "btnEditComp";
            this.btnEditComp.Size = new System.Drawing.Size(75, 23);
            this.btnEditComp.TabIndex = 3;
            this.btnEditComp.Text = "&Editar";
            this.btnEditComp.UseVisualStyleBackColor = true;
            this.btnEditComp.Click += new System.EventHandler(this.btnEditComp_Click);
            // 
            // btnIncluirComp
            // 
            this.btnIncluirComp.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirComp.Location = new System.Drawing.Point(247, 276);
            this.btnIncluirComp.Name = "btnIncluirComp";
            this.btnIncluirComp.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirComp.TabIndex = 4;
            this.btnIncluirComp.Text = "I&ncluir";
            this.btnIncluirComp.UseVisualStyleBackColor = true;
            this.btnIncluirComp.Click += new System.EventHandler(this.btnIncluirComp_Click);
            // 
            // DataGridViewCompetencia
            // 
            this.DataGridViewCompetencia.AllowUserToAddRows = false;
            this.DataGridViewCompetencia.AllowUserToDeleteRows = false;
            this.DataGridViewCompetencia.AutoGenerateColumns = false;
            this.DataGridViewCompetencia.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridViewCompetencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCompetencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50,
            this.DeleteColumn});
            this.DataGridViewCompetencia.DataSource = this.competenciaBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Eras Medium ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewCompetencia.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewCompetencia.GridColor = System.Drawing.SystemColors.Highlight;
            this.DataGridViewCompetencia.Location = new System.Drawing.Point(502, 154);
            this.DataGridViewCompetencia.Name = "DataGridViewCompetencia";
            this.DataGridViewCompetencia.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Eras Medium ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCompetencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewCompetencia.RowHeadersVisible = false;
            this.DataGridViewCompetencia.Size = new System.Drawing.Size(473, 256);
            this.DataGridViewCompetencia.TabIndex = 5;
            this.DataGridViewCompetencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCompetencia_CellContentClick);
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn48.HeaderText = "Sequencial";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "CompNome";
            this.dataGridViewTextBoxColumn49.HeaderText = "Competência";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            this.dataGridViewTextBoxColumn49.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn49.Width = 200;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "DataRegistro";
            this.dataGridViewTextBoxColumn50.HeaderText = "Data Registro";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Excluir";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "X";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            this.DeleteColumn.Width = 70;
            // 
            // tabPageCxDiario
            // 
            this.tabPageCxDiario.AutoScroll = true;
            this.tabPageCxDiario.BackColor = System.Drawing.Color.Tan;
            this.tabPageCxDiario.Controls.Add(this.label1);
            this.tabPageCxDiario.Controls.Add(this.btnEditMov);
            this.tabPageCxDiario.Controls.Add(this.btnIncluirMov);
            this.tabPageCxDiario.Controls.Add(this.monthCalendar1);
            this.tabPageCxDiario.Controls.Add(this.panelMov);
            this.tabPageCxDiario.Controls.Add(lblMovTitle);
            this.tabPageCxDiario.Controls.Add(this.tableLayoutPanel2);
            this.tabPageCxDiario.Controls.Add(this.tableLayoutPanel1);
            this.tabPageCxDiario.Controls.Add(this.dataGridViewMov);
            this.tabPageCxDiario.Font = new System.Drawing.Font("Eras Medium ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCxDiario.Location = new System.Drawing.Point(4, 25);
            this.tabPageCxDiario.Name = "tabPageCxDiario";
            this.tabPageCxDiario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCxDiario.Size = new System.Drawing.Size(1357, 702);
            this.tabPageCxDiario.TabIndex = 0;
            this.tabPageCxDiario.Text = "Caixa Diário";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 1F);
            this.label1.Location = new System.Drawing.Point(15, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 3);
            this.label1.TabIndex = 26;
            // 
            // btnEditMov
            // 
            this.btnEditMov.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMov.Location = new System.Drawing.Point(530, 109);
            this.btnEditMov.Name = "btnEditMov";
            this.btnEditMov.Size = new System.Drawing.Size(75, 23);
            this.btnEditMov.TabIndex = 24;
            this.btnEditMov.Text = "&Editar";
            this.btnEditMov.UseVisualStyleBackColor = true;
            this.btnEditMov.Click += new System.EventHandler(this.btnEditMov_Click);
            // 
            // btnIncluirMov
            // 
            this.btnIncluirMov.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirMov.Location = new System.Drawing.Point(425, 109);
            this.btnIncluirMov.Name = "btnIncluirMov";
            this.btnIncluirMov.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirMov.TabIndex = 25;
            this.btnIncluirMov.Text = "I&ncluir";
            this.btnIncluirMov.UseVisualStyleBackColor = true;
            this.btnIncluirMov.Click += new System.EventHandler(this.btnIncluirMov_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(616, 16);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // panelMov
            // 
            this.panelMov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMov.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMov.BackColor = System.Drawing.Color.OldLace;
            this.panelMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMov.Controls.Add(this.numericBox1);
            this.panelMov.Controls.Add(this.btnSalvarMov);
            this.panelMov.Controls.Add(this.comboBox3);
            this.panelMov.Controls.Add(this.cmbTMov);
            this.panelMov.Controls.Add(this.btnCancelMov);
            this.panelMov.Controls.Add(parteEnvolvida_fkLabel);
            this.panelMov.Controls.Add(valorLabel);
            this.panelMov.Controls.Add(tipoMovimentacao_fkLabel);
            this.panelMov.Controls.Add(idLabel2);
            this.panelMov.Controls.Add(this.txtIdMov);
            this.panelMov.Controls.Add(descricaoLabel);
            this.panelMov.Controls.Add(this.txtDescricaoMov);
            this.panelMov.Controls.Add(dataLabel);
            this.panelMov.Controls.Add(this.dataDateTimePickerDataMov);
            this.panelMov.Location = new System.Drawing.Point(11, 153);
            this.panelMov.Name = "panelMov";
            this.panelMov.Size = new System.Drawing.Size(885, 189);
            this.panelMov.TabIndex = 21;
            // 
            // numericBox1
            // 
            this.numericBox1.BackColor = System.Drawing.SystemColors.Window;
            this.numericBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movimentacaoBindingSource, "Valor", true));
            this.numericBox1.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.numericBox1.Location = new System.Drawing.Point(450, 56);
            this.numericBox1.Name = "numericBox1";
            this.numericBox1.NegativeNumberColor = System.Drawing.Color.Red;
            this.numericBox1.Size = new System.Drawing.Size(100, 26);
            this.numericBox1.TabIndex = 33;
            this.numericBox1.Text = "0,00";
            // 
            // movimentacaoBindingSource
            // 
            this.movimentacaoBindingSource.DataSource = typeof(Fabiane_Sistema_CaixaDiario.Movimentacao);
            // 
            // btnSalvarMov
            // 
            this.btnSalvarMov.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarMov.Location = new System.Drawing.Point(413, 8);
            this.btnSalvarMov.Name = "btnSalvarMov";
            this.btnSalvarMov.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarMov.TabIndex = 22;
            this.btnSalvarMov.Text = "&Salvar";
            this.btnSalvarMov.UseVisualStyleBackColor = true;
            this.btnSalvarMov.Click += new System.EventHandler(this.btnSalvarMov_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.movimentacaoBindingSource, "ParteEnvolvida_fk", true));
            this.comboBox3.DataSource = this.parteEnvolvidaBindingSource;
            this.comboBox3.DisplayMember = "Nome";
            this.comboBox3.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(656, 149);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(213, 27);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.ValueMember = "Id";
            // 
            // parteEnvolvidaBindingSource
            // 
            this.parteEnvolvidaBindingSource.DataSource = typeof(Fabiane_Sistema_CaixaDiario.ParteEnvolvida);
            // 
            // cmbTMov
            // 
            this.cmbTMov.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbTMov.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.movimentacaoBindingSource, "TipoMovimentacao_fk", true));
            this.cmbTMov.DataSource = this.tipoMovimentacaoBindingSource;
            this.cmbTMov.DisplayMember = "TipoMovimentacao1";
            this.cmbTMov.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTMov.FormattingEnabled = true;
            this.cmbTMov.Location = new System.Drawing.Point(656, 95);
            this.cmbTMov.Name = "cmbTMov";
            this.cmbTMov.Size = new System.Drawing.Size(213, 27);
            this.cmbTMov.TabIndex = 1;
            this.cmbTMov.ValueMember = "Id";
            // 
            // tipoMovimentacaoBindingSource
            // 
            this.tipoMovimentacaoBindingSource.DataSource = typeof(Fabiane_Sistema_CaixaDiario.TipoMovimentacao);
            // 
            // btnCancelMov
            // 
            this.btnCancelMov.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelMov.Location = new System.Drawing.Point(519, 8);
            this.btnCancelMov.Name = "btnCancelMov";
            this.btnCancelMov.Size = new System.Drawing.Size(75, 23);
            this.btnCancelMov.TabIndex = 23;
            this.btnCancelMov.Text = "&Cancelar";
            this.btnCancelMov.UseVisualStyleBackColor = true;
            this.btnCancelMov.Click += new System.EventHandler(this.btnCancelMov_Click);
            // 
            // txtIdMov
            // 
            this.txtIdMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movimentacaoBindingSource, "Id", true));
            this.txtIdMov.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMov.Location = new System.Drawing.Point(105, 9);
            this.txtIdMov.Name = "txtIdMov";
            this.txtIdMov.ReadOnly = true;
            this.txtIdMov.Size = new System.Drawing.Size(100, 26);
            this.txtIdMov.TabIndex = 26;
            // 
            // txtDescricaoMov
            // 
            this.txtDescricaoMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movimentacaoBindingSource, "Descricao", true));
            this.txtDescricaoMov.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoMov.Location = new System.Drawing.Point(105, 102);
            this.txtDescricaoMov.Multiline = true;
            this.txtDescricaoMov.Name = "txtDescricaoMov";
            this.txtDescricaoMov.Size = new System.Drawing.Size(524, 74);
            this.txtDescricaoMov.TabIndex = 24;
            // 
            // dataDateTimePickerDataMov
            // 
            this.dataDateTimePickerDataMov.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.movimentacaoBindingSource, "Data", true));
            this.dataDateTimePickerDataMov.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateTimePickerDataMov.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDateTimePickerDataMov.Location = new System.Drawing.Point(105, 56);
            this.dataDateTimePickerDataMov.Name = "dataDateTimePickerDataMov";
            this.dataDateTimePickerDataMov.Size = new System.Drawing.Size(125, 26);
            this.dataDateTimePickerDataMov.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel2.Controls.Add(this.cmbCompMov, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCompTelaMov, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(24, 101);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(285, 31);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // cmbCompMov
            // 
            this.cmbCompMov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCompMov.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.movimentacaoBindingSource, "Competencia_fk", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "MMMM/yyyy"));
            this.cmbCompMov.DataSource = this.competenciaBindingSource;
            this.cmbCompMov.DisplayMember = "CompNome";
            this.cmbCompMov.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompMov.FormatString = "MMMM/yyyy";
            this.cmbCompMov.FormattingEnabled = true;
            this.cmbCompMov.Location = new System.Drawing.Point(129, 3);
            this.cmbCompMov.Name = "cmbCompMov";
            this.cmbCompMov.Size = new System.Drawing.Size(153, 27);
            this.cmbCompMov.TabIndex = 27;
            this.cmbCompMov.ValueMember = "Id";
            // 
            // lblCompTelaMov
            // 
            this.lblCompTelaMov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCompTelaMov.CausesValidation = false;
            this.lblCompTelaMov.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompTelaMov.Location = new System.Drawing.Point(3, 4);
            this.lblCompTelaMov.Margin = new System.Windows.Forms.Padding(3);
            this.lblCompTelaMov.Name = "lblCompTelaMov";
            this.lblCompTelaMov.Size = new System.Drawing.Size(120, 22);
            this.lblCompTelaMov.TabIndex = 15;
            this.lblCompTelaMov.Text = "Competência:";
            this.lblCompTelaMov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblCompTelaMov, "A competência é formada pela junção do mês e ano");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 414F));
            this.tableLayoutPanel1.Controls.Add(this.lblEmpTelaMov, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbEmpMov, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 39);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // lblEmpTelaMov
            // 
            this.lblEmpTelaMov.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmpTelaMov.AutoSize = true;
            this.lblEmpTelaMov.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpTelaMov.Location = new System.Drawing.Point(3, 10);
            this.lblEmpTelaMov.Name = "lblEmpTelaMov";
            this.lblEmpTelaMov.Size = new System.Drawing.Size(85, 19);
            this.lblEmpTelaMov.TabIndex = 0;
            this.lblEmpTelaMov.Text = "Empresa:";
            this.lblEmpTelaMov.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEmpMov
            // 
            this.cmbEmpMov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmpMov.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.movimentacaoBindingSource, "Empresa_fk", true));
            this.cmbEmpMov.DataSource = this.empresaBindingSource;
            this.cmbEmpMov.DisplayMember = "NomeFantasia";
            this.cmbEmpMov.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpMov.FormattingEnabled = true;
            this.cmbEmpMov.Location = new System.Drawing.Point(115, 6);
            this.cmbEmpMov.Name = "cmbEmpMov";
            this.cmbEmpMov.Size = new System.Drawing.Size(408, 27);
            this.cmbEmpMov.TabIndex = 1;
            this.cmbEmpMov.ValueMember = "Id";
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataSource = typeof(Fabiane_Sistema_CaixaDiario.Empresa);
            // 
            // dataGridViewMov
            // 
            this.dataGridViewMov.AllowUserToAddRows = false;
            this.dataGridViewMov.AllowUserToDeleteRows = false;
            this.dataGridViewMov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewMov.AutoGenerateColumns = false;
            this.dataGridViewMov.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMov.ColumnHeadersHeight = 30;
            this.dataGridViewMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn63,
            this.dataGridViewTextBoxColumn64,
            this.dataGridViewTextBoxColumn65,
            this.dataGridViewTextBoxColumn66,
            this.dataGridViewTextBoxColumn67,
            this.dataGridViewTextBoxColumn68,
            this.dataGridViewTextBoxColumn69,
            this.dataGridViewTextBoxColumn70,
            this.dataGridViewTextBoxColumn71,
            this.dgvExcluirMov});
            this.dataGridViewMov.DataSource = this.movimentacaoBindingSource;
            this.dataGridViewMov.Location = new System.Drawing.Point(11, 366);
            this.dataGridViewMov.Name = "dataGridViewMov";
            this.dataGridViewMov.ReadOnly = true;
            this.dataGridViewMov.RowHeadersVisible = false;
            this.dataGridViewMov.Size = new System.Drawing.Size(1294, 328);
            this.dataGridViewMov.TabIndex = 0;
            this.dataGridViewMov.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMov_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Seq";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.ToolTipText = "Número Sequencial";
            this.Id.Width = 50;
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn63.HeaderText = "Data";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn63.ReadOnly = true;
            this.dataGridViewTextBoxColumn63.Width = 80;
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn64.HeaderText = "Descricão";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn64.ReadOnly = true;
            this.dataGridViewTextBoxColumn64.Width = 200;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn65.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn65.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.DataPropertyName = "TipoMovimentacao_fk";
            this.dataGridViewTextBoxColumn66.DataSource = this.tipoMovimentacaoBindingSource;
            this.dataGridViewTextBoxColumn66.DisplayMember = "TipoMovimentacao1";
            this.dataGridViewTextBoxColumn66.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn66.HeaderText = "Tipo Movimentação";
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            this.dataGridViewTextBoxColumn66.ReadOnly = true;
            this.dataGridViewTextBoxColumn66.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn66.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn66.ValueMember = "Id";
            this.dataGridViewTextBoxColumn66.Width = 150;
            // 
            // dataGridViewTextBoxColumn67
            // 
            this.dataGridViewTextBoxColumn67.DataPropertyName = "ParteEnvolvida_fk";
            this.dataGridViewTextBoxColumn67.DataSource = this.parteEnvolvidaBindingSource;
            this.dataGridViewTextBoxColumn67.DisplayMember = "Nome";
            this.dataGridViewTextBoxColumn67.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn67.HeaderText = "Parte Envolvida";
            this.dataGridViewTextBoxColumn67.Name = "dataGridViewTextBoxColumn67";
            this.dataGridViewTextBoxColumn67.ReadOnly = true;
            this.dataGridViewTextBoxColumn67.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn67.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn67.ValueMember = "Id";
            this.dataGridViewTextBoxColumn67.Width = 150;
            // 
            // dataGridViewTextBoxColumn68
            // 
            this.dataGridViewTextBoxColumn68.DataPropertyName = "Competencia_fk";
            this.dataGridViewTextBoxColumn68.DataSource = this.competenciaBindingSource;
            this.dataGridViewTextBoxColumn68.DisplayMember = "CompNome";
            this.dataGridViewTextBoxColumn68.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn68.HeaderText = "Competência";
            this.dataGridViewTextBoxColumn68.Name = "dataGridViewTextBoxColumn68";
            this.dataGridViewTextBoxColumn68.ReadOnly = true;
            this.dataGridViewTextBoxColumn68.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn68.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn68.ValueMember = "Id";
            this.dataGridViewTextBoxColumn68.Width = 150;
            // 
            // dataGridViewTextBoxColumn69
            // 
            this.dataGridViewTextBoxColumn69.DataPropertyName = "Empresa_fk";
            this.dataGridViewTextBoxColumn69.DataSource = this.empresaBindingSource;
            this.dataGridViewTextBoxColumn69.DisplayMember = "NomeFantasia";
            this.dataGridViewTextBoxColumn69.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn69.HeaderText = "Empresa";
            this.dataGridViewTextBoxColumn69.Name = "dataGridViewTextBoxColumn69";
            this.dataGridViewTextBoxColumn69.ReadOnly = true;
            this.dataGridViewTextBoxColumn69.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn69.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn69.ValueMember = "Id";
            this.dataGridViewTextBoxColumn69.Width = 150;
            // 
            // dataGridViewTextBoxColumn70
            // 
            this.dataGridViewTextBoxColumn70.DataPropertyName = "DataRegistro";
            this.dataGridViewTextBoxColumn70.HeaderText = "Data Registro";
            this.dataGridViewTextBoxColumn70.Name = "dataGridViewTextBoxColumn70";
            this.dataGridViewTextBoxColumn70.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn71
            // 
            this.dataGridViewTextBoxColumn71.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn71.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn71.Name = "dataGridViewTextBoxColumn71";
            this.dataGridViewTextBoxColumn71.ReadOnly = true;
            // 
            // dgvExcluirMov
            // 
            this.dgvExcluirMov.HeaderText = "Exluir";
            this.dgvExcluirMov.Name = "dgvExcluirMov";
            this.dgvExcluirMov.ReadOnly = true;
            this.dgvExcluirMov.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvExcluirMov.Text = "X";
            this.dgvExcluirMov.ToolTipText = "Apaga o registro da linha selecionada";
            this.dgvExcluirMov.UseColumnTextForButtonValue = true;
            this.dgvExcluirMov.Width = 62;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCxDiario);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.TabParteEnvolvida);
            this.tabControl1.Controls.Add(this.tabTPEnv);
            this.tabControl1.Controls.Add(this.TabTipoMov);
            this.tabControl1.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1365, 731);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Tan;
            this.tabPage1.Controls.Add(this.btnSalvarEmpresa);
            this.tabPage1.Controls.Add(this.empresaDataGridView);
            this.tabPage1.Controls.Add(this.btnCancelarEmpresa);
            this.tabPage1.Controls.Add(this.btnEditarEmpresa);
            this.tabPage1.Controls.Add(this.btnIncluirEmpresa);
            this.tabPage1.Controls.Add(lblEmpTitle);
            this.tabPage1.Controls.Add(this.panelEmpresa);
            this.tabPage1.Font = new System.Drawing.Font("Eras Medium ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1357, 702);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Empresa";
            // 
            // btnSalvarEmpresa
            // 
            this.btnSalvarEmpresa.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarEmpresa.Location = new System.Drawing.Point(566, 276);
            this.btnSalvarEmpresa.Name = "btnSalvarEmpresa";
            this.btnSalvarEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEmpresa.TabIndex = 6;
            this.btnSalvarEmpresa.Text = "&Salvar";
            this.toolTip1.SetToolTip(this.btnSalvarEmpresa, "Gravas as informações inseridas nos campos");
            this.btnSalvarEmpresa.UseVisualStyleBackColor = true;
            this.btnSalvarEmpresa.Click += new System.EventHandler(this.btnSalvarEmpresa_Click);
            // 
            // empresaDataGridView
            // 
            this.empresaDataGridView.AllowUserToAddRows = false;
            this.empresaDataGridView.AllowUserToDeleteRows = false;
            this.empresaDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empresaDataGridView.AutoGenerateColumns = false;
            this.empresaDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.empresaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empresaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empresaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.DeleteEmpColumn});
            this.empresaDataGridView.DataSource = this.empresaBindingSource;
            this.empresaDataGridView.Location = new System.Drawing.Point(9, 369);
            this.empresaDataGridView.Name = "empresaDataGridView";
            this.empresaDataGridView.ReadOnly = true;
            this.empresaDataGridView.RowHeadersVisible = false;
            this.empresaDataGridView.Size = new System.Drawing.Size(1271, 220);
            this.empresaDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn39.HeaderText = "Seq";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            this.dataGridViewTextBoxColumn39.ToolTipText = "Número Sequêncial";
            this.dataGridViewTextBoxColumn39.Width = 60;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "NomeFantasia";
            this.dataGridViewTextBoxColumn40.HeaderText = "Nome Fantasia";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            this.dataGridViewTextBoxColumn40.Width = 250;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "RazaoSocial";
            this.dataGridViewTextBoxColumn41.HeaderText = "Razão Social";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            this.dataGridViewTextBoxColumn41.Width = 200;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "Endereco";
            this.dataGridViewTextBoxColumn42.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            this.dataGridViewTextBoxColumn42.Width = 200;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "CEP";
            this.dataGridViewTextBoxColumn43.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "Fone";
            this.dataGridViewTextBoxColumn44.HeaderText = "Fone";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn45.HeaderText = "Email";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "DataRegistro";
            this.dataGridViewTextBoxColumn46.HeaderText = "Data Registro";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn47.HeaderText = "Usuário";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.ReadOnly = true;
            // 
            // DeleteEmpColumn
            // 
            this.DeleteEmpColumn.HeaderText = "Excluir";
            this.DeleteEmpColumn.Name = "DeleteEmpColumn";
            this.DeleteEmpColumn.ReadOnly = true;
            this.DeleteEmpColumn.Text = "X";
            this.DeleteEmpColumn.UseColumnTextForButtonValue = true;
            this.DeleteEmpColumn.Width = 70;
            // 
            // btnCancelarEmpresa
            // 
            this.btnCancelarEmpresa.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEmpresa.Location = new System.Drawing.Point(448, 276);
            this.btnCancelarEmpresa.Name = "btnCancelarEmpresa";
            this.btnCancelarEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEmpresa.TabIndex = 7;
            this.btnCancelarEmpresa.Text = "&Cancelar";
            this.toolTip1.SetToolTip(this.btnCancelarEmpresa, "Desfaz os lançamentos feitos nos campos, impedindo que seja gravado no banco de d" +
        "ados");
            this.btnCancelarEmpresa.UseVisualStyleBackColor = true;
            this.btnCancelarEmpresa.Click += new System.EventHandler(this.btnCancelarEmpresa_Click);
            // 
            // btnEditarEmpresa
            // 
            this.btnEditarEmpresa.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEmpresa.Location = new System.Drawing.Point(330, 276);
            this.btnEditarEmpresa.Name = "btnEditarEmpresa";
            this.btnEditarEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEmpresa.TabIndex = 1;
            this.btnEditarEmpresa.Text = "&Editar";
            this.toolTip1.SetToolTip(this.btnEditarEmpresa, "Permite alterar os dados de uma empresa já cadastrada");
            this.btnEditarEmpresa.UseVisualStyleBackColor = true;
            this.btnEditarEmpresa.Click += new System.EventHandler(this.btnEditarEmpresa_Click);
            // 
            // btnIncluirEmpresa
            // 
            this.btnIncluirEmpresa.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirEmpresa.Location = new System.Drawing.Point(212, 276);
            this.btnIncluirEmpresa.Name = "btnIncluirEmpresa";
            this.btnIncluirEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirEmpresa.TabIndex = 0;
            this.btnIncluirEmpresa.Text = "I&ncluir";
            this.toolTip1.SetToolTip(this.btnIncluirEmpresa, "Abre os campos para novo lançamento de um novo registro de uma empresa não cadast" +
        "rada");
            this.btnIncluirEmpresa.UseVisualStyleBackColor = true;
            this.btnIncluirEmpresa.Click += new System.EventHandler(this.btnIncluirEmpresa_Click);
            // 
            // panelEmpresa
            // 
            this.panelEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelEmpresa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelEmpresa.Controls.Add(this.mskbxCEPEmp);
            this.panelEmpresa.Controls.Add(this.mskbxFoneEmp);
            this.panelEmpresa.Controls.Add(cEPLabel);
            this.panelEmpresa.Controls.Add(emailLabel);
            this.panelEmpresa.Controls.Add(this.emailTextBox);
            this.panelEmpresa.Controls.Add(enderecoLabel);
            this.panelEmpresa.Controls.Add(this.enderecoTextBox);
            this.panelEmpresa.Controls.Add(foneLabel);
            this.panelEmpresa.Controls.Add(nomeFantasiaLabel);
            this.panelEmpresa.Controls.Add(this.nomeFantasiaTextBox);
            this.panelEmpresa.Controls.Add(razaoSocialLabel);
            this.panelEmpresa.Controls.Add(this.razaoSocialTextBox);
            this.panelEmpresa.Location = new System.Drawing.Point(197, 93);
            this.panelEmpresa.Name = "panelEmpresa";
            this.panelEmpresa.Size = new System.Drawing.Size(998, 178);
            this.panelEmpresa.TabIndex = 20;
            // 
            // mskbxCEPEmp
            // 
            this.mskbxCEPEmp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "CEP", true));
            this.mskbxCEPEmp.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxCEPEmp.Location = new System.Drawing.Point(879, 143);
            this.mskbxCEPEmp.Mask = "99999-999";
            this.mskbxCEPEmp.Name = "mskbxCEPEmp";
            this.mskbxCEPEmp.Size = new System.Drawing.Size(94, 26);
            this.mskbxCEPEmp.TabIndex = 21;
            // 
            // mskbxFoneEmp
            // 
            this.mskbxFoneEmp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "Fone", true));
            this.mskbxFoneEmp.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxFoneEmp.Location = new System.Drawing.Point(856, 94);
            this.mskbxFoneEmp.Mask = "(99) 9999-9999";
            this.mskbxFoneEmp.Name = "mskbxFoneEmp";
            this.mskbxFoneEmp.Size = new System.Drawing.Size(117, 26);
            this.mskbxFoneEmp.TabIndex = 22;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(174, 98);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(597, 26);
            this.emailTextBox.TabIndex = 2;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "Endereco", true));
            this.enderecoTextBox.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTextBox.Location = new System.Drawing.Point(174, 143);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(632, 26);
            this.enderecoTextBox.TabIndex = 4;
            // 
            // nomeFantasiaTextBox
            // 
            this.nomeFantasiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "NomeFantasia", true));
            this.nomeFantasiaTextBox.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFantasiaTextBox.Location = new System.Drawing.Point(174, 8);
            this.nomeFantasiaTextBox.Name = "nomeFantasiaTextBox";
            this.nomeFantasiaTextBox.Size = new System.Drawing.Size(799, 26);
            this.nomeFantasiaTextBox.TabIndex = 0;
            // 
            // razaoSocialTextBox
            // 
            this.razaoSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "RazaoSocial", true));
            this.razaoSocialTextBox.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razaoSocialTextBox.Location = new System.Drawing.Point(174, 53);
            this.razaoSocialTextBox.Name = "razaoSocialTextBox";
            this.razaoSocialTextBox.Size = new System.Drawing.Size(799, 26);
            this.razaoSocialTextBox.TabIndex = 1;
            // 
            // TabParteEnvolvida
            // 
            this.TabParteEnvolvida.BackColor = System.Drawing.Color.Tan;
            this.TabParteEnvolvida.Controls.Add(this.panelPEnv);
            this.TabParteEnvolvida.Controls.Add(this.btnEditPEnv);
            this.TabParteEnvolvida.Controls.Add(this.btnIncluirPEnv);
            this.TabParteEnvolvida.Controls.Add(lblPEnvTitle);
            this.TabParteEnvolvida.Controls.Add(dataRegistroLabel);
            this.TabParteEnvolvida.Controls.Add(this.dataRegistroDateTimePicker);
            this.TabParteEnvolvida.Controls.Add(usuarioLabel);
            this.TabParteEnvolvida.Controls.Add(this.usuarioTextBox);
            this.TabParteEnvolvida.Controls.Add(this.parteEnvolvidaDataGridView);
            this.TabParteEnvolvida.Location = new System.Drawing.Point(4, 25);
            this.TabParteEnvolvida.Name = "TabParteEnvolvida";
            this.TabParteEnvolvida.Padding = new System.Windows.Forms.Padding(3);
            this.TabParteEnvolvida.Size = new System.Drawing.Size(1357, 702);
            this.TabParteEnvolvida.TabIndex = 6;
            this.TabParteEnvolvida.Text = "Parte Envolvida";
            // 
            // panelPEnv
            // 
            this.panelPEnv.Controls.Add(this.msktxtFone);
            this.panelPEnv.Controls.Add(this.btnSalvarPEnv);
            this.panelPEnv.Controls.Add(this.btnCancelPEnv);
            this.panelPEnv.Controls.Add(this.msktxtCEP);
            this.panelPEnv.Controls.Add(this.cboTPEnvolvida);
            this.panelPEnv.Controls.Add(cEPLabel1);
            this.panelPEnv.Controls.Add(emailLabel1);
            this.panelPEnv.Controls.Add(this.txtEmailPEnv);
            this.panelPEnv.Controls.Add(enderecoLabel1);
            this.panelPEnv.Controls.Add(this.txtEnderecoPEnv);
            this.panelPEnv.Controls.Add(foneLabel1);
            this.panelPEnv.Controls.Add(idLabel1);
            this.panelPEnv.Controls.Add(this.txtIdPEnv);
            this.panelPEnv.Controls.Add(nomeLabel);
            this.panelPEnv.Controls.Add(this.txtNomePEnv);
            this.panelPEnv.Controls.Add(tipoParteEnvolvida_fkLabel);
            this.panelPEnv.Location = new System.Drawing.Point(40, 75);
            this.panelPEnv.Name = "panelPEnv";
            this.panelPEnv.Size = new System.Drawing.Size(890, 217);
            this.panelPEnv.TabIndex = 1;
            // 
            // msktxtFone
            // 
            this.msktxtFone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parteEnvolvidaBindingSource, "Fone", true));
            this.msktxtFone.Location = new System.Drawing.Point(120, 174);
            this.msktxtFone.Mask = "(99) 9999-9999";
            this.msktxtFone.Name = "msktxtFone";
            this.msktxtFone.Size = new System.Drawing.Size(117, 24);
            this.msktxtFone.TabIndex = 7;
            // 
            // btnSalvarPEnv
            // 
            this.btnSalvarPEnv.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPEnv.Location = new System.Drawing.Point(424, 175);
            this.btnSalvarPEnv.Name = "btnSalvarPEnv";
            this.btnSalvarPEnv.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPEnv.TabIndex = 8;
            this.btnSalvarPEnv.Text = "&Salvar";
            this.toolTip1.SetToolTip(this.btnSalvarPEnv, "Gravas as informações inseridas nos campos");
            this.btnSalvarPEnv.UseVisualStyleBackColor = true;
            this.btnSalvarPEnv.Click += new System.EventHandler(this.btnSalvarPEnv_Click);
            // 
            // btnCancelPEnv
            // 
            this.btnCancelPEnv.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPEnv.Location = new System.Drawing.Point(306, 175);
            this.btnCancelPEnv.Name = "btnCancelPEnv";
            this.btnCancelPEnv.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPEnv.TabIndex = 9;
            this.btnCancelPEnv.Text = "&Cancelar";
            this.toolTip1.SetToolTip(this.btnCancelPEnv, "Desfaz os lançamentos feitos nos campos, impedindo que seja gravado no banco de d" +
        "ados");
            this.btnCancelPEnv.UseVisualStyleBackColor = true;
            this.btnCancelPEnv.Click += new System.EventHandler(this.btnCancPEnv_Click);
            // 
            // msktxtCEP
            // 
            this.msktxtCEP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parteEnvolvidaBindingSource, "CEP", true));
            this.msktxtCEP.Location = new System.Drawing.Point(120, 139);
            this.msktxtCEP.Mask = "99999-999";
            this.msktxtCEP.Name = "msktxtCEP";
            this.msktxtCEP.Size = new System.Drawing.Size(94, 24);
            this.msktxtCEP.TabIndex = 5;
            // 
            // cboTPEnvolvida
            // 
            this.cboTPEnvolvida.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.parteEnvolvidaBindingSource, "TipoParteEnvolvida_fk", true));
            this.cboTPEnvolvida.DataSource = this.tipoParteEnvolvidaBindingSource;
            this.cboTPEnvolvida.DisplayMember = "Descricao";
            this.cboTPEnvolvida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTPEnvolvida.FormattingEnabled = true;
            this.cboTPEnvolvida.Location = new System.Drawing.Point(624, 14);
            this.cboTPEnvolvida.Name = "cboTPEnvolvida";
            this.cboTPEnvolvida.Size = new System.Drawing.Size(203, 24);
            this.cboTPEnvolvida.TabIndex = 2;
            this.cboTPEnvolvida.ValueMember = "Id";
            // 
            // tipoParteEnvolvidaBindingSource
            // 
            this.tipoParteEnvolvidaBindingSource.DataSource = typeof(Fabiane_Sistema_CaixaDiario.TipoParteEnvolvida);
            // 
            // txtEmailPEnv
            // 
            this.txtEmailPEnv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parteEnvolvidaBindingSource, "Email", true));
            this.txtEmailPEnv.Location = new System.Drawing.Point(375, 142);
            this.txtEmailPEnv.Name = "txtEmailPEnv";
            this.txtEmailPEnv.Size = new System.Drawing.Size(452, 24);
            this.txtEmailPEnv.TabIndex = 6;
            // 
            // txtEnderecoPEnv
            // 
            this.txtEnderecoPEnv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parteEnvolvidaBindingSource, "Endereco", true));
            this.txtEnderecoPEnv.Location = new System.Drawing.Point(120, 109);
            this.txtEnderecoPEnv.Name = "txtEnderecoPEnv";
            this.txtEnderecoPEnv.Size = new System.Drawing.Size(707, 24);
            this.txtEnderecoPEnv.TabIndex = 4;
            // 
            // txtIdPEnv
            // 
            this.txtIdPEnv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parteEnvolvidaBindingSource, "Id", true));
            this.txtIdPEnv.Location = new System.Drawing.Point(120, 19);
            this.txtIdPEnv.Name = "txtIdPEnv";
            this.txtIdPEnv.ReadOnly = true;
            this.txtIdPEnv.Size = new System.Drawing.Size(152, 24);
            this.txtIdPEnv.TabIndex = 1;
            // 
            // txtNomePEnv
            // 
            this.txtNomePEnv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parteEnvolvidaBindingSource, "Nome", true));
            this.txtNomePEnv.Location = new System.Drawing.Point(120, 49);
            this.txtNomePEnv.Name = "txtNomePEnv";
            this.txtNomePEnv.Size = new System.Drawing.Size(707, 24);
            this.txtNomePEnv.TabIndex = 3;
            // 
            // btnEditPEnv
            // 
            this.btnEditPEnv.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPEnv.Location = new System.Drawing.Point(179, 319);
            this.btnEditPEnv.Name = "btnEditPEnv";
            this.btnEditPEnv.Size = new System.Drawing.Size(75, 23);
            this.btnEditPEnv.TabIndex = 10;
            this.btnEditPEnv.Text = "&Editar";
            this.toolTip1.SetToolTip(this.btnEditPEnv, "Permite alterar os dados de uma empresa já cadastrada");
            this.btnEditPEnv.UseVisualStyleBackColor = true;
            this.btnEditPEnv.Click += new System.EventHandler(this.btnEditarPEnv_Click);
            // 
            // btnIncluirPEnv
            // 
            this.btnIncluirPEnv.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirPEnv.Location = new System.Drawing.Point(61, 319);
            this.btnIncluirPEnv.Name = "btnIncluirPEnv";
            this.btnIncluirPEnv.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirPEnv.TabIndex = 0;
            this.btnIncluirPEnv.Text = "I&ncluir";
            this.toolTip1.SetToolTip(this.btnIncluirPEnv, "Abre os campos para novo lançamento de um novo registro de uma empresa não cadast" +
        "rada");
            this.btnIncluirPEnv.UseVisualStyleBackColor = true;
            this.btnIncluirPEnv.Click += new System.EventHandler(this.btnIncluirPEnv_Click);
            // 
            // dataRegistroDateTimePicker
            // 
            this.dataRegistroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.parteEnvolvidaBindingSource, "DataRegistro", true));
            this.dataRegistroDateTimePicker.Location = new System.Drawing.Point(941, 151);
            this.dataRegistroDateTimePicker.Name = "dataRegistroDateTimePicker";
            this.dataRegistroDateTimePicker.Size = new System.Drawing.Size(252, 24);
            this.dataRegistroDateTimePicker.TabIndex = 4;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parteEnvolvidaBindingSource, "Usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(939, 94);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.ReadOnly = true;
            this.usuarioTextBox.Size = new System.Drawing.Size(252, 24);
            this.usuarioTextBox.TabIndex = 18;
            // 
            // parteEnvolvidaDataGridView
            // 
            this.parteEnvolvidaDataGridView.AllowUserToAddRows = false;
            this.parteEnvolvidaDataGridView.AllowUserToDeleteRows = false;
            this.parteEnvolvidaDataGridView.AutoGenerateColumns = false;
            this.parteEnvolvidaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.parteEnvolvidaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parteEnvolvidaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn32,
            this.nomeDataGridViewTextBoxColumn,
            this.tipoParteEnvolvidafkDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.BtnExcluirPEnv});
            this.parteEnvolvidaDataGridView.DataSource = this.parteEnvolvidaBindingSource;
            this.parteEnvolvidaDataGridView.Location = new System.Drawing.Point(40, 378);
            this.parteEnvolvidaDataGridView.Name = "parteEnvolvidaDataGridView";
            this.parteEnvolvidaDataGridView.ReadOnly = true;
            this.parteEnvolvidaDataGridView.Size = new System.Drawing.Size(1258, 220);
            this.parteEnvolvidaDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn32.HeaderText = "Seq";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.ToolTipText = "Número Sequêncial";
            this.dataGridViewTextBoxColumn32.Width = 80;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 300;
            // 
            // tipoParteEnvolvidafkDataGridViewTextBoxColumn
            // 
            this.tipoParteEnvolvidafkDataGridViewTextBoxColumn.DataPropertyName = "TipoParteEnvolvida_fk";
            this.tipoParteEnvolvidafkDataGridViewTextBoxColumn.DataSource = this.tipoParteEnvolvidaBindingSource;
            this.tipoParteEnvolvidafkDataGridViewTextBoxColumn.DisplayMember = "Descricao";
            this.tipoParteEnvolvidafkDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tipoParteEnvolvidafkDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoParteEnvolvidafkDataGridViewTextBoxColumn.Name = "tipoParteEnvolvidafkDataGridViewTextBoxColumn";
            this.tipoParteEnvolvidafkDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoParteEnvolvidafkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipoParteEnvolvidafkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tipoParteEnvolvidafkDataGridViewTextBoxColumn.ValueMember = "Id";
            this.tipoParteEnvolvidafkDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Endereco";
            this.dataGridViewTextBoxColumn33.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "CEP";
            this.dataGridViewTextBoxColumn34.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Fone";
            this.dataGridViewTextBoxColumn35.HeaderText = "Fone";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn36.HeaderText = "Email";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "DataRegistro";
            this.dataGridViewTextBoxColumn37.HeaderText = "Data Registro";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn38.HeaderText = "Usuário";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            // 
            // BtnExcluirPEnv
            // 
            this.BtnExcluirPEnv.HeaderText = "Excluir";
            this.BtnExcluirPEnv.Name = "BtnExcluirPEnv";
            this.BtnExcluirPEnv.ReadOnly = true;
            this.BtnExcluirPEnv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtnExcluirPEnv.Text = "X";
            this.BtnExcluirPEnv.ToolTipText = "Apaga o registro da linha selecionada";
            this.BtnExcluirPEnv.UseColumnTextForButtonValue = true;
            this.BtnExcluirPEnv.Width = 70;
            // 
            // tabTPEnv
            // 
            this.tabTPEnv.BackColor = System.Drawing.Color.Tan;
            this.tabTPEnv.Controls.Add(this.panelTPEnv);
            this.tabTPEnv.Controls.Add(this.btnEditTPEnv);
            this.tabTPEnv.Controls.Add(this.btnIncluirTPEnv);
            this.tabTPEnv.Controls.Add(lblTPEnvTitle);
            this.tabTPEnv.Controls.Add(this.tipoParteEnvolvidaDataGridView);
            this.tabTPEnv.Location = new System.Drawing.Point(4, 25);
            this.tabTPEnv.Name = "tabTPEnv";
            this.tabTPEnv.Padding = new System.Windows.Forms.Padding(3);
            this.tabTPEnv.Size = new System.Drawing.Size(1357, 702);
            this.tabTPEnv.TabIndex = 7;
            this.tabTPEnv.Text = "Tipo Parte Envolvida";
            // 
            // panelTPEnv
            // 
            this.panelTPEnv.Controls.Add(lblidTPEnv);
            this.panelTPEnv.Controls.Add(this.btnSalvarTPEnv);
            this.panelTPEnv.Controls.Add(this.btnCancTPEnv);
            this.panelTPEnv.Controls.Add(lblDescricaoTPEnv);
            this.panelTPEnv.Controls.Add(this.descricaoTPEnv);
            this.panelTPEnv.Controls.Add(this.txtIdTPEnv);
            this.panelTPEnv.Location = new System.Drawing.Point(55, 147);
            this.panelTPEnv.Name = "panelTPEnv";
            this.panelTPEnv.Size = new System.Drawing.Size(405, 88);
            this.panelTPEnv.TabIndex = 18;
            // 
            // btnSalvarTPEnv
            // 
            this.btnSalvarTPEnv.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTPEnv.Location = new System.Drawing.Point(314, 10);
            this.btnSalvarTPEnv.Name = "btnSalvarTPEnv";
            this.btnSalvarTPEnv.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarTPEnv.TabIndex = 1;
            this.btnSalvarTPEnv.Text = "&Salvar";
            this.btnSalvarTPEnv.UseVisualStyleBackColor = true;
            this.btnSalvarTPEnv.Click += new System.EventHandler(this.btnSalvarTPEnv_Click);
            // 
            // btnCancTPEnv
            // 
            this.btnCancTPEnv.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancTPEnv.Location = new System.Drawing.Point(314, 53);
            this.btnCancTPEnv.Name = "btnCancTPEnv";
            this.btnCancTPEnv.Size = new System.Drawing.Size(75, 23);
            this.btnCancTPEnv.TabIndex = 2;
            this.btnCancTPEnv.Text = "&Cancelar";
            this.btnCancTPEnv.UseVisualStyleBackColor = true;
            this.btnCancTPEnv.Click += new System.EventHandler(this.btnCancTPEnv_Click);
            // 
            // descricaoTPEnv
            // 
            this.descricaoTPEnv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoParteEnvolvidaBindingSource, "Descricao", true));
            this.descricaoTPEnv.Location = new System.Drawing.Point(124, 49);
            this.descricaoTPEnv.Name = "descricaoTPEnv";
            this.descricaoTPEnv.Size = new System.Drawing.Size(184, 24);
            this.descricaoTPEnv.TabIndex = 2;
            // 
            // txtIdTPEnv
            // 
            this.txtIdTPEnv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoParteEnvolvidaBindingSource, "Id", true));
            this.txtIdTPEnv.Location = new System.Drawing.Point(124, 9);
            this.txtIdTPEnv.Name = "txtIdTPEnv";
            this.txtIdTPEnv.ReadOnly = true;
            this.txtIdTPEnv.Size = new System.Drawing.Size(100, 24);
            this.txtIdTPEnv.TabIndex = 4;
            // 
            // btnEditTPEnv
            // 
            this.btnEditTPEnv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditTPEnv.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTPEnv.Location = new System.Drawing.Point(369, 247);
            this.btnEditTPEnv.Name = "btnEditTPEnv";
            this.btnEditTPEnv.Size = new System.Drawing.Size(75, 23);
            this.btnEditTPEnv.TabIndex = 16;
            this.btnEditTPEnv.Text = "&Editar";
            this.btnEditTPEnv.UseVisualStyleBackColor = true;
            this.btnEditTPEnv.Click += new System.EventHandler(this.btnEditarTPEnv_Click);
            // 
            // btnIncluirTPEnv
            // 
            this.btnIncluirTPEnv.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirTPEnv.Location = new System.Drawing.Point(264, 247);
            this.btnIncluirTPEnv.Name = "btnIncluirTPEnv";
            this.btnIncluirTPEnv.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirTPEnv.TabIndex = 17;
            this.btnIncluirTPEnv.Text = "I&ncluir";
            this.btnIncluirTPEnv.UseVisualStyleBackColor = true;
            this.btnIncluirTPEnv.Click += new System.EventHandler(this.btnIncluirTPEnv_Click);
            // 
            // tipoParteEnvolvidaDataGridView
            // 
            this.tipoParteEnvolvidaDataGridView.AllowUserToAddRows = false;
            this.tipoParteEnvolvidaDataGridView.AllowUserToDeleteRows = false;
            this.tipoParteEnvolvidaDataGridView.AutoGenerateColumns = false;
            this.tipoParteEnvolvidaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tipoParteEnvolvidaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoParteEnvolvidaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn31,
            this.btnExcluirTPEnv});
            this.tipoParteEnvolvidaDataGridView.DataSource = this.tipoParteEnvolvidaBindingSource;
            this.tipoParteEnvolvidaDataGridView.Location = new System.Drawing.Point(540, 147);
            this.tipoParteEnvolvidaDataGridView.Name = "tipoParteEnvolvidaDataGridView";
            this.tipoParteEnvolvidaDataGridView.ReadOnly = true;
            this.tipoParteEnvolvidaDataGridView.Size = new System.Drawing.Size(563, 220);
            this.tipoParteEnvolvidaDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn15.HeaderText = "Seq";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.ToolTipText = "Número Sequêncial";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn25.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 150;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "DataRegistro";
            this.dataGridViewTextBoxColumn26.HeaderText = "Data Registro";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn31.HeaderText = "Usuário";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // btnExcluirTPEnv
            // 
            this.btnExcluirTPEnv.HeaderText = "Excluir";
            this.btnExcluirTPEnv.Name = "btnExcluirTPEnv";
            this.btnExcluirTPEnv.ReadOnly = true;
            this.btnExcluirTPEnv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnExcluirTPEnv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnExcluirTPEnv.Text = "X";
            this.btnExcluirTPEnv.ToolTipText = "Apaga o registro da linha selecionada";
            this.btnExcluirTPEnv.UseColumnTextForButtonValue = true;
            this.btnExcluirTPEnv.Width = 70;
            // 
            // TabTipoMov
            // 
            this.TabTipoMov.BackColor = System.Drawing.Color.Tan;
            this.TabTipoMov.Controls.Add(this.panelTMov);
            this.TabTipoMov.Controls.Add(this.btnEditTMov);
            this.TabTipoMov.Controls.Add(this.btnIncluirTMov);
            this.TabTipoMov.Controls.Add(lblTMovTitle);
            this.TabTipoMov.Controls.Add(this.tipoMovimentacaoDataGridView);
            this.TabTipoMov.Location = new System.Drawing.Point(4, 25);
            this.TabTipoMov.Name = "TabTipoMov";
            this.TabTipoMov.Padding = new System.Windows.Forms.Padding(3);
            this.TabTipoMov.Size = new System.Drawing.Size(1357, 702);
            this.TabTipoMov.TabIndex = 8;
            this.TabTipoMov.Text = "Tipo de Movimentação";
            // 
            // panelTMov
            // 
            this.panelTMov.Controls.Add(this.btnSalvarTMov);
            this.panelTMov.Controls.Add(this.btnCancelTMov);
            this.panelTMov.Controls.Add(tipoMovimentacao1Label);
            this.panelTMov.Controls.Add(this.descricaoTMov);
            this.panelTMov.Controls.Add(idLabel4);
            this.panelTMov.Controls.Add(this.txtIdTMov);
            this.panelTMov.Location = new System.Drawing.Point(69, 206);
            this.panelTMov.Name = "panelTMov";
            this.panelTMov.Size = new System.Drawing.Size(405, 88);
            this.panelTMov.TabIndex = 21;
            // 
            // btnSalvarTMov
            // 
            this.btnSalvarTMov.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTMov.Location = new System.Drawing.Point(314, 10);
            this.btnSalvarTMov.Name = "btnSalvarTMov";
            this.btnSalvarTMov.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarTMov.TabIndex = 1;
            this.btnSalvarTMov.Text = "&Salvar";
            this.btnSalvarTMov.UseVisualStyleBackColor = true;
            this.btnSalvarTMov.Click += new System.EventHandler(this.btnSalvarTMov_Click);
            // 
            // btnCancelTMov
            // 
            this.btnCancelTMov.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTMov.Location = new System.Drawing.Point(314, 53);
            this.btnCancelTMov.Name = "btnCancelTMov";
            this.btnCancelTMov.Size = new System.Drawing.Size(75, 23);
            this.btnCancelTMov.TabIndex = 2;
            this.btnCancelTMov.Text = "&Cancelar";
            this.btnCancelTMov.UseVisualStyleBackColor = true;
            this.btnCancelTMov.Click += new System.EventHandler(this.btnCancTMov_Click);
            // 
            // descricaoTMov
            // 
            this.descricaoTMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoMovimentacaoBindingSource, "TipoMovimentacao1", true));
            this.descricaoTMov.Location = new System.Drawing.Point(180, 46);
            this.descricaoTMov.Name = "descricaoTMov";
            this.descricaoTMov.Size = new System.Drawing.Size(100, 24);
            this.descricaoTMov.TabIndex = 4;
            // 
            // txtIdTMov
            // 
            this.txtIdTMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoMovimentacaoBindingSource, "Id", true));
            this.txtIdTMov.Location = new System.Drawing.Point(180, 16);
            this.txtIdTMov.Name = "txtIdTMov";
            this.txtIdTMov.ReadOnly = true;
            this.txtIdTMov.Size = new System.Drawing.Size(100, 24);
            this.txtIdTMov.TabIndex = 2;
            // 
            // btnEditTMov
            // 
            this.btnEditTMov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditTMov.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTMov.Location = new System.Drawing.Point(383, 300);
            this.btnEditTMov.Name = "btnEditTMov";
            this.btnEditTMov.Size = new System.Drawing.Size(75, 23);
            this.btnEditTMov.TabIndex = 19;
            this.btnEditTMov.Text = "&Editar";
            this.btnEditTMov.UseVisualStyleBackColor = true;
            this.btnEditTMov.Click += new System.EventHandler(this.btnEditarTMov_Click);
            // 
            // btnIncluirTMov
            // 
            this.btnIncluirTMov.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirTMov.Location = new System.Drawing.Point(278, 300);
            this.btnIncluirTMov.Name = "btnIncluirTMov";
            this.btnIncluirTMov.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirTMov.TabIndex = 20;
            this.btnIncluirTMov.Text = "I&ncluir";
            this.btnIncluirTMov.UseVisualStyleBackColor = true;
            this.btnIncluirTMov.Click += new System.EventHandler(this.btnIncluirTMov_Click);
            // 
            // tipoMovimentacaoDataGridView
            // 
            this.tipoMovimentacaoDataGridView.AllowUserToAddRows = false;
            this.tipoMovimentacaoDataGridView.AllowUserToDeleteRows = false;
            this.tipoMovimentacaoDataGridView.AutoGenerateColumns = false;
            this.tipoMovimentacaoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tipoMovimentacaoDataGridView.ColumnHeadersHeight = 30;
            this.tipoMovimentacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tipoMovimentacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.tipoMovimentacao1DataGridViewTextBoxColumn,
            this.BtnExcluirTMov});
            this.tipoMovimentacaoDataGridView.DataSource = this.tipoMovimentacaoBindingSource;
            this.tipoMovimentacaoDataGridView.Location = new System.Drawing.Point(601, 150);
            this.tipoMovimentacaoDataGridView.Name = "tipoMovimentacaoDataGridView";
            this.tipoMovimentacaoDataGridView.ReadOnly = true;
            this.tipoMovimentacaoDataGridView.Size = new System.Drawing.Size(373, 220);
            this.tipoMovimentacaoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn13.HeaderText = "Seq";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 60;
            // 
            // tipoMovimentacao1DataGridViewTextBoxColumn
            // 
            this.tipoMovimentacao1DataGridViewTextBoxColumn.DataPropertyName = "TipoMovimentacao1";
            this.tipoMovimentacao1DataGridViewTextBoxColumn.HeaderText = "Tipo Movimentação";
            this.tipoMovimentacao1DataGridViewTextBoxColumn.Name = "tipoMovimentacao1DataGridViewTextBoxColumn";
            this.tipoMovimentacao1DataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoMovimentacao1DataGridViewTextBoxColumn.Width = 200;
            // 
            // BtnExcluirTMov
            // 
            this.BtnExcluirTMov.HeaderText = "Excluir";
            this.BtnExcluirTMov.Name = "BtnExcluirTMov";
            this.BtnExcluirTMov.ReadOnly = true;
            this.BtnExcluirTMov.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtnExcluirTMov.Text = "X";
            this.BtnExcluirTMov.ToolTipText = "Apaga o registro da linha selecionada";
            this.BtnExcluirTMov.UseColumnTextForButtonValue = true;
            this.BtnExcluirTMov.Width = 70;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1276, 742);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Caixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelComp.ResumeLayout(false);
            this.panelComp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCompetencia)).EndInit();
            this.tabPageCxDiario.ResumeLayout(false);
            this.tabPageCxDiario.PerformLayout();
            this.panelMov.ResumeLayout(false);
            this.panelMov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parteEnvolvidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMovimentacaoBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMov)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataGridView)).EndInit();
            this.panelEmpresa.ResumeLayout(false);
            this.panelEmpresa.PerformLayout();
            this.TabParteEnvolvida.ResumeLayout(false);
            this.TabParteEnvolvida.PerformLayout();
            this.panelPEnv.ResumeLayout(false);
            this.panelPEnv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoParteEnvolvidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parteEnvolvidaDataGridView)).EndInit();
            this.tabTPEnv.ResumeLayout(false);
            this.tabTPEnv.PerformLayout();
            this.panelTPEnv.ResumeLayout(false);
            this.panelTPEnv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoParteEnvolvidaDataGridView)).EndInit();
            this.TabTipoMov.ResumeLayout(false);
            this.TabTipoMov.PerformLayout();
            this.panelTMov.ResumeLayout(false);
            this.panelTMov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMovimentacaoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DataGridViewCompetencia;
        private System.Windows.Forms.TabPage tabPageCxDiario;
        private System.Windows.Forms.DataGridView dataGridViewMov;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSalvarComp;
        private System.Windows.Forms.Button btnCancelComp;
        private System.Windows.Forms.Button btnEditComp;
        private System.Windows.Forms.Button btnIncluirComp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEmpTelaMov;
        private System.Windows.Forms.Panel panelComp;
        private System.Windows.Forms.TextBox txtIdComp;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Button btnEditarEmpresa;
        private System.Windows.Forms.Button btnIncluirEmpresa;
        private System.Windows.Forms.Panel panelEmpresa;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox nomeFantasiaTextBox;
        private System.Windows.Forms.TextBox razaoSocialTextBox;
        private System.Windows.Forms.DataGridView empresaDataGridView;
        private System.Windows.Forms.Button btnSalvarEmpresa;
        private System.Windows.Forms.Button btnCancelarEmpresa;
        private System.Windows.Forms.DateTimePicker dateTimePickerComp;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.BindingSource competenciaBindingSource;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private System.Windows.Forms.TabPage TabParteEnvolvida;
        private System.Windows.Forms.BindingSource parteEnvolvidaBindingSource;
        private System.Windows.Forms.DateTimePicker dataRegistroDateTimePicker;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.DataGridView parteEnvolvidaDataGridView;
        private System.Windows.Forms.TabPage tabTPEnv;
        private System.Windows.Forms.TextBox descricaoTPEnv;
        private System.Windows.Forms.TextBox txtIdTPEnv;
        private System.Windows.Forms.DataGridView tipoParteEnvolvidaDataGridView;
        private System.Windows.Forms.TabPage TabTipoMov;
        private System.Windows.Forms.TextBox txtIdTMov;
        private System.Windows.Forms.BindingSource tipoMovimentacaoBindingSource;
        private System.Windows.Forms.TextBox descricaoTMov;
        private System.Windows.Forms.DataGridView tipoMovimentacaoDataGridView;
        private System.Windows.Forms.ComboBox cmbEmpMov;
        private System.Windows.Forms.BindingSource movimentacaoBindingSource;
        private System.Windows.Forms.Panel panelTPEnv;
        private System.Windows.Forms.Button btnSalvarTPEnv;
        private System.Windows.Forms.Button btnCancTPEnv;
        private System.Windows.Forms.Button btnEditTPEnv;
        private System.Windows.Forms.Button btnIncluirTPEnv;
        private System.Windows.Forms.BindingSource tipoParteEnvolvidaBindingSource;
        private System.Windows.Forms.Button btnSalvarPEnv;
        private System.Windows.Forms.Button btnCancelPEnv;
        private System.Windows.Forms.Button btnEditPEnv;
        private System.Windows.Forms.Button btnIncluirPEnv;
        private System.Windows.Forms.Panel panelPEnv;
        private System.Windows.Forms.TextBox txtEmailPEnv;
        private System.Windows.Forms.TextBox txtEnderecoPEnv;
        private System.Windows.Forms.TextBox txtIdPEnv;
        private System.Windows.Forms.TextBox txtNomePEnv;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelTMov;
        private System.Windows.Forms.Button btnSalvarTMov;
        private System.Windows.Forms.Button btnCancelTMov;
        private System.Windows.Forms.Button btnEditTMov;
        private System.Windows.Forms.Button btnIncluirTMov;
        private System.Windows.Forms.ComboBox cboTPEnvolvida;
        private System.Windows.Forms.MaskedTextBox msktxtFone;
        private System.Windows.Forms.MaskedTextBox msktxtCEP;
        private System.Windows.Forms.MaskedTextBox mskbxCEPEmp;
        private System.Windows.Forms.MaskedTextBox mskbxFoneEmp;
        private System.Windows.Forms.Label lblCompTelaMov;
        private System.Windows.Forms.Panel panelMov;
        private System.Windows.Forms.TextBox txtIdMov;
        private System.Windows.Forms.TextBox txtDescricaoMov;
        private System.Windows.Forms.DateTimePicker dataDateTimePickerDataMov;
        private System.Windows.Forms.Button btnEditMov;
        private System.Windows.Forms.Button btnIncluirMov;
        private System.Windows.Forms.Button btnSalvarMov;
        private System.Windows.Forms.Button btnCancelMov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox cmbTMov;
        private System.Windows.Forms.ComboBox cmbCompMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn66;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn67;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn68;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn69;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private System.Windows.Forms.DataGridViewButtonColumn dgvExcluirMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMovimentacao1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluirTMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluirTPEnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipoParteEnvolvidafkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluirPEnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteEmpColumn;
        private NumericBox.NumericBox numericBox1;
    }
}

