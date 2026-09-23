using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProject.UX
{
    public class CAlphabetButtonsGrid: List<Button>
    {
        private Control _parentControl;
        private int _rows;
        private int _colPerRow;
        private int colIndex;
        private int _startX = 8;
        private int _startY = 22;
        private int _spacingIncrement = 38;
        private int _currentX;
        private int _currentY;

        // ----------------------------------------------------------------------------
        public CAlphabetButtonsGrid(Control p_oParent, int p_nRows) 
        { 
            this._parentControl = p_oParent;
            this._rows = p_nRows;
            this._colPerRow = (int)Math.Ceiling(26.0 / p_nRows);

            this._parentControl.Parent.SuspendLayout(); // Stop refreshing the form to avoid flickering
            try
            {
                this.colIndex = 0;
                this._currentX = this._startX;
                this._currentY = this._startY;
                for (char cCapitalLetter = 'A'; cCapitalLetter <= 'Z'; cCapitalLetter++)
                    createButton(cCapitalLetter.ToString());
            }
            finally
            {
                this._parentControl.Parent.ResumeLayout();
            }
        }
        // ----------------------------------------------------------------------------
        private Button createButton(string p_sText)
        {
            Button oNewButton = new Button()
                                { 
                                    Location = new Point(this._currentX, this._currentY),
                                    Size = new Size(32, 32),
                                    Text = p_sText,
                                    Name = $"btnLetter{this.Count + 1}",
                                    UseVisualStyleBackColor = true,
                                    BackColor = Color.NavajoWhite
                                };

            this._parentControl.Controls.Add(oNewButton);
            this.Add(oNewButton);

            this.colIndex++;
            this._currentX += this._spacingIncrement;
            if (this.colIndex >= this._colPerRow)
            { 
                this.colIndex = 0;
                this._currentY += this._spacingIncrement;
                this._currentX = this._startX;
            }

            return oNewButton;
        }
        // ----------------------------------------------------------------------------

    }
}
