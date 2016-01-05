using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Duplica.CustomForms
{
    public class FileSizeUnitBox : Panel
    {
        public int SelectedIndex
        {
            get
            {
                return unitComboBox.SelectedIndex;
            }
            set
            {
                unitComboBox.SelectedIndex = value;
            }
        }

        public long Value
        {
            get
            {
                return (long)(valueUpDown.Value * Constants.Multiplier[unitComboBox.SelectedIndex]);
            }
        }

        public FileSizeUnitBox() : base()
        {
            initializeComponent();
        }

        private void initializeComponent()
        {
            valueUpDown = new NumericUpDown();
            unitComboBox = new ComboBox();
            SuspendLayout();
            valueUpDown.SuspendLayout();
            unitComboBox.SuspendLayout();
            //
            // valueUpDown
            //
            valueUpDown.Minimum = 0;
            valueUpDown.Maximum = long.MaxValue;
            valueUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            valueUpDown.Location = new Point(0, 1);
            valueUpDown.Size = new Size(90, 22);
            //
            // unitComboBox
            //
            unitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unitComboBox.Items.AddRange(Constants.Units);
            unitComboBox.SelectedIndex = 0;
            unitComboBox.Location = new Point(105, 0);
            unitComboBox.Size = new Size(58, 21);
            //
            // SizeUnitComboBox
            //
            Size = new Size(163, 21);
            Controls.Add(valueUpDown);
            Controls.Add(unitComboBox);
            unitComboBox.ResumeLayout(true);
            valueUpDown.ResumeLayout(true);
            ResumeLayout(true);
        }

        private NumericUpDown valueUpDown;
        private ComboBox unitComboBox;
    }
}
