using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebApplication.Models
{
    public class HeroiBatalha
    {
        public long Heroid { get; set; }
        public Heroi Heroi { get; set; }

        public long batalhaId { get; set; }        
        public Batalha Batalha { get; set; }
    }
}
