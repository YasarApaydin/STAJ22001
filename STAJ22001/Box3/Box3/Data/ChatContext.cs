using Microsoft.EntityFrameworkCore;
using Box3.Models;

namespace Box3.Data
{
    public class ChatContext : DbContext
    {
        public ChatContext(DbContextOptions<ChatContext> options) : base(options) { }

        public DbSet<ChatMessage> ChatMessages { get; set; }
       
    }
}

