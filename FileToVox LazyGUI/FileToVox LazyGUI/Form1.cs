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

// FileToVox LazyGUI v1.3.1
// PatrikRoy 05/2020 (https://github.com/patrikroy)
// DISCLAIMER: I'm no coder, prepare to facepalm.

namespace FileToVox_LazyGUI
{
    public partial class Form1 : Form
    {

        // Global variables
        string defaultGUIPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        string myCompPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
        string f2vChos, inputChos, outputChos, paletteFilePathChos, pngColorFilePathChos; // 0=no, 1=yes
        int countBackslash;
        string outputCmd, f2vPath, f2vPathDisp, inputPath, inputPathDisp, outputPath, outputFilenameNoExt, outputPathDisp;
        string paletteFilePath, paletteFilePathDisp;
        string chk_Help, chk_Verbose, chk_Excavate, chk_Slices, scale, colorlimit;
        string schematicIminy, schematicImaxy, chk_schematicWay;
        string pngHmValue, chk_pngHmColor, pngColorFilePath, pngColorFilePathDisp;
        string objGridSize, objSlowValue;
        string chk_cpFlood, chk_cpFixHoles, chk_cpFixLonely;


        public Form1()
        {
            InitializeComponent();
        }

        // --------------------------- Functions ---------------------------
        // Update command line
        public void updateOutputCmd()
        {
            // Get *Path*
            // FileToVox
            if (f2vChos == "1")
            {
                f2vPathDisp = "\"" + f2vPath + "\""; // get FileToVox display from user's choice
            }

            // Input
            if (inputChos == "1")
            {
                // Input file has been chosen
                inputPathDisp = " --i \"" + inputPath + "\""; // create input file display from user's choice
                outputFilenameNoExt = System.IO.Path.GetFileNameWithoutExtension(inputPath); // create output filename from input filename without extension

                // Does output directory has been chosen?
                if (outputChos != "1")
                {
                    // No
                    outputPath = System.IO.Path.GetDirectoryName(inputPath);  // make it the same as inputPathFull, without file extension
                    if (countBackslash < 2) // if input file in root, adapt output
                    {
                        outputPathDisp = " --o \"" + outputPath + outputFilenameNoExt + "\"";
                    }
                    else
                    {
                        outputPathDisp = " --o \"" + outputPath + "\\" + outputFilenameNoExt + "\"";
                    }
                    outputChos = "0";
                }
                if (outputChos == "1")
                {
                    // Yes, keep the user's choice
                    if (outputPath.EndsWith("\\"))
                    {
                        outputPathDisp = " --o \"" + outputPath + outputFilenameNoExt + "\""; // if chosen path ends with a slash, add the original filename without extension
                    }
                    else
                    {
                        outputPathDisp = " --o \"" + outputPath + "\""; // if user has chosen a filename, use it
                    }
                }

            }

            // paletteFilePath
            if (string.IsNullOrEmpty(paletteFilePath))
            {
                // Palette file is not selected, display nothing
            }
            else
            {
                // Palette file has been chosen
                paletteFilePathDisp = " --palette \"" + paletteFilePath + "\""; // create palette file display from user's choice
            }

            // pngColorFilePath
            if (string.IsNullOrEmpty(pngColorFilePath))
            {
                // Color file is not selected, display nothing
            }
            else
            {
                // Color file has been chosen
                pngColorFilePathDisp = " --cm \"" + pngColorFilePath + "\""; // get color file display from user's choice
            }

            // build outputCmd from all that collected stuff, and wrap it in quotation marks (mandatory for launching an executable as a cmd.exe argument)
            textBox_outputCmd.Text = outputCmd = "\"" + f2vPathDisp
                + paletteFilePathDisp 
                + chk_Help + chk_Verbose + chk_Excavate + chk_Slices 
                + chk_schematicWay + schematicIminy + schematicImaxy 
                + scale + colorlimit
                + pngHmValue + chk_pngHmColor + pngColorFilePathDisp 
                + objGridSize + objSlowValue
                + chk_cpFlood + chk_cpFixHoles + chk_cpFixLonely 
                + inputPathDisp + outputPathDisp + "\"";

            if (textBox_outputCmd.Text.Length <= 2) { outputCmd = textBox_outputCmd.Text = ""; } // no path left in outputCmd? clear it
        }


        // ---------------------------- Checkboxes --------------------------------
        // Help
        private void checkBox_help_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_help.Checked) { chk_Help = " --h"; } else { chk_Help = ""; }
            updateOutputCmd();
        }

        // Verbose
        private void checkBox_verbose_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_verbose.Checked) { chk_Verbose = " --v"; } else { chk_Verbose = ""; }
            updateOutputCmd();
        }

        // Excavate
        private void checkBox_excavate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_excavate.Checked) { chk_Excavate = " --e"; } else { chk_Excavate = ""; }
            updateOutputCmd();
        }

        // Slices
        private void checkBox_slices_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_slices.Checked) { chk_Slices = " --slices"; } else { chk_Slices = ""; }
            updateOutputCmd();
        }

        // Schematic
        // Way (deprecated since FileToVox v1.8.4)
        private void checkBox_schematicWay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_schematicWay.Checked) { chk_schematicWay = " --w 1"; } else { chk_schematicWay = ""; }
            updateOutputCmd();
        }
        

        // PNG
        // enable color
        private void checkBox_pngHmColor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pngHmColor.Checked) { chk_pngHmColor = " --c"; } else { chk_pngHmColor = ""; }
            updateOutputCmd();
        }

        // Cloud point files
        // flood
        private void checkBox_cpFlood_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cpFlood.Checked) { chk_cpFlood = " --flood"; } else { chk_cpFlood = ""; }
            updateOutputCmd();
        }
        // fix holes
        private void checkBox_cpFixHoles_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cpFixHoles.Checked) { chk_cpFixHoles = " --fix-holes"; } else { chk_cpFixHoles = ""; }
            updateOutputCmd();
        }
        // fix lonely
        private void checkBox_cpFixLonely_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cpFixLonely.Checked) { chk_cpFixLonely = " --fix-lonely"; } else { chk_cpFixLonely = ""; }
            updateOutputCmd();
        }


        // ---------------------------- Values --------------------------------

        private void textBox_f2vPath_TextChanged(object sender, EventArgs e)
        {
            f2vChos = "1";
            f2vPath = textBox_f2vPath.Text;
            if (textBox_f2vPath.Text.Length <= 0)
            {
                f2vChos = "0";
                f2vPath = f2vPathDisp = "";
            }
            updateOutputCmd();
        }

        private void textBox_inputFile_TextChanged(object sender, EventArgs e)
        {
            inputChos = "1"; // input Path has been chosen
            inputPath = textBox_inputFile.Text;
            if (textBox_inputFile.Text.Length <= 0)
            {
                inputPath = inputPathDisp = "";
                inputChos = "0";
            }
            countBackslash = inputPath.Count(x => x == '\\'); // count input path backslashes
            // inputBackslash = countBackslash.ToString(); // extract a string for debug
            updateOutputCmd();
        }

        private void textBox_outputFile_TextChanged(object sender, EventArgs e)
        {
            outputChos = "1";
            outputPath = textBox_outputFile.Text;
            if (textBox_outputFile.Text.Length <= 0)
            {
                outputPath = outputPathDisp = "";
                outputChos = "0";
            }
            updateOutputCmd();
        }

        //Palette File
        private void textBox_paletteFilePath_TextChanged(object sender, EventArgs e)
        {
            paletteFilePathChos = "1";
            paletteFilePath = textBox_paletteFilePath.Text;
            if (textBox_paletteFilePath.Text.Length <= 0)
            {
                paletteFilePath = paletteFilePathDisp = "";
                paletteFilePathChos = "0";
            }
            updateOutputCmd();
        }

        // Scale
        private void textBox_scale_TextChanged(object sender, EventArgs e)
        {
            scale = textBox_scale.Text;
            scale = " --sc " + scale;
            if (textBox_scale.Text == "") { scale = ""; }
            updateOutputCmd();
        }

        // Color limit
        private void textBox_colorlimit_TextChanged(object sender, EventArgs e)
        {
            colorlimit = textBox_colorlimit.Text;
            colorlimit = " --cl " + colorlimit;
            if (textBox_colorlimit.Text == "") { colorlimit = ""; }
            updateOutputCmd();
        }

        // Schematic
        // Iminy
        private void textBox_schematicIminy_TextChanged(object sender, EventArgs e)
        {
            schematicIminy = textBox_schematicIminy.Text;
            schematicIminy = " --iminy " + schematicIminy;
            if (textBox_schematicIminy.Text == "") { schematicIminy = ""; }
            updateOutputCmd();
        }
        // Imaxy
        private void textBox_schematicImaxy_TextChanged(object sender, EventArgs e)
        {
            schematicImaxy = textBox_schematicImaxy.Text;
            schematicImaxy = " --imaxy " + schematicImaxy;
            if (textBox_schematicImaxy.Text == "") { schematicImaxy = ""; }
            updateOutputCmd();
        }


        // PNG
        // heightmap
        private void textBox_pngHmValue_TextChanged(object sender, EventArgs e)
        {
            pngHmValue = textBox_pngHmValue.Text;
            pngHmValue = " --hm " + pngHmValue;
            if (textBox_pngHmValue.Text == "" ) { pngHmValue = ""; }
            updateOutputCmd();
        }
        //Color from File
        private void textBox_pngColorFilePath_TextChanged(object sender, EventArgs e)
        {
            pngColorFilePathChos = "1";
            pngColorFilePath = textBox_pngColorFilePath.Text;
            if (textBox_pngColorFilePath.Text.Length <= 0)
            {
                pngColorFilePath = pngColorFilePathDisp = "";
                pngColorFilePathChos = "0";
            }
            updateOutputCmd();
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
        // FileToVox path
        private void button_f2vPath_Click(object sender, EventArgs e)
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


            if (f2vPathDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_f2vPath.Text = f2vPath = f2vPathDialog.FileName;
                updateOutputCmd();
            }
        }

        // Input file path
        private void button_inputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog inputFileDialog = new OpenFileDialog
            {
                InitialDirectory = myCompPath,
                Title = "FileToVox input file",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "png",
                Filter = "FileToVox files (*.schematic, *.png, *.asc, *.binvox, *.obj, *.qb, *.ply, *.xyz, *.tif) | *.schematic; *.png; *.asc; *.binvox; *.obj; *.qb; *.ply; *.xyz; *.tif",
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (inputFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_inputFile.Text = inputPath = inputFileDialog.FileName;
                updateOutputCmd();
            }
        }

        // Output file path
        private void button_outputFile_Click(object sender, EventArgs e)
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
                outputChos = "1";
                updateOutputCmd();
            }
        }

        // Palette file
        private void button_paletteFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog paletteFilePathDialog = new OpenFileDialog
            {
                InitialDirectory = defaultGUIPath,
                Title = "Palette file location",

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "PNG image (*.png) | *.png",
                FilterIndex = 1,
                RestoreDirectory = true,
                ShowReadOnly = false
            };

            if (paletteFilePathDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_paletteFilePath.Text = paletteFilePath = paletteFilePathDialog.FileName;
                updateOutputCmd();
            }
        }

        // PNG Color file
        private void button_pngColorFilePath_Click(object sender, EventArgs e)
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

            if (pngColorFilePathDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_pngColorFilePath.Text = pngColorFilePath = pngColorFilePathDialog.FileName;
                updateOutputCmd();
            }
        }

        // Convert
        private void button_convert_Click(object sender, EventArgs e)
        {
            Process convert = new Process();
            convert.StartInfo.FileName = "cmd.exe";
            convert.StartInfo.Arguments = "/k " + outputCmd;
            convert.Start();
            convert.WaitForExit();
        }


        // ---------------------------- Links ----------------------------------
        private void linkZarbuz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Zarbuz");
        }

        private void linkPatrik_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/patrikroy");
        }

        private void linkDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.co/gHnkv3AdBU");
        }

        private void linkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://magicavoxel.fandom.com");
        }

    }
}