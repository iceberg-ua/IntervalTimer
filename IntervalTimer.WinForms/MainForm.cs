using Timer = System.Windows.Forms.Timer;

namespace IntervalTimer.WinForms;

public partial class MainForm : Form
{
    static readonly double _intStep = 1000;
    readonly Timer _mainTimer = new();

    TimeSpan _activeTimeSpan;
    TimeSpan _breakTimeSpan;
    TimeSpan _timeSpan;
    TimeSpan _step = TimeSpan.FromMilliseconds(_intStep);
    bool _active = true;
    int _counter = 0;

    public MainForm()
    {
        InitializeComponent();

        _mainTimer.Interval = (int)_intStep;
        _mainTimer.Tick += OnMainTimerTick;
    }

    private void OnMainTimerTick(object? sender, EventArgs e)
    {
        _timeSpan = _timeSpan.Subtract(_step);

        if (_active)
            _activeTimerLabel.Text = $"{_timeSpan.Minutes,2:00}:{_timeSpan.Seconds,2:00}";
        else
            _breakTimerLabel.Text = $"{_timeSpan.Minutes,2:00}:{_timeSpan.Seconds,2:00}";

        if (_timeSpan == TimeSpan.Zero)
        {
            if (_active)
                _breakTimerLabel.Text = $"{_breakTimeSpan.Minutes,2:00}:{_breakTimeSpan.Seconds,2:00}";
            else
                _activeTimerLabel.Text = $"{_activeTimeSpan.Minutes,2:00}:{_activeTimeSpan.Seconds,2:00}";

            _timeSpan = _active ? _breakTimeSpan : _activeTimeSpan;
            _active = !_active;
        }
    }

    private void OnStartButtonClick(object sender, EventArgs e)
    {
        _activeTimeSpan = TimeSpan.FromSeconds((int)_activeSpanCtrl.Value);
        _breakTimeSpan = TimeSpan.FromSeconds((int)_breakSpanCtrl.Value);

        _activeTimerLabel.Text = $"{_activeTimeSpan.Minutes,2:00}:{_activeTimeSpan.Seconds,2:00}";
        _breakTimerLabel.Text = $"{_breakTimeSpan.Minutes,2:00}:{_breakTimeSpan.Seconds,2:00}";

        _timeSpan = _activeTimeSpan;
        _counter = 0;
        _mainTimer.Start();

        _startButton.Enabled = false;
        _activeSpanCtrl.Enabled = false;
        _breakSpanCtrl.Enabled = false;
    }

    private void OnStopButtonClick(object sender, EventArgs e)
    {
        _mainTimer.Stop();

        _activeTimerLabel.Text = $"{_activeTimeSpan.Minutes,2:00}:{_activeTimeSpan.Seconds,2:00}";
        _breakTimerLabel.Text = $"{_breakTimeSpan.Minutes,2:00}:{_breakTimeSpan.Seconds,2:00}";

        _startButton.Enabled = true;
        _activeSpanCtrl.Enabled = true;
        _breakSpanCtrl.Enabled = true;
    }
}
