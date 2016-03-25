namespace cryptography.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabCtrl_app = new System.Windows.Forms.TabControl();
            this.tab_page_substitutional = new System.Windows.Forms.TabPage();
            this.groupBoxDecryption = new System.Windows.Forms.GroupBox();
            this.btn_matrix_sub_de = new System.Windows.Forms.Button();
            this.btn_clear_en_txt = new System.Windows.Forms.Button();
            this.btn_encrypted_text_save = new System.Windows.Forms.Button();
            this.btn_encrypted_text_load = new System.Windows.Forms.Button();
            this.btn_multi_alphabetical_sub_de = new System.Windows.Forms.Button();
            this.btn_direct_substitution_de = new System.Windows.Forms.Button();
            this.btn_caesars_cipher_de = new System.Windows.Forms.Button();
            this.lbl_encrypted_text = new System.Windows.Forms.Label();
            this.lbl_direct_text = new System.Windows.Forms.Label();
            this.groupBoxEncryption = new System.Windows.Forms.GroupBox();
            this.btn_matrix_sub_en = new System.Windows.Forms.Button();
            this.btn_clear_de_txt = new System.Windows.Forms.Button();
            this.btn_decrypted_text_save = new System.Windows.Forms.Button();
            this.btn_decrypted_text_load = new System.Windows.Forms.Button();
            this.btn_multi_alphabetical_sub_en = new System.Windows.Forms.Button();
            this.btn_direct_substitution_en = new System.Windows.Forms.Button();
            this.btn_caesars_cipher_en = new System.Windows.Forms.Button();
            this.rich_txtbox_encrypted_message = new System.Windows.Forms.RichTextBox();
            this.rich_txtbox_message = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabCtrl_app.SuspendLayout();
            this.tab_page_substitutional.SuspendLayout();
            this.groupBoxDecryption.SuspendLayout();
            this.groupBoxEncryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl_app
            // 
            this.tabCtrl_app.Controls.Add(this.tab_page_substitutional);
            this.tabCtrl_app.Location = new System.Drawing.Point(12, 12);
            this.tabCtrl_app.Name = "tabCtrl_app";
            this.tabCtrl_app.SelectedIndex = 0;
            this.tabCtrl_app.Size = new System.Drawing.Size(573, 388);
            this.tabCtrl_app.TabIndex = 0;
            // 
            // tab_page_substitutional
            // 
            this.tab_page_substitutional.BackColor = System.Drawing.Color.Gray;
            this.tab_page_substitutional.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab_page_substitutional.BackgroundImage")));
            this.tab_page_substitutional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_page_substitutional.Controls.Add(this.groupBoxDecryption);
            this.tab_page_substitutional.Controls.Add(this.lbl_encrypted_text);
            this.tab_page_substitutional.Controls.Add(this.lbl_direct_text);
            this.tab_page_substitutional.Controls.Add(this.groupBoxEncryption);
            this.tab_page_substitutional.Controls.Add(this.rich_txtbox_encrypted_message);
            this.tab_page_substitutional.Controls.Add(this.rich_txtbox_message);
            this.tab_page_substitutional.Location = new System.Drawing.Point(4, 22);
            this.tab_page_substitutional.Name = "tab_page_substitutional";
            this.tab_page_substitutional.Padding = new System.Windows.Forms.Padding(3);
            this.tab_page_substitutional.Size = new System.Drawing.Size(565, 362);
            this.tab_page_substitutional.TabIndex = 0;
            this.tab_page_substitutional.Text = "Substitutional Methods";
            // 
            // groupBoxDecryption
            // 
            this.groupBoxDecryption.BackColor = System.Drawing.Color.Silver;
            this.groupBoxDecryption.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxDecryption.BackgroundImage")));
            this.groupBoxDecryption.Controls.Add(this.btn_matrix_sub_de);
            this.groupBoxDecryption.Controls.Add(this.btn_clear_en_txt);
            this.groupBoxDecryption.Controls.Add(this.btn_encrypted_text_save);
            this.groupBoxDecryption.Controls.Add(this.btn_encrypted_text_load);
            this.groupBoxDecryption.Controls.Add(this.btn_multi_alphabetical_sub_de);
            this.groupBoxDecryption.Controls.Add(this.btn_direct_substitution_de);
            this.groupBoxDecryption.Controls.Add(this.btn_caesars_cipher_de);
            this.groupBoxDecryption.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxDecryption.Location = new System.Drawing.Point(293, 197);
            this.groupBoxDecryption.Name = "groupBoxDecryption";
            this.groupBoxDecryption.Size = new System.Drawing.Size(266, 159);
            this.groupBoxDecryption.TabIndex = 21;
            this.groupBoxDecryption.TabStop = false;
            this.groupBoxDecryption.Text = "Decrypt Using";
            // 
            // btn_matrix_sub_de
            // 
            this.btn_matrix_sub_de.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_matrix_sub_de.Location = new System.Drawing.Point(21, 114);
            this.btn_matrix_sub_de.Name = "btn_matrix_sub_de";
            this.btn_matrix_sub_de.Size = new System.Drawing.Size(101, 26);
            this.btn_matrix_sub_de.TabIndex = 23;
            this.btn_matrix_sub_de.Text = "Matrix Sub";
            this.btn_matrix_sub_de.UseVisualStyleBackColor = true;
            this.btn_matrix_sub_de.Click += new System.EventHandler(this.click_de);
            // 
            // btn_clear_en_txt
            // 
            this.btn_clear_en_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear_en_txt.Location = new System.Drawing.Point(152, 94);
            this.btn_clear_en_txt.Name = "btn_clear_en_txt";
            this.btn_clear_en_txt.Size = new System.Drawing.Size(93, 26);
            this.btn_clear_en_txt.TabIndex = 22;
            this.btn_clear_en_txt.Text = "Clear Encryption";
            this.btn_clear_en_txt.UseVisualStyleBackColor = true;
            this.btn_clear_en_txt.Click += new System.EventHandler(this.click_de);
            // 
            // btn_encrypted_text_save
            // 
            this.btn_encrypted_text_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_encrypted_text_save.Location = new System.Drawing.Point(152, 62);
            this.btn_encrypted_text_save.Name = "btn_encrypted_text_save";
            this.btn_encrypted_text_save.Size = new System.Drawing.Size(93, 26);
            this.btn_encrypted_text_save.TabIndex = 18;
            this.btn_encrypted_text_save.Text = "Save To File";
            this.btn_encrypted_text_save.UseVisualStyleBackColor = true;
            this.btn_encrypted_text_save.Click += new System.EventHandler(this.click_de);
            // 
            // btn_encrypted_text_load
            // 
            this.btn_encrypted_text_load.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_encrypted_text_load.Location = new System.Drawing.Point(152, 30);
            this.btn_encrypted_text_load.Name = "btn_encrypted_text_load";
            this.btn_encrypted_text_load.Size = new System.Drawing.Size(93, 26);
            this.btn_encrypted_text_load.TabIndex = 17;
            this.btn_encrypted_text_load.Text = "Load From File";
            this.btn_encrypted_text_load.UseVisualStyleBackColor = true;
            this.btn_encrypted_text_load.Click += new System.EventHandler(this.click_de);
            // 
            // btn_multi_alphabetical_sub_de
            // 
            this.btn_multi_alphabetical_sub_de.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_multi_alphabetical_sub_de.Location = new System.Drawing.Point(21, 83);
            this.btn_multi_alphabetical_sub_de.Name = "btn_multi_alphabetical_sub_de";
            this.btn_multi_alphabetical_sub_de.Size = new System.Drawing.Size(101, 26);
            this.btn_multi_alphabetical_sub_de.TabIndex = 16;
            this.btn_multi_alphabetical_sub_de.Text = "Alphabetical Sub";
            this.btn_multi_alphabetical_sub_de.UseVisualStyleBackColor = true;
            this.btn_multi_alphabetical_sub_de.Click += new System.EventHandler(this.click_de);
            // 
            // btn_direct_substitution_de
            // 
            this.btn_direct_substitution_de.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_direct_substitution_de.Location = new System.Drawing.Point(21, 51);
            this.btn_direct_substitution_de.Name = "btn_direct_substitution_de";
            this.btn_direct_substitution_de.Size = new System.Drawing.Size(101, 26);
            this.btn_direct_substitution_de.TabIndex = 15;
            this.btn_direct_substitution_de.Text = "Direct Substitution";
            this.btn_direct_substitution_de.UseVisualStyleBackColor = true;
            this.btn_direct_substitution_de.Click += new System.EventHandler(this.click_de);
            // 
            // btn_caesars_cipher_de
            // 
            this.btn_caesars_cipher_de.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_caesars_cipher_de.Location = new System.Drawing.Point(21, 19);
            this.btn_caesars_cipher_de.Name = "btn_caesars_cipher_de";
            this.btn_caesars_cipher_de.Size = new System.Drawing.Size(101, 26);
            this.btn_caesars_cipher_de.TabIndex = 13;
            this.btn_caesars_cipher_de.Text = "Caesar\'s cipher";
            this.btn_caesars_cipher_de.UseVisualStyleBackColor = true;
            this.btn_caesars_cipher_de.Click += new System.EventHandler(this.click_de);
            // 
            // lbl_encrypted_text
            // 
            this.lbl_encrypted_text.AutoSize = true;
            this.lbl_encrypted_text.BackColor = System.Drawing.Color.Transparent;
            this.lbl_encrypted_text.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_encrypted_text.Location = new System.Drawing.Point(23, 187);
            this.lbl_encrypted_text.Name = "lbl_encrypted_text";
            this.lbl_encrypted_text.Size = new System.Drawing.Size(101, 13);
            this.lbl_encrypted_text.TabIndex = 22;
            this.lbl_encrypted_text.Text = "Encrypted Message";
            // 
            // lbl_direct_text
            // 
            this.lbl_direct_text.AutoSize = true;
            this.lbl_direct_text.BackColor = System.Drawing.Color.Transparent;
            this.lbl_direct_text.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_direct_text.Location = new System.Drawing.Point(23, 17);
            this.lbl_direct_text.Name = "lbl_direct_text";
            this.lbl_direct_text.Size = new System.Drawing.Size(50, 13);
            this.lbl_direct_text.TabIndex = 21;
            this.lbl_direct_text.Text = "Message";
            // 
            // groupBoxEncryption
            // 
            this.groupBoxEncryption.BackColor = System.Drawing.Color.Silver;
            this.groupBoxEncryption.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxEncryption.BackgroundImage")));
            this.groupBoxEncryption.Controls.Add(this.btn_matrix_sub_en);
            this.groupBoxEncryption.Controls.Add(this.btn_clear_de_txt);
            this.groupBoxEncryption.Controls.Add(this.btn_decrypted_text_save);
            this.groupBoxEncryption.Controls.Add(this.btn_decrypted_text_load);
            this.groupBoxEncryption.Controls.Add(this.btn_multi_alphabetical_sub_en);
            this.groupBoxEncryption.Controls.Add(this.btn_direct_substitution_en);
            this.groupBoxEncryption.Controls.Add(this.btn_caesars_cipher_en);
            this.groupBoxEncryption.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxEncryption.Location = new System.Drawing.Point(293, 17);
            this.groupBoxEncryption.Name = "groupBoxEncryption";
            this.groupBoxEncryption.Size = new System.Drawing.Size(266, 154);
            this.groupBoxEncryption.TabIndex = 16;
            this.groupBoxEncryption.TabStop = false;
            this.groupBoxEncryption.Text = "Encrypt Using";
            // 
            // btn_matrix_sub_en
            // 
            this.btn_matrix_sub_en.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_matrix_sub_en.Location = new System.Drawing.Point(21, 114);
            this.btn_matrix_sub_en.Name = "btn_matrix_sub_en";
            this.btn_matrix_sub_en.Size = new System.Drawing.Size(101, 26);
            this.btn_matrix_sub_en.TabIndex = 22;
            this.btn_matrix_sub_en.Text = "Matrix Sub";
            this.btn_matrix_sub_en.UseVisualStyleBackColor = true;
            this.btn_matrix_sub_en.Click += new System.EventHandler(this.click_en);
            // 
            // btn_clear_de_txt
            // 
            this.btn_clear_de_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear_de_txt.Location = new System.Drawing.Point(152, 96);
            this.btn_clear_de_txt.Name = "btn_clear_de_txt";
            this.btn_clear_de_txt.Size = new System.Drawing.Size(93, 26);
            this.btn_clear_de_txt.TabIndex = 21;
            this.btn_clear_de_txt.Text = "Clear Message";
            this.btn_clear_de_txt.UseVisualStyleBackColor = true;
            this.btn_clear_de_txt.Click += new System.EventHandler(this.click_en);
            // 
            // btn_decrypted_text_save
            // 
            this.btn_decrypted_text_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_decrypted_text_save.Location = new System.Drawing.Point(152, 64);
            this.btn_decrypted_text_save.Name = "btn_decrypted_text_save";
            this.btn_decrypted_text_save.Size = new System.Drawing.Size(93, 26);
            this.btn_decrypted_text_save.TabIndex = 18;
            this.btn_decrypted_text_save.Text = "Save To File";
            this.btn_decrypted_text_save.UseVisualStyleBackColor = true;
            this.btn_decrypted_text_save.Click += new System.EventHandler(this.click_en);
            // 
            // btn_decrypted_text_load
            // 
            this.btn_decrypted_text_load.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_decrypted_text_load.Location = new System.Drawing.Point(152, 32);
            this.btn_decrypted_text_load.Name = "btn_decrypted_text_load";
            this.btn_decrypted_text_load.Size = new System.Drawing.Size(93, 26);
            this.btn_decrypted_text_load.TabIndex = 17;
            this.btn_decrypted_text_load.Text = "Load From File";
            this.btn_decrypted_text_load.UseVisualStyleBackColor = true;
            this.btn_decrypted_text_load.Click += new System.EventHandler(this.click_en);
            // 
            // btn_multi_alphabetical_sub_en
            // 
            this.btn_multi_alphabetical_sub_en.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_multi_alphabetical_sub_en.Location = new System.Drawing.Point(21, 83);
            this.btn_multi_alphabetical_sub_en.Name = "btn_multi_alphabetical_sub_en";
            this.btn_multi_alphabetical_sub_en.Size = new System.Drawing.Size(101, 26);
            this.btn_multi_alphabetical_sub_en.TabIndex = 16;
            this.btn_multi_alphabetical_sub_en.Text = "Alphabetical Sub";
            this.btn_multi_alphabetical_sub_en.UseVisualStyleBackColor = true;
            this.btn_multi_alphabetical_sub_en.Click += new System.EventHandler(this.click_en);
            // 
            // btn_direct_substitution_en
            // 
            this.btn_direct_substitution_en.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_direct_substitution_en.Location = new System.Drawing.Point(21, 51);
            this.btn_direct_substitution_en.Name = "btn_direct_substitution_en";
            this.btn_direct_substitution_en.Size = new System.Drawing.Size(101, 26);
            this.btn_direct_substitution_en.TabIndex = 15;
            this.btn_direct_substitution_en.Text = "Direct Substitution";
            this.btn_direct_substitution_en.UseVisualStyleBackColor = true;
            this.btn_direct_substitution_en.Click += new System.EventHandler(this.click_en);
            // 
            // btn_caesars_cipher_en
            // 
            this.btn_caesars_cipher_en.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_caesars_cipher_en.Location = new System.Drawing.Point(21, 19);
            this.btn_caesars_cipher_en.Name = "btn_caesars_cipher_en";
            this.btn_caesars_cipher_en.Size = new System.Drawing.Size(101, 26);
            this.btn_caesars_cipher_en.TabIndex = 13;
            this.btn_caesars_cipher_en.Text = "Caesar\'s cipher";
            this.btn_caesars_cipher_en.UseVisualStyleBackColor = true;
            this.btn_caesars_cipher_en.Click += new System.EventHandler(this.click_en);
            // 
            // rich_txtbox_encrypted_message
            // 
            this.rich_txtbox_encrypted_message.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rich_txtbox_encrypted_message.Location = new System.Drawing.Point(26, 216);
            this.rich_txtbox_encrypted_message.Name = "rich_txtbox_encrypted_message";
            this.rich_txtbox_encrypted_message.Size = new System.Drawing.Size(232, 122);
            this.rich_txtbox_encrypted_message.TabIndex = 1;
            this.rich_txtbox_encrypted_message.Text = "";
            // 
            // rich_txtbox_message
            // 
            this.rich_txtbox_message.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rich_txtbox_message.Location = new System.Drawing.Point(26, 40);
            this.rich_txtbox_message.Name = "rich_txtbox_message";
            this.rich_txtbox_message.Size = new System.Drawing.Size(232, 123);
            this.rich_txtbox_message.TabIndex = 0;
            this.rich_txtbox_message.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 410);
            this.Controls.Add(this.tabCtrl_app);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabCtrl_app.ResumeLayout(false);
            this.tab_page_substitutional.ResumeLayout(false);
            this.tab_page_substitutional.PerformLayout();
            this.groupBoxDecryption.ResumeLayout(false);
            this.groupBoxEncryption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl_app;
        private System.Windows.Forms.TabPage tab_page_substitutional;
        private System.Windows.Forms.GroupBox groupBoxEncryption;
        private System.Windows.Forms.Button btn_decrypted_text_save;
        private System.Windows.Forms.Button btn_decrypted_text_load;
        private System.Windows.Forms.Button btn_multi_alphabetical_sub_en;
        private System.Windows.Forms.Button btn_direct_substitution_en;
        private System.Windows.Forms.Button btn_caesars_cipher_en;
        private System.Windows.Forms.Label lbl_encrypted_text;
        private System.Windows.Forms.Label lbl_direct_text;
        private System.Windows.Forms.GroupBox groupBoxDecryption;
        private System.Windows.Forms.Button btn_encrypted_text_save;
        private System.Windows.Forms.Button btn_encrypted_text_load;
        private System.Windows.Forms.Button btn_multi_alphabetical_sub_de;
        private System.Windows.Forms.Button btn_direct_substitution_de;
        private System.Windows.Forms.Button btn_caesars_cipher_de;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btn_clear_en_txt;
        private System.Windows.Forms.Button btn_clear_de_txt;
        private System.Windows.Forms.RichTextBox rich_txtbox_encrypted_message;
        private System.Windows.Forms.RichTextBox rich_txtbox_message;
        private System.Windows.Forms.Button btn_matrix_sub_de;
        private System.Windows.Forms.Button btn_matrix_sub_en;

    }
}