using CTRE.Phoenix;
using CTRE.Phoenix.Controller;
using CTRE.Phoenix.MotorControl;
using CTRE.Phoenix.MotorControl.CAN;
using Microsoft.SPOT;
using System;
using System.Text;
using System.Threading;

namespace NinetyNineBurgalurs
{
    class Shooter
    {
        public enum States
        {
            Stop, Go, Intake,
            Standby
        }

        public States currentState = States.Stop;
        public States lastState;

        private TalonSRX shooterMotor;

        public Shooter()
        {

        }
        
        public void StateMachine()
        {
            switch (currentState)
            {
                case States.Stop:
                    break;
                case States.Go:
                    break;
                case States.Intake:
                    break;
                case States.Standby:
                    break;
                default:
                    break;
            }
        }
    }
}
