using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircularWPF;
//using System.Windows.Controls;

namespace CircularWF
{
    public partial class CircularWF: UserControl
    {

        // Private data member that backs the EndColor property.  
        private double gaugeValue = 0.0;
        // The Category attribute tells the designer to display  
        // it in the Flash grouping.
        // The Description attribute provides a description of  
        // the property.
        [
        Category("Gauge"),
        Description("The Value.")
        ]

        public double GaugeValue
        {
            get { return gaugeValue; }
            set
            {
                userControl11.Value = value;
                // The Invalidate method calls the OnPaint method, which redraws the control.  
                Invalidate();
            }
        }

        public CircularWF()
        {
            InitializeComponent();
        }
    }
}
