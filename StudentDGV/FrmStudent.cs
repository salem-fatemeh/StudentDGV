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

        private bool Validation(string name, string lastName, string gender, out string msg)
        {
            var v1 = string.IsNullOrEmpty(name);
            var v2 = string.IsNullOrEmpty(lastName);
            var v3 = string.IsNullOrEmpty(gender);
            if (v1 || v2 || v3)
            {
                msg = "لطفا اطلاعات را تکمیل کنید";
                return false;
            }
            msg = "";
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg;
            string name = txtName.Text;
            string lastName = txtFamily.Text;
            string gender = txtGender.Text;
            int natioalCode = int.Parse(txtNationalCode.Text);

            var valid = Validation(name, lastName, gender, out msg);
            if (!valid)
            {
                MessageBox.Show(msg);
                return;
            }

            var Person = new Person();
            Person.FirstName = txtName.Text;
            Person.LastName = txtFamily.Text;
            Person.NationalCode = txtNationalCode.Text;
            Person.Gender = txtGender.Text;

            var frmFirst = Application.OpenForms[nameof(FrmFirst)] as FrmFirst;
            students.Add(Person);
            FillDGV();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            var nCode = txtNationalCode.Text;
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
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].NationalCode == nCode)
                {
                    students[i].FirstName= txtName.Text;
                    students[i].LastName= txtFamily.Text;
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
