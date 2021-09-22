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
    public class Program
    {
        
        static StringBuilder stringBuilder = new StringBuilder();
        
        static CTRE.Phoenix.Controller.GameController gamepad = null;

        static Drive Drivetrain = new Drive();

        static float leftVertical = gamepad.GetAxis(0);
        static float leftHorizontal = gamepad.GetAxis(1);

        public static void Main()
        {
            /* loop forever */
            while (true)
            {
                leftVertical = gamepad.GetAxis(0);
                leftHorizontal = gamepad.GetAxis(1);
                Deadband(ref leftVertical);
                Deadband(ref leftHorizontal);
                /* drive robot using gamepad */
                Drivetrain.driveController(leftVertical, leftHorizontal);
                /* print whatever is in our string builder */
                Debug.Print(stringBuilder.ToString());
                stringBuilder.Clear();
                /* feed watchdog to keep Talon's enabled */
                CTRE.Phoenix.Watchdog.Feed();
                /* run this task every 20ms */
                Thread.Sleep(20);
            }
        }
        /**
         * If value is within 10% of center, clear it.
         * @param value [out] floating point value to deadband.
         */
        static void Deadband(ref float value)
        {
            if (value < -0.10)
            {
                /* outside of deadband */
            }
            else if (value > +0.10)
            {
                /* outside of deadband */
            }
            else
            {
                /* within 10% so zero it */
                value = 0;
            }
        }
        //static void Drive()
        //{
        //    if (null == _gamepad)
        //        _gamepad = new GameController(UsbHostDevice.GetInstance());

        //    float x = _gamepad.GetAxis(0);
        //    float y = -1 * _gamepad.GetAxis(1);
        //    float twist = _gamepad.GetAxis(2);

        //    Deadband(ref x);
        //    Deadband(ref y);
        //    Deadband(ref twist);

        //    float leftThrot = y + twist;
        //    float rightThrot = y - twist;

        //    left.Set(ControlMode.PercentOutput, leftThrot);
        //    leftSlave.Set(ControlMode.PercentOutput, leftThrot);
        //    right.Set(ControlMode.PercentOutput, -rightThrot);
        //    rightSlave.Set(ControlMode.PercentOutput, -rightThrot);

        //    stringBuilder.Append("\t");
        //    stringBuilder.Append(x);
        //    stringBuilder.Append("\t");
        //    stringBuilder.Append(y);
        //    stringBuilder.Append("\t");
        //    stringBuilder.Append(twist);

        //}
    }
}