namespace Nk_Colletion_New
{
    partial class Form_devoluciones
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
            btn_ayuda = new Button();
            groupBoxdatagrid = new GroupBox();
            textBox1 = new TextBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label4 = new Label();
            dataGridViewdevo = new DataGridView();
            columnaproducto = new DataGridViewTextBoxColumn();
            cantvendida = new DataGridViewTextBoxColumn();
            cantdevolver = new DataGridViewTextBoxColumn();
            motivo = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            groupBoxnuevoproducto = new GroupBox();
            dataGridViewnuevoproducto = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            groupBoxtipodevolucion = new GroupBox();
            btncambio = new RadioButton();
            btnreembolso = new RadioButton();
            btnimprimir = new Button();
            btnvalidar = new Button();
            groupBoxdatos = new GroupBox();
            btnbuscarventa = new Button();
            label3 = new Label();
            txtcliente = new TextBox();
            label2 = new Label();
            txtfactura = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            groupBoxdatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewdevo).BeginInit();
            groupBoxnuevoproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewnuevoproducto).BeginInit();
            groupBoxtipodevolucion.SuspendLayout();
            groupBoxdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_ayuda
            // 
            btn_ayuda.ImageIndex = 0;
            btn_ayuda.Location = new Point(1206, 72);
            btn_ayuda.Name = "btn_ayuda";
            btn_ayuda.Size = new Size(47, 43);
            btn_ayuda.TabIndex = 185;
            btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // groupBoxdatagrid
            // 
            groupBoxdatagrid.BackColor = Color.SeaShell;
            groupBoxdatagrid.Controls.Add(textBox1);
            groupBoxdatagrid.Controls.Add(label8);
            groupBoxdatagrid.Controls.Add(comboBox1);
            groupBoxdatagrid.Controls.Add(textBox3);
            groupBoxdatagrid.Controls.Add(label7);
            groupBoxdatagrid.Controls.Add(label4);
            groupBoxdatagrid.Controls.Add(dataGridViewdevo);
            groupBoxdatagrid.Location = new Point(39, 243);
            groupBoxdatagrid.Name = "groupBoxdatagrid";
            groupBoxdatagrid.Size = new Size(1295, 217);
            groupBoxdatagrid.TabIndex = 184;
            groupBoxdatagrid.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 31);
            textBox1.TabIndex = 98;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 83);
            label8.Name = "label8";
            label8.Size = new Size(135, 25);
            label8.TabIndex = 97;
            label8.Text = "Cantidad a dev:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(9, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 96;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(9, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 31);
            textBox3.TabIndex = 95;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 152);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 94;
            label7.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 19);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 92;
            label4.Text = "Motivo:";
            // 
            // dataGridViewdevo
            // 
            dataGridViewdevo.BackgroundColor = Color.SeaShell;
            dataGridViewdevo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewdevo.Columns.AddRange(new DataGridViewColumn[] { columnaproducto, cantvendida, cantdevolver, motivo, estado });
            dataGridViewdevo.Location = new Point(208, 30);
            dataGridViewdevo.Name = "dataGridViewdevo";
            dataGridViewdevo.RowHeadersWidth = 62;
            dataGridViewdevo.Size = new Size(816, 116);
            dataGridViewdevo.TabIndex = 0;
            // 
            // columnaproducto
            // 
            columnaproducto.HeaderText = "Producto";
            columnaproducto.MinimumWidth = 8;
            columnaproducto.Name = "columnaproducto";
            columnaproducto.Width = 150;
            // 
            // cantvendida
            // 
            cantvendida.HeaderText = "Cant.Vendida";
            cantvendida.MinimumWidth = 8;
            cantvendida.Name = "cantvendida";
            cantvendida.Width = 150;
            // 
            // cantdevolver
            // 
            cantdevolver.HeaderText = "Cant.Devolver";
            cantdevolver.MinimumWidth = 8;
            cantdevolver.Name = "cantdevolver";
            cantdevolver.Width = 150;
            // 
            // motivo
            // 
            motivo.HeaderText = "Motivo";
            motivo.MinimumWidth = 8;
            motivo.Name = "motivo";
            motivo.Width = 150;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 8;
            estado.Name = "estado";
            estado.Width = 150;
            // 
            // groupBoxnuevoproducto
            // 
            groupBoxnuevoproducto.BackColor = Color.SeaShell;
            groupBoxnuevoproducto.Controls.Add(dataGridViewnuevoproducto);
            groupBoxnuevoproducto.Location = new Point(39, 549);
            groupBoxnuevoproducto.Name = "groupBoxnuevoproducto";
            groupBoxnuevoproducto.Size = new Size(1295, 162);
            groupBoxnuevoproducto.TabIndex = 183;
            groupBoxnuevoproducto.TabStop = false;
            groupBoxnuevoproducto.Text = "Nuevo Producto";
            // 
            // dataGridViewnuevoproducto
            // 
            dataGridViewnuevoproducto.BackgroundColor = Color.SeaShell;
            dataGridViewnuevoproducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewnuevoproducto.Columns.AddRange(new DataGridViewColumn[] { codigo, producto, cantidad, precio, total });
            dataGridViewnuevoproducto.Location = new Point(27, 30);
            dataGridViewnuevoproducto.Name = "dataGridViewnuevoproducto";
            dataGridViewnuevoproducto.RowHeadersWidth = 62;
            dataGridViewnuevoproducto.Size = new Size(816, 109);
            dataGridViewnuevoproducto.TabIndex = 0;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.MinimumWidth = 8;
            codigo.Name = "codigo";
            codigo.Width = 150;
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 8;
            producto.Name = "producto";
            producto.Width = 150;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 8;
            cantidad.Name = "cantidad";
            cantidad.Width = 150;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 8;
            precio.Name = "precio";
            precio.Width = 150;
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.MinimumWidth = 8;
            total.Name = "total";
            total.Width = 150;
            // 
            // groupBoxtipodevolucion
            // 
            groupBoxtipodevolucion.BackColor = Color.SeaShell;
            groupBoxtipodevolucion.Controls.Add(btncambio);
            groupBoxtipodevolucion.Controls.Add(btnreembolso);
            groupBoxtipodevolucion.Location = new Point(39, 466);
            groupBoxtipodevolucion.Name = "groupBoxtipodevolucion";
            groupBoxtipodevolucion.Size = new Size(1300, 77);
            groupBoxtipodevolucion.TabIndex = 182;
            groupBoxtipodevolucion.TabStop = false;
            groupBoxtipodevolucion.Text = "Tipo de Devolución";
            // 
            // btncambio
            // 
            btncambio.AutoSize = true;
            btncambio.Location = new Point(236, 30);
            btncambio.Name = "btncambio";
            btncambio.Size = new Size(203, 29);
            btncambio.TabIndex = 99;
            btncambio.TabStop = true;
            btncambio.Text = "Cambio de producto";
            btncambio.UseVisualStyleBackColor = true;
            // 
            // btnreembolso
            // 
            btnreembolso.AutoSize = true;
            btnreembolso.Location = new Point(38, 30);
            btnreembolso.Name = "btnreembolso";
            btnreembolso.Size = new Size(126, 29);
            btnreembolso.TabIndex = 98;
            btnreembolso.TabStop = true;
            btnreembolso.Text = "Reembolso";
            btnreembolso.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            btnimprimir.BackColor = Color.Maroon;
            btnimprimir.ForeColor = SystemColors.ControlLightLight;
            btnimprimir.Location = new Point(1119, 742);
            btnimprimir.Name = "btnimprimir";
            btnimprimir.Size = new Size(215, 34);
            btnimprimir.TabIndex = 181;
            btnimprimir.Text = "Imprimir Comprobante";
            btnimprimir.UseVisualStyleBackColor = false;
            // 
            // btnvalidar
            // 
            btnvalidar.BackColor = Color.Maroon;
            btnvalidar.ForeColor = SystemColors.ControlLightLight;
            btnvalidar.Location = new Point(909, 742);
            btnvalidar.Name = "btnvalidar";
            btnvalidar.Size = new Size(184, 34);
            btnvalidar.TabIndex = 180;
            btnvalidar.Text = "Guardar";
            btnvalidar.UseVisualStyleBackColor = false;
            // 
            // groupBoxdatos
            // 
            groupBoxdatos.BackColor = Color.SeaShell;
            groupBoxdatos.Controls.Add(btnbuscarventa);
            groupBoxdatos.Controls.Add(label3);
            groupBoxdatos.Controls.Add(txtcliente);
            groupBoxdatos.Controls.Add(label2);
            groupBoxdatos.Controls.Add(txtfactura);
            groupBoxdatos.Controls.Add(label1);
            groupBoxdatos.Location = new Point(39, 121);
            groupBoxdatos.Name = "groupBoxdatos";
            groupBoxdatos.Size = new Size(1295, 116);
            groupBoxdatos.TabIndex = 179;
            groupBoxdatos.TabStop = false;
            // 
            // btnbuscarventa
            // 
            btnbuscarventa.BackColor = Color.Maroon;
            btnbuscarventa.ForeColor = SystemColors.ControlLightLight;
            btnbuscarventa.Location = new Point(278, 30);
            btnbuscarventa.Name = "btnbuscarventa";
            btnbuscarventa.Size = new Size(156, 34);
            btnbuscarventa.TabIndex = 86;
            btnbuscarventa.Text = "Buscar Venta";
            btnbuscarventa.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 72);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 84;
            label3.Text = "Fecha Venta:";
            // 
            // txtcliente
            // 
            txtcliente.Location = new Point(114, 66);
            txtcliente.Name = "txtcliente";
            txtcliente.Size = new Size(150, 31);
            txtcliente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 69);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 2;
            label2.Text = "Cliente:";
            // 
            // txtfactura
            // 
            txtfactura.Location = new Point(114, 30);
            txtfactura.Name = "txtfactura";
            txtfactura.Size = new Size(150, 31);
            txtfactura.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 27);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "No.Factura:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(1259, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 178;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(26, 51);
            label5.Name = "label5";
            label5.Size = new Size(402, 32);
            label5.TabIndex = 177;
            label5.Text = "Gestión de Devolución ventas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(32, 74);
            label6.Name = "label6";
            label6.Size = new Size(1166, 32);
            label6.TabIndex = 176;
            label6.Text = "________________________________________________________________________";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 26);
            panel1.TabIndex = 186;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 0);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1345, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(26, 798);
            panel2.TabIndex = 187;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 0, 0);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(26, 798);
            panel3.TabIndex = 188;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 0, 0);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(26, 798);
            panel4.Name = "panel4";
            panel4.Size = new Size(1319, 26);
            panel4.TabIndex = 189;
            // 
            // Form_devoluciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 824);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_ayuda);
            Controls.Add(groupBoxdatagrid);
            Controls.Add(groupBoxnuevoproducto);
            Controls.Add(groupBoxtipodevolucion);
            Controls.Add(btnimprimir);
            Controls.Add(btnvalidar);
            Controls.Add(groupBoxdatos);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_devoluciones";
            Text = "Form_devoluciones";
            Load += Form_devoluciones_Load;
            groupBoxdatagrid.ResumeLayout(false);
            groupBoxdatagrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewdevo).EndInit();
            groupBoxnuevoproducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewnuevoproducto).EndInit();
            groupBoxtipodevolucion.ResumeLayout(false);
            groupBoxtipodevolucion.PerformLayout();
            groupBoxdatos.ResumeLayout(false);
            groupBoxdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ayuda;
        private GroupBox groupBoxdatagrid;
        private TextBox textBox1;
        private Label label8;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label7;
        private Label label4;
        private DataGridView dataGridViewdevo;
        private DataGridViewTextBoxColumn columnaproducto;
        private DataGridViewTextBoxColumn cantvendida;
        private DataGridViewTextBoxColumn cantdevolver;
        private DataGridViewTextBoxColumn motivo;
        private DataGridViewTextBoxColumn estado;
        private GroupBox groupBoxnuevoproducto;
        private DataGridView dataGridViewnuevoproducto;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn total;
        private GroupBox groupBoxtipodevolucion;
        private RadioButton btncambio;
        private RadioButton btnreembolso;
        private Button btnimprimir;
        private Button btnvalidar;
        private GroupBox groupBoxdatos;
        private Button btnbuscarventa;
        private Label label3;
        private TextBox txtcliente;
        private Label label2;
        private TextBox txtfactura;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}