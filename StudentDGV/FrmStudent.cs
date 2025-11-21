using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace StudentDGV
{
    public partial class FrmStudent : Form
    {
        List<Person> students = new List<Person>();
       
        public FrmStudent()
        {
            InitializeComponent();
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {   
            var person=new Person();
            person.FirstName = txtName.Text;
            person.LastName = txtFamily.Text;
            person.NationalCode = txtNationalCode.Text;
            person.Gender = txtGender.Text;

            var isValid = person.Validation();
            
            if (isValid.IsSuccess)
            {
                if (!txtNationalCode.Text.NCodeValidation().IsSuccess)
                {
                    MessageBox.Show(txtNationalCode.Text.NCodeValidation().Message);
                    return;
                }
                    students.Add(person);
            }
            else
                MessageBox.Show(isValid.Message);

            FillDGV();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            var nCode = txtNationalCode.Text;
            if (!txtNationalCode.Text.NCodeValidation().IsSuccess)
            {
                MessageBox.Show(txtNationalCode.Text.NCodeValidation().Message);
                return;
            }

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].NationalCode == nCode)
                    students.RemoveAt(i);
            }
            FillDGV();

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            var nCode = txtNationalCode.Text;
            if (!txtNationalCode.Text.NCodeValidation().IsSuccess)
            {
                MessageBox.Show(txtNationalCode.Text.NCodeValidation().Message);
                return;
            }
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].NationalCode == nCode)
                {
                    students[i].FirstName= txtName.Text;
                    students[i].LastName= txtFamily.Text;
                    students[i].NationalCode = txtNationalCode.Text;
                    students[i].Gender= txtGender.Text;
                }
            }
            FillDGV();

        }
        private void FillDGV()
        {
            var frmFirst = Application.OpenForms[nameof(FrmFirst)] as FrmFirst;
            frmFirst.dgvStudent.DataSource = students.ToList();
        }

        
    }
}
