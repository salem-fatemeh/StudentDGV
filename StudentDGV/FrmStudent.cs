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
            var person = new Person
            {
                FirstName = txtName.Text,
                LastName = txtFamily.Text,
                NationalCode= txtNationalCode.Text,
                Gender=txtGender.Text
            };

            var valid = person.Validation();
            var nCode = txtNationalCode.Text;
            var validateNationalCode = nCode.NCodeValidation();

            if (valid.IsSuccess)
            {
                if (!validateNationalCode.IsSuccess)
                {
                    MessageBox.Show(validateNationalCode.Message);
                    return;
                }
                    students.Add(person);
            }
            else
                MessageBox.Show(valid.Message);

            FillDGV();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            var nCode = txtNationalCode.Text;
            var validateNationalCode = nCode.NCodeValidation();
            if (!validateNationalCode.IsSuccess)
            {
                MessageBox.Show(validateNationalCode.Message);
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
            var validateNationalCode = nCode.NCodeValidation();
            if (!validateNationalCode.IsSuccess)
            {
                MessageBox.Show(validateNationalCode.Message);
                return;
            }
            for (int i = 0; i < students.Count; i++)
            {
                var student = students[i];
                if (student.NationalCode == nCode)
                {
                    student.FirstName= txtName.Text;
                    student.LastName= txtFamily.Text;
                    student.NationalCode = txtNationalCode.Text;
                    student.Gender= txtGender.Text;
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
