using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunnyJokesWebApp.Models
{
    public class Jokes
    {
        public int ID { get; set; }

        public String JokeQuestion { get; set; }

        public String JokeAnswer { get; set; }

        public Jokes()
        {

        }
    }
}
