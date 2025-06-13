using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CursorColorDetector
{
    public partial class Form1 : Form
    {

        private Thread botThread;
        private volatile bool isRunning = false;
        private Color targetColor = Color.FromArgb(0, 204, 128); // Default color
        private int TOLERANCE;
        private int Sleep;
        private Thread autoClickThread;
        private volatile bool isAutoClicking = false;
        private bool isColorPicked = false;

        // DLL imports
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        // Key event constants
        private const int KEYEVENTF_KEYDOWN = 0x0000;
        private const int KEYEVENTF_KEYUP = 0x0002;


        // Constants
        private const int HOTKEY_ID = 9000; // any unique ID
        private const int WM_HOTKEY = 0x0312;

        public Form1()
        {
            InitializeComponent();
            lblStatus.Text = "Cursor Robot Mode Active";
            lblStatus.ForeColor = Color.Red;
            this.KeyPreview = true;
            TOLERANCE = 5;
            TolTxt1.Text = TOLERANCE.ToString();
            Sleep = 500; // Default sleep time
            SleepTxt.Text = Sleep.ToString();
        }

        //private void btnToggle_Click(object sender, EventArgs e)
        //{
        //    //ToggleBot();
        //}

        private void ToggleBot()
        {
            // Determine the active tab
            if (tabControl1.SelectedTab == tabCursorRobot)
            {
                StartCursorBot();
            }
            else if (tabControl1.SelectedTab == tabAutoClicker)
            {
                StartAutoClicker();
            }
        }

        public void StartCursorBot()
        {
            if (!isRunning)
            {
                isRunning = true;
                //btnToggle.Text = "Stop";
                lblStatus.Text = "Cusor Bot is Running...";
                lblStatus.ForeColor = Color.Green;

                botThread = new Thread(RunBot);
                botThread.IsBackground = true;
                botThread.Start();
            }
            else
            {
                StopCursorBot();
            }
        }

        public void StartAutoClicker()
        {
            if (!isAutoClicking)
            {
                if (!int.TryParse(txtInterval.Text, out int interval))
                {
                    MessageBox.Show("Invalid interval value.");
                    return;
                }

                StartAutoClicker(interval);
                //btnToggle.Text = "Stop";
                lblStatus.Text = "Auto Clicker is Running...";
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                StopAutoClicker();
                //btnToggle.Text = "Start";
                lblStatus.Text = "Auto Clicker Stopped";
                lblStatus.ForeColor = Color.Red;
            }
        }


        private void RunBot()
        {
            if (!isColorPicked)
            {
                MessageBox.Show("Please pick a target color before starting the bot.");
                isRunning = false;
                Invoke((MethodInvoker)(() =>
                {
                    lblStatus.Text = "Stopped";
                    lblStatus.ForeColor = Color.Red;
                }));
                return;
            }
            while (isRunning)
            {
                Bitmap screenshot;
                try
                {
                    screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                    using (Graphics g = Graphics.FromImage(screenshot))
                    {
                        g.CopyFromScreen(0, 0, 0, 0, screenshot.Size);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Screen capture failed: " + ex.Message);
                    return;
                }

                // Get the offset of the screen relative to the desktop
                int screenXOffset = Screen.PrimaryScreen.Bounds.X;
                int screenYOffset = Screen.PrimaryScreen.Bounds.Y;

                for (int x = 0; x < screenshot.Width; x += 5)
                {
                    for (int y = 0; y < screenshot.Height; y += 5)
                    {
                        if (!isRunning) return; // Exit early if stopped

                        Color pixel = screenshot.GetPixel(x, y);
                        if (IsColorMatch(pixel, targetColor))
                        {
                            // Adjust cursor position to the screen offset
                            Cursor.Position = new Point(x + screenXOffset, y + screenYOffset);

                            mouse_event(MouseEventFlags.LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MouseEventFlags.LEFTUP, 0, 0, 0, 0);


                        }
                    }
                }

                Thread.Sleep(Sleep);
            }
        }


        private bool IsColorMatch(Color c1, Color c2)
        {
            return Math.Abs(c1.R - c2.R) <= TOLERANCE &&
                   Math.Abs(c1.G - c2.G) <= TOLERANCE &&
                   Math.Abs(c1.B - c2.B) <= TOLERANCE;
        }

        [Flags]
        public enum MouseEventFlags : uint
        {
            LEFTDOWN = 0x02,
            LEFTUP = 0x04,
            RIGHTDOWN = 0x08,
            RIGHTUP = 0x10,
            MIDDLEDOWN = 0x20,
            MIDDLEUP = 0x40
        }

        [DllImport("user32.dll")]
        public static extern void mouse_event(MouseEventFlags dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                targetColor = colorDialog1.Color;
                //MessageBox.Show("Target color set to: " + targetColor.ToString(), "Color Selected");
                label3.Text = targetColor.ToString();
                label3.ForeColor = targetColor;
                isColorPicked = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                ToggleBot();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegisterHotKey(this.Handle, HOTKEY_ID, 0, Keys.F6);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == HOTKEY_ID)
            {
                ToggleBot();
            }
            base.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TolTxt1.Text = (--TOLERANCE).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TolTxt1.Text = (++TOLERANCE).ToString();
        }

        private void StopCursorBot()
        {
            isRunning = false;
            isAutoClicking = false;
            if (botThread != null && botThread.IsAlive)
            {
                botThread.Join();
            }

            lblStatus.Invoke((MethodInvoker)(() =>
            {
                lblStatus.Text = "Cusor Bot Stopped";
                lblStatus.ForeColor = Color.Red;
            }));


            //btnToggle.Invoke((MethodInvoker)(() =>
            //{
            //    btnToggle.Text = "Start";
            //}));
        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabCursorRobot)
            {
                // Activate cursor bot
                StopAutoClicker(); // if needed
                lblStatus.Text = "Cursor Robot Mode Active";
            }
            else if (tabControl1.SelectedTab == tabAutoClicker)
            {
                // Activate auto clicker
                StopCursorBot(); // if needed
                lblStatus.Text = "Auto Clicker Mode Active";
            }
        }



        private void StartAutoClicker(int interval)
        {
            isAutoClicking = true;

            autoClickThread = new Thread(() =>
            {
                string selectedButton = "Left";
                bool holdClick = false;

                // Safely read values from UI controls
                cmbMouseButton.Invoke(() =>
                {
                    if (cmbMouseButton.SelectedItem != null)
                        selectedButton = cmbMouseButton.SelectedItem.ToString();
                });

                chkHoldClick.Invoke(() =>
                {
                    holdClick = chkHoldClick.Checked;
                });

                if (holdClick)
                {
                    // Simulate holding down once
                    HoldMouseDown(selectedButton);

                    // Stay in loop until stopped
                    while (isAutoClicking)
                    {
                        Thread.Sleep(interval); // keep the thread alive but don't flood CPU
                    }

                    // Release mouse when stopping
                    HoldMouseUp(selectedButton);
                }
                else
                {
                    // Repeated clicking loop
                    while (isAutoClicking)
                    {
                        ClickMouse(selectedButton);
                        Thread.Sleep(interval);
                    }
                }
            });

            autoClickThread.IsBackground = true;
            autoClickThread.Start();
        }

        private void PressKey(Keys key)
        {
            byte vk = (byte)key;
            keybd_event(vk, 0, KEYEVENTF_KEYDOWN, UIntPtr.Zero);
            Thread.Sleep(50); // short delay to simulate key hold
            keybd_event(vk, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
        }


        private void ClickMouse(string button)
        {
            switch (button)
            {
                case "Left":
                    mouse_event(MouseEventFlags.LEFTDOWN | MouseEventFlags.LEFTUP, 0, 0, 0, 0);
                    break;
                case "Right":
                    mouse_event(MouseEventFlags.RIGHTDOWN | MouseEventFlags.RIGHTUP, 0, 0, 0, 0);
                    break;
                case "Middle":
                    mouse_event(MouseEventFlags.MIDDLEDOWN | MouseEventFlags.MIDDLEUP, 0, 0, 0, 0);
                    break;
                case "E":
                    PressKey(Keys.E);
                    break;
                case "F":
                    PressKey(Keys.F);
                    break;
            }
        }

        private void HoldMouseDown(string button)
        {
            switch (button)
            {
                case "Left":
                    mouse_event(MouseEventFlags.LEFTDOWN, 0, 0, 0, 0);
                    break;
                case "Right":
                    mouse_event(MouseEventFlags.RIGHTDOWN, 0, 0, 0, 0);
                    break;
                case "Middle":
                    mouse_event(MouseEventFlags.MIDDLEDOWN, 0, 0, 0, 0);
                    break;
            }
        }

        private void HoldMouseUp(string button)
        {
            switch (button)
            {
                case "Left":
                    mouse_event(MouseEventFlags.LEFTUP, 0, 0, 0, 0);
                    break;
                case "Right":
                    mouse_event(MouseEventFlags.RIGHTUP, 0, 0, 0, 0);
                    break;
                case "Middle":
                    mouse_event(MouseEventFlags.MIDDLEUP, 0, 0, 0, 0);
                    break;
            }
        }


        private void StopAutoClicker()
        {
            isAutoClicking = false;
            lblStatus.Invoke((MethodInvoker)(() =>
            {
                lblStatus.Text = "Stopped";
                lblStatus.ForeColor = Color.Red;
            }));
        }

        private void SleepTxt_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(SleepTxt.Text, out int newSleep))
            {
                Sleep = newSleep;
            }
            else
            {
                MessageBox.Show("Invalid sleep time. Please enter a valid number.");
                SleepTxt.Text = Sleep.ToString(); // Reset to previous value
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/KTP23o/"; // Replace with your link
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Important for .NET Core and .NET 5+
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open the link: " + ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/kalikyle"; // Replace with your link
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Important for .NET Core and .NET 5+
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open the link: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string url = "www.linkedin.com/in/kyle-pintor-8a17a417b"; // Replace with your link
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Important for .NET Core and .NET 5+
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open the link: " + ex.Message);
            }
        }
    }
}
