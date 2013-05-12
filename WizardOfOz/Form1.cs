using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using HapticDriver;

namespace WizardOfOz
{
    public partial class Form1 : Form
    {
        Mediator beltCommand;
        StreamWriter dataStreamRecorder;
        bool recording = false;
        public Form1()
        {
            InitializeComponent();
            disconnectButton.Enabled = false;
            // Populate list of available COM ports.
            ArrayList myPortList = new ArrayList();
            foreach (string name in System.IO.Ports.SerialPort.GetPortNames())
            {
                string tempName = "";
                if (name.Substring(0, 3) == "COM")
                {
                    if ((name.Length == 5) && !Char.IsDigit((name.Substring(4, 1))[0]))
                        tempName = name.Substring(0, 4);
                    else if ((name.Length == 6) && !Char.IsDigit((name.Substring(5, 1))[0]))
                        tempName = name.Substring(0, 5);
                    else
                        tempName = name;
                }
                myPortList.Add(tempName);
            }
            inputComPort.DataSource = myPortList;
            outputComPort.DataSource = myPortList;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            connectButton.Enabled = false;
            beltCommand = new Mediator(inputComPort.Text, outputComPort.Text);
            if (beltCommand.Connect())
            {
                disconnectButton.Enabled = true;
            }
            else
                connectButton.Enabled = true;
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            beltCommand.Disconnect();
            connectButton.Enabled = true;
            disconnectButton.Enabled = false;
            display.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            error_t status; ;
            // motor 2, rythym 4, magnitude 0, cycles 1
            status = beltCommand.play(2, 4, 0, 1);
            if(status==error_t.ESUCCESS)
            status = beltCommand.play(3, 4, 0, 1);
            if (status == error_t.ESUCCESS)
            status = beltCommand.play(1, 4, 0, 1);
            DateTime now = DateTime.Now;

            if (recording)
            {
                dataStreamRecorder.WriteLine(now.ToString("G") + ": LEAN FORWARD");
            }
            display.Text = beltCommand.getErrorMsg(status);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            beltCommand.play(6, 4, 0, 1);
            beltCommand.play(7, 4, 0, 1);
            DateTime now = DateTime.Now;
            if (recording)
            {
                dataStreamRecorder.WriteLine(now.ToString("G") + ": LEAN BACK");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            beltCommand.play(2, 1, 0, 1);
            DateTime now = DateTime.Now;
            if (recording)
            {
                dataStreamRecorder.WriteLine(now.ToString("G") + ": HEAD NOD");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            beltCommand.play(5, 1, 0, 1);
            beltCommand.play(0, 1, 0, 1);
            DateTime now = DateTime.Now;
            if (recording)
            {
                dataStreamRecorder.WriteLine(now.ToString("G") + ": HEAD SHAKE");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            recordButton.Enabled = true;
            recording = false;
            stopRecordButton.Enabled = false;
            DateTime now = DateTime.Now;
            dataStreamRecorder.WriteLine(now.ToString("G") + ": STOP");
            dataStreamRecorder.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            recordButton.Enabled = false;
            recording = true;
            stopRecordButton.Enabled = true;
            DateTime now = DateTime.Now;
            string name = now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString();
            dataStreamRecorder = new StreamWriter(name + "-data-log.txt");
            dataStreamRecorder.WriteLine(now.ToString("G") + ": START");
        }
    }
}
