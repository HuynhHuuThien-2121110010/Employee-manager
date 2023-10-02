using Exercise_001.BAL;
using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Exercise_001.GUI
{
    public partial class Employee : Form
    {
        EmployeeBAL empBAL = new EmployeeBAL();
        TypeEmployeeBAL typeempBAL = new TypeEmployeeBAL();
        DepartmentBAL departmentBAL = new DepartmentBAL();
        JobBAL jobBAL = new JobBAL();
        PositionBAL positionBAL = new PositionBAL();
        EducationBAL eductionBAL = new EducationBAL();
        LanguageBAL languageBAL = new LanguageBAL();
        NationBAL nationBAL = new NationBAL();
        NationalityBAL nationalityBAL = new NationalityBAL();
        DegreeBAL degreeBAL = new DegreeBAL();
        InformaticsBAL InformaticsBAL = new InformaticsBAL();
        ReligionBAL ReligionBAL = new ReligionBAL();
        private byte[] selectedImageBytes;
        EmployeeBEL emp;
        public bool co = false;
        public Employee()
        {
            InitializeComponent();
        }
        public Employee(EmployeeBEL emp) : this()
        {
            this.emp = emp;
            co = true;
            tbId.ReadOnly = true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            EmployeeBEL emp = new EmployeeBEL();
            if (co==false)
            {
                emp.EmployeeId = tbId.Text;
                emp.EmployeeName = tbName.Text;
                emp.Gender = cbGender.Checked;
                emp.Married = cbFamily.Checked;
                emp.Phone = tbPhone.Text;
                emp.Alias = tbAlias.Text;
                emp.Email = tbEmail.Text;
                emp.Birthday = tbBirthday.Value;
                emp.BirthdayPlace = tbBirthdayPlace.Text;
                emp.CIDNumber = tbCIDNumber.Text;
                emp.CIDDate = dtpCIDDate.Value;
                emp.CIDPlaceOfIssue = tbCIDPlaceOfIssue.Text;
                emp.Hometown = tbHometown.Text;
                emp.PermanentAddress = tbPermanentAddress.Text;
                emp.TemporaryAddress = tbTemporaryAddress.Text;
                if (ptImage.Image != null)
                {
                    System.Drawing.Image image = ptImage.Image;
                    byte[] imagedata = ConvertImageToByteArray(image);
                    emp.Image = imagedata;
                }
                else
                {
                    emp.Image = null;
                }
                emp.TypeEmployee = (TypeEmployeeBEL)cbTypeEmployee.SelectedItem;
                emp.InDate = dtpInDate.Value;
                emp.Department = (DepartmentBEL)cbDepartment.SelectedItem;
                emp.Job =(JobBEL)cbJob.SelectedItem;
                emp.Position = (PositionBEL)cbPosition.SelectedItem;
                emp.Basicsalary = tbLuongCoBan.Text;
                emp.Coefficient = tbHeSo.Text;
                emp.Wage=tbMucLuong.Text;
                emp.Allowance=tbPhuCap.Text;
                emp.NumberBook=tbSoSoLaoDong.Text;
                emp.CIDate = dtbngaycap.Value;
                emp.PlaceOfIssue = tbNoiCap.Text;
                emp.BankAccount = tbTkNganHang.Text;
                emp.BankName = tbNganHang.Text;
                emp.Education = (EducationBEL)cbEduction.SelectedItem;
                emp.Degree = (DegreeBEL)cbDegree.SelectedItem;
                emp.Language = (LanguageBEL)cbLanguage.SelectedItem;
                emp.Informatics = (InformaticsBEL)cbInformatics.SelectedItem;
                emp.Nation = (NationBEL)cbNation.SelectedItem;
                emp.Nationality = (NationalityBEL)cbNationality.SelectedItem;
                emp.Religion = (ReligionBEL)cbReligion.SelectedItem;
                empBAL.NewEmployee(emp);
                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
                this.Hide();
                EmployeeList empList = new EmployeeList();
                empList.Show();
            }
            else
            {
                emp.EmployeeId = tbId.Text;
                emp.EmployeeName = tbName.Text;
                emp.Gender = cbGender.Checked;
                emp.Married = cbFamily.Checked;
                emp.Phone = tbPhone.Text;
                emp.Alias = tbAlias.Text;
                emp.Email = tbEmail.Text;
                emp.Birthday = tbBirthday.Value;
                emp.BirthdayPlace = tbBirthdayPlace.Text;
                emp.CIDNumber = tbCIDNumber.Text;
                emp.CIDDate = dtpCIDDate.Value;
                emp.CIDPlaceOfIssue = tbCIDPlaceOfIssue.Text;
                emp.Hometown = tbHometown.Text;
                emp.PermanentAddress = tbPermanentAddress.Text;
                emp.TemporaryAddress = tbTemporaryAddress.Text;
                if (ptImage.Image != null)
                {
                    System.Drawing.Image image = ptImage.Image;
                    byte[] imagedata = ConvertImageToByteArray(image);
                    emp.Image = imagedata;
                }
                else
                {
                    emp.Image = null;
                }
                emp.TypeEmployee = (TypeEmployeeBEL)cbTypeEmployee.SelectedItem;
                emp.TypeEmployeeId = emp.TypeEmployee.TypeEmployeeId;
                emp.InDate = dtpInDate.Value;
                emp.Department = (DepartmentBEL)cbDepartment.SelectedItem;
                emp.DepartmentId = emp.Department.DepartmentId;
                emp.Job = (JobBEL)cbJob.SelectedItem;
                emp.JobId = emp.Job.JobId;
                emp.Position = (PositionBEL)cbPosition.SelectedItem;
                emp.PositionId = emp.Position.PositionId;
                emp.Basicsalary = tbLuongCoBan.Text;
                emp.Coefficient = tbHeSo.Text;
                emp.Wage = tbMucLuong.Text;
                emp.Allowance = tbPhuCap.Text;
                emp.NumberBook = tbSoSoLaoDong.Text;
                emp.CIDate = dtbngaycap.Value;
                emp.PlaceOfIssue = tbNoiCap.Text;
                emp.BankAccount = tbTkNganHang.Text;
                emp.BankName = tbNganHang.Text;
                emp.Education = (EducationBEL)cbEduction.SelectedItem;
                emp.EducationId = emp.Education.EducationId;
                emp.Degree = (DegreeBEL)cbDegree.SelectedItem;
                emp.DegreeId = emp.Degree.DegreeId;
                emp.Language = (LanguageBEL)cbLanguage.SelectedItem;
                emp.LanguageId = emp.Language.LanguageId;
                emp.Informatics = (InformaticsBEL)cbInformatics.SelectedItem;
                emp.InformaticsId = emp.Informatics.InformaticsId;
                emp.Nation = (NationBEL)cbNation.SelectedItem;
                emp.NationId = emp.Nation.NationId;
                emp.Nationality = (NationalityBEL)cbNationality.SelectedItem;
                emp.NationalityId = emp.Nationality.NationalityId;
                emp.Religion = (ReligionBEL)cbReligion.SelectedItem;
                emp.ReligionId = emp.Religion.ReligionId;
                empBAL.EditEmployee(emp);
                MessageBox.Show("Đã Lưu", "Thông Báo", MessageBoxButtons.OK);
                this.Hide();
                EmployeeList empList = new EmployeeList();
                empList.Show();

            }
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            if (co==false)
            {
                List<TypeEmployeeBEL> lstTtpeEmployee = typeempBAL.ReadTypeEmployeeList();
                foreach (TypeEmployeeBEL type in lstTtpeEmployee)
                {
                    cbTypeEmployee.Items.Add(type);
                }
                cbTypeEmployee.DisplayMember = "TypeEmployeeName";
                List<DepartmentBEL> lstdepartment = departmentBAL.ReadDepartmentList();
                foreach (DepartmentBEL department in lstdepartment)
                {
                    cbDepartment.Items.Add(department);
                }
                cbDepartment.DisplayMember = "DepartmentName";
                List<JobBEL> lstjob = jobBAL.ReadJobList();
                foreach (JobBEL job in lstjob)
                {
                    cbJob.Items.Add(job);
                }
                cbJob.DisplayMember = "JobName";
                List<PositionBEL> lstpos = positionBAL.ReadPositionList();
                foreach (PositionBEL pos in lstpos)
                {
                    cbPosition.Items.Add(pos);
                }
                cbPosition.DisplayMember = "PositionName";
                List<EducationBEL> lstedc = eductionBAL.ReadEducationList();
                foreach (EducationBEL edc in lstedc)
                {
                    cbEduction.Items.Add(edc);
                }
                cbEduction.DisplayMember = "EducationName";
                List<LanguageBEL> lstlan = languageBAL.ReadLanguageList();
                foreach (LanguageBEL lan in lstlan)
                {
                    cbLanguage.Items.Add(lan);
                }
                cbLanguage.DisplayMember = "LanguageName";
                List<NationBEL> lstnto = nationBAL.ReadNationList();
                foreach (NationBEL nto in lstnto)
                {
                    cbNation.Items.Add(nto);
                }
                cbNation.DisplayMember = "NationName";
                List<NationalityBEL> lstntolt = nationalityBAL.ReadNationalityList();
                foreach (NationalityBEL ntolt in lstntolt)
                {
                    cbNationality.Items.Add(ntolt);
                }
                cbNationality.DisplayMember = "NationalityName";
                List<DegreeBEL> lstdgr = degreeBAL.ReadDegreeList();
                foreach (DegreeBEL ntolt in lstdgr)
                {
                    cbDegree.Items.Add(ntolt);
                }
                cbDegree.DisplayMember = "DegreeName";
                List<InformaticsBEL> lstimt= InformaticsBAL.ReadInformaticsList();
                foreach (InformaticsBEL ntolt in lstimt)
                {
                    cbInformatics.Items.Add(ntolt);
                }
                cbInformatics.DisplayMember = "InformaticsName";
                List<ReligionBEL> lstrlg = ReligionBAL.ReadReligionList();
                foreach (ReligionBEL ntolt in lstrlg)
                {
                    cbReligion.Items.Add(ntolt);
                }
                cbReligion.DisplayMember = "ReligionName";
            }
            else
            {
                this.tbId.Text = emp.EmployeeId;
                this.tbName.Text = emp.EmployeeName;
                this.tbAlias.Text = emp.Alias;
                if(emp.Married == true)
                {
                    this.cbFamily.Checked = true;
                }    
                if(emp.Gender == true)
                {
                    this.cbGender.Checked = true;
                }
                byte[] imagedata = emp.Image;
                System.Drawing.Image image = ByteArrayToImage(imagedata);
                this.ptImage.Image = image;
                this.tbEmail.Text = emp.Email;
                this.tbPhone.Text = emp.Phone;
                this.tbBirthday.Value = emp.Birthday;
                this.tbBirthdayPlace.Text = emp.BirthdayPlace;
                this.tbCIDNumber.Text = emp.CIDNumber;
                this.dtpCIDDate.Value = emp.CIDDate;
                this.tbCIDPlaceOfIssue.Text = emp.CIDPlaceOfIssue;
                this.tbHometown.Text = emp.Hometown;
                this.tbPermanentAddress.Text = emp.PermanentAddress;
                this.tbTemporaryAddress.Text = emp.TemporaryAddress;
                List<TypeEmployeeBEL> lstTtpeEmployee = typeempBAL.ReadTypeEmployeeList();
                foreach (TypeEmployeeBEL type in lstTtpeEmployee)
                {
                    cbTypeEmployee.Items.Add(type);
                }
                cbTypeEmployee.DisplayMember = "TypeEmployeeName";
                this.cbTypeEmployee.Text = emp.TypeEmployeeId;
                this.dtpInDate.Value = emp.InDate;
                List<DepartmentBEL> lstdepartment = departmentBAL.ReadDepartmentList();
                foreach (DepartmentBEL department in lstdepartment)
                {
                    cbDepartment.Items.Add(department);
                }
                cbDepartment.DisplayMember = "DepartmentName";
                this.cbDepartment.Text = emp.DepartmentId;
                this.tbLuongCoBan.Text = emp.Basicsalary;
                List<JobBEL> lstjob = jobBAL.ReadJobList();
                foreach (JobBEL job in lstjob)
                {
                    cbJob.Items.Add(job);
                }
                cbJob.DisplayMember = "JobName";
                this.cbJob.Text = emp.JobId;
                List<PositionBEL> lstpos = positionBAL.ReadPositionList();
                foreach (PositionBEL pos in lstpos)
                {
                    cbPosition.Items.Add(pos);
                }
                cbPosition.DisplayMember = "PositionName";
                this.cbPosition.Text = emp.PositionId;
                this.tbHeSo.Text = emp.Coefficient;
                this.tbMucLuong.Text = emp.Wage;
                this.tbPhuCap.Text = emp.Allowance;
                this.tbSoSoLaoDong.Text = emp.NumberBook;
                this.dtbngaycap.Value = emp.CIDate;
                this.tbNoiCap.Text = emp.PlaceOfIssue;
                this.tbTkNganHang.Text = emp.BankAccount;
                this.tbNganHang.Text = emp.BankName;
                List<EducationBEL> lstedc = eductionBAL.ReadEducationList();
                foreach (EducationBEL edc in lstedc)
                {
                    cbEduction.Items.Add(edc);
                }
                cbEduction.DisplayMember = "EducationName";
                this.cbEduction.Text= emp.EducationId;
                List<LanguageBEL> lstlan = languageBAL.ReadLanguageList();
                foreach (LanguageBEL lan in lstlan)
                {
                    cbLanguage.Items.Add(lan);
                }
                cbLanguage.DisplayMember = "LanguageName";
                this.cbLanguage.Text= emp.LanguageId;   
                List<NationBEL> lstnto = nationBAL.ReadNationList();
                foreach (NationBEL nto in lstnto)
                {
                    cbNation.Items.Add(nto);
                }
                cbNation.DisplayMember = "NationName";
                this.cbNation.Text= emp.NationId;
                List<NationalityBEL> lstntolt = nationalityBAL.ReadNationalityList();
                foreach (NationalityBEL ntolt in lstntolt)
                {
                    cbNationality.Items.Add(ntolt);
                }
                cbNationality.DisplayMember = "NationalityName";
                this.cbNationality.Text= emp.NationalityId;
                List<DegreeBEL> lstdgr = degreeBAL.ReadDegreeList();
                foreach (DegreeBEL ntolt in lstdgr)
                {
                    cbDegree.Items.Add(ntolt);
                }
                cbDegree.DisplayMember = "DegreeName";
                this.cbDegree.Text= emp.DegreeId;
                List<InformaticsBEL> lstimt = InformaticsBAL.ReadInformaticsList();
                foreach (InformaticsBEL ntolt in lstimt)
                {
                    cbInformatics.Items.Add(ntolt);
                }
                cbInformatics.DisplayMember = "InformaticsName";
                this.cbInformatics.Text= emp.InformaticsId;
                List<ReligionBEL> lstrlg = ReligionBAL.ReadReligionList();
                foreach (ReligionBEL ntolt in lstrlg)
                {
                    cbReligion.Items.Add(ntolt);
                }
                cbReligion.DisplayMember = "ReligionName";
                this.cbReligion.Text= emp.ReligionId;
            }

        }
        private void ptImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png, *.jpg, *.jpeg, *.gif, *.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ptImage.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                selectedImageBytes = ConvertImageToByteArray(ptImage.Image);
                ptImage.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }
        private byte[] ConvertImageToByteArray(System.Drawing.Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {   
                image.Save(ms, image.RawFormat);
                ptImage.SizeMode = PictureBoxSizeMode.Zoom;
                return ms.ToArray();
            }
        }
        private System.Drawing.Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                return image;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không","Thông Báo!",MessageBoxButtons.YesNo)==DialogResult.Yes) 
            {
                this.Hide();
                EmployeeList emlst = new EmployeeList();
                emlst.Show();
            }
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            EmployeeList emplis = new EmployeeList();
            emplis.Show();
        }

        private void tbMucLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
