using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Text;

namespace fofGuitarController_driver
{
    public class arduino
    {
        public SerialPort ComPort
        {
            get;
            private set;
        }

        public arduino(string comPort, int baudRate)
        {
            this.ComPort = new SerialPort(comPort, baudRate, Parity.None, 8);
            this.ComPort.Open();
        }

        public enum digitalState
        {
            LOW,
            HIGH
        }
    }
}
