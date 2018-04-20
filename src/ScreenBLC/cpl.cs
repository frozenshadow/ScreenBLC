using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Math;
using System.Management;

namespace ScreenBLC
{
    public partial class cpl : Form
    {
        // Global variables
        FilterInfoCollection videoDevices;  // Collection of cameras
        VideoCaptureDevice videoSource;     // Capture source
        byte[] bLevels;                     // Array of valid backlight level values

        // Initialize ControlPanel
        public cpl()
        {
            InitializeComponent();
        }

        // Load the ControlPanel form
        private void cpl_Load(object sender, EventArgs e)
        {
            // Get collection of camaras
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            bLevels = GetBrightnessLevels(); // Get the backlight level array of this system

            if (bLevels.Count() == 0 || videoDevices.Count == 0)
            {
                Application.Exit(); // Exit the application
            }
            else
            {
                // List these devices in the combobox
                foreach (FilterInfo device in videoDevices)
                {
                    comboBoxDevices.Items.Add(device.Name);
                }

                videoSource = new VideoCaptureDevice();
                comboBoxDevices.SelectedIndex = 0; // Select first camera by default

                // Get the backlight level array and put it in a textbox
                for (var i = 0; i < bLevels.Length; i++)
                {
                    var val = bLevels[i];
                    possibleValues.AppendText(val + "% ");
                }
                check_brightness(); // Set current screen brightness label
            }
            
            

            

            
            if (bLevels.Count() == 0) // IF "WmiMonitorBrightness" is not supported by the system
            {
                
            }
            else
            {
                
            }
        }

        // Start/Stop button click
        private void srtStp_btn_Click(object sender, EventArgs e)
        {
            // Stop and reset all tasks if the program is already activated
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                previewBox.Image = null;
                previewBox.Invalidate();
                refresh.Enabled = false;
            }
            else
            {
                // Set and start all tasks if the program is not yet activated
                videoSource = new VideoCaptureDevice(videoDevices[comboBoxDevices.SelectedIndex].MonikerString);
                videoSource.NewFrame += videoSource_NewFrame;
                videoSource.Start();
                refresh.Interval = (int)refreshInterval.Value*1000;
                refresh.Enabled = true;
                //videoSource.DisplayPropertyPage(IntPtr.Zero); // Display camera property box
            }
        }

        // When closing the ControlPanel
        private void cpl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource.IsRunning) // Terminate the camera IF the program is activated
            {
                videoSource.Stop(); 
            }
        }

        // When screen brightness refresh button is clicked
        private void screenRefresh_btn_Click(object sender, EventArgs e)
        {
            check_brightness(); // Set current screen brightness label
        }

        // When environment brightness refresh button is clicked
        private void envRefresh_btn_Click(object sender, EventArgs e)
        {
            fullRefresh(); // Do a full refresh
        }

        // On every timer tick
        private void refresh_Tick(object sender, EventArgs e)
        {
            fullRefresh(); // Do a full refresh
        }

        // When refresh interval box is changed
        private void refreshInterval_ValueChanged(object sender, EventArgs e)
        {
            // Set refresh interval
            refresh.Interval = (int)refreshInterval.Value * 1000;
        }

        // When reset button is clicked
        private void reset_btn_Click(object sender, EventArgs e)
        {
            // Reset both the brightness offset and refresh interval
            brightnessOffset.Value = 0;
            refreshInterval.Value = 5;
        }

        // When notify icon is clicked
        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            // Show the ControlPanel
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        // When ControlPanel resize event is detected
        private void cpl_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState) // IF event is "minimize"
            {
                // Hide the ControlPanel and show the notify icon
                notifyIcon1.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState) // IF event is "normal"
            {
                // Hide the notify icon
                notifyIcon1.Visible = false;
            }
        }


        /////////////////////////////////////////////////////////// METHODS

        // Executed when NewFrame event is called
        void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = new Bitmap(eventArgs.Frame); // Create Bitmap from frame
            previewBox.Image = frame; // Add to PictureBox
        }

        // Do a full refresh
        private void fullRefresh()
        {
            if (previewBox.Image != null) // IF program is activated
            {
                check_envorimentBrightness(); // Set current environment brightness label
                SetBrightness((byte)get_environmentBrightness(false)); // Set the screen brightness from environment
                check_brightness(); // Set current screen brightness label
            }       
        }

        // Check environment brightness
        private void check_envorimentBrightness()
        {
            int envValue = (int)get_environmentBrightness(false);
            environmentValue.Text = envValue.ToString() + '%'; // Set current environment brightness label 
        }

        // Get current environment brightness
        private float get_environmentBrightness(bool raw){
            Bitmap FrameData = new Bitmap(previewBox.Image);
            ImageStatisticsHSL stat = new ImageStatisticsHSL(FrameData);

            if(raw == true){
                return stat.Luminance.Mean; // Return the environment brightness
            }
            else
            {
                int offset = (int)brightnessOffset.Value; // Get offset value
                decimal percentage = Math.Round((Decimal)stat.Luminance.Mean * 100, 0, MidpointRounding.AwayFromZero) + offset; // Calc environment brightness percentage

                return bLevels.OrderBy(x => Math.Abs((long)x - percentage)).First(); // Return percentage closest to possible system brightness array
            }
        }

        // Check screen brightness
        private void check_brightness()
        {
            currentValue.Text = GetBrightness().ToString() + '%'; // Set current screen brightness label
        }

        // Get screen brightness
        static int GetBrightness()
        {
            System.Management.ManagementScope s = new System.Management.ManagementScope("root\\WMI"); // Define scope (namespace)
            System.Management.SelectQuery q = new System.Management.SelectQuery("WmiMonitorBrightness"); // Define query
            System.Management.ManagementObjectSearcher mos = new System.Management.ManagementObjectSearcher(s, q); // Output current screen brightness

            System.Management.ManagementObjectCollection moc = mos.Get();

            // Store result
            byte curBrightness = 0;
            foreach (System.Management.ManagementObject o in moc)
            {
                curBrightness = (byte)o.GetPropertyValue("CurrentBrightness");
                break; // Only work on the first object
            }

            moc.Dispose();
            mos.Dispose();

            return (int)curBrightness; // Return current screen brightness
        }

        // Set array of valid brightness values in percent
        static byte[] GetBrightnessLevels()
        {            
            System.Management.ManagementScope s = new System.Management.ManagementScope("root\\WMI"); // Define scope (namespace)
            System.Management.SelectQuery q = new System.Management.SelectQuery("WmiMonitorBrightness"); // Define query
            System.Management.ManagementObjectSearcher mos = new System.Management.ManagementObjectSearcher(s, q); // Output current screen brightness

            // Set and fill bLevels array
            byte[] BrightnessLevels = new byte[0];
            try
            {
                System.Management.ManagementObjectCollection moc = mos.Get();

                // Store result
                foreach (System.Management.ManagementObject o in moc)
                {
                    BrightnessLevels = (byte[])o.GetPropertyValue("Level");
                    break; // Only work on the first object
                }

                moc.Dispose();
                mos.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, Your System does not support this brightness control..."); // Show message if brightness control is not supported
            }

            return BrightnessLevels;
        }

        // Set screen brightness
        static void SetBrightness(byte targetBrightness)
        {           
            System.Management.ManagementScope s = new System.Management.ManagementScope("root\\WMI"); // Define scope (namespace)           
            System.Management.SelectQuery q = new System.Management.SelectQuery("WmiMonitorBrightnessMethods"); // Define query
            System.Management.ManagementObjectSearcher mos = new System.Management.ManagementObjectSearcher(s, q); // Output current screen brightness

            System.Management.ManagementObjectCollection moc = mos.Get();

            // Store result is reversed order - apparently won't work otherwise
            foreach (System.Management.ManagementObject o in moc)
            {
                o.InvokeMethod("WmiSetBrightness", new Object[] { UInt32.MaxValue, targetBrightness });
                break; // Only work on the first object
            }

            moc.Dispose();
            mos.Dispose();
        }
    }
}
