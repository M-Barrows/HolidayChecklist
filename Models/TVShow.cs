
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HolidayChecklist.Models
{
    public class TVShow
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime First_Air_Date { get; set;}
        
        public string Title {get; set;}

        public IEnumerable<Season> Seasons {get; set;}

        public string Overview {get; set;}

        public string Backdrop_Path {get; set;}
    }
}
            