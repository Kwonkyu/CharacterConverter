using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterConverter
{
    public partial class Form1 : Form
    {
        private enum TranslationMode { STRING_TO_HEX, STRING_TO_INT }
        private TranslationMode CurrentTranslationMode = TranslationMode.STRING_TO_HEX;
        private string header = "", separator = "";

        public Form1()
        {
            InitializeComponent();
            ModeStrToHex.Checked = true;
            OutputModeNone.Checked = true;
            SeparatorNone.Checked = true;
        }

        private void ClearTextBox()
        {
            InputText.Text = "";
            OutputText.Text = "";
        }

        private string TranslateCharacter(char chr, TranslationMode mode)
        {
            string output = "??";
            try
            {
                ErrorLabel.Text = "";
                if (mode == TranslationMode.STRING_TO_HEX)
                {
                    output = Convert.ToByte(chr).ToString("x2");
                }
                else if(mode == TranslationMode.STRING_TO_INT)
                {
                    output = Convert.ToInt32(chr).ToString();
                }
            }
            catch (FormatException)
            {
                ErrorLabel.Text = "Format Exception";
            }
            catch (OverflowException)
            {
                ErrorLabel.Text = "Overflow Exception";
            }
            return output;
        }

        private void UpdateOutputText()
        {
            string input = InputText.Text;
            string output = "";

            foreach (var chr in input)
            {
                output += header;
                output += TranslateCharacter(chr, CurrentTranslationMode);
                output += separator;
            }
            OutputText.Text = output.Substring(0, output.Length - separator.Length);
        }

        private void InputText_TextChanged(object sender, EventArgs e)
        {
            UpdateOutputText();
        }

        private void ModeStrToHex_CheckedChanged(object sender, EventArgs e)
        {
            CurrentTranslationMode = TranslationMode.STRING_TO_HEX;
            OutputLabel.Text = "Output(Hex)";
            UpdateOutputText();
        }

        private void ModeStrToInt_CheckedChanged(object sender, EventArgs e)
        {
            CurrentTranslationMode = TranslationMode.STRING_TO_INT;
            OutputLabel.Text = "Output(Integer)";
            UpdateOutputText();
        }

        private void OutputModeNone_CheckedChanged(object sender, EventArgs e)
        {
            header = "";
            UpdateOutputText();
        }

        private void OutputModePercentage_CheckedChanged(object sender, EventArgs e)
        {
            header = "%";
            UpdateOutputText();
        }

        private void OutputModeX_CheckedChanged(object sender, EventArgs e)
        {
            header = "\\x";
            UpdateOutputText();
        }

        private void OutputModeCustom_CheckedChanged(object sender, EventArgs e)
        {
            header = OutputModeCustomText.Text;
            UpdateOutputText();
        }

        private void SeparatorWhitespace_CheckedChanged(object sender, EventArgs e)
        {
            separator = " ";
            UpdateOutputText();
        }

        private void SeparatorNone_CheckedChanged(object sender, EventArgs e)
        {
            separator = "";
            UpdateOutputText();
        }

        private void SeparatorComma_CheckedChanged(object sender, EventArgs e)
        {
            separator = ",";
            UpdateOutputText();
        }

        private void SeparatorCustom_CheckedChanged(object sender, EventArgs e)
        {
            separator = SeparatorCustomText.Text;
            UpdateOutputText();
        }

        private void SeparatorCustomText_TextChanged(object sender, EventArgs e)
        {
            SeparatorCustom.Checked = true;
            separator = SeparatorCustomText.Text;
            UpdateOutputText();
        }

        private void CopyToClipboardButton_Click(object sender, EventArgs e)
        {
            if(OutputText.Text.Length > 0)
            {
                Clipboard.SetText(OutputText.Text);
                MessageBox.Show("Copied to clipboard!");
            }
        }

        private void OutputModeCustomHeader_TextChanged(object sender, EventArgs e)
        {
            OutputModeCustom.Checked = true;
            header = OutputModeCustomText.Text;
            UpdateOutputText();
        }
    }
}
