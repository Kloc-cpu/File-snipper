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
            button1 = new Button();
            label_from_path = new Label();
            label_num_item = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            browse_button = new Button();
            label_to_path = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            file_path_textbox = new TextBox();
            richTextBox1 = new RichTextBox();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Font = new Font("Candara", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(267, 476);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(260, 120);
            button1.TabIndex = 0;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label_from_path
            // 
            label_from_path.AutoSize = true;
            label_from_path.Font = new Font("Candara", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            label_from_path.ForeColor = SystemColors.ControlText;
            label_from_path.Location = new Point(54, 132);
            label_from_path.Margin = new Padding(4, 0, 4, 0);
            label_from_path.Name = "label_from_path";
            label_from_path.Size = new Size(49, 22);
            label_from_path.TabIndex = 1;
            label_from_path.Text = "Path:";
            label_from_path.Click += label1_Click;
            // 
            // label_num_item
            // 
            label_num_item.AutoSize = true;
            label_num_item.Font = new Font("Candara", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            label_num_item.ForeColor = SystemColors.ControlText;
            label_num_item.Location = new Point(55, 272);
            label_num_item.Margin = new Padding(4, 0, 4, 0);
            label_num_item.Name = "label_num_item";
            label_num_item.Size = new Size(228, 22);
            label_num_item.TabIndex = 2;
            label_num_item.Text = "Number of items per XML file";
            label_num_item.Click += label_num_item_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(291, 270);
            numericUpDown1.Margin = new Padding(4, 3, 4, 3);
            numericUpDown1.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(188, 29);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(55, 27);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(244, 41);
            label3.TabIndex = 4;
            label3.Text = "XML file snipper";
            label3.Click += label3_Click;
            // 
            // browse_button
            // 
            browse_button.Font = new Font("Candara", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            browse_button.Location = new Point(682, 193);
            browse_button.Margin = new Padding(4, 3, 4, 3);
            browse_button.Name = "browse_button";
            browse_button.Size = new Size(108, 40);
            browse_button.TabIndex = 5;
            browse_button.Text = "Open";
            browse_button.UseVisualStyleBackColor = true;
            browse_button.Click += button2_Click;
            // 
            // label_to_path
            // 
            label_to_path.AutoSize = true;
            label_to_path.Font = new Font("Candara", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            label_to_path.Location = new Point(55, 202);
            label_to_path.Margin = new Padding(4, 0, 4, 0);
            label_to_path.Name = "label_to_path";
            label_to_path.Size = new Size(101, 22);
            label_to_path.TabIndex = 7;
            label_to_path.Text = "Destination:";
            // 
            // button2
            // 
            button2.Font = new Font("Candara", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(630, 123);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(108, 40);
            button2.TabIndex = 9;
            button2.Text = "Open";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(159, 199);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(515, 29);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // file_path_textbox
            // 
            file_path_textbox.Enabled = false;
            file_path_textbox.Font = new Font("Candara", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            file_path_textbox.Location = new Point(107, 129);
            file_path_textbox.Margin = new Padding(4, 3, 4, 3);
            file_path_textbox.Name = "file_path_textbox";
            file_path_textbox.Size = new Size(515, 29);
            file_path_textbox.TabIndex = 6;
            file_path_textbox.TextChanged += file_path_textbox_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(797, -1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(680, 656);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged_1;
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
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1478, 656);
            Controls.Add(progressBar1);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label_to_path);
            Controls.Add(file_path_textbox);
            Controls.Add(browse_button);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label_num_item);
            Controls.Add(label_from_path);
            Controls.Add(button1);
            Font = new Font("Candara", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "XML_File_snipper";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label_from_path;
        private Label label_num_item;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Button browse_button;
        private Label label_to_path;
        private Button button2;
        private TextBox textBox2;
        private TextBox file_path_textbox;
        private RichTextBox richTextBox1;
        private ProgressBar progressBar1;
    }
}