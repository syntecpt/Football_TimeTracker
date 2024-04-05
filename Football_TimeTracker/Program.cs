using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_TimeTracker
{
    internal static class Program
    {

    }

    class InterceptKeys
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private static GameForm _gameForm;
        private static GameForm _newform;

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            _hookID = SetHook( _proc );
            _gameForm = new GameForm();
            Application.Run( _gameForm );
            UnhookWindowsHookEx( _hookID );
        }

        public static void ResetApp()
        {
            Application.Restart();
        }

        private static IntPtr SetHook( LowLevelKeyboardProc proc )
        {
            using ( Process curProcess = Process.GetCurrentProcess() )
            using ( ProcessModule curModule = curProcess.MainModule )
            {
                return SetWindowsHookEx( WH_KEYBOARD_LL, proc,
                    GetModuleHandle( curModule.ModuleName ), 0 );
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(
            int nCode, IntPtr wParam, IntPtr lParam );

        private static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam )
        {
            if ( nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN )
            {
                int vkCode = Marshal.ReadInt32( lParam );
                //Console.WriteLine( (Keys)vkCode );
                //Console.WriteLine( "int code:" + vkCode );
                if(vkCode == 87) // W
                {
                    _gameForm.SegmentActiveButton_Click(null,null);
                }
                else if ( vkCode == 65 ) // A
                {
                    _gameForm.SegmentOutofBoundsButton_Click( null, null );
                }
                else if ( vkCode == 68 ) // D
                {
                    _gameForm.SegmentRefBlowButton_Click( null, null );
                }
                else if ( vkCode == 83 ) // S
                {
                    _gameForm.SegmentGoalButton_Click( null, null );
                }
                else if( vkCode == 13) // ENTER
                {
                    //_gameForm.ClickRightStartStopMethod();
                }
                else if (vkCode == 80) // P
                {
                    _gameForm.startButton_Click(null, null);
                }
            }
            return CallNextHookEx( _hookID, nCode, wParam, lParam );
        }

        [DllImport( "user32.dll", CharSet = CharSet.Auto, SetLastError = true )]
        private static extern IntPtr SetWindowsHookEx( int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId );

        [DllImport( "user32.dll", CharSet = CharSet.Auto, SetLastError = true )]
        [return: MarshalAs( UnmanagedType.Bool )]
        private static extern bool UnhookWindowsHookEx( IntPtr hhk );

        [DllImport( "user32.dll", CharSet = CharSet.Auto, SetLastError = true )]
        private static extern IntPtr CallNextHookEx( IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam );

        [DllImport( "kernel32.dll", CharSet = CharSet.Auto, SetLastError = true )]
        private static extern IntPtr GetModuleHandle( string lpModuleName );
    }
}
