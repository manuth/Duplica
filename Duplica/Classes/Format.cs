using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Duplica
{
    /// <summary>
    /// Definiert das Format eines Textes in einer RichTextBox
    /// </summary>
    public class Format
    {
        public Font Font { get; set; }
        public HorizontalAlignment Alignment { get; set; }
        public Color ForeColor { get; set; }
        public Color BackColor { get; set; }
        public bool Bullets { get; set; }
        public int Indent { get; set; }
        public int RightIndent { get; set; }

        /// <summary>
        /// Initialisiert ein Format für Texte in einer RichTextBox
        /// </summary>
        public Format()
        {
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Alignment = HorizontalAlignment.Left;
            ForeColor = SystemColors.WindowText;
            BackColor = SystemColors.Control;
            Bullets = false;
            Indent = 0;
            RightIndent = 0;
        }

        /// <summary>
        /// Initialisiert ein Format für Texte in einer RichTextBox
        /// </summary>
        /// <param name="font">
        /// Schriftart, welche formatiert werden soll
        /// </param>
        public Format(Font font) : this()
        {
            Font = font;
        }

        /// <summary>
        /// Initialisiert ein Format für Texte in einer RichTextBox
        /// </summary>
        /// <param name="font">
        /// Schriftart, welche formatiert werden soll
        /// </param>
        /// <param name="alignment">
        /// Horizontale Ausrichtung des Texts
        /// </param>
        public Format(Font font, HorizontalAlignment alignment) : this(font)
        {
            Alignment = alignment;
        }

        /// <summary>
        /// Initialisiert ein Format für Texte in einer RichTextBox
        /// </summary>
        /// <param name="font">
        /// Schriftart, welche formatiert werden soll
        /// </param>
        /// <param name="alignment">
        /// Horizontale Ausrichtung des Texts
        /// </param>
        /// <param name="foreColor">
        /// Schriftfarbe des Texts
        /// </param>
        /// <param name="backColor">
        /// Hintergrundfarbe des Texts
        /// </param>
        public Format(Font font, HorizontalAlignment alignment, Color foreColor, Color backColor) : this(font, alignment)
        {
            ForeColor = foreColor;
            BackColor = backColor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="font">
        /// Schriftart, welche formatiert werden soll
        /// </param>
        /// <param name="alignment">
        /// Horizontale Ausrichtung des Texts
        /// </param>
        /// <param name="foreColor">
        /// Schriftfarbe des Texts
        /// </param>
        /// <param name="backColor">
        /// Hintergrundfarbe des Texts
        /// </param>
        /// <param name="bullets">
        /// Definiert, ob der Text Aufzählungszeichen haben soll.
        /// </param>
        public Format(Font font, HorizontalAlignment alignment, Color foreColor, Color backColor, bool bullets) : this(font, alignment, foreColor, backColor)
        {
            Bullets = bullets;
        }

        /// <summary>
        /// Initialisiert ein Format für Texte in einer RichTextBox
        /// </summary>
        /// <param name="font">
        /// Schriftart, welche formatiert werden soll
        /// </param>
        /// <param name="alignment">
        /// Horizontale Ausrichtung des Texts
        /// </param>
        /// <param name="foreColor">
        /// Schriftfarbe des Texts
        /// </param>
        /// <param name="backColor">
        /// Hintergrundfarbe des Texts
        /// </param>
        /// <param name="bullets">
        /// Definiert, ob der Text Aufzählungszeichen haben soll.
        /// </param>
        /// <param name="indent">
        /// Definiert den linken Einzug
        /// </param>
        public Format(Font font, HorizontalAlignment alignment, Color foreColor, Color backColor, bool bullets, int indent) : this(font, alignment, foreColor, backColor, bullets)
        {
            Indent = indent;
        }

        /// <summary>
        /// Initialisiert ein Format für Texte in einer RichTextBox
        /// </summary>
        /// <param name="font">
        /// Schriftart, welche formatiert werden soll
        /// </param>
        /// <param name="alignment">
        /// Horizontale Ausrichtung des Texts
        /// </param>
        /// <param name="foreColor">
        /// Schriftfarbe des Texts
        /// </param>
        /// <param name="backColor">
        /// Hintergrundfarbe des Texts
        /// </param>
        /// <param name="bullets">
        /// Definiert, ob der Text Aufzählungszeichen haben soll.
        /// </param>
        /// <param name="indent">
        /// Definiert den linken Einzug
        /// </param>
        /// <param name="rightIndent">
        /// Definiert den rechten Einzug
        /// </param>
        public Format(Font font, HorizontalAlignment alignment, Color foreColor, Color backColor, bool bullets, int indent, int rightIndent) : this(font, alignment, foreColor, backColor, bullets, indent)
        {
            RightIndent = rightIndent;
        }
    }
}
