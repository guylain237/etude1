using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etude1
{
    public partial class FormUsers : Form
    {
        public IUserrepository Userrepository { get; }

        public FormUsers(IUserrepository userrepository)
        {
            InitializeComponent();
            this.Userrepository = userrepository;
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            IEnumerable<User> users = this.Userrepository.getall();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = users;


        }

        private void butcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butsave_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(textusername.Text, textpassword.Text, textfullname.Text);
               
                this.Userrepository.ADD(user);
                MessageBox.Show("save done!",
                    "confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            catch(Exception ex)
            {
                MessageBox.Show("an error occured!",
                   "error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
                   );
            }
        }
    }
}
