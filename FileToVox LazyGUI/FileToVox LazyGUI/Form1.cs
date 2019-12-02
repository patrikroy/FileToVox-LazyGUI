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

// FileToVox LazyGUI v0.2
// PatrikRoy 12/2019
// DISCLAIMER: I'm no coder, prepare to facepalm.

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
        string chkHelp;
        string chkVerbose;
        string chk_schematicWay;
        string schematicIminy;
        string schematicImaxy;
        string chkExcavate;
        string scale;
        string pngHmValue;
        string chk_pngHmColor;
        string pngColorFilePathFull;
        string pngColorFilePathDisplay;
        string objGridSize;
        string objSlowValue;


        public Form1()
        {
            InitializeComponent();
        }

        // --------------------------- Functions ---------------------------
        // Update command line
        public void updateOutputCmd()
        {
            // get *Path*
            // input
            if (string.IsNullOrEmpty(inputPathFull))
            {
                // Input file is not selected, display nothing
            }
            else
            {
                // Input file has been chosen
                inputPathDisplay = " --i \"" + inputPathFull + "\""; // get input file display from user's choice
                outputFilenameNoExt = System.IO.Path.GetFileNameWithoutExtension(inputPathFull); // get output filename from input filename without extension
                
                // Does output directory has been chosen?
                if (string.IsNullOrEmpty(outputPath))
                {
                    // No, so make it the same as inputPathFull, without file extension
                    outputPath = System.IO.Path.GetDirectoryName(inputPathFull);
                    outputPathDisplay = " --o \"" + outputPath + "\\" + outputFilenameNoExt + "\"";
                }
                else
                {
                    // Yes, so keep the user's choice
                    outputPathDisplay = " --o \"" + outputPath + outputFilenameNoExt + "\"";
                }
                
            }
            // pngColorFile
            if (string.IsNullOrEmpty(pngColorFilePathFull))
            {
                // Color file is not selected, display nothing
            }
            else
            {
                // Color file has been chosen
                pngColorFilePathDisplay = " --cm \"" + pngColorFilePathFull + "\""; // get color file display from user's choice
            }

            // build outputCmd from displays
            outputCmd = f2vPathFull 
                + chkHelp + chkVerbose 
                + chk_schematicWay + schematicIminy + schematicImaxy 
                + chkExcavate 
                + scale
                + pngHmValue + chk_pngHmColor + pngColorFilePathDisplay 
                + objGridSize + objSlowValue 
                + inputPathDisplay + outputPathDisplay;
            textBox_outputCmd.Text = outputCmd;
        }


        // ---------------------------- Events --------------------------------
        // FileToVox path
        private void textBox_f2vPath_Click(object sender, EventArgs e)
        {
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

        // Input file path
        private void textBox_inputfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog inputFileDialog = new OpenFileDialog
            {
                InitialDirectory = myCompPath,
                Title = "FileToVox input file",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "png",
                Filter = "FileToVox files (*.schematic, *.png, *.asc, *.binvox, *.obj, *.qb, *.ply, *.xyz) | *.schematic; *.png; *.asc; *.binvox; *.obj; *.qb; *.ply; *.xyz",
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

        // Output file path
        private void textBox_outputfile_Click(object sender, EventArgs e)
        {
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

        // Checkbox: Help
        private void checkBox_help_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_help.Checked) { chkHelp = " --h"; } else { chkHelp = ""; }
            updateOutputCmd();
        }

        // Checkbox: Verbose
        private void checkBox_verbose_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_verbose.Checked) { chkVerbose = " --v"; } else { chkVerbose = ""; }
            updateOutputCmd();
        }

        // Schematic
        // Checkbox: Way
        private void checkBox_schematicWay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_schematicWay.Checked) { chk_schematicWay = " --w 1"; } else { chk_schematicWay = ""; }
            updateOutputCmd();
        }
        // Value: Iminy
        private void textBox_schematicIminy_TextChanged(object sender, EventArgs e)
        {
            schematicIminy = textBox_schematicIminy.Text;
            schematicIminy = " --iminy " + schematicIminy;
            if (textBox_schematicIminy.Text == "") { schematicIminy = ""; }
            updateOutputCmd();
        }
        // Value: Imaxy
        private void textBox_schematicImaxy_TextChanged(object sender, EventArgs e)
        {
            schematicImaxy = textBox_schematicImaxy.Text;
            schematicImaxy = " --imaxy " + schematicImaxy;
            if (textBox_schematicImaxy.Text == "") { schematicImaxy = ""; }
            updateOutputCmd();
        }

        // Checkbox: Excavate
        private void checkBox_excavate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_excavate.Checked) { chkExcavate = " --e"; } else { chkExcavate = ""; }
            updateOutputCmd();
        }

        // Value: Scale
        private void textBox_scale_TextChanged(object sender, EventArgs e)
        {
            scale = textBox_scale.Text;
            scale = " --s " + scale;
            if (textBox_scale.Text == "") { scale = ""; }
            updateOutputCmd();
        }

        // PNG
        // heightmap value
        private void textBox_pngHmValue_TextChanged(object sender, EventArgs e)
        {
            pngHmValue = textBox_pngHmValue.Text;
            pngHmValue = " --hm " + pngHmValue;
            if (textBox_pngHmValue.Text == "" ) { pngHmValue = ""; }
            updateOutputCmd();
        }
        // heightmap enable color
        private void checkBox_pngHmColor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pngHmColor.Checked) { chk_pngHmColor = " --c"; } else { chk_pngHmColor = ""; }
            updateOutputCmd();
        }
        // Color file
        private void textBox_pngColorFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog pngColorFilePathDialog = new OpenFileDialog
            {
                InitialDirectory = defaultGUIPath,
                Title = "Color file location",

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "PNG image (*.png) | *.png",
                FilterIndex = 1,
                RestoreDirectory = true,

                ShowReadOnly = false
            };

            if (pngColorFilePathDialog.ShowDialog() == DialogResult.OK || pngColorFilePathDialog.ShowDialog() == DialogResult.Yes)
            {
                textBox_pngColorFile.Text = pngColorFilePathFull = pngColorFilePathDialog.FileName;
                updateOutputCmd();
            }
        }

        // OBJ
        // Grid size
        private void textBox_objGridSize_TextChanged(object sender, EventArgs e)
        {
            objGridSize = textBox_objGridSize.Text;
            objGridSize = " --gs " + objGridSize;
            if (textBox_objGridSize.Text == "") { objGridSize = ""; }
            updateOutputCmd();
        }
        // Slow value
        private void textBox_objSlowValue_TextChanged(object sender, EventArgs e)
        {
            objSlowValue = textBox_objSlowValue.Text;
            objSlowValue = " --slow=" + objSlowValue;
            if (textBox_objSlowValue.Text == "") { objSlowValue = ""; }
            updateOutputCmd();
        }


        // --------------------------- Buttons --------------------------------
        // Copy to clipboard
        private void button_cc_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputCmd);
        }

        // Launch cmd.exe
        private void button_cmd_Click(object sender, EventArgs e)
        {
            Process cmd_f2v = new Process();
            cmd_f2v.StartInfo.FileName = @"cmd.exe";
            cmd_f2v.Start();
            cmd_f2v.WaitForExit();
        }


        // ---------------------------- Links ----------------------------------
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

        private void textBox_f2vPath_TextChanged(object sender, EventArgs e)
        {

        }

    }
}