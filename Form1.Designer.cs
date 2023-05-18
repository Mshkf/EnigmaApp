namespace EnigmaApp
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.rotorFirstTextBox = new System.Windows.Forms.TextBox();
            this.rotorSecondTextBox = new System.Windows.Forms.TextBox();
            this.rotorThirdTextBox = new System.Windows.Forms.TextBox();
            this.plug1TextBox = new System.Windows.Forms.TextBox();
            this.plug2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.plugListLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(374, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(300, 400);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.Leave += new System.EventHandler(this.richTextBox1_Leave);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(871, 63);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(300, 400);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(711, 219);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(125, 83);
            this.encryptButton.TabIndex = 2;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // rotorFirstTextBox
            // 
            this.rotorFirstTextBox.Location = new System.Drawing.Point(187, 63);
            this.rotorFirstTextBox.Name = "rotorFirstTextBox";
            this.rotorFirstTextBox.Size = new System.Drawing.Size(40, 22);
            this.rotorFirstTextBox.TabIndex = 3;
            this.rotorFirstTextBox.TextChanged += new System.EventHandler(this.rotorFirstTextBox_TextChanged);
            // 
            // rotorSecondTextBox
            // 
            this.rotorSecondTextBox.Location = new System.Drawing.Point(141, 63);
            this.rotorSecondTextBox.Name = "rotorSecondTextBox";
            this.rotorSecondTextBox.Size = new System.Drawing.Size(40, 22);
            this.rotorSecondTextBox.TabIndex = 4;
            this.rotorSecondTextBox.TextChanged += new System.EventHandler(this.rotorSecondTextBox_TextChanged);
            // 
            // rotorThirdTextBox
            // 
            this.rotorThirdTextBox.Location = new System.Drawing.Point(95, 63);
            this.rotorThirdTextBox.Name = "rotorThirdTextBox";
            this.rotorThirdTextBox.Size = new System.Drawing.Size(40, 22);
            this.rotorThirdTextBox.TabIndex = 5;
            this.rotorThirdTextBox.TextChanged += new System.EventHandler(this.rotorThirdTextBox_TextChanged);
            // 
            // plug1TextBox
            // 
            this.plug1TextBox.Location = new System.Drawing.Point(95, 163);
            this.plug1TextBox.Name = "plug1TextBox";
            this.plug1TextBox.Size = new System.Drawing.Size(40, 22);
            this.plug1TextBox.TabIndex = 6;
            this.plug1TextBox.Text = "A";
            this.plug1TextBox.Leave += new System.EventHandler(this.plug1TextBox_Leave);
            // 
            // plug2TextBox
            // 
            this.plug2TextBox.Location = new System.Drawing.Point(187, 163);
            this.plug2TextBox.Name = "plug2TextBox";
            this.plug2TextBox.Size = new System.Drawing.Size(40, 22);
            this.plug2TextBox.TabIndex = 7;
            this.plug2TextBox.Text = "B";
            this.plug2TextBox.Leave += new System.EventHandler(this.plug2TextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "=";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(95, 134);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(132, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(95, 191);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(132, 23);
            this.removeButton.TabIndex = 10;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Active plugs:";
            // 
            // plugListLabel
            // 
            this.plugListLabel.AutoSize = true;
            this.plugListLabel.Location = new System.Drawing.Point(92, 297);
            this.plugListLabel.Name = "plugListLabel";
            this.plugListLabel.Size = new System.Drawing.Size(0, 16);
            this.plugListLabel.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Your text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(868, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plugListLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plug2TextBox);
            this.Controls.Add(this.plug1TextBox);
            this.Controls.Add(this.rotorThirdTextBox);
            this.Controls.Add(this.rotorSecondTextBox);
            this.Controls.Add(this.rotorFirstTextBox);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Enigma Encription";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox rotorFirstTextBox;
        private System.Windows.Forms.TextBox rotorSecondTextBox;
        private System.Windows.Forms.TextBox rotorThirdTextBox;
        private System.Windows.Forms.TextBox plug1TextBox;
        private System.Windows.Forms.TextBox plug2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label plugListLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

