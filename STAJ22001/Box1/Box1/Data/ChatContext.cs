using Microsoft.EntityFrameworkCore;
using Box1.Models;

namespace Box1.Data
{
    public class ChatContext : DbContext
    {
        public ChatContext(DbContextOptions<ChatContext> options) : base(options) { }

        public DbSet<ChatMessage> ChatMessages { get; set; }
    }
}

