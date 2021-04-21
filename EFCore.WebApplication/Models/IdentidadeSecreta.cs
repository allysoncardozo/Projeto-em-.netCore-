using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebApplication.Models
{
    public class IdentidadeSecreta
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public long HeroiId { get; set; }
        public Heroi Heroi { get; set; }
    }
}
