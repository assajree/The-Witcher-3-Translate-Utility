using svvv;
using svvv.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TheWitcher3Thai;

namespace TranslateUtility.Screens
{
    public partial class frmCustomTranslateSetting : Form
    {
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
            if(item==null)
            {
                gvSettingList.Rows[lastrowIndex].Cells[(int)eCol.Enable].Value = true;
                //gvSettingList.Rows[lastrowIndex].Cells[(int)eCol.Id].Value = $@"item {gvSettingList.Rows.Count}";
                gvSettingList.Rows[lastrowIndex].Cells[(int)eCol.Description].Value = "[ใส่ ID และกดอัพเดทเพื่อดูคำอธิบาย]";
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
            if (index >= gvSettingList.Rows.Count-1)
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
            MoveUp(GetSelectedRowIndex());
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveDown(GetSelectedRowIndex());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var index = GetSelectedRowIndex();
            if (index < 0)
                return;

            if (gvSettingList.Rows.Count > 1 && index == gvSettingList.Rows.Count - 1)
                gvSettingList.Rows[index - 1].Selected=true;

            gvSettingList.Rows.RemoveAt(index);
        }

        private void gvSettingList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == (int)eCol.Enable)
                ToggleEnable(e.RowIndex);

            else if (e.ColumnIndex == (int)eCol.Update)
                UpdateCustomTranslate(e.RowIndex);

            else if (e.ColumnIndex == (int)eCol.Open)
                OpenGoogleSheet(e.RowIndex);
        }

        private void OpenGoogleSheet(int rowIndex)
        {
            var id = gvSettingList.Rows[rowIndex].Cells[(int)eCol.Id].Value as string;
            c.OpenGoogleSheet(id);
        }

        private void UpdateCustomTranslate(int rowIndex)
        {
            var id= gvSettingList.Rows[rowIndex].Cells[(int)eCol.Id].Value as string;
            c.DownloadCustomTranslateFile(id, Common.eDownloadFrequency.Always);

            var desc = c.GetCustomTranslateDescription(id);
            if (desc == null)
                desc = "[ID ไม่ถูกต้อง]";

            gvSettingList.Rows[rowIndex].Cells[(int)eCol.Description].Value = desc;
        }

        private void ToggleEnable(int rowIndex)
        {
            var enable = gvSettingList.Rows[rowIndex].Cells[(int)eCol.Enable].Value as bool?;
            gvSettingList.Rows[rowIndex].Cells[(int)eCol.Enable].Value = !(enable ?? false);
        }
    }
}
