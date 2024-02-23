using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FileFinderV3
{
    partial class FileFinderV3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelecLocationBtn = new System.Windows.Forms.Button();
            this.DateRangeSelectorTbl = new System.Windows.Forms.MonthCalendar();
            this.DateSelectorLbl = new System.Windows.Forms.Label();
            this.SearchPhrasetxt = new System.Windows.Forms.TextBox();
            this.SearchPhraseLbl = new System.Windows.Forms.Label();
            this.FileLocationtxt = new System.Windows.Forms.TextBox();
            this.SearchFilesLbl = new System.Windows.Forms.Label();
            this.SearchFilesbtn = new System.Windows.Forms.Button();
            this.ResultsLV = new System.Windows.Forms.ListView();
            this.UseDatesCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SelecLocationBtn
            // 
            this.SelecLocationBtn.Location = new System.Drawing.Point(21, 10);
            this.SelecLocationBtn.Name = "SelecLocationBtn";
            this.SelecLocationBtn.Size = new System.Drawing.Size(195, 37);
            this.SelecLocationBtn.TabIndex = 0;
            this.SelecLocationBtn.Text = "Select Location";
            this.SelecLocationBtn.UseVisualStyleBackColor = true;
            this.SelecLocationBtn.Click += new System.EventHandler(this.SelecLocationBtn_Click_1);
            // 
            // DateRangeSelectorTbl
            // 
            this.DateRangeSelectorTbl.Location = new System.Drawing.Point(21, 175);
            this.DateRangeSelectorTbl.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.DateRangeSelectorTbl.Name = "DateRangeSelectorTbl";
            this.DateRangeSelectorTbl.TabIndex = 1;
            // 
            // DateSelectorLbl
            // 
            this.DateSelectorLbl.AutoSize = true;
            this.DateSelectorLbl.Location = new System.Drawing.Point(79, 154);
            this.DateSelectorLbl.Name = "DateSelectorLbl";
            this.DateSelectorLbl.Size = new System.Drawing.Size(72, 13);
            this.DateSelectorLbl.TabIndex = 2;
            this.DateSelectorLbl.Text = "Date Selector";
            // 
            // SearchPhrasetxt
            // 
            this.SearchPhrasetxt.Location = new System.Drawing.Point(21, 123);
            this.SearchPhrasetxt.Name = "SearchPhrasetxt";
            this.SearchPhrasetxt.Size = new System.Drawing.Size(195, 20);
            this.SearchPhrasetxt.TabIndex = 3;
            // 
            // SearchPhraseLbl
            // 
            this.SearchPhraseLbl.AutoSize = true;
            this.SearchPhraseLbl.Location = new System.Drawing.Point(79, 100);
            this.SearchPhraseLbl.Name = "SearchPhraseLbl";
            this.SearchPhraseLbl.Size = new System.Drawing.Size(77, 13);
            this.SearchPhraseLbl.TabIndex = 4;
            this.SearchPhraseLbl.Text = "Search Phrase";
            // 
            // FileLocationtxt
            // 
            this.FileLocationtxt.Location = new System.Drawing.Point(21, 65);
            this.FileLocationtxt.Name = "FileLocationtxt";
            this.FileLocationtxt.ReadOnly = true;
            this.FileLocationtxt.Size = new System.Drawing.Size(195, 20);
            this.FileLocationtxt.TabIndex = 5;
            // 
            // SearchFilesLbl
            // 
            this.SearchFilesLbl.AutoSize = true;
            this.SearchFilesLbl.Location = new System.Drawing.Point(86, 368);
            this.SearchFilesLbl.Name = "SearchFilesLbl";
            this.SearchFilesLbl.Size = new System.Drawing.Size(65, 13);
            this.SearchFilesLbl.TabIndex = 6;
            this.SearchFilesLbl.Text = "Search Files";
            // 
            // SearchFilesbtn
            // 
            this.SearchFilesbtn.Location = new System.Drawing.Point(21, 393);
            this.SearchFilesbtn.Name = "SearchFilesbtn";
            this.SearchFilesbtn.Size = new System.Drawing.Size(195, 29);
            this.SearchFilesbtn.TabIndex = 7;
            this.SearchFilesbtn.Text = "Search Files";
            this.SearchFilesbtn.UseVisualStyleBackColor = true;
            this.SearchFilesbtn.Click += new System.EventHandler(this.SearchFilesbtn_Click_1);
            // 
            // ResultsLV
            // 
            this.ResultsLV.GridLines = true;
            this.ResultsLV.HideSelection = false;
            this.ResultsLV.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ResultsLV.Location = new System.Drawing.Point(253, 10);
            this.ResultsLV.Name = "ResultsLV";
            this.ResultsLV.ShowItemToolTips = true;
            this.ResultsLV.Size = new System.Drawing.Size(362, 412);
            this.ResultsLV.TabIndex = 8;
            this.ResultsLV.UseCompatibleStateImageBehavior = false;
            this.ResultsLV.View = System.Windows.Forms.View.List;
            // 
            // UseDatesCheck
            // 
            this.UseDatesCheck.AutoSize = true;
            this.UseDatesCheck.Location = new System.Drawing.Point(66, 348);
            this.UseDatesCheck.Name = "UseDatesCheck";
            this.UseDatesCheck.Size = new System.Drawing.Size(106, 17);
            this.UseDatesCheck.TabIndex = 9;
            this.UseDatesCheck.Text = "Use Date Range";
            this.UseDatesCheck.UseVisualStyleBackColor = true;
            // 
            // FileFinderV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 435);
            this.Controls.Add(this.UseDatesCheck);
            this.Controls.Add(this.ResultsLV);
            this.Controls.Add(this.SearchFilesbtn);
            this.Controls.Add(this.SearchFilesLbl);
            this.Controls.Add(this.FileLocationtxt);
            this.Controls.Add(this.SearchPhraseLbl);
            this.Controls.Add(this.SearchPhrasetxt);
            this.Controls.Add(this.DateSelectorLbl);
            this.Controls.Add(this.DateRangeSelectorTbl);
            this.Controls.Add(this.SelecLocationBtn);
            this.Name = "FileFinderV3";
            this.Text = "File Finder V3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SelecLocationBtn;
        private MonthCalendar DateRangeSelectorTbl;
        private Label DateSelectorLbl;
        private TextBox SearchPhrasetxt;
        private Label SearchPhraseLbl;
        private TextBox FileLocationtxt;
        private Label SearchFilesLbl;
        private Button SearchFilesbtn;
        private ListView ResultsLV;
        private CheckBox UseDatesCheck;
    }
}
