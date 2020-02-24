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
        private string PLAYER_CHARACTER_NAME_JSON_FILE_PATH = "";
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
                this.getSavedGamesUserPath();//populates SystemSaveGameFolderPath
                this.PLAYER_CHEST_JSON_FILE_PATH = SystemSaveGameFolderPath + "\\wolcen\\savegames\\playerchest.json";
                this.PLAYER_DATA_JSON_FILE_PATH = SystemSaveGameFolderPath + "\\wolcen\\savegames\\playerdata.json";
                this.PLAYER_CHARACTER_NAME_JSON_FILE_PATH = SystemSaveGameFolderPath + "\\wolcen\\savegames\\characters";
                this.playerchest = LoadFileJSONFromPath(this.PLAYER_CHEST_JSON_FILE_PATH);
                this.playerdata = LoadFileJSONFromPath(this.PLAYER_DATA_JSON_FILE_PATH);
                PopulateCharacterCombobox();
                textBox1.Text = this.playercharacter.ToString();

            }

            t.Abort();
        }

        private void PopulateCharacterCombobox()
        {
            BindingSource bs = new BindingSource();
            List<string> charactersList = GetCharactersList();
            bs.DataSource = charactersList;
            comboBox1.DataSource = bs;

            if(charactersList.Count == 1)
            {
                this.playercharacter = LoadFileJSONFromPath(this.PLAYER_CHARACTER_NAME_JSON_FILE_PATH+"\\"+charactersList[0]);
            }
        }
        private List<string> GetCharactersList()
        {
            DirectoryInfo d = new DirectoryInfo(@""+ this.PLAYER_CHARACTER_NAME_JSON_FILE_PATH);
            FileInfo[] Files = d.GetFiles("*.json"); //Getting Text files
            List<string> filelist = new List<string>();
           
            foreach (FileInfo file in Files)
            {
                filelist.Add(file.Name);
            }
            return filelist;
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
