namespace asdasda.Models
{
    public class SinhVien
    {
        public Guid id { get; set; }
        public string? Ten { get; set; }
        public int Tuoi { get; set; }
        public string? GioiTinh { get; set; }
        public ICollection<KHCT> KHCTs { get; set; } = new List<KHCT>();
    }
}
