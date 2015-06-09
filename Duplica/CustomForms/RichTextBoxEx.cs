using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Duplica
{
    public class RichTextBoxEx : RichTextBox
    {
        public Format StandardFormat { get; set; }

        public RichTextBoxEx() : base()
        {
            StandardFormat = new Format();
            setFormat(StandardFormat);
        }

        new public void AppendText(string text)
        {
            setFormat(StandardFormat);
            base.AppendText(text);
        }

        public void AppendText(Format textFormat, string text)
        {
            setFormat(textFormat);
            base.AppendText(text);
            setFormat(StandardFormat);
        }

        public void AppendText(Format textFormat, Color foreColor, string text)
        {
            textFormat.ForeColor = foreColor;
            AppendText(textFormat, text);
        }

        public void AppendText(Format textFormat, Color foreColor, Color backColor, string text)
        {
            textFormat.BackColor = backColor;
            AppendText(textFormat, foreColor, text);
        }

        private void setFormat(Format format)
        {
            SelectionFont = format.Font;
            SelectionAlignment = format.Alignment;
            SelectionBackColor = format.BackColor;
            SelectionColor = format.ForeColor;
            SelectionBullet = format.Bullets;
            SelectionIndent = format.Indent;
            SelectionRightIndent = format.RightIndent;
        }
    }
}
