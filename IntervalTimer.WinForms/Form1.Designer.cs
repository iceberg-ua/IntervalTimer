namespace IntervalTimer.WinForms;

partial class Form1
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
        _activeTimerLabel.Location = new Point(187, 83);
        _activeTimerLabel.Name = "_activeTimerLabel";
        _activeTimerLabel.Size = new Size(34, 15);
        _activeTimerLabel.TabIndex = 0;
        _activeTimerLabel.Text = "00:00";
        // 
        // _breakTimerLabel
        // 
        _breakTimerLabel.AutoSize = true;
        _breakTimerLabel.Location = new Point(264, 83);
        _breakTimerLabel.Name = "_breakTimerLabel";
        _breakTimerLabel.Size = new Size(34, 15);
        _breakTimerLabel.TabIndex = 1;
        _breakTimerLabel.Text = "00:00";
        // 
        // _startButton
        // 
        _startButton.Location = new Point(165, 110);
        _startButton.Name = "_startButton";
        _startButton.Size = new Size(75, 23);
        _startButton.TabIndex = 2;
        _startButton.Text = "start";
        _startButton.UseVisualStyleBackColor = true;
        _startButton.Click += OnStartButtonClick;
        // 
        // _activeSpan
        // 
        _activeSpanCtrl.Location = new Point(165, 57);
        _activeSpanCtrl.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
        _activeSpanCtrl.Name = "_activeSpan";
        _activeSpanCtrl.Size = new Size(75, 23);
        _activeSpanCtrl.TabIndex = 3;
        // 
        // _breakSpan
        // 
        _breakSpanCtrl.Location = new Point(246, 57);
        _breakSpanCtrl.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
        _breakSpanCtrl.Name = "_breakSpan";
        _breakSpanCtrl.Size = new Size(75, 23);
        _breakSpanCtrl.TabIndex = 4;
        // 
        // _stopButton
        // 
        _stopButton.Location = new Point(246, 110);
        _stopButton.Name = "_stopButton";
        _stopButton.Size = new Size(75, 23);
        _stopButton.TabIndex = 5;
        _stopButton.Text = "stop";
        _stopButton.UseVisualStyleBackColor = true;
        _stopButton.Click += OnStopButtonClick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(_stopButton);
        Controls.Add(_breakSpanCtrl);
        Controls.Add(_activeSpanCtrl);
        Controls.Add(_startButton);
        Controls.Add(_breakTimerLabel);
        Controls.Add(_activeTimerLabel);
        Name = "Form1";
        Text = "Form1";
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
