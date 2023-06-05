namespace XML_File_Snipper
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
            Generate_Button = new Button();
            Path_text = new Label();
            Nodes_Per_XML_Text = new Label();
            Number_Of_Elements_Per_file = new NumericUpDown();
            label3 = new Label();
            Destination_Open_Button = new Button();
            destination_text = new Label();
            Path_Open_Button = new Button();
            File_Destination_Textbox = new TextBox();
            File_Path_Textbox = new TextBox();
            Progress_output_text = new RichTextBox();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)Number_Of_Elements_Per_file).BeginInit();
            SuspendLayout();
            // 
            // Generate_Button
            // 
            Generate_Button.BackColor = Color.Snow;
            Generate_Button.Font = new Font("Candara", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Generate_Button.ForeColor = Color.Black;
            Generate_Button.Location = new Point(267, 476);
            Generate_Button.Margin = new Padding(4, 3, 4, 3);
            Generate_Button.Name = "Generate_Button";
            Generate_Button.Size = new Size(260, 120);
            Generate_Button.TabIndex = 0;
            Generate_Button.Text = "Generate";
            Generate_Button.UseVisualStyleBackColor = false;
            Generate_Button.Click += button1_Click;
            // 
            // Path_text
            // 
            Path_text.AutoSize = true;
            Path_text.Font = new Font("Candara", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            Path_text.ForeColor = SystemColors.ControlText;
            Path_text.Location = new Point(54, 132);
            Path_text.Margin = new Padding(4, 0, 4, 0);
            Path_text.Name = "Path_text";
            Path_text.Size = new Size(41, 18);
            Path_text.TabIndex = 1;
            Path_text.Text = "Path:";
            Path_text.Click += label1_Click;
            // 
            // Nodes_Per_XML_Text
            // 
            Nodes_Per_XML_Text.AutoSize = true;
            Nodes_Per_XML_Text.Font = new Font("Candara", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            Nodes_Per_XML_Text.ForeColor = SystemColors.ControlText;
            Nodes_Per_XML_Text.Location = new Point(55, 272);
            Nodes_Per_XML_Text.Margin = new Padding(4, 0, 4, 0);
            Nodes_Per_XML_Text.Name = "Nodes_Per_XML_Text";
            Nodes_Per_XML_Text.Size = new Size(184, 18);
            Nodes_Per_XML_Text.TabIndex = 2;
            Nodes_Per_XML_Text.Text = "Number of items per XML file";
            Nodes_Per_XML_Text.Click += label_num_item_Click;
            // 
            // Number_Of_Elements_Per_file
            // 
            Number_Of_Elements_Per_file.Location = new Point(291, 270);
            Number_Of_Elements_Per_file.Margin = new Padding(4, 3, 4, 3);
            Number_Of_Elements_Per_file.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            Number_Of_Elements_Per_file.Name = "Number_Of_Elements_Per_file";
            Number_Of_Elements_Per_file.Size = new Size(188, 25);
            Number_Of_Elements_Per_file.TabIndex = 3;
            Number_Of_Elements_Per_file.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(55, 27);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(197, 33);
            label3.TabIndex = 4;
            label3.Text = "XML file snipper";
            label3.Click += label3_Click;
            // 
            // Destination_Open_Button
            // 
            Destination_Open_Button.Font = new Font("Candara", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Destination_Open_Button.Location = new Point(682, 193);
            Destination_Open_Button.Margin = new Padding(4, 3, 4, 3);
            Destination_Open_Button.Name = "Destination_Open_Button";
            Destination_Open_Button.Size = new Size(108, 40);
            Destination_Open_Button.TabIndex = 5;
            Destination_Open_Button.Text = "Open";
            Destination_Open_Button.UseVisualStyleBackColor = true;
            Destination_Open_Button.Click += button2_Click;
            // 
            // destination_text
            // 
            destination_text.AutoSize = true;
            destination_text.Font = new Font("Candara", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            destination_text.Location = new Point(55, 202);
            destination_text.Margin = new Padding(4, 0, 4, 0);
            destination_text.Name = "destination_text";
            destination_text.Size = new Size(83, 18);
            destination_text.TabIndex = 7;
            destination_text.Text = "Destination:";
            // 
            // Path_Open_Button
            // 
            Path_Open_Button.Font = new Font("Candara", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Path_Open_Button.Location = new Point(630, 123);
            Path_Open_Button.Margin = new Padding(4);
            Path_Open_Button.Name = "Path_Open_Button";
            Path_Open_Button.Size = new Size(108, 40);
            Path_Open_Button.TabIndex = 9;
            Path_Open_Button.Text = "Open";
            Path_Open_Button.UseVisualStyleBackColor = true;
            Path_Open_Button.Click += button2_Click_1;
            // 
            // File_Destination_Textbox
            // 
            File_Destination_Textbox.Enabled = false;
            File_Destination_Textbox.Location = new Point(159, 199);
            File_Destination_Textbox.Margin = new Padding(4, 3, 4, 3);
            File_Destination_Textbox.Name = "File_Destination_Textbox";
            File_Destination_Textbox.Size = new Size(515, 25);
            File_Destination_Textbox.TabIndex = 8;
            File_Destination_Textbox.TextChanged += textBox2_TextChanged;
            // 
            // File_Path_Textbox
            // 
            File_Path_Textbox.Enabled = false;
            File_Path_Textbox.Font = new Font("Candara", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            File_Path_Textbox.Location = new Point(107, 129);
            File_Path_Textbox.Margin = new Padding(4, 3, 4, 3);
            File_Path_Textbox.Name = "File_Path_Textbox";
            File_Path_Textbox.Size = new Size(515, 25);
            File_Path_Textbox.TabIndex = 6;
            File_Path_Textbox.TextChanged += file_path_textbox_TextChanged;
            // 
            // Progress_output_text
            // 
            Progress_output_text.Font = new Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Progress_output_text.Location = new Point(797, -1);
            Progress_output_text.Name = "Progress_output_text";
            Progress_output_text.Size = new Size(680, 656);
            Progress_output_text.TabIndex = 10;
            Progress_output_text.Text = "";
            Progress_output_text.TextChanged += richTextBox1_TextChanged_1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(3, 602);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(788, 53);
            progressBar1.TabIndex = 11;
            progressBar1.Click += progressBar1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1478, 656);
            Controls.Add(progressBar1);
            Controls.Add(Progress_output_text);
            Controls.Add(Path_Open_Button);
            Controls.Add(File_Destination_Textbox);
            Controls.Add(destination_text);
            Controls.Add(File_Path_Textbox);
            Controls.Add(Destination_Open_Button);
            Controls.Add(label3);
            Controls.Add(Number_Of_Elements_Per_file);
            Controls.Add(Nodes_Per_XML_Text);
            Controls.Add(Path_text);
            Controls.Add(Generate_Button);
            Font = new Font("Candara", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "XML_File_snipper";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Number_Of_Elements_Per_file).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Generate_Button;
        private Label Path_text;
        private Label Nodes_Per_XML_Text;
        private NumericUpDown Number_Of_Elements_Per_file;
        private Label label3;
        private Button Destination_Open_Button;
        private Label destination_text;
        private Button Path_Open_Button;
        private TextBox File_Destination_Textbox;
        private TextBox File_Path_Textbox;
        private RichTextBox Progress_output_text;
        private ProgressBar progressBar1;
    }
}