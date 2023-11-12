namespace ProCast
{
    partial class Form1
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
            lblNamn = new Label();
            lblUrl = new Label();
            lblAvsnitt = new Label();
            lblKategori = new Label();
            txtNamn = new TextBox();
            txtUrl = new TextBox();
            txtKategoriInput = new TextBox();
            btnLaggTillKategori = new Button();
            btnAndraKategori = new Button();
            btnTaBortKategori = new Button();
            btnLaggTillFlode = new Button();
            btnAndraFlode = new Button();
            btnTaBortFlode = new Button();
            btnAterstall = new Button();
            cmbFiltrera = new ComboBox();
            cmbKategori = new ComboBox();
            lstbxKategorier = new ListBox();
            listViewPodd = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            listViewAvsnitt = new ListView();
            columnHeader5 = new ColumnHeader();
            textBoxDescription = new TextBox();
            cmbIntervall = new ComboBox();
            btnRensa = new Button();
            SuspendLayout();
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNamn.ForeColor = Color.FromArgb(0, 0, 64);
            lblNamn.Location = new Point(35, 34);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(40, 18);
            lblNamn.TabIndex = 0;
            lblNamn.Text = "NAMN";
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblUrl.ForeColor = Color.FromArgb(0, 0, 64);
            lblUrl.Location = new Point(35, 108);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(32, 18);
            lblUrl.TabIndex = 1;
            lblUrl.Text = "URL";
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvsnitt.ForeColor = Color.FromArgb(0, 0, 64);
            lblAvsnitt.Location = new Point(532, 34);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(64, 18);
            lblAvsnitt.TabIndex = 3;
            lblAvsnitt.Text = "AVSNITT";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblKategori.ForeColor = Color.FromArgb(0, 0, 64);
            lblKategori.Location = new Point(769, 34);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(72, 18);
            lblKategori.TabIndex = 4;
            lblKategori.Text = "KATEGORI";
            // 
            // txtNamn
            // 
            txtNamn.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNamn.ForeColor = Color.FromArgb(0, 0, 64);
            txtNamn.Location = new Point(35, 58);
            txtNamn.Margin = new Padding(3, 2, 3, 2);
            txtNamn.Name = "txtNamn";
            txtNamn.Size = new Size(197, 20);
            txtNamn.TabIndex = 5;
            // 
            // txtUrl
            // 
            txtUrl.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUrl.ForeColor = Color.FromArgb(0, 0, 64);
            txtUrl.Location = new Point(35, 127);
            txtUrl.Margin = new Padding(3, 2, 3, 2);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(197, 20);
            txtUrl.TabIndex = 6;
            // 
            // txtKategoriInput
            // 
            txtKategoriInput.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtKategoriInput.ForeColor = Color.FromArgb(0, 0, 64);
            txtKategoriInput.Location = new Point(773, 58);
            txtKategoriInput.Margin = new Padding(3, 2, 3, 2);
            txtKategoriInput.Name = "txtKategoriInput";
            txtKategoriInput.Size = new Size(254, 20);
            txtKategoriInput.TabIndex = 7;
            txtKategoriInput.TextChanged += txtKategoriInput_TextChanged;
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLaggTillKategori.ForeColor = Color.FromArgb(0, 0, 64);
            btnLaggTillKategori.Location = new Point(769, 90);
            btnLaggTillKategori.Margin = new Padding(3, 2, 3, 2);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(82, 22);
            btnLaggTillKategori.TabIndex = 8;
            btnLaggTillKategori.Text = "Lägg till";
            btnLaggTillKategori.UseVisualStyleBackColor = true;
            btnLaggTillKategori.Click += btnLaggTillKategori_Click;
            // 
            // btnAndraKategori
            // 
            btnAndraKategori.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAndraKategori.ForeColor = Color.FromArgb(0, 0, 64);
            btnAndraKategori.Location = new Point(857, 90);
            btnAndraKategori.Margin = new Padding(3, 2, 3, 2);
            btnAndraKategori.Name = "btnAndraKategori";
            btnAndraKategori.Size = new Size(82, 22);
            btnAndraKategori.TabIndex = 9;
            btnAndraKategori.Text = "Ändra";
            btnAndraKategori.UseVisualStyleBackColor = true;
            btnAndraKategori.Click += btnAndraKategori_Click;
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTaBortKategori.ForeColor = Color.FromArgb(0, 0, 64);
            btnTaBortKategori.Location = new Point(944, 90);
            btnTaBortKategori.Margin = new Padding(3, 2, 3, 2);
            btnTaBortKategori.Name = "btnTaBortKategori";
            btnTaBortKategori.Size = new Size(82, 22);
            btnTaBortKategori.TabIndex = 10;
            btnTaBortKategori.Text = "Ta bort";
            btnTaBortKategori.UseVisualStyleBackColor = true;
            btnTaBortKategori.Click += btnTaBortKategori_Click;
            // 
            // btnLaggTillFlode
            // 
            btnLaggTillFlode.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLaggTillFlode.ForeColor = Color.FromArgb(0, 0, 64);
            btnLaggTillFlode.Location = new Point(251, 127);
            btnLaggTillFlode.Margin = new Padding(3, 2, 3, 2);
            btnLaggTillFlode.Name = "btnLaggTillFlode";
            btnLaggTillFlode.Size = new Size(86, 22);
            btnLaggTillFlode.TabIndex = 11;
            btnLaggTillFlode.Text = "Lägg till";
            btnLaggTillFlode.UseVisualStyleBackColor = true;
            btnLaggTillFlode.Click += btnLaggTillFlode_Click;
            // 
            // btnAndraFlode
            // 
            btnAndraFlode.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAndraFlode.ForeColor = Color.FromArgb(0, 0, 64);
            btnAndraFlode.Location = new Point(342, 127);
            btnAndraFlode.Margin = new Padding(3, 2, 3, 2);
            btnAndraFlode.Name = "btnAndraFlode";
            btnAndraFlode.Size = new Size(74, 22);
            btnAndraFlode.TabIndex = 12;
            btnAndraFlode.Text = "Ändra";
            btnAndraFlode.UseVisualStyleBackColor = true;
            btnAndraFlode.Click += btnAndraFlode_Click;
            // 
            // btnTaBortFlode
            // 
            btnTaBortFlode.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTaBortFlode.ForeColor = Color.FromArgb(0, 0, 64);
            btnTaBortFlode.Location = new Point(421, 127);
            btnTaBortFlode.Margin = new Padding(3, 2, 3, 2);
            btnTaBortFlode.Name = "btnTaBortFlode";
            btnTaBortFlode.Size = new Size(80, 22);
            btnTaBortFlode.TabIndex = 13;
            btnTaBortFlode.Text = "Ta bort";
            btnTaBortFlode.UseVisualStyleBackColor = true;
            btnTaBortFlode.Click += btnTaBortFlode_Click;
            // 
            // btnAterstall
            // 
            btnAterstall.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAterstall.ForeColor = Color.FromArgb(0, 0, 64);
            btnAterstall.Location = new Point(251, 65);
            btnAterstall.Margin = new Padding(3, 2, 3, 2);
            btnAterstall.Name = "btnAterstall";
            btnAterstall.Size = new Size(101, 22);
            btnAterstall.TabIndex = 14;
            btnAterstall.Text = "Återställ";
            btnAterstall.UseVisualStyleBackColor = true;
            btnAterstall.Click += btnAterstall_Click;
            // 
            // cmbFiltrera
            // 
            cmbFiltrera.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFiltrera.ForeColor = Color.FromArgb(0, 0, 64);
            cmbFiltrera.FormattingEnabled = true;
            cmbFiltrera.Location = new Point(251, 34);
            cmbFiltrera.Margin = new Padding(3, 2, 3, 2);
            cmbFiltrera.Name = "cmbFiltrera";
            cmbFiltrera.Size = new Size(130, 21);
            cmbFiltrera.TabIndex = 15;
            cmbFiltrera.Text = "Filtrera...";
            cmbFiltrera.SelectedIndexChanged += cmbFiltrera_SelectedIndexChanged;
            // 
            // cmbKategori
            // 
            cmbKategori.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbKategori.ForeColor = Color.FromArgb(0, 0, 64);
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(251, 94);
            cmbKategori.Margin = new Padding(3, 2, 3, 2);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(130, 21);
            cmbKategori.TabIndex = 16;
            cmbKategori.Text = "Kategori...";
            // 
            // lstbxKategorier
            // 
            lstbxKategorier.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstbxKategorier.ForeColor = Color.FromArgb(0, 0, 64);
            lstbxKategorier.FormattingEnabled = true;
            lstbxKategorier.Location = new Point(769, 131);
            lstbxKategorier.Margin = new Padding(3, 2, 3, 2);
            lstbxKategorier.Name = "lstbxKategorier";
            lstbxKategorier.Size = new Size(258, 95);
            lstbxKategorier.TabIndex = 17;
            lstbxKategorier.SelectedIndexChanged += lstbxKategorier_SelectedIndexChanged;
            // 
            // listViewPodd
            // 
            listViewPodd.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader6 });
            listViewPodd.FullRowSelect = true;
            listViewPodd.Location = new Point(36, 166);
            listViewPodd.Margin = new Padding(3, 2, 3, 2);
            listViewPodd.Name = "listViewPodd";
            listViewPodd.Size = new Size(465, 203);
            listViewPodd.TabIndex = 20;
            listViewPodd.UseCompatibleStateImageBehavior = false;
            listViewPodd.View = View.Details;
            listViewPodd.SelectedIndexChanged += listViewPodd_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Titel";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Namn";
            columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Antal Avsnitt";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Kategori";
            columnHeader4.Width = 110;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Intervall";
            columnHeader6.Width = 100;
            // 
            // listViewAvsnitt
            // 
            listViewAvsnitt.Columns.AddRange(new ColumnHeader[] { columnHeader5 });
            listViewAvsnitt.FullRowSelect = true;
            listViewAvsnitt.Location = new Point(519, 83);
            listViewAvsnitt.Margin = new Padding(3, 2, 3, 2);
            listViewAvsnitt.Name = "listViewAvsnitt";
            listViewAvsnitt.Size = new Size(228, 285);
            listViewAvsnitt.TabIndex = 21;
            listViewAvsnitt.UseCompatibleStateImageBehavior = false;
            listViewAvsnitt.View = View.Details;
            listViewAvsnitt.SelectedIndexChanged += listViewAvsnitt_SelectedIndexChanged;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Avsnitt";
            columnHeader5.Width = 260;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(770, 256);
            textBoxDescription.Margin = new Padding(3, 2, 3, 2);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(257, 112);
            textBoxDescription.TabIndex = 22;
            // 
            // cmbIntervall
            // 
            cmbIntervall.FormattingEnabled = true;
            cmbIntervall.Items.AddRange(new object[] { "5 min", "7 min", "10 min" });
            cmbIntervall.Location = new Point(400, 34);
            cmbIntervall.Margin = new Padding(3, 2, 3, 2);
            cmbIntervall.Name = "cmbIntervall";
            cmbIntervall.Size = new Size(101, 23);
            cmbIntervall.TabIndex = 23;
            cmbIntervall.Text = "Intervall. . . ";
            // 
            // btnRensa
            // 
            btnRensa.Location = new Point(400, 94);
            btnRensa.Name = "btnRensa";
            btnRensa.Size = new Size(75, 23);
            btnRensa.TabIndex = 24;
            btnRensa.Text = "Rensa fält";
            btnRensa.UseVisualStyleBackColor = true;
            btnRensa.Click += btnRensa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1074, 398);
            Controls.Add(btnRensa);
            Controls.Add(cmbIntervall);
            Controls.Add(textBoxDescription);
            Controls.Add(listViewAvsnitt);
            Controls.Add(listViewPodd);
            Controls.Add(lstbxKategorier);
            Controls.Add(cmbKategori);
            Controls.Add(cmbFiltrera);
            Controls.Add(btnAterstall);
            Controls.Add(btnTaBortFlode);
            Controls.Add(btnAndraFlode);
            Controls.Add(btnLaggTillFlode);
            Controls.Add(btnTaBortKategori);
            Controls.Add(btnAndraKategori);
            Controls.Add(btnLaggTillKategori);
            Controls.Add(txtKategoriInput);
            Controls.Add(txtUrl);
            Controls.Add(txtNamn);
            Controls.Add(lblKategori);
            Controls.Add(lblAvsnitt);
            Controls.Add(lblUrl);
            Controls.Add(lblNamn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNamn;
        private Label lblUrl;
        private Label lblAvsnitt;
        private Label lblKategori;
        private TextBox txtNamn;
        private TextBox txtUrl;
        private TextBox txtKategoriInput;
        private Button btnLaggTillKategori;
        private Button btnAndraKategori;
        private Button btnTaBortKategori;
        private Button btnLaggTillFlode;
        private Button btnAndraFlode;
        private Button btnTaBortFlode;
        private Button btnAterstall;
        private ComboBox cmbFiltrera;
        private ComboBox cmbKategori;
        private ListBox lstbxKategorier;
        private ListView listViewPodd;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listViewAvsnitt;
        private ColumnHeader columnHeader5;
        private TextBox textBoxDescription;
        private ComboBox cmbIntervall;
        private ColumnHeader columnHeader6;
        private Button btnRensa;
    }
}