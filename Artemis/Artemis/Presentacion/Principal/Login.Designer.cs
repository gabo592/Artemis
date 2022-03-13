namespace Artemis.Presentacion.Principal
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.formBorderStyle = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlDatos = new System.Windows.Forms.TableLayoutPanel();
            this.txtUsuario = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtContraseña = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pbContraseña = new System.Windows.Forms.PictureBox();
            this.pnlBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIniciarSesion = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCerrar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::Artemis.Properties.Resources.artemis_perfil;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(362, 158);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // formBorderStyle
            // 
            this.formBorderStyle.ElipseRadius = 20;
            this.formBorderStyle.TargetControl = this;
            // 
            // pnlDatos
            // 
            this.pnlDatos.ColumnCount = 3;
            this.pnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.78471F));
            this.pnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.215298F));
            this.pnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlDatos.Controls.Add(this.txtUsuario, 0, 1);
            this.pnlDatos.Controls.Add(this.txtContraseña, 0, 2);
            this.pnlDatos.Controls.Add(this.pbContraseña, 1, 2);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatos.Location = new System.Drawing.Point(0, 158);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.RowCount = 3;
            this.pnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.14286F));
            this.pnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.85714F));
            this.pnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.pnlDatos.Size = new System.Drawing.Size(362, 118);
            this.pnlDatos.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AcceptsReturn = false;
            this.txtUsuario.AcceptsTab = false;
            this.txtUsuario.AnimationSpeed = 200;
            this.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsuario.AutoSizeHeight = true;
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUsuario.BackgroundImage")));
            this.txtUsuario.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.txtUsuario.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsuario.BorderColorHover = System.Drawing.Color.Black;
            this.txtUsuario.BorderColorIdle = System.Drawing.Color.Black;
            this.txtUsuario.BorderRadius = 15;
            this.txtUsuario.BorderThickness = 1;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsuario.FillColor = System.Drawing.Color.Black;
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.HideSelection = true;
            this.txtUsuario.IconLeft = global::Artemis.Properties.Resources.user_free_icon_font;
            this.txtUsuario.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.IconPadding = 14;
            this.txtUsuario.IconRight = null;
            this.txtUsuario.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(3, 14);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUsuario.Modified = false;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            stateProperties1.FillColor = System.Drawing.Color.Black;
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtUsuario.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Black;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtUsuario.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Black;
            stateProperties4.FillColor = System.Drawing.Color.Black;
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.OnIdleState = stateProperties4;
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtUsuario.PlaceholderText = "Nombre de usuario";
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(317, 48);
            this.txtUsuario.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.TextMarginBottom = 0;
            this.txtUsuario.TextMarginLeft = 3;
            this.txtUsuario.TextMarginTop = 1;
            this.txtUsuario.TextPlaceholder = "Nombre de usuario";
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.WordWrap = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.AcceptsReturn = false;
            this.txtContraseña.AcceptsTab = false;
            this.txtContraseña.AnimationSpeed = 200;
            this.txtContraseña.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtContraseña.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtContraseña.AutoSizeHeight = true;
            this.txtContraseña.BackColor = System.Drawing.Color.Transparent;
            this.txtContraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtContraseña.BackgroundImage")));
            this.txtContraseña.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.txtContraseña.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtContraseña.BorderColorHover = System.Drawing.Color.Black;
            this.txtContraseña.BorderColorIdle = System.Drawing.Color.Black;
            this.txtContraseña.BorderRadius = 15;
            this.txtContraseña.BorderThickness = 1;
            this.txtContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.DefaultFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.DefaultText = "";
            this.txtContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContraseña.FillColor = System.Drawing.Color.Black;
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.HideSelection = true;
            this.txtContraseña.IconLeft = global::Artemis.Properties.Resources.lock_free_icon_font;
            this.txtContraseña.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.IconPadding = 14;
            this.txtContraseña.IconRight = null;
            this.txtContraseña.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.Lines = new string[0];
            this.txtContraseña.Location = new System.Drawing.Point(3, 68);
            this.txtContraseña.MaxLength = 32767;
            this.txtContraseña.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtContraseña.Modified = false;
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            stateProperties5.FillColor = System.Drawing.Color.Black;
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtContraseña.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtContraseña.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.Black;
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            stateProperties7.ForeColor = System.Drawing.Color.White;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtContraseña.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Black;
            stateProperties8.FillColor = System.Drawing.Color.Black;
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtContraseña.OnIdleState = stateProperties8;
            this.txtContraseña.Padding = new System.Windows.Forms.Padding(3);
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtContraseña.PlaceholderText = "Contraseña";
            this.txtContraseña.ReadOnly = false;
            this.txtContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.SelectionLength = 0;
            this.txtContraseña.SelectionStart = 0;
            this.txtContraseña.ShortcutsEnabled = true;
            this.txtContraseña.Size = new System.Drawing.Size(317, 47);
            this.txtContraseña.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContraseña.TextMarginBottom = 0;
            this.txtContraseña.TextMarginLeft = 3;
            this.txtContraseña.TextMarginTop = 1;
            this.txtContraseña.TextPlaceholder = "Contraseña";
            this.txtContraseña.UseSystemPasswordChar = false;
            this.txtContraseña.WordWrap = true;
            // 
            // pbContraseña
            // 
            this.pbContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbContraseña.Image = global::Artemis.Properties.Resources.eye_free_icon_font;
            this.pbContraseña.Location = new System.Drawing.Point(326, 68);
            this.pbContraseña.Name = "pbContraseña";
            this.pbContraseña.Size = new System.Drawing.Size(22, 47);
            this.pbContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbContraseña.TabIndex = 2;
            this.pbContraseña.TabStop = false;
            this.pbContraseña.Click += new System.EventHandler(this.PbContraseña_Click);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnIniciarSesion);
            this.pnlBotones.Controls.Add(this.btnCerrar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlBotones.Location = new System.Drawing.Point(0, 320);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(362, 53);
            this.pnlBotones.TabIndex = 3;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.AllowAnimations = true;
            this.btnIniciarSesion.AllowMouseEffects = true;
            this.btnIniciarSesion.AllowToggling = false;
            this.btnIniciarSesion.AnimationSpeed = 200;
            this.btnIniciarSesion.AutoGenerateColors = false;
            this.btnIniciarSesion.AutoRoundBorders = false;
            this.btnIniciarSesion.AutoSizeLeftIcon = true;
            this.btnIniciarSesion.AutoSizeRightIcon = true;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnIniciarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciarSesion.BackgroundImage")));
            this.btnIniciarSesion.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIniciarSesion.ButtonText = "Iniciar Sesión";
            this.btnIniciarSesion.ButtonTextMarginLeft = 0;
            this.btnIniciarSesion.ColorContrastOnClick = 45;
            this.btnIniciarSesion.ColorContrastOnHover = 45;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnIniciarSesion.CustomizableEdges = borderEdges1;
            this.btnIniciarSesion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIniciarSesion.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnIniciarSesion.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnIniciarSesion.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnIniciarSesion.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.IconLeft = null;
            this.btnIniciarSesion.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarSesion.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnIniciarSesion.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnIniciarSesion.IconMarginLeft = 11;
            this.btnIniciarSesion.IconPadding = 10;
            this.btnIniciarSesion.IconRight = null;
            this.btnIniciarSesion.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciarSesion.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnIniciarSesion.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnIniciarSesion.IconSize = 25;
            this.btnIniciarSesion.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnIniciarSesion.IdleBorderRadius = 0;
            this.btnIniciarSesion.IdleBorderThickness = 0;
            this.btnIniciarSesion.IdleFillColor = System.Drawing.Color.Empty;
            this.btnIniciarSesion.IdleIconLeftImage = null;
            this.btnIniciarSesion.IdleIconRightImage = null;
            this.btnIniciarSesion.IndicateFocus = false;
            this.btnIniciarSesion.Location = new System.Drawing.Point(225, 3);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnIniciarSesion.OnDisabledState.BorderRadius = 15;
            this.btnIniciarSesion.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIniciarSesion.OnDisabledState.BorderThickness = 1;
            this.btnIniciarSesion.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnIniciarSesion.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnIniciarSesion.OnDisabledState.IconLeftImage = null;
            this.btnIniciarSesion.OnDisabledState.IconRightImage = null;
            this.btnIniciarSesion.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.btnIniciarSesion.onHoverState.BorderRadius = 15;
            this.btnIniciarSesion.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIniciarSesion.onHoverState.BorderThickness = 1;
            this.btnIniciarSesion.onHoverState.FillColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.onHoverState.IconLeftImage = null;
            this.btnIniciarSesion.onHoverState.IconRightImage = null;
            this.btnIniciarSesion.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.OnIdleState.BorderRadius = 15;
            this.btnIniciarSesion.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIniciarSesion.OnIdleState.BorderThickness = 1;
            this.btnIniciarSesion.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.btnIniciarSesion.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.OnIdleState.IconLeftImage = null;
            this.btnIniciarSesion.OnIdleState.IconRightImage = null;
            this.btnIniciarSesion.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.OnPressedState.BorderRadius = 15;
            this.btnIniciarSesion.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIniciarSesion.OnPressedState.BorderThickness = 1;
            this.btnIniciarSesion.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.btnIniciarSesion.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.OnPressedState.IconLeftImage = null;
            this.btnIniciarSesion.OnPressedState.IconRightImage = null;
            this.btnIniciarSesion.Size = new System.Drawing.Size(134, 39);
            this.btnIniciarSesion.TabIndex = 0;
            this.btnIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIniciarSesion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIniciarSesion.TextMarginLeft = 0;
            this.btnIniciarSesion.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnIniciarSesion.UseDefaultRadiusAndThickness = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.AllowAnimations = true;
            this.btnCerrar.AllowMouseEffects = true;
            this.btnCerrar.AllowToggling = false;
            this.btnCerrar.AnimationSpeed = 200;
            this.btnCerrar.AutoGenerateColors = false;
            this.btnCerrar.AutoRoundBorders = false;
            this.btnCerrar.AutoSizeLeftIcon = true;
            this.btnCerrar.AutoSizeRightIcon = true;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.ButtonText = "Cerrar";
            this.btnCerrar.ButtonTextMarginLeft = 0;
            this.btnCerrar.ColorContrastOnClick = 45;
            this.btnCerrar.ColorContrastOnHover = 45;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCerrar.CustomizableEdges = borderEdges2;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCerrar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnCerrar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnCerrar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.IconLeft = null;
            this.btnCerrar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCerrar.IconMarginLeft = 11;
            this.btnCerrar.IconPadding = 10;
            this.btnCerrar.IconRight = null;
            this.btnCerrar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnCerrar.IdleBorderRadius = 0;
            this.btnCerrar.IdleBorderThickness = 0;
            this.btnCerrar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnCerrar.IdleIconLeftImage = null;
            this.btnCerrar.IdleIconRightImage = null;
            this.btnCerrar.IndicateFocus = false;
            this.btnCerrar.Location = new System.Drawing.Point(85, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCerrar.OnDisabledState.BorderRadius = 15;
            this.btnCerrar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.OnDisabledState.BorderThickness = 1;
            this.btnCerrar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCerrar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCerrar.OnDisabledState.IconLeftImage = null;
            this.btnCerrar.OnDisabledState.IconRightImage = null;
            this.btnCerrar.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.btnCerrar.onHoverState.BorderRadius = 15;
            this.btnCerrar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.onHoverState.BorderThickness = 1;
            this.btnCerrar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.btnCerrar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.onHoverState.IconLeftImage = null;
            this.btnCerrar.onHoverState.IconRightImage = null;
            this.btnCerrar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.btnCerrar.OnIdleState.BorderRadius = 15;
            this.btnCerrar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.OnIdleState.BorderThickness = 1;
            this.btnCerrar.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnCerrar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnIdleState.IconLeftImage = null;
            this.btnCerrar.OnIdleState.IconRightImage = null;
            this.btnCerrar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.btnCerrar.OnPressedState.BorderRadius = 15;
            this.btnCerrar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.OnPressedState.BorderThickness = 1;
            this.btnCerrar.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btnCerrar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnPressedState.IconLeftImage = null;
            this.btnCerrar.OnPressedState.IconRightImage = null;
            this.btnCerrar.Size = new System.Drawing.Size(134, 39);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCerrar.TextMarginLeft = 0;
            this.btnCerrar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCerrar.UseDefaultRadiusAndThickness = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(362, 373);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogo;
        private Bunifu.Framework.UI.BunifuElipse formBorderStyle;
        private System.Windows.Forms.TableLayoutPanel pnlDatos;
        private Bunifu.UI.WinForms.BunifuTextBox txtUsuario;
        private Bunifu.UI.WinForms.BunifuTextBox txtContraseña;
        private System.Windows.Forms.PictureBox pbContraseña;
        private System.Windows.Forms.FlowLayoutPanel pnlBotones;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnIniciarSesion;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCerrar;
    }
}