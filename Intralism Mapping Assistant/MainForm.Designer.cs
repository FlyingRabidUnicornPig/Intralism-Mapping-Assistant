﻿namespace Intralism_Mapping_Assistant
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ZoomStopTool = new System.Windows.Forms.TabControl();
            this.ZoomStopTab = new System.Windows.Forms.TabPage();
            this.ZoomPanel = new System.Windows.Forms.Panel();
            this.AdvancedOptions = new System.Windows.Forms.GroupBox();
            this.CustomRangeZSCalc = new System.Windows.Forms.NumericUpDown();
            this.AdvancedCustomRangeCalc = new System.Windows.Forms.CheckBox();
            this.CustomFrameRate = new System.Windows.Forms.NumericUpDown();
            this.AdvancedFrameRateCalc = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.ZoomStopCalculate = new System.Windows.Forms.Button();
            this.ZoomStopOutputLabel = new System.Windows.Forms.Label();
            this.CalcSED = new System.Windows.Forms.RadioButton();
            this.CalcSET = new System.Windows.Forms.RadioButton();
            this.CalcFED = new System.Windows.Forms.RadioButton();
            this.CalcFET = new System.Windows.Forms.RadioButton();
            this.ZoomStopDescription = new System.Windows.Forms.Label();
            this.InputGroup = new System.Windows.Forms.GroupBox();
            this.SecondEventDistanceBox = new System.Windows.Forms.NumericUpDown();
            this.SecondEventTimeBox = new System.Windows.Forms.NumericUpDown();
            this.FirstEventDistanceBox = new System.Windows.Forms.NumericUpDown();
            this.FirstEventTimeBox = new System.Windows.Forms.NumericUpDown();
            this.StartingDistanceBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EventModifier = new System.Windows.Forms.TabPage();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomFRToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CustomRangeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.EventModifierPanel = new System.Windows.Forms.Panel();
            this.ZoomModifierDescription = new System.Windows.Forms.Label();
            this.ZoomStopTool.SuspendLayout();
            this.ZoomStopTab.SuspendLayout();
            this.ZoomPanel.SuspendLayout();
            this.AdvancedOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomRangeZSCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomFrameRate)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.InputGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondEventDistanceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondEventTimeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstEventDistanceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstEventTimeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingDistanceBox)).BeginInit();
            this.EventModifier.SuspendLayout();
            this.AboutTab.SuspendLayout();
            this.EventModifierPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZoomStopTool
            // 
            this.ZoomStopTool.Controls.Add(this.ZoomStopTab);
            this.ZoomStopTool.Controls.Add(this.EventModifier);
            this.ZoomStopTool.Controls.Add(this.AboutTab);
            this.ZoomStopTool.Location = new System.Drawing.Point(13, 13);
            this.ZoomStopTool.Name = "ZoomStopTool";
            this.ZoomStopTool.SelectedIndex = 0;
            this.ZoomStopTool.Size = new System.Drawing.Size(935, 515);
            this.ZoomStopTool.TabIndex = 0;
            // 
            // ZoomStopTab
            // 
            this.ZoomStopTab.Controls.Add(this.ZoomPanel);
            this.ZoomStopTab.Location = new System.Drawing.Point(4, 22);
            this.ZoomStopTab.Name = "ZoomStopTab";
            this.ZoomStopTab.Padding = new System.Windows.Forms.Padding(3);
            this.ZoomStopTab.Size = new System.Drawing.Size(927, 489);
            this.ZoomStopTab.TabIndex = 0;
            this.ZoomStopTab.Text = "\"Zoom Stop\" effect Calculator";
            // 
            // ZoomPanel
            // 
            this.ZoomPanel.Controls.Add(this.AdvancedOptions);
            this.ZoomPanel.Controls.Add(this.groupBox2);
            this.ZoomPanel.Controls.Add(this.CalcSED);
            this.ZoomPanel.Controls.Add(this.CalcSET);
            this.ZoomPanel.Controls.Add(this.CalcFED);
            this.ZoomPanel.Controls.Add(this.CalcFET);
            this.ZoomPanel.Controls.Add(this.ZoomStopDescription);
            this.ZoomPanel.Controls.Add(this.InputGroup);
            this.ZoomPanel.Location = new System.Drawing.Point(7, 7);
            this.ZoomPanel.Name = "ZoomPanel";
            this.ZoomPanel.Size = new System.Drawing.Size(914, 476);
            this.ZoomPanel.TabIndex = 0;
            // 
            // AdvancedOptions
            // 
            this.AdvancedOptions.Controls.Add(this.CustomRangeZSCalc);
            this.AdvancedOptions.Controls.Add(this.AdvancedCustomRangeCalc);
            this.AdvancedOptions.Controls.Add(this.CustomFrameRate);
            this.AdvancedOptions.Controls.Add(this.AdvancedFrameRateCalc);
            this.AdvancedOptions.Location = new System.Drawing.Point(7, 274);
            this.AdvancedOptions.Name = "AdvancedOptions";
            this.AdvancedOptions.Size = new System.Drawing.Size(217, 147);
            this.AdvancedOptions.TabIndex = 17;
            this.AdvancedOptions.TabStop = false;
            this.AdvancedOptions.Text = "Advanced Options";
            // 
            // CustomRangeZSCalc
            // 
            this.CustomRangeZSCalc.Enabled = false;
            this.CustomRangeZSCalc.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CustomRangeZSCalc.Location = new System.Drawing.Point(11, 111);
            this.CustomRangeZSCalc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CustomRangeZSCalc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CustomRangeZSCalc.Name = "CustomRangeZSCalc";
            this.CustomRangeZSCalc.Size = new System.Drawing.Size(120, 20);
            this.CustomRangeZSCalc.TabIndex = 3;
            this.CustomRangeZSCalc.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // AdvancedCustomRangeCalc
            // 
            this.AdvancedCustomRangeCalc.AutoSize = true;
            this.AdvancedCustomRangeCalc.Location = new System.Drawing.Point(11, 88);
            this.AdvancedCustomRangeCalc.Name = "AdvancedCustomRangeCalc";
            this.AdvancedCustomRangeCalc.Size = new System.Drawing.Size(96, 17);
            this.AdvancedCustomRangeCalc.TabIndex = 2;
            this.AdvancedCustomRangeCalc.Text = "Custom Range";
            this.CustomRangeToolTip.SetToolTip(this.AdvancedCustomRangeCalc, "Used in the calculation of the First Event Distance.\nIncreasing this range can ha" +
        "ve a big impact on calculation time. Use with caution.\nDefault: 500");
            this.AdvancedCustomRangeCalc.UseVisualStyleBackColor = true;
            this.AdvancedCustomRangeCalc.CheckedChanged += new System.EventHandler(this.AdvancedCustomRangeCalc_CheckedChanged);
            // 
            // CustomFrameRate
            // 
            this.CustomFrameRate.Enabled = false;
            this.CustomFrameRate.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CustomFrameRate.Location = new System.Drawing.Point(11, 43);
            this.CustomFrameRate.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.CustomFrameRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CustomFrameRate.Name = "CustomFrameRate";
            this.CustomFrameRate.Size = new System.Drawing.Size(120, 20);
            this.CustomFrameRate.TabIndex = 1;
            this.CustomFrameRate.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // AdvancedFrameRateCalc
            // 
            this.AdvancedFrameRateCalc.AutoSize = true;
            this.AdvancedFrameRateCalc.Location = new System.Drawing.Point(10, 20);
            this.AdvancedFrameRateCalc.Name = "AdvancedFrameRateCalc";
            this.AdvancedFrameRateCalc.Size = new System.Drawing.Size(119, 17);
            this.AdvancedFrameRateCalc.TabIndex = 0;
            this.AdvancedFrameRateCalc.Text = "Custom Frame Rate";
            this.CustomFRToolTip.SetToolTip(this.AdvancedFrameRateCalc, "Used to mimmick in-game zoom calculations.\nIf you want a zoom that looks best on " +
        "your machine, input your average frame rate.\nDefault Frame Rate is 1000.");
            this.AdvancedFrameRateCalc.UseVisualStyleBackColor = true;
            this.AdvancedFrameRateCalc.CheckedChanged += new System.EventHandler(this.AdvancedFrameRateCalc_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OutputBox);
            this.groupBox2.Controls.Add(this.ZoomStopCalculate);
            this.groupBox2.Controls.Add(this.ZoomStopOutputLabel);
            this.groupBox2.Location = new System.Drawing.Point(462, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 131);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(153, 64);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(100, 20);
            this.OutputBox.TabIndex = 22;
            // 
            // ZoomStopCalculate
            // 
            this.ZoomStopCalculate.Location = new System.Drawing.Point(30, 62);
            this.ZoomStopCalculate.Name = "ZoomStopCalculate";
            this.ZoomStopCalculate.Size = new System.Drawing.Size(75, 23);
            this.ZoomStopCalculate.TabIndex = 21;
            this.ZoomStopCalculate.Text = "Calculate";
            this.ZoomStopCalculate.UseVisualStyleBackColor = true;
            this.ZoomStopCalculate.Click += new System.EventHandler(this.ZoomStopCalculate_Click);
            // 
            // ZoomStopOutputLabel
            // 
            this.ZoomStopOutputLabel.AutoSize = true;
            this.ZoomStopOutputLabel.Location = new System.Drawing.Point(150, 48);
            this.ZoomStopOutputLabel.Name = "ZoomStopOutputLabel";
            this.ZoomStopOutputLabel.Size = new System.Drawing.Size(194, 13);
            this.ZoomStopOutputLabel.TabIndex = 20;
            this.ZoomStopOutputLabel.Text = "Please select one of the above options!";
            // 
            // CalcSED
            // 
            this.CalcSED.AutoSize = true;
            this.CalcSED.Location = new System.Drawing.Point(7, 90);
            this.CalcSED.Name = "CalcSED";
            this.CalcSED.Size = new System.Drawing.Size(185, 17);
            this.CalcSED.TabIndex = 4;
            this.CalcSED.Text = "Calculate Second Event Distance";
            this.CalcSED.UseVisualStyleBackColor = true;
            this.CalcSED.CheckedChanged += new System.EventHandler(this.CalcSED_CheckedChanged);
            // 
            // CalcSET
            // 
            this.CalcSET.AutoSize = true;
            this.CalcSET.Location = new System.Drawing.Point(7, 67);
            this.CalcSET.Name = "CalcSET";
            this.CalcSET.Size = new System.Drawing.Size(166, 17);
            this.CalcSET.TabIndex = 3;
            this.CalcSET.Text = "Calculate Second Event Time";
            this.CalcSET.UseVisualStyleBackColor = true;
            this.CalcSET.CheckedChanged += new System.EventHandler(this.CalcSET_CheckedChanged);
            // 
            // CalcFED
            // 
            this.CalcFED.AutoSize = true;
            this.CalcFED.Location = new System.Drawing.Point(7, 44);
            this.CalcFED.Name = "CalcFED";
            this.CalcFED.Size = new System.Drawing.Size(167, 17);
            this.CalcFED.TabIndex = 2;
            this.CalcFED.Text = "Calculate First Event Distance";
            this.CalcFED.UseVisualStyleBackColor = true;
            this.CalcFED.CheckedChanged += new System.EventHandler(this.CalcFED_CheckedChanged);
            // 
            // CalcFET
            // 
            this.CalcFET.AutoSize = true;
            this.CalcFET.Enabled = false;
            this.CalcFET.Location = new System.Drawing.Point(7, 21);
            this.CalcFET.Name = "CalcFET";
            this.CalcFET.Size = new System.Drawing.Size(256, 17);
            this.CalcFET.TabIndex = 1;
            this.CalcFET.Text = "Calculate First Event Time (Not Implemented Yet)";
            this.CalcFET.UseVisualStyleBackColor = true;
            // 
            // ZoomStopDescription
            // 
            this.ZoomStopDescription.AutoSize = true;
            this.ZoomStopDescription.Location = new System.Drawing.Point(4, 4);
            this.ZoomStopDescription.Name = "ZoomStopDescription";
            this.ZoomStopDescription.Size = new System.Drawing.Size(500, 13);
            this.ZoomStopDescription.TabIndex = 0;
            this.ZoomStopDescription.Text = "This tool can calculate the timing or player distance of the events needed to mak" +
    "e a \"Zoom Stop\" effect.";
            // 
            // InputGroup
            // 
            this.InputGroup.Controls.Add(this.SecondEventDistanceBox);
            this.InputGroup.Controls.Add(this.SecondEventTimeBox);
            this.InputGroup.Controls.Add(this.FirstEventDistanceBox);
            this.InputGroup.Controls.Add(this.FirstEventTimeBox);
            this.InputGroup.Controls.Add(this.StartingDistanceBox);
            this.InputGroup.Controls.Add(this.label6);
            this.InputGroup.Controls.Add(this.label4);
            this.InputGroup.Controls.Add(this.label5);
            this.InputGroup.Controls.Add(this.label2);
            this.InputGroup.Controls.Add(this.label3);
            this.InputGroup.Location = new System.Drawing.Point(7, 122);
            this.InputGroup.Name = "InputGroup";
            this.InputGroup.Size = new System.Drawing.Size(431, 131);
            this.InputGroup.TabIndex = 15;
            this.InputGroup.TabStop = false;
            this.InputGroup.Text = "Input";
            // 
            // SecondEventDistanceBox
            // 
            this.SecondEventDistanceBox.DecimalPlaces = 3;
            this.SecondEventDistanceBox.Enabled = false;
            this.SecondEventDistanceBox.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SecondEventDistanceBox.Location = new System.Drawing.Point(298, 100);
            this.SecondEventDistanceBox.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.SecondEventDistanceBox.Name = "SecondEventDistanceBox";
            this.SecondEventDistanceBox.Size = new System.Drawing.Size(120, 20);
            this.SecondEventDistanceBox.TabIndex = 21;
            // 
            // SecondEventTimeBox
            // 
            this.SecondEventTimeBox.DecimalPlaces = 5;
            this.SecondEventTimeBox.Enabled = false;
            this.SecondEventTimeBox.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SecondEventTimeBox.Location = new System.Drawing.Point(295, 29);
            this.SecondEventTimeBox.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.SecondEventTimeBox.Name = "SecondEventTimeBox";
            this.SecondEventTimeBox.Size = new System.Drawing.Size(120, 20);
            this.SecondEventTimeBox.TabIndex = 20;
            // 
            // FirstEventDistanceBox
            // 
            this.FirstEventDistanceBox.DecimalPlaces = 3;
            this.FirstEventDistanceBox.Enabled = false;
            this.FirstEventDistanceBox.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.FirstEventDistanceBox.Location = new System.Drawing.Point(155, 100);
            this.FirstEventDistanceBox.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.FirstEventDistanceBox.Name = "FirstEventDistanceBox";
            this.FirstEventDistanceBox.Size = new System.Drawing.Size(120, 20);
            this.FirstEventDistanceBox.TabIndex = 19;
            // 
            // FirstEventTimeBox
            // 
            this.FirstEventTimeBox.DecimalPlaces = 5;
            this.FirstEventTimeBox.Enabled = false;
            this.FirstEventTimeBox.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.FirstEventTimeBox.Location = new System.Drawing.Point(155, 29);
            this.FirstEventTimeBox.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.FirstEventTimeBox.Name = "FirstEventTimeBox";
            this.FirstEventTimeBox.Size = new System.Drawing.Size(120, 20);
            this.FirstEventTimeBox.TabIndex = 18;
            // 
            // StartingDistanceBox
            // 
            this.StartingDistanceBox.DecimalPlaces = 3;
            this.StartingDistanceBox.Enabled = false;
            this.StartingDistanceBox.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.StartingDistanceBox.Location = new System.Drawing.Point(10, 62);
            this.StartingDistanceBox.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.StartingDistanceBox.Name = "StartingDistanceBox";
            this.StartingDistanceBox.Size = new System.Drawing.Size(120, 20);
            this.StartingDistanceBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Second Event Distance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "First Event Distance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Second Event Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Starting Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Event Time";
            // 
            // EventModifier
            // 
            this.EventModifier.Controls.Add(this.EventModifierPanel);
            this.EventModifier.Location = new System.Drawing.Point(4, 22);
            this.EventModifier.Name = "EventModifier";
            this.EventModifier.Padding = new System.Windows.Forms.Padding(3);
            this.EventModifier.Size = new System.Drawing.Size(927, 489);
            this.EventModifier.TabIndex = 2;
            this.EventModifier.Text = "Zoom Event Modifier";
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.linkLabel1);
            this.AboutTab.Controls.Add(this.label9);
            this.AboutTab.Controls.Add(this.label8);
            this.AboutTab.Controls.Add(this.label7);
            this.AboutTab.Location = new System.Drawing.Point(4, 22);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(927, 489);
            this.AboutTab.TabIndex = 1;
            this.AboutTab.Text = "About";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(7, 102);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Copyright (c) 2019 FlyingRabidUnicornPig";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Intralism Mapping Assistant 0.0.1";
            // 
            // EventModifierPanel
            // 
            this.EventModifierPanel.Controls.Add(this.ZoomModifierDescription);
            this.EventModifierPanel.Location = new System.Drawing.Point(7, 6);
            this.EventModifierPanel.Name = "EventModifierPanel";
            this.EventModifierPanel.Size = new System.Drawing.Size(914, 477);
            this.EventModifierPanel.TabIndex = 0;
            // 
            // ZoomModifierDescription
            // 
            this.ZoomModifierDescription.AutoSize = true;
            this.ZoomModifierDescription.Location = new System.Drawing.Point(4, 4);
            this.ZoomModifierDescription.Name = "ZoomModifierDescription";
            this.ZoomModifierDescription.Size = new System.Drawing.Size(35, 13);
            this.ZoomModifierDescription.TabIndex = 0;
            this.ZoomModifierDescription.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.ZoomStopTool);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Intralism Mapping Assistant";
            this.ZoomStopTool.ResumeLayout(false);
            this.ZoomStopTab.ResumeLayout(false);
            this.ZoomPanel.ResumeLayout(false);
            this.ZoomPanel.PerformLayout();
            this.AdvancedOptions.ResumeLayout(false);
            this.AdvancedOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomRangeZSCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomFrameRate)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.InputGroup.ResumeLayout(false);
            this.InputGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondEventDistanceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondEventTimeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstEventDistanceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstEventTimeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingDistanceBox)).EndInit();
            this.EventModifier.ResumeLayout(false);
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
            this.EventModifierPanel.ResumeLayout(false);
            this.EventModifierPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ZoomStopTool;
        private System.Windows.Forms.TabPage AboutTab;
        private System.Windows.Forms.TabPage ZoomStopTab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip CustomFRToolTip;
        private System.Windows.Forms.Panel ZoomPanel;
        private System.Windows.Forms.GroupBox AdvancedOptions;
        private System.Windows.Forms.CheckBox AdvancedCustomRangeCalc;
        private System.Windows.Forms.NumericUpDown CustomFrameRate;
        private System.Windows.Forms.CheckBox AdvancedFrameRateCalc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button ZoomStopCalculate;
        private System.Windows.Forms.Label ZoomStopOutputLabel;
        private System.Windows.Forms.RadioButton CalcSED;
        private System.Windows.Forms.RadioButton CalcSET;
        private System.Windows.Forms.RadioButton CalcFED;
        private System.Windows.Forms.RadioButton CalcFET;
        private System.Windows.Forms.Label ZoomStopDescription;
        private System.Windows.Forms.GroupBox InputGroup;
        private System.Windows.Forms.NumericUpDown SecondEventDistanceBox;
        private System.Windows.Forms.NumericUpDown SecondEventTimeBox;
        private System.Windows.Forms.NumericUpDown FirstEventDistanceBox;
        private System.Windows.Forms.NumericUpDown FirstEventTimeBox;
        private System.Windows.Forms.NumericUpDown StartingDistanceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage EventModifier;
        private System.Windows.Forms.NumericUpDown CustomRangeZSCalc;
        private System.Windows.Forms.ToolTip CustomRangeToolTip;
        private System.Windows.Forms.Panel EventModifierPanel;
        private System.Windows.Forms.Label ZoomModifierDescription;
    }
}