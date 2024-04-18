using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Metadata.Models
{
    public class Music
    {
        public Music(string name, string title)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }

        public string Name { get; set; }
        public string Title { get; set; }
    }
}