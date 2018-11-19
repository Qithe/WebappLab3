using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WebAppLab3.MVC.Models
{
    public class Movie
    {
        [Required]
        public int ID { get; set; }
        public string MovieTitle { get; set; }
        public DateTime MovieStartTime { get; set; }
        public int MoveRunTime { get; set; }
        public int SaloonnMaxSeats { get; set; }
        public int SaloonOcupiedSeats { get; set; }
    }
}
