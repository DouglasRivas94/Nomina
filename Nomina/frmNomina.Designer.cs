namespace Nomina
{
    partial class frmNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNomina));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblHora = new Label();
            lblFecha = new Label();
            label10 = new Label();
            label9 = new Label();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            label12 = new Label();
            mtxtCedula = new MaskedTextBox();
            txtBono = new TextBox();
            label11 = new Label();
            txtHorasE = new TextBox();
            txtDep = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtViatico = new TextBox();
            txtSalario = new TextBox();
            txtCargo = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            lsvEmpleado = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            tabPage3 = new TabPage();
            btnGuard = new Button();
            lsvEmpleador = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            label1 = new Label();
            btnGuardar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(808, 367);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(lblHora);
            tabPage1.Controls.Add(lblFecha);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(btnAdd);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(800, 339);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Informacion";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(719, 85);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(44, 15);
            lblHora.TabIndex = 7;
            lblHora.Text = "label12";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(719, 31);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "label11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(620, 81);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 5;
            label10.Text = "Hora";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(620, 31);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 4;
            label9.Text = "Fecha";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(642, 141);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(mtxtCedula);
            groupBox1.Controls.Add(txtBono);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtHorasE);
            groupBox1.Controls.Add(txtDep);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtViatico);
            groupBox1.Controls.Add(txtSalario);
            groupBox1.Controls.Add(txtCargo);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 327);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(289, 34);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 17;
            label12.Text = "Cedula";
            // 
            // mtxtCedula
            // 
            mtxtCedula.Location = new Point(357, 25);
            mtxtCedula.Mask = "000-000000-0000L";
            mtxtCedula.Name = "mtxtCedula";
            mtxtCedula.Size = new Size(123, 23);
            mtxtCedula.TabIndex = 16;
            // 
            // txtBono
            // 
            txtBono.Location = new Point(357, 131);
            txtBono.Name = "txtBono";
            txtBono.Size = new Size(100, 23);
            txtBono.TabIndex = 15;
            txtBono.Tag = "0";
            txtBono.Text = "0";
            txtBono.KeyPress += txtSalario_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(289, 135);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 14;
            label11.Text = "Bonos";
            // 
            // txtHorasE
            // 
            txtHorasE.Location = new Point(357, 194);
            txtHorasE.Name = "txtHorasE";
            txtHorasE.Size = new Size(100, 23);
            txtHorasE.TabIndex = 13;
            txtHorasE.Tag = "0";
            txtHorasE.Text = "0";
            txtHorasE.KeyPress += txtSalario_KeyPress;
            // 
            // txtDep
            // 
            txtDep.Location = new Point(357, 75);
            txtDep.Name = "txtDep";
            txtDep.Size = new Size(100, 23);
            txtDep.TabIndex = 12;
            txtDep.Tag = "0";
            txtDep.Text = "0";
            txtDep.KeyPress += txtSalario_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(289, 197);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 11;
            label8.Text = "Horas E.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(275, 78);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 10;
            label7.Text = "Depreciacion";
            // 
            // txtViatico
            // 
            txtViatico.Location = new Point(116, 254);
            txtViatico.Name = "txtViatico";
            txtViatico.Size = new Size(100, 23);
            txtViatico.TabIndex = 9;
            txtViatico.Tag = "0";
            txtViatico.Text = "0";
            txtViatico.KeyPress += txtSalario_KeyPress;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(116, 194);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 8;
            txtSalario.KeyPress += txtSalario_KeyPress;
            txtSalario.Leave += txtSalario_Leave;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(116, 131);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(100, 23);
            txtCargo.TabIndex = 7;
            txtCargo.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(116, 75);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 6;
            txtApellido.KeyPress += txtNombre_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 257);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 4;
            label6.Text = "Viaticos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 197);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 3;
            label5.Text = "Salario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 134);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Cargo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 78);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 29);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lsvEmpleado);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(800, 339);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pago Empleado";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lsvEmpleado
            // 
            lsvEmpleado.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            lsvEmpleado.GridLines = true;
            lsvEmpleado.Location = new Point(7, 8);
            lsvEmpleado.Name = "lsvEmpleado";
            lsvEmpleado.Size = new Size(787, 325);
            lsvEmpleado.TabIndex = 0;
            lsvEmpleado.UseCompatibleStateImageBehavior = false;
            lsvEmpleado.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Cargo";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre Completo";
            columnHeader2.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Salario";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "DEP.";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Viaticos";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Horas E.";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Bonos";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Total";
            columnHeader9.Width = 70;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "INSS";
            columnHeader10.Width = 70;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "IR";
            columnHeader11.Width = 67;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Salario neto";
            columnHeader12.Width = 75;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnGuardar);
            tabPage3.Controls.Add(btnGuard);
            tabPage3.Controls.Add(lsvEmpleador);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(800, 339);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Pago Empleador";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGuard
            // 
            btnGuard.Location = new Point(662, 137);
            btnGuard.Name = "btnGuard";
            btnGuard.Size = new Size(75, 23);
            btnGuard.TabIndex = 1;
            btnGuard.Text = "Salir";
            btnGuard.UseVisualStyleBackColor = true;
            btnGuard.Click += btnGuard_Click;
            // 
            // lsvEmpleador
            // 
            lsvEmpleador.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader13, columnHeader14, columnHeader15, columnHeader16, columnHeader17, columnHeader18 });
            lsvEmpleador.GridLines = true;
            lsvEmpleador.Location = new Point(6, 6);
            lsvEmpleador.Name = "lsvEmpleador";
            lsvEmpleador.Size = new Size(606, 327);
            lsvEmpleador.TabIndex = 0;
            lsvEmpleador.UseCompatibleStateImageBehavior = false;
            lsvEmpleador.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Total";
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "INSS Patronal";
            columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Vacaciones";
            columnHeader14.Width = 80;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "13 Mes";
            columnHeader15.Width = 80;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Indemnizacion";
            columnHeader16.Width = 100;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "INATEC";
            columnHeader17.Width = 80;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Neto Pagar";
            columnHeader18.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(326, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 40);
            label1.TabIndex = 1;
            label1.Text = "Nomina";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(662, 202);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmNomina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(832, 438);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmNomina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNomina";
            Load += frmNomina_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tabPage2;
        private Label label1;
        private Label lblHora;
        private Label lblFecha;
        private Label label10;
        private Label label9;
        private Button btnSup;
        private Button btnAdd;
        private TextBox txtHorasE;
        private TextBox txtDep;
        private Label label8;
        private Label label7;
        private TextBox txtViatico;
        private TextBox txtSalario;
        private TextBox txtCargo;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private ListView lsvEmpleado;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private TextBox txtBono;
        private Label label11;
        private TabPage tabPage3;
        private ListView lsvEmpleador;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private Button btnGuard;
        private Label label12;
        private MaskedTextBox mtxtCedula;
        private Button btnGuardar;
    }
}