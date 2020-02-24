using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace WolcenEditor
{
    public partial class WolcenMainWindows : Form
    {

        #region KnownFolder
        [DllImport("shell32.dll")]
        static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken, out IntPtr pszPath);
        #endregion

        private string SystemSaveGameFolderPath = "";
        public static readonly Guid SavedGames = new Guid("{4C5C32FF-BB9D-43b0-B5B4-2D72E54EAAA4}");

        private string PLAYER_DATA_JSON_FILE_PATH = "";
        private string PLAYER_CHEST_JSON_FILE_PATH = "";
        private string PLAYER_CHARACTER_NAME_JSON_FILE_PATH = "";//Populated after choosing characters
        private JObject playerchest;
        private JObject playerdata;
        private JObject playercharacter;

        public WolcenMainWindows()
        {
            Thread t = new Thread(new ThreadStart(StartProgram));
            t.Start();
            Thread.Sleep(5000);
            this.BringToFront();
            InitializeComponent();
            this.BringToFront();
            //TODO code

            if (Environment.OSVersion.Version.Major >= 6)
            {
                getSavedGamesUserPath();//populates SystemSaveGameFolderPath
                this.PLAYER_CHEST_JSON_FILE_PATH = SystemSaveGameFolderPath + "\\wolcen\\savegames\\playerchest.json";
                this.PLAYER_DATA_JSON_FILE_PATH = SystemSaveGameFolderPath + "\\wolcen\\savegames\\playerdata.json";






            }

            t.Abort();
        }

        public void StartProgram()
        {
            Application.Run(new WolcenSplashScreen());
        }
        protected override void OnPaintBackground(PaintEventArgs e) { /* Ignore */ }
        private void WolcenMainWindows_Load(object sender, EventArgs e)
        {

        }

        private JObject LoadFileJSONFromPath(string path)
        {
            JObject jo;
            using (StreamReader file = File.OpenText(@"" + path))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                jo = JObject.Load(reader);
            }
            return jo;
        }

        private void getSavedGamesUserPath()
        {
            IntPtr pPath;
            SHGetKnownFolderPath(SavedGames, 0, IntPtr.Zero, out pPath);
            this.SystemSaveGameFolderPath = System.Runtime.InteropServices.Marshal.PtrToStringUni(pPath);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(pPath);
        }
    }
}
