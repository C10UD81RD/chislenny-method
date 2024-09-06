using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _1labMath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }
        private void chart1_SelectionRangeChanged(object sender, CursorEventArgs e)
        {




            double startX, endX, startY, endY;

            if (chart1.ChartAreas[0].CursorX.SelectionStart > chart1.ChartAreas[0].CursorX.SelectionEnd)
            {
                startX = chart1.ChartAreas[0].CursorX.SelectionEnd;
                endX = chart1.ChartAreas[0].CursorX.SelectionStart;
            }
            else
            {
                startX = chart1.ChartAreas[0].CursorX.SelectionStart;
                endX = chart1.ChartAreas[0].CursorX.SelectionEnd;
            }
            if (chart1.ChartAreas[0].CursorY.SelectionStart > chart1.ChartAreas[0].CursorY.SelectionEnd)
            {
                endY = chart1.ChartAreas[0].CursorY.SelectionStart;
                startY = chart1.ChartAreas[0].CursorY.SelectionEnd;
            }
            else
            {
                startY = chart1.ChartAreas[0].CursorY.SelectionStart;
                endY = chart1.ChartAreas[0].CursorY.SelectionEnd;
            }

            if (startX == endX && startY == endY)
            {
                return;
            }

            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(startX, (endX - startX), DateTimeIntervalType.Auto, true);
            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(startY, (endY - startY), DateTimeIntervalType.Auto, true);
        }
    }
}
