using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.DataTransferObjects.Requests
{
    public class AddClubRequest
    {
        [Required (ErrorMessage = "Club's name is required")]
        [StringLength(20, ErrorMessage = "Club's name can't be more than 20 character")]
        [MinLength(2, ErrorMessage = "Club's name can't be less then 2 Character")]
        public string Name { get; set; }
        public int? CountryId { get; set; }
        public string? StadiumName { get; set; }
        public string? CoachsName { get; set; }

    }
}
