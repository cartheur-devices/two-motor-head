using System;
using System.Threading.Tasks;
using Cartheur.Animals.Robot;

namespace Head.Controller
{
    public class Program
    {
        public static MotorFunctions MotorControl { get; set; }
        public static bool MotorsInitialized { get; set; }
        //public UsbCamera Camera { get; set; }

        async static Task Main()
        {
            MotorControl = new MotorFunctions();
            var value = MotorControl.InitializeDynamixelMotors();
            MotorsInitialized = MotorFunctions.DynamixelMotorsInitialized;
            if (MotorsInitialized)
            {
                MotorControl.CreateConnectMotorObjects();
                Console.WriteLine("System ready.");
            }

            await Task.CompletedTask;
        }
    }
}
