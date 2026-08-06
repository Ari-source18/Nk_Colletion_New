namespace Nk_Colletion_New
{
    partial class Form_caja
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
            dateTimePicker1 = new DateTimePicker();
            label20 = new Label();
            groupBoxnuevoproducto = new GroupBox();
            btnControldeegresos = new Button();
            btnCierredecaja = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            txtSaldoinicial = new TextBox();
            txtSaldofinal = new TextBox();
            txtTotalingresos = new TextBox();
            txtTotalegresos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtMonto = new TextBox();
            txtConcepto = new TextBox();
            lblmonto = new Label();
            lblconcepto = new Label();
            btnGuardarmovimiento = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            groupBoxnuevoproducto.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_ayuda
            // 
            btn_ayuda.ImageIndex = 0;
            btn_ayuda.Location = new Point(1268, 137);
            btn_ayuda.Name = "btn_ayuda";
            btn_ayuda.Size = new Size(47, 43);
            btn_ayuda.TabIndex = 184;
            btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(153, 129);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(316, 31);
            dateTimePicker1.TabIndex = 183;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(64, 0, 0);
            label20.Location = new Point(78, 137);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(57, 20);
            label20.TabIndex = 182;
            label20.Text = "Fecha:";
            // 
            // groupBoxnuevoproducto
            // 
            groupBoxnuevoproducto.BackColor = Color.SeaShell;
            groupBoxnuevoproducto.Controls.Add(btnControldeegresos);
            groupBoxnuevoproducto.Controls.Add(btnCierredecaja);
            groupBoxnuevoproducto.Controls.Add(button1);
            groupBoxnuevoproducto.Location = new Point(848, 428);
            groupBoxnuevoproducto.Margin = new Padding(2);
            groupBoxnuevoproducto.Name = "groupBoxnuevoproducto";
            groupBoxnuevoproducto.Padding = new Padding(2);
            groupBoxnuevoproducto.Size = new Size(324, 171);
            groupBoxnuevoproducto.TabIndex = 180;
            groupBoxnuevoproducto.TabStop = false;
            groupBoxnuevoproducto.Text = "Opciones de caja";
            // 
            // btnControldeegresos
            // 
            btnControldeegresos.BackColor = Color.Maroon;
            btnControldeegresos.ForeColor = SystemColors.ControlLightLight;
            btnControldeegresos.Location = new Point(54, 108);
            btnControldeegresos.Margin = new Padding(2);
            btnControldeegresos.Name = "btnControldeegresos";
            btnControldeegresos.Size = new Size(194, 34);
            btnControldeegresos.TabIndex = 140;
            btnControldeegresos.Text = "Control de egresos";
            btnControldeegresos.UseVisualStyleBackColor = false;
            // 
            // btnCierredecaja
            // 
            btnCierredecaja.BackColor = Color.Maroon;
            btnCierredecaja.ForeColor = SystemColors.ControlLightLight;
            btnCierredecaja.Location = new Point(54, 69);
            btnCierredecaja.Margin = new Padding(2);
            btnCierredecaja.Name = "btnCierredecaja";
            btnCierredecaja.Size = new Size(194, 34);
            btnCierredecaja.TabIndex = 139;
            btnCierredecaja.Text = "Cierre de caja";
            btnCierredecaja.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(54, 30);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(194, 34);
            button1.TabIndex = 138;
            button1.Text = "Arqueo de caja";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(78, 205);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(661, 394);
            groupBox1.TabIndex = 181;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSaldoinicial);
            groupBox3.Controls.Add(txtSaldofinal);
            groupBox3.Controls.Add(txtTotalingresos);
            groupBox3.Controls.Add(txtTotalegresos);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(104, 171);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(428, 206);
            groupBox3.TabIndex = 108;
            groupBox3.TabStop = false;
            // 
            // txtSaldoinicial
            // 
            txtSaldoinicial.Location = new Point(165, 21);
            txtSaldoinicial.Margin = new Padding(2);
            txtSaldoinicial.Name = "txtSaldoinicial";
            txtSaldoinicial.Size = new Size(150, 31);
            txtSaldoinicial.TabIndex = 10;
            // 
            // txtSaldofinal
            // 
            txtSaldofinal.Location = new Point(165, 155);
            txtSaldofinal.Margin = new Padding(2);
            txtSaldofinal.Name = "txtSaldofinal";
            txtSaldofinal.Size = new Size(150, 31);
            txtSaldofinal.TabIndex = 9;
            // 
            // txtTotalingresos
            // 
            txtTotalingresos.Location = new Point(165, 62);
            txtTotalingresos.Margin = new Padding(2);
            txtTotalingresos.Name = "txtTotalingresos";
            txtTotalingresos.Size = new Size(150, 31);
            txtTotalingresos.TabIndex = 8;
            // 
            // txtTotalegresos
            // 
            txtTotalegresos.Location = new Point(165, 110);
            txtTotalegresos.Margin = new Padding(2);
            txtTotalegresos.Name = "txtTotalegresos";
            txtTotalegresos.Size = new Size(150, 31);
            txtTotalegresos.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 68);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 6;
            label1.Text = "Total ingreso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 115);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 5;
            label2.Text = "Total egresos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 160);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 4;
            label4.Text = "Saldo final:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 27);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 3;
            label3.Text = "Saldo inicial:";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.SeaShell;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3 });
            dataGridView2.Location = new Point(115, 28);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(417, 122);
            dataGridView2.TabIndex = 0;
            // 
            // Column2
            // 
            Column2.HeaderText = "Concepto";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Monto";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SeaShell;
            groupBox2.Controls.Add(txtMonto);
            groupBox2.Controls.Add(txtConcepto);
            groupBox2.Controls.Add(lblmonto);
            groupBox2.Controls.Add(lblconcepto);
            groupBox2.Controls.Add(btnGuardarmovimiento);
            groupBox2.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox2.Location = new Point(848, 205);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(324, 209);
            groupBox2.TabIndex = 179;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registrar movimiento ";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(86, 95);
            txtMonto.Margin = new Padding(2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(182, 31);
            txtMonto.TabIndex = 5;
            // 
            // txtConcepto
            // 
            txtConcepto.Location = new Point(110, 49);
            txtConcepto.Margin = new Padding(2);
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(159, 31);
            txtConcepto.TabIndex = 4;
            // 
            // lblmonto
            // 
            lblmonto.AutoSize = true;
            lblmonto.Location = new Point(10, 100);
            lblmonto.Margin = new Padding(2, 0, 2, 0);
            lblmonto.Name = "lblmonto";
            lblmonto.Size = new Size(70, 25);
            lblmonto.TabIndex = 2;
            lblmonto.Text = "Monto:";
            // 
            // lblconcepto
            // 
            lblconcepto.AutoSize = true;
            lblconcepto.Location = new Point(10, 54);
            lblconcepto.Margin = new Padding(2, 0, 2, 0);
            lblconcepto.Name = "lblconcepto";
            lblconcepto.Size = new Size(93, 25);
            lblconcepto.TabIndex = 1;
            lblconcepto.Text = "Concepto:";
            // 
            // btnGuardarmovimiento
            // 
            btnGuardarmovimiento.BackColor = Color.Maroon;
            btnGuardarmovimiento.ForeColor = SystemColors.ControlLightLight;
            btnGuardarmovimiento.Location = new Point(32, 154);
            btnGuardarmovimiento.Margin = new Padding(2);
            btnGuardarmovimiento.Name = "btnGuardarmovimiento";
            btnGuardarmovimiento.Size = new Size(215, 34);
            btnGuardarmovimiento.TabIndex = 137;
            btnGuardarmovimiento.Text = "Guardar movimiento";
            btnGuardarmovimiento.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(1233, 41);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 178;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(58, 59);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(220, 32);
            label5.TabIndex = 177;
            label5.Text = "Gestión de Caja";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(47, 78);
            label6.Margin = new Padding(2, 0, 2, 0);
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
            panel1.TabIndex = 185;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 0);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1345, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(26, 798);
            panel2.TabIndex = 186;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 0, 0);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(26, 798);
            panel3.TabIndex = 187;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 0, 0);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(26, 798);
            panel4.Name = "panel4";
            panel4.Size = new Size(1319, 26);
            panel4.TabIndex = 188;
            // 
            // Form_caja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 824);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_ayuda);
            Controls.Add(dateTimePicker1);
            Controls.Add(label20);
            Controls.Add(groupBoxnuevoproducto);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_caja";
            Text = "Form_caja";
            Load += Form_caja_Load;
            groupBoxnuevoproducto.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ayuda;
        private DateTimePicker dateTimePicker1;
        private Label label20;
        private GroupBox groupBoxnuevoproducto;
        private Button btnControldeegresos;
        private Button btnCierredecaja;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private TextBox txtSaldoinicial;
        private TextBox txtSaldofinal;
        private TextBox txtTotalingresos;
        private TextBox txtTotalegresos;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private GroupBox groupBox2;
        private TextBox txtMonto;
        private TextBox txtConcepto;
        private Label lblmonto;
        private Label lblconcepto;
        private Button btnGuardarmovimiento;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}