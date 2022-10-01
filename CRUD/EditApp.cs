using CRUD.Crud;

namespace CRUD
{
    public partial class EditApp : Form
    {
        private CrudOperations _operations;

        public EditApp()
        {
            InitializeComponent();
            _operations = new CrudOperations();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _operations.Update(int.Parse(targetIdTb.Text), int.Parse(newIdTb.Text), newFirstNameTb.Text, newLastNameTb.Text);
            MessageBox.Show("Changes saved!");
            this.Close();
        }
    }
}
