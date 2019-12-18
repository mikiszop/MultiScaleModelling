using MultiscaleModelling.Interfaces;
using MultiscaleModelling.Models;
using MultiscaleModelling.Simulation;
using MultiscaleModelling.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiscaleModelling
{
    public partial class Form1 : Form
    {
        private ISimulation _currentSimullation;
        private bool _isStartedSimulation;
        public Form1()
        {
            InitializeComponent();
            SelectGrains.Enabled = false;
            button1.Enabled = false;
            StrucutreType.SelectedIndex = 0;
            //comboBoxBC.SelectedIndex = 0;
            comboBoxNeighbourhood.SelectedIndex = 0;
            _isStartedSimulation = false;
            
            _currentSimullation = new StandardSimulation();
            ChangeEnableGrowOptions(true);
            ChangeEnableGrowButtons(true);
            ChangeEnableSubstructure(false);



        }

        

        private Configuration GetConfiguration()
        {

            return new Configuration()
            {
                Width = (int)numericUpDownWidth.Value,
                Height = (int)numericUpDownHeight.Value,
                //BoundaryConditions = (BCEnum)c.SelectedIndex,
                Neighbourhood = (NeighbourhoodEnum)comboBoxNeighbourhood.SelectedIndex,
                StructureTypeEnume = (StructureTypeEnume)StrucutreType.SelectedIndex,
                SizeOfGB = (int)numericUpDownGBSize.Value,
                //NumberOfSubGrains = (int)subSgrains.Value,
                NumberOfGrains = (int)numericUpDownNumberOfGrain.Value,
                MooreProbability = (int)numericMooreProbability.Value,
                IsMC = checkBoxMC.Checked,
                J = (double)numericUpDownJ.Value,
                MCIterations = (int)numericUpDownMCIterations.Value,
                ConfigurationRecrystallization = new ConfigurationRecrystallization()
                {
                    Iterations = (int)numericUpDownRecIterations.Value,
                    J = (double)numericUpDownJ.Value,
                    NucleonsType = (NucleonsType)comboBoxNucleationType.SelectedIndex,
                    NumberOfStates = (int)numericUpDownRecrStates.Value,
                    OnlyGBGeneration = radioButtonGB.Checked,
                    TotalNucleons = (int)numericUpDownTotalNucleons.Value
                },
                BorderEnergy = 7,
                GrainEnergy = 2

            };
        }
        private ConfigurationInclusions GetConfigurationInclusions()
        {

            return new ConfigurationInclusions()
            {
                InclusionType = (InclusionType)comboBoxTypeOfInclusion.SelectedIndex,
                NumberOfInclusions = (int)numericAmountOfInclusions.Value,
                SizeOfInclusions = (int)numericSizeOfInclusions.Value
            };
        }

        private void StartStandatdSimulation()
        {
            ChangeEnableGrowOptions(false);
            ChangeEnableSubstructure(false);

            var config = GetConfiguration();

            _currentSimullation.Initialize(config);
            _currentSimullation.InitializeStep();


            _isStartedSimulation = true;
        }
        private void Render(Bitmap map)
        {
            if (map != null)
                pictureBox1.Image = ResizeBitmap(map, (int)numericUpDownWidth.Value, (int)numericUpDownHeight.Value);
        }

        private void RenderStep()
        {
            var map = _currentSimullation.GetBitmap();
            Render(map);
        }
        //generation of bitmap with graphics
        private Bitmap ResizeBitmap(Bitmap b, int nWidth, int nHeight)
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(b, 0, 0, nWidth, nHeight);
            }
            return result;
        }

        private void ChangeEnableGrowOptions(bool enable)
        {
            numericUpDownWidth.Enabled = enable;
            numericUpDownHeight.Enabled = enable;
            numericUpDownNumberOfGrain.Enabled = enable;
            comboBoxNeighbourhood.Enabled = enable;
            //comboBoxBC.Enabled = enable;
            //numericMooreProbability.Enabled = enable;
            //numericUpDownMCIterations.Enabled = enable;
           // numericUpDownJ.Enabled = enable;
        }
        private void ChangeEnableGrowButtons(bool enable)
        {
            buttonStart.Enabled = enable;
            buttonStop.Enabled = enable;
        }
        private void ChangeEnableSubstructure(bool enable)
        {

            SelectGrains.Enabled = enable;
            buttonGenerate.Enabled = enable;

            _grainsSelection = false;
            SelectGrains.Enabled = enable;
            //_grainsSelection = false;
            timer2.Enabled = false;
            numericUpDownGBSize.Enabled = enable;
            buttonGenerateGB.Enabled = enable;
            buttonRemoveColors.Enabled = enable;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private Simul _simulationEngine;
        private bool _visFlag = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (_grainsSelection == true)
            {
                var mouseEvent = (MouseEventArgs)e;
                double imageX = mouseEvent.X;
                double imageY = mouseEvent.Y;

                double imageWidth = pictureBox1.Width;
                double imageHeight = pictureBox1.Height;

                var map = _currentSimullation.GetBitmap();

                double mapWidth = map.Width;
                double mapHeight = map.Height;


                int x = (int)(imageX / imageWidth * mapWidth);
                int y = (int)(imageY / imageHeight * mapHeight);

                _currentSimullation.AddOrRemoveGrainsToSelectLis(x, y);
                var map1 = _currentSimullation.GetBitmapGrainsSelection(true);
                Render(map1);
               //_visFlag = !_visFlag;

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            ChangeEnableSubstructure(false);
            if (!_isStartedSimulation)
            {
                pictureBox1.Size = new System.Drawing.Size((int)numericUpDownWidth.Value, (int)numericUpDownHeight.Value);
                StartStandatdSimulation();
            }
            _currentSimullation.NextStep();
            RenderStep();
            button1.Enabled = true;
            //timer1.Enabled = true;
        }
 

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            button1.Enabled = false;
            _currentSimullation.Restart();
            RenderStep();
            _isStartedSimulation = false;
            //timer1.Enabled = false;
            ChangeEnableGrowOptions(true);
            ChangeEnableGrowButtons(false);
            ChangeEnableSubstructure(false);
            buttonStart.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _currentSimullation.NextStep();
            
            if (_currentSimullation.IsEndSimulation())
            {
                RenderStep();
                ChangeEnableGrowButtons(false);
                ChangeEnableSubstructure(true);
                timer1.Enabled = false;
            }
        }


        //private void comboBoxBC_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void comboBoxNeighbourhood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }       

        private void numericUpDownNumberOfGrain_ValueChanged(object sender, EventArgs e)
        {

        }

      private void Label20_Click(object sender, EventArgs e)
      {

      }

      private void NumericUpDownMCIterations_ValueChanged(object sender, EventArgs e)
      {

      }

      private void NumericUpDownJ_ValueChanged(object sender, EventArgs e)
      {

      }

      private void NumericMooreProbability_ValueChanged(object sender, EventArgs e)
      {

      }

      private void NumericUpDownHeight_ValueChanged(object sender, EventArgs e)
      {

      }

      private void NumericUpDownWidth_ValueChanged(object sender, EventArgs e)
      {

      }

      private void Label1_Click(object sender, EventArgs e)
      {

      }

      private void Label2_Click(object sender, EventArgs e)
      {

      }

      private void Label5_Click(object sender, EventArgs e)
      {

      }

      private void Label15_Click(object sender, EventArgs e)
      {

      }

      private void Button1_Click_1(object sender, EventArgs e)
      {
         SaveFileDialog saveFileGialog = new SaveFileDialog();
         saveFileGialog.Filter = "Structure Files (*.bmp)|*.bmp";
         saveFileGialog.Title = "Select path for file";


         if (saveFileGialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
         {
            var name = saveFileGialog.FileName;
            _currentSimullation.ExportToFile(FileTypeEnum.Bmp, name);

         }
      }

      private void Button3_Click(object sender, EventArgs e)
      {
         OpenFileDialog openFileDialog1 = new OpenFileDialog();
         openFileDialog1.Filter = "Structure Files (*.bmp, *.txt)|*.bmp; *.txt";
         openFileDialog1.Title = "Select a structure file";


         if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
         {
            var name = openFileDialog1.FileName;

            if (name.Contains(".txt"))
               _currentSimullation.ImportFromFile(FileTypeEnum.Text, name);
            else if (name.Contains(".bmp"))
               _currentSimullation.ImportFromFile(FileTypeEnum.Bmp, name);

            var config = _currentSimullation.GetConfiguration();
            numericUpDownWidth.Value = config.Width;
            numericUpDownHeight.Value = config.Height;

                _isStartedSimulation = true;
            RenderStep();

            ChangeEnableGrowOptions(false);
            ChangeEnableGrowButtons(false);
            ChangeEnableSubstructure(true);

            config = _currentSimullation.GetConfiguration();
            numericUpDownWidth.Value = config.Width;
            numericUpDownHeight.Value = config.Height;
            numericUpDownNumberOfGrain.Value = config.NumberOfGrains;
         }
      }

      private void FileToolStripMenuItem_Click(object sender, EventArgs e)
      {

      }

      private void SaveToTxt_Click(object sender, EventArgs e)
      {
         SaveFileDialog saveFileGialog = new SaveFileDialog();
         saveFileGialog.Filter = "Structure Files (*.txt)|*.txt";
         saveFileGialog.Title = "Select path for file";


         if (saveFileGialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
         {
            var name = saveFileGialog.FileName;
            _currentSimullation.ExportToFile(FileTypeEnum.Text, name);

         }
      }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool simFlag = true;
            int iter = 0;
            while (simFlag == true)
            {
                _currentSimullation.NextStep();
                iter++;
                if (_currentSimullation.IsEndSimulation()|| iter >= 400)
                {
                    RenderStep();
                    ChangeEnableGrowButtons(false);
                    ChangeEnableSubstructure(true);
                    numericUpDownNumberOfGrain.Enabled = true;
                    //timer1.Enabled = false;
                    simFlag = false;
                    button1.Enabled = false;
                }
            }
        }

 
        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericSizeOfInclusions_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericAmountOfInclusions_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxTypeOfInclusion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (_currentSimullation.IsMapEmpty())
            {
                var globalConfig = GetConfiguration();
                _currentSimullation.Initialize(globalConfig);
            }
            var config = GetConfigurationInclusions();
            _currentSimullation.AddInclusions(config);
            RenderStep();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private bool _grainsSelection = false;

        private void SelectGrains_Click(object sender, EventArgs e)
        {
            _currentSimullation.RestartSelectedList();
            _grainsSelection = true;
            timer2.Enabled = true;
        }
        //private bool _visFlag = false;
        private void timer2_Tick(object sender, EventArgs e)
        {

            if (_grainsSelection)
            {
                //var map = _currentSimullation.GetBitmapGrainsSelection(_visFlag);
                //Render(map);
                //_visFlag = !_visFlag;
            }
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            var config = GetConfiguration();
            _isStartedSimulation = true;
            _grainsSelection = false;
            timer2.Enabled = false;

            _currentSimullation.StartGenerateSubstructure(config);
            _currentSimullation.InitializeStep();

            ChangeEnableGrowButtons(true);
            numericUpDownNumberOfGrain.Enabled = true;
            RenderStep();
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void ButtonGenerateGB_Click(object sender, EventArgs e)
        {
            var config = GetConfiguration();
            //config.NumberOfGrains = (int)subSgrains.Value;
            _currentSimullation.AddBoundariesForGrains(config);
            RenderStep();
            GB.Text = _currentSimullation.GetGBPercent().ToString();
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRemoveColors_Click(object sender, EventArgs e)
        {
            _currentSimullation.RemoveGrainsColors();
            RenderStep();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonAny_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRecrystallization_Click(object sender, EventArgs e)
        {
            var config = GetConfiguration();
            _isStartedSimulation = true;
            _grainsSelection = false;
            timer2.Enabled = false;

            ChangeEnableGrowButtons(true);
            config.IsRecrystallization = true;

            _currentSimullation.Initialize(config);
            _currentSimullation.InitializeStep();

            RenderStep();
        }

        private void NumericUpDownRecrStates_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCalculateEnergy_Click(object sender, EventArgs e)
        {
            _currentSimullation.CalculateEnergy();
        }

        private void CheckBoxEnergy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnergy.Checked)
            {
                var map = _currentSimullation.GetEnergyBitmap();
                Render(map);
            }
            else
            {
                var map = _currentSimullation.GetBitmap();
                Render(map);
            }
        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void Label23_Click(object sender, EventArgs e)
        {

        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxNucleationType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
