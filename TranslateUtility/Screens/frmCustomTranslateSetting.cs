using svvv;
using svvv.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TheWitcher3Thai;

namespace TranslateUtility.Screens
{
    public partial class frmCustomTranslateSetting : Form
    {
        const string EMPTY_ID_MESSAGE = "[ใส่ ID และกดอัพเดทเพื่อดูคำอธิบาย]";
        enum eCol
        {
            Enable,
            Id,
            Description,
            Update,
            Open
        }

        //List<CustomTranslate> mData;
        Common c = new Common();
        Setting setting = new Setting();
        CustomTranslateSetting customSetting;


        public frmCustomTranslateSetting()
        {
            InitializeComponent();
        }

        private void frmCustomTranslateSetting_Load(object sender, EventArgs e)
        {
            InitialData();
        }

        private void InitialData()
        {
            customSetting = new CustomTranslateSetting(Configs.CustomTranslateSettingPath, setting.GetCustomTranslate());
            foreach (var item in customSetting.Value.Values)
            {
                AddRow(item);
            }
        }

        private void AddRow(CustomTranslateItem item)
        {
            gvSettingList.Rows.Add();

            // add row and set selection
            var lastrowIndex = gvSettingList.Rows.Count - 1;
            gvSettingList.Rows[lastrowIndex].Selected = true;

            // set data
            if (item == null)
            {
                gvSettingList.Rows[lastrowIndex].Cells[(int)eCol.Enable].Value = true;
                //gvSettingList.Rows[lastrowIndex].Cells[(int)eCol.Id].Value = $@"item {gvSettingList.Rows.Count}";
                gvSettingList.Rows[lastrowIndex].Cells[(int)eCol.Description].Value = EMPTY_ID_MESSAGE;
            }
            else
            {
                gvSettingList.Rows[lastrowIndex].Cells[(int)eCol.Enable].Value = item.Enable;
                gvSettingList.Rows[lastrowIndex].Cells[(int)eCol.Id].Value = item.ID;
                gvSettingList.Rows[lastrowIndex].Cells[(int)eCol.Description].Value = item.Description;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRow(null);
        }

        private void gvSettingList_Click(object sender, EventArgs e)
        {
            gvSettingList.EndEdit();
        }

        private int GetSelectedRowIndex()
        {
            if (gvSettingList.SelectedRows.Count == 0)
                return -1;

            return gvSettingList.SelectedRows[0].Index;
        }

        private void MoveUp(int index)
        {
            // check first row
            if (index < 1)
                return;

            int targetIndex = index - 1;
            MoveRow(index, targetIndex);

        }

        private void MoveDown(int index)
        {
            // check first row
            // check last row
            if (index >= gvSettingList.Rows.Count - 1)
                return;

            int targetIndex = index + 1;
            MoveRow(index, targetIndex);

        }

        private void MoveRow(int sourceIndex, int targetIndex)
        {
            // copy old value
            var enable = gvSettingList.Rows[sourceIndex].Cells[(int)eCol.Enable].Value as bool?;
            string id = gvSettingList.Rows[sourceIndex].Cells[(int)eCol.Id].Value as string;
            string desc = gvSettingList.Rows[sourceIndex].Cells[(int)eCol.Description].Value as string;

            gvSettingList.Rows.RemoveAt(sourceIndex);
            gvSettingList.Rows.Insert(targetIndex);
            gvSettingList.Rows[targetIndex].Cells[(int)eCol.Enable].Value = enable;
            gvSettingList.Rows[targetIndex].Cells[(int)eCol.Id].Value = id;
            gvSettingList.Rows[targetIndex].Cells[(int)eCol.Description].Value = desc;
            gvSettingList.Rows[targetIndex].Selected = true;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                MoveUp(GetSelectedRowIndex());
            }
            catch (Exception ex)
            {
                c.ShowErrorMessage(ex);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            try
            {
                MoveDown(GetSelectedRowIndex());
            }
            catch (Exception ex)
            {
                c.ShowErrorMessage(ex);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var index = GetSelectedRowIndex();
                if (index < 0)
                    return;

                if (gvSettingList.Rows.Count > 1 && index == gvSettingList.Rows.Count - 1)
                    gvSettingList.Rows[index - 1].Selected = true;

                gvSettingList.Rows.RemoveAt(index);
            }
            catch (Exception ex)
            {
                c.ShowErrorMessage(ex);
            }
        }

        private void gvSettingList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    if (e.ColumnIndex == (int)eCol.Enable)
                        ToggleEnableAll();

                    return;
                }

                if (e.ColumnIndex == (int)eCol.Enable)
                    ToggleEnable(e.RowIndex);

                else if (e.ColumnIndex == (int)eCol.Update)
                    UpdateCustomTranslate(e.RowIndex);

                else if (e.ColumnIndex == (int)eCol.Open)
                    OpenGoogleSheet(e.RowIndex);
            }
            catch (Exception ex)
            {
                c.ShowErrorMessage(ex);
            }
        }

        private void ToggleEnableAll()
        {
            var all = GetDataFromGrid();

            // have any disable
            if (all.Values.Any(c => c.Enable == false))
                SetAllCustomTranslateEnableEnable(true); // enable all
            else
                SetAllCustomTranslateEnableEnable(false); // disable all
        }

        private void SetAllCustomTranslateEnableEnable(bool enable)
        {
            for(int i=0;i<gvSettingList.RowCount;i++)
            {
                SetCustomTranslateEnableEnable(i, enable);
            }
        }

        private void OpenGoogleSheet(int rowIndex)
        {
            var id = gvSettingList.Rows[rowIndex].Cells[(int)eCol.Id].Value as string;
            c.OpenGoogleSheet(id);
        }

        private void UpdateCustomTranslate(int rowIndex)
        {
            string desc;
            var id = gvSettingList.Rows[rowIndex].Cells[(int)eCol.Id].Value as string;
            if (String.IsNullOrWhiteSpace(id))
            {
                desc = EMPTY_ID_MESSAGE;
            }
            else
            {
                c.DownloadCustomTranslateFile(id, Common.eDownloadFrequency.Always);

                desc = c.GetCustomTranslateDescription(id);
                if (desc == null)
                    desc = "[ID ไม่ถูกต้อง]";
            }

            gvSettingList.Rows[rowIndex].Cells[(int)eCol.Description].Value = desc;
        }

        private void ToggleEnable(int rowIndex)
        {
            var enable = gvSettingList.Rows[rowIndex].Cells[(int)eCol.Enable].Value as bool?;
            gvSettingList.Rows[rowIndex].Cells[(int)eCol.Enable].Value = !(enable ?? false);
        }

        private void SetCustomTranslateEnableEnable(int rowIndex, bool enable)
        {
            gvSettingList.Rows[rowIndex].Cells[(int)eCol.Enable].Value = enable;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
                this.Close();
            }
            catch (Exception ex)
            {
                c.ShowErrorMessage(ex);
            }
        }

        private void SaveData()
        {
            customSetting.Value = GetDataFromGrid();
            customSetting.Save();
            //c.ShowMessage("บันทึกเรียบร้อย");

        }

        private Dictionary<string, CustomTranslateItem> GetDataFromGrid()
        {
            string id;
            var result = new Dictionary<string, CustomTranslateItem>();

            foreach (DataGridViewRow row in gvSettingList.Rows)
            {
                id = row.Cells[(int)eCol.Id].Value as string;
                if (!String.IsNullOrWhiteSpace(id) && !result.ContainsKey(id))
                {
                    var item = new CustomTranslateItem();
                    item.Enable = (row.Cells[(int)eCol.Enable].Value as bool?) ?? false;
                    item.ID = id;
                    item.Description = row.Cells[(int)eCol.Description].Value as string;

                    result.Add(id, item);
                }
            }

            return result;
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            try
            {
                c.Processing(UpdateAllCustomTranslate, "กำลังอัพเดท...", "สำเร็จ");
            }
            catch(Exception ex)
            {
                c.ShowErrorMessage(ex);
            }
        }

        private void UpdateAllCustomTranslate()
        {
            for (int i = 0; i < gvSettingList.Rows.Count; i++)
            {
                UpdateCustomTranslate(i);
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            ToggleEnableAll();
        }
    }
}
