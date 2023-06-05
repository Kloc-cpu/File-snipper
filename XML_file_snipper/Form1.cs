using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using System.Xml;
using System.ComponentModel;

namespace XML_File_Snipper
{
    
    public partial class Form1 : Form
    {
        public string XML_file_path;
        
        BackgroundWorker bw;

        public Form1()
        {
            InitializeComponent();
        }


        private void AppendText(string text)
        {
            if (Progress_output_text.InvokeRequired)
            {
                Progress_output_text.Invoke(new Action<string>(AppendText), text);
            }
            else
            {
                Progress_output_text.AppendText(text);
            }
        }

        public void create_file(string full_file_path, int Current_item_line)
        {
            using (XmlWriter writer = XmlWriter.Create(full_file_path))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("CNJExport");

                using (XmlReader reader = XmlReader.Create(XML_file_path))
                {
                    int itemCounter = 0;
                    // Loop through the XML file and copy selected items to the new file
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Item")
                        {
                            if (itemCounter >= Current_item_line && itemCounter < Current_item_line + Number_Of_Elements_Per_file.Value)
                            {
                                writer.WriteNode(reader, true);
                            }
                            itemCounter++;
                        }
                    }
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            Generate_Button.Enabled = false;

            // Start the background worker
            bw = new BackgroundWorker();
            bw.DoWork += (obj, ea) => TasksAsync(1);
            bw.RunWorkerCompleted += (obj, ea) => Generate_Button.Enabled = true; // Enable the button after the operation completes
            bw.RunWorkerAsync();
        }

        private async void TasksAsync(int times)
        {
            string Error_code_save = "", file_name_and_type = File_Path_Textbox.Text.Substring(File_Path_Textbox.Text.LastIndexOf('\\') + 1), full_file_path, file_name;
            int number_is_not_devisable = 0, total_items_in_XML = 0, Current_item_line = 0, filesCreated = 0, total_files_at_end;

            XML_file_path = File_Path_Textbox.Text;

            if (Number_Of_Elements_Per_file.Value == 0)
            {
                Error_code_save += "ERROR: Number of XML files cannot be zero\r";
            }
            else if (!string.IsNullOrEmpty(Error_code_save))
            {
                Progress_output_text.Invoke((MethodInvoker)delegate
                {
                    Progress_output_text.Text += "You set " + Number_Of_Elements_Per_file.Value + " items per file\r";
                });
            }

            if (string.IsNullOrEmpty(File_Path_Textbox.Text) || string.IsNullOrEmpty(File_Destination_Textbox.Text))
            {
                Error_code_save += "ERROR: Path and/or Destination have not been set, please set them and generate again";
            }

            if (!string.IsNullOrEmpty(Error_code_save))
            {
                MessageBox.Show(Error_code_save);
                return;
            }

            file_name = file_name_and_type.Substring(0, file_name_and_type.Length - 4);

            using (XmlReader reader = XmlReader.Create(XML_file_path))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Item")
                        total_items_in_XML++;
                }
            }

            if (total_items_in_XML % Number_Of_Elements_Per_file.Value > 0)
            {
                number_is_not_devisable = 1;
            }

            total_files_at_end = (int)Math.Ceiling(total_items_in_XML / Number_Of_Elements_Per_file.Value);

            for (int i = 1; i <= total_files_at_end; i++)
            {
                int progressValue = (int)(i * 100.0 / total_files_at_end);

                progressBar1.Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value = progressValue;
                });

                full_file_path = string.Concat(File_Destination_Textbox.Text, '\\', file_name, i, ".xml");
                try
                {
                    create_file(full_file_path, Current_item_line);

                    filesCreated++;

                    // Reset the progress bar after creating 10 files
                    if (filesCreated % 10 == 0)
                    {
                        await Task.Delay(2000); // Wait for 2 seconds
                        progressBar1.Invoke((MethodInvoker)delegate
                        {

                            progressBar1.Value = 0;
                        });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while creating the file: " + ex.Message);
                }

                Current_item_line += (int)Number_Of_Elements_Per_file.Value;
            }

            Progress_output_text.Invoke((MethodInvoker)delegate
            {
                Progress_output_text.Text += filesCreated + " files have been created in " + File_Destination_Textbox.Text + "\r\n";
            });
        }







        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var folderBrowserDialog = new FolderBrowserDialog())
                {

                    DialogResult result = folderBrowserDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string selectedPath = folderBrowserDialog.SelectedPath;

                        // Get the directory path of the selected file
                        string selectedFolderPath = System.IO.Path.GetDirectoryName(selectedPath);

                        // Update the TextBox with the selected file path
                        File_Destination_Textbox.Text = selectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening File Explorer: " + ex.Message);
            }
        }

        private void file_path_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "XML Files (*.xml)|*.xml";

                    DialogResult result = openFileDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string selectedFilePath = openFileDialog.FileName;

                        string selectedFolderPath = System.IO.Path.GetDirectoryName(selectedFilePath);

                        File_Path_Textbox.Text = selectedFilePath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening File Explorer: " + ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label_num_item_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}