namespace IntervalTimer.WinForms;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        _activeTimerLabel = new Label();
        _breakTimerLabel = new Label();
        _startButton = new Button();
        _activeSpanCtrl = new NumericUpDown();
        _breakSpanCtrl = new NumericUpDown();
        _stopButton = new Button();
        ((System.ComponentModel.ISupportInitialize)_activeSpanCtrl).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_breakSpanCtrl).BeginInit();
        SuspendLayout();
        // 
        // _activeTimerLabel
        // 
        _activeTimerLabel.AutoSize = true;
        _activeTimerLabel.Font = new Font("Trebuchet MS", 72F, FontStyle.Bold, GraphicsUnit.Point, 204);
        _activeTimerLabel.ForeColor = Color.IndianRed;
        _activeTimerLabel.Location = new Point(12, 9);
        _activeTimerLabel.Name = "_activeTimerLabel";
        _activeTimerLabel.Size = new Size(309, 119);
        _activeTimerLabel.TabIndex = 0;
        _activeTimerLabel.Text = "00:00";
        // 
        // _breakTimerLabel
        // 
        _breakTimerLabel.AutoSize = true;
        _breakTimerLabel.Font = new Font("Trebuchet MS", 72F, FontStyle.Bold, GraphicsUnit.Point, 204);
        _breakTimerLabel.ForeColor = Color.DarkSeaGreen;
        _breakTimerLabel.Location = new Point(327, 9);
        _breakTimerLabel.Name = "_breakTimerLabel";
        _breakTimerLabel.Size = new Size(309, 119);
        _breakTimerLabel.TabIndex = 1;
        _breakTimerLabel.Text = "00:00";
        // 
        // _startButton
        // 
        _startButton.BackColor = Color.ForestGreen;
        _startButton.FlatAppearance.BorderSize = 0;
        _startButton.FlatStyle = FlatStyle.Flat;
        _startButton.Font = new Font("Trebuchet MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        _startButton.ForeColor = SystemColors.ButtonHighlight;
        _startButton.Location = new Point(161, 165);
        _startButton.Name = "_startButton";
        _startButton.Size = new Size(160, 60);
        _startButton.TabIndex = 2;
        _startButton.Text = "START";
        _startButton.UseVisualStyleBackColor = false;
        _startButton.Click += OnStartButtonClick;
        // 
        // _activeSpanCtrl
        // 
        _activeSpanCtrl.Location = new Point(246, 131);
        _activeSpanCtrl.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
        _activeSpanCtrl.Name = "_activeSpanCtrl";
        _activeSpanCtrl.Size = new Size(75, 23);
        _activeSpanCtrl.TabIndex = 3;
        // 
        // _breakSpanCtrl
        // 
        _breakSpanCtrl.Location = new Point(327, 131);
        _breakSpanCtrl.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
        _breakSpanCtrl.Name = "_breakSpanCtrl";
        _breakSpanCtrl.Size = new Size(75, 23);
        _breakSpanCtrl.TabIndex = 4;
        // 
        // _stopButton
        // 
        _stopButton.BackColor = Color.FromArgb(192, 0, 0);
        _stopButton.FlatAppearance.BorderSize = 0;
        _stopButton.FlatStyle = FlatStyle.Flat;
        _stopButton.Font = new Font("Trebuchet MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        _stopButton.ForeColor = SystemColors.ButtonHighlight;
        _stopButton.Location = new Point(327, 165);
        _stopButton.Name = "_stopButton";
        _stopButton.Size = new Size(160, 60);
        _stopButton.TabIndex = 5;
        _stopButton.Text = "STOP";
        _stopButton.UseVisualStyleBackColor = false;
        _stopButton.Click += OnStopButtonClick;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DimGray;
        ClientSize = new Size(644, 241);
        Controls.Add(_stopButton);
        Controls.Add(_breakSpanCtrl);
        Controls.Add(_activeSpanCtrl);
        Controls.Add(_startButton);
        Controls.Add(_breakTimerLabel);
        Controls.Add(_activeTimerLabel);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "MainForm";
        SizeGripStyle = SizeGripStyle.Show;
        Text = "Interval timer";
        ((System.ComponentModel.ISupportInitialize)_activeSpanCtrl).EndInit();
        ((System.ComponentModel.ISupportInitialize)_breakSpanCtrl).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label _activeTimerLabel;
    private Label _breakTimerLabel;
    private Button _startButton;
    private NumericUpDown _activeSpanCtrl;
    private NumericUpDown _breakSpanCtrl;
    private Button _stopButton;
}
