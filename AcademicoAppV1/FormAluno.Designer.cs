namespace AcademicoAppV1
{
    partial class FormAluno
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
            if (disposing && (components != null))
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAluno));
            tabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            materialButtonSalvar = new ReaLTaiizor.Controls.MaterialButton();
            materiaButtonCancelar = new ReaLTaiizor.Controls.MaterialButton();
            materialComboBoxEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            materialMaskedTextBoxData = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialTextBoxSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBoxMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            materialButtonExcluir = new ReaLTaiizor.Controls.MaterialButton();
            materialButtonEditar = new ReaLTaiizor.Controls.MaterialButton();
            materialButtonNovo = new ReaLTaiizor.Controls.MaterialButton();
            materialListView1 = new ReaLTaiizor.Controls.MaterialListView();
            imageList1 = new ImageList(components);
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Controls.Add(tabPageCadastro);
            tabControlCadastro.Controls.Add(tabPageConsulta);
            tabControlCadastro.Depth = 0;
            tabControlCadastro.Dock = DockStyle.Fill;
            tabControlCadastro.ImageList = imageList1;
            tabControlCadastro.Location = new Point(3, 64);
            tabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlCadastro.Multiline = true;
            tabControlCadastro.Name = "tabControlCadastro";
            tabControlCadastro.SelectedIndex = 0;
            tabControlCadastro.Size = new Size(794, 435);
            tabControlCadastro.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(materialButtonSalvar);
            tabPageCadastro.Controls.Add(materiaButtonCancelar);
            tabPageCadastro.Controls.Add(materialComboBoxEstado);
            tabPageCadastro.Controls.Add(materialMaskedTextBoxData);
            tabPageCadastro.Controls.Add(materialTextBoxSenha);
            tabPageCadastro.Controls.Add(materialTextBoxCidade);
            tabPageCadastro.Controls.Add(materialTextBoxBairro);
            tabPageCadastro.Controls.Add(materialTextBoxEndereco);
            tabPageCadastro.Controls.Add(materialTextBoxNome);
            tabPageCadastro.Controls.Add(materialTextBoxMatricula);
            tabPageCadastro.ImageKey = "form.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(786, 400);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // materialButtonSalvar
            // 
            materialButtonSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSalvar.Depth = 0;
            materialButtonSalvar.HighEmphasis = true;
            materialButtonSalvar.Icon = null;
            materialButtonSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButtonSalvar.Location = new Point(675, 351);
            materialButtonSalvar.Margin = new Padding(4, 6, 4, 6);
            materialButtonSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButtonSalvar.Name = "materialButtonSalvar";
            materialButtonSalvar.NoAccentTextColor = Color.Empty;
            materialButtonSalvar.Size = new Size(76, 36);
            materialButtonSalvar.TabIndex = 15;
            materialButtonSalvar.Text = "Salvar";
            materialButtonSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonSalvar.UseAccentColor = false;
            materialButtonSalvar.UseVisualStyleBackColor = true;
            // 
            // materiaButtonCancelar
            // 
            materiaButtonCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materiaButtonCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materiaButtonCancelar.Depth = 0;
            materiaButtonCancelar.HighEmphasis = true;
            materiaButtonCancelar.Icon = null;
            materiaButtonCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materiaButtonCancelar.Location = new Point(571, 351);
            materiaButtonCancelar.Margin = new Padding(4, 6, 4, 6);
            materiaButtonCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materiaButtonCancelar.Name = "materiaButtonCancelar";
            materiaButtonCancelar.NoAccentTextColor = Color.Empty;
            materiaButtonCancelar.Size = new Size(96, 36);
            materiaButtonCancelar.TabIndex = 14;
            materiaButtonCancelar.Text = "Cancelar";
            materiaButtonCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materiaButtonCancelar.UseAccentColor = false;
            materiaButtonCancelar.UseVisualStyleBackColor = true;
            materiaButtonCancelar.Click += materiaButtonCancelar_Click;
            // 
            // materialComboBoxEstado
            // 
            materialComboBoxEstado.AutoResize = false;
            materialComboBoxEstado.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxEstado.Depth = 0;
            materialComboBoxEstado.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxEstado.DropDownHeight = 174;
            materialComboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxEstado.DropDownWidth = 121;
            materialComboBoxEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxEstado.FormattingEnabled = true;
            materialComboBoxEstado.Hint = "Estado";
            materialComboBoxEstado.IntegralHeight = false;
            materialComboBoxEstado.ItemHeight = 43;
            materialComboBoxEstado.Items.AddRange(new object[] { "", "AC", "AL", "AP", "AM", "BA", "CE", "ES", "GO", "DF", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            materialComboBoxEstado.Location = new Point(558, 222);
            materialComboBoxEstado.MaxDropDownItems = 4;
            materialComboBoxEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialComboBoxEstado.Name = "materialComboBoxEstado";
            materialComboBoxEstado.Size = new Size(208, 49);
            materialComboBoxEstado.StartIndex = 0;
            materialComboBoxEstado.TabIndex = 13;
            // 
            // materialMaskedTextBoxData
            // 
            materialMaskedTextBoxData.AllowPromptAsInput = true;
            materialMaskedTextBoxData.AnimateReadOnly = false;
            materialMaskedTextBoxData.AsciiOnly = false;
            materialMaskedTextBoxData.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBoxData.BeepOnError = false;
            materialMaskedTextBoxData.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBoxData.Depth = 0;
            materialMaskedTextBoxData.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBoxData.HidePromptOnLeave = false;
            materialMaskedTextBoxData.HideSelection = true;
            materialMaskedTextBoxData.Hint = "Data de Nascimento";
            materialMaskedTextBoxData.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBoxData.LeadingIcon = null;
            materialMaskedTextBoxData.Location = new Point(516, 6);
            materialMaskedTextBoxData.Mask = "_/_/_";
            materialMaskedTextBoxData.MaxLength = 32767;
            materialMaskedTextBoxData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBoxData.Name = "materialMaskedTextBoxData";
            materialMaskedTextBoxData.PasswordChar = '\0';
            materialMaskedTextBoxData.PrefixSuffixText = null;
            materialMaskedTextBoxData.PromptChar = '_';
            materialMaskedTextBoxData.ReadOnly = false;
            materialMaskedTextBoxData.RejectInputOnFirstFailure = false;
            materialMaskedTextBoxData.ResetOnPrompt = true;
            materialMaskedTextBoxData.ResetOnSpace = true;
            materialMaskedTextBoxData.RightToLeft = RightToLeft.No;
            materialMaskedTextBoxData.SelectedText = "";
            materialMaskedTextBoxData.SelectionLength = 0;
            materialMaskedTextBoxData.SelectionStart = 0;
            materialMaskedTextBoxData.ShortcutsEnabled = true;
            materialMaskedTextBoxData.Size = new Size(250, 48);
            materialMaskedTextBoxData.SkipLiterals = true;
            materialMaskedTextBoxData.TabIndex = 12;
            materialMaskedTextBoxData.TabStop = false;
            materialMaskedTextBoxData.Text = "_/_/_";
            materialMaskedTextBoxData.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBoxData.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBoxData.TrailingIcon = null;
            materialMaskedTextBoxData.UseSystemPasswordChar = false;
            materialMaskedTextBoxData.ValidatingType = null;
            // 
            // materialTextBoxSenha
            // 
            materialTextBoxSenha.AnimateReadOnly = false;
            materialTextBoxSenha.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxSenha.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxSenha.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxSenha.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxSenha.Depth = 0;
            materialTextBoxSenha.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxSenha.HideSelection = true;
            materialTextBoxSenha.Hint = "Senha";
            materialTextBoxSenha.LeadingIcon = Properties.Resources.baseline_fingerprint_black_24dp;
            materialTextBoxSenha.Location = new Point(6, 276);
            materialTextBoxSenha.MaxLength = 32767;
            materialTextBoxSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxSenha.Name = "materialTextBoxSenha";
            materialTextBoxSenha.PasswordChar = '\0';
            materialTextBoxSenha.PrefixSuffixText = null;
            materialTextBoxSenha.ReadOnly = false;
            materialTextBoxSenha.RightToLeft = RightToLeft.No;
            materialTextBoxSenha.SelectedText = "";
            materialTextBoxSenha.SelectionLength = 0;
            materialTextBoxSenha.SelectionStart = 0;
            materialTextBoxSenha.ShortcutsEnabled = true;
            materialTextBoxSenha.Size = new Size(760, 48);
            materialTextBoxSenha.TabIndex = 11;
            materialTextBoxSenha.TabStop = false;
            materialTextBoxSenha.TextAlign = HorizontalAlignment.Left;
            materialTextBoxSenha.TrailingIcon = null;
            materialTextBoxSenha.UseSystemPasswordChar = false;
            // 
            // materialTextBoxCidade
            // 
            materialTextBoxCidade.AnimateReadOnly = false;
            materialTextBoxCidade.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxCidade.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxCidade.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxCidade.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxCidade.Depth = 0;
            materialTextBoxCidade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxCidade.HideSelection = true;
            materialTextBoxCidade.Hint = "Cidade";
            materialTextBoxCidade.LeadingIcon = null;
            materialTextBoxCidade.Location = new Point(6, 222);
            materialTextBoxCidade.MaxLength = 32767;
            materialTextBoxCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxCidade.Name = "materialTextBoxCidade";
            materialTextBoxCidade.PasswordChar = '\0';
            materialTextBoxCidade.PrefixSuffixText = null;
            materialTextBoxCidade.ReadOnly = false;
            materialTextBoxCidade.RightToLeft = RightToLeft.No;
            materialTextBoxCidade.SelectedText = "";
            materialTextBoxCidade.SelectionLength = 0;
            materialTextBoxCidade.SelectionStart = 0;
            materialTextBoxCidade.ShortcutsEnabled = true;
            materialTextBoxCidade.Size = new Size(546, 48);
            materialTextBoxCidade.TabIndex = 10;
            materialTextBoxCidade.TabStop = false;
            materialTextBoxCidade.TextAlign = HorizontalAlignment.Left;
            materialTextBoxCidade.TrailingIcon = null;
            materialTextBoxCidade.UseSystemPasswordChar = false;
            // 
            // materialTextBoxBairro
            // 
            materialTextBoxBairro.AnimateReadOnly = false;
            materialTextBoxBairro.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxBairro.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxBairro.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxBairro.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxBairro.Depth = 0;
            materialTextBoxBairro.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxBairro.HideSelection = true;
            materialTextBoxBairro.Hint = "Bairro";
            materialTextBoxBairro.LeadingIcon = null;
            materialTextBoxBairro.Location = new Point(6, 168);
            materialTextBoxBairro.MaxLength = 32767;
            materialTextBoxBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxBairro.Name = "materialTextBoxBairro";
            materialTextBoxBairro.PasswordChar = '\0';
            materialTextBoxBairro.PrefixSuffixText = null;
            materialTextBoxBairro.ReadOnly = false;
            materialTextBoxBairro.RightToLeft = RightToLeft.No;
            materialTextBoxBairro.SelectedText = "";
            materialTextBoxBairro.SelectionLength = 0;
            materialTextBoxBairro.SelectionStart = 0;
            materialTextBoxBairro.ShortcutsEnabled = true;
            materialTextBoxBairro.Size = new Size(760, 48);
            materialTextBoxBairro.TabIndex = 9;
            materialTextBoxBairro.TabStop = false;
            materialTextBoxBairro.TextAlign = HorizontalAlignment.Left;
            materialTextBoxBairro.TrailingIcon = null;
            materialTextBoxBairro.UseSystemPasswordChar = false;
            // 
            // materialTextBoxEndereco
            // 
            materialTextBoxEndereco.AnimateReadOnly = false;
            materialTextBoxEndereco.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEndereco.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEndereco.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEndereco.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEndereco.Depth = 0;
            materialTextBoxEndereco.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEndereco.HideSelection = true;
            materialTextBoxEndereco.Hint = "Endereço";
            materialTextBoxEndereco.LeadingIcon = null;
            materialTextBoxEndereco.Location = new Point(6, 114);
            materialTextBoxEndereco.MaxLength = 32767;
            materialTextBoxEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEndereco.Name = "materialTextBoxEndereco";
            materialTextBoxEndereco.PasswordChar = '\0';
            materialTextBoxEndereco.PrefixSuffixText = null;
            materialTextBoxEndereco.ReadOnly = false;
            materialTextBoxEndereco.RightToLeft = RightToLeft.No;
            materialTextBoxEndereco.SelectedText = "";
            materialTextBoxEndereco.SelectionLength = 0;
            materialTextBoxEndereco.SelectionStart = 0;
            materialTextBoxEndereco.ShortcutsEnabled = true;
            materialTextBoxEndereco.Size = new Size(760, 48);
            materialTextBoxEndereco.TabIndex = 8;
            materialTextBoxEndereco.TabStop = false;
            materialTextBoxEndereco.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEndereco.TrailingIcon = null;
            materialTextBoxEndereco.UseSystemPasswordChar = false;
            // 
            // materialTextBoxNome
            // 
            materialTextBoxNome.AnimateReadOnly = false;
            materialTextBoxNome.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxNome.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxNome.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxNome.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxNome.Depth = 0;
            materialTextBoxNome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxNome.HideSelection = true;
            materialTextBoxNome.Hint = "Nome";
            materialTextBoxNome.LeadingIcon = null;
            materialTextBoxNome.Location = new Point(6, 60);
            materialTextBoxNome.MaxLength = 32767;
            materialTextBoxNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxNome.Name = "materialTextBoxNome";
            materialTextBoxNome.PasswordChar = '\0';
            materialTextBoxNome.PrefixSuffixText = null;
            materialTextBoxNome.ReadOnly = false;
            materialTextBoxNome.RightToLeft = RightToLeft.No;
            materialTextBoxNome.SelectedText = "";
            materialTextBoxNome.SelectionLength = 0;
            materialTextBoxNome.SelectionStart = 0;
            materialTextBoxNome.ShortcutsEnabled = true;
            materialTextBoxNome.Size = new Size(760, 48);
            materialTextBoxNome.TabIndex = 7;
            materialTextBoxNome.TabStop = false;
            materialTextBoxNome.TextAlign = HorizontalAlignment.Left;
            materialTextBoxNome.TrailingIcon = null;
            materialTextBoxNome.UseSystemPasswordChar = false;
            // 
            // materialTextBoxMatricula
            // 
            materialTextBoxMatricula.AnimateReadOnly = false;
            materialTextBoxMatricula.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxMatricula.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxMatricula.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxMatricula.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxMatricula.Depth = 0;
            materialTextBoxMatricula.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxMatricula.HideSelection = true;
            materialTextBoxMatricula.Hint = "Matrícula";
            materialTextBoxMatricula.LeadingIcon = null;
            materialTextBoxMatricula.Location = new Point(6, 6);
            materialTextBoxMatricula.MaxLength = 32767;
            materialTextBoxMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxMatricula.Name = "materialTextBoxMatricula";
            materialTextBoxMatricula.PasswordChar = '\0';
            materialTextBoxMatricula.PrefixSuffixText = null;
            materialTextBoxMatricula.ReadOnly = false;
            materialTextBoxMatricula.RightToLeft = RightToLeft.No;
            materialTextBoxMatricula.SelectedText = "";
            materialTextBoxMatricula.SelectionLength = 0;
            materialTextBoxMatricula.SelectionStart = 0;
            materialTextBoxMatricula.ShortcutsEnabled = true;
            materialTextBoxMatricula.Size = new Size(504, 48);
            materialTextBoxMatricula.TabIndex = 6;
            materialTextBoxMatricula.TabStop = false;
            materialTextBoxMatricula.TextAlign = HorizontalAlignment.Left;
            materialTextBoxMatricula.TrailingIcon = null;
            materialTextBoxMatricula.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(materialButtonExcluir);
            tabPageConsulta.Controls.Add(materialButtonEditar);
            tabPageConsulta.Controls.Add(materialButtonNovo);
            tabPageConsulta.Controls.Add(materialListView1);
            tabPageConsulta.ImageKey = "search.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(786, 400);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // materialButtonExcluir
            // 
            materialButtonExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonExcluir.Depth = 0;
            materialButtonExcluir.HighEmphasis = true;
            materialButtonExcluir.Icon = null;
            materialButtonExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButtonExcluir.Location = new Point(699, 354);
            materialButtonExcluir.Margin = new Padding(4, 6, 4, 6);
            materialButtonExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButtonExcluir.Name = "materialButtonExcluir";
            materialButtonExcluir.NoAccentTextColor = Color.Empty;
            materialButtonExcluir.Size = new Size(80, 36);
            materialButtonExcluir.TabIndex = 3;
            materialButtonExcluir.Text = "Excluir";
            materialButtonExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonExcluir.UseAccentColor = false;
            materialButtonExcluir.UseVisualStyleBackColor = true;
            // 
            // materialButtonEditar
            // 
            materialButtonEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonEditar.Depth = 0;
            materialButtonEditar.HighEmphasis = true;
            materialButtonEditar.Icon = null;
            materialButtonEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButtonEditar.Location = new Point(620, 354);
            materialButtonEditar.Margin = new Padding(4, 6, 4, 6);
            materialButtonEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButtonEditar.Name = "materialButtonEditar";
            materialButtonEditar.NoAccentTextColor = Color.Empty;
            materialButtonEditar.Size = new Size(71, 36);
            materialButtonEditar.TabIndex = 2;
            materialButtonEditar.Text = "Editar";
            materialButtonEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonEditar.UseAccentColor = false;
            materialButtonEditar.UseVisualStyleBackColor = true;
            // 
            // materialButtonNovo
            // 
            materialButtonNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonNovo.Depth = 0;
            materialButtonNovo.HighEmphasis = true;
            materialButtonNovo.Icon = null;
            materialButtonNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButtonNovo.Location = new Point(548, 354);
            materialButtonNovo.Margin = new Padding(4, 6, 4, 6);
            materialButtonNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButtonNovo.Name = "materialButtonNovo";
            materialButtonNovo.NoAccentTextColor = Color.Empty;
            materialButtonNovo.Size = new Size(64, 36);
            materialButtonNovo.TabIndex = 1;
            materialButtonNovo.Text = "Novo";
            materialButtonNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonNovo.UseAccentColor = false;
            materialButtonNovo.UseVisualStyleBackColor = true;
            materialButtonNovo.Click += materialButtonNovo_Click;
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Depth = 0;
            materialListView1.FullRowSelect = true;
            materialListView1.Location = new Point(6, 6);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new Size(774, 339);
            materialListView1.TabIndex = 0;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // FormAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(tabControlCadastro);
            DrawerTabControl = tabControlCadastro;
            MaximizeBox = false;
            Name = "FormAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Alunos";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tabControlCadastro;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBoxData;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxMatricula;
        private ReaLTaiizor.Controls.MaterialButton materialButtonSalvar;
        private ReaLTaiizor.Controls.MaterialButton materiaButtonCancelar;
        private ReaLTaiizor.Controls.MaterialComboBox materialComboBoxEstado;
        private ReaLTaiizor.Controls.MaterialListView materialListView1;
        private ReaLTaiizor.Controls.MaterialButton materialButtonExcluir;
        private ReaLTaiizor.Controls.MaterialButton materialButtonEditar;
        private ReaLTaiizor.Controls.MaterialButton materialButtonNovo;
    }
}