using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using ThePhoneBook.Data.Entities;

namespace ThePhoneBook.Data;

public class AppDbContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Contacts.Add(new Contact
        {
            Name = "Sample1",
            PhoneNumber = "0000000001"
        });
    }
}