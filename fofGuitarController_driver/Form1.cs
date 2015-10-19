using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using WindowsInput;
using System.IO;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Drawing;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Ports;
using InTheHand.Net.Sockets;
using InTheHand;
using System.Threading.Tasks;

namespace fofGuitarController_driver
{
    public partial class Form1 : Form
    {
        #region extern

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);
        
        byte VK_F1 = 0x70;
        byte VK_F2 = 0x71;
        byte VK_F3 = 0x72;
        byte VK_F4 = 0x73;
        byte VK_F5 = 0x74;
        byte VK_RETURN = 0x0D;

        async Task PressKey(byte keyCode, int sleeptime)
        {
            const int KEYEVENTF_EXTENDEDKEY = 0x1;
            keybd_event(keyCode, 0x45, KEYEVENTF_EXTENDEDKEY, 0);
        }

        void ReleaseKey(byte keyCode)
        {
            const int KEYEVENTF_KEYUP = 0x2;
            keybd_event(keyCode, 0x45, KEYEVENTF_KEYUP, 0);
        }

        #endregion

        #region keyControl

        bool showVisualFeedback = true;
        bool menuNavigation = false;
        int keystrokeCount = 0;

        void fret1High()
        {
            if (menuNavigation)
            {
                InputSimulator.SimulateKeyDown(VirtualKeyCode.DOWN);

                if (showVisualFeedback)
                {
                    lblDown.ForeColor = Color.Green;
                }
            }
            else
            {
                InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);

                if (showVisualFeedback)
                {
                    lblFret1.ForeColor = Color.Green;
                }
            }
        }

        void fret1Low()
        {
            if (menuNavigation)
            {
                InputSimulator.SimulateKeyUp(VirtualKeyCode.DOWN);

                if (showVisualFeedback)
                {
                    lblDown.ForeColor = Color.Black;
                }
            }
            else
            {
                InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);

                if (showVisualFeedback)
                {
                    lblFret1.ForeColor = Color.Black;
                }
            }
            this.addKeyStroke();
        }

        void fret2High()
        {
            if (menuNavigation)
            {
                InputSimulator.SimulateKeyDown(VirtualKeyCode.UP);

                if (showVisualFeedback)
                {
                    lblUp.ForeColor = Color.Red;
                }
            }
            else
            {
                InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_S);

                if (showVisualFeedback)
                {
                    lblFret2.ForeColor = Color.Red;
                }
            }
        }

        void fret2Low()
        {
            if (menuNavigation)
            {
                InputSimulator.SimulateKeyUp(VirtualKeyCode.UP);

                if (showVisualFeedback)
                {
                    lblUp.ForeColor = Color.Black;
                }
            }
            else
            {
                InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_S);

                if (showVisualFeedback)
                {
                    lblFret2.ForeColor = Color.Black;
                }
            }
            this.addKeyStroke();
        }

        void fret3High()
        {
            if (menuNavigation)
            {
                InputSimulator.SimulateKeyDown(VirtualKeyCode.LEFT);

                if (showVisualFeedback)
                {
                    lblLeft.ForeColor = Color.Yellow;
                }
            }
            else
            {
                InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_D);

                if (showVisualFeedback)
                {
                    lblFret3.ForeColor = Color.Yellow;
                }
            }
        }

        void fret3Low()
        {
            if (menuNavigation)
            {
                InputSimulator.SimulateKeyUp(VirtualKeyCode.LEFT);

                if (showVisualFeedback)
                {
                    lblLeft.ForeColor = Color.Black;
                }
            }
            else
            {
                InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_D);

                if (showVisualFeedback)
                {
                    lblFret3.ForeColor = Color.Black;
                }
            }
            this.addKeyStroke();
        }

        void fret4High()
        {
            if (menuNavigation)
            {
                InputSimulator.SimulateKeyDown(VirtualKeyCode.RIGHT);

                if (showVisualFeedback)
                {
                    lblRight.ForeColor = Color.Blue;
                }
            }
            else
            {
                InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_F);

                if (showVisualFeedback)
                {
                    lblFret4.ForeColor = Color.Blue;
                }
            }
        }

        void fret4Low()
        {
            if (menuNavigation)
            {
                InputSimulator.SimulateKeyUp(VirtualKeyCode.RIGHT);

                if (showVisualFeedback)
                {
                    lblRight.ForeColor = Color.Black;
                }
            }
            else
            {
                InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_F);

                if (showVisualFeedback)
                {
                    lblFret4.ForeColor = Color.Black;
                }
            }
            this.addKeyStroke();
        }

        void fret5High()
        {
            if (menuNavigation)
            {
                InputSimulator.SimulateKeyDown(VirtualKeyCode.ESCAPE);

                if (showVisualFeedback)
                {
                    lblEscape.ForeColor = Color.Purple;
                }
            }
            else
            {
                InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_G);

                if (showVisualFeedback)
                {
                    lblFret5.ForeColor = Color.Purple;
                }
            }
        }

        void fret5Low()
        {
            if (menuNavigation)
            {
                InputSimulator.SimulateKeyUp(VirtualKeyCode.ESCAPE);

                if (showVisualFeedback)
                {
                    lblEscape.ForeColor = Color.Black;
                }
            }
            else
            {
                InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_G);

                if (showVisualFeedback)
                {
                    lblFret5.ForeColor = Color.Black;
                }
            }
            this.addKeyStroke();
        }

        void pickHigh()
        {
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_Q);

            if (menuNavigation)
            {
                if (showVisualFeedback)
                {
                    lblEnter.ForeColor = Color.Orange;
                }
            }
            else
            {
                if (showVisualFeedback)
                {
                    lblPick.ForeColor = Color.Orange;
                }
            }
        }

        void pickLow()
        {
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_Q);

            if (menuNavigation)
            {
                if (showVisualFeedback)
                {
                    lblEnter.ForeColor = Color.Black;
                }
            }
            else
            {
                if (showVisualFeedback)
                {
                    lblPick.ForeColor = Color.Black;
                }
            }
            this.addKeyStroke();
        }

        void enableMenuVisualFeedback()
        {
            this.lblMenuMode.ForeColor = Color.Black;
            this.lblUp.ForeColor = Color.Black;
            this.lblDown.ForeColor = Color.Black;
            this.lblLeft.ForeColor = Color.Black;
            this.lblRight.ForeColor = Color.Black;
            this.lblEscape.ForeColor = Color.Black;
            this.lblEnter.ForeColor = Color.Black;

            this.lblGuitarMode.ForeColor = Color.Gray;
            this.lblFret1.ForeColor = Color.Gray;
            this.lblFret2.ForeColor = Color.Gray;
            this.lblFret3.ForeColor = Color.Gray;
            this.lblFret4.ForeColor = Color.Gray;
            this.lblFret5.ForeColor = Color.Gray;
            this.lblPick.ForeColor = Color.Gray;
        }

        void enableGuitarVisualFeedBack()
        {
            this.lblMenuMode.ForeColor = Color.Gray;
            this.lblUp.ForeColor = Color.Gray;
            this.lblDown.ForeColor = Color.Gray;
            this.lblLeft.ForeColor = Color.Gray;
            this.lblRight.ForeColor = Color.Gray;
            this.lblEscape.ForeColor = Color.Gray;
            this.lblEnter.ForeColor = Color.Gray;

            this.lblGuitarMode.ForeColor = Color.Black;
            this.lblFret1.ForeColor = Color.Black;
            this.lblFret2.ForeColor = Color.Black;
            this.lblFret3.ForeColor = Color.Black;
            this.lblFret4.ForeColor = Color.Black;
            this.lblFret5.ForeColor = Color.Black;
            this.lblPick.ForeColor = Color.Black;
        }

        void menuNavigationHIGH()
        {
            menuNavigation = true;
            enableMenuVisualFeedback();
        }

        void menuNavigationLOW()
        {
            menuNavigation = false;
            enableGuitarVisualFeedBack();
        }

        void addKeyStroke()
        {
            this.keystrokeCount++;
            this.keystrokeCountPerSecond++;
            this.lblKeyStrokeCount.Text = "KeyStrokes: " + this.keystrokeCount;
        }


        #endregion

        #region measureDelayGraph

        List<float> probes;
        Graphics g;
        Pen p;
        float probesPerCycle = 20;
        Thread drawMeasureDelayGraphThread;
        int measureDelayProbeDelay = 50;

        void measureDelayProbeReceived(string rcv)
        {
            float val = Convert.ToSingle(rcv.Split(':')[1].Replace(";", ""));
            addProbe(val);
        }

        void addProbe(float probeVal)
        {
            if (probes.Count < probesPerCycle)
            {
                probes.Add(probeVal);
            }
            else
            {
                probes.RemoveAt(0);
                probes.Add(probeVal);
            }

            if (probes.Count == 2)
            {
                startDraw();
            }
        }

        void startDraw()
        {
            drawMeasureDelayGraphThread = new Thread(new ThreadStart(drawValues));
            drawMeasureDelayGraphThread.Start();
        }

        void drawValues()
        {
            while (true)
            {
                try
                {
                    g.Clear(Color.Black);

                    float yMax = probes.Max<float>();
                    if (yMax == 0)
                        return;
                    float xMax = probes.Count;
                    float viewHeight = this.picBxMeasureDelayGraph.Height;
                    float viewWidth = this.picBxMeasureDelayGraph.Width;

                    float heightCoefficient = (viewHeight - 10) / (float)yMax;
                    float widthCoefficient = viewWidth / (float)xMax;

                    for (int x = 1; x < xMax; x++)
                    {
                        float x1 = (x - 1) * widthCoefficient;
                        float y1 = viewHeight - (probes[x - 1] * heightCoefficient);

                        float x2 = x * widthCoefficient;
                        float y2 = viewHeight - (probes[x] * heightCoefficient);

                        PointF p1 = new PointF(x1, y1);
                        PointF p2 = new PointF(x2, y2);

                        g.DrawLine(p, p1, p2);
                    }

                    this.lblMeasureDelayMin.Text = "Min: " + this.probes.Min();
                    this.lblMeasureDelayMax.Text = "Max: " + this.probes.Max();
                }
                catch (Exception ex)
                { }

                Thread.Sleep(measureDelayProbeDelay);
            }
        }

        #endregion


        System.Windows.Forms.Timer keyCounterTmr;
        int keystrokeCountPerSecond = 0;
        arduino controller;
        float dataVolume = 0;

        public Form1()
        {
            InitializeComponent(); 
            Form.CheckForIllegalCrossThreadCalls = false;
            probes = new List<float>();
            g = this.picBxMeasureDelayGraph.CreateGraphics();
            p = new Pen(Color.Green, 3);

            keyCounterTmr = new System.Windows.Forms.Timer();
            keyCounterTmr.Interval = 1000;
            keyCounterTmr.Tick += KeyCounterTmr_Tick;
            keyCounterTmr.Start();
        }

        private void KeyCounterTmr_Tick(object sender, EventArgs e)
        {
            this.lblKeyStrokesPerSecond.Text = $"KeyStrokes per sec: {keystrokeCountPerSecond}";
            keystrokeCountPerSecond = 0;
        }

        #region usb

        private void btnConnectComPort_Click(object sender, EventArgs e)
        {
            controller = new arduino("COM" + this.textBox1.Text, 38400);
            controller.ComPort.DataReceived += new SerialDataReceivedEventHandler(ComPort_DataReceived);
            controller.ComPort.Write("u");
            //this.sw.Start();
        }
        
        void ComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string command = controller.ComPort.ReadTo(";");

            handleCommand(command);
        }

        #endregion

        #region bt

        Guid cGuid = new Guid("00001101-0000-1000-8000-00805F9B34FB");
        bool stopBTDataProcessing = false;

        private void btnSearchBTDevice_Click(object sender, EventArgs e)
        {
            Thread btScanThread = new Thread(new ThreadStart(scan));
            btScanThread.Start();
        }

        BluetoothDeviceInfo[] devices;
        void scan()
        {
            this.lstBxBTDevices.Items.Add("Scanning...");
            BluetoothClient client = new BluetoothClient();
            devices = client.DiscoverDevicesInRange();
            //Scan done

            this.lstBxBTDevices.Items.Clear();

            foreach (BluetoothDeviceInfo device in devices)
            {
                this.lstBxBTDevices.Items.Add(device.DeviceName);
            }
        }

        BluetoothDeviceInfo device;
        private void btnConnectBTDevice_Click(object sender, EventArgs e)
        {
            device = devices[lstBxBTDevices.SelectedIndex];

            if (pairDevice())
            {

            }
            else
            {
                MessageBox.Show("Pairing failed");
            }

            Thread btClientThread = new Thread(new ThreadStart(connectClient));
            btClientThread.Start();
        }

        private void connectClient()
        {
            BluetoothClient client = new BluetoothClient();
            client.BeginConnect(device.DeviceAddress, cGuid, this.BluetoothClientConnectCallback, client);
        }

        Queue<char> btReadBuffer;
        private void BluetoothClientConnectCallback(IAsyncResult result)
        {
            BluetoothClient client = (BluetoothClient)result.AsyncState;
            client.EndConnect(result);

            if (!client.Connected) //Connnection successful?
            {
                return;
            }

            btReadBuffer = new Queue<char>();

            Stream stream = client.GetStream();

            stream.WriteByte(Convert.ToByte('b'));

            while (!stopBTDataProcessing)
            {
                char cNext = Convert.ToChar(stream.ReadByte());
                if (cNext == ';')
                {
                    string command = "";

                    foreach (char c in btReadBuffer.ToArray())
                    {
                        command += c;
                    }

                    btReadBuffer.Clear();

                    handleCommand(command);
                }
                else
                {
                    btReadBuffer.Enqueue(cNext);
                }
            }

        }

        private bool pairDevice()
        {
            if (!device.Authenticated)
            {
                if (!BluetoothSecurity.PairRequest(device.DeviceAddress, "1234"))
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region commandhandling

        void handleCommand(string command)
        {
            this.lstBxReceived.Items.Add(command);
            addDataVolume(command);

            switch (command)
            {
                case "fret1:HIGH":
                    fret1High();
                    break;
                case "fret1:LOW":
                    fret1Low();
                    break;
                case "fret2:HIGH":
                    fret2High();
                    break;
                case "fret2:LOW":
                    fret2Low();
                    break;
                case "fret3:HIGH":
                    fret3High();
                    break;
                case "fret3:LOW":
                    fret3Low();
                    break;
                case "fret4:HIGH":
                    fret4High();
                    break;
                case "fret4:LOW":
                    fret4Low();
                    break;
                case "fret5:HIGH":
                    fret5High();
                    break;
                case "fret5:LOW":
                    fret5Low();
                    break;
                case "pick:HIGH":
                    pickHigh();
                    break;
                case "pick:LOW":
                    pickLow();
                    break;
                case "menuNav:HIGH":
                    menuNavigationHIGH();
                    break;
                case "menuNav:LOW":
                    menuNavigationLOW();
                    break;
                default:
                    if (command.StartsWith("measureDelay"))
                    {
                        measureDelayProbeReceived(command);
                    }
                    break;
            }
        }

        //Stopwatch sw = new Stopwatch();
        
        void addDataVolume(string data)
        {
            
            dataVolume = dataVolume + ((float)(data.ToCharArray().Length + 1));
            if (dataVolume > 1024)
            {
                if ((dataVolume / 1024) > 1024)
                {
                    this.lblDataVolume.Text = "Data Received: " + ((dataVolume / 1024) / 1024) + " Mbyte";
                }
                else
                {
                    this.lblDataVolume.Text = "Data Received: " + (dataVolume / 1024) + " Kbyte";
                }
            }
            else
            {
                this.lblDataVolume.Text = "Data Received: " + dataVolume + " byte";
            }
        }

        private void resetDataCollection()
        {
            this.dataVolume = 0;
            this.lstBxReceived.Items.Clear();
            this.lblDataVolume.Text = "Data Received: 0 byte";
            this.keystrokeCount = 0;
            this.lblKeyStrokeCount.Text = "KeyStrokes: 0";
        }

        #endregion

        private void chkBxShowVisualFeedback_CheckedChanged(object sender, EventArgs e)
        {
            showVisualFeedback = chkBxShowVisualFeedback.Checked;
        }

        private void btnResetDataVolume_Click(object sender, EventArgs e)
        {
            resetDataCollection();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (drawMeasureDelayGraphThread != null)
            {
                drawMeasureDelayGraphThread.Abort();
            }

            stopBTDataProcessing = true;
        }


    }
}
