
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HolidayChecklist.Models
{
    public class Episode
    {
        [Key]
        public int ParentShowID {get; set;}

        public int ParentSeasonNumber {get; set;}

        public string Title {get; set;}

        public string Overview {get; set;}

        public DateTime First_Air_Date {get; set;}
    }
}
            