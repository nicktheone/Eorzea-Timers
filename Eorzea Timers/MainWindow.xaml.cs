using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Eorzea_Timers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Start the timer that calculates Eorzea Time
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(2916);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        #region Methods

        #endregion

        #region Events
        private void Timer_Tick(object sender, EventArgs e)
        {
            //https://stackoverflow.com/a/7875351/10617365
            var eorzeaTimeNow = DateTime.Now.ToEorzeaTime().ToString("hh:mm tt", CultureInfo.InvariantCulture);
            eorzeaTime.Content = eorzeaTimeNow;
        }
        #endregion
    }

    public static class Extension
    {
        public static DateTime ToEorzeaTime(this DateTime date)
        {
            //https://www.reddit.com/r/ffxiv/comments/2pbl8p/eorzea_time_formula/cmvijkz?utm_source=share&utm_medium=web2x
            //https://olitee.com/2015/01/c-convert-current-time-ffxivs-eorzea-time/

            const double EorzeaMultiplier = 3600d / 175d;

            // Calculate how many ticks have elapsed since 1/1/1970
            long epochTicks = date.ToUniversalTime().Ticks - (new DateTime(1970, 1, 1).Ticks);

            // Multiply those ticks by the Eorzea multipler (approx 20.5x)
            long eorzeaTicks = (long)Math.Round(epochTicks * EorzeaMultiplier);

            return new DateTime(eorzeaTicks);
        }
    }
}
