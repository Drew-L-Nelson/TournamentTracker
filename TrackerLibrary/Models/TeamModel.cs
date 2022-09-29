using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public int Id { get; set; } 
        public string TeamName { get; set; }
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    }
}
