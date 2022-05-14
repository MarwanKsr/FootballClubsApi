using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country.Entities
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfEstablishment { get; set; }
        public string? StadiumName { get; set; }
        public string CoachsName { get; set; }
        public string? PresidentsName { get; set; }
        public Country Country { get; set; }
        public int NumberOfLeagueTitles { get; set; }
        public int NumberOfCupTitles { get; set; }
        public int NumberOfChampionsLeagueTitles { get; set; }




    }
}
