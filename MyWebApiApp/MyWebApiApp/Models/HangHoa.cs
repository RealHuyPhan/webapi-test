namespace MyWebApiApp.Models
{
    public class HangHoaVM
    {
        public string TenHoangHoa { get; set; }
        public double DonGia { get; set; }
    }
    public class HangHoa : HangHoaVM
    {
        public Guid MaHangHoa { get; set; }
    }
}
