using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App2.Models
{
    public class HomeModel
    {
        public List<Amigo> Amigos { get; set; } = new List<Amigo>();
        public int QtdAmigos { get; set; }
    }
}
