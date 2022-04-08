namespace Artemis.Presentacion.Shop
{
    partial class EditorProveedores
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorProveedores));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.formBorderStyle = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLimpiar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCancelar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlDatosProveedor = new System.Windows.Forms.TableLayoutPanel();
            this.txtNombre = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtTelefono = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblDirección = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.pnlBotones.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.pnlDatosProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // formBorderStyle
            // 
            this.formBorderStyle.ElipseRadius = 15;
            this.formBorderStyle.TargetControl = this;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(692, 52);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Editar Proveedor";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Controls.Add(this.btnLimpiar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlBotones.Location = new System.Drawing.Point(0, 276);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(692, 51);
            this.pnlBotones.TabIndex = 1;
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
            this.btnGuardar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnGuardar.Location = new System.Drawing.Point(539, 3);
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
            this.btnGuardar.Size = new System.Drawing.Size(150, 39);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.TextMarginLeft = 0;
            this.btnGuardar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGuardar.UseDefaultRadiusAndThickness = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AllowAnimations = true;
            this.btnLimpiar.AllowMouseEffects = true;
            this.btnLimpiar.AllowToggling = false;
            this.btnLimpiar.AnimationSpeed = 200;
            this.btnLimpiar.AutoGenerateColors = false;
            this.btnLimpiar.AutoRoundBorders = false;
            this.btnLimpiar.AutoSizeLeftIcon = true;
            this.btnLimpiar.AutoSizeRightIcon = true;
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLimpiar.ButtonText = "Limpiar";
            this.btnLimpiar.ButtonTextMarginLeft = 0;
            this.btnLimpiar.ColorContrastOnClick = 45;
            this.btnLimpiar.ColorContrastOnHover = 45;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnLimpiar.CustomizableEdges = borderEdges2;
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLimpiar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnLimpiar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnLimpiar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconLeft = null;
            this.btnLimpiar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpiar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLimpiar.IconMarginLeft = 11;
            this.btnLimpiar.IconPadding = 10;
            this.btnLimpiar.IconRight = null;
            this.btnLimpiar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpiar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLimpiar.IconSize = 25;
            this.btnLimpiar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnLimpiar.IdleBorderRadius = 0;
            this.btnLimpiar.IdleBorderThickness = 0;
            this.btnLimpiar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnLimpiar.IdleIconLeftImage = null;
            this.btnLimpiar.IdleIconRightImage = null;
            this.btnLimpiar.IndicateFocus = false;
            this.btnLimpiar.Location = new System.Drawing.Point(383, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLimpiar.OnDisabledState.BorderRadius = 15;
            this.btnLimpiar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLimpiar.OnDisabledState.BorderThickness = 1;
            this.btnLimpiar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLimpiar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLimpiar.OnDisabledState.IconLeftImage = null;
            this.btnLimpiar.OnDisabledState.IconRightImage = null;
            this.btnLimpiar.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnLimpiar.onHoverState.BorderRadius = 15;
            this.btnLimpiar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLimpiar.onHoverState.BorderThickness = 1;
            this.btnLimpiar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.btnLimpiar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.onHoverState.IconLeftImage = null;
            this.btnLimpiar.onHoverState.IconRightImage = null;
            this.btnLimpiar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.btnLimpiar.OnIdleState.BorderRadius = 15;
            this.btnLimpiar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLimpiar.OnIdleState.BorderThickness = 1;
            this.btnLimpiar.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnLimpiar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.OnIdleState.IconLeftImage = null;
            this.btnLimpiar.OnIdleState.IconRightImage = null;
            this.btnLimpiar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.btnLimpiar.OnPressedState.BorderRadius = 15;
            this.btnLimpiar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLimpiar.OnPressedState.BorderThickness = 1;
            this.btnLimpiar.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnLimpiar.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.OnPressedState.IconLeftImage = null;
            this.btnLimpiar.OnPressedState.IconRightImage = null;
            this.btnLimpiar.Size = new System.Drawing.Size(150, 39);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpiar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLimpiar.TextMarginLeft = 0;
            this.btnLimpiar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLimpiar.UseDefaultRadiusAndThickness = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AllowAnimations = true;
            this.btnCancelar.AllowMouseEffects = true;
            this.btnCancelar.AllowToggling = false;
            this.btnCancelar.AnimationSpeed = 200;
            this.btnCancelar.AutoGenerateColors = false;
            this.btnCancelar.AutoRoundBorders = false;
            this.btnCancelar.AutoSizeLeftIcon = true;
            this.btnCancelar.AutoSizeRightIcon = true;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.ButtonTextMarginLeft = 0;
            this.btnCancelar.ColorContrastOnClick = 45;
            this.btnCancelar.ColorContrastOnHover = 45;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnCancelar.CustomizableEdges = borderEdges3;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnCancelar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnCancelar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.IconLeft = null;
            this.btnCancelar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancelar.IconMarginLeft = 11;
            this.btnCancelar.IconPadding = 10;
            this.btnCancelar.IconRight = null;
            this.btnCancelar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnCancelar.IdleBorderRadius = 0;
            this.btnCancelar.IdleBorderThickness = 0;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnCancelar.IdleIconLeftImage = null;
            this.btnCancelar.IdleIconRightImage = null;
            this.btnCancelar.IndicateFocus = false;
            this.btnCancelar.Location = new System.Drawing.Point(227, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelar.OnDisabledState.BorderRadius = 15;
            this.btnCancelar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnDisabledState.BorderThickness = 1;
            this.btnCancelar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancelar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancelar.OnDisabledState.IconLeftImage = null;
            this.btnCancelar.OnDisabledState.IconRightImage = null;
            this.btnCancelar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.btnCancelar.onHoverState.BorderRadius = 15;
            this.btnCancelar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.onHoverState.BorderThickness = 1;
            this.btnCancelar.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnCancelar.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.onHoverState.IconLeftImage = null;
            this.btnCancelar.onHoverState.IconRightImage = null;
            this.btnCancelar.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.OnIdleState.BorderRadius = 15;
            this.btnCancelar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnIdleState.BorderThickness = 1;
            this.btnCancelar.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnCancelar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.OnIdleState.IconLeftImage = null;
            this.btnCancelar.OnIdleState.IconRightImage = null;
            this.btnCancelar.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.OnPressedState.BorderRadius = 15;
            this.btnCancelar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnPressedState.BorderThickness = 1;
            this.btnCancelar.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnCancelar.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.OnPressedState.IconLeftImage = null;
            this.btnCancelar.OnPressedState.IconRightImage = null;
            this.btnCancelar.Size = new System.Drawing.Size(150, 39);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.TextMarginLeft = 0;
            this.btnCancelar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancelar.UseDefaultRadiusAndThickness = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.AutoScroll = true;
            this.pnlPrincipal.Controls.Add(this.pnlDatosProveedor);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 52);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(692, 224);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // pnlDatosProveedor
            // 
            this.pnlDatosProveedor.ColumnCount = 4;
            this.pnlDatosProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.631579F));
            this.pnlDatosProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.36842F));
            this.pnlDatosProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 331F));
            this.pnlDatosProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.pnlDatosProveedor.Controls.Add(this.txtNombre, 1, 0);
            this.pnlDatosProveedor.Controls.Add(this.txtTelefono, 2, 0);
            this.pnlDatosProveedor.Controls.Add(this.lblDirección, 1, 1);
            this.pnlDatosProveedor.Controls.Add(this.txtDireccion, 1, 2);
            this.pnlDatosProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatosProveedor.Location = new System.Drawing.Point(0, 0);
            this.pnlDatosProveedor.Name = "pnlDatosProveedor";
            this.pnlDatosProveedor.RowCount = 3;
            this.pnlDatosProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlDatosProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlDatosProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.pnlDatosProveedor.Size = new System.Drawing.Size(692, 196);
            this.pnlDatosProveedor.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsReturn = false;
            this.txtNombre.AcceptsTab = false;
            this.txtNombre.AnimationSpeed = 200;
            this.txtNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombre.AutoSizeHeight = true;
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombre.BackgroundImage")));
            this.txtNombre.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.txtNombre.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNombre.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.txtNombre.BorderColorIdle = System.Drawing.Color.White;
            this.txtNombre.BorderRadius = 15;
            this.txtNombre.BorderThickness = 1;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.DefaultText = "";
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.FillColor = System.Drawing.Color.White;
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.HideSelection = true;
            this.txtNombre.IconLeft = null;
            this.txtNombre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.IconPadding = 10;
            this.txtNombre.IconRight = null;
            this.txtNombre.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(12, 3);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNombre.Modified = false;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            stateProperties1.FillColor = System.Drawing.Color.White;
            stateProperties1.ForeColor = System.Drawing.Color.Black;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNombre.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombre.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            stateProperties3.FillColor = System.Drawing.Color.White;
            stateProperties3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.txtNombre.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNombre.OnIdleState = stateProperties4;
            this.txtNombre.Padding = new System.Windows.Forms.Padding(3);
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.ReadOnly = false;
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(330, 46);
            this.txtNombre.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TextMarginBottom = 0;
            this.txtNombre.TextMarginLeft = 3;
            this.txtNombre.TextMarginTop = 1;
            this.txtNombre.TextPlaceholder = "Nombre";
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.WordWrap = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AcceptsReturn = false;
            this.txtTelefono.AcceptsTab = false;
            this.txtTelefono.AnimationSpeed = 200;
            this.txtTelefono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTelefono.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTelefono.AutoSizeHeight = true;
            this.txtTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTelefono.BackgroundImage")));
            this.txtTelefono.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.txtTelefono.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTelefono.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.txtTelefono.BorderColorIdle = System.Drawing.Color.White;
            this.txtTelefono.BorderRadius = 15;
            this.txtTelefono.BorderThickness = 1;
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.DefaultText = "";
            this.txtTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTelefono.FillColor = System.Drawing.Color.White;
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.HideSelection = true;
            this.txtTelefono.IconLeft = null;
            this.txtTelefono.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.IconPadding = 10;
            this.txtTelefono.IconRight = null;
            this.txtTelefono.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Lines = new string[0];
            this.txtTelefono.Location = new System.Drawing.Point(348, 3);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTelefono.Modified = false;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            stateProperties5.FillColor = System.Drawing.Color.White;
            stateProperties5.ForeColor = System.Drawing.Color.Black;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTelefono.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            stateProperties7.FillColor = System.Drawing.Color.White;
            stateProperties7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(114)))));
            this.txtTelefono.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.White;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTelefono.OnIdleState = stateProperties8;
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(3);
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTelefono.PlaceholderText = "Teléfono";
            this.txtTelefono.ReadOnly = false;
            this.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.ShortcutsEnabled = true;
            this.txtTelefono.Size = new System.Drawing.Size(325, 46);
            this.txtTelefono.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTelefono.TabIndex = 1;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.TextMarginBottom = 0;
            this.txtTelefono.TextMarginLeft = 3;
            this.txtTelefono.TextMarginTop = 1;
            this.txtTelefono.TextPlaceholder = "Teléfono";
            this.txtTelefono.UseSystemPasswordChar = false;
            this.txtTelefono.WordWrap = true;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // lblDirección
            // 
            this.pnlDatosProveedor.SetColumnSpan(this.lblDirección, 2);
            this.lblDirección.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDirección.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirección.Location = new System.Drawing.Point(12, 52);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(661, 52);
            this.lblDirección.TabIndex = 2;
            this.lblDirección.Text = "Dirección";
            this.lblDirección.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDireccion
            // 
            this.pnlDatosProveedor.SetColumnSpan(this.txtDireccion, 2);
            this.txtDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(12, 107);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDireccion.Size = new System.Drawing.Size(661, 86);
            this.txtDireccion.TabIndex = 3;
            // 
            // EditorProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 327);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditorProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Proveedores";
            this.pnlBotones.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlDatosProveedor.ResumeLayout(false);
            this.pnlDatosProveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse formBorderStyle;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.TableLayoutPanel pnlDatosProveedor;
        private Bunifu.UI.WinForms.BunifuTextBox txtNombre;
        private Bunifu.UI.WinForms.BunifuTextBox txtTelefono;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.FlowLayoutPanel pnlBotones;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGuardar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLimpiar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancelar;
    }
}