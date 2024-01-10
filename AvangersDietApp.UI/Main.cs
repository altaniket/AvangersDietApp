using AvangersDietApp.DAL.Concrate;

namespace AvangersDietApp.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_Yonetici_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.AdminName=txt_Admin.Text;
            admin.Password=msk_AdminPass.Text;

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
                adminOperations.ShowDialog();
                this.Close();
            }

        }
    }
}
