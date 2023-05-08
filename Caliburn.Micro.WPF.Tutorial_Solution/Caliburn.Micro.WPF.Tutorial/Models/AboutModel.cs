using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.WPF.Tutorial.Models
{
    public class AboutModel
    {
        public string Title { get; set; } = "Caliburn.Micro Tutorial";
        public string Version { get; set; } = "1.0";
        public string Author { get; set; } = "Henrik de Freitas";
        public string Url { get; set; } = "https://caliburnmicro.com/";
    }
}
