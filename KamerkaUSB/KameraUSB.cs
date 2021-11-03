using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace KamerkaUSB
{
    class KameraUSB
    {
        private const int WM_CAP_START = 1024;
        private const short WM_CAP = 0x400;
        private const int WM_CAP_DRIVER_CONNECT = 0x40a;
        private const int WM_CAP_DLG_VIDEOFORMAT = WM_CAP_START + 41;
        private const int WM_CAP_DLG_VIDEOSOURCE = WM_CAP_START + 42;
        private const int WM_CAP_FILE_SET_CAPTURE_FILE = WM_CAP_START + 21;
        private const int WM_CAP_SEQUENCE = WM_CAP_START + 62;
        private const int WM_CAP_SET_SEQUENCE_SETUP = WM_CAP_START + 64;
        private const int WM_CAP_FILE_SAVEAS = WM_CAP_START + 23;
        private const int WM_CAP_PAL_SAVE = WM_CAP_START + 81;
        private const int WM_CAP_DRIVER_DISCONNECT = 0x40b;
        private const int WM_CAP_EDIT_COPY = 0x41e;
        private const int WM_CAP_SET_PREVIEW = 0x432;
        private const int WM_CAP_SET_OVERLAY = 0x433;
        private const int WM_CAP_SET_PREVIEWRATE = 0x434;
        private const int WM_CAP_SET_SCALE = 0x435;
        private const int WS_CHILD = 0x40000000;
        private const int WS_VISIBLE = 0x10000000;
        private const short SWP_NOMOVE = 0x2;

        //pozwala wypisać urządzenia
        [DllImport("avicap32.dll")]
        protected static extern bool capGetDriverDescription(short wDriverIndex, [MarshalAs(UnmanagedType.VBByRefStr)] ref String lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref String lpszVer, int cbVer);

        //pozwala wyświetlić 
        [DllImport("avicap32.dll")]
        protected static extern int capCreateCaptureWindow([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszWindowName, int dwStyle, int x, int y, int nWidth, int nHeight, int hWndParent, int nID);

        //ustwia pozycje
        [DllImport("user32")]
        protected static extern int SetWindowPosition(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

        //wysyla widomosci do okna
        [DllImport("user32", EntryPoint = "SendMessageA")]
        protected static extern int SendMessage(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.AsAny)] object lParam);

        //wylacza okno
        [DllImport("user32")]
        protected static extern bool DestroyWindow(int hwnd);


        int deviceIndex;
        int windowHandler;
   

        public List<String> findDevice()
        {
            string name = String.Empty.PadRight(100);
            string version = String.Empty.PadRight(100);
            List<string> listOfDevices = new List<string>();

            for(short i = 0; capGetDriverDescription(i, ref name, 100, ref version, 100); i++)
            {
                listOfDevices.Add(name.Trim() + version.Trim());
            }
            return listOfDevices.Count == 0 ? null : listOfDevices;
        }

        public void startConnection(int index, PictureBox box)
        {
            string device = index.ToString();
            deviceIndex = index;
            int handler = box.Handle.ToInt32();
            setResolution();
            windowHandler = capCreateCaptureWindow(ref device, WS_CHILD | WS_VISIBLE, 0, 0, 1600, 1200, handler, 0);
            
            SendMessage(windowHandler, WM_CAP_DRIVER_CONNECT, index, 0);
            
            SendMessage(windowHandler, WM_CAP_SET_PREVIEWRATE, 30, 0);

            SendMessage(windowHandler, WM_CAP_SET_PREVIEW, -1, 0);

            SendMessage(windowHandler, WM_CAP_SET_SCALE, 0, 0);
            
        }

        public void setResolution()
        {
            SendMessage(windowHandler, WM_CAP_DLG_VIDEOFORMAT, 0, 0);
        }

        public void setContrast()
        {
            SendMessage(windowHandler, WM_CAP_DLG_VIDEOSOURCE, 0, 0);
        }
    
        public void makeZoom(int value)
        {
            SendMessage(windowHandler, WM_CAP_SET_SCALE, value, 0);
        }

        public Image makePhoto()
        {
            SendMessage(windowHandler, WM_CAP_EDIT_COPY, 0, 0);

            return Clipboard.GetImage();
        }

        public void makeVideo()
        {
            SendMessage(windowHandler, WM_CAP_SET_SEQUENCE_SETUP, 0, 0);
            SendMessage(windowHandler, WM_CAP_SEQUENCE, 0, 0);
        }

        public void stopRecording()
        {
            SendMessage(windowHandler, WM_CAP_PAL_SAVE, 0, "file.avi");
        }

        public void closeConnection()
        {
            SendMessage(windowHandler, WM_CAP_DRIVER_DISCONNECT, deviceIndex, 0);
            DestroyWindow(windowHandler);
        }
    }
}
