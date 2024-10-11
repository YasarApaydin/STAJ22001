namespace Box1.Models
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? Mesaj { get; set; }
        public DateTime Zamanlayici { get; set; }
    }

}
