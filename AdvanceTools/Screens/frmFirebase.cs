using svvv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheWitcher3Thai;

namespace AdvanceTools.Screens
{
    public partial class frmFirebase : Form
    {
        Common c = new Common();
        Setting setting = new Setting();
        Dictionary<string, string> sheetConfig;

        public frmFirebase()
        {
            InitializeComponent();
        }

        private void btnSelectExcel_Click(object sender, EventArgs e)
        {
            c.SelectXlsxTextBox(txtExcelPath);
        }

        private void btnExcelToJson_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtExcelPath.Text))
                return;

            var raw = c.ReadExcel(txtExcelPath.Text, sheetConfig, true);
            var data = c.ConvertToW2String(raw).ToDictionary(d=>d.Index,d=>d);
            var path = Path.Combine(Configs.OutputPath, "data.json");
            var json = c.ToJson(data);
            c.WriteJson(json, path);
            MessageBox.Show("finish");
        }

        private void frmFirebase_Load(object sender, EventArgs e)
        {
            sheetConfig = setting.GetSheetConfig();
        }

        private void txtExcelPath_DoubleClick(object sender, EventArgs e)
        {
            c.Open(Configs.StartupPath);
        }

        private void btnMakeData_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Configs.OutputPath, "data.json");
            var data = c.ReadWebJson(path);            
            c.WriteJson(data, Path.Combine(Configs.OutputPath, $@"data_{DateTime.Now.ToString("yyyyMMdd_HHmmssfff")}.json"));
            MessageBox.Show("finish");

        }

        private void btnGenerateExtraLanguage_Click(object sender, EventArgs e)
        {
            c.makeExtraLanguageExcel(txtExcelPath.Text);
            MessageBox.Show("finish");
        }

        private void btnGoogleTranslate_Click(object sender, EventArgs e)
        {
            var result = c.GoogleTranslate(
                "Unlike the First Nilfgaard War, the second conflict had no clear aggressor. In early 1267 the Northern kings met in Hagge and prepared a plan for the reconquest of Cintra. Foreseeing their intentions, Emperor var Emreis amassed a large expeditionary force on the Temerian border. He then masterminded a series of events that left the North ripe for an attack - a mages' revolt erupted on Thanedd, and King Vizimir was assassinated, leaving Redania in chaos. All Emhyr needed now was a pretext, which he received when soldiers supposedly from Aedirn attacked the Nilfgaardian frontier fortress known as Glevitzingen. Armed with that excuse, the Nilfgaardian forces marched north and the second war had begun.<br><br>During the first phase of the war, the imperial offensive quickly swept through the North. First they occupied southern Lyria. After a short siege, Rivia was next to fall. Next came the Battle of Aldersberg, and then Menno Coehoorn's march into Vengerberg. King Henselt of Kaedwen seized this opportunity to dismember his neighbor and signed an agreement with Nilfgaard partitioning Aedirn between them. Opportunistic elves also joined the Empire's cause and gained for their trouble an independent kingdom in Dol Blathanna. King Foltest was the next rat out of the sinking ship, signing a treaty with Nilfgaard and grabbing for himself the western portion of Aedirn. Deserted by his allies and left with a rump of a kingdom, Demavend, ruler of Aedirn, fled to seek shelter in Redania.<br><br>The first stage of the war ended and the second began when Nilfgaard broke its truce with Temeria after a mere sixteen days. Its forces then immediately invaded Brugge and Sodden, and soon both lands were awash in blood. In short order Emhyr had occupied all of southern Temeria and shattered Foltest’s troops at Maribor. Then the shrewd emperor retreated back to winter in Sodden and prepare a renewed offensive for the spring.<br><br>No war in history saw such fierce battles as the Great Temerian Offensive waged during those fair spring days. The united forces of the North at last proved themselves a worthy opponent and slowed the Nilfgaardian advance. This provided an opening for Emhyr's internal enemies to put in motion a plot for his overthrow. Weakened by this infighting (known as the Conspiracy of Nobles), the myth of its invincibility shattered, Nilfgaard’s mightiest army was then routed by Northern forces near Brenna. The tide of war had turned.<br><br>The fourth and final phase of the war then began. The North opened a counter-offensive forcing the Imperial Armies into a slow and bloody retreat. It was only a matter of time before armistice talks were opened, temporary cease-fire lines were drawn and the war drew to a close. Delegates from all parties to the conflict decided to convene in Cintra to draw up a peace treaty and establish a new world order. On the 2nd of April, 1268, the Peace of Cintra was signed, bringing an end to the Second Nilfgaard War.",
                "auto",
                "th"
             );
        }

        private void btnExtraJson_Click(object sender, EventArgs e)
        {
            c.makeExtraLanguageJson(txtExcelPath.Text);
            MessageBox.Show("finish");
        }
    }
}
