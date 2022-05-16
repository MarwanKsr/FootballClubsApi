using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Country.Entities;

namespace Country.DataTransferObjects.Responses
{
    public class ClubDisplayResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? StadiumName { get; set; }
        public string? CoachsName { get; set; }
        public string? Logo { get; set; }
    }
}
