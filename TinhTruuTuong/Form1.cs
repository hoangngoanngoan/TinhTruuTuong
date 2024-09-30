namespace TinhTruuTuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<SinhVienIT> lsvit = new List<SinhVienIT>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVienIT svit = new SinhVienIT() 
            { 
                DiemC = double.Parse(txtDiemC.Text),
                DiemSQL = double.Parse(txtDiemSQL.Text),
                DiemOOP = double.Parse(txtDiemOOP.Text),
                HoTen = txtHoTen.Text,
            };
            svit.SetDiemTB();
            svit.DiemTB = svit.GetDiemTB();
            svit.SetXepHang();
            lsvit.Add(svit);
            dgvSinhVienIT.DataSource = null;
            dgvSinhVienIT.DataSource = lsvit;
            
        }
    }
}
