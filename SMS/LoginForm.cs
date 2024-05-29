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
            //接收页面输入
            string userName = this.UserName.Text.Trim();
            string pwd = Password.Text.Trim();
            //检查信息  ---非空检查
            if (string.IsNullOrEmpty(userName))
            {
                this.ShowErrorDialog("登录系统", "账号不能为空!");
                this.UserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                this.ShowErrorDialog("登录系统", "密码不能为空!");
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
                this.ShowErrorDialog("登录系统", "账号或密码错误！");
            }  

        }
    }
}
