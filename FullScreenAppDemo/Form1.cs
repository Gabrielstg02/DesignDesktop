using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullScreenAppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,5),      //First Point of First Line
                        new ObservablePoint(4,4),       //2nd POint
                        new ObservablePoint(8,2),     //------
                        new ObservablePoint(9,12),
                        new ObservablePoint(10,14)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,3),      //First Point of 2nd Line
                        new ObservablePoint(3,7),       //2nd POint
                        new ObservablePoint(4,12),     //------
                        new ObservablePoint(7,9),
                        new ObservablePoint(10,12)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,4),      //First Point of 3rd Line
                        new ObservablePoint(3,12),       //2nd POint
                        new ObservablePoint(5,10),     //------
                        new ObservablePoint(6,12),
                        new ObservablePoint(10,12)
                    },
                    PointGeometrySize = 15
                }
            };
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2Button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
