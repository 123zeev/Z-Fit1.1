using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Z_fit1._0
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GudgetsPage : Page
    {
        static int count = 0;
        DispatcherTimer timer = new DispatcherTimer();
        public GudgetsPage()
        {
            this.InitializeComponent();
            BuildTimer();
        }

        private void BuildTimer()
        {
            MinuteTextBlock.Text = "00";
            SecondsTextBlock.Text = "00";
            CentiSecTextBlock.Text = "00";
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, object e)
        {
            // your homework
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            BuildTimer();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void RoundButton_Click(object sender, RoutedEventArgs e)
        {
            count++;
            string roundTime = "";
            roundTime += MinuteTextBlock.Text + ":";
            roundTime += SecondsTextBlock.Text + ":";
            roundTime += CentiSecTextBlock.Text;
            TextBox t = new TextBox();
            t.Text = count.ToString() + " " + roundTime;
            MyResultsStackPanel.Children.Add(t);
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
