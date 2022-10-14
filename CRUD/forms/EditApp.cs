using CRUD.Facade;

namespace CRUD.forms
{
    public partial class EditApp : Form
    {
        private readonly CrudFacade _facade;

        public EditApp()
        {
            InitializeComponent();
            _facade = new CrudFacade();
            _facade.Init();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _facade.UpdateOperation.Update(int.Parse(targetIdTb.Text), newFirstNameTb.Text, newLastNameTb.Text);
            MessageBox.Show("Changes saved!");
            Close();
        }
    }
}
