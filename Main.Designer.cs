namespace EasyAccess
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            ///  Required method for Designer support - do not modify
            ///  the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                  buttonLoadCylinders = new Button();
                  labelControl = new Label();
                  labelStatusCities = new Label();
                  labelOKCities = new Label();
                  labelClientes = new Label();
                  labelStatusClients = new Label();
                  labelStatusCylinders = new Label();
                  buttonExport = new Button();
                  labelGeneralStatusText = new Label();
                  labelGeneralStatusValue = new Label();
                  textBoxClients = new TextBox();
                  dataGridGeneral = new DataGridView();
                  checkboxCapacities = new CheckBox();
                  labelClients = new Label();
                  textboxClientId = new TextBox();
                  comboBoxClients = new ComboBox();
                  labelComboLocations = new Label();
                  comboboxCities = new ComboBox();
                  checkboxCylinders = new CheckBox();
                  labelCylinders = new Label();
                  textboxCylinder = new TextBox();
                  textBoxFilterDescription = new TextBox();
                  buttonLookForDescription = new Button();
                  buttonLinde = new Button();
                  textboxFilterFamilies = new TextBox();
                  label1 = new Label();
                  label2 = new Label();
                  ((System.ComponentModel.ISupportInitialize)dataGridGeneral).BeginInit();
                  SuspendLayout();
                  // 
                  // buttonLoadCylinders
                  // 
                  buttonLoadCylinders.Location = new Point(199, 378);
                  buttonLoadCylinders.Name = "buttonLoadCylinders";
                  buttonLoadCylinders.Size = new Size(117, 61);
                  buttonLoadCylinders.TabIndex = 1;
                  buttonLoadCylinders.Text = "Cargar";
                  buttonLoadCylinders.UseVisualStyleBackColor = true;
                  buttonLoadCylinders.Click += buttonLoadCylinders_Click;
                  // 
                  // labelControl
                  // 
                  labelControl.AutoSize = true;
                  labelControl.Location = new Point(10, 449);
                  labelControl.Name = "labelControl";
                  labelControl.Size = new Size(70, 20);
                  labelControl.TabIndex = 9;
                  labelControl.Text = "Cilindros:";
                  // 
                  // labelStatusCities
                  // 
                  labelStatusCities.AutoSize = true;
                  labelStatusCities.Location = new Point(84, 393);
                  labelStatusCities.Name = "labelStatusCities";
                  labelStatusCities.Size = new Size(18, 20);
                  labelStatusCities.TabIndex = 10;
                  labelStatusCities.Text = "...";
                  // 
                  // labelOKCities
                  // 
                  labelOKCities.AutoSize = true;
                  labelOKCities.Location = new Point(10, 393);
                  labelOKCities.Name = "labelOKCities";
                  labelOKCities.Size = new Size(73, 20);
                  labelOKCities.TabIndex = 11;
                  labelOKCities.Text = "Ciudades:";
                  // 
                  // labelClientes
                  // 
                  labelClientes.AutoSize = true;
                  labelClientes.Location = new Point(10, 419);
                  labelClientes.Name = "labelClientes";
                  labelClientes.Size = new Size(64, 20);
                  labelClientes.TabIndex = 12;
                  labelClientes.Text = "Clientes:";
                  // 
                  // labelStatusClients
                  // 
                  labelStatusClients.AutoSize = true;
                  labelStatusClients.Location = new Point(84, 419);
                  labelStatusClients.Name = "labelStatusClients";
                  labelStatusClients.Size = new Size(18, 20);
                  labelStatusClients.TabIndex = 13;
                  labelStatusClients.Text = "...";
                  // 
                  // labelStatusCylinders
                  // 
                  labelStatusCylinders.AutoSize = true;
                  labelStatusCylinders.Location = new Point(84, 449);
                  labelStatusCylinders.Name = "labelStatusCylinders";
                  labelStatusCylinders.Size = new Size(18, 20);
                  labelStatusCylinders.TabIndex = 14;
                  labelStatusCylinders.Text = "...";
                  // 
                  // buttonExport
                  // 
                  buttonExport.Location = new Point(321, 442);
                  buttonExport.Name = "buttonExport";
                  buttonExport.Size = new Size(116, 61);
                  buttonExport.TabIndex = 18;
                  buttonExport.Text = "Exportar tabla";
                  buttonExport.UseVisualStyleBackColor = true;
                  buttonExport.Click += buttonExport_Click;
                  // 
                  // labelGeneralStatusText
                  // 
                  labelGeneralStatusText.AutoSize = true;
                  labelGeneralStatusText.Location = new Point(10, 475);
                  labelGeneralStatusText.Name = "labelGeneralStatusText";
                  labelGeneralStatusText.Size = new Size(135, 20);
                  labelGeneralStatusText.TabIndex = 22;
                  labelGeneralStatusText.Text = "Cilindros cargados:";
                  // 
                  // labelGeneralStatusValue
                  // 
                  labelGeneralStatusValue.Anchor = AnchorStyles.Right;
                  labelGeneralStatusValue.Location = new Point(151, 475);
                  labelGeneralStatusValue.Name = "labelGeneralStatusValue";
                  labelGeneralStatusValue.Size = new Size(126, 20);
                  labelGeneralStatusValue.TabIndex = 23;
                  labelGeneralStatusValue.Text = "0";
                  labelGeneralStatusValue.TextAlign = ContentAlignment.MiddleRight;
                  // 
                  // textBoxClients
                  // 
                  textBoxClients.Location = new Point(206, 24);
                  textBoxClients.Name = "textBoxClients";
                  textBoxClients.Size = new Size(231, 27);
                  textBoxClients.TabIndex = 17;
                  textBoxClients.TextChanged += textBoxClients_TextChanged;
                  // 
                  // dataGridGeneral
                  // 
                  dataGridGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                  dataGridGeneral.Location = new Point(443, 16);
                  dataGridGeneral.Name = "dataGridGeneral";
                  dataGridGeneral.RowHeadersWidth = 100;
                  dataGridGeneral.Size = new Size(1159, 483);
                  dataGridGeneral.TabIndex = 8;
                  // 
                  // checkboxCapacities
                  // 
                  checkboxCapacities.AutoSize = true;
                  checkboxCapacities.Checked = true;
                  checkboxCapacities.CheckState = CheckState.Checked;
                  checkboxCapacities.Location = new Point(322, 196);
                  checkboxCapacities.Name = "checkboxCapacities";
                  checkboxCapacities.Size = new Size(116, 24);
                  checkboxCapacities.TabIndex = 15;
                  checkboxCapacities.Text = "Capacidades";
                  checkboxCapacities.UseVisualStyleBackColor = true;
                  // 
                  // labelClients
                  // 
                  labelClients.AutoSize = true;
                  labelClients.Location = new Point(6, 60);
                  labelClients.Name = "labelClients";
                  labelClients.Size = new Size(61, 20);
                  labelClients.TabIndex = 7;
                  labelClients.Text = "Clientes";
                  // 
                  // textboxClientId
                  // 
                  textboxClientId.Location = new Point(108, 24);
                  textboxClientId.Name = "textboxClientId";
                  textboxClientId.Size = new Size(92, 27);
                  textboxClientId.TabIndex = 21;
                  textboxClientId.TextChanged += textboxClientId_TextChanged;
                  // 
                  // comboBoxClients
                  // 
                  comboBoxClients.FormattingEnabled = true;
                  comboBoxClients.Location = new Point(108, 57);
                  comboBoxClients.Name = "comboBoxClients";
                  comboBoxClients.Size = new Size(330, 28);
                  comboBoxClients.TabIndex = 6;
                  comboBoxClients.SelectedValueChanged += comboBoxClients_SelectedValueChanged;
                  // 
                  // labelComboLocations
                  // 
                  labelComboLocations.AutoSize = true;
                  labelComboLocations.Location = new Point(6, 156);
                  labelComboLocations.Name = "labelComboLocations";
                  labelComboLocations.Size = new Size(88, 20);
                  labelComboLocations.TabIndex = 4;
                  labelComboLocations.Text = "Localidades";
                  // 
                  // comboboxCities
                  // 
                  comboboxCities.FormattingEnabled = true;
                  comboboxCities.Location = new Point(108, 153);
                  comboboxCities.Name = "comboboxCities";
                  comboboxCities.Size = new Size(330, 28);
                  comboboxCities.TabIndex = 3;
                  // 
                  // checkboxCylinders
                  // 
                  checkboxCylinders.AutoSize = true;
                  checkboxCylinders.Checked = true;
                  checkboxCylinders.CheckState = CheckState.Checked;
                  checkboxCylinders.Location = new Point(322, 226);
                  checkboxCylinders.Name = "checkboxCylinders";
                  checkboxCylinders.Size = new Size(89, 24);
                  checkboxCylinders.TabIndex = 16;
                  checkboxCylinders.Text = "Cilindros";
                  checkboxCylinders.UseVisualStyleBackColor = true;
                  // 
                  // labelCylinders
                  // 
                  labelCylinders.AutoSize = true;
                  labelCylinders.Location = new Point(6, 90);
                  labelCylinders.Name = "labelCylinders";
                  labelCylinders.Size = new Size(61, 20);
                  labelCylinders.TabIndex = 24;
                  labelCylinders.Text = "Cilindro";
                  // 
                  // textboxCylinder
                  // 
                  textboxCylinder.Location = new Point(108, 90);
                  textboxCylinder.Name = "textboxCylinder";
                  textboxCylinder.Size = new Size(92, 27);
                  textboxCylinder.TabIndex = 25;
                  textboxCylinder.TextChanged += textCylinder_TextChanged;
                  // 
                  // textBoxFilterDescription
                  // 
                  textBoxFilterDescription.Location = new Point(206, 90);
                  textBoxFilterDescription.Name = "textBoxFilterDescription";
                  textBoxFilterDescription.Size = new Size(170, 27);
                  textBoxFilterDescription.TabIndex = 26;
                  // 
                  // buttonLookForDescription
                  // 
                  buttonLookForDescription.Location = new Point(382, 90);
                  buttonLookForDescription.Name = "buttonLookForDescription";
                  buttonLookForDescription.Size = new Size(55, 57);
                  buttonLookForDescription.TabIndex = 27;
                  buttonLookForDescription.Text = "X";
                  buttonLookForDescription.UseVisualStyleBackColor = true;
                  buttonLookForDescription.Click += button1_Click;
                  // 
                  // buttonLinde
                  // 
                  buttonLinde.Enabled = false;
                  buttonLinde.Location = new Point(322, 378);
                  buttonLinde.Name = "buttonLinde";
                  buttonLinde.Size = new Size(115, 61);
                  buttonLinde.TabIndex = 28;
                  buttonLinde.Text = "Reporte Linde";
                  buttonLinde.UseVisualStyleBackColor = true;
                  buttonLinde.Click += buttonLinde_Click;
                  // 
                  // textboxFilterFamilies
                  // 
                  textboxFilterFamilies.Location = new Point(108, 120);
                  textboxFilterFamilies.Name = "textboxFilterFamilies";
                  textboxFilterFamilies.Size = new Size(268, 27);
                  textboxFilterFamilies.TabIndex = 29;
                  // 
                  // label1
                  // 
                  label1.AutoSize = true;
                  label1.Location = new Point(6, 120);
                  label1.Name = "label1";
                  label1.Size = new Size(94, 20);
                  label1.TabIndex = 30;
                  label1.Text = "Filtro Familia";
                  // 
                  // label2
                  // 
                  label2.AutoSize = true;
                  label2.Location = new Point(6, 31);
                  label2.Name = "label2";
                  label2.Size = new Size(74, 20);
                  label2.TabIndex = 31;
                  label2.Text = "Busqueda";
                  label2.Click += label2_Click;
                  // 
                  // Main
                  // 
                  AutoScaleDimensions = new SizeF(8F, 20F);
                  AutoScaleMode = AutoScaleMode.Font;
                  ClientSize = new Size(1615, 515);
                  Controls.Add(label2);
                  Controls.Add(label1);
                  Controls.Add(textboxFilterFamilies);
                  Controls.Add(buttonLinde);
                  Controls.Add(buttonLookForDescription);
                  Controls.Add(textBoxFilterDescription);
                  Controls.Add(textboxCylinder);
                  Controls.Add(labelCylinders);
                  Controls.Add(labelGeneralStatusValue);
                  Controls.Add(labelGeneralStatusText);
                  Controls.Add(textboxClientId);
                  Controls.Add(buttonExport);
                  Controls.Add(textBoxClients);
                  Controls.Add(checkboxCylinders);
                  Controls.Add(checkboxCapacities);
                  Controls.Add(labelStatusCylinders);
                  Controls.Add(labelStatusClients);
                  Controls.Add(labelClientes);
                  Controls.Add(labelOKCities);
                  Controls.Add(labelStatusCities);
                  Controls.Add(labelControl);
                  Controls.Add(dataGridGeneral);
                  Controls.Add(labelClients);
                  Controls.Add(comboBoxClients);
                  Controls.Add(labelComboLocations);
                  Controls.Add(comboboxCities);
                  Controls.Add(buttonLoadCylinders);
                  Name = "Main";
                  Text = "Easy Extension";
                  ((System.ComponentModel.ISupportInitialize)dataGridGeneral).EndInit();
                  ResumeLayout(false);
                  PerformLayout();
            }

            #endregion

            private Button buttonAllClients;
        private Button buttonLoadCylinders;
        private Button buttonLookForDescription;
        private Label labelControl;
        private Label labelClientes;
        private Label labelStatusCities;
        private Label labelOKCities;
        private Label labelStatusClients;
        private Label labelStatusCylinders;
        private Button buttonExport;
        private Label labelGeneralStatusText;
        private Label labelGeneralStatusValue;
        private TextBox textBoxClients;
        private DataGridView dataGridGeneral;
        private CheckBox checkboxCapacities;
        private Label labelClients;
        private TextBox textboxClientId;
        private ComboBox comboBoxClients;
        private Label labelComboLocations;
        private ComboBox comboboxCities;
        private CheckBox checkboxCylinders;
        private Label labelCylinders;
        private TextBox textboxCylinder;
        private TextBox textBoxFilterDescription;
        private Button buttonLinde;
            private TextBox textBoxFilterCapacity;
            private TextBox textboxFilterFamilies;
            private Label label1;
            private Label label2;
            //private TextBox textBoxFilterCapacity;
      }
}
