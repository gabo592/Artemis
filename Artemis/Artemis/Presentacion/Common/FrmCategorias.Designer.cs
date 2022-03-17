namespace Artemis.Presentacion.Common
{
    partial class FrmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.TableLayoutPanel();
            this.txtBuscar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnNuevaCategoria = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(913, 49);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Categorías";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.ColumnCount = 3;
            this.pnlTopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.68018F));
            this.pnlTopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.31982F));
            this.pnlTopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlTopBar.Controls.Add(this.txtBuscar, 0, 0);
            this.pnlTopBar.Controls.Add(this.btnNuevaCategoria, 1, 0);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 49);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.RowCount = 1;
            this.pnlTopBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlTopBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlTopBar.Size = new System.Drawing.Size(913, 46);
            this.pnlTopBar.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AcceptsReturn = false;
            this.txtBuscar.AcceptsTab = false;
            this.txtBuscar.AnimationSpeed = 200;
            this.txtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscar.AutoSizeHeight = true;
            this.txtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(157)))), ((int)(((byte)(85)))));
            this.txtBuscar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBuscar.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(157)))), ((int)(((byte)(85)))));
            this.txtBuscar.BorderColorIdle = System.Drawing.Color.Black;
            this.txtBuscar.BorderRadius = 15;
            this.txtBuscar.BorderThickness = 1;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscar.FillColor = System.Drawing.Color.Black;
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.HideSelection = true;
            this.txtBuscar.IconLeft = global::Artemis.Properties.Resources.search_free_icon_font;
            this.txtBuscar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.IconPadding = 10;
            this.txtBuscar.IconRight = null;
            this.txtBuscar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(3, 3);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBuscar.Modified = false;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(157)))), ((int)(((byte)(85)))));
            stateProperties1.FillColor = System.Drawing.Color.Black;
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBuscar.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(157)))), ((int)(((byte)(85)))));
            stateProperties3.FillColor = System.Drawing.Color.Black;
            stateProperties3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(157)))), ((int)(((byte)(85)))));
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(157)))), ((int)(((byte)(85)))));
            this.txtBuscar.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Black;
            stateProperties4.FillColor = System.Drawing.Color.Black;
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBuscar.OnIdleState = stateProperties4;
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBuscar.PlaceholderText = "Buscar";
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(751, 40);
            this.txtBuscar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.TextMarginBottom = 0;
            this.txtBuscar.TextMarginLeft = 8;
            this.txtBuscar.TextMarginTop = 1;
            this.txtBuscar.TextPlaceholder = "Buscar";
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.WordWrap = true;
            // 
            // btnNuevaCategoria
            // 
            this.btnNuevaCategoria.AllowAnimations = true;
            this.btnNuevaCategoria.AllowMouseEffects = true;
            this.btnNuevaCategoria.AllowToggling = false;
            this.btnNuevaCategoria.AnimationSpeed = 200;
            this.btnNuevaCategoria.AutoGenerateColors = false;
            this.btnNuevaCategoria.AutoRoundBorders = false;
            this.btnNuevaCategoria.AutoSizeLeftIcon = true;
            this.btnNuevaCategoria.AutoSizeRightIcon = true;
            this.btnNuevaCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevaCategoria.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnNuevaCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevaCategoria.BackgroundImage")));
            this.btnNuevaCategoria.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNuevaCategoria.ButtonText = "Nueva";
            this.btnNuevaCategoria.ButtonTextMarginLeft = 0;
            this.btnNuevaCategoria.ColorContrastOnClick = 45;
            this.btnNuevaCategoria.ColorContrastOnHover = 45;
            this.btnNuevaCategoria.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnNuevaCategoria.CustomizableEdges = borderEdges1;
            this.btnNuevaCategoria.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNuevaCategoria.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNuevaCategoria.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnNuevaCategoria.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnNuevaCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevaCategoria.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNuevaCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevaCategoria.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCategoria.IconLeft = global::Artemis.Properties.Resources.add_free_icon_font;
            this.btnNuevaCategoria.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaCategoria.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNuevaCategoria.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNuevaCategoria.IconMarginLeft = 11;
            this.btnNuevaCategoria.IconPadding = 10;
            this.btnNuevaCategoria.IconRight = null;
            this.btnNuevaCategoria.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaCategoria.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNuevaCategoria.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNuevaCategoria.IconSize = 25;
            this.btnNuevaCategoria.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnNuevaCategoria.IdleBorderRadius = 0;
            this.btnNuevaCategoria.IdleBorderThickness = 0;
            this.btnNuevaCategoria.IdleFillColor = System.Drawing.Color.Empty;
            this.btnNuevaCategoria.IdleIconLeftImage = global::Artemis.Properties.Resources.add_free_icon_font;
            this.btnNuevaCategoria.IdleIconRightImage = null;
            this.btnNuevaCategoria.IndicateFocus = false;
            this.btnNuevaCategoria.Location = new System.Drawing.Point(760, 3);
            this.btnNuevaCategoria.Name = "btnNuevaCategoria";
            this.btnNuevaCategoria.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNuevaCategoria.OnDisabledState.BorderRadius = 15;
            this.btnNuevaCategoria.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNuevaCategoria.OnDisabledState.BorderThickness = 1;
            this.btnNuevaCategoria.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNuevaCategoria.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNuevaCategoria.OnDisabledState.IconLeftImage = null;
            this.btnNuevaCategoria.OnDisabledState.IconRightImage = null;
            this.btnNuevaCategoria.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(157)))), ((int)(((byte)(85)))));
            this.btnNuevaCategoria.onHoverState.BorderRadius = 15;
            this.btnNuevaCategoria.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNuevaCategoria.onHoverState.BorderThickness = 1;
            this.btnNuevaCategoria.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(157)))), ((int)(((byte)(85)))));
            this.btnNuevaCategoria.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCategoria.onHoverState.IconLeftImage = null;
            this.btnNuevaCategoria.onHoverState.IconRightImage = null;
            this.btnNuevaCategoria.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnNuevaCategoria.OnIdleState.BorderRadius = 15;
            this.btnNuevaCategoria.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNuevaCategoria.OnIdleState.BorderThickness = 1;
            this.btnNuevaCategoria.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnNuevaCategoria.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCategoria.OnIdleState.IconLeftImage = global::Artemis.Properties.Resources.add_free_icon_font;
            this.btnNuevaCategoria.OnIdleState.IconRightImage = null;
            this.btnNuevaCategoria.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(157)))), ((int)(((byte)(85)))));
            this.btnNuevaCategoria.OnPressedState.BorderRadius = 15;
            this.btnNuevaCategoria.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNuevaCategoria.OnPressedState.BorderThickness = 1;
            this.btnNuevaCategoria.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btnNuevaCategoria.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCategoria.OnPressedState.IconLeftImage = null;
            this.btnNuevaCategoria.OnPressedState.IconRightImage = null;
            this.btnNuevaCategoria.Size = new System.Drawing.Size(141, 40);
            this.btnNuevaCategoria.TabIndex = 1;
            this.btnNuevaCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevaCategoria.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNuevaCategoria.TextMarginLeft = 0;
            this.btnNuevaCategoria.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNuevaCategoria.UseDefaultRadiusAndThickness = true;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.AutoScroll = true;
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 95);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(913, 396);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(913, 491);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategorias";
            this.pnlTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel pnlTopBar;
        private Bunifu.UI.WinForms.BunifuTextBox txtBuscar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNuevaCategoria;
        private System.Windows.Forms.FlowLayoutPanel pnlPrincipal;
    }
}