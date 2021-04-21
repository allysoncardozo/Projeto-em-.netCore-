using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebApplication.Models
{
    public class Heroi
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public IdentidadeSecreta IdentidadeSecreta { get; set; }
        public ICollection<Arma> Armas { get; set; }
        public ICollection<HeroiBatalha> HeroisBatalhas { get; set; }
    }
}
