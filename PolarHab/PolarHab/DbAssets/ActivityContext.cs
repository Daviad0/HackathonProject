using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace PolarHab.DbAssets
{
    public class ActivityContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Uri url;
            bool isUrl = Uri.TryCreate("postgres://iiyorjun:kRH12Wt7v5ujcE5VrCSL_H7Z5xEoa66w@lallah.db.elephantsql.com:5432/iiyorjun", UriKind.Absolute, out url);
            if (isUrl)
            {
                Console.WriteLine("Host: " + url.Host);
                Console.WriteLine("Port: " + url.Port);
                Console.WriteLine("Database: " + url.LocalPath.Substring(1));
                Console.WriteLine("Username: " + url.UserInfo.Split(':')[0]);
                Console.WriteLine("Password: " + url.UserInfo.Split(':')[1]);
                var connectionUrl = $"host={url.Host};username={url.UserInfo.Split(':')[0]};password={url.UserInfo.Split(':')[1]};database={url.LocalPath.Substring(1)};pooling=true;";
                optionsBuilder.UseNpgsql(connectionUrl);
                Console.WriteLine(connectionUrl);
            }
        }
            //=> optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=polarbearactivities;User Id=postgres;Password=HanShotFirst");
    }
}
