﻿using System.Windows.Controls;
using System.Windows.Input;

namespace IntervalTimer.WPF;
/// <summary>
/// Interaction logic for NumericUpDown.xaml
/// </summary>
public partial class NumericUpDown : UserControl
{
    public NumericUpDown()
    {
        InitializeComponent();
        DataContext = this;
    }

    public int Value { get; set; }



    private void TextBoxPreviewKeyDown(object sender, KeyEventArgs e)
    {
        if ((e.Key >= Key.D0 && e.Key <= Key.D9) ||
           (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) ||
            e.Key == Key.Back || e.Key == Key.Delete || e.Key == Key.Right || e.Key == Key.Left)
            return;

        if (e.Key == Key.Up)
        {
            Value++;
            return;
        }

        if (e.Key == Key.Down)
        {
            Value--;
            return;
        }

        e.Handled = true;
    }

    private void ScrollBarScroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
    {
    }
}
