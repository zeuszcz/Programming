
namespace EstablishmentsApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EstablishmentsListBox = new System.Windows.Forms.ListBox();
            this.SelectedEstablishmentGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.СategoryLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RemoveEstablishmentButton = new System.Windows.Forms.Button();
            this.AddEstablishmentButton = new System.Windows.Forms.Button();
            this.SelectedEstablishmentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EstablishmentsListBox
            // 
            this.EstablishmentsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EstablishmentsListBox.FormattingEnabled = true;
            this.EstablishmentsListBox.Location = new System.Drawing.Point(12, 12);
            this.EstablishmentsListBox.Name = "EstablishmentsListBox";
            this.EstablishmentsListBox.Size = new System.Drawing.Size(242, 394);
            this.EstablishmentsListBox.TabIndex = 0;
            this.EstablishmentsListBox.SelectedIndexChanged += new System.EventHandler(this.EstablishmentsListBox_SelectedIndexChanged);
            // 
            // SelectedEstablishmentGroupBox
            // 
            this.SelectedEstablishmentGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedEstablishmentGroupBox.Controls.Add(this.CategoryComboBox);
            this.SelectedEstablishmentGroupBox.Controls.Add(this.AddressTextBox);
            this.SelectedEstablishmentGroupBox.Controls.Add(this.RatingTextBox);
            this.SelectedEstablishmentGroupBox.Controls.Add(this.NameTextBox);
            this.SelectedEstablishmentGroupBox.Controls.Add(this.RatingLabel);
            this.SelectedEstablishmentGroupBox.Controls.Add(this.СategoryLabel);
            this.SelectedEstablishmentGroupBox.Controls.Add(this.AddressLabel);
            this.SelectedEstablishmentGroupBox.Controls.Add(this.NameLabel);
            this.SelectedEstablishmentGroupBox.Location = new System.Drawing.Point(260, 12);
            this.SelectedEstablishmentGroupBox.Name = "SelectedEstablishmentGroupBox";
            this.SelectedEstablishmentGroupBox.Size = new System.Drawing.Size(528, 124);
            this.SelectedEstablishmentGroupBox.TabIndex = 1;
            this.SelectedEstablishmentGroupBox.TabStop = false;
            this.SelectedEstablishmentGroupBox.Text = "Selected Establishment";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(81, 97);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(222, 21);
            this.CategoryComboBox.TabIndex = 9;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            this.CategoryComboBox.Leave += new System.EventHandler(this.CategoryComboBox_Leave);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(81, 45);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(222, 20);
            this.AddressTextBox.TabIndex = 8;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.RatingTextBox.Location = new System.Drawing.Point(81, 71);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(222, 20);
            this.RatingTextBox.TabIndex = 7;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameTextBox.Location = new System.Drawing.Point(81, 19);
            this.NameTextBox.MaxLength = 150;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(441, 20);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.NameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(6, 74);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingLabel.TabIndex = 3;
            this.RatingLabel.Text = "Rating:";
            // 
            // СategoryLabel
            // 
            this.СategoryLabel.AutoSize = true;
            this.СategoryLabel.Location = new System.Drawing.Point(6, 100);
            this.СategoryLabel.Name = "СategoryLabel";
            this.СategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.СategoryLabel.TabIndex = 2;
            this.СategoryLabel.Text = "Сategory:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(6, 48);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 1;
            this.AddressLabel.Text = "Address:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 22);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // RemoveEstablishmentButton
            // 
            this.RemoveEstablishmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveEstablishmentButton.BackgroundImage = global::ContactsApp.Properties.Resources.EstablishmentsApp_cancel;
            this.RemoveEstablishmentButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RemoveEstablishmentButton.FlatAppearance.BorderSize = 0;
            this.RemoveEstablishmentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RemoveEstablishmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RemoveEstablishmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveEstablishmentButton.Location = new System.Drawing.Point(49, 412);
            this.RemoveEstablishmentButton.Name = "RemoveEstablishmentButton";
            this.RemoveEstablishmentButton.Size = new System.Drawing.Size(30, 28);
            this.RemoveEstablishmentButton.TabIndex = 3;
            this.RemoveEstablishmentButton.UseVisualStyleBackColor = true;
            this.RemoveEstablishmentButton.Click += new System.EventHandler(this.RemoveEstablishmentButton_Click);
            // 
            // AddEstablishmentButton
            // 
            this.AddEstablishmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddEstablishmentButton.BackgroundImage = global::ContactsApp.Properties.Resources.EstablishmentsApp_add;
            this.AddEstablishmentButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddEstablishmentButton.FlatAppearance.BorderSize = 0;
            this.AddEstablishmentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddEstablishmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddEstablishmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEstablishmentButton.Location = new System.Drawing.Point(12, 412);
            this.AddEstablishmentButton.Name = "AddEstablishmentButton";
            this.AddEstablishmentButton.Size = new System.Drawing.Size(31, 31);
            this.AddEstablishmentButton.TabIndex = 2;
            this.AddEstablishmentButton.UseVisualStyleBackColor = true;
            this.AddEstablishmentButton.Click += new System.EventHandler(this.AddEstablishmentButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.RemoveEstablishmentButton);
            this.Controls.Add(this.AddEstablishmentButton);
            this.Controls.Add(this.SelectedEstablishmentGroupBox);
            this.Controls.Add(this.EstablishmentsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "EstablishmentsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SelectedEstablishmentGroupBox.ResumeLayout(false);
            this.SelectedEstablishmentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox EstablishmentsListBox;
        private System.Windows.Forms.GroupBox SelectedEstablishmentGroupBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label СategoryLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Button AddEstablishmentButton;
        private System.Windows.Forms.Button RemoveEstablishmentButton;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
    }
}

