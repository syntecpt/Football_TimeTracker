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
        private static OptionsForm _optionsForm;

        private static Options _currOptions;

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

        public static void SetOptions(Options options)
        {
            _currOptions = options;
        }

        public static Options GetOptions()
        {
            return _currOptions;
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

        public static void OptionsShow()
        {
            _startForm.Hide();
            if (_optionsForm == null)
            {
                OptionsForm options = new OptionsForm();
                _optionsForm = options;
                options.Show();
            }
            else
            {
                _optionsForm.BringToFront();
            }
        }

        public static void CloseOptions()
        {
            _optionsForm.Dispose();
            _optionsForm = null;
            _startForm.Show();
        }

        public static string GetKeyDescription(int keyCode)
        {
            if (keyCode == 27) return "Escape";
            if (keyCode == 112) return "F1";
            if (keyCode == 113) return "F2";
            if (keyCode == 114) return "F3";
            if (keyCode == 115) return "F4";
            if (keyCode == 116) return "F5";
            if (keyCode == 117) return "F6";
            if (keyCode == 118) return "F7";
            if (keyCode == 119) return "F8";
            if (keyCode == 120) return "F9";
            if (keyCode == 121) return "F10";
            if (keyCode == 122) return "F11";
            if (keyCode == 123) return "F12";
            if (keyCode == 220) return "\\";
            if (keyCode == 49) return "1";
            if (keyCode == 50) return "2";
            if (keyCode == 51) return "3";
            if (keyCode == 52) return "4";
            if (keyCode == 53) return "5";
            if (keyCode == 54) return "6";
            if (keyCode == 55) return "7";
            if (keyCode == 56) return "8";
            if (keyCode == 57) return "9";
            if (keyCode == 48) return "0";
            if (keyCode == 219) return "'";
            if (keyCode == 221) return "«";
            if (keyCode == 8) return "Backspace";
            if (keyCode == 45) return "Insert";
            if (keyCode == 36) return "Home";
            if (keyCode == 33) return "PageUp";
            if (keyCode == 144) return "Num Lock";
            if (keyCode == 111) return "/";
            if (keyCode == 106) return "*";
            if (keyCode == 109) return "-";
            if (keyCode == 9) return "Tab";
            if (keyCode == 81) return "Q";
            if (keyCode == 87) return "W";
            if (keyCode == 69) return "E";
            if (keyCode == 82) return "R";
            if (keyCode == 84) return "T";
            if (keyCode == 89) return "Y";
            if (keyCode == 85) return "U";
            if (keyCode == 73) return "I";
            if (keyCode == 79) return "O";
            if (keyCode == 80) return "P";
            if (keyCode == 187) return "+";
            if (keyCode == 186) return "´";
            if (keyCode == 13) return "Enter";
            if (keyCode == 46) return "Delete";
            if (keyCode == 35) return "End";
            if (keyCode == 34) return "PageDown";
            if (keyCode == 103) return "(num)7";
            if (keyCode == 104) return "(num)8";
            if (keyCode == 105) return "(num)9";
            if (keyCode == 107) return "(num)+";
            if (keyCode == 20) return "Caps Lock";
            if (keyCode == 65) return "A";
            if (keyCode == 83) return "S";
            if (keyCode == 68) return "D";
            if (keyCode == 70) return "F";
            if (keyCode == 71) return "G";
            if (keyCode == 72) return "H";
            if (keyCode == 74) return "J";
            if (keyCode == 75) return "K";
            if (keyCode == 76) return "L";
            if (keyCode == 192) return "Ç";
            if (keyCode == 222) return "º";
            if (keyCode == 191) return "~";
            if (keyCode == 100) return "(num)4";
            if (keyCode == 101) return "(num)5";
            if (keyCode == 102) return "(num)6";
            if (keyCode == 160) return "L Shift";
            if (keyCode == 226) return "<";
            if (keyCode == 90) return "Z";
            if (keyCode == 88) return "X";
            if (keyCode == 67) return "C";
            if (keyCode == 86) return "V";
            if (keyCode == 66) return "B";
            if (keyCode == 78) return "N";
            if (keyCode == 77) return "M";
            if (keyCode == 188) return ",";
            if (keyCode == 190) return ".";
            if (keyCode == 189) return "-";
            if (keyCode == 161) return "R Shift";
            if (keyCode == 97) return "(num)1";
            if (keyCode == 98) return "(num)2";
            if (keyCode == 9) return "(num)3";
            if (keyCode == 13) return "(num)Enter";
            if (keyCode == 162) return "L Ctrl";
            if (keyCode == 91) return "Windows";
            if (keyCode == 32) return "Space";
            if (keyCode == 93) return "Menu";
            if (keyCode == 163) return "R Ctrl";
            if (keyCode == 38) return "Up";
            if (keyCode == 37) return "Left";
            if (keyCode == 40) return "Down";
            if (keyCode == 39) return "Right";
            if (keyCode == 96) return "(num)0";
            if (keyCode == 110) return "(num).";
            return "Indefinido";
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
                if (_gameForm != null)
                {

                    if (vkCode == _currOptions.currentActiveKey) // Active Key
                    {
                        _gameForm.SegmentActiveButton_Click( null, null );
                    }
                    else if (vkCode == _currOptions.currentOutOfBoundsKey) // OutOfBounds Key
                    {
                        _gameForm.SegmentOutofBoundsButton_Click( null, null );
                    }
                    else if (vkCode == _currOptions.currentRefBlowKey) // RefBlow Key
                    {
                        _gameForm.SegmentRefBlowButton_Click( null, null );
                    }
                    else if (vkCode == _currOptions.currentGoalKey) // Goal Key
                    {
                        _gameForm.SegmentGoalButton_Click( null, null );
                    }
                    else if (vkCode == _currOptions.currentStartStopKey) // StartStop Key
                    {
                        _gameForm.startButton_Click( null, null );
                    }
                    else if (vkCode == _currOptions.currentUndoKey) // Undo Key
                    {
                        _gameForm.UndoButton_Click( null, null );
                    }
                }

                if(_optionsForm != null)
                {
                    if(_optionsForm.settingKey)
                    {
                        _optionsForm.CloseKeybindForm(vkCode);
                    }
                    else return CallNextHookEx( _hookID, nCode, wParam, lParam );
                }

                if(_historyForm != null)
                {
                    if (vkCode == 13)    // Enter
                        _historyForm.filterTableButton_Click( null, null );
                }

                if(_popupForm != null)
                {
                    if (vkCode == 13)    // Enter
                        _popupForm.SetFocus();
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

    public class Options
    {
        public int currentActiveKey;
        public int currentOutOfBoundsKey;
        public int currentRefBlowKey;
        public int currentGoalKey;
        public int currentUndoKey;
        public int currentStartStopKey;

        public Options()
        {
            currentActiveKey = 87; // W
            currentOutOfBoundsKey = 65; // A
            currentRefBlowKey = 68; // D
            currentGoalKey = 83; // S
            currentUndoKey = 8; // Backspace
            currentStartStopKey = 80; // P
        }
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
