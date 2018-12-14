using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemastersOnly.Api.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int TrainerLevel { get; set; }
        public string Team { get; set; }
        public string FriendCode { get; set; }
        public DateTime JoinDate { get; set; }

        // relations
    }
}