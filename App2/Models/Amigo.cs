using System;
using System.ComponentModel.DataAnnotations;

namespace App2.Models
{
    public class Amigo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Aniversario { get; set; }
    }
}