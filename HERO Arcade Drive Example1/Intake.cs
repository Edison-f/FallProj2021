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
    class Intake
    {
        public enum States
        {
            Stop, Shoot, SlowIn,
            Go

        }

        private TalonSRX intakeMotor;

        public States currentState = States.Stop;
        
        public Intake()
        {
            intakeMotor = new TalonSRX(0);

        }

        public void StateMachine()
        {
            switch (currentState)
            {
                case States.Stop:
                    Stop();
                    break;
                case States.Shoot:
                    Shoot();
                    break;
                case States.SlowIn:
                    SlowIn();
                    break;
                case States.Go:
                    Go();
                    break;
            }
        }

        public void Stop()
        {
            intakeMotor.Set(ControlMode.PercentOutput, 0);
        }

        public void SlowIn()
        {
            intakeMotor.Set(ControlMode.PercentOutput, 0.20);
        }

        public void Go()
        {
            intakeMotor.Set(ControlMode.PercentOutput, 1);
        }

        public void Shoot()
        {
            intakeMotor.Set(ControlMode.PercentOutput, -1);
        }

    }
}
