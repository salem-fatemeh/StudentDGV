namespace StudentDGV
{
    public partial class FrmFirst : Form
    {
       
        public FrmFirst()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmStudent();
            frm.ShowDialog();
            
        }

        
    }
}
