namespace GPAxCalculator5
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName_input = new System.Windows.Forms.TextBox();
            this.textBoxGPA_input = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMinName = new System.Windows.Forms.TextBox();
            this.textBoxMaxName = new System.Windows.Forms.TextBox();
            this.textBoxMinGPA = new System.Windows.Forms.TextBox();
            this.textBoxGPAx = new System.Windows.Forms.TextBox();
            this.textBoxMaxGPA = new System.Windows.Forms.TextBox();
            this.textBoxAllData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "GPA INPUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "GPAx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "GPA MAX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "GPA MIN";
            // 
            // textBoxName_input
            // 
            this.textBoxName_input.Location = new System.Drawing.Point(189, 74);
            this.textBoxName_input.Name = "textBoxName_input";
            this.textBoxName_input.Size = new System.Drawing.Size(150, 31);
            this.textBoxName_input.TabIndex = 6;
            // 
            // textBoxGPA_input
            // 
            this.textBoxGPA_input.Location = new System.Drawing.Point(345, 72);
            this.textBoxGPA_input.Name = "textBoxGPA_input";
            this.textBoxGPA_input.Size = new System.Drawing.Size(150, 31);
            this.textBoxGPA_input.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMinName);
            this.groupBox1.Controls.Add(this.textBoxMaxName);
            this.groupBox1.Controls.Add(this.textBoxMinGPA);
            this.groupBox1.Controls.Add(this.textBoxGPAx);
            this.groupBox1.Controls.Add(this.textBoxMaxGPA);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(89, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 213);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OUTPUT";
            // 
            // textBoxMinName
            // 
            this.textBoxMinName.Location = new System.Drawing.Point(92, 147);
            this.textBoxMinName.Name = "textBoxMinName";
            this.textBoxMinName.Size = new System.Drawing.Size(150, 31);
            this.textBoxMinName.TabIndex = 12;
            // 
            // textBoxMaxName
            // 
            this.textBoxMaxName.Location = new System.Drawing.Point(90, 100);
            this.textBoxMaxName.Name = "textBoxMaxName";
            this.textBoxMaxName.Size = new System.Drawing.Size(150, 31);
            this.textBoxMaxName.TabIndex = 10;
            // 
            // textBoxMinGPA
            // 
            this.textBoxMinGPA.Location = new System.Drawing.Point(246, 146);
            this.textBoxMinGPA.Name = "textBoxMinGPA";
            this.textBoxMinGPA.Size = new System.Drawing.Size(115, 31);
            this.textBoxMinGPA.TabIndex = 9;
            // 
            // textBoxGPAx
            // 
            this.textBoxGPAx.Location = new System.Drawing.Point(246, 62);
            this.textBoxGPAx.Name = "textBoxGPAx";
            this.textBoxGPAx.Size = new System.Drawing.Size(115, 31);
            this.textBoxGPAx.TabIndex = 8;
            // 
            // textBoxMaxGPA
            // 
            this.textBoxMaxGPA.Location = new System.Drawing.Point(246, 103);
            this.textBoxMaxGPA.Name = "textBoxMaxGPA";
            this.textBoxMaxGPA.Size = new System.Drawing.Size(115, 31);
            this.textBoxMaxGPA.TabIndex = 7;
            // 
            // textBoxAllData
            // 
            this.textBoxAllData.Location = new System.Drawing.Point(115, 358);
            this.textBoxAllData.Multiline = true;
            this.textBoxAllData.Name = "textBoxAllData";
            this.textBoxAllData.Size = new System.Drawing.Size(513, 152);
            this.textBoxAllData.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.textBoxAllData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxGPA_input);
            this.Controls.Add(this.textBoxName_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxName_input;
        private TextBox textBoxGPA_input;
        private GroupBox groupBox1;
        private TextBox textBoxMinName;
        private TextBox textBoxMaxName;
        private TextBox textBoxMinGPA;
        private TextBox textBoxGPAx;
        private TextBox textBoxMaxGPA;
        private TextBox textBoxAllData;
    }
}