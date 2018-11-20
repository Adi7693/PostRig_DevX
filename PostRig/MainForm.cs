using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress;
using DevExpress.XtraCharts;

namespace PostRig
{
    public partial class PostRigForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Document Doc { get; set; }

        private bool ResponseToICNeedsToPlot = true;
        private bool HarmonicInputNeedsToPlot = true;
        private bool ResponseToHarmonicInputNeedsToPlot = true;
        private bool TotalResponseNeedsToPlot = true;


        public PostRigForm()
        {
            InitializeComponent();
            UpdateUIFromDocument();
            this.PropertiesTreeList.ExpandAll();
            this.SimSetupTreeList.ExpandAll();
        }

        public void UpdateUIFromDocument()
        {
            if (Doc != null)
            {
                ValuesTreeListColumn.TreeList.Nodes[0].SetValue(ValuesTreeListColumn, Doc.Input.VehicleMass);
                ValuesTreeListColumn.TreeList.Nodes[1].SetValue(ValuesTreeListColumn, Doc.Input.SpringStiffness);
                ValuesTreeListColumn.TreeList.Nodes[2].SetValue(ValuesTreeListColumn, Doc.Input.DampingCoefficient);

                SimValuesTreeListColumn.TreeList.Nodes[0].Nodes[0].SetValue(SimValuesTreeListColumn, Doc.Input.StartTime);
                SimValuesTreeListColumn.TreeList.Nodes[0].Nodes[1].SetValue(SimValuesTreeListColumn, Doc.Input.TimeStep);
                SimValuesTreeListColumn.TreeList.Nodes[0].Nodes[2].SetValue(SimValuesTreeListColumn, Doc.Input.EndTime);

                SimValuesTreeListColumn.TreeList.Nodes[1].Nodes[0].SetValue(SimValuesTreeListColumn, Doc.Input.InitialDisplacement);
                SimValuesTreeListColumn.TreeList.Nodes[1].Nodes[1].SetValue(SimValuesTreeListColumn, Doc.Input.InitialVelocity);

                SimValuesTreeListColumn.TreeList.Nodes[2].Nodes[0].SetValue(SimValuesTreeListColumn, Doc.Input.ExcitationFrequencyHz);
                SimValuesTreeListColumn.TreeList.Nodes[2].Nodes[1].SetValue(SimValuesTreeListColumn, Doc.Input.InputForce);
            }
        }


        public void UpdateDocumentFromUI()
        {
            if (Doc != null)
            {
                string strval = ValuesTreeListColumn.TreeList.Nodes[0].GetValue(ValuesTreeListColumn).ToString();

                double dblval = -1.0;

                bool Error = false;

                if (double.TryParse(strval, out dblval))
                {
                    Doc.Input.VehicleMass = dblval;
                }
                else
                {
                    Error = true;
                }

                strval = ValuesTreeListColumn.TreeList.Nodes[1].GetValue(ValuesTreeListColumn).ToString();

                if (double.TryParse(strval, out dblval))
                {
                    Doc.Input.SpringStiffness = dblval;
                }
                else
                {
                    Error = true;
                }

                strval = ValuesTreeListColumn.TreeList.Nodes[2].GetValue(ValuesTreeListColumn).ToString();

                if (double.TryParse(strval, out dblval))
                {
                    Doc.Input.DampingCoefficient = dblval;
                }
                else
                {
                    Error = true;
                }

                strval = SimValuesTreeListColumn.TreeList.Nodes[0].Nodes[0].GetValue(SimValuesTreeListColumn).ToString();

                if (double.TryParse(strval, out dblval))
                {
                    Doc.Input.StartTime = dblval;
                }
                else
                {
                    Error = true;
                }

                strval = SimValuesTreeListColumn.TreeList.Nodes[0].Nodes[1].GetValue(SimValuesTreeListColumn).ToString();

                if (double.TryParse(strval, out dblval))
                {
                    Doc.Input.TimeStep = dblval;
                }
                else
                {
                    Error = true;
                }

                strval = SimValuesTreeListColumn.TreeList.Nodes[0].Nodes[2].GetValue(SimValuesTreeListColumn).ToString();

                if (double.TryParse(strval, out dblval))
                {
                    Doc.Input.EndTime = dblval;
                }
                else
                {
                    Error = true;
                }

                strval = SimValuesTreeListColumn.TreeList.Nodes[1].Nodes[0].GetValue(SimValuesTreeListColumn).ToString();

                if (double.TryParse(strval, out dblval))
                {
                    Doc.Input.InitialDisplacement = dblval;
                }
                else
                {
                    Error = true;
                }

                strval = SimValuesTreeListColumn.TreeList.Nodes[1].Nodes[1].GetValue(SimValuesTreeListColumn).ToString();

                if (double.TryParse(strval, out dblval))
                {
                    Doc.Input.InitialVelocity = dblval;
                }
                else
                {
                    Error = true;
                }

                strval = SimValuesTreeListColumn.TreeList.Nodes[2].Nodes[0].GetValue(SimValuesTreeListColumn).ToString();

                if (double.TryParse(strval, out dblval))
                {
                    Doc.Input.ExcitationFrequencyHz = dblval;
                }
                else
                {
                    Error = true;
                }

                strval = SimValuesTreeListColumn.TreeList.Nodes[2].Nodes[1].GetValue(SimValuesTreeListColumn).ToString();

                if (double.TryParse(strval, out dblval))
                {
                    Doc.Input.InputForce = dblval;
                }
                else
                {
                    Error = true;
                }

                if (Error)
                {
                    MessageBox.Show("One of the input values was incorrect. Resetting to previous value.");

                    UpdateUIFromDocument();
                }
            }
        }

        private void NewMenuBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Doc = new Document();
            UpdateUIFromDocument();
            this.DesignRibbonPage.Visible = true;
            this.SimulationSetupRibbonPage.Visible = true;
            this.ResultsRibbonPage.Visible = true;
            this.DesignPropertiesPanel.Visible = true;
        }

        private void OpenMenuBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = "C:\\";

            dlg.Filter = "PostRig Files (*.postrig)|*.postrig";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Doc = new Document(dlg.FileName);
            }

            if (Doc != null)
            {
                UpdateUIFromDocument();

                this.DesignRibbonPage.Visible = true;
                this.SimulationSetupRibbonPage.Visible = true;
                this.ResultsRibbonPage.Visible = true;
                this.DesignPropertiesPanel.Visible = true;
            }
        }

        private void SaveMenuBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Doc != null && !string.IsNullOrWhiteSpace(Doc.FileName))
            {
                Doc.Save();
            }
            else if (Doc != null)
            {
                SaveAsMenuBarButton_ItemClick(sender, e);
            }
        }

        private void SaveAsMenuBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Doc != null)
            {
                SaveFileDialog dlg = new SaveFileDialog();

                dlg.InitialDirectory = "C:\\";

                dlg.Filter = "PostRig Files|*.postrig";

                dlg.AddExtension = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Doc.SaveAs(dlg.FileName);
                }
            }
        }

        private void ExitMenuBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want To Close The Program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RoadCarBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Doc.Input.VehicleMass = 1600; // kg
            Doc.Input.SpringStiffness = 100000; // N/m
            Doc.Input.DampingCoefficient = 6000; // N/(m/s)
            UpdateUIFromDocument();
        }

        private void TouringCarBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Doc.Input.VehicleMass = 1000; // kg
            Doc.Input.SpringStiffness = 120000; // N/m
            Doc.Input.DampingCoefficient = 8000; // N/(m/s)
            UpdateUIFromDocument();
        }

        private void SingleSeaterBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Doc.Input.VehicleMass = 700; // kg
            Doc.Input.SpringStiffness = 150000; // N/m
            Doc.Input.DampingCoefficient = 15000; // N/(m/s)
            UpdateUIFromDocument();
        }

        private void RunBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateDocumentFromUI();
            Doc.Input.Calculate();
            HarmonicInputNeedsToPlot = true;
            MessageBox.Show("Run Complete", "Simulation", MessageBoxButtons.OK);
        }

        private void InitialConditionBarCheckItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitialConditionBarCheckItem.Checked = true;
            HarmonicIPBarCheckItem.Checked = false;
            CombinedIPBarCheckItem.Checked = false;
            SimSetupPanel.Visible = true;
            //SimSetupPanel.BringToFront();

            if (InitialConditionBarCheckItem.Checked)
            {
                SimValuesTreeListColumn.TreeList.Nodes[2].Collapse();
                SimValuesTreeListColumn.TreeList.Nodes[2].Visible = false;
                SimValuesTreeListColumn.TreeList.Nodes[1].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[1].Visible = true;
                InputSignalPlotSimSetupGroup.Visible = false;
                ResponseToICBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                ResponseToHarmonicBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                CombinedResponseBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                ResponseToICNeedsToPlot = true;
            }
        }

        private void HarmonicIPBarCheckItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitialConditionBarCheckItem.Checked = false;
            HarmonicIPBarCheckItem.Checked = true;
            CombinedIPBarCheckItem.Checked = false;
            SimSetupPanel.Visible = true;

            if (HarmonicIPBarCheckItem.Checked)
            {
                SimValuesTreeListColumn.TreeList.Nodes[1].Collapse();
                SimValuesTreeListColumn.TreeList.Nodes[1].Visible = false;
                SimValuesTreeListColumn.TreeList.Nodes[2].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[2].Visible = true;
                InputSignalPlotSimSetupGroup.Visible = true;
                ResponseToICBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                ResponseToHarmonicBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                CombinedResponseBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                HarmonicInputNeedsToPlot = true;
            }
        }

        private void CombinedIPBarCheckItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitialConditionBarCheckItem.Checked = true;
            HarmonicIPBarCheckItem.Checked = true;
            CombinedIPBarCheckItem.Checked = true;
            SimSetupPanel.Visible = true;

            if (CombinedIPBarCheckItem.Checked)
            {
                SimValuesTreeListColumn.TreeList.Nodes[1].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[1].Visible = true;
                SimValuesTreeListColumn.TreeList.Nodes[2].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[2].Visible = true;
                InputSignalPlotSimSetupGroup.Visible = true;
                ResponseToICBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                ResponseToHarmonicBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                CombinedResponseBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                TotalResponseNeedsToPlot = true;
            }
        }

        private void ShowDesignPanelBarButtonItem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DesignPropertiesPanel.Visible = true;
        }

        private void HideDesignPanelBarButtonItem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DesignPropertiesPanel.Visible = false;
        }

        private void ShowSimSetupPanelBarButtonItem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SimSetupPanel.Visible = true;
        }

        private void HideSimSetupBarButtonItem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SimSetupPanel.Visible = false;
        }

        private void ShowGraphPanelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GraphPanel.Visible = true;
        }

        private void HideGraphPanelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GraphPanel.Visible = false;
        }

        private void HarmonicInputPlotBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SimSetupPanel.Visible = false;
            GraphPanel.Visible = true;
            HarmonicInputChartControl.Visible = true;
            ResponseToICChartControl.Visible = false;
            ResponseToHarmonicIPChartControl.Visible = false;
            TotalResponseChartControl.Visible = false;

            if (HarmonicInputNeedsToPlot)
            {
                HarmonicInputChartControl.Dock = DockStyle.Fill;

                HarmonicInputChartControl.Series.Clear();

                Series HarmonicIP = new Series("Force", ViewType.Spline);

                for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                {
                    HarmonicIP.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.InputForceOscillations[i]));
                }

                HarmonicInputChartControl.Series.Add(HarmonicIP);

                HarmonicInputChartControl.Update();

                HarmonicInputNeedsToPlot = false;
            }
        }

        private void ResponseToICBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SimSetupPanel.Visible = false;
            GraphPanel.Visible = true;
            HarmonicInputChartControl.Visible = false;
            ResponseToICChartControl.Visible = true;
            ResponseToHarmonicIPChartControl.Visible = false;
            TotalResponseChartControl.Visible = false;

            if (ResponseToICNeedsToPlot)
            {
                ResponseToICChartControl.Dock = DockStyle.Fill;

                ResponseToICChartControl.Series.Clear();

                Series ICResponse = new Series("Displacement", ViewType.Spline);

                for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                {
                    ICResponse.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.ResponseToInitialConditions[i]));
                }

                ResponseToICChartControl.Series.Add(ICResponse);

                ResponseToICChartControl.Update();

                ResponseToICNeedsToPlot = false;
            }
        }

        private void ResponseToHarmonicBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SimSetupPanel.Visible = false;
            GraphPanel.Visible = true;
            HarmonicInputChartControl.Visible = false;
            ResponseToICChartControl.Visible = false;
            ResponseToHarmonicIPChartControl.Visible = true;
            TotalResponseChartControl.Visible = false;

            if (ResponseToHarmonicInputNeedsToPlot)
            {
                ResponseToHarmonicIPChartControl.Dock = DockStyle.Fill;

                ResponseToHarmonicIPChartControl.Series.Clear();

                Series HarmonicIPResponse = new Series("Displacement", ViewType.Spline);

                for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                {
                    HarmonicIPResponse.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.ResponseToHarmonicInput[i]));
                }

                ResponseToHarmonicIPChartControl.Series.Add(HarmonicIPResponse);

                ResponseToHarmonicIPChartControl.Update();

                ResponseToHarmonicInputNeedsToPlot = false;
            }
 
        }
        private void CombinedResponseBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SimSetupPanel.Visible = false;
            GraphPanel.Visible = true;
            HarmonicInputChartControl.Visible = false;
            ResponseToICChartControl.Visible = false;
            ResponseToHarmonicIPChartControl.Visible = false;
            TotalResponseChartControl.Visible = true;

            if (TotalResponseNeedsToPlot)
            {
                TotalResponseChartControl.Dock = DockStyle.Fill;

                TotalResponseChartControl.Series.Clear();

                Series TotalResponse = new Series("Displacement", ViewType.Spline);

                for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                {
                    TotalResponse.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.TotalResponse[i]));
                }

                TotalResponseChartControl.Series.Add(TotalResponse);
                TotalResponseNeedsToPlot = false;
            }
        }
    }
}
