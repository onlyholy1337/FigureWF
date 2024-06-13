namespace FiguresWF
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.size2_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.size1_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.figure_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.square_button = new System.Windows.Forms.Button();
            this.protocol_listBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size1_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size2_numericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фигура";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.size2_numericUpDown);
            this.groupBox1.Controls.Add(this.size1_numericUpDown);
            this.groupBox1.Controls.Add(this.figure_comboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // figure_comboBox
            // 
            this.figure_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.figure_comboBox.FormattingEnabled = true;
            this.figure_comboBox.Items.AddRange(new object[] {
        "Прямоугольник",
        "Окружность",
        "Квадрат"
    });
            this.figure_comboBox.Location = new System.Drawing.Point(71, 27);
            this.figure_comboBox.Name = "figure_comboBox";
            this.figure_comboBox.Size = new System.Drawing.Size(121, 21);
            this.figure_comboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Длина";
            // 
            // size1_numericUpDown
            // 
            this.size1_numericUpDown.Location = new System.Drawing.Point(71, 68);
            this.size1_numericUpDown.Name = "size1_numericUpDown";
            this.size1_numericUpDown.Size = new System.Drawing.Size(75, 20);
            this.size1_numericUpDown.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ширина";
            // 
            // size2_numericUpDown
            // 
            this.size2_numericUpDown.Location = new System.Drawing.Point(71, 94);
            this.size2_numericUpDown.Name = "size2_numericUpDown";
            this.size2_numericUpDown.Size = new System.Drawing.Size(75, 20);
            this.size2_numericUpDown.TabIndex = 2;
            // 
            // square_button
            // 
            this.square_button.Location = new System.Drawing.Point(49, 149);
            this.square_button.Name = "square_button";
            this.square_button.Size = new System.Drawing.Size(109, 23);
            this.square_button.TabIndex = 2;
            this.square_button.Text = "Расчет площади";
            this.square_button.UseVisualStyleBackColor = true;
            this.square_button.Click += new System.EventHandler(this.square_button_Click);
            // 
            // protocol_listBox
            // 
            this.protocol_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.protocol_listBox.FormattingEnabled = true;
            this.protocol_listBox.HorizontalScrollbar = true;
            this.protocol_listBox.Location = new System.Drawing.Point(3, 16);
            this.protocol_listBox.Name = "protocol_listBox";
            this.protocol_listBox.Size = new System.Drawing.Size(371, 206);
            this.protocol_listBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.protocol_listBox);
            this.groupBox2.Location = new System.Drawing.Point(241, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 225);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Протокол расчетов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 249);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.square_button);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Демо";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size1_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size2_numericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown size2_numericUpDown;
        private System.Windows.Forms.NumericUpDown size1_numericUpDown;
        private System.Windows.Forms.ComboBox figure_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button square_button;
        private System.Windows.Forms.ListBox protocol_listBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
