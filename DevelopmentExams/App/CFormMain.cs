using App.UX;

namespace App
{
    public partial class CFormMain : Form
    {
        public CFormMain()
        {
            InitializeComponent();
        }

        private void DoOnAnyCommand(object sender, EventArgs e)
        {
            if (sender == btnCountries)
            {   
                CFormCountries form = new CFormCountries();
                form.Visible = true;
            }
            else if (sender == btnContinents) 
            {
                CFormContinents form = new CFormContinents();
                form.Visible = true;
            }
            else if (sender == btnHighways)
            {
                CFormHighways form = new CFormHighways();
                form.Visible = true;
            }
        }
    }
}
