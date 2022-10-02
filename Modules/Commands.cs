using System;
using System.IO;
using System.Threading.Tasks;
using Discord.Commands;

namespace JedrusBotDiscord.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        private string _path = "../../../Quotes.txt";

        [Command("quote")]
        public async Task GetRandomQuote()
        {
            var lines = File.ReadAllLines(_path);
            var r = new Random();
            var randomLineNumber = r.Next(0, lines.Length - 1);
            var line = lines[randomLineNumber];
            await ReplyAsync(line);
        }

        [Command("dupa")]
        public async Task SayDupa()
        {
            
        }
    }
}
