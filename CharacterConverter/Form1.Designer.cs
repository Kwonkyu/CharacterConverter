namespace CharacterConverter
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ModeStrToHex = new System.Windows.Forms.RadioButton();
            this.ModeStrToInt = new System.Windows.Forms.RadioButton();
            this.InputText = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OutputModeCustomText = new System.Windows.Forms.TextBox();
            this.OutputModeCustom = new System.Windows.Forms.RadioButton();
            this.OutputModePercentage = new System.Windows.Forms.RadioButton();
            this.OutputModeX = new System.Windows.Forms.RadioButton();
            this.OutputModeNone = new System.Windows.Forms.RadioButton();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SeparatorNone = new System.Windows.Forms.RadioButton();
            this.SeparatorCustomText = new System.Windows.Forms.TextBox();
            this.SeparatorCustom = new System.Windows.Forms.RadioButton();
            this.SeparatorComma = new System.Windows.Forms.RadioButton();
            this.SeparatorWhitespace = new System.Windows.Forms.RadioButton();
            this.CopyToClipboardButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ModeStrToHex);
            this.groupBox1.Controls.Add(this.ModeStrToInt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // ModeStrToHex
            // 
            this.ModeStrToHex.AutoSize = true;
            this.ModeStrToHex.Location = new System.Drawing.Point(7, 25);
            this.ModeStrToHex.Name = "ModeStrToHex";
            this.ModeStrToHex.Size = new System.Drawing.Size(119, 19);
            this.ModeStrToHex.TabIndex = 1;
            this.ModeStrToHex.Text = "String To Hex";
            this.ModeStrToHex.UseVisualStyleBackColor = true;
            this.ModeStrToHex.CheckedChanged += new System.EventHandler(this.ModeStrToHex_CheckedChanged);
            // 
            // ModeStrToInt
            // 
            this.ModeStrToInt.AutoSize = true;
            this.ModeStrToInt.Location = new System.Drawing.Point(7, 60);
            this.ModeStrToInt.Name = "ModeStrToInt";
            this.ModeStrToInt.Size = new System.Drawing.Size(107, 19);
            this.ModeStrToInt.TabIndex = 0;
            this.ModeStrToInt.Text = "String To Int";
            this.ModeStrToInt.UseVisualStyleBackColor = true;
            this.ModeStrToInt.CheckedChanged += new System.EventHandler(this.ModeStrToInt_CheckedChanged);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(118, 111);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(495, 25);
            this.InputText.TabIndex = 1;
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(12, 114);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(87, 15);
            this.InputLabel.TabIndex = 2;
            this.InputLabel.Text = "Input(String)";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(9, 147);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(90, 15);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Text = "Output(Hex)";
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(118, 144);
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(495, 25);
            this.OutputText.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OutputModeCustomText);
            this.groupBox2.Controls.Add(this.OutputModeCustom);
            this.groupBox2.Controls.Add(this.OutputModePercentage);
            this.groupBox2.Controls.Add(this.OutputModeX);
            this.groupBox2.Controls.Add(this.OutputModeNone);
            this.groupBox2.Location = new System.Drawing.Point(153, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 87);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Mode";
            // 
            // OutputModeCustomText
            // 
            this.OutputModeCustomText.Location = new System.Drawing.Point(99, 56);
            this.OutputModeCustomText.Name = "OutputModeCustomText";
            this.OutputModeCustomText.Size = new System.Drawing.Size(30, 25);
            this.OutputModeCustomText.TabIndex = 4;
            this.OutputModeCustomText.TextChanged += new System.EventHandler(this.OutputModeCustomHeader_TextChanged);
            // 
            // OutputModeCustom
            // 
            this.OutputModeCustom.AutoSize = true;
            this.OutputModeCustom.Location = new System.Drawing.Point(76, 61);
            this.OutputModeCustom.Name = "OutputModeCustom";
            this.OutputModeCustom.Size = new System.Drawing.Size(17, 16);
            this.OutputModeCustom.TabIndex = 3;
            this.OutputModeCustom.UseVisualStyleBackColor = true;
            this.OutputModeCustom.CheckedChanged += new System.EventHandler(this.OutputModeCustom_CheckedChanged);
            // 
            // OutputModePercentage
            // 
            this.OutputModePercentage.AutoSize = true;
            this.OutputModePercentage.Location = new System.Drawing.Point(76, 25);
            this.OutputModePercentage.Name = "OutputModePercentage";
            this.OutputModePercentage.Size = new System.Drawing.Size(39, 19);
            this.OutputModePercentage.TabIndex = 2;
            this.OutputModePercentage.Text = "%";
            this.OutputModePercentage.UseVisualStyleBackColor = true;
            this.OutputModePercentage.CheckedChanged += new System.EventHandler(this.OutputModePercentage_CheckedChanged);
            // 
            // OutputModeX
            // 
            this.OutputModeX.AutoSize = true;
            this.OutputModeX.Location = new System.Drawing.Point(6, 60);
            this.OutputModeX.Name = "OutputModeX";
            this.OutputModeX.Size = new System.Drawing.Size(51, 19);
            this.OutputModeX.TabIndex = 1;
            this.OutputModeX.Text = "\\x";
            this.OutputModeX.UseVisualStyleBackColor = true;
            this.OutputModeX.CheckedChanged += new System.EventHandler(this.OutputModeX_CheckedChanged);
            // 
            // OutputModeNone
            // 
            this.OutputModeNone.AutoSize = true;
            this.OutputModeNone.Location = new System.Drawing.Point(7, 25);
            this.OutputModeNone.Name = "OutputModeNone";
            this.OutputModeNone.Size = new System.Drawing.Size(62, 19);
            this.OutputModeNone.TabIndex = 0;
            this.OutputModeNone.Text = "None";
            this.OutputModeNone.UseVisualStyleBackColor = true;
            this.OutputModeNone.CheckedChanged += new System.EventHandler(this.OutputModeNone_CheckedChanged);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 187);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.ErrorLabel.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SeparatorNone);
            this.groupBox3.Controls.Add(this.SeparatorCustomText);
            this.groupBox3.Controls.Add(this.SeparatorCustom);
            this.groupBox3.Controls.Add(this.SeparatorComma);
            this.groupBox3.Controls.Add(this.SeparatorWhitespace);
            this.groupBox3.Location = new System.Drawing.Point(299, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 86);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Separator";
            // 
            // SeparatorNone
            // 
            this.SeparatorNone.AutoSize = true;
            this.SeparatorNone.Location = new System.Drawing.Point(7, 25);
            this.SeparatorNone.Name = "SeparatorNone";
            this.SeparatorNone.Size = new System.Drawing.Size(62, 19);
            this.SeparatorNone.TabIndex = 4;
            this.SeparatorNone.TabStop = true;
            this.SeparatorNone.Text = "None";
            this.SeparatorNone.UseVisualStyleBackColor = true;
            this.SeparatorNone.CheckedChanged += new System.EventHandler(this.SeparatorNone_CheckedChanged);
            // 
            // SeparatorCustomText
            // 
            this.SeparatorCustomText.Location = new System.Drawing.Point(95, 55);
            this.SeparatorCustomText.Name = "SeparatorCustomText";
            this.SeparatorCustomText.Size = new System.Drawing.Size(34, 25);
            this.SeparatorCustomText.TabIndex = 3;
            this.SeparatorCustomText.TextChanged += new System.EventHandler(this.SeparatorCustomText_TextChanged);
            // 
            // SeparatorCustom
            // 
            this.SeparatorCustom.AutoSize = true;
            this.SeparatorCustom.Location = new System.Drawing.Point(72, 60);
            this.SeparatorCustom.Name = "SeparatorCustom";
            this.SeparatorCustom.Size = new System.Drawing.Size(17, 16);
            this.SeparatorCustom.TabIndex = 2;
            this.SeparatorCustom.TabStop = true;
            this.SeparatorCustom.UseVisualStyleBackColor = true;
            this.SeparatorCustom.CheckedChanged += new System.EventHandler(this.SeparatorCustom_CheckedChanged);
            // 
            // SeparatorComma
            // 
            this.SeparatorComma.AutoSize = true;
            this.SeparatorComma.Location = new System.Drawing.Point(7, 59);
            this.SeparatorComma.Name = "SeparatorComma";
            this.SeparatorComma.Size = new System.Drawing.Size(33, 19);
            this.SeparatorComma.TabIndex = 1;
            this.SeparatorComma.TabStop = true;
            this.SeparatorComma.Text = ",";
            this.SeparatorComma.UseVisualStyleBackColor = true;
            this.SeparatorComma.CheckedChanged += new System.EventHandler(this.SeparatorComma_CheckedChanged);
            // 
            // SeparatorWhitespace
            // 
            this.SeparatorWhitespace.AutoSize = true;
            this.SeparatorWhitespace.Location = new System.Drawing.Point(72, 24);
            this.SeparatorWhitespace.Name = "SeparatorWhitespace";
            this.SeparatorWhitespace.Size = new System.Drawing.Size(105, 19);
            this.SeparatorWhitespace.TabIndex = 0;
            this.SeparatorWhitespace.TabStop = true;
            this.SeparatorWhitespace.Text = "Whitespace";
            this.SeparatorWhitespace.UseVisualStyleBackColor = true;
            this.SeparatorWhitespace.CheckedChanged += new System.EventHandler(this.SeparatorWhitespace_CheckedChanged);
            // 
            // CopyToClipboardButton
            // 
            this.CopyToClipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyToClipboardButton.Location = new System.Drawing.Point(505, 22);
            this.CopyToClipboardButton.Name = "CopyToClipboardButton";
            this.CopyToClipboardButton.Size = new System.Drawing.Size(108, 77);
            this.CopyToClipboardButton.TabIndex = 8;
            this.CopyToClipboardButton.Text = "Copy To Clipboard";
            this.CopyToClipboardButton.UseVisualStyleBackColor = true;
            this.CopyToClipboardButton.Click += new System.EventHandler(this.CopyToClipboardButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 214);
            this.Controls.Add(this.CopyToClipboardButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Character Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ModeStrToHex;
        private System.Windows.Forms.RadioButton ModeStrToInt;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox OutputModeCustomText;
        private System.Windows.Forms.RadioButton OutputModeCustom;
        private System.Windows.Forms.RadioButton OutputModePercentage;
        private System.Windows.Forms.RadioButton OutputModeX;
        private System.Windows.Forms.RadioButton OutputModeNone;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox SeparatorCustomText;
        private System.Windows.Forms.RadioButton SeparatorCustom;
        private System.Windows.Forms.RadioButton SeparatorComma;
        private System.Windows.Forms.RadioButton SeparatorWhitespace;
        private System.Windows.Forms.Button CopyToClipboardButton;
        private System.Windows.Forms.RadioButton SeparatorNone;
    }
}

