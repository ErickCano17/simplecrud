
namespace simpleCRUD
{
    partial class frmBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dtPublishedDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtSubTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtTitle = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lNew = new MetroFramework.Controls.MetroLink();
            this.dtgBooks = new System.Windows.Forms.DataGridView();
            this.actions = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.tabForm = new MetroFramework.Controls.MetroTabPage();
            this.tabData = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBooks)).BeginInit();
            this.actions.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.tabData.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1289, 799);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(210, 229);
            this.txtISBN.Mask = "0000-0000-0000-0000";
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(220, 20);
            this.txtISBN.TabIndex = 25;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(83, 231);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 19);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "ISBN";
            // 
            // dtPublishedDate
            // 
            this.dtPublishedDate.CustomFormat = "0000-00-00";
            this.dtPublishedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPublishedDate.Location = new System.Drawing.Point(210, 165);
            this.dtPublishedDate.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtPublishedDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtPublishedDate.Name = "dtPublishedDate";
            this.dtPublishedDate.Size = new System.Drawing.Size(155, 29);
            this.dtPublishedDate.TabIndex = 21;
            this.dtPublishedDate.Value = new System.DateTime(1998, 12, 1, 0, 0, 0, 0);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(83, 165);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(96, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Published Date";
            // 
            // txtSubTitle
            // 
            // 
            // 
            // 
            this.txtSubTitle.CustomButton.Image = null;
            this.txtSubTitle.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.txtSubTitle.CustomButton.Name = "";
            this.txtSubTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubTitle.CustomButton.TabIndex = 1;
            this.txtSubTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubTitle.CustomButton.UseSelectable = true;
            this.txtSubTitle.CustomButton.Visible = false;
            this.txtSubTitle.Lines = new string[0];
            this.txtSubTitle.Location = new System.Drawing.Point(210, 115);
            this.txtSubTitle.MaxLength = 32767;
            this.txtSubTitle.Name = "txtSubTitle";
            this.txtSubTitle.PasswordChar = '\0';
            this.txtSubTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubTitle.SelectedText = "";
            this.txtSubTitle.SelectionLength = 0;
            this.txtSubTitle.SelectionStart = 0;
            this.txtSubTitle.ShortcutsEnabled = true;
            this.txtSubTitle.Size = new System.Drawing.Size(303, 23);
            this.txtSubTitle.TabIndex = 19;
            this.txtSubTitle.UseSelectable = true;
            this.txtSubTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(83, 115);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Subtitle";
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.CustomButton.Image = null;
            this.txtTitle.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.txtTitle.CustomButton.Name = "";
            this.txtTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitle.CustomButton.TabIndex = 1;
            this.txtTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitle.CustomButton.UseSelectable = true;
            this.txtTitle.CustomButton.Visible = false;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(210, 69);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(303, 23);
            this.txtTitle.TabIndex = 17;
            this.txtTitle.UseSelectable = true;
            this.txtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(210, 25);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ReadOnly = true;
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(101, 23);
            this.txtId.TabIndex = 16;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(83, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(33, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Title";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(83, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(54, 19);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Book Id";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(810, 472);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 28);
            this.btnExit.Style = MetroFramework.MetroColorStyle.White;
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseCustomBackColor = true;
            this.btnExit.UseSelectable = true;
            this.btnExit.UseStyleColors = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(65, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "BOOKS";
            // 
            // lNew
            // 
            this.lNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lNew.Location = new System.Drawing.Point(133, 27);
            this.lNew.Name = "lNew";
            this.lNew.Size = new System.Drawing.Size(75, 23);
            this.lNew.TabIndex = 29;
            this.lNew.Text = "| new book";
            this.lNew.UseSelectable = true;
            this.lNew.Click += new System.EventHandler(this.lNew_Click);
            // 
            // dtgBooks
            // 
            this.dtgBooks.AllowUserToAddRows = false;
            this.dtgBooks.AllowUserToDeleteRows = false;
            this.dtgBooks.AllowUserToResizeColumns = false;
            this.dtgBooks.AllowUserToResizeRows = false;
            this.dtgBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBooks.BackgroundColor = System.Drawing.Color.White;
            this.dtgBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBooks.ContextMenuStrip = this.actions;
            this.dtgBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgBooks.Location = new System.Drawing.Point(13, 17);
            this.dtgBooks.MultiSelect = false;
            this.dtgBooks.Name = "dtgBooks";
            this.dtgBooks.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgBooks.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBooks.Size = new System.Drawing.Size(772, 263);
            this.dtgBooks.TabIndex = 32;
            // 
            // actions
            // 
            this.actions.BackColor = System.Drawing.Color.White;
            this.actions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.actions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.actions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.actions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit,
            this.delete});
            this.actions.Name = "actions";
            this.actions.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.actions.ShowImageMargin = false;
            this.actions.Size = new System.Drawing.Size(93, 52);
            this.actions.Style = MetroFramework.MetroColorStyle.Blue;
            this.actions.Text = "Actions";
            this.actions.UseCustomBackColor = true;
            this.actions.UseCustomForeColor = true;
            this.actions.UseStyleColors = true;
            this.actions.UseWaitCursor = true;
            // 
            // edit
            // 
            this.edit.AutoToolTip = true;
            this.edit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(155, 24);
            this.edit.Text = "Edit";
            this.edit.ToolTipText = "Edit Book";
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.AutoToolTip = true;
            this.delete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(155, 24);
            this.delete.Text = "Delete";
            this.delete.ToolTipText = "Delete Book";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(503, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 33);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.White;
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(408, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 33);
            this.btnSave.Style = MetroFramework.MetroColorStyle.White;
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabForm);
            this.tabs.Controls.Add(this.tabData);
            this.tabs.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.tabs.Location = new System.Drawing.Point(75, 75);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(823, 374);
            this.tabs.TabIndex = 33;
            this.tabs.UseSelectable = true;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.btnCancel);
            this.tabForm.Controls.Add(this.btnSave);
            this.tabForm.Controls.Add(this.metroLabel4);
            this.tabForm.Controls.Add(this.lblId);
            this.tabForm.Controls.Add(this.dtPublishedDate);
            this.tabForm.Controls.Add(this.txtSubTitle);
            this.tabForm.Controls.Add(this.metroLabel2);
            this.tabForm.Controls.Add(this.metroLabel5);
            this.tabForm.Controls.Add(this.txtISBN);
            this.tabForm.Controls.Add(this.metroLabel3);
            this.tabForm.Controls.Add(this.txtId);
            this.tabForm.Controls.Add(this.txtTitle);
            this.tabForm.HorizontalScrollbarBarColor = true;
            this.tabForm.HorizontalScrollbarHighlightOnWheel = false;
            this.tabForm.HorizontalScrollbarSize = 10;
            this.tabForm.Location = new System.Drawing.Point(4, 34);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(815, 336);
            this.tabForm.TabIndex = 0;
            this.tabForm.Text = "BOOK FORM";
            this.tabForm.VerticalScrollbarBarColor = true;
            this.tabForm.VerticalScrollbarHighlightOnWheel = false;
            this.tabForm.VerticalScrollbarSize = 10;
            this.tabForm.Click += new System.EventHandler(this.tabForm_Click);
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.dtgBooks);
            this.tabData.HorizontalScrollbarBarColor = true;
            this.tabData.HorizontalScrollbarHighlightOnWheel = false;
            this.tabData.HorizontalScrollbarSize = 10;
            this.tabData.Location = new System.Drawing.Point(4, 34);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(815, 336);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "BOOK LIST";
            this.tabData.VerticalScrollbarBarColor = true;
            this.tabData.VerticalScrollbarHighlightOnWheel = false;
            this.tabData.VerticalScrollbarSize = 10;
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 535);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.lNew);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBook";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libary | Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBooks)).EndInit();
            this.actions.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.tabData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtISBN;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime dtPublishedDate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtSubTitle;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtTitle;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink lNew;
        private System.Windows.Forms.DataGridView dtgBooks;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTabControl tabs;
        private MetroFramework.Controls.MetroTabPage tabForm;
        private MetroFramework.Controls.MetroTabPage tabData;
        public MetroFramework.Controls.MetroContextMenu actions;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem delete;
    }
}

