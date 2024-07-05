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
            textBoxCylinderDescription = new TextBox();
            buttonLookForDescription = new Button();
            buttonLinde = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridGeneral).BeginInit();
            SuspendLayout();
            // 
            // buttonLoadCylinders
            // 
            buttonLoadCylinders.Location = new Point(8, 312);
            buttonLoadCylinders.Name = "buttonLoadCylinders";
            buttonLoadCylinders.Size = new Size(185, 61);
            buttonLoadCylinders.TabIndex = 1;
            buttonLoadCylinders.Text = "Cargar";
            buttonLoadCylinders.UseVisualStyleBackColor = true;
            buttonLoadCylinders.Click += buttonLoadCylinders_Click;
            // 
            // labelControl
            // 
            labelControl.AutoSize = true;
            labelControl.Location = new Point(221, 449);
            labelControl.Name = "labelControl";
            labelControl.Size = new Size(70, 20);
            labelControl.TabIndex = 9;
            labelControl.Text = "Cilindros:";
            // 
            // labelStatusCities
            // 
            labelStatusCities.AutoSize = true;
            labelStatusCities.Location = new Point(287, 387);
            labelStatusCities.Name = "labelStatusCities";
            labelStatusCities.Size = new Size(18, 20);
            labelStatusCities.TabIndex = 10;
            labelStatusCities.Text = "...";
            // 
            // labelOKCities
            // 
            labelOKCities.AutoSize = true;
            labelOKCities.Location = new Point(218, 387);
            labelOKCities.Name = "labelOKCities";
            labelOKCities.Size = new Size(73, 20);
            labelOKCities.TabIndex = 11;
            labelOKCities.Text = "Ciudades:";
            // 
            // labelClientes
            // 
            labelClientes.AutoSize = true;
            labelClientes.Location = new Point(227, 419);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(64, 20);
            labelClientes.TabIndex = 12;
            labelClientes.Text = "Clientes:";
            // 
            // labelStatusClients
            // 
            labelStatusClients.AutoSize = true;
            labelStatusClients.Location = new Point(287, 419);
            labelStatusClients.Name = "labelStatusClients";
            labelStatusClients.Size = new Size(18, 20);
            labelStatusClients.TabIndex = 13;
            labelStatusClients.Text = "...";
            // 
            // labelStatusCylinders
            // 
            labelStatusCylinders.AutoSize = true;
            labelStatusCylinders.Location = new Point(287, 449);
            labelStatusCylinders.Name = "labelStatusCylinders";
            labelStatusCylinders.Size = new Size(18, 20);
            labelStatusCylinders.TabIndex = 14;
            labelStatusCylinders.Text = "...";
            // 
            // buttonExport
            // 
            buttonExport.Location = new Point(199, 312);
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
            labelGeneralStatusText.Location = new Point(18, 475);
            labelGeneralStatusText.Name = "labelGeneralStatusText";
            labelGeneralStatusText.Size = new Size(135, 20);
            labelGeneralStatusText.TabIndex = 22;
            labelGeneralStatusText.Text = "Cilindros cargados:";
            // 
            // labelGeneralStatusValue
            // 
            labelGeneralStatusValue.Anchor = AnchorStyles.Right;
            labelGeneralStatusValue.Location = new Point(189, 475);
            labelGeneralStatusValue.Name = "labelGeneralStatusValue";
            labelGeneralStatusValue.Size = new Size(126, 20);
            labelGeneralStatusValue.TabIndex = 23;
            labelGeneralStatusValue.Text = "0";
            labelGeneralStatusValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxClients
            // 
            textBoxClients.Location = new Point(177, 16);
            textBoxClients.Name = "textBoxClients";
            textBoxClients.Size = new Size(138, 27);
            textBoxClients.TabIndex = 17;
            textBoxClients.TextChanged += textBoxClients_TextChanged;
            // 
            // dataGridGeneral
            // 
            dataGridGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridGeneral.Location = new Point(325, 16);
            dataGridGeneral.Name = "dataGridGeneral";
            dataGridGeneral.RowHeadersWidth = 100;
            dataGridGeneral.Size = new Size(1277, 483);
            dataGridGeneral.TabIndex = 8;
            // 
            // checkboxCapacities
            // 
            checkboxCapacities.AutoSize = true;
            checkboxCapacities.Checked = true;
            checkboxCapacities.CheckState = CheckState.Checked;
            checkboxCapacities.Location = new Point(203, 227);
            checkboxCapacities.Name = "checkboxCapacities";
            checkboxCapacities.Size = new Size(116, 24);
            checkboxCapacities.TabIndex = 15;
            checkboxCapacities.Text = "Capacidades";
            checkboxCapacities.UseVisualStyleBackColor = true;
            // 
            // labelClients
            // 
            labelClients.AutoSize = true;
            labelClients.Location = new Point(12, 52);
            labelClients.Name = "labelClients";
            labelClients.Size = new Size(61, 20);
            labelClients.TabIndex = 7;
            labelClients.Text = "Clientes";
            // 
            // textboxClientId
            // 
            textboxClientId.Location = new Point(79, 16);
            textboxClientId.Name = "textboxClientId";
            textboxClientId.Size = new Size(92, 27);
            textboxClientId.TabIndex = 21;
            textboxClientId.TextChanged += textboxClientId_TextChanged;
            // 
            // comboBoxClients
            // 
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point(79, 49);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(236, 28);
            comboBoxClients.TabIndex = 6;
            comboBoxClients.SelectedValueChanged += comboBoxClients_SelectedValueChanged;
            // 
            // labelComboLocations
            // 
            labelComboLocations.AutoSize = true;
            labelComboLocations.Location = new Point(10, 197);
            labelComboLocations.Name = "labelComboLocations";
            labelComboLocations.Size = new Size(88, 20);
            labelComboLocations.TabIndex = 4;
            labelComboLocations.Text = "Localidades";
            // 
            // comboboxCities
            // 
            comboboxCities.FormattingEnabled = true;
            comboboxCities.Location = new Point(104, 194);
            comboboxCities.Name = "comboboxCities";
            comboboxCities.Size = new Size(211, 28);
            comboboxCities.TabIndex = 3;
            // 
            // checkboxCylinders
            // 
            checkboxCylinders.AutoSize = true;
            checkboxCylinders.Checked = true;
            checkboxCylinders.CheckState = CheckState.Checked;
            checkboxCylinders.Location = new Point(203, 257);
            checkboxCylinders.Name = "checkboxCylinders";
            checkboxCylinders.Size = new Size(89, 24);
            checkboxCylinders.TabIndex = 16;
            checkboxCylinders.Text = "Cilindros";
            checkboxCylinders.UseVisualStyleBackColor = true;
            // 
            // labelCylinders
            // 
            labelCylinders.AutoSize = true;
            labelCylinders.Location = new Point(12, 90);
            labelCylinders.Name = "labelCylinders";
            labelCylinders.Size = new Size(61, 20);
            labelCylinders.TabIndex = 24;
            labelCylinders.Text = "Cilindro";
            // 
            // textboxCylinder
            // 
            textboxCylinder.Location = new Point(79, 87);
            textboxCylinder.Name = "textboxCylinder";
            textboxCylinder.Size = new Size(92, 27);
            textboxCylinder.TabIndex = 25;
            textboxCylinder.TextChanged += textCylinder_TextChanged;
            // 
            // textBoxCylinderDescription
            // 
            textBoxCylinderDescription.Location = new Point(177, 87);
            textBoxCylinderDescription.Name = "textBoxCylinderDescription";
            textBoxCylinderDescription.Size = new Size(107, 27);
            textBoxCylinderDescription.TabIndex = 26;
            // 
            // buttonLookForDescription
            // 
            buttonLookForDescription.Location = new Point(290, 85);
            buttonLookForDescription.Name = "buttonLookForDescription";
            buttonLookForDescription.Size = new Size(25, 29);
            buttonLookForDescription.TabIndex = 27;
            buttonLookForDescription.Text = "X";
            buttonLookForDescription.UseVisualStyleBackColor = true;
            buttonLookForDescription.Click += button1_Click;
            // 
            // buttonLinde
            // 
            buttonLinde.Location = new Point(18, 419);
            buttonLinde.Name = "buttonLinde";
            buttonLinde.Size = new Size(176, 43);
            buttonLinde.TabIndex = 28;
            buttonLinde.Text = "Reporte Linde";
            buttonLinde.UseVisualStyleBackColor = true;
            buttonLinde.Click += buttonLinde_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1615, 515);
            Controls.Add(buttonLinde);
            Controls.Add(buttonLookForDescription);
            Controls.Add(textBoxCylinderDescription);
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
            Load += Main_Load;
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
        private TextBox textBoxCylinderDescription;
        private Button buttonLinde;
    }
}
