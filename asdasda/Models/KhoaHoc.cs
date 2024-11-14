namespace asdasda.Models
{
    public class KhoaHoc
    {
        public string MaPB { get; set; }
        public string TenKH { get; set; }

        public ICollection<KHCT> KHCTs { get; set; } = new List<KHCT>();
    }
}
