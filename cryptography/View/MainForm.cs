using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cryptography.Logic;
using System.IO;
namespace cryptography.View
{
    public partial class MainForm : Form
    {
        private string key = "";

        public MainForm()
        {
            InitializeComponent();
        }


       /* private void LoadPicture(PictureBox pbox)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbox.ImageLocation = openFileDialog.FileName;
            }
        }
        */
        private void save(RichTextBox txtbox)
        {
            saveFileDialog.DefaultExt = "*.RTF";
            saveFileDialog.Filter = "RTF Files|*.rtf";
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && (saveFileDialog.FileName.Length > 0))
            {
                try
                {
                    // Save the contents of the RichTextBox into the file. 

                    txtbox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }

                catch (Exception)
                {
                    MessageBox.Show("Файлът не беше съхранен, поради грешка в записа!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private string load(RichTextBox txtbox)
        {
            openFileDialog.DefaultExt = "*.rtf";
            openFileDialog.Filter = "RTF Files|*.rtf";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && (openFileDialog.FileName.Length > 0))
            {
                StreamReader reader = new StreamReader(openFileDialog.FileName, Encoding.GetEncoding(1251));
                return txtbox.Text = reader.ReadToEnd();

            }
            else return null;
        }

        private void clear(RichTextBox txtbox)
        {
            txtbox.Text = "";
        }
        private void click_en(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "Save To File")
            {
                save(rich_txtbox_message);
            }



            if (btn.Text == "Load From File")
            {
                rich_txtbox_message.Text = load(rich_txtbox_message);
            }

            if (btn.Text == "Clear Message")
            {
                clear(rich_txtbox_message);
            }

         /*   if (btn.Text == "Open Pic")
            {
                LoadPicture(pic_box_original);
            }
            */
            if (btn.Text == "Caesar's cipher")
            {
                string text = rich_txtbox_message.Text;
                if (text == "") MessageBox.Show("You haven't entered any message for encryption.", "Error");
                else
                {
                    SubstitutionalEncryptionAlgorithms ob = new SubstitutionalEncryptionAlgorithms(text);
                    rich_txtbox_encrypted_message.Text = ob.CaesarsCipherEncrypt();
                }
            }

            if (btn.Text == "Direct Substitution")
            {
                string text = rich_txtbox_message.Text;
                SubstitutionalEncryptionAlgorithms ob = new SubstitutionalEncryptionAlgorithms(text);
                if (text == "") MessageBox.Show("You haven't entered any message for encryption.", "Error");

                else
                {
                    DialogResult result = MessageBox.Show("Would you like to encode the space?", "Space encryption", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                        rich_txtbox_encrypted_message.Text = ob.DirectSubstitutionEncrypt(true);
                    }
                    else
                    {
                        rich_txtbox_encrypted_message.Text = ob.DirectSubstitutionEncrypt(false);
                    }
                }
            }

            if (btn.Text == "Alphabetical Sub")
            {
                string text = rich_txtbox_message.Text;
                SubstitutionalEncryptionAlgorithms ob = new SubstitutionalEncryptionAlgorithms(text);
                if (text == "") MessageBox.Show("You haven't entered any message for encryption.", "Error");

                else
                {
                    using (EnterKeyForm form = new EnterKeyForm())
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            key = form.getKey();
                        }
                        else MessageBox.Show("You haven't entered key for encryption.", "Error");

                    if (key == "") MessageBox.Show("You haven't entered key for encryption.", "Error");
                    else
                    {

                        if (key != null) rich_txtbox_encrypted_message.Text = ob.MultiAlphabeticalSubstitutionEncrypt(key);

                    }
                }

            }
            if (btn.Text == "Matrix Sub")
            {
                string text = rich_txtbox_message.Text;
                SubstitutionalEncryptionAlgorithms ob = new SubstitutionalEncryptionAlgorithms(text);
                if (text == "") MessageBox.Show("You haven't entered any message for encryption.", "Error");

                else
                {
                    using (EnterKeyForm form = new EnterKeyForm())
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            key = form.getKey();
                        }
                        else MessageBox.Show("You haven't entered key for encryption.", "Error");

                    if (key == "") MessageBox.Show("You haven't entered key for encryption.", "Error");
                    else
                    {

                        if (key != null) rich_txtbox_encrypted_message.Text = ob.MatrixSubstitutionEncrypt(key);

                    }
                }

                

            }
            
        }

        private void click_de(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            if (btn.Text == "Clear Encryption")
            {
                clear(rich_txtbox_encrypted_message);

            }

            if (btn.Text == "Save To File")
            {
                save(rich_txtbox_encrypted_message);
            }

            if (btn.Text == "Open Pic")
            {
                LoadPicture(pic_box_encoded);
            }

            if (btn.Text == "Load From File")
            {

                rich_txtbox_encrypted_message.Text = load(rich_txtbox_encrypted_message);
            }

            if (btn.Text == "Caesar's cipher")
            {
                string text = rich_txtbox_encrypted_message.Text;
                SubstitutionalEncryptionAlgorithms ob = new SubstitutionalEncryptionAlgorithms(text);
                if (text == "") MessageBox.Show("You haven't entered any message for decryption.", "Error");
                else rich_txtbox_message.Text = ob.CaesarsCipherDecrypt();
            }

            if (btn.Text == "Direct Substitution")
            {

                string text = rich_txtbox_encrypted_message.Text;
                SubstitutionalEncryptionAlgorithms ob = new SubstitutionalEncryptionAlgorithms(text);
                if (text == "") MessageBox.Show("You haven't entered any message for decryption.", "Error");
                else rich_txtbox_message.Text = ob.DirectSubstitutionDecrypt();
            }

            if (btn.Text == "Alphabetical Sub")
            {
                string text = rich_txtbox_encrypted_message.Text;
                SubstitutionalEncryptionAlgorithms ob = new SubstitutionalEncryptionAlgorithms(text);
                if (text == "") MessageBox.Show("You haven't entered any message for encryption.", "Error");

                else
                {
                    using (EnterKeyForm form = new EnterKeyForm())
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            key = form.getKey();
                        }
                        else MessageBox.Show("You haven't entered key for encryption.", "Error");
                    if (key == "") MessageBox.Show("You haven't entered key for encryption.", "Error");
                    else
                    {
                        if (key != null) rich_txtbox_message.Text = ob.MultiAlphabeticalSubstitutionDecrypt(key);

                    }
                }
            }
            if (btn.Text == "Matrix Sub")
            {
                string text = rich_txtbox_encrypted_message.Text;
                SubstitutionalEncryptionAlgorithms ob = new SubstitutionalEncryptionAlgorithms(text);
                if (text == "") MessageBox.Show("You haven't entered any message for encryption.", "Error");

                else
                {
                    using (EnterKeyForm form = new EnterKeyForm())
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            key = form.getKey();
                        }
                        else MessageBox.Show("You haven't entered key for encryption.", "Error");

                    if (key == "") MessageBox.Show("You haven't entered key for encryption.", "Error");
                    else
                    {

                        if (key != null) rich_txtbox_message.Text = ob.MatrixSubstitutionDecrypt(key);

                    }
                }

            }
        }

    }
}
