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
        label1 = new Label();
        _iterationCountCtrl = new NumericUpDown();
        _inCheckBox = new CheckBox();
        label2 = new Label();
        label3 = new Label();
        groupBox1 = new GroupBox();
        _counterLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)_activeSpanCtrl).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_breakSpanCtrl).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_iterationCountCtrl).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // _activeTimerLabel
        // 
        _activeTimerLabel.AutoSize = true;
        _activeTimerLabel.Font = new Font("Trebuchet MS", 72F, FontStyle.Bold, GraphicsUnit.Point, 204);
        _activeTimerLabel.ForeColor = Color.IndianRed;
        _activeTimerLabel.Location = new Point(6, 11);
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
        _breakTimerLabel.Location = new Point(317, 11);
        _breakTimerLabel.Name = "_breakTimerLabel";
        _breakTimerLabel.Size = new Size(309, 119);
        _breakTimerLabel.TabIndex = 1;
        _breakTimerLabel.Text = "00:00";
        // 
        // _startButton
        // 
        _startButton.BackColor = Color.ForestGreen;
        _startButton.Enabled = false;
        _startButton.FlatAppearance.BorderColor = SystemColors.ButtonFace;
        _startButton.FlatStyle = FlatStyle.Flat;
        _startButton.Font = new Font("Trebuchet MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        _startButton.ForeColor = SystemColors.ButtonHighlight;
        _startButton.Location = new Point(12, 228);
        _startButton.Name = "_startButton";
        _startButton.Size = new Size(160, 60);
        _startButton.TabIndex = 1;
        _startButton.Text = "START";
        _startButton.UseVisualStyleBackColor = false;
        _startButton.Click += OnStartButtonClick;
        // 
        // _activeSpanCtrl
        // 
        _activeSpanCtrl.BorderStyle = BorderStyle.None;
        _activeSpanCtrl.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
        _activeSpanCtrl.Location = new Point(27, 181);
        _activeSpanCtrl.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
        _activeSpanCtrl.Name = "_activeSpanCtrl";
        _activeSpanCtrl.Size = new Size(145, 31);
        _activeSpanCtrl.TabIndex = 3;
        _activeSpanCtrl.TextAlign = HorizontalAlignment.Center;
        _activeSpanCtrl.ValueChanged += SpanControlValueChanged;
        // 
        // _breakSpanCtrl
        // 
        _breakSpanCtrl.BorderStyle = BorderStyle.None;
        _breakSpanCtrl.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
        _breakSpanCtrl.Location = new Point(476, 182);
        _breakSpanCtrl.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
        _breakSpanCtrl.Name = "_breakSpanCtrl";
        _breakSpanCtrl.RightToLeft = RightToLeft.Yes;
        _breakSpanCtrl.Size = new Size(145, 31);
        _breakSpanCtrl.TabIndex = 4;
        _breakSpanCtrl.TextAlign = HorizontalAlignment.Center;
        _breakSpanCtrl.ValueChanged += SpanControlValueChanged;
        // 
        // _stopButton
        // 
        _stopButton.BackColor = Color.FromArgb(192, 0, 0);
        _stopButton.Enabled = false;
        _stopButton.FlatAppearance.BorderColor = SystemColors.ButtonFace;
        _stopButton.FlatStyle = FlatStyle.Flat;
        _stopButton.Font = new Font("Trebuchet MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        _stopButton.ForeColor = SystemColors.ButtonHighlight;
        _stopButton.Location = new Point(476, 228);
        _stopButton.Name = "_stopButton";
        _stopButton.Size = new Size(160, 60);
        _stopButton.TabIndex = 5;
        _stopButton.Text = "STOP";
        _stopButton.UseVisualStyleBackColor = false;
        _stopButton.Click += OnStopButtonClick;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label1.ForeColor = SystemColors.ButtonFace;
        label1.Location = new Point(178, 134);
        label1.Name = "label1";
        label1.Size = new Size(0, 27);
        label1.TabIndex = 6;
        // 
        // _iterationCountCtrl
        // 
        _iterationCountCtrl.BorderStyle = BorderStyle.None;
        _iterationCountCtrl.Enabled = false;
        _iterationCountCtrl.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        _iterationCountCtrl.Location = new Point(264, 185);
        _iterationCountCtrl.Name = "_iterationCountCtrl";
        _iterationCountCtrl.Size = new Size(120, 28);
        _iterationCountCtrl.TabIndex = 7;
        _iterationCountCtrl.TextAlign = HorizontalAlignment.Center;
        _iterationCountCtrl.ValueChanged += SpanControlValueChanged;
        // 
        // _inCheckBox
        // 
        _inCheckBox.AutoSize = true;
        _inCheckBox.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
        _inCheckBox.ForeColor = SystemColors.ButtonFace;
        _inCheckBox.Location = new Point(208, 153);
        _inCheckBox.Name = "_inCheckBox";
        _inCheckBox.Size = new Size(238, 26);
        _inCheckBox.TabIndex = 1;
        _inCheckBox.Text = "Define number of iterations";
        _inCheckBox.UseVisualStyleBackColor = true;
        _inCheckBox.CheckedChanged += IterationNumberCheckedChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label2.ForeColor = SystemColors.ButtonFace;
        label2.Location = new Point(27, 153);
        label2.Name = "label2";
        label2.Size = new Size(151, 22);
        label2.TabIndex = 9;
        label2.Text = "Activity time(sec):";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label3.ForeColor = SystemColors.ButtonFace;
        label3.Location = new Point(476, 153);
        label3.Name = "label3";
        label3.Size = new Size(136, 22);
        label3.TabIndex = 10;
        label3.Text = "Break time(sec):";
        // 
        // groupBox1
        // 
        groupBox1.AccessibleRole = AccessibleRole.IpAddress;
        groupBox1.BackColor = Color.DimGray;
        groupBox1.Controls.Add(_activeTimerLabel);
        groupBox1.Controls.Add(_breakTimerLabel);
        groupBox1.ForeColor = SystemColors.ControlLightLight;
        groupBox1.Location = new Point(10, 1);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(630, 135);
        groupBox1.TabIndex = 11;
        groupBox1.TabStop = false;
        // 
        // _counterLabel
        // 
        _counterLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        _counterLabel.AutoSize = true;
        _counterLabel.Font = new Font("Trebuchet MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
        _counterLabel.ForeColor = SystemColors.ActiveCaption;
        _counterLabel.Location = new Point(293, 216);
        _counterLabel.Name = "_counterLabel";
        _counterLabel.Size = new Size(73, 81);
        _counterLabel.TabIndex = 12;
        _counterLabel.Text = "0";
        _counterLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DimGray;
        ClientSize = new Size(652, 300);
        Controls.Add(_counterLabel);
        Controls.Add(groupBox1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(_inCheckBox);
        Controls.Add(_iterationCountCtrl);
        Controls.Add(label1);
        Controls.Add(_stopButton);
        Controls.Add(_breakSpanCtrl);
        Controls.Add(_activeSpanCtrl);
        Controls.Add(_startButton);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "MainForm";
        SizeGripStyle = SizeGripStyle.Show;
        Text = "Interval timer";
        ((System.ComponentModel.ISupportInitialize)_activeSpanCtrl).EndInit();
        ((System.ComponentModel.ISupportInitialize)_breakSpanCtrl).EndInit();
        ((System.ComponentModel.ISupportInitialize)_iterationCountCtrl).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
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
    private Label label1;
    private NumericUpDown _iterationCountCtrl;
    private CheckBox _inCheckBox;
    private Label label2;
    private Label label3;
    private GroupBox groupBox1;
    private Label _counterLabel;
}
