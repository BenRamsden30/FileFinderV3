using System.Threading;
using System.Windows.Forms;
using System;

namespace FileFinderV3
{
    public partial class FileFinderV3 : Form
    {
        public FileFinderV3()
        {
            InitializeComponent();
        }

        #region Depricated
        //private void SelecLocationBtn_Click(object sender, EventArgs e)
        //{
        //    string Path = "";
        //    var T = new Thread((ThreadStart)(() =>
        //    {
        //        FolderBrowserDialog ofd = new FolderBrowserDialog();
        //        //ofd.InitalDirectory = "c:\\";

        //        if (ofd.ShowDialog() == DialogResult.OK)
        //        {
        //            var path = ofd.SelectedPath;
        //        }
        //        Path = ofd.SelectedPath;
        //    }));

        //    T.SetApartmentState(ApartmentState.STA);
        //    T.Start();
        //    T.Join();

        //    FileLocationtxt.Text = Path;

        //    MessageBox.Show("File selected, please see check the textbox to see if the file is correct");
        //}

        private void SearchPhrasetxt_TextChanged(object sender, EventArgs e)
        {

        }

        //private void SearchFilesbtn_Click(object sender, EventArgs e)
        //{
        //    ResultsLV.Items.Clear();

        //    DateTime StartDate = DateTime.Now;
        //    DateTime EndDate = DateTime.Now;

        //    if (UseDatesCheck.Checked)
        //    {
        //        StartDate = DateRangeSelectorTbl.SelectionRange.Start;
        //        EndDate = DateRangeSelectorTbl.SelectionRange.End;
        //    }

        //    string[] files = FileProcess.GatherFiles(FileLocationtxt.Text);
        //    string[] foundFiles = FileSearch.SearchFiles(files, SearchPhrasetxt.Text, StartDate, EndDate, UseDatesCheck.Checked);

        //    foreach (string file in foundFiles)
        //    {
        //        if (!(string.IsNullOrEmpty(file)))
        //        {
        //            ResultsLV.Items.Add(file);
        //        }
        //    }
        //}
        #endregion
        private void SelecLocationBtn_Click_1(object sender, EventArgs e)
        
            {
                string Path = "";
                var T = new Thread((ThreadStart)(() =>
                {
                    FolderBrowserDialog ofd = new FolderBrowserDialog();
                    //ofd.InitalDirectory = "c:\\";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        var path = ofd.SelectedPath;
                    }
                    Path = ofd.SelectedPath;
                }));

                T.SetApartmentState(ApartmentState.STA);
                T.Start();
                T.Join();

                FileLocationtxt.Text = Path;

                MessageBox.Show("File selected, please see check the textbox to see if the file is correct");
            }

        private void SearchFilesbtn_Click_1(object sender, EventArgs e)
        {
            ResultsLV.Items.Clear();

            DateTime StartDate = DateTime.Now;
            DateTime EndDate = DateTime.Now;

            if (UseDatesCheck.Checked)
            {
                StartDate = DateRangeSelectorTbl.SelectionRange.Start;
                EndDate = DateRangeSelectorTbl.SelectionRange.End;
            }

            string[] files = FileProcess.GatherFiles(FileLocationtxt.Text);
            string[] foundFiles = FileSearch.SearchFiles(files, SearchPhrasetxt.Text, StartDate, EndDate, UseDatesCheck.Checked);

            foreach (string file in foundFiles)
            {
                if (!(string.IsNullOrEmpty(file)))
                {
                    ResultsLV.Items.Add(file);
                }
            }
        }
    }
}
