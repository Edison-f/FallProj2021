namespace NinetyNineBurgalurs
{
    internal class TeleopStateMachine
    {
        public enum States
        {
            Stop, Auton, Intake,
            Shoot
        }

        private Drive drive;
        private Intake intake;
        private Shooter shooter;

        public States currentState = States.Stop;
        public States lastState;

        public TeleopStateMachine(ref Drive drive_, ref Intake intake_, ref Shooter shooter_)
        {
            drive = drive_;
            intake = intake_;
            shooter = shooter_;
        }

        public void StateMachine()
        {

            switch (currentState)
            {
                case States.Stop:
                    
                    break;
                case States.Auton:
                    break;
                case States.Intake:
                    break;
                case States.Shoot:
                    break;
                default:
                    break;
            }

        }
    }
}