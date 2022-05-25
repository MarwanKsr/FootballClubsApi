using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.DataTransferObjects.Requests
{
    public class UpdateClubRequest
    {
        [Required]
        public string Name { get; set; }
        public int? CountryId { get; set; }
        public string? StadiumName { get; set; }
        public string? CoachsName { get; set; }
        public string? PresidentsName { get; set; }
        public int? NumberOfLeagueTitles { get; set; }
        public int? NumberOfCupTitles { get; set; }
        public int? NumberOfChampionsLeagueTitles { get; set; }
    }
}
