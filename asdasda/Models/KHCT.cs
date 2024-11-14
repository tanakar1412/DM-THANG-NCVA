namespace asdasda.Models
{
    public class KHCT
    {
        public Guid id { get; set; }
        public Guid? SinhVienID { get; set; }
        public string? KhoaHocID { get; set; }
        public SinhVien? SinhVien { get; set; }
        public KhoaHoc? KhoaHoc { get; set; }
    }
}
