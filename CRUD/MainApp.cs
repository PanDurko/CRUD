using CRUD.Core;
using CRUD.Crud;

namespace CRUD
{
    public partial class MainApp : Form
    {
        private CrudOperations _operations;

        public MainApp()
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
            EditApp editForm = new EditApp();
            editForm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _operations.Delete(int.Parse(IdTb.Text));
            MessageBox.Show("User deleted!");
        }
    }
}