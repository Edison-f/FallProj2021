using Microsoft.SPOT;
using System;

namespace NinetyNineBurgalurs
{
    class Intake
    {
        public enum States
        {
            Stop, Go, Reverse,
            Slow
        }

        public States currentState = States.Stop;
        public Intake()
        {

        }

        public void StateMachine()
        {

        }
    }
}
