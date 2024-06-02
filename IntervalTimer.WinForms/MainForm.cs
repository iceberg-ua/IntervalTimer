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
    int _iterationCount = 0;

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
            {
                _activeTimerLabel.Text = $"{_activeTimeSpan.Minutes,2:00}:{_activeTimeSpan.Seconds,2:00}";
                _counter++;
                _counterLabel.Text = _counter.ToString();

                if (_inCheckBox.Checked)
                {
                    _iterationCount--;

                    if (_iterationCount == 0)
                        OnStopButtonClick(_stopButton, EventArgs.Empty);
                }
            }

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

        if (_inCheckBox.Checked)
            _iterationCount = (int)_iterationCountCtrl.Value;

        _mainTimer.Start();

        _startButton.Enabled = false;
        _stopButton.Enabled = true;
        _activeSpanCtrl.Enabled = false;
        _breakSpanCtrl.Enabled = false;
    }

    private void OnStopButtonClick(object sender, EventArgs e)
    {
        _mainTimer.Stop();

        _activeTimerLabel.Text = $"{_activeTimeSpan.Minutes,2:00}:{_activeTimeSpan.Seconds,2:00}";
        _breakTimerLabel.Text = $"{_breakTimeSpan.Minutes,2:00}:{_breakTimeSpan.Seconds,2:00}";
        _counterLabel.Text = "0";

        _startButton.Enabled = true;
        _stopButton.Enabled = false;
        _activeSpanCtrl.Enabled = true;
        _breakSpanCtrl.Enabled = true;
        _counter = 0;
    }

    private void SpanControlValueChanged(object sender, EventArgs e)
    {
        UpdateStartButtonState();
    }

    private void IterationNumberCheckedChanged(object sender, EventArgs e)
    {
        _iterationCountCtrl.Enabled = _inCheckBox.Checked;
        UpdateStartButtonState();
    }

    private void UpdateStartButtonState()
    {
        _startButton.Enabled = _activeSpanCtrl.Value != 0 && _breakSpanCtrl.Value != 0 && 
                               (!_inCheckBox.Checked || (_inCheckBox.Checked && _iterationCountCtrl.Value > 0));
    }
}
