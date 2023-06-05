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
        public string temp_path;

        public Form1()
        {
            InitializeComponent();
        }
        BackgroundWorker worker;

        BackgroundWorker bw;

        private void AppendText(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action<string>(AppendText), text);
            }
            else
            {
                richTextBox1.AppendText(text);
            }
        }


        

        private async void button1_Click(object sender, EventArgs e)
        {
            // Disable the button to prevent multiple clicks
            button1.Enabled = false;

            // Start the background worker
            bw = new BackgroundWorker();
            bw.DoWork += (obj, ea) => TasksAsync(1);
            bw.RunWorkerCompleted += (obj, ea) => button1.Enabled = true; // Enable the button after the operation completes
            bw.RunWorkerAsync();
        }

        private async void TasksAsync(int times)
        {
            string temporary_error_save = ""; // Used to later output all the errors at once instead of them being a pop-up for each error

            // Numericupdown1 trackers
            string path_file_name = file_path_textbox.Text.Substring(file_path_textbox.Text.LastIndexOf('\\') + 1); // Only has the name neki.xml
            temp_path = file_path_textbox.Text; // Saves XML file path
            string full_file_path, file_name;
            int check = 0;

            // Check if the number of XML files is zero
            if (numericUpDown1.Value == 0)
            {
                temporary_error_save += "ERROR: Number of XML files cannot be zero\r";
            }
            else if (!string.IsNullOrEmpty(temporary_error_save))
            {
                richTextBox1.Invoke((MethodInvoker)delegate {
                    richTextBox1.Text += "You set " + numericUpDown1.Value + " items per file\r";
                });
            }

            // Destination and path trackers 
            if (string.IsNullOrEmpty(file_path_textbox.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                temporary_error_save += "ERROR: Path and/or Destination have not been set, please set them and generate again";
            }

            // Display errors and return if there are any
            if (!string.IsNullOrEmpty(temporary_error_save))
            {
                MessageBox.Show(temporary_error_save);
                return; // Exit the function if there are errors
            }

            file_name = path_file_name.Substring(0, path_file_name.Length - 4);

            // Count the total number of items in the XML file
            int itemCount = 0;
            using (XmlReader reader = XmlReader.Create(temp_path))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Item")
                        itemCount++;
                }
            }

            // Check if the number of items is not divisible by the items per file
            if (itemCount % numericUpDown1.Value > 0)
            {
                check = 1;
            }

            int itemIndex = 0;
            int filesCreated = 0;

            // Calculate the total number of files to be created
            int totalFiles = (int)Math.Ceiling(itemCount / numericUpDown1.Value);

            // Loop to create multiple files based on the number of items per file
            for (int i = 1; i <= totalFiles; i++)
            {
                // Calculate the progress value based on the number of files created
                int progressValue = (int)(i * 100.0 / totalFiles);
                progressBar1.Invoke((MethodInvoker)delegate {
                    progressBar1.Value = progressValue;
                });

                full_file_path = string.Concat(textBox2.Text, '\\', file_name, i, ".xml");
                try
                {
                    // Create a new XML file
                    using (XmlWriter writer = XmlWriter.Create(full_file_path))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("CNJExport");

                        using (XmlReader reader = XmlReader.Create(temp_path))
                        {
                            int itemCounter = 0;
                            // Loop through the XML file and copy selected items to the new file
                            while (reader.Read())
                            {
                                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Item")
                                {
                                    if (itemCounter >= itemIndex && itemCounter < itemIndex + numericUpDown1.Value)
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

                    // Increment the files created count
                    filesCreated++;

                    // Reset the progress bar after creating 10 files
                    if (filesCreated % 10 == 0)
                    {
                        await Task.Delay(2000); // Wait for 2 seconds
                        progressBar1.Invoke((MethodInvoker)delegate {
                            
                            progressBar1.Value = 0;
                        });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while creating the file: " + ex.Message);
                }

                itemIndex += (int)numericUpDown1.Value;
            }

            richTextBox1.Invoke((MethodInvoker)delegate {
                richTextBox1.Text += filesCreated + " files have been created in " + textBox2.Text + "\r\n";
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
                        textBox2.Text = selectedPath;
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
                    // Set the filter to allow only XML files
                    openFileDialog.Filter = "XML Files (*.xml)|*.xml";

                    // Show the open file dialog
                    DialogResult result = openFileDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string selectedFilePath = openFileDialog.FileName;

                        // Get the directory path of the selected file
                        string selectedFolderPath = System.IO.Path.GetDirectoryName(selectedFilePath);

                        // Update the TextBox with the selected file path
                        file_path_textbox.Text = selectedFilePath;
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