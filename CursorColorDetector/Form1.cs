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

        // DLL imports
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // Constants
        private const int HOTKEY_ID = 9000; // any unique ID
        private const int WM_HOTKEY = 0x0312;

        public Form1()
        {
            InitializeComponent();
            lblStatus.Text = "Stopped";
            lblStatus.ForeColor = Color.Red;
            this.KeyPreview = true;
            TOLERANCE = 5;
            TolTxt1.Text = TOLERANCE.ToString();
            Sleep = 500;
            SleepTxt.Text = Sleep.ToString();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            ToggleBot();
        }
        private void ToggleBot()
        {
            isRunning = !isRunning;
            Sleep = int.Parse(SleepTxt.Text);

            if (isRunning)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    lblStatus.Text = "Running...";
                    lblStatus.ForeColor = Color.Green; // Set text color to green
                }));
                btnToggle.Text = "Stop Bot";
                botThread = new Thread(RunBot);
                botThread.IsBackground = true;
                botThread.Start();
            }
            else
            {
                lblStatus.Text = "Stopped";
                lblStatus.ForeColor = Color.Red;
                btnToggle.Text = "Start Bot";
                // Let the bot loop naturally exit
            }
        }

        private void RunBot()
        {
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
