using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

        private static NewGamePopupForm _popupForm;
        private static StartForm _startForm;
        private static GameForm _gameForm;
        private static HistoryForm _historyForm;
        private static HistoryDetailForm _historyDetailForm;

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            _hookID = SetHook( _proc );
            _startForm = new StartForm();
            Application.Run( _startForm );
            UnhookWindowsHookEx( _hookID );
        }

        public static void BackToMainForm()
        {
            _gameForm.Dispose();
            _gameForm = null;
            _startForm.Show();
        }

        public static void NewGameWindow(string gameName, string competition, DateTime date)
        {
            _startForm.Hide();
            _popupForm = null;
            string result = gameName + "_" + competition + "_" + date.ToString( "dd-MM-yyyy" );
            _gameForm = new GameForm( result );
            _gameForm.Show();
        }

        public static void NewGamePopup()
        {
            if ( _popupForm == null )
            {
                NewGamePopupForm popup = new NewGamePopupForm();
                _popupForm = popup;
                _popupForm.Show();
            }
            else
            {
                _popupForm.BringToFront();
            }
        }

        public static void HistoryShow()
        {
            _startForm.Hide();
            if ( _historyForm == null )
            {
                HistoryForm history = new HistoryForm();
                _historyForm = history;
                history.Show();
            }
            else
            {
                _historyForm.BringToFront();
            }
        }

        public static void CloseHistory()
        {
            _historyForm.Dispose();
            _historyForm = null;
            _startForm.Show();
        }

        public static void ShowHistoryDetail(string path)
        {
            _historyForm.Hide();
            if ( _historyDetailForm == null )
            {
                HistoryDetailForm historyDetail = new HistoryDetailForm(path);
                _historyDetailForm = historyDetail;
                _historyDetailForm.Show();
            }
            else
            {
                _historyDetailForm.BringToFront();
            }
        }

        public static void CloseHistoryDetail()
        {
            _historyDetailForm.Dispose();
            _historyDetailForm = null;
            _historyForm.Show();
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
                if(_gameForm == null)
                    return CallNextHookEx( _hookID, nCode, wParam, lParam );

                if (vkCode == 87) // W
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
                else if ( vkCode == 8 ) // Backspace
                {
                    _gameForm.RemoveSegmentButton_Click( null, null );
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

    public static class JsonSerialization
    {
        /// <summary>
        /// Writes the given object instance to a Json file.
        /// <para>Object type must have a parameterless constructor.</para>
        /// <para>Only Public properties and variables will be written to the file. These can be any type though, even other classes.</para>
        /// <para>If there are public properties/variables that you do not want written to the file, decorate them with the [JsonIgnore] attribute.</para>
        /// </summary>
        /// <typeparam name="T">The type of object being written to the file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the file.</param>
        /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
        public static void WriteToJsonFile<T>( string filePath, T objectToWrite, bool append = false ) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = Newtonsoft.Json.JsonConvert.SerializeObject( objectToWrite );
                writer = new StreamWriter( filePath, append );
                writer.Write( contentsToWriteToFile );
            }
            finally
            {
                if ( writer != null )
                    writer.Close();
            }
        }

        /// <summary>
        /// Reads an object instance from an Json file.
        /// <para>Object type must have a parameterless constructor.</para>
        /// </summary>
        /// <typeparam name="T">The type of object to read from the file.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the Json file.</returns>
        public static T ReadFromJsonFile<T>( string filePath ) where T : new()
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader( filePath );
                var fileContents = reader.ReadToEnd();
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>( fileContents );
            }
            finally
            {
                if ( reader != null )
                    reader.Close();
            }
        }
    }
}
