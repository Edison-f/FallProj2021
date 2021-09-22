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
    class Drive
    {
        private TalonSRX rightDrive;
        private TalonSRX leftDrive;

        public Drive() {
            rightDrive = new TalonSRX(0);
            leftDrive = new TalonSRX(0);
        }

        public void driveController(double vertical, double horizontal)
        {
            double leftOut = vertical;
            double rightOut = horizontal;

            leftOut -= horizontal;
            rightOut += horizontal;

            rightDrive.Set(ControlMode.PercentOutput, rightOut);
            leftDrive.Set(ControlMode.PercentOutput, leftOut);
        }

    }
}
