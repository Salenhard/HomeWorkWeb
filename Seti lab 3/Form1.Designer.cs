namespace Seti_lab_3
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
            this.comboBoxCommunicationLine = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.comboBoxCabelType = new System.Windows.Forms.ComboBox();
            this.labelCommunicationLine = new System.Windows.Forms.Label();
            this.textBoxCabelLenght = new System.Windows.Forms.TextBox();
            this.labelCableType = new System.Windows.Forms.Label();
            this.labelCabelLenght = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelResultValue = new System.Windows.Forms.Label();
            this.textBoxCabelSpeed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxCommunicationLine
            // 
            this.comboBoxCommunicationLine.FormattingEnabled = true;
            this.comboBoxCommunicationLine.Location = new System.Drawing.Point(32, 41);
            this.comboBoxCommunicationLine.Name = "comboBoxCommunicationLine";
            this.comboBoxCommunicationLine.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCommunicationLine.TabIndex = 0;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(32, 206);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(121, 23);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Ввод";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // comboBoxCabelType
            // 
            this.comboBoxCabelType.FormattingEnabled = true;
            this.comboBoxCabelType.Location = new System.Drawing.Point(32, 85);
            this.comboBoxCabelType.Name = "comboBoxCabelType";
            this.comboBoxCabelType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCabelType.TabIndex = 2;
            // 
            // labelCommunicationLine
            // 
            this.labelCommunicationLine.AutoSize = true;
            this.labelCommunicationLine.Location = new System.Drawing.Point(32, 23);
            this.labelCommunicationLine.Name = "labelCommunicationLine";
            this.labelCommunicationLine.Size = new System.Drawing.Size(75, 15);
            this.labelCommunicationLine.TabIndex = 3;
            this.labelCommunicationLine.Text = "Линия связи";
            // 
            // textBoxCabelLenght
            // 
            this.textBoxCabelLenght.Location = new System.Drawing.Point(32, 133);
            this.textBoxCabelLenght.Name = "textBoxCabelLenght";
            this.textBoxCabelLenght.Size = new System.Drawing.Size(121, 23);
            this.textBoxCabelLenght.TabIndex = 4;
            // 
            // labelCableType
            // 
            this.labelCableType.AutoSize = true;
            this.labelCableType.Location = new System.Drawing.Point(32, 67);
            this.labelCableType.Name = "labelCableType";
            this.labelCableType.Size = new System.Drawing.Size(84, 15);
            this.labelCableType.TabIndex = 5;
            this.labelCableType.Text = "Вид покрытия";
            // 
            // labelCabelLenght
            // 
            this.labelCabelLenght.AutoSize = true;
            this.labelCabelLenght.Location = new System.Drawing.Point(32, 115);
            this.labelCabelLenght.Name = "labelCabelLenght";
            this.labelCabelLenght.Size = new System.Drawing.Size(143, 15);
            this.labelCabelLenght.TabIndex = 6;
            this.labelCabelLenght.Text = "Дистанция покрытия (м)";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(32, 159);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(98, 15);
            this.labelSpeed.TabIndex = 8;
            this.labelSpeed.Text = "Скорость (мбит)";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(32, 232);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(60, 15);
            this.labelResult.TabIndex = 10;
            this.labelResult.Text = "Результат";
            // 
            // labelResultValue
            // 
            this.labelResultValue.BackColor = System.Drawing.SystemColors.Control;
            this.labelResultValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResultValue.Location = new System.Drawing.Point(32, 247);
            this.labelResultValue.Name = "labelResultValue";
            this.labelResultValue.Size = new System.Drawing.Size(121, 23);
            this.labelResultValue.TabIndex = 11;
            this.labelResultValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCabelSpeed
            // 
            this.textBoxCabelSpeed.Location = new System.Drawing.Point(32, 177);
            this.textBoxCabelSpeed.Name = "textBoxCabelSpeed";
            this.textBoxCabelSpeed.Size = new System.Drawing.Size(121, 23);
            this.textBoxCabelSpeed.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 299);
            this.Controls.Add(this.textBoxCabelSpeed);
            this.Controls.Add(this.labelResultValue);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelCabelLenght);
            this.Controls.Add(this.labelCableType);
            this.Controls.Add(this.textBoxCabelLenght);
            this.Controls.Add(this.labelCommunicationLine);
            this.Controls.Add(this.comboBoxCabelType);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.comboBoxCommunicationLine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxCommunicationLine;
        private Button buttonSubmit;
        private ComboBox comboBoxCabelType;
        private Label labelCommunicationLine;
        private TextBox textBoxCabelLenght;
        private Label labelCableType;
        private Label labelCabelLenght;
        private Label labelSpeed;
        private Label labelResult;
        private Label labelResultValue;
        private TextBox textBoxCabelSpeed;
    }
}