using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary_1
{
    public class State
    {
        public string Capital { get; set; }
        public int Population { get; set; }
        public int Size { get; set; }

        public State(string capital, int pop, int size)
        {
            this.Capital = capital;
            this.Population = pop;
            this.Size = size;
        }

        public static Dictionary<string, State> GetStates()
        {
            var states = new Dictionary<string, State>();//a dictionary with the string as the capital and the state object
            
            var theState = new State("Montgomery", 123456, 123);
            states.Add("Alabama", theState);

            theState = new State("Juneau", 24681012, 456);
            states.Add("Alaska", theState);

            return states;//returns the dictionary
        }
    }
}
