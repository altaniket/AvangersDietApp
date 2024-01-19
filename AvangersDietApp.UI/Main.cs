using AvangersDietApp.DAL.Concrate;
using AvangersDietApp.DAL.Context;

namespace AvangersDietApp.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        AvangersContext context=new AvangersContext();
        private void btn_Yonetici_Click(object sender, EventArgs e)
        {
            
            Admin admin = context.Admin.FirstOrDefault();

           
                if (string.IsNullOrWhiteSpace(txt_Admin.Text)||string.IsNullOrWhiteSpace(msk_AdminPass.Text))
                {
                    MessageBox.Show("L�tfen y�netici ad� ve �ifrenizi giriniz.");
                    txt_Admin.Text = "";
                    msk_AdminPass.Text = "";
                }
                else if (admin.AdminName!=txt_Admin.Text)
                {
                    MessageBox.Show("Y�netici ad�n�z hatal�! L�tfen tekrar giriniz.");
                    txt_Admin.Text = "";
                    msk_AdminPass.Text = "";
                }
                else if (admin.Password!= msk_AdminPass.Text)
                {
                    MessageBox.Show("�ifreniz hatal�! L�tfen tekrar giriniz.");
                    txt_Admin.Text = "";
                    msk_AdminPass.Text = "";
                }
                else
                {

                    AdminOperations adminOperations = new AdminOperations();
                    adminOperations.Show();
                    this.Hide();
                }
            
           

        }

        private void btn_Uye_Click(object sender, EventArgs e)
        {
            User user = context.Users.FirstOrDefault(a => a.UserName == txt_User.Text && a.Password==msk_UserPass.Text);

            SessionManger.CurrentUser = user;
           

            if (string.IsNullOrWhiteSpace(txt_User.Text)||string.IsNullOrWhiteSpace(msk_UserPass.Text))
            {
                MessageBox.Show("L�tfen y�netici ad� ve �ifrenizi giriniz.");
                txt_User.Text= "";
                msk_UserPass.Text = "";
            }
            else if (user == null)
            {
                MessageBox.Show("Kullan�c� bulunamad�");
                txt_Admin.Text = "";
                msk_AdminPass.Text = "";
            }
            else if (user.UserName!=txt_User.Text)
            {
                MessageBox.Show("Kullan�c� ad�n�z hatal�! L�tfen tekrar giriniz.");
                txt_User.Text = "";
                msk_UserPass.Text = "";
            }
            else if (user.Password!= msk_UserPass.Text)
            {
                MessageBox.Show("�ifreniz hatal�! L�tfen tekrar giriniz.");
                txt_User.Text = "";
                msk_UserPass.Text = "";
            }
            else
            {
                UserMain userMain = new UserMain();
                userMain.Show();
                this.Hide();
            }
        }

        private void Btn_UyeOl_Click(object sender, EventArgs e)
        {
            
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();

        }
    }
}
