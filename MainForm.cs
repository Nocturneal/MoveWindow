using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveWindow {
    public partial class MainForm : Form {
        public class WindowData {
            public bool isSelected;
            public string windowName;
            public IntPtr windowHandle;
            public int pid;
            public Process process;

            public WindowData(Process process, bool isSelected = false) {
                this.process = process;
                windowName = process.ProcessName;
                windowHandle = process.MainWindowHandle;
                pid = process.Id;
            }
        }

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern int SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        [DllImport("user32.dll", EntryPoint = "BringWindowToTop")]
        public static extern int BringWindowToTop(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "ShowWindow")]
        public static extern int ShowWindow(IntPtr hWnd, int nCmdShow);

        private IntPtr myWindowHandle = IntPtr.Zero;
        private List<Process> windowProcesses = new List<Process>();
        private List<WindowData> allWindows = new List<WindowData>();

        private List<int> selectedLast = new List<int>();

        public MainForm() {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(0, 0);

            LocationChanged += (s, e) => BeginInvoke(new Action(() => posResult.Text = $"x={Location.X}, y={Location.Y}"));

            windowListBox.SelectedValueChanged += WindowListBox_SelectedValueChanged;

            moveAllBtn.Click += moveAllBtn_Click;
            resetBtn.Click += resetBtn_Click;
            clearSelectionBtn.Click += ClearSelectionBtn_Click;

            myWindowHandle = Process.GetCurrentProcess().MainWindowHandle;

            Load += (s, e) => UpdateProcessList();
        }

        private void RefreshProcessList() {
            myWindowHandle = Process.GetCurrentProcess().MainWindowHandle;
            windowProcesses = Process.GetProcesses().Where(p => p.MainWindowHandle != IntPtr.Zero && p.MainWindowHandle != myWindowHandle).ToList();
        }

        public void MoveWindows() {
            int x = 0, y = 0, h = 0, w = 0;
            //const short SWP_NOMOVE = 0X2;
            const short SWP_NOSIZE = 1;
            //const short SWP_NOZORDER = 0X4;
            const int SWP_SHOWWINDOW = 0x0040;
            const int SWP_ASYNCWINDOWPOS = 0x4000;

            const int SW_RESTORE = 0x0009;

            x = Location.X;
            y = Location.Y;

            foreach (var window in allWindows.Where(win => win.isSelected)) {
                if (Process.GetProcessesByName(window.windowName).Length == 0 || window.windowHandle == IntPtr.Zero) continue;
                ShowWindow(window.windowHandle, SW_RESTORE);
                SetWindowPos(window.windowHandle, 0, x, y, w, h, SWP_ASYNCWINDOWPOS | SWP_NOSIZE | SWP_SHOWWINDOW);
                BringWindowToTop(window.windowHandle);
            }
        }

        private void moveAllBtn_Click(object sender, EventArgs e) {
            var selectedWindows = allWindows.Where(w => w.isSelected);
            var multi = selectedWindows.Count() > 0;
            var message = multi ? "About to move windows for:\n" : "Are you sure you want to move ALL windows?";
            var windowNames = multi ? $" - {string.Join(Environment.NewLine + " - ", selectedWindows.Select(w => w.windowName))}" : "";
            var res = MessageBox.Show(message + windowNames, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes) MoveWindows();
        }

        private void resetBtn_Click(object sender, EventArgs e) {
            Location = new Point(0, 0);
        }

        private void ClearSelectionBtn_Click(object sender, EventArgs e) {
            windowListBox.ClearSelected();
        }

        private void UpdateProcessList() {
            RefreshProcessList();
            windowListBox.ClearSelected();
            windowListBox.Items.Clear();
            foreach(var process in windowProcesses) {
                var obj = new WindowData(process);
                allWindows.Add(obj);
                windowListBox.Items.Add(obj.windowName);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e) => UpdateProcessList();

        private void WindowListBox_SelectedValueChanged(object sender, EventArgs e) {
            var selectedNow = windowListBox.SelectedIndices.Cast<int>();
            foreach(int i in selectedLast.Except(selectedNow)) {
                var query = windowListBox.Items[i].ToString();
                var match = allWindows.Where(w => w.windowName.Equals(query)).FirstOrDefault();
                if (match != null) match.isSelected = false;
            }
            selectedLast.Clear();
            foreach(int i in selectedNow) {
                var query = windowListBox.Items[i].ToString();
                var match = allWindows.Where(w => w.windowName.Equals(query)).FirstOrDefault();
                if (match != null) match.isSelected = true;
                selectedLast.Add(i);
            }
        }

    }
}
