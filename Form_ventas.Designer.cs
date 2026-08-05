namespace Nk_Colletion_New
{
    partial class Form_ventas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            lbl_usuario = new Label();
            btn_ayuda = new Button();
            txt_categoria = new TextBox();
            lblFecha = new Label();
            cmb_nombre_cliente = new ComboBox();
            btn_cancelar = new Button();
            lbl_porc_descuento = new Label();
            btn_agregar = new Button();
            txt_porc_descuento = new TextBox();
            txt_precio = new TextBox();
            txt_cantidad_producto = new TextBox();
            txt_codigo = new TextBox();
            cmb_producto = new ComboBox();
            lbl_categoria = new Label();
            lbl_precio = new Label();
            lbl_cantidad_producto = new Label();
            lbl_codigo = new Label();
            label9 = new Label();
            txt_direccion = new TextBox();
            lbl_direccion = new Label();
            label7 = new Label();
            txt_cedula = new TextBox();
            txt_telefono = new TextBox();
            btn_agregar_cliente = new Button();
            lbl_nombre_cliente = new Label();
            lbl_cedula = new Label();
            lbl_telefono = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            lbl_cambioF = new Label();
            lbl_totalF = new Label();
            lbl_descuentoF = new Label();
            lbl_subtotalF = new Label();
            button4 = new Button();
            txt_interes = new TextBox();
            lbl_interes = new Label();
            date_credito = new DateTimePicker();
            txtnumerodereferencia = new TextBox();
            txtcantidadT = new TextBox();
            lbl_cantidad = new Label();
            lbl_numero_referencia = new Label();
            txt_efectivo_dolares = new TextBox();
            txt_efectivo_cordobas = new TextBox();
            lbl_efectivo_dolares = new Label();
            lbl_efectivo_cordobas = new Label();
            rdb_Efectivo = new RadioButton();
            rdb_Credito = new RadioButton();
            rdb_Tarjeta = new RadioButton();
            lbl_descuento = new Label();
            lbl_total = new Label();
            lbl_cambio = new Label();
            lbl_subtotal = new Label();
            dtgw_ventas = new DataGridView();
            Clm_producto = new DataGridViewTextBoxColumn();
            Clm_Cantidad = new DataGridViewTextBoxColumn();
            Clm_Precio = new DataGridViewTextBoxColumn();
            Clm_IVA = new DataGridViewTextBoxColumn();
            Clm_Descuento = new DataGridViewTextBoxColumn();
            Clm_Subtotal = new DataGridViewTextBoxColumn();
            Clm_Editar = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgw_ventas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 26);
            panel1.TabIndex = 152;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 0, 0);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(26, 798);
            panel3.TabIndex = 154;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 0);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1345, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(26, 798);
            panel2.TabIndex = 155;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 0, 0);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(26, 798);
            panel4.Name = "panel4";
            panel4.Size = new Size(1319, 26);
            panel4.TabIndex = 156;
            // 
            // lbl_usuario
            // 
            lbl_usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_usuario.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_usuario.Location = new Point(1046, 51);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(67, 20);
            lbl_usuario.TabIndex = 210;
            lbl_usuario.Text = "Usuario";
            // 
            // btn_ayuda
            // 
            btn_ayuda.ImageIndex = 0;
            btn_ayuda.Location = new Point(1294, 115);
            btn_ayuda.Name = "btn_ayuda";
            btn_ayuda.Size = new Size(47, 43);
            btn_ayuda.TabIndex = 209;
            btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // txt_categoria
            // 
            txt_categoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_categoria.Location = new Point(481, 278);
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(183, 31);
            txt_categoria.TabIndex = 208;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.FromArgb(64, 0, 0);
            lblFecha.Location = new Point(1143, 51);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 20);
            lblFecha.TabIndex = 207;
            lblFecha.Text = "Fecha:";
            // 
            // cmb_nombre_cliente
            // 
            cmb_nombre_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmb_nombre_cliente.Items.AddRange(new object[] { "Ariana Gaitán" });
            cmb_nombre_cliente.Location = new Point(47, 158);
            cmb_nombre_cliente.Name = "cmb_nombre_cliente";
            cmb_nombre_cliente.Size = new Size(233, 33);
            cmb_nombre_cliente.TabIndex = 206;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Maroon;
            btn_cancelar.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelar.ForeColor = SystemColors.ControlLightLight;
            btn_cancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cancelar.ImageIndex = 2;
            btn_cancelar.Location = new Point(174, 321);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(113, 41);
            btn_cancelar.TabIndex = 205;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // lbl_porc_descuento
            // 
            lbl_porc_descuento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_porc_descuento.AutoSize = true;
            lbl_porc_descuento.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_porc_descuento.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_porc_descuento.Location = new Point(1031, 248);
            lbl_porc_descuento.Name = "lbl_porc_descuento";
            lbl_porc_descuento.Size = new Size(91, 20);
            lbl_porc_descuento.TabIndex = 204;
            lbl_porc_descuento.Text = "Descuento:";
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.Maroon;
            btn_agregar.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.ForeColor = SystemColors.ControlLightLight;
            btn_agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregar.ImageIndex = 1;
            btn_agregar.Location = new Point(47, 321);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(113, 41);
            btn_agregar.TabIndex = 202;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            // 
            // txt_porc_descuento
            // 
            txt_porc_descuento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_porc_descuento.Location = new Point(1031, 274);
            txt_porc_descuento.Name = "txt_porc_descuento";
            txt_porc_descuento.Size = new Size(124, 31);
            txt_porc_descuento.TabIndex = 201;
            // 
            // txt_precio
            // 
            txt_precio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_precio.Location = new Point(683, 276);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(135, 31);
            txt_precio.TabIndex = 200;
            // 
            // txt_cantidad_producto
            // 
            txt_cantidad_producto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_cantidad_producto.Location = new Point(852, 274);
            txt_cantidad_producto.Name = "txt_cantidad_producto";
            txt_cantidad_producto.Size = new Size(165, 31);
            txt_cantidad_producto.TabIndex = 199;
            // 
            // txt_codigo
            // 
            txt_codigo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_codigo.Location = new Point(301, 278);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(165, 31);
            txt_codigo.TabIndex = 198;
            // 
            // cmb_producto
            // 
            cmb_producto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmb_producto.Items.AddRange(new object[] { "Camisa Polo", "Pantalón Jeans", "Zapatos Deportivos", "Vestido Casual", "Chaqueta de Cuero", "Blusa Elegante", "Falda Plisada", "Suéter de Lana", "Traje de Baño", "Accesorios de Moda" });
            cmb_producto.Location = new Point(47, 278);
            cmb_producto.Name = "cmb_producto";
            cmb_producto.Size = new Size(233, 33);
            cmb_producto.TabIndex = 203;
            // 
            // lbl_categoria
            // 
            lbl_categoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_categoria.AutoSize = true;
            lbl_categoria.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_categoria.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_categoria.Location = new Point(493, 248);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(86, 20);
            lbl_categoria.TabIndex = 197;
            lbl_categoria.Text = "Categoría:";
            // 
            // lbl_precio
            // 
            lbl_precio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_precio.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_precio.Location = new Point(683, 248);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(60, 20);
            lbl_precio.TabIndex = 196;
            lbl_precio.Text = "Precio:";
            // 
            // lbl_cantidad_producto
            // 
            lbl_cantidad_producto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_cantidad_producto.AutoSize = true;
            lbl_cantidad_producto.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_cantidad_producto.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_cantidad_producto.Location = new Point(852, 248);
            lbl_cantidad_producto.Name = "lbl_cantidad_producto";
            lbl_cantidad_producto.Size = new Size(80, 20);
            lbl_cantidad_producto.TabIndex = 195;
            lbl_cantidad_producto.Text = "Cantidad:";
            // 
            // lbl_codigo
            // 
            lbl_codigo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_codigo.AutoSize = true;
            lbl_codigo.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_codigo.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_codigo.Location = new Point(301, 248);
            lbl_codigo.Name = "lbl_codigo";
            lbl_codigo.Size = new Size(68, 20);
            lbl_codigo.TabIndex = 194;
            lbl_codigo.Text = "Código:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(64, 0, 0);
            label9.Location = new Point(47, 248);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 193;
            label9.Text = "Producto:";
            // 
            // txt_direccion
            // 
            txt_direccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_direccion.Location = new Point(732, 156);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(320, 31);
            txt_direccion.TabIndex = 192;
            // 
            // lbl_direccion
            // 
            lbl_direccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_direccion.AutoSize = true;
            lbl_direccion.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_direccion.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_direccion.Location = new Point(732, 133);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(86, 20);
            lbl_direccion.TabIndex = 191;
            lbl_direccion.Text = "Dirección:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("PMingLiU-ExtB", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(47, 207);
            label7.Name = "label7";
            label7.Size = new Size(192, 22);
            label7.TabIndex = 190;
            label7.Text = "Datos del producto:";
            // 
            // txt_cedula
            // 
            txt_cedula.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_cedula.Location = new Point(304, 156);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(219, 31);
            txt_cedula.TabIndex = 189;
            // 
            // txt_telefono
            // 
            txt_telefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_telefono.Location = new Point(544, 158);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(151, 31);
            txt_telefono.TabIndex = 188;
            // 
            // btn_agregar_cliente
            // 
            btn_agregar_cliente.BackColor = Color.Maroon;
            btn_agregar_cliente.Font = new Font("PMingLiU-ExtB", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar_cliente.ForeColor = SystemColors.ControlLightLight;
            btn_agregar_cliente.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregar_cliente.ImageIndex = 0;
            btn_agregar_cliente.Location = new Point(1058, 153);
            btn_agregar_cliente.Name = "btn_agregar_cliente";
            btn_agregar_cliente.Size = new Size(97, 36);
            btn_agregar_cliente.TabIndex = 187;
            btn_agregar_cliente.Text = "Cliente";
            btn_agregar_cliente.UseVisualStyleBackColor = false;
            // 
            // lbl_nombre_cliente
            // 
            lbl_nombre_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_nombre_cliente.AutoSize = true;
            lbl_nombre_cliente.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_nombre_cliente.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_nombre_cliente.Location = new Point(47, 135);
            lbl_nombre_cliente.Name = "lbl_nombre_cliente";
            lbl_nombre_cliente.Size = new Size(155, 20);
            lbl_nombre_cliente.TabIndex = 186;
            lbl_nombre_cliente.Text = "Nombre del cliente:";
            // 
            // lbl_cedula
            // 
            lbl_cedula.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_cedula.AutoSize = true;
            lbl_cedula.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_cedula.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_cedula.Location = new Point(313, 133);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(67, 20);
            lbl_cedula.TabIndex = 185;
            lbl_cedula.Text = "Cédula:";
            // 
            // lbl_telefono
            // 
            lbl_telefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_telefono.AutoSize = true;
            lbl_telefono.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_telefono.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_telefono.Location = new Point(544, 135);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(80, 20);
            lbl_telefono.TabIndex = 184;
            lbl_telefono.Text = "Teléfono:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(47, 96);
            label1.Name = "label1";
            label1.Size = new Size(179, 22);
            label1.TabIndex = 183;
            label1.Text = "Datos del Cliente:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(1255, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 182;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(47, 39);
            label5.Name = "label5";
            label5.Size = new Size(251, 32);
            label5.TabIndex = 181;
            label5.Text = "Gestión de Ventas";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(39, 51);
            label6.Name = "label6";
            label6.Size = new Size(1198, 32);
            label6.TabIndex = 180;
            label6.Text = "__________________________________________________________________________";
            // 
            // lbl_cambioF
            // 
            lbl_cambioF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_cambioF.AutoSize = true;
            lbl_cambioF.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_cambioF.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_cambioF.Location = new Point(1177, 610);
            lbl_cambioF.Name = "lbl_cambioF";
            lbl_cambioF.Size = new Size(50, 20);
            lbl_cambioF.TabIndex = 234;
            lbl_cambioF.Text = "00.00";
            // 
            // lbl_totalF
            // 
            lbl_totalF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_totalF.AutoSize = true;
            lbl_totalF.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_totalF.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_totalF.Location = new Point(1177, 546);
            lbl_totalF.Name = "lbl_totalF";
            lbl_totalF.Size = new Size(50, 20);
            lbl_totalF.TabIndex = 233;
            lbl_totalF.Text = "00.00";
            // 
            // lbl_descuentoF
            // 
            lbl_descuentoF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_descuentoF.AutoSize = true;
            lbl_descuentoF.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_descuentoF.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_descuentoF.Location = new Point(1175, 483);
            lbl_descuentoF.Name = "lbl_descuentoF";
            lbl_descuentoF.Size = new Size(50, 20);
            lbl_descuentoF.TabIndex = 232;
            lbl_descuentoF.Text = "00.00";
            // 
            // lbl_subtotalF
            // 
            lbl_subtotalF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_subtotalF.AutoSize = true;
            lbl_subtotalF.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_subtotalF.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_subtotalF.Location = new Point(1175, 423);
            lbl_subtotalF.Name = "lbl_subtotalF";
            lbl_subtotalF.Size = new Size(50, 20);
            lbl_subtotalF.TabIndex = 231;
            lbl_subtotalF.Text = "00.00";
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.ImageIndex = 3;
            button4.Location = new Point(1195, 741);
            button4.Name = "button4";
            button4.Size = new Size(129, 41);
            button4.TabIndex = 230;
            button4.Text = "Registrar";
            button4.UseVisualStyleBackColor = false;
            // 
            // txt_interes
            // 
            txt_interes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txt_interes.Location = new Point(874, 714);
            txt_interes.Name = "txt_interes";
            txt_interes.Size = new Size(109, 31);
            txt_interes.TabIndex = 229;
            // 
            // lbl_interes
            // 
            lbl_interes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_interes.AutoSize = true;
            lbl_interes.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_interes.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_interes.Location = new Point(804, 718);
            lbl_interes.Name = "lbl_interes";
            lbl_interes.Size = new Size(64, 20);
            lbl_interes.TabIndex = 228;
            lbl_interes.Text = "Interés:";
            // 
            // date_credito
            // 
            date_credito.Location = new Point(481, 718);
            date_credito.Name = "date_credito";
            date_credito.Size = new Size(300, 31);
            date_credito.TabIndex = 227;
            // 
            // txtnumerodereferencia
            // 
            txtnumerodereferencia.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtnumerodereferencia.Location = new Point(271, 755);
            txtnumerodereferencia.Name = "txtnumerodereferencia";
            txtnumerodereferencia.Size = new Size(204, 31);
            txtnumerodereferencia.TabIndex = 226;
            // 
            // txtcantidadT
            // 
            txtcantidadT.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtcantidadT.Location = new Point(567, 755);
            txtcantidadT.Name = "txtcantidadT";
            txtcantidadT.Size = new Size(109, 31);
            txtcantidadT.TabIndex = 225;
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_cantidad.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_cantidad.Location = new Point(481, 762);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(80, 20);
            lbl_cantidad.TabIndex = 224;
            lbl_cantidad.Text = "Cantidad:";
            // 
            // lbl_numero_referencia
            // 
            lbl_numero_referencia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_numero_referencia.AutoSize = true;
            lbl_numero_referencia.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_numero_referencia.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_numero_referencia.Location = new Point(90, 762);
            lbl_numero_referencia.Name = "lbl_numero_referencia";
            lbl_numero_referencia.Size = new Size(175, 20);
            lbl_numero_referencia.TabIndex = 223;
            lbl_numero_referencia.Text = "Número de referencia:";
            // 
            // txt_efectivo_dolares
            // 
            txt_efectivo_dolares.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txt_efectivo_dolares.Location = new Point(1046, 751);
            txt_efectivo_dolares.Name = "txt_efectivo_dolares";
            txt_efectivo_dolares.Size = new Size(109, 31);
            txt_efectivo_dolares.TabIndex = 222;
            // 
            // txt_efectivo_cordobas
            // 
            txt_efectivo_cordobas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txt_efectivo_cordobas.Location = new Point(836, 751);
            txt_efectivo_cordobas.Name = "txt_efectivo_cordobas";
            txt_efectivo_cordobas.Size = new Size(109, 31);
            txt_efectivo_cordobas.TabIndex = 221;
            // 
            // lbl_efectivo_dolares
            // 
            lbl_efectivo_dolares.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_efectivo_dolares.AutoSize = true;
            lbl_efectivo_dolares.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_efectivo_dolares.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_efectivo_dolares.Location = new Point(951, 762);
            lbl_efectivo_dolares.Name = "lbl_efectivo_dolares";
            lbl_efectivo_dolares.Size = new Size(89, 20);
            lbl_efectivo_dolares.TabIndex = 220;
            lbl_efectivo_dolares.Text = "Efectivo $:";
            // 
            // lbl_efectivo_cordobas
            // 
            lbl_efectivo_cordobas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_efectivo_cordobas.AutoSize = true;
            lbl_efectivo_cordobas.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_efectivo_cordobas.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_efectivo_cordobas.Location = new Point(732, 762);
            lbl_efectivo_cordobas.Name = "lbl_efectivo_cordobas";
            lbl_efectivo_cordobas.Size = new Size(102, 20);
            lbl_efectivo_cordobas.TabIndex = 219;
            lbl_efectivo_cordobas.Text = "Efectivo C$:";
            // 
            // rdb_Efectivo
            // 
            rdb_Efectivo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rdb_Efectivo.AutoSize = true;
            rdb_Efectivo.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdb_Efectivo.ForeColor = Color.FromArgb(64, 0, 0);
            rdb_Efectivo.Location = new Point(291, 709);
            rdb_Efectivo.Name = "rdb_Efectivo";
            rdb_Efectivo.Size = new Size(99, 22);
            rdb_Efectivo.TabIndex = 218;
            rdb_Efectivo.TabStop = true;
            rdb_Efectivo.Text = "Efectivo";
            rdb_Efectivo.UseVisualStyleBackColor = true;
            // 
            // rdb_Credito
            // 
            rdb_Credito.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rdb_Credito.AutoSize = true;
            rdb_Credito.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdb_Credito.ForeColor = Color.FromArgb(64, 0, 0);
            rdb_Credito.Location = new Point(174, 709);
            rdb_Credito.Name = "rdb_Credito";
            rdb_Credito.Size = new Size(91, 22);
            rdb_Credito.TabIndex = 217;
            rdb_Credito.TabStop = true;
            rdb_Credito.Text = "Crédito";
            rdb_Credito.UseVisualStyleBackColor = true;
            // 
            // rdb_Tarjeta
            // 
            rdb_Tarjeta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rdb_Tarjeta.AutoSize = true;
            rdb_Tarjeta.Font = new Font("PMingLiU-ExtB", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdb_Tarjeta.ForeColor = Color.FromArgb(64, 0, 0);
            rdb_Tarjeta.Location = new Point(47, 709);
            rdb_Tarjeta.Name = "rdb_Tarjeta";
            rdb_Tarjeta.Size = new Size(90, 22);
            rdb_Tarjeta.TabIndex = 216;
            rdb_Tarjeta.TabStop = true;
            rdb_Tarjeta.Text = "Tarjeta";
            rdb_Tarjeta.UseVisualStyleBackColor = true;
            // 
            // lbl_descuento
            // 
            lbl_descuento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_descuento.AutoSize = true;
            lbl_descuento.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Bold | FontStyle.Italic);
            lbl_descuento.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_descuento.Location = new Point(1173, 454);
            lbl_descuento.Name = "lbl_descuento";
            lbl_descuento.Size = new Size(95, 20);
            lbl_descuento.TabIndex = 215;
            lbl_descuento.Text = "Descuento";
            // 
            // lbl_total
            // 
            lbl_total.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_total.AutoSize = true;
            lbl_total.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Bold | FontStyle.Italic);
            lbl_total.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_total.Location = new Point(1175, 515);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(52, 20);
            lbl_total.TabIndex = 214;
            lbl_total.Text = "Total";
            // 
            // lbl_cambio
            // 
            lbl_cambio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_cambio.AutoSize = true;
            lbl_cambio.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Bold | FontStyle.Italic);
            lbl_cambio.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_cambio.Location = new Point(1176, 578);
            lbl_cambio.Name = "lbl_cambio";
            lbl_cambio.Size = new Size(74, 20);
            lbl_cambio.TabIndex = 213;
            lbl_cambio.Text = "Cambio";
            // 
            // lbl_subtotal
            // 
            lbl_subtotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_subtotal.AutoSize = true;
            lbl_subtotal.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Bold | FontStyle.Italic);
            lbl_subtotal.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_subtotal.Location = new Point(1173, 393);
            lbl_subtotal.Name = "lbl_subtotal";
            lbl_subtotal.Size = new Size(77, 20);
            lbl_subtotal.TabIndex = 212;
            lbl_subtotal.Text = "Subtotal";
            // 
            // dtgw_ventas
            // 
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dtgw_ventas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgw_ventas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgw_ventas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgw_ventas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgw_ventas.BackgroundColor = SystemColors.InactiveBorder;
            dtgw_ventas.BorderStyle = BorderStyle.None;
            dtgw_ventas.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dtgw_ventas.ColumnHeadersHeight = 33;
            dtgw_ventas.Columns.AddRange(new DataGridViewColumn[] { Clm_producto, Clm_Cantidad, Clm_Precio, Clm_IVA, Clm_Descuento, Clm_Subtotal, Clm_Editar });
            dtgw_ventas.Cursor = Cursors.Hand;
            dtgw_ventas.Location = new Point(47, 368);
            dtgw_ventas.Name = "dtgw_ventas";
            dtgw_ventas.RowHeadersWidth = 62;
            dtgw_ventas.Size = new Size(1108, 315);
            dtgw_ventas.TabIndex = 211;
            // 
            // Clm_producto
            // 
            Clm_producto.HeaderText = "Producto";
            Clm_producto.MinimumWidth = 8;
            Clm_producto.Name = "Clm_producto";
            // 
            // Clm_Cantidad
            // 
            Clm_Cantidad.HeaderText = "Cantidad";
            Clm_Cantidad.MinimumWidth = 8;
            Clm_Cantidad.Name = "Clm_Cantidad";
            // 
            // Clm_Precio
            // 
            Clm_Precio.HeaderText = "Precio ";
            Clm_Precio.MinimumWidth = 8;
            Clm_Precio.Name = "Clm_Precio";
            // 
            // Clm_IVA
            // 
            Clm_IVA.HeaderText = "IVA";
            Clm_IVA.MinimumWidth = 8;
            Clm_IVA.Name = "Clm_IVA";
            // 
            // Clm_Descuento
            // 
            Clm_Descuento.HeaderText = "Descuento";
            Clm_Descuento.MinimumWidth = 8;
            Clm_Descuento.Name = "Clm_Descuento";
            // 
            // Clm_Subtotal
            // 
            Clm_Subtotal.HeaderText = "Subtotal";
            Clm_Subtotal.MinimumWidth = 8;
            Clm_Subtotal.Name = "Clm_Subtotal";
            // 
            // Clm_Editar
            // 
            Clm_Editar.HeaderText = "Editar";
            Clm_Editar.MinimumWidth = 8;
            Clm_Editar.Name = "Clm_Editar";
            // 
            // Form_ventas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 824);
            Controls.Add(lbl_cambioF);
            Controls.Add(lbl_totalF);
            Controls.Add(lbl_descuentoF);
            Controls.Add(lbl_subtotalF);
            Controls.Add(button4);
            Controls.Add(txt_interes);
            Controls.Add(lbl_interes);
            Controls.Add(date_credito);
            Controls.Add(txtnumerodereferencia);
            Controls.Add(txtcantidadT);
            Controls.Add(lbl_cantidad);
            Controls.Add(lbl_numero_referencia);
            Controls.Add(txt_efectivo_dolares);
            Controls.Add(txt_efectivo_cordobas);
            Controls.Add(lbl_efectivo_dolares);
            Controls.Add(lbl_efectivo_cordobas);
            Controls.Add(rdb_Efectivo);
            Controls.Add(rdb_Credito);
            Controls.Add(rdb_Tarjeta);
            Controls.Add(lbl_descuento);
            Controls.Add(lbl_total);
            Controls.Add(lbl_cambio);
            Controls.Add(lbl_subtotal);
            Controls.Add(dtgw_ventas);
            Controls.Add(lbl_usuario);
            Controls.Add(btn_ayuda);
            Controls.Add(txt_categoria);
            Controls.Add(lblFecha);
            Controls.Add(cmb_nombre_cliente);
            Controls.Add(btn_cancelar);
            Controls.Add(lbl_porc_descuento);
            Controls.Add(btn_agregar);
            Controls.Add(txt_porc_descuento);
            Controls.Add(txt_precio);
            Controls.Add(txt_cantidad_producto);
            Controls.Add(txt_codigo);
            Controls.Add(cmb_producto);
            Controls.Add(lbl_categoria);
            Controls.Add(lbl_precio);
            Controls.Add(lbl_cantidad_producto);
            Controls.Add(lbl_codigo);
            Controls.Add(label9);
            Controls.Add(txt_direccion);
            Controls.Add(lbl_direccion);
            Controls.Add(label7);
            Controls.Add(txt_cedula);
            Controls.Add(txt_telefono);
            Controls.Add(btn_agregar_cliente);
            Controls.Add(lbl_nombre_cliente);
            Controls.Add(lbl_cedula);
            Controls.Add(lbl_telefono);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_ventas";
            Text = "Form_ventas";
            Load += Form_ventas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgw_ventas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Label lbl_usuario;
        private Button btn_ayuda;
        private TextBox txt_categoria;
        private Label lblFecha;
        private ComboBox cmb_nombre_cliente;
        private Button btn_cancelar;
        private Label lbl_porc_descuento;
        private Button btn_agregar;
        private TextBox txt_porc_descuento;
        private TextBox txt_precio;
        private TextBox txt_cantidad_producto;
        private TextBox txt_codigo;
        private ComboBox cmb_producto;
        private Label lbl_categoria;
        private Label lbl_precio;
        private Label lbl_cantidad_producto;
        private Label lbl_codigo;
        private Label label9;
        private TextBox txt_direccion;
        private Label lbl_direccion;
        private Label label7;
        private TextBox txt_cedula;
        private TextBox txt_telefono;
        private Button btn_agregar_cliente;
        private Label lbl_nombre_cliente;
        private Label lbl_cedula;
        private Label lbl_telefono;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label lbl_cambioF;
        private Label lbl_totalF;
        private Label lbl_descuentoF;
        private Label lbl_subtotalF;
        private Button button4;
        private TextBox txt_interes;
        private Label lbl_interes;
        private DateTimePicker date_credito;
        private TextBox txtnumerodereferencia;
        private TextBox txtcantidadT;
        private Label lbl_cantidad;
        private Label lbl_numero_referencia;
        private TextBox txt_efectivo_dolares;
        private TextBox txt_efectivo_cordobas;
        private Label lbl_efectivo_dolares;
        private Label lbl_efectivo_cordobas;
        private RadioButton rdb_Efectivo;
        private RadioButton rdb_Credito;
        private RadioButton rdb_Tarjeta;
        private Label lbl_descuento;
        private Label lbl_total;
        private Label lbl_cambio;
        private Label lbl_subtotal;
        private DataGridView dtgw_ventas;
        private DataGridViewTextBoxColumn Clm_producto;
        private DataGridViewTextBoxColumn Clm_Cantidad;
        private DataGridViewTextBoxColumn Clm_Precio;
        private DataGridViewTextBoxColumn Clm_IVA;
        private DataGridViewTextBoxColumn Clm_Descuento;
        private DataGridViewTextBoxColumn Clm_Subtotal;
        private DataGridViewTextBoxColumn Clm_Editar;
    }
}