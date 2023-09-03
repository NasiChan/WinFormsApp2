namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnShow_Click(object sender, EventArgs e)
        {
            #region check phone number
            string str = txtPhoneNumber.Text;
            int len = txtPhoneNumber.Text.Length;

            if (len == 12)
            {
                string strFinal ="0"+ str.Substring(4, 12);
                txtPhoneNumber.Text = strFinal;

            }
            else if(len>11)
            {
                MessageBox.Show("کاربر گرامی شما داری اشتباه میزنی");
            }
            
            #endregion

            #region Print

            string valSex = "";
            bool ischecked = radioButtonSexFemale.Checked;
            if (ischecked)
            {
                valSex = radioButtonSexFemale.Text;
            }
            else
            {
                valSex = radioButtonSexMale.Text;
            }

            string msg = "";
            msg =" "+"نام : " + txtFirstName.Text+" ، " ;
            msg = " " + msg +  "نام خانوادگی  : " + txtLastName.Text+ " ، ";
            msg = " " + msg + "شماره تلفن همراه  : " + txtPhoneNumber.Text + " ، ";
            msg = " " + msg + "کدملی  : " + txtNationalNumber.Text + " ، ";
            msg = " " + msg + "جنسیت  : " + valSex;
            lblMassage.Text = msg;

            #endregion

        

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

          

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode > Keys.D0 && e.KeyCode < Keys.D9 && e.Shift))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

            //if ((e.KeyChar >= '0' && e.KeyChar <= '9')  ) 


            //    e.Handled = true;
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a'&& e.KeyChar <= 'z') || 
                (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || 
                (e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))

                e.Handled = true;
        }

        private void txtNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}