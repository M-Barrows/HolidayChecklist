
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
        public int EpisodeID {get; set;}
        public int ShowID {get; set;}

        public int SeasonNumber {get; set;}

        public string ShowTitle {get; set;}

        public string ShowBackdropPath {get;set;}

        public string ShowOverview {get; set;}

        public DateTime EpisodeAirDate {get; set;}

        public int EpisodeNumber {get; set;}

        public string EpisodeTitle {get;set;}

        public string EpisodeOverview {get; set;}
        public Boolean Watched {get; set;}

    }
}