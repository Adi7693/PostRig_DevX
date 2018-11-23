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
        private bool ResponseToHarmonicInputNeedsToPlot = true;
        private bool TotalResponseNeedsToPlot = true;
        private bool SpringForceNeedsToPlot = true;
        private bool DamperForceNeedsToPlot = true;
        private bool BodyForceNeedsToPlot = true;
        private bool BodyAccelnNeedsToPlot = true;

        public PostRigForm()
        {
            InitializeComponent();

            UpdateUIFromDocument();

            PropertiesTreeList.ExpandAll();
            SimSetupTreeList.ExpandAll();


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

        public void UpdateResultsFromDocument()
        {
            if (Doc != null)
            {
                SysCharValuesTreeListColumn.TreeList.Nodes[0].SetValue(SysCharValuesTreeListColumn, Doc.Input.NaturalFrequencyHz);
                SysCharValuesTreeListColumn.TreeList.Nodes[1].SetValue(SysCharValuesTreeListColumn, Doc.Input.CriticalDamping);
                SysCharValuesTreeListColumn.TreeList.Nodes[2].SetValue(SysCharValuesTreeListColumn, Doc.Input.DampingRatio);
                SysCharValuesTreeListColumn.TreeList.Nodes[3].SetValue(SysCharValuesTreeListColumn, Doc.Input.FrequencyRatio);
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

            DesignRibbonPage.Visible = true;
            SimulationSetupRibbonPage.Visible = true;
            ResultsRibbonPage.Visible = true;
            DesignPropertiesPanel.Visible = true;

            ShowHideResultsPageGroup.Visible = false;

            ResponsePlotsResultsGroup.Visible = false;
            ForcePlotResultGroup.Visible = false;
            AccelerationResultsGroup.Visible = false;

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

                DesignRibbonPage.Visible = true;
                SimulationSetupRibbonPage.Visible = true;
                ResultsRibbonPage.Visible = true;
                DesignPropertiesPanel.Visible = true;
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
            Doc.Input.VehicleMass = 400; // kg
            Doc.Input.SpringStiffness = 80000; // N/m
            Doc.Input.DampingCoefficient = 4000; // N/(m/s)

            PropertiesTreeList.Visible = true;

            UpdateUIFromDocument();

            if (InitialConditionBarCheckItem.Checked)
            {
                SimValuesTreeListColumn.TreeList.Nodes[2].Collapse();
                SimValuesTreeListColumn.TreeList.Nodes[2].Visible = false;

                SimValuesTreeListColumn.TreeList.Nodes[1].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[1].Visible = true;

                SysCharValuesTreeListColumn.TreeList.Nodes[3].Visible = false;
            }

            if (HarmonicIPBarCheckItem.Checked)
            {
                SimValuesTreeListColumn.TreeList.Nodes[1].Collapse();
                SimValuesTreeListColumn.TreeList.Nodes[1].Visible = false;

                SimValuesTreeListColumn.TreeList.Nodes[2].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[2].Visible = true;

                SysCharValuesTreeListColumn.TreeList.Nodes[3].Visible = true;
            }

            if (CombinedIPBarCheckItem.Checked)
            {
                SimValuesTreeListColumn.TreeList.Nodes[1].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[1].Visible = true;

                SimValuesTreeListColumn.TreeList.Nodes[2].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[2].Visible = true;

                SysCharValuesTreeListColumn.TreeList.Nodes[3].Visible = true;
            }

        }

        private void TouringCarBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Doc.Input.VehicleMass = 250; // kg
            Doc.Input.SpringStiffness = 120000; // N/m
            Doc.Input.DampingCoefficient = 8000; // N/(m/s)

            PropertiesTreeList.Visible = true;

            UpdateUIFromDocument();

            if (InitialConditionBarCheckItem.Checked)
            {
                SimValuesTreeListColumn.TreeList.Nodes[2].Collapse();
                SimValuesTreeListColumn.TreeList.Nodes[2].Visible = false;

                SimValuesTreeListColumn.TreeList.Nodes[1].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[1].Visible = true;

                SysCharValuesTreeListColumn.TreeList.Nodes[3].Visible = false;
            }

            if (HarmonicIPBarCheckItem.Checked)
            {
                SimValuesTreeListColumn.TreeList.Nodes[1].Collapse();
                SimValuesTreeListColumn.TreeList.Nodes[1].Visible = false;

                SimValuesTreeListColumn.TreeList.Nodes[2].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[2].Visible = true;

                SysCharValuesTreeListColumn.TreeList.Nodes[3].Visible = true;
            }

            if (CombinedIPBarCheckItem.Checked)
            {
                SimValuesTreeListColumn.TreeList.Nodes[1].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[1].Visible = true;

                SimValuesTreeListColumn.TreeList.Nodes[2].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[2].Visible = true;

                SysCharValuesTreeListColumn.TreeList.Nodes[3].Visible = true;
            }
        }

        private void SingleSeaterBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Doc.Input.VehicleMass = 175; // kg
            Doc.Input.SpringStiffness = 150000; // N/m
            Doc.Input.DampingCoefficient = 8500; // N/(m/s)

            PropertiesTreeList.Visible = true;

            UpdateUIFromDocument();


            if (InitialConditionBarCheckItem.Checked)
            {
                SimValuesTreeListColumn.TreeList.Nodes[2].Collapse();
                SimValuesTreeListColumn.TreeList.Nodes[2].Visible = false;

                SimValuesTreeListColumn.TreeList.Nodes[1].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[1].Visible = true;

                SysCharValuesTreeListColumn.TreeList.Nodes[3].Visible = false;
            }

            if (HarmonicIPBarCheckItem.Checked)
            {
                SimValuesTreeListColumn.TreeList.Nodes[1].Collapse();
                SimValuesTreeListColumn.TreeList.Nodes[1].Visible = false;

                SimValuesTreeListColumn.TreeList.Nodes[2].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[2].Visible = true;

                SysCharValuesTreeListColumn.TreeList.Nodes[3].Visible = true;
            }

            if (CombinedIPBarCheckItem.Checked)
            {
                SimValuesTreeListColumn.TreeList.Nodes[1].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[1].Visible = true;

                SimValuesTreeListColumn.TreeList.Nodes[2].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[2].Visible = true;

                SysCharValuesTreeListColumn.TreeList.Nodes[3].Visible = true;
            }
        }

        private void RunBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateDocumentFromUI();

            //UpdateUIFromDocument();

            UpdateResultsFromDocument();

            Doc.Input.Calculate();

            MessageBox.Show("Run Complete", "Simulation", MessageBoxButtons.OK);

            ResponsePlotsResultsGroup.Visible = true;

            ResponsePlotsResultsGroup.Visible = true;
            ForcePlotResultGroup.Visible = true;
            AccelerationResultsGroup.Visible = true;

            if (InitialConditionBarCheckItem.Checked)
            {
                ResponseToICBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                ResponseToHarmonicBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                CombinedResponseBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                SimValuesTreeListColumn.TreeList.Nodes[2].Collapse();
                SimValuesTreeListColumn.TreeList.Nodes[2].Visible = false;

                SimValuesTreeListColumn.TreeList.Nodes[1].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[1].Visible = true;

                SysCharValuesTreeListColumn.TreeList.Nodes[3].Visible = false;
            }

            if (HarmonicIPBarCheckItem.Checked)
            {
                ResponseToICBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                ResponseToHarmonicBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                CombinedResponseBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                SimValuesTreeListColumn.TreeList.Nodes[1].Collapse();
                SimValuesTreeListColumn.TreeList.Nodes[1].Visible = false;

                SimValuesTreeListColumn.TreeList.Nodes[2].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[2].Visible = true;

                SysCharValuesTreeListColumn.TreeList.Nodes[3].Visible = true;
            }

            if (CombinedIPBarCheckItem.Checked)
            {
                ResponseToICBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                ResponseToHarmonicBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                CombinedResponseBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                SimValuesTreeListColumn.TreeList.Nodes[1].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[1].Visible = true;

                SimValuesTreeListColumn.TreeList.Nodes[2].ExpandAll();
                SimValuesTreeListColumn.TreeList.Nodes[2].Visible = true;

                SysCharValuesTreeListColumn.TreeList.Nodes[3].Visible = true;
            }

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

                SysCharValuesTreeListColumn.TreeList.Nodes[3].Visible = false;

                ResponseToICBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                ResponseToHarmonicBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                CombinedResponseBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                ResponseToICNeedsToPlot = true;
                ResponseToHarmonicInputNeedsToPlot = false;
                TotalResponseNeedsToPlot = false;

                DamperForceNeedsToPlot = true;
                SpringForceNeedsToPlot = true;
                BodyForceNeedsToPlot = true;

                BodyAccelnNeedsToPlot = true;
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

                SysCharValuesTreeListColumn.TreeList.Nodes[3].Visible = true;

                ResponseToICBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                ResponseToHarmonicBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                CombinedResponseBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                ResponseToICNeedsToPlot = false;
                ResponseToHarmonicInputNeedsToPlot = true;
                TotalResponseNeedsToPlot = false;

                DamperForceNeedsToPlot = true;
                SpringForceNeedsToPlot = true;
                BodyForceNeedsToPlot = true;

                BodyAccelnNeedsToPlot = true;
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

                SysCharValuesTreeListColumn.TreeList.Nodes[3].Visible = true;

                ResponseToICBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                ResponseToHarmonicBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                CombinedResponseBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                ResponseToICNeedsToPlot = true;
                ResponseToHarmonicInputNeedsToPlot = true;
                TotalResponseNeedsToPlot = true;

                DamperForceNeedsToPlot = true;
                SpringForceNeedsToPlot = true;
                BodyForceNeedsToPlot = true;

                BodyAccelnNeedsToPlot = true;
            }
        }

        private void SysCharateristicsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SysCharactersticsTreelList.Visible = true;
        }

        private void ShowDesignPanelBarButtonItem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PropertiesTreeList.Visible = true;
        }

        private void HideDesignPanelBarButtonItem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PropertiesTreeList.Visible = false;
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
            SysCharactersticsTreelList.Visible = false;
        }

        // Region Below Is Not Used Currently

        #region Harmonic Input Plot
        //private void HarmonicInputPlotBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    SimSetupPanel.Visible = false;
        //    GraphPanel.Visible = true;

        //    HarmonicInputChartControl.Visible = true;

        //    ResponseToICChartControl.Visible = false;
        //    ResponseToHarmonicIPChartControl.Visible = false;
        //    TotalResponseChartControl.Visible = false;

        //    SpringForceChartControl.Visible = false;
        //    DamperForceChartControl.Visible = false;
        //    BodyForceChartControl.Visible = false;

        //    if (HarmonicInputNeedsToPlot)
        //    {
        //        HarmonicInputChartControl.Dock = DockStyle.Fill;

        //        HarmonicInputChartControl.Series.Clear();

        //        Series HarmonicIP = new Series("Force", ViewType.Spline);

        //        for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
        //        {
        //            HarmonicIP.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.InputForceOscillations[i]));
        //        }

        //        HarmonicInputChartControl.Series.Add(HarmonicIP);

        //        XYDiagram diagram = (XYDiagram)HarmonicInputChartControl.Diagram;

        //        diagram.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
        //        diagram.AxisX.Alignment = AxisAlignment.Near;
        //        diagram.AxisX.Title.Text = "Time (s)";
        //        diagram.AxisX.Title.TextColor = Color.Black;
        //        diagram.AxisX.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
        //        diagram.AxisX.Title.Font = new Font("Tahoma", 14, FontStyle.Bold);

        //        HarmonicInputChartControl.Update();

        //        HarmonicInputNeedsToPlot = false;
        //    }
        //}

        #endregion

        private void ResponseToICBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SimSetupPanel.Visible = false;
            GraphPanel.Visible = true;

            HarmonicInputChartControl.Visible = false;

            ResponseToICChartControl.Visible = true;
            ResponseToHarmonicIPChartControl.Visible = false;
            TotalResponseChartControl.Visible = false;

            SpringForceChartControl.Visible = false;
            DamperForceChartControl.Visible = false;
            BodyForceChartControl.Visible = false;
            BodyAccelnChartControl.Visible = false;

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

                XYDiagram diagram = (XYDiagram)ResponseToICChartControl.Diagram;

                diagram.AxisX.WholeRange.MinValue = Doc.Input.StartTime;
                diagram.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
                diagram.AxisX.Alignment = AxisAlignment.Near;
                diagram.AxisX.Title.Text = "Time (s)";
                diagram.AxisX.Title.TextColor = Color.Black;
                diagram.AxisX.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
                diagram.AxisX.Title.Font = new Font("Tahoma", 14, FontStyle.Bold);

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

            SpringForceChartControl.Visible = false;
            DamperForceChartControl.Visible = false;
            BodyForceChartControl.Visible = false;
            BodyAccelnChartControl.Visible = false;

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

                XYDiagram diagram = (XYDiagram)ResponseToHarmonicIPChartControl.Diagram;

                diagram.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
                diagram.AxisX.Alignment = AxisAlignment.Near;
                diagram.AxisX.Title.Text = "Time (s)";
                diagram.AxisX.Title.TextColor = Color.Black;
                diagram.AxisX.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
                diagram.AxisX.Title.Font = new Font("Tahoma", 14, FontStyle.Bold);

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

            SpringForceChartControl.Visible = false;
            DamperForceChartControl.Visible = false;
            BodyForceChartControl.Visible = false;
            BodyAccelnChartControl.Visible = false;

            if (TotalResponseNeedsToPlot)
            {
                TotalResponseChartControl.Dock = DockStyle.Fill;

                Series TotalResponse = new Series("Displacement", ViewType.Spline);

                TotalResponseChartControl.Series.Clear();

                for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                {
                    TotalResponse.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.TotalResponse[i]));
                }

                TotalResponseChartControl.Series.Add(TotalResponse);

                XYDiagram diagram = (XYDiagram)TotalResponseChartControl.Diagram;

                diagram.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
                diagram.AxisX.Alignment = AxisAlignment.Near;
                diagram.AxisX.Title.Text = "Time (s)";
                diagram.AxisX.Title.TextColor = Color.Black;
                diagram.AxisX.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
                diagram.AxisX.Title.Font = new Font("Tahoma", 14, FontStyle.Bold);

                TotalResponseChartControl.Update();

                TotalResponseNeedsToPlot = false;
            }
        }


        private void SpringForceResultsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SimSetupPanel.Visible = false;
            GraphPanel.Visible = true;

            HarmonicInputChartControl.Visible = false;

            ResponseToICChartControl.Visible = false;
            ResponseToHarmonicIPChartControl.Visible = false;
            TotalResponseChartControl.Visible = false;

            SpringForceChartControl.Visible = true;
            DamperForceChartControl.Visible = false;
            BodyForceChartControl.Visible = false;
            BodyAccelnChartControl.Visible = false;

            SpringForceChartControl.Dock = DockStyle.Fill;

            if (SpringForceNeedsToPlot)
            {
                if (InitialConditionBarCheckItem.Checked)
                {
                    Series SpringForce = new Series("Spring Force", ViewType.Spline);

                    SpringForceChartControl.Series.Clear();

                    for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                    {
                        SpringForce.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.SpringForceICR[i]));
                    }

                    SpringForceChartControl.Series.Add(SpringForce);

                    SpringForceChartControl.Update();
                }

                if (HarmonicIPBarCheckItem.Checked)
                {
                    Series SpringForce = new Series("Spring Force", ViewType.Spline);

                    SpringForceChartControl.Series.Clear();

                    for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                    {
                        SpringForce.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.SpringForceHR[i]));
                    }

                    SpringForceChartControl.Series.Add(SpringForce);

                    SpringForceChartControl.Update();
                }

                if (CombinedIPBarCheckItem.Checked)
                {
                    Series SpringForce = new Series("Spring Force", ViewType.Spline);

                    SpringForceChartControl.Series.Clear();

                    for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                    {
                        SpringForce.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.SpringForceTR[i]));
                    }

                    SpringForceChartControl.Series.Add(SpringForce);

                    SpringForceChartControl.Update();
                }

                SpringForceNeedsToPlot = false;
            }
        }

        private void DamperForceResultBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SimSetupPanel.Visible = false;
            GraphPanel.Visible = true;

            HarmonicInputChartControl.Visible = false;

            ResponseToICChartControl.Visible = false;
            ResponseToHarmonicIPChartControl.Visible = false;
            TotalResponseChartControl.Visible = false;

            SpringForceChartControl.Visible = false;
            DamperForceChartControl.Visible = true;
            BodyForceChartControl.Visible = false;
            BodyAccelnChartControl.Visible = false;

            DamperForceChartControl.Dock = DockStyle.Fill;

            if (DamperForceNeedsToPlot)
            {
                if (InitialConditionBarCheckItem.Checked)
                {
                    DamperForceChartControl.Series.Clear();

                    Series DamperForce = new Series("Damper Force", ViewType.Spline);

                    for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                    {
                        DamperForce.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.DamperForceICR[i]));
                    }

                    DamperForceChartControl.Series.Add(DamperForce);

                    DamperForceChartControl.Update();
                }

                if (HarmonicIPBarCheckItem.Checked)
                {
                    DamperForceChartControl.Series.Clear();

                    Series DamperForce = new Series("Damper Force", ViewType.Spline);

                    for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                    {
                        DamperForce.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.DamperForceHR[i]));
                    }

                    DamperForceChartControl.Series.Add(DamperForce);

                    DamperForceChartControl.Update();
                }

                if (CombinedIPBarCheckItem.Checked)
                {
                    DamperForceChartControl.Series.Clear();

                    Series DamperForce = new Series("Damper Force", ViewType.Spline);

                    for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                    {
                        DamperForce.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.DamperForceTR[i]));
                    }

                    DamperForceChartControl.Series.Add(DamperForce);

                    DamperForceChartControl.Update();
                }

                DamperForceNeedsToPlot = false;
            }
        }

        private void BodyForceResultsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SimSetupPanel.Visible = false;
            GraphPanel.Visible = true;

            HarmonicInputChartControl.Visible = false;

            ResponseToICChartControl.Visible = false;
            ResponseToHarmonicIPChartControl.Visible = false;
            TotalResponseChartControl.Visible = false;

            SpringForceChartControl.Visible = false;
            DamperForceChartControl.Visible = false;
            BodyForceChartControl.Visible = true;
            BodyAccelnChartControl.Visible = false;

            BodyForceChartControl.Dock = DockStyle.Fill;

            if (BodyForceNeedsToPlot)
            {
                if (InitialConditionBarCheckItem.Checked)
                {
                    BodyForceChartControl.Series.Clear();

                    Series BodyForce = new Series("Body Force", ViewType.Spline);

                    for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                    {
                        BodyForce.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.BodyForceICR[i]));
                    }

                    BodyForceChartControl.Series.Add(BodyForce);

                    BodyForceChartControl.Update();
                }

                if (HarmonicIPBarCheckItem.Checked)
                {
                    BodyForceChartControl.Series.Clear();

                    Series BodyForce = new Series("Body Force", ViewType.Spline);

                    for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                    {
                        BodyForce.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.BodyForceHR[i]));
                    }

                    BodyForceChartControl.Series.Add(BodyForce);

                    BodyForceChartControl.Update();
                }

                if (CombinedIPBarCheckItem.Checked)
                {
                    BodyForceChartControl.Series.Clear();

                    Series BodyForce = new Series("Body Force", ViewType.Spline);

                    for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                    {
                        BodyForce.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.BodyForceTR[i]));
                    }

                    BodyForceChartControl.Series.Add(BodyForce);

                    BodyForceChartControl.Update();
                }

                BodyForceNeedsToPlot = false;
            }
        }

        private void BodyAcclnResultsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SimSetupPanel.Visible = false;
            GraphPanel.Visible = true;

            HarmonicInputChartControl.Visible = false;

            ResponseToICChartControl.Visible = false;
            ResponseToHarmonicIPChartControl.Visible = false;
            TotalResponseChartControl.Visible = false;

            SpringForceChartControl.Visible = false;
            DamperForceChartControl.Visible = false;
            BodyForceChartControl.Visible = false;
            BodyAccelnChartControl.Visible = true;

            BodyAccelnChartControl.Dock = DockStyle.Fill;

            if (BodyAccelnNeedsToPlot)
            {
                if (InitialConditionBarCheckItem.Checked)
                {
                    BodyAccelnChartControl.Series.Clear();

                    Series BodyAcceln = new Series("Body Acceleration", ViewType.Spline);

                    for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                    {
                        BodyAcceln.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.AccelerationICR[i]));
                    }

                    BodyAccelnChartControl.Series.Add(BodyAcceln);

                    BodyAccelnChartControl.Update();
                }

                if (HarmonicIPBarCheckItem.Checked)
                {
                    BodyAccelnChartControl.Series.Clear();

                    Series BodyForce = new Series("Body Acceleration", ViewType.Spline);

                    for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                    {
                        BodyForce.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.AccelerationHR[i]));
                    }

                    BodyAccelnChartControl.Series.Add(BodyForce);

                    BodyAccelnChartControl.Update();
                }

                if (CombinedIPBarCheckItem.Checked)
                {
                    BodyAccelnChartControl.Series.Clear();

                    Series BodyForce = new Series("Body Acceleration", ViewType.Spline);

                    for (int i = 0; i < Doc.Input.TimeIntervals.Count; i++)
                    {
                        BodyForce.Points.Add(new SeriesPoint(Doc.Input.TimeIntervals[i], Doc.Input.AccelerationTR[i]));
                    }

                    BodyAccelnChartControl.Series.Add(BodyForce);

                    BodyAccelnChartControl.Update();
                }

                BodyAccelnNeedsToPlot = false;
            }
        }
    }
}
