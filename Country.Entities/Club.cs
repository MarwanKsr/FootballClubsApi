using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Entities
{
    public class Club : IEntity
    {
        public int Id { get; set; }
        
        public Country Country { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }
        public string? StadiumName { get; set; }
        public string? CoachsName { get; set; }
        public DateTime? DateOfEstablishment { get; set; }
        public string? PresidentsName { get; set; }
        public int? NumberOfLeagueTitles { get; set; }
        public int? NumberOfCupTitles { get; set; }
        public int? NumberOfChampionsLeagueTitles { get; set; }
        public string? Logo { get; set; }
        
    }
}
