using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BTBuoi6
{
    public partial class Form1 : Form
    {
        private Model1 context;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (context == null)
                {
                    context = new Model1();
                }

                List<khoa> listFalcultys = context.khoa.ToList();
                List<sinhvien> listStudent = context.sinhvien.ToList();
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillFalcultyCombobox(List<khoa> listFalcultys)
        {
            comboBoxKhoa.DataSource = listFalcultys;
            comboBoxKhoa.DisplayMember = "ten_khoa";
            comboBoxKhoa.ValueMember = "ma_khoa";
        }

        private void BindGrid(List<sinhvien> listStudent)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.id;
                dataGridView1.Rows[index].Cells[1].Value = item.ten;
                dataGridView1.Rows[index].Cells[2].Value = item.khoa.ten_khoa;
                dataGridView1.Rows[index].Cells[3].Value = item.diem_trung_binh;
            }
        }

        private void ClearForm()
        {
            txtID.Clear();
            txtHoTen.Clear();
            txtDTB.Clear();
            comboBoxKhoa.SelectedIndex = -1;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu thông tin không đầy đủ
                if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtDTB.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra điểm trung bình hợp lệ
                
                if (comboBoxKhoa.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                float diemTrungBinh = float.Parse(txtDTB.Text);
                diemTrungBinh = (float)Math.Round(diemTrungBinh, 2);

                sinhvien s = new sinhvien()
                {
                    id = int.Parse(txtID.Text),
                    ten = txtHoTen.Text,
                    diem_trung_binh = diemTrungBinh,
                    ma_khoa = Convert.ToInt32(comboBoxKhoa.SelectedValue)
                };
                context.sinhvien.Add(s);
                context.SaveChanges();
                LoadData();
                ClearForm();
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtDTB.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }    
                if (comboBoxKhoa.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idToUpdate = int.Parse(txtID.Text);
                sinhvien dbUpdate = context.sinhvien.FirstOrDefault(p => p.id == idToUpdate);
         
                float diemTrungBinh = float.Parse(txtDTB.Text);
                diemTrungBinh = (float)Math.Round(diemTrungBinh, 2);
                if (dbUpdate != null)
                {
                    dbUpdate.ten = txtHoTen.Text;
                    dbUpdate.diem_trung_binh = diemTrungBinh;
                    dbUpdate.ma_khoa = (int)comboBoxKhoa.SelectedValue;

                    context.SaveChanges();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int idToDelete = int.Parse(txtID.Text);
                sinhvien dbDelete = context.sinhvien.FirstOrDefault(sv => sv.id == idToDelete);

                if (dbDelete != null)
                {
                    context.sinhvien.Remove(dbDelete);
                    context.SaveChanges();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int selectedStudentId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    sinhvien selectedStudent = context.sinhvien.FirstOrDefault(sv => sv.id == selectedStudentId);

                    if (selectedStudent != null)
                    {
                        txtID.Text = selectedStudent.id.ToString();
                        txtHoTen.Text = selectedStudent.ten;
                        txtDTB.Text = selectedStudent.diem_trung_binh.ToString();
                        comboBoxKhoa.SelectedValue = selectedStudent.ma_khoa;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
