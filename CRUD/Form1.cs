using CRUD.Core;
using CRUD.Crud;

namespace CRUD
{
    public partial class Form1 : Form
    {
        private CrudOperations _operations;

        public Form1()
        {
            InitializeComponent();
            _operations = new CrudOperations();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            _operations.Create(int.Parse(IdTb.Text), fNameTb.Text, lNameTb.Text);
            MessageBox.Show("New user created!");
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            User user = _operations.Read(int.Parse(IdTb.Text));
            fNameTb.Text = user.FirstName;
            lNameTb.Text = user.LastName;
            MessageBox.Show("Got user info!");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _operations.Update(int.Parse(IdTb.Text), fNameTb.Text, lNameTb.Text);
            MessageBox.Show("User info updated!");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _operations.Delete(int.Parse(IdTb.Text));
            MessageBox.Show("User deleted!");
        }
    }
}