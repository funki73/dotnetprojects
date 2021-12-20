using System.Collections.Generic;

namespace belt_exam.Models
{
    public class DashboardView
    {
        public string UserName { get; set; }
        public List<TVShow> AllShows { get; set; }
    }
}