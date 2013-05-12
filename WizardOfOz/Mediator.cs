using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using HapticDriver;
using System.Threading;

namespace WizardOfOz
{
    class Mediator
    {
        //public static Mediator instance = new Mediator();

        private HapticBelt wirelessBelt;

        private bool[] ActiveTactons;

        private string inPort;

        private string outPort;

        public Mediator(string port1, string port2)
        {
            wirelessBelt = new HapticBelt();
            inPort = port1;
            outPort = port2;
        }

        private bool connected = false;

        private string status = "";

        public string Status
        {
            get
            {
                return status;
            }
        }

        public bool Connected
        {
            get
            {
                return connected;
            }
        }

        public bool Connect()
        {

            //wirelessBelt.SetupPorts("COM14", "COM14", "9600", "8", "1", "None", 1000);
            wirelessBelt.SetupPorts(inPort, outPort, "9600", "8", "1", "None", 1000);
            wirelessBelt.OpenPorts();
            status = "";
            if (wirelessBelt.getStatus() != error_t.ESUCCESS)
            {
                status = wirelessBelt.getStatus().ToString();
                return connected;
            }
            if (wirelessBelt.getDataRecvType() == (byte)MessageType.NORMAL)
            {
                status = "Input port opened.";
                Console.WriteLine(status);
            }
            else if (wirelessBelt.getDataRecvType() == (byte)MessageType.ERROR)
            {
                status = "Error: " + wirelessBelt.getStatusBuffer();
                wirelessBelt.ResetHapticBelt();
                wirelessBelt.ClosePorts();
                Console.WriteLine(status);
                return connected;
            }
            try
            {
                error_t response = wirelessBelt.Query_All();
                if (response != error_t.ESUCCESS)
                    status += wirelessBelt.getErrorMsg(response);
                else
                {
                    status += "Query success";
                    Console.WriteLine(status);
                    connected = true;
                    String[] motor = { wirelessBelt.getMotors(QueryType.PREVIOUS).ToString() };
                    ActiveTactons = new bool[motor.Length];
                    //// brackets reqd for casting int array to string array
                    //String[] motor = { wirelessBelt.getMotors(QueryType.PREVIOUS).ToString() };
                    //String[] rhythm = wirelessBelt.getRhythm(false, QueryType.PREVIOUS);
                    //String[] magnitude = wirelessBelt.getMagnitude(false, QueryType.PREVIOUS);
                    //wirelessBelt.Vibrate_Motor(1, 1, 1, 7);
                }
            }
            catch (Exception ex)
            {
                status += wirelessBelt.getStatusBufferStr() + " " + ex.Message;
                Console.WriteLine(status);
                error_t response = wirelessBelt.ResetHapticBelt();

                if (response != error_t.ESUCCESS)
                {
                    Console.WriteLine(wirelessBelt.getErrorMsg(response));
                }
                wirelessBelt.ClosePorts();
            }
            return connected;
        }

        public void Disconnect()
        {
            connected = false;
            StopAll();
            wirelessBelt.ResetHapticBelt();
            wirelessBelt.ClosePorts();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void play(byte motor, byte rhythm, byte magnitude, byte dutyCycle)
        {
            if (connected)
            {
                wirelessBelt.Vibrate_Motor(motor, rhythm, magnitude, dutyCycle);
            }
        }
        public string Start(string szTactons, string szPatterns)
        {
            string[] tactons = szTactons.Split(' ', ',', ';');
            string[] patterns = szPatterns.Split(' ', ',', ';');
            status = tactons.Length.ToString() + ":" + patterns.Length.ToString();
            if (tactons.Length == patterns.Length)
            {
                wirelessBelt.SerialPortWriteData("//Actor 1\n" +
                                                    "VIBRATE,1,A,100,1\n" +
                                                    "WAIT,300\n" +
                                                    "VIBRATE,1,C,100,1\n" +
                                                    "WAIT,300\n" +
                                                    "VIBRATE,2,A,100,1\n" +
                                                    "WAIT,300\n" +
                                                    "VIBRATE,2,D,100,1\n" +
                                                    "WAIT,300\n" +
                                                    "VIBRATE,3,A,100,1\n" +
                                                    "WAIT,300\n" +
                                                    "VIBRATE,3,E,100,1\n" +
                                                    "WAIT,300\n" +
                                                    "//Actor 2\n" +
                                                    "VIBRATE,6,B,100,1\n" +
                                                    "WAIT,300\n" +
                                                    "VIBRATE,6,C,100,1\n" +
                                                    "WAIT,300\n" +
                                                    "VIBRATE,5,B,100,1\n" +
                                                    "WAIT,300\n" +
                                                    "VIBRATE,5,D,100,1\n" +
                                                    "WAIT,300\n" +
                                                    "VIBRATE,4,B,100,1\n" +
                                                    "WAIT,300\n" +
                                                    "VIBRATE,4,E,100,1\n" +
                                                    "WAIT,300", 10);
                //for (int i = 0; i < tactons.Length; i++)
                //{
                //    wirelessBelt.Vibrate_Motor((byte)i, 1, 1, 7);                    
                //    //wirelessBelt.Vibrate_Motor(Byte.Parse(tactons[i]), Byte.Parse(patterns[i]), 1, 7);
                //}
            }
            return status;
        }

        public void Stop(string szTactons)
        {
            string[] tactons = szTactons.Split(' ', ',');
            for (int i = 0; i < tactons.Length; i++)
            {
                wirelessBelt.Stop(Byte.Parse(tactons[i]));
            }
        }

        public void StopAll()
        {
            wirelessBelt.StopAll();
        }
    }
}
