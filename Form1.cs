using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace CAL_Lab5
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort("COM5", 9600);
        List<string> passwordLogs = new List<string>();
        System.Threading.Timer timer;
        private bool newEntryAdded;

        public Form1()
        {
            InitializeComponent();
            serialPort.Open();
            serialPort.DataReceived += SerialPort_DataReceived;
            timer = new System.Threading.Timer(TimerCallback, null, 0, 1000);
            newEntryAdded = false;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine().Trim();

            passwordLogs.Add(data);
            UpdatePasswordLog();
        }

        private void TimerCallback(object state)
        {
            sendSignalToArduino();
        }

        private void UpdatePasswordLog()
        {
            if (listBoxLogs.InvokeRequired)
            {
                listBoxLogs.Invoke(new Action(UpdatePasswordLog));
            }
            else
            {
                HashSet<string> uniqueEntries = new HashSet<string>();
                List<string> existingLogs = new List<string>(listBoxLogs.Items.Cast<string>());

                listBoxLogs.Items.Clear();

                foreach (string entry in existingLogs)
                {
                    listBoxLogs.Items.Add(entry);
                    uniqueEntries.Add(entry);
                }

                foreach (string entry in passwordLogs)
                {
                    string timestamp = DateTime.Now.ToString("HH:mm:ss");
                    string logEntry = $"{timestamp} - {entry}";

                    if (!uniqueEntries.Contains(logEntry))
                    {
                        listBoxLogs.Items.Add(logEntry);
                        uniqueEntries.Add(logEntry);
                        newEntryAdded = true;
                    }
                }
            }

            if (newEntryAdded)
            {
                activateTimer();
                sendSignalToArduino();
                newEntryAdded = false;
            }
        }

        private void sendSignalToArduino()
        {
            string startTime = dateTimePickerStart.Value.AddSeconds(-1).ToString("HH:mm:ss");
            string stopTime = dateTimePickerStop.Value.AddSeconds(-1).ToString("HH:mm:ss");
            string currentTime = DateTime.Now.AddSeconds(-1).ToString("HH:mm:ss");

            if (currentTime == startTime)
            {
                serialPort.Write("A");
                Thread.Sleep(100);
            }
            else if (currentTime == stopTime)
            {
                serialPort.Write("B");
                Thread.Sleep(100);
                deactivateTimer();
            }
        }

        private void activateTimer()
        {
            timer.Change(0, 1000);
        }

        private void deactivateTimer()
        {
            timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Dispose();
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
