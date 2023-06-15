using System;
using System.Collections.Generic;
using NfaAndDfa;
using Alphapits =System.Char;

namespace NfaConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            try
            {
               
                var states = new List<State>(){ new State("q0"), new State("q1"),new State("q2") };
                var symbols = new List<Alphapits>() { 'a', 'b','c' };
                var transitionFunctions = new List<TransitionFunction>()
                {
                    new TransitionFunction(new State("q0"), new State("q1"), symbols[0]),
                    new TransitionFunction(new State("q1"), new State("q2"), symbols[1])
                };

                var nfa =new NFA(states, symbols, states[0],states[2],transitionFunctions);
                nfa.TestInput("ab");
                var dfa = nfa.ConvertToDfa();
                dfa.TestInput("ab");

               Console.WriteLine(dfa.ToString());

             
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();

        }
    }
}
