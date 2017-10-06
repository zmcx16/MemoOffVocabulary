using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MemoOffVocabulary
{
    static class win32API
    {

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("USER32.DLL", SetLastError = true)]
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        public static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        public static extern bool WritePrivateProfileSection(string section, string key_val_list, string lpFileName);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        public static extern int GetPrivateProfileSection(string section, byte[] lpReturnedString, int nSize, string lpFileName);

        public static void BringProcessToTop(IntPtr hWnd)
        {
            IntPtr HWND_TOPMOST = new IntPtr(-1);
            uint SWP_NOACTIVATE = 0x0010;
            uint SWP_NOMOVE = 0x0002;
            uint SWP_NOSIZE = 0x0001;
            SetWindowPos(hWnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE);
        }

        public static void GetPrivateProfileString(string section, string key, string def, ref StringBuilder retVal, string filePath)
        {
            int nBufferSize = 256;
            int nRetVal = 0;
            int nCnt = 0;
            do
            {
                nCnt++;
                retVal = new StringBuilder(nBufferSize * nCnt);
                nRetVal = GetPrivateProfileString(section, key, "", retVal, nBufferSize * nCnt, filePath);
            } while ((nRetVal == ((nBufferSize * nCnt) - 1)) ||(nRetVal == ((nBufferSize * nCnt) - 2)));
        }
    
    }
}
