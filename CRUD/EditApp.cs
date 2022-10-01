using CRUD.Facade;

namespace CRUD
{
    public partial class EditApp : Form
    {
        private CrudFacade _facade;

        public EditApp()
        {
            InitializeComponent();
            _facade = new CrudFacade();
            _facade.Init();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _facade.UpdateOperation.Update(int.Parse(targetIdTb.Text), int.Parse(newIdTb.Text), newFirstNameTb.Text, newLastNameTb.Text);
            MessageBox.Show("Changes saved!");
            this.Close();
        }
    }
}
