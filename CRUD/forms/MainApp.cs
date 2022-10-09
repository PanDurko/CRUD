using CRUD.Core;
using CRUD.Facade;

namespace CRUD
{
    public partial class MainApp : Form
    {
        private CrudFacade _facade;

        public MainApp()
        {
            InitializeComponent();
            _facade = new CrudFacade();
            _facade.Init();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            _facade.CreateOperation.Create(int.Parse(IdTb.Text), fNameTb.Text, lNameTb.Text);
            MessageBox.Show("New user created!");
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            User user = _facade.ReadOperation.Read(int.Parse(IdTb.Text));
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
            _facade.DeleteOperation.Delete(int.Parse(IdTb.Text));
            MessageBox.Show("User deleted!");
        }
    }
}