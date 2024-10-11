using Box1.Data;
using Box1.Models;
using Microsoft.AspNetCore.SignalR;

namespace Box1.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ChatContext _context;

        public ChatHub(ChatContext context)
        {
            _context = context;
        }

        public async Task SendMessage(string kullaniciAdi, string mesaj)
        {
            var chatMessage = new ChatMessage
            {
                KullaniciAdi = kullaniciAdi,
                Mesaj = mesaj,
                Zamanlayici = DateTime.Now
            };

            _context.ChatMessages.Add(chatMessage);
            await _context.SaveChangesAsync();

            await Clients.All.SendAsync("ReceiveMessage", kullaniciAdi, mesaj);
        }
    }
}
