namespace Circles
{
    partial class Main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.UstawieniaLabel = new System.Windows.Forms.Label();
            this.V1S2ReverseLable = new System.Windows.Forms.Label();
            this.V2S3ReverseLable = new System.Windows.Forms.Label();
            this.V2S3Label = new System.Windows.Forms.Label();
            this.V1S2Label = new System.Windows.Forms.Label();
            this.R3S3Label = new System.Windows.Forms.Label();
            this.R1S1Label = new System.Windows.Forms.Label();
            this.R2S2Label = new System.Windows.Forms.Label();
            this.CDS2RightLabel = new System.Windows.Forms.Label();
            this.CDS2LeftLabel = new System.Windows.Forms.Label();
            this.CDS3RightLabel = new System.Windows.Forms.Label();
            this.CDS3LeftLabel = new System.Windows.Forms.Label();
            this.RadiusO3PlusButton = new System.Windows.Forms.Button();
            this.RadiusO3MinusButton = new System.Windows.Forms.Button();
            this.RadiusO2PlusButton = new System.Windows.Forms.Button();
            this.RadiusO2MinusButton = new System.Windows.Forms.Button();
            this.RadiusO1PlusButton = new System.Windows.Forms.Button();
            this.RadiusO1MinusButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ChengeDirectionS3checkBox = new System.Windows.Forms.CheckBox();
            this.V2PlusButton = new System.Windows.Forms.Button();
            this.V2MinusButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChengeDirectionS2checkBox = new System.Windows.Forms.CheckBox();
            this.V1PlusButton = new System.Windows.Forms.Button();
            this.V1MinusButton = new System.Windows.Forms.Button();
            this.V1label = new System.Windows.Forms.Label();
            this.V3P3ReverseLable = new System.Windows.Forms.Label();
            this.V3P3Label = new System.Windows.Forms.Label();
            this.CDP3RightLabel = new System.Windows.Forms.Label();
            this.CDP3LeftLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ChengeDirectionP3checkBox = new System.Windows.Forms.CheckBox();
            this.V3PlusButton = new System.Windows.Forms.Button();
            this.V3MinusButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ShowPathS2CheckBox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ShowPathS3CheckBox = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ShowS1CheckBox = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ShowCirclesO1CheckBox = new System.Windows.Forms.CheckBox();
            this.ShowCirclesO2CheckBox = new System.Windows.Forms.CheckBox();
            this.ShowCirclesO3CheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(389, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1380, 960);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCircels_Paint);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartButton.Location = new System.Drawing.Point(12, 11);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(178, 50);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StopButton.Location = new System.Drawing.Point(205, 12);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(178, 50);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Aqua;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResetButton.Location = new System.Drawing.Point(13, 68);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(370, 67);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // UstawieniaLabel
            // 
            this.UstawieniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UstawieniaLabel.ForeColor = System.Drawing.Color.Black;
            this.UstawieniaLabel.Location = new System.Drawing.Point(14, 148);
            this.UstawieniaLabel.Name = "UstawieniaLabel";
            this.UstawieniaLabel.Size = new System.Drawing.Size(370, 78);
            this.UstawieniaLabel.TabIndex = 14;
            this.UstawieniaLabel.Text = "Ustawienia\r\nParametrów\r\n";
            this.UstawieniaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // V1S2ReverseLable
            // 
            this.V1S2ReverseLable.BackColor = System.Drawing.Color.Transparent;
            this.V1S2ReverseLable.ForeColor = System.Drawing.Color.Green;
            this.V1S2ReverseLable.Location = new System.Drawing.Point(303, 496);
            this.V1S2ReverseLable.Name = "V1S2ReverseLable";
            this.V1S2ReverseLable.Size = new System.Drawing.Size(36, 30);
            this.V1S2ReverseLable.TabIndex = 95;
            this.V1S2ReverseLable.Text = "-1";
            this.V1S2ReverseLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.V1S2ReverseLable.Visible = false;
            // 
            // V2S3ReverseLable
            // 
            this.V2S3ReverseLable.BackColor = System.Drawing.Color.Transparent;
            this.V2S3ReverseLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.V2S3ReverseLable.Location = new System.Drawing.Point(303, 739);
            this.V2S3ReverseLable.Name = "V2S3ReverseLable";
            this.V2S3ReverseLable.Size = new System.Drawing.Size(36, 30);
            this.V2S3ReverseLable.TabIndex = 94;
            this.V2S3ReverseLable.Text = "-1";
            this.V2S3ReverseLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.V2S3ReverseLable.Visible = false;
            // 
            // V2S3Label
            // 
            this.V2S3Label.BackColor = System.Drawing.Color.Transparent;
            this.V2S3Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.V2S3Label.Location = new System.Drawing.Point(303, 739);
            this.V2S3Label.Name = "V2S3Label";
            this.V2S3Label.Size = new System.Drawing.Size(36, 30);
            this.V2S3Label.TabIndex = 93;
            this.V2S3Label.Text = "1";
            this.V2S3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // V1S2Label
            // 
            this.V1S2Label.BackColor = System.Drawing.Color.Transparent;
            this.V1S2Label.ForeColor = System.Drawing.Color.Green;
            this.V1S2Label.Location = new System.Drawing.Point(303, 496);
            this.V1S2Label.Name = "V1S2Label";
            this.V1S2Label.Size = new System.Drawing.Size(36, 30);
            this.V1S2Label.TabIndex = 92;
            this.V1S2Label.Text = "1";
            this.V1S2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // R3S3Label
            // 
            this.R3S3Label.BackColor = System.Drawing.Color.Transparent;
            this.R3S3Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.R3S3Label.Location = new System.Drawing.Point(303, 688);
            this.R3S3Label.Name = "R3S3Label";
            this.R3S3Label.Size = new System.Drawing.Size(36, 30);
            this.R3S3Label.TabIndex = 91;
            this.R3S3Label.Text = "30";
            this.R3S3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // R1S1Label
            // 
            this.R1S1Label.BackColor = System.Drawing.Color.Transparent;
            this.R1S1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.R1S1Label.Location = new System.Drawing.Point(303, 321);
            this.R1S1Label.Name = "R1S1Label";
            this.R1S1Label.Size = new System.Drawing.Size(36, 30);
            this.R1S1Label.TabIndex = 90;
            this.R1S1Label.Text = "100";
            this.R1S1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // R2S2Label
            // 
            this.R2S2Label.BackColor = System.Drawing.Color.Transparent;
            this.R2S2Label.ForeColor = System.Drawing.Color.Green;
            this.R2S2Label.Location = new System.Drawing.Point(303, 448);
            this.R2S2Label.Name = "R2S2Label";
            this.R2S2Label.Size = new System.Drawing.Size(36, 30);
            this.R2S2Label.TabIndex = 89;
            this.R2S2Label.Text = "50";
            this.R2S2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CDS2RightLabel
            // 
            this.CDS2RightLabel.BackColor = System.Drawing.Color.Transparent;
            this.CDS2RightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CDS2RightLabel.ForeColor = System.Drawing.Color.Green;
            this.CDS2RightLabel.Location = new System.Drawing.Point(341, 539);
            this.CDS2RightLabel.Name = "CDS2RightLabel";
            this.CDS2RightLabel.Size = new System.Drawing.Size(39, 32);
            this.CDS2RightLabel.TabIndex = 88;
            this.CDS2RightLabel.Text = "--->";
            this.CDS2RightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CDS2LeftLabel
            // 
            this.CDS2LeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.CDS2LeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CDS2LeftLabel.ForeColor = System.Drawing.Color.Green;
            this.CDS2LeftLabel.Location = new System.Drawing.Point(257, 539);
            this.CDS2LeftLabel.Name = "CDS2LeftLabel";
            this.CDS2LeftLabel.Size = new System.Drawing.Size(39, 32);
            this.CDS2LeftLabel.TabIndex = 87;
            this.CDS2LeftLabel.Text = "<---";
            this.CDS2LeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CDS2LeftLabel.Visible = false;
            // 
            // CDS3RightLabel
            // 
            this.CDS3RightLabel.BackColor = System.Drawing.Color.Transparent;
            this.CDS3RightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CDS3RightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CDS3RightLabel.Location = new System.Drawing.Point(341, 777);
            this.CDS3RightLabel.Name = "CDS3RightLabel";
            this.CDS3RightLabel.Size = new System.Drawing.Size(39, 32);
            this.CDS3RightLabel.TabIndex = 86;
            this.CDS3RightLabel.Text = "--->";
            this.CDS3RightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CDS3LeftLabel
            // 
            this.CDS3LeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.CDS3LeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CDS3LeftLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CDS3LeftLabel.Location = new System.Drawing.Point(258, 777);
            this.CDS3LeftLabel.Name = "CDS3LeftLabel";
            this.CDS3LeftLabel.Size = new System.Drawing.Size(39, 32);
            this.CDS3LeftLabel.TabIndex = 85;
            this.CDS3LeftLabel.Text = "<---";
            this.CDS3LeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CDS3LeftLabel.Visible = false;
            // 
            // RadiusO3PlusButton
            // 
            this.RadiusO3PlusButton.Location = new System.Drawing.Point(344, 688);
            this.RadiusO3PlusButton.Name = "RadiusO3PlusButton";
            this.RadiusO3PlusButton.Size = new System.Drawing.Size(39, 30);
            this.RadiusO3PlusButton.TabIndex = 83;
            this.RadiusO3PlusButton.Text = "+10";
            this.RadiusO3PlusButton.UseVisualStyleBackColor = true;
            this.RadiusO3PlusButton.Click += new System.EventHandler(this.RadiusO3PlusButton_Click);
            // 
            // RadiusO3MinusButton
            // 
            this.RadiusO3MinusButton.Location = new System.Drawing.Point(261, 688);
            this.RadiusO3MinusButton.Name = "RadiusO3MinusButton";
            this.RadiusO3MinusButton.Size = new System.Drawing.Size(36, 30);
            this.RadiusO3MinusButton.TabIndex = 84;
            this.RadiusO3MinusButton.Text = "-10";
            this.RadiusO3MinusButton.UseVisualStyleBackColor = true;
            this.RadiusO3MinusButton.Click += new System.EventHandler(this.RadiusO3MinusButton_Click);
            // 
            // RadiusO2PlusButton
            // 
            this.RadiusO2PlusButton.Location = new System.Drawing.Point(344, 448);
            this.RadiusO2PlusButton.Name = "RadiusO2PlusButton";
            this.RadiusO2PlusButton.Size = new System.Drawing.Size(39, 30);
            this.RadiusO2PlusButton.TabIndex = 81;
            this.RadiusO2PlusButton.Text = "+10";
            this.RadiusO2PlusButton.UseVisualStyleBackColor = true;
            this.RadiusO2PlusButton.Click += new System.EventHandler(this.RadiusO2PlusButton_Click);
            // 
            // RadiusO2MinusButton
            // 
            this.RadiusO2MinusButton.Location = new System.Drawing.Point(261, 448);
            this.RadiusO2MinusButton.Name = "RadiusO2MinusButton";
            this.RadiusO2MinusButton.Size = new System.Drawing.Size(36, 30);
            this.RadiusO2MinusButton.TabIndex = 82;
            this.RadiusO2MinusButton.Text = "-10";
            this.RadiusO2MinusButton.UseVisualStyleBackColor = true;
            this.RadiusO2MinusButton.Click += new System.EventHandler(this.RadiusO2MinusButton_Click);
            // 
            // RadiusO1PlusButton
            // 
            this.RadiusO1PlusButton.Location = new System.Drawing.Point(345, 321);
            this.RadiusO1PlusButton.Name = "RadiusO1PlusButton";
            this.RadiusO1PlusButton.Size = new System.Drawing.Size(39, 30);
            this.RadiusO1PlusButton.TabIndex = 79;
            this.RadiusO1PlusButton.Text = "+10";
            this.RadiusO1PlusButton.UseVisualStyleBackColor = true;
            this.RadiusO1PlusButton.Click += new System.EventHandler(this.RadiusO1PlusButton_Click_1);
            // 
            // RadiusO1MinusButton
            // 
            this.RadiusO1MinusButton.Location = new System.Drawing.Point(260, 321);
            this.RadiusO1MinusButton.Name = "RadiusO1MinusButton";
            this.RadiusO1MinusButton.Size = new System.Drawing.Size(36, 30);
            this.RadiusO1MinusButton.TabIndex = 80;
            this.RadiusO1MinusButton.Text = "-10";
            this.RadiusO1MinusButton.UseVisualStyleBackColor = true;
            this.RadiusO1MinusButton.Click += new System.EventHandler(this.RadiusO1MinusButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(16, 789);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 78;
            this.label6.Text = "Zmiana kierunku";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(16, 692);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 77;
            this.label7.Text = "Promień";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(157, 644);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 76;
            this.label8.Text = "Okrąg O3";
            // 
            // ChengeDirectionS3checkBox
            // 
            this.ChengeDirectionS3checkBox.AutoSize = true;
            this.ChengeDirectionS3checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ChengeDirectionS3checkBox.Location = new System.Drawing.Point(315, 787);
            this.ChengeDirectionS3checkBox.Name = "ChengeDirectionS3checkBox";
            this.ChengeDirectionS3checkBox.Size = new System.Drawing.Size(15, 14);
            this.ChengeDirectionS3checkBox.TabIndex = 75;
            this.ChengeDirectionS3checkBox.UseVisualStyleBackColor = true;
            this.ChengeDirectionS3checkBox.CheckedChanged += new System.EventHandler(this.ChengeDirectionS3checkBox_CheckedChanged);
            // 
            // V2PlusButton
            // 
            this.V2PlusButton.Location = new System.Drawing.Point(345, 739);
            this.V2PlusButton.Name = "V2PlusButton";
            this.V2PlusButton.Size = new System.Drawing.Size(39, 30);
            this.V2PlusButton.TabIndex = 73;
            this.V2PlusButton.Text = "+1";
            this.V2PlusButton.UseVisualStyleBackColor = true;
            this.V2PlusButton.Click += new System.EventHandler(this.V2PlusButton_Click);
            // 
            // V2MinusButton
            // 
            this.V2MinusButton.Location = new System.Drawing.Point(261, 739);
            this.V2MinusButton.Name = "V2MinusButton";
            this.V2MinusButton.Size = new System.Drawing.Size(36, 30);
            this.V2MinusButton.TabIndex = 74;
            this.V2MinusButton.Text = "-1";
            this.V2MinusButton.UseVisualStyleBackColor = true;
            this.V2MinusButton.Click += new System.EventHandler(this.V2MinusButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(16, 743);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 72;
            this.label9.Text = "Prędkość";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(16, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Zmiana kierunku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(16, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Promień";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Promień";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(157, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Okrąg O2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(157, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Okrąg O1";
            // 
            // ChengeDirectionS2checkBox
            // 
            this.ChengeDirectionS2checkBox.AutoSize = true;
            this.ChengeDirectionS2checkBox.ForeColor = System.Drawing.Color.Green;
            this.ChengeDirectionS2checkBox.Location = new System.Drawing.Point(315, 549);
            this.ChengeDirectionS2checkBox.Name = "ChengeDirectionS2checkBox";
            this.ChengeDirectionS2checkBox.Size = new System.Drawing.Size(15, 14);
            this.ChengeDirectionS2checkBox.TabIndex = 66;
            this.ChengeDirectionS2checkBox.UseVisualStyleBackColor = true;
            this.ChengeDirectionS2checkBox.CheckedChanged += new System.EventHandler(this.ChengeDirectionS2checkBox_CheckedChanged);
            // 
            // V1PlusButton
            // 
            this.V1PlusButton.Location = new System.Drawing.Point(344, 496);
            this.V1PlusButton.Name = "V1PlusButton";
            this.V1PlusButton.Size = new System.Drawing.Size(39, 30);
            this.V1PlusButton.TabIndex = 64;
            this.V1PlusButton.Text = "+1";
            this.V1PlusButton.UseVisualStyleBackColor = true;
            this.V1PlusButton.Click += new System.EventHandler(this.V1PlusButton_Click);
            // 
            // V1MinusButton
            // 
            this.V1MinusButton.Location = new System.Drawing.Point(260, 496);
            this.V1MinusButton.Name = "V1MinusButton";
            this.V1MinusButton.Size = new System.Drawing.Size(36, 30);
            this.V1MinusButton.TabIndex = 65;
            this.V1MinusButton.Text = "-1";
            this.V1MinusButton.UseVisualStyleBackColor = true;
            this.V1MinusButton.Click += new System.EventHandler(this.V1MinusButton_Click);
            // 
            // V1label
            // 
            this.V1label.AutoSize = true;
            this.V1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.V1label.ForeColor = System.Drawing.Color.Green;
            this.V1label.Location = new System.Drawing.Point(16, 500);
            this.V1label.Name = "V1label";
            this.V1label.Size = new System.Drawing.Size(83, 20);
            this.V1label.TabIndex = 63;
            this.V1label.Text = "Prędkość";
            // 
            // V3P3ReverseLable
            // 
            this.V3P3ReverseLable.BackColor = System.Drawing.Color.Transparent;
            this.V3P3ReverseLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.V3P3ReverseLable.Location = new System.Drawing.Point(303, 910);
            this.V3P3ReverseLable.Name = "V3P3ReverseLable";
            this.V3P3ReverseLable.Size = new System.Drawing.Size(36, 30);
            this.V3P3ReverseLable.TabIndex = 105;
            this.V3P3ReverseLable.Text = "-1";
            this.V3P3ReverseLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.V3P3ReverseLable.Visible = false;
            // 
            // V3P3Label
            // 
            this.V3P3Label.BackColor = System.Drawing.Color.Transparent;
            this.V3P3Label.ForeColor = System.Drawing.Color.Magenta;
            this.V3P3Label.Location = new System.Drawing.Point(302, 910);
            this.V3P3Label.Name = "V3P3Label";
            this.V3P3Label.Size = new System.Drawing.Size(36, 30);
            this.V3P3Label.TabIndex = 104;
            this.V3P3Label.Text = "1";
            this.V3P3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CDP3RightLabel
            // 
            this.CDP3RightLabel.BackColor = System.Drawing.Color.Transparent;
            this.CDP3RightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CDP3RightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CDP3RightLabel.Location = new System.Drawing.Point(344, 943);
            this.CDP3RightLabel.Name = "CDP3RightLabel";
            this.CDP3RightLabel.Size = new System.Drawing.Size(39, 32);
            this.CDP3RightLabel.TabIndex = 103;
            this.CDP3RightLabel.Text = "--->";
            this.CDP3RightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CDP3LeftLabel
            // 
            this.CDP3LeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.CDP3LeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CDP3LeftLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CDP3LeftLabel.Location = new System.Drawing.Point(258, 943);
            this.CDP3LeftLabel.Name = "CDP3LeftLabel";
            this.CDP3LeftLabel.Size = new System.Drawing.Size(39, 32);
            this.CDP3LeftLabel.TabIndex = 102;
            this.CDP3LeftLabel.Text = "<---";
            this.CDP3LeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CDP3LeftLabel.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.Magenta;
            this.label12.Location = new System.Drawing.Point(16, 948);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 20);
            this.label12.TabIndex = 101;
            this.label12.Text = "Zmiana kierunku";
            // 
            // ChengeDirectionP3checkBox
            // 
            this.ChengeDirectionP3checkBox.AutoSize = true;
            this.ChengeDirectionP3checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ChengeDirectionP3checkBox.Location = new System.Drawing.Point(315, 954);
            this.ChengeDirectionP3checkBox.Name = "ChengeDirectionP3checkBox";
            this.ChengeDirectionP3checkBox.Size = new System.Drawing.Size(15, 14);
            this.ChengeDirectionP3checkBox.TabIndex = 100;
            this.ChengeDirectionP3checkBox.UseVisualStyleBackColor = true;
            this.ChengeDirectionP3checkBox.CheckedChanged += new System.EventHandler(this.ChengeDirectionP3checkBox_CheckedChanged);
            // 
            // V3PlusButton
            // 
            this.V3PlusButton.Location = new System.Drawing.Point(344, 910);
            this.V3PlusButton.Name = "V3PlusButton";
            this.V3PlusButton.Size = new System.Drawing.Size(39, 30);
            this.V3PlusButton.TabIndex = 98;
            this.V3PlusButton.Text = "+1";
            this.V3PlusButton.UseVisualStyleBackColor = true;
            this.V3PlusButton.Click += new System.EventHandler(this.V3PlusButton_Click);
            // 
            // V3MinusButton
            // 
            this.V3MinusButton.Location = new System.Drawing.Point(261, 910);
            this.V3MinusButton.Name = "V3MinusButton";
            this.V3MinusButton.Size = new System.Drawing.Size(36, 30);
            this.V3MinusButton.TabIndex = 99;
            this.V3MinusButton.Text = "-1";
            this.V3MinusButton.UseVisualStyleBackColor = true;
            this.V3MinusButton.Click += new System.EventHandler(this.V3MinusButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Magenta;
            this.label11.Location = new System.Drawing.Point(16, 914);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 97;
            this.label11.Text = "Prędkość";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Magenta;
            this.label10.Location = new System.Drawing.Point(161, 874);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 96;
            this.label10.Text = "Punkt P3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(16, 589);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 20);
            this.label13.TabIndex = 106;
            this.label13.Text = "Pokaż ścieżkę i punkt S2";
            // 
            // ShowPathS2CheckBox
            // 
            this.ShowPathS2CheckBox.AutoSize = true;
            this.ShowPathS2CheckBox.ForeColor = System.Drawing.Color.Green;
            this.ShowPathS2CheckBox.Location = new System.Drawing.Point(315, 595);
            this.ShowPathS2CheckBox.Name = "ShowPathS2CheckBox";
            this.ShowPathS2CheckBox.Size = new System.Drawing.Size(15, 14);
            this.ShowPathS2CheckBox.TabIndex = 107;
            this.ShowPathS2CheckBox.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(16, 829);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(209, 20);
            this.label14.TabIndex = 108;
            this.label14.Text = "Pokaż ścieżkę i punkt S3";
            // 
            // ShowPathS3CheckBox
            // 
            this.ShowPathS3CheckBox.AutoSize = true;
            this.ShowPathS3CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ShowPathS3CheckBox.Location = new System.Drawing.Point(315, 834);
            this.ShowPathS3CheckBox.Name = "ShowPathS3CheckBox";
            this.ShowPathS3CheckBox.Size = new System.Drawing.Size(15, 14);
            this.ShowPathS3CheckBox.TabIndex = 109;
            this.ShowPathS3CheckBox.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(12, 368);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 20);
            this.label15.TabIndex = 110;
            this.label15.Text = "Pokaż punkt S1";
            // 
            // ShowS1CheckBox
            // 
            this.ShowS1CheckBox.AutoSize = true;
            this.ShowS1CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ShowS1CheckBox.Location = new System.Drawing.Point(315, 374);
            this.ShowS1CheckBox.Name = "ShowS1CheckBox";
            this.ShowS1CheckBox.Size = new System.Drawing.Size(15, 14);
            this.ShowS1CheckBox.TabIndex = 111;
            this.ShowS1CheckBox.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(16, 241);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(206, 20);
            this.label16.TabIndex = 112;
            this.label16.Text = "Pokaż okręgi O1, O2, O3";
            // 
            // ShowCirclesO1CheckBox
            // 
            this.ShowCirclesO1CheckBox.AutoSize = true;
            this.ShowCirclesO1CheckBox.ForeColor = System.Drawing.Color.Black;
            this.ShowCirclesO1CheckBox.Location = new System.Drawing.Point(272, 247);
            this.ShowCirclesO1CheckBox.Name = "ShowCirclesO1CheckBox";
            this.ShowCirclesO1CheckBox.Size = new System.Drawing.Size(15, 14);
            this.ShowCirclesO1CheckBox.TabIndex = 113;
            this.ShowCirclesO1CheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowCirclesO2CheckBox
            // 
            this.ShowCirclesO2CheckBox.AutoSize = true;
            this.ShowCirclesO2CheckBox.ForeColor = System.Drawing.Color.Black;
            this.ShowCirclesO2CheckBox.Location = new System.Drawing.Point(315, 247);
            this.ShowCirclesO2CheckBox.Name = "ShowCirclesO2CheckBox";
            this.ShowCirclesO2CheckBox.Size = new System.Drawing.Size(15, 14);
            this.ShowCirclesO2CheckBox.TabIndex = 114;
            this.ShowCirclesO2CheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowCirclesO3CheckBox
            // 
            this.ShowCirclesO3CheckBox.AutoSize = true;
            this.ShowCirclesO3CheckBox.ForeColor = System.Drawing.Color.Black;
            this.ShowCirclesO3CheckBox.Location = new System.Drawing.Point(356, 247);
            this.ShowCirclesO3CheckBox.Name = "ShowCirclesO3CheckBox";
            this.ShowCirclesO3CheckBox.Size = new System.Drawing.Size(15, 14);
            this.ShowCirclesO3CheckBox.TabIndex = 115;
            this.ShowCirclesO3CheckBox.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1784, 982);
            this.Controls.Add(this.ShowCirclesO3CheckBox);
            this.Controls.Add(this.ShowCirclesO2CheckBox);
            this.Controls.Add(this.ShowCirclesO1CheckBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ShowS1CheckBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ShowPathS3CheckBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ShowPathS2CheckBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.V3P3ReverseLable);
            this.Controls.Add(this.V3P3Label);
            this.Controls.Add(this.CDP3RightLabel);
            this.Controls.Add(this.CDP3LeftLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ChengeDirectionP3checkBox);
            this.Controls.Add(this.V3PlusButton);
            this.Controls.Add(this.V3MinusButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.V1S2ReverseLable);
            this.Controls.Add(this.V2S3ReverseLable);
            this.Controls.Add(this.V2S3Label);
            this.Controls.Add(this.V1S2Label);
            this.Controls.Add(this.R3S3Label);
            this.Controls.Add(this.R1S1Label);
            this.Controls.Add(this.R2S2Label);
            this.Controls.Add(this.CDS2RightLabel);
            this.Controls.Add(this.CDS2LeftLabel);
            this.Controls.Add(this.CDS3RightLabel);
            this.Controls.Add(this.CDS3LeftLabel);
            this.Controls.Add(this.RadiusO3PlusButton);
            this.Controls.Add(this.RadiusO3MinusButton);
            this.Controls.Add(this.RadiusO2PlusButton);
            this.Controls.Add(this.RadiusO2MinusButton);
            this.Controls.Add(this.RadiusO1PlusButton);
            this.Controls.Add(this.RadiusO1MinusButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ChengeDirectionS3checkBox);
            this.Controls.Add(this.V2PlusButton);
            this.Controls.Add(this.V2MinusButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChengeDirectionS2checkBox);
            this.Controls.Add(this.V1PlusButton);
            this.Controls.Add(this.V1MinusButton);
            this.Controls.Add(this.V1label);
            this.Controls.Add(this.UstawieniaLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Main";
            this.Text = "Circles";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label UstawieniaLabel;
        private System.Windows.Forms.Label V1S2ReverseLable;
        private System.Windows.Forms.Label V2S3ReverseLable;
        private System.Windows.Forms.Label V2S3Label;
        private System.Windows.Forms.Label V1S2Label;
        private System.Windows.Forms.Label R3S3Label;
        private System.Windows.Forms.Label R1S1Label;
        private System.Windows.Forms.Label R2S2Label;
        private System.Windows.Forms.Label CDS2RightLabel;
        private System.Windows.Forms.Label CDS2LeftLabel;
        private System.Windows.Forms.Label CDS3RightLabel;
        private System.Windows.Forms.Label CDS3LeftLabel;
        private System.Windows.Forms.Button RadiusO3PlusButton;
        private System.Windows.Forms.Button RadiusO3MinusButton;
        private System.Windows.Forms.Button RadiusO2PlusButton;
        private System.Windows.Forms.Button RadiusO2MinusButton;
        private System.Windows.Forms.Button RadiusO1PlusButton;
        private System.Windows.Forms.Button RadiusO1MinusButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ChengeDirectionS3checkBox;
        private System.Windows.Forms.Button V2PlusButton;
        private System.Windows.Forms.Button V2MinusButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChengeDirectionS2checkBox;
        private System.Windows.Forms.Button V1PlusButton;
        private System.Windows.Forms.Button V1MinusButton;
        private System.Windows.Forms.Label V1label;
        private System.Windows.Forms.Label V3P3ReverseLable;
        private System.Windows.Forms.Label V3P3Label;
        private System.Windows.Forms.Label CDP3RightLabel;
        private System.Windows.Forms.Label CDP3LeftLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox ChengeDirectionP3checkBox;
        private System.Windows.Forms.Button V3PlusButton;
        private System.Windows.Forms.Button V3MinusButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox ShowPathS2CheckBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox ShowPathS3CheckBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox ShowS1CheckBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox ShowCirclesO1CheckBox;
        private System.Windows.Forms.CheckBox ShowCirclesO2CheckBox;
        private System.Windows.Forms.CheckBox ShowCirclesO3CheckBox;
    }
}

