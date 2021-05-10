using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Legion1.Models
{
    public class FizzBuzz
    {

        [Required(ErrorMessage = "Podaj liczbę"), Range(1, 1000, ErrorMessage = "Musisz podać liczbę z  przedziału 1-1000")]
        public int Number { get; set; }

    }
}
