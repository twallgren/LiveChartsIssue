using System;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace LiveChartsIssue.Sample
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {

            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new LineSeries()
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(4),
                        new ObservableValue(2),
                        new ObservableValue(8),
                        new ObservableValue(2),
                        new ObservableValue(3),
                        new ObservableValue(0),
                        new ObservableValue(1),
                    },
                }
            };

            Labels = new[]
            {
                "August",
                "gjpqy",
                "Brogdon",
                "gjpqygjpqygjpqy",
                "blah",
                "gjpqygjpqy",
                "Lorem"
            };

            DataContext = this;
        }


        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
    }
}
