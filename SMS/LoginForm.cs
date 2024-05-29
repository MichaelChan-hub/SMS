using SMS.BLL;
using Sunny.UI;

namespace SMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            //����ҳ������
            string userName = this.UserName.Text.Trim();
            string pwd = Password.Text.Trim();
            //�����Ϣ  ---�ǿռ��
            if (string.IsNullOrEmpty(userName))
            {
                this.ShowErrorDialog("��¼ϵͳ", "�˺Ų���Ϊ��!");
                this.UserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                this.ShowErrorDialog("��¼ϵͳ", "���벻��Ϊ��!");
                this.Password.Focus();
                return;
            }
            UserBLL userBLL = new UserBLL();
            bool blLogin = userBLL.LoginSystem(userName, pwd);

            if (blLogin)
            {
                MainForm mainForm = new();
                mainForm.Tag = userName;
                mainForm.Show();
                this.Hide();
            }
            else
            {
                this.ShowErrorDialog("��¼ϵͳ", "�˺Ż��������");
            }  

        }
    }
}
