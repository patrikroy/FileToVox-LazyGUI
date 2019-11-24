using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

// FileToVox Lazy GUI v0.1
// PatrikRoy 11/2019

namespace FileToVox_LazyGUI
{
    public partial class Form1 : Form
    {

        // Global variables
        string defaultGUIPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        string myCompPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
        string outputCmd;
        string f2vPathFull;
        string inputPathFull;
        string inputPathDisplay;
        string outputPath;
        string outputFilenameNoExt;
        string outputPathDisplay;

        public Form1()
        {
            InitializeComponent();
        }

        // Function: update command line
        public void updateOutputCmd()
        {
            // get *Path*
            if (string.IsNullOrEmpty(inputPathFull))
            {
                // Input file is not selected, display nothing
            }
            else
            {
                // Input file has been chosen
                inputPathDisplay = " \"" + inputPathFull + "\""; // get input file display from user's choice
                outputFilenameNoExt = System.IO.Path.GetFileNameWithoutExtension(inputPathFull); // get output filename from input filename without extension
                
                // Does output directory has been chosen?
                if (string.IsNullOrEmpty(outputPath))
                {
                    // No, so make it the same as inputPathFull, without file extension
                    outputPath = System.IO.Path.GetDirectoryName(inputPathFull);
                    outputPathDisplay = " \"" + outputPath + "\\" + outputFilenameNoExt + "\"";
                }
                else
                {
                    // Yes, so keep the user's choice
                    outputPathDisplay = " \"" + outputPath + outputFilenameNoExt + "\"";
                }
                
            }

            outputCmd = f2vPathFull + inputPathDisplay + outputPathDisplay; // build outputCmd from displays
            textBox_outputCmd.Text = outputCmd;
        }

        private void textBox_f2vPath_Click(object sender, EventArgs e)
        {
            // FileToVox path
            OpenFileDialog f2vPathDialog = new OpenFileDialog
            {
                InitialDirectory = defaultGUIPath,
                Title = "FileToVox location",

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "FileToVox executable (*.exe) | *.exe",
                RestoreDirectory = true,

                ShowReadOnly = false
            };

            if (f2vPathDialog.ShowDialog() == DialogResult.OK || f2vPathDialog.ShowDialog() == DialogResult.Yes)
            {
                textBox_f2vPath.Text = f2vPathFull = f2vPathDialog.FileName;
                updateOutputCmd();
            }
        }

        private void textBox_inputfile_Click(object sender, EventArgs e)
        {
            // Input file path
            OpenFileDialog inputFileDialog = new OpenFileDialog
            {
                InitialDirectory = myCompPath,
                Title = "FileToVox input file",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "png",
                Filter = "FileToVox files (*.schematic, *.png, *.asc, *.binvox, *.qb, *.ply, *.xyz) | *.schematic; *.png; *.asc; *.binvox; *.qb; *.ply; *.xyz",
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (inputFileDialog.ShowDialog() == DialogResult.OK || inputFileDialog.ShowDialog() == DialogResult.Yes)
            {
                textBox_inputFile.Text = inputPathFull = inputFileDialog.FileName;
                updateOutputCmd();
            }
        }

        private void textBox_outputfile_Click(object sender, EventArgs e)
        {
            // Output file path
            FolderBrowserDialog outputFileDialog = new FolderBrowserDialog
            {
                Description = "Output file",
                ShowNewFolderButton = true
            };

            DialogResult result = outputFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBox_outputFile.Text = outputPath = outputFileDialog.SelectedPath;
                Environment.SpecialFolder root = outputFileDialog.RootFolder;
                updateOutputCmd();
            }
        }
        private void button_cc_Click(object sender, EventArgs e)
        {
            // copy to clipboard
            Clipboard.SetText(outputCmd);
        }

        private void button_cmd_Click(object sender, EventArgs e)
        {
            // launch cmd.exe
            Process cmd_f2v = new Process();
            cmd_f2v.StartInfo.FileName = @"cmd.exe";
            cmd_f2v.Start();
            cmd_f2v.WaitForExit();
        }

        //-----------------------------------------------------------
        // Links
        private void linkZarbuz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Zarbuz");
        }

        private void linkPatrik_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://patrikroy.art/");
        }

        private void linkDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.co/gHnkv3AdBU");
        }

        private void linkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mvc.wiki/");
        }

    }
}

