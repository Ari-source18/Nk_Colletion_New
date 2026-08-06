namespace Nk_Colletion_New
{
    partial class Form_control_egresos
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
            panel1 = new Panel();
            btn_ayuda = new Button();
            btnRegresaracaja = new Button();
            dataGridView1 = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Concepto = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Responsable = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtTotaldeegresos = new TextBox();
            txtTotalegresado = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnImprimir = new Button();
            btnBuscar = new Button();
            CBconcepto = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label12 = new Label();
            label2 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 26);
            panel1.TabIndex = 178;
            // 
            // btn_ayuda
            // 
            btn_ayuda.ImageIndex = 0;
            btn_ayuda.Location = new Point(1278, 140);
            btn_ayuda.Name = "btn_ayuda";
            btn_ayuda.Size = new Size(47, 43);
            btn_ayuda.TabIndex = 186;
            btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // btnRegresaracaja
            // 
            btnRegresaracaja.BackColor = Color.Maroon;
            btnRegresaracaja.BackgroundImageLayout = ImageLayout.None;
            btnRegresaracaja.Font = new Font("PMingLiU-ExtB", 10F);
            btnRegresaracaja.ForeColor = Color.White;
            btnRegresaracaja.Location = new Point(1151, 731);
            btnRegresaracaja.Margin = new Padding(2);
            btnRegresaracaja.Name = "btnRegresaracaja";
            btnRegresaracaja.Size = new Size(148, 42);
            btnRegresaracaja.TabIndex = 185;
            btnRegresaracaja.Text = "Regresar a caja";
            btnRegresaracaja.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SeaShell;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, Concepto, Descripcion, Responsable, Monto });
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(208, 293);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(829, 168);
            dataGridView1.TabIndex = 184;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Concepto
            // 
            Concepto.HeaderText = "Concepto";
            Concepto.MinimumWidth = 6;
            Concepto.Name = "Concepto";
            Concepto.Width = 195;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 195;
            // 
            // Responsable
            // 
            Responsable.HeaderText = "Responsable";
            Responsable.MinimumWidth = 6;
            Responsable.Name = "Responsable";
            Responsable.Width = 125;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto (C$)";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.Width = 125;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SeaShell;
            groupBox2.Controls.Add(txtTotaldeegresos);
            groupBox2.Controls.Add(txtTotalegresado);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox2.Location = new Point(116, 512);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(1022, 111);
            groupBox2.TabIndex = 183;
            groupBox2.TabStop = false;
            // 
            // txtTotaldeegresos
            // 
            txtTotaldeegresos.Font = new Font("PMingLiU-ExtB", 9F);
            txtTotaldeegresos.Location = new Point(184, 45);
            txtTotaldeegresos.Margin = new Padding(2);
            txtTotaldeegresos.Name = "txtTotaldeegresos";
            txtTotaldeegresos.Size = new Size(94, 29);
            txtTotaldeegresos.TabIndex = 49;
            // 
            // txtTotalegresado
            // 
            txtTotalegresado.Font = new Font("PMingLiU-ExtB", 9F);
            txtTotalegresado.Location = new Point(822, 45);
            txtTotalegresado.Margin = new Padding(2);
            txtTotalegresado.Name = "txtTotalegresado";
            txtTotalegresado.Size = new Size(180, 29);
            txtTotalegresado.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("PMingLiU-ExtB", 10F);
            label3.Location = new Point(678, 54);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 47;
            label3.Text = "Total egresado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("PMingLiU-ExtB", 10F);
            label4.Location = new Point(24, 54);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 37;
            label4.Text = "Total de egresoso:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(btnImprimir);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(CBconcepto);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox1.Location = new Point(107, 137);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1022, 139);
            groupBox1.TabIndex = 182;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.Maroon;
            btnImprimir.BackgroundImageLayout = ImageLayout.None;
            btnImprimir.Font = new Font("PMingLiU-ExtB", 10F);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(898, 55);
            btnImprimir.Margin = new Padding(2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(116, 42);
            btnImprimir.TabIndex = 147;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Maroon;
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.Font = new Font("PMingLiU-ExtB", 10F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(751, 55);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 42);
            btnBuscar.TabIndex = 146;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // CBconcepto
            // 
            CBconcepto.Font = new Font("PMingLiU-ExtB", 9F);
            CBconcepto.FormattingEnabled = true;
            CBconcepto.Location = new Point(425, 69);
            CBconcepto.Margin = new Padding(2);
            CBconcepto.Name = "CBconcepto";
            CBconcepto.Size = new Size(306, 26);
            CBconcepto.TabIndex = 145;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarForeColor = Color.Black;
            dateTimePicker2.CalendarMonthBackground = Color.White;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 8.25F);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(220, 69);
            dateTimePicker2.Margin = new Padding(4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(168, 26);
            dateTimePicker2.TabIndex = 144;
            dateTimePicker2.Value = new DateTime(2026, 6, 7, 12, 32, 51, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.Black;
            dateTimePicker1.CalendarMonthBackground = Color.White;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 8.25F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(9, 72);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(168, 26);
            dateTimePicker1.TabIndex = 143;
            dateTimePicker1.Value = new DateTime(2026, 6, 7, 12, 32, 51, 0);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("PMingLiU-ExtB", 10F);
            label12.Location = new Point(424, 39);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(84, 20);
            label12.TabIndex = 60;
            label12.Text = "Concepto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 10F);
            label2.Location = new Point(219, 39);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 47;
            label2.Text = "Fecha fin:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("PMingLiU-ExtB", 10F);
            label10.Location = new Point(8, 39);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 37;
            label10.Text = "Fecha inicio:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(1246, 51);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 181;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(44, 71);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(368, 32);
            label5.TabIndex = 180;
            label5.Text = "Control de Egresos de Caja";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(33, 87);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(1214, 32);
            label6.TabIndex = 179;
            label6.Text = "___________________________________________________________________________";
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
            // Form_control_egresos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 824);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btn_ayuda);
            Controls.Add(btnRegresaracaja);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_control_egresos";
            Text = "Form_control_egresos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_ayuda;
        private Button btnRegresaracaja;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Concepto;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Responsable;
        private DataGridViewTextBoxColumn Monto;
        private GroupBox groupBox2;
        private TextBox txtTotaldeegresos;
        private TextBox txtTotalegresado;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Button btnImprimir;
        private Button btnBuscar;
        private ComboBox CBconcepto;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label12;
        private Label label2;
        private Label label10;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}