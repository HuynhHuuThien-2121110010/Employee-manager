using Exercise_001.BAL;
using Exercise_001.GUI;
using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Xml.Linq;

namespace Exercise_001
{
    public partial class EmployeeList : Form
    {
        EmployeeBAL empBAL = new EmployeeBAL();
        private string indx;
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.ShowDialog();
            this.Hide();
        }

        public void EmployeeList_Load(object sender, EventArgs e)
        {
            List<EmployeeBEL> lstemp = empBAL.ReadEmployee();
            foreach (EmployeeBEL emp in lstemp)
            {
                dgvEmployee.Rows.Add(emp.EmployeeId,emp.EmployeeName,emp.Gender,emp.Married,emp.Image,emp.Phone,emp.Alias,emp.Email,emp.Birthday,emp.BirthdayPlace,emp.CIDNumber,emp.CIDDate,emp.CIDPlaceOfIssue,emp.Hometown,emp.PermanentAddress,emp.TemporaryAddress,emp.TypeEmployee.TypeEmployeeName,emp.InDate,emp.Department.DepartmentName,emp.Job.JobName,emp.Position.PositionName,emp.Basicsalary,emp.Coefficient,emp.Wage,emp.Allowance,emp.NumberBook,emp.CIDate,emp.PlaceOfIssue,emp.BankAccount,emp.BankName,emp.Education.EducationName,emp.Degree.DegreeName,emp.Language.LanguageName,emp.Informatics.InformaticsName,emp.Nation.NationName,emp.Nationality.NationalityName,emp.Religion.ReligionName);
            }
        }
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dgvEmployee.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                indx = row.Cells[0].Value.ToString();
                
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (indx != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa Nhân viên " + indx + " Không?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EmployeeBEL emp = new EmployeeBEL();
                    emp.EmployeeId = indx;
                    empBAL.DeleteEmployee(emp);
                    int idx = dgvEmployee.CurrentCell.RowIndex;
                    dgvEmployee.Rows.RemoveAt(idx);
                }

            }
            else
            {
                MessageBox.Show("Không có Nhân viên để xóa", "Thông báo!", MessageBoxButtons.OK);
            }
        }

        private void EmployeeList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvEmployee.CurrentRow;
            if (row != null)
            {
                EmployeeBEL emp = new EmployeeBEL();
                emp.EmployeeId = row.Cells[0].Value.ToString();
                emp.EmployeeName = row.Cells[1].Value.ToString();
                emp.Gender = (bool?)row.Cells[2].Value;
                emp.Married = (bool?)row.Cells[3].Value;
                emp.Image = (byte[])row.Cells[4].Value;
                emp.Phone = row.Cells[5].Value.ToString();
                emp.Alias = row.Cells[6].Value.ToString();
                emp.Email = row.Cells[7].Value.ToString();
                emp.Birthday = Convert.ToDateTime(row.Cells[8].Value);
                emp.BirthdayPlace = row.Cells[9].Value.ToString();
                emp.CIDNumber = row.Cells[10].Value.ToString();
                emp.CIDDate = Convert.ToDateTime(row.Cells[11].Value);
                emp.CIDPlaceOfIssue = row.Cells[12].Value.ToString();
                emp.Hometown = row.Cells[13].Value.ToString();
                emp.PermanentAddress = row.Cells[14].Value.ToString();
                emp.TemporaryAddress = row.Cells[15].Value.ToString();
                emp.TypeEmployeeId = row.Cells[16].Value.ToString();
                emp.InDate= Convert.ToDateTime(row.Cells[17].Value);
                emp.DepartmentId = row.Cells[18].Value.ToString();
                emp.JobId = row.Cells[19].Value.ToString();
                emp.PositionId = row.Cells[20].Value.ToString();
                emp.Basicsalary = row.Cells[21].Value.ToString();
                emp.Coefficient = row.Cells[22].Value.ToString();
                emp.Wage = row.Cells[23].Value.ToString();
                emp.Allowance = row.Cells[24].Value.ToString();
                emp.NumberBook = row.Cells[25].Value.ToString();
                emp.CIDate = Convert.ToDateTime(row.Cells[26].Value);
                emp.PlaceOfIssue = row.Cells[27].Value.ToString();
                emp.BankAccount = row.Cells[28].Value.ToString();
                emp.BankName = row.Cells[29].Value.ToString();
                emp.EducationId = row.Cells[30].Value.ToString();
                emp.DegreeId = row.Cells[31].Value.ToString();
                emp.LanguageId = row.Cells[32].Value.ToString();
                emp.InformaticsId = row.Cells[33].Value.ToString();
                emp.NationId = row.Cells[34].Value.ToString();
                emp.NationalityId = row.Cells[35].Value.ToString();
                emp.ReligionId = row.Cells[36].Value.ToString();
                Employee empgui = new Employee(emp);
                empgui.ShowDialog();
                this.Hide();
                //row.Cells[0].Value = emp.EmployeeId;
                //row.Cells[1].Value = emp.EmployeeName;
                //row.Cells[2].Value = emp.Gender;
                //row.Cells[3].Value = emp.Married;
                //row.Cells[4].Value = emp.Image;
                //row.Cells[5].Value = emp.Phone;
                //row.Cells[6].Value = emp.Alias;
                //row.Cells[7].Value = emp.Email;
                //row.Cells[8].Value = emp.Birthday;
                //row.Cells[9].Value = emp.BirthdayPlace;
                //row.Cells[10].Value = emp.CIDNumber;
                //row.Cells[11].Value = emp.CIDDate;
                //row.Cells[12].Value = emp.CIDPlaceOfIssue;
                //row.Cells[13].Value = emp.Hometown;
                //row.Cells[14].Value = emp.PermanentAddress;
                //row.Cells[15].Value = emp.TemporaryAddress;
                //row.Cells[16].Value = emp.TypeEmployeeId;
                //row.Cells[17].Value = emp.InDate;
                //row.Cells[18].Value = emp.DepartmentId;
                //row.Cells[19].Value = emp.JobId;
                //row.Cells[20].Value = emp.PositionId;
                //row.Cells[21].Value = emp.Basicsalary;
                //row.Cells[22].Value = emp.Coefficient;
                //row.Cells[23].Value = emp.Wage;
                //row.Cells[24].Value = emp.Allowance;
                //row.Cells[25].Value = emp.NumberBook;
                //row.Cells[26].Value = emp.CIDate;
                //row.Cells[27].Value = emp.PlaceOfIssue;
                //row.Cells[28].Value = emp.BankAccount;
                //row.Cells[29].Value = emp.BankName;
                //row.Cells[30].Value = emp.EducationId;
                //row.Cells[31].Value = emp.DegreeId;
                //row.Cells[32].Value = emp.LanguageId;
                //row.Cells[33].Value = emp.InformaticsId;
                //row.Cells[34].Value = emp.NationId;
                //row.Cells[35].Value = emp.NationalityId;
                //row.Cells[36].Value = emp.ReligionId;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?","Thông báo!",MessageBoxButtons.YesNo)==DialogResult.Yes) 
            {
                Application.Exit();
            }
        }
    }
}
