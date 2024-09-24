using System;
using System.Windows.Forms;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace ClassLibrary3
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCalculateAreaColumn_Click(object sender, EventArgs e)
        {
                if (double.TryParse(textBoxColumnHeight.Text, out double columnHeight))
                {
                    double columnVolume = CalculateVolumeOfColumns(txtLayerColumnName.Text, columnHeight);
                    textBoxColumnVolume.Text = $"{columnVolume:F2} m³";
                }
                else
                {
                    MessageBox.Show("Please enter a valid height for the column.");
                }

        }

        private void btnCalculateAreaBeam_Click(object sender, EventArgs e)
        {
            double beamHeight = double.Parse(textBoxBeamHeight.Text); // Correct textbox for beam height
            double beamVolume = CalculateVolumeOfBeams(txtLayerBeamName.Text, beamHeight);
            textBoxBeamVolume.Text = $"{beamVolume:F2} m³";
        }
        private void btnCalculateAreaSlab_Click(object sender, EventArgs e)
        {

            double slabHeight = double.Parse(textBoxSlabHeight.Text); // Textbox for slab height
            double slabVolume = CalculateVolumeOfSlabs(txtLayerSlabName.Text, slabHeight);
            textBoxSlabVolume.Text = $"{slabVolume:F2} m³";


        }
        private void btnCalculateAreaRCfooting_Click(object sender, EventArgs e)
        {
            double RCfootingHeight = double.Parse(textBoxRCFootingHeight.Text); // Correct textbox for RC footing height
            double RCfootingVolume = CalculateVolumeOfRCFootings(txtLayerRCFootingName.Text, RCfootingHeight);
            textBoxRCFootingVolume.Text = $"{RCfootingVolume:F2} m³";
        }

        private void btnCalculateAreaPCfooting_Click(object sender, EventArgs e)
        {
            double PCfootingHeight = double.Parse(textBoxPCFootingHeight.Text); // Textbox for footing height
            double PCfootingVolume = CalculateVolumeOfPCFootings(txtLayerPCFootingName.Text, PCfootingHeight);
            textBoxPCFootingVolume.Text = $"{PCfootingVolume:F2} m³";

        }
        private double CalculateVolumeOfColumns(string layerName, double height)
        {
            return CalculateVolume(layerName, height);
        }

        private double CalculateVolumeOfBeams(string layerName, double height)
        {
            return CalculateVolume(layerName, height);
        }

        private double CalculateVolumeOfSlabs(string layerName, double height)
        {
            return CalculateVolume(layerName, height);
        }

        private double CalculateVolumeOfRCFootings(string layerName, double height)
        {
            return CalculateVolume(layerName, height);
        }

        private double CalculateVolumeOfPCFootings(string layerName, double height)
        {
            return CalculateVolume(layerName, height);
        }

        private double CalculateVolume(string layerName, double height)
        {
            double volumeSum = 0.0;
            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                BlockTable blockTable = (BlockTable)trans.GetObject(db.BlockTableId, OpenMode.ForRead);
                BlockTableRecord modelSpace = (BlockTableRecord)trans.GetObject(blockTable[BlockTableRecord.ModelSpace], OpenMode.ForRead);

                foreach (ObjectId objectId in modelSpace)
                {
                    Entity entity = (Entity)trans.GetObject(objectId, OpenMode.ForRead);
                    if (entity.Layer == layerName && entity is Polyline polyline)
                    {
                        volumeSum += polyline.Area * height; // Accumulate the volume
                                                             
                        System.Diagnostics.Debug.WriteLine($"Layer: {layerName}, Area: {polyline.Area}, Volume: {polyline.Area * height}");
                    }
                }
                trans.Commit();
            }

            return volumeSum;
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void groupBox7_Enter(object sender, EventArgs e) { }

        private void groupBox9_Enter(object sender, EventArgs e) { }

        private void groupBox6_Enter(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
