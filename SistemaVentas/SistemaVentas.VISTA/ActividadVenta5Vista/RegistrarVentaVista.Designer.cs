namespace SistemaVentas.VISTA.Actividad5Vista
{
    partial class RegistrarVentaVista
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 117);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "FECHA";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(131, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(131, 109);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(195, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(106, 369);
            button1.Name = "button1";
            button1.Size = new Size(129, 28);
            button1.TabIndex = 4;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(480, 154);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 159);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 6;
            label2.Text = "PRODUCTOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 109);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "TOTAL :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 109);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 8;
            label4.Text = "0";
            // 
            // button2
            // 
            button2.Location = new Point(288, 369);
            button2.Name = "button2";
            button2.Size = new Size(129, 28);
            button2.TabIndex = 9;
            button2.Text = "VER VENTAS";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(223, 47);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 10;
            label5.Text = "REGISTRAR VENTA";
            // 
            // RegistrarVentaVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 409);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "RegistrarVentaVista";
            Text = "RegistrarVentaVista";
            Load += RegistrarVentaVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Label label5;
    }
}