namespace Artemis.Presentacion.Common
{
    partial class EditarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCategoria));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.formBorderStyle = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlInfoCategoria = new System.Windows.Forms.TableLayoutPanel();
            this.pbCategoria = new System.Windows.Forms.PictureBox();
            this.txtNombreCategoria = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnGuardar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCerrar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlInfoCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // formBorderStyle
            // 
            this.formBorderStyle.ElipseRadius = 15;
            this.formBorderStyle.TargetControl = this;
            // 
            // pnlInfoCategoria
            // 
            this.pnlInfoCategoria.ColumnCount = 2;
            this.pnlInfoCategoria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlInfoCategoria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlInfoCategoria.Controls.Add(this.pbCategoria, 0, 1);
            this.pnlInfoCategoria.Controls.Add(this.txtNombreCategoria, 0, 3);
            this.pnlInfoCategoria.Controls.Add(this.btnGuardar, 1, 5);
            this.pnlInfoCategoria.Controls.Add(this.btnCerrar, 0, 5);
            this.pnlInfoCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfoCategoria.Location = new System.Drawing.Point(0, 0);
            this.pnlInfoCategoria.Name = "pnlInfoCategoria";
            this.pnlInfoCategoria.RowCount = 6;
            this.pnlInfoCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.3908F));
            this.pnlInfoCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.60919F));
            this.pnlInfoCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlInfoCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.pnlInfoCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.pnlInfoCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.pnlInfoCategoria.Size = new System.Drawing.Size(289, 230);
            this.pnlInfoCategoria.TabIndex = 3;
            // 
            // pbCategoria
            // 
            this.pnlInfoCategoria.SetColumnSpan(this.pbCategoria, 2);
            this.pbCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCategoria.Image = global::Artemis.Properties.Resources.picture;
            this.pbCategoria.Location = new System.Drawing.Point(3, 21);
            this.pbCategoria.Name = "pbCategoria";
            this.pbCategoria.Size = new System.Drawing.Size(283, 75);
            this.pbCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCategoria.TabIndex = 0;
            this.pbCategoria.TabStop = false;
            this.pbCategoria.Click += new System.EventHandler(this.PbCategoria_Click);
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.AcceptsReturn = false;
            this.txtNombreCategoria.AcceptsTab = false;
            this.txtNombreCategoria.AnimationSpeed = 200;
            this.txtNombreCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombreCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombreCategoria.AutoSizeHeight = true;
            this.txtNombreCategoria.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombreCategoria.BackgroundImage")));
            this.txtNombreCategoria.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.txtNombreCategoria.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNombreCategoria.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.txtNombreCategoria.BorderColorIdle = System.Drawing.Color.White;
            this.txtNombreCategoria.BorderRadius = 15;
            this.txtNombreCategoria.BorderThickness = 1;
            this.txtNombreCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pnlInfoCategoria.SetColumnSpan(this.txtNombreCategoria, 2);
            this.txtNombreCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCategoria.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCategoria.DefaultText = "";
            this.txtNombreCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreCategoria.FillColor = System.Drawing.Color.White;
            this.txtNombreCategoria.ForeColor = System.Drawing.Color.Black;
            this.txtNombreCategoria.HideSelection = true;
            this.txtNombreCategoria.IconLeft = null;
            this.txtNombreCategoria.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCategoria.IconPadding = 10;
            this.txtNombreCategoria.IconRight = null;
            this.txtNombreCategoria.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreCategoria.Lines = new string[0];
            this.txtNombreCategoria.Location = new System.Drawing.Point(3, 110);
            this.txtNombreCategoria.MaxLength = 32767;
            this.txtNombreCategoria.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNombreCategoria.Modified = false;
            this.txtNombreCategoria.Multiline = false;
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            stateProperties1.FillColor = System.Drawing.Color.White;
            stateProperties1.ForeColor = System.Drawing.Color.Black;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNombreCategoria.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombreCategoria.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            stateProperties3.FillColor = System.Drawing.Color.White;
            stateProperties3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.txtNombreCategoria.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNombreCategoria.OnIdleState = stateProperties4;
            this.txtNombreCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.txtNombreCategoria.PasswordChar = '\0';
            this.txtNombreCategoria.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNombreCategoria.PlaceholderText = "Nombre";
            this.txtNombreCategoria.ReadOnly = false;
            this.txtNombreCategoria.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreCategoria.SelectedText = "";
            this.txtNombreCategoria.SelectionLength = 0;
            this.txtNombreCategoria.SelectionStart = 0;
            this.txtNombreCategoria.ShortcutsEnabled = true;
            this.txtNombreCategoria.Size = new System.Drawing.Size(283, 36);
            this.txtNombreCategoria.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNombreCategoria.TabIndex = 1;
            this.txtNombreCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreCategoria.TextMarginBottom = 0;
            this.txtNombreCategoria.TextMarginLeft = 3;
            this.txtNombreCategoria.TextMarginTop = 1;
            this.txtNombreCategoria.TextPlaceholder = "Nombre";
            this.txtNombreCategoria.UseSystemPasswordChar = false;
            this.txtNombreCategoria.WordWrap = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AllowAnimations = true;
            this.btnGuardar.AllowMouseEffects = true;
            this.btnGuardar.AllowToggling = false;
            this.btnGuardar.AnimationSpeed = 200;
            this.btnGuardar.AutoGenerateColors = false;
            this.btnGuardar.AutoRoundBorders = false;
            this.btnGuardar.AutoSizeLeftIcon = true;
            this.btnGuardar.AutoSizeRightIcon = true;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.ButtonTextMarginLeft = 0;
            this.btnGuardar.ColorContrastOnClick = 45;
            this.btnGuardar.ColorContrastOnHover = 45;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnGuardar.CustomizableEdges = borderEdges1;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGuardar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnGuardar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconLeft = null;
            this.btnGuardar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnGuardar.IconMarginLeft = 11;
            this.btnGuardar.IconPadding = 10;
            this.btnGuardar.IconRight = null;
            this.btnGuardar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGuardar.IconSize = 25;
            this.btnGuardar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnGuardar.IdleBorderRadius = 0;
            this.btnGuardar.IdleBorderThickness = 0;
            this.btnGuardar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnGuardar.IdleIconLeftImage = null;
            this.btnGuardar.IdleIconRightImage = null;
            this.btnGuardar.IndicateFocus = false;
            this.btnGuardar.Location = new System.Drawing.Point(147, 189);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGuardar.OnDisabledState.BorderRadius = 15;
            this.btnGuardar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardar.OnDisabledState.BorderThickness = 1;
            this.btnGuardar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGuardar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGuardar.OnDisabledState.IconLeftImage = null;
            this.btnGuardar.OnDisabledState.IconRightImage = null;
            this.btnGuardar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.btnGuardar.onHoverState.BorderRadius = 15;
            this.btnGuardar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardar.onHoverState.BorderThickness = 1;
            this.btnGuardar.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnGuardar.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.onHoverState.IconLeftImage = null;
            this.btnGuardar.onHoverState.IconRightImage = null;
            this.btnGuardar.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.OnIdleState.BorderRadius = 15;
            this.btnGuardar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardar.OnIdleState.BorderThickness = 1;
            this.btnGuardar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.btnGuardar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnIdleState.IconLeftImage = null;
            this.btnGuardar.OnIdleState.IconRightImage = null;
            this.btnGuardar.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.OnPressedState.BorderRadius = 15;
            this.btnGuardar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGuardar.OnPressedState.BorderThickness = 1;
            this.btnGuardar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.btnGuardar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnPressedState.IconLeftImage = null;
            this.btnGuardar.OnPressedState.IconRightImage = null;
            this.btnGuardar.Size = new System.Drawing.Size(139, 38);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.TextMarginLeft = 0;
            this.btnGuardar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGuardar.UseDefaultRadiusAndThickness = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
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
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCerrar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
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
            this.btnCerrar.Location = new System.Drawing.Point(3, 189);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCerrar.OnDisabledState.BorderRadius = 15;
            this.btnCerrar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.OnDisabledState.BorderThickness = 1;
            this.btnCerrar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCerrar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCerrar.OnDisabledState.IconLeftImage = null;
            this.btnCerrar.OnDisabledState.IconRightImage = null;
            this.btnCerrar.onHoverState.BorderColor = System.Drawing.Color.White;
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
            this.btnCerrar.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnCerrar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.OnIdleState.IconLeftImage = null;
            this.btnCerrar.OnIdleState.IconRightImage = null;
            this.btnCerrar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.btnCerrar.OnPressedState.BorderRadius = 15;
            this.btnCerrar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCerrar.OnPressedState.BorderThickness = 1;
            this.btnCerrar.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnCerrar.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.OnPressedState.IconLeftImage = null;
            this.btnCerrar.OnPressedState.IconRightImage = null;
            this.btnCerrar.Size = new System.Drawing.Size(138, 38);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCerrar.TextMarginLeft = 0;
            this.btnCerrar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCerrar.UseDefaultRadiusAndThickness = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmEditarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 230);
            this.Controls.Add(this.pnlInfoCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Categoria";
            this.Load += new System.EventHandler(this.FrmEditarCategoria_Load);
            this.pnlInfoCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse formBorderStyle;
        private System.Windows.Forms.TableLayoutPanel pnlInfoCategoria;
        private System.Windows.Forms.PictureBox pbCategoria;
        private Bunifu.UI.WinForms.BunifuTextBox txtNombreCategoria;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGuardar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCerrar;
    }
}