﻿using svvv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TheWitcher3Thai;
using TheWitcher3Thai.Helper;

namespace TranslateUtility.Screens
{
    public partial class frmMessageFinder : Form
    {
        List<w3Strings> mData;
        List<w3Strings> mSearchResult;

        Common c = new Common();
        Setting setting = new Setting();

        enum eSearchFild
        {
            All,
            Message,
            Translate
        }

        public frmMessageFinder()
        {
            InitializeComponent();
        }

        private void frmMessageFinder_Load(object sender, EventArgs e)
        {
            ToggleDetail();
        }

        private void frmMessageFinder_Shown(object sender, EventArgs e)
        {
            gvSearchResult.AutoGenerateColumns = false;            
        }

        private void ReadData()
        {
            try
            {
                string excelPath = Path.Combine(Configs.StartupPath, "mod", "translate.xlsx");
                if (!File.Exists(excelPath))
                    throw new Exception("ไม่พบไฟล์ข้อความ กรุณาสร้าง mod ก่อน");

                var dict = c.ReadAllExcel(excelPath);
                mData = c.ConvertToList(dict);
            }
            catch (Exception ex)
            {
                mData = new List<w3Strings>();
                throw ex;
            }
        }

        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = $@"{row.Index + 1}";
            }

            dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            if(mData==null)
                c.Processing(ReadData, false, "กำลังอ่านข้อความ...");

            if (String.IsNullOrWhiteSpace(txtInput.Text))
                return;

            ClearDetail();

            FilterData();
            gvSearchResult.DataSource = mSearchResult;
            setRowNumber(gvSearchResult);

            if (mSearchResult.Count == 0)
                c.ShowMessage("ไม่พบข้อความ");
        }

        private eSearchFild GetSearchField()
        {
            if (rdoAll.Checked)
                return eSearchFild.All;
            else if (rdoOriginal.Checked)
                return eSearchFild.Message;
            else if (rdoTranslate.Checked)
                return eSearchFild.Translate;
            else
                return eSearchFild.All;
        }

        private void FilterData()
        {
            string textToSearch = txtInput.Text.Trim().ToLower();
            eSearchFild searchFild = GetSearchField();

            //textToSearch = textToSearch.ToLower();

            List<w3Strings> result = new List<w3Strings>();
            foreach (var message in mData)
            {
                if (searchFild == eSearchFild.All)
                {
                    if (message.Text.ToLower().Contains(textToSearch) || message.Translate.ToLower().Contains(textToSearch))
                        result.Add(message);
                }
                else if (searchFild == eSearchFild.Message)
                {
                    if (message.Text.ToLower().Contains(textToSearch))
                        result.Add(message);
                }
                else if (searchFild == eSearchFild.Translate)
                {
                    if (!String.IsNullOrWhiteSpace(message.Translate) && message.Translate.ToLower().Contains(textToSearch))
                        result.Add(message);
                }
            }

            mSearchResult = result;
        }

        

        private void gvSearchResult_SelectionChanged(object sender, EventArgs e)
        {
                SetData();
        }

        private void SetData()
        {
            if (gvSearchResult.SelectedRows.Count < 1)
                return;

            var data = mSearchResult[gvSearchResult.SelectedRows[0].Index];
            txtSheetName.Text = data.SheetName;
            txtRowNumber.Text = data.RowNumber.ToStringOrNull();
            txtOriginalText.Text = data.Text;
            txtTranslateText.Text = data.Translate;
        }

        private void ClearDetail()
        {
            txtSheetName.Clear();
            txtRowNumber.Clear();
            txtOriginalText.Clear();
            txtTranslateText.Clear();
        }

        private void lblDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ToggleDetail();
        }

        private void ToggleDetail()
        {
            if (pnDetail.Visible)
            {
                pnDetail.Visible = false;
                //this.Height -= pnDetail.Height;
                //gvSearchResult.Height+= pnDetail.Height;
            }
            else
            {
                pnDetail.Visible = true;
                //this.Height += pnDetail.Height;
                //gvSearchResult.Height -= pnDetail.Height;
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchData();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (gvSearchResult.SelectedRows.Count < 1)
                return;

            var data = mSearchResult[gvSearchResult.SelectedRows[0].Index];
            var result = String.Format("{0}\t{1}\t{2}\t{3}\t{4}",data.ID,data.KeyHex,data.KeyString,data.Text,data.Translate);
            Clipboard.SetText(result);
        }
    }
}
