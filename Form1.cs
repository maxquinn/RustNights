using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RustNights
{
    public partial class Form1 : Form
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct RAMP
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Red;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Green;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Blue;
        }

        private static RAMP userDefault = new RAMP();

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("gdi32.dll")]
        public static extern bool SetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);

        [DllImport("gdi32.dll")]
        public static extern bool GetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);

        public static void SetGamma(int gamma)
        {
            if (gamma <= 256 && gamma >= 1)
            {
                RAMP ramp = new RAMP();
                ramp.Red = new ushort[256];
                ramp.Green = new ushort[256];
                ramp.Blue = new ushort[256];
                for (int i = 1; i < 256; i++)
                {
                    int iArrayValue = i * (gamma + 128);

                    if (iArrayValue > 65535)
                        iArrayValue = 65535;
                    ramp.Red[i] = ramp.Blue[i] = ramp.Green[i] = (ushort)iArrayValue;
                }
                SetDeviceGammaRamp(GetDC(IntPtr.Zero), ref ramp);
            }
        }


        public Form1()
        {
            InitializeComponent();
            GetDeviceGammaRamp(GetDC(IntPtr.Zero), ref userDefault);
            this.FormClosing += this.Form1_FormClosing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetDeviceGammaRamp(GetDC(IntPtr.Zero), ref userDefault);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.DayTimeButton.Visible = false;
            this.NightTimeButton.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetGamma(255);
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DayTimeButton.Visible = true;
            this.NightTimeButton.Visible = false;
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
                SetDeviceGammaRamp(GetDC(IntPtr.Zero), ref userDefault);
        }

        private void DefaultButton_Click(object sender, EventArgs e)
        {
            SetGamma(128);
        }
    }
}
