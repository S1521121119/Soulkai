namespace 計算機
{
    partial class CCD_Calc
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CCD_Calc));
            this.lbl_SampleSize = new System.Windows.Forms.Label();
            this.lbl_SampleX = new System.Windows.Forms.Label();
            this.lbl_mm_1 = new System.Windows.Forms.Label();
            this.lbl_mm_2 = new System.Windows.Forms.Label();
            this.lbl_mm_3 = new System.Windows.Forms.Label();
            this.lbl_mm_4 = new System.Windows.Forms.Label();
            this.lbl_mm_5 = new System.Windows.Forms.Label();
            this.lbl_mm_6 = new System.Windows.Forms.Label();
            this.lbl_mm_7 = new System.Windows.Forms.Label();
            this.lbl_mm_8 = new System.Windows.Forms.Label();
            this.lbl_SampleY = new System.Windows.Forms.Label();
            this.txt_SampleX = new System.Windows.Forms.TextBox();
            this.txt_SampleY = new System.Windows.Forms.TextBox();
            this.lbl_CCDList = new System.Windows.Forms.Label();
            this.CCDList = new System.Windows.Forms.ComboBox();
            this.grp_InputArea = new System.Windows.Forms.GroupBox();
            this.lbl_SensorSize = new System.Windows.Forms.Label();
            this.lbl_CCDPIXEL = new System.Windows.Forms.Label();
            this.lbl_SensorSizeData = new System.Windows.Forms.Label();
            this.lbl_CCDPixelData = new System.Windows.Forms.Label();
            this.txt_SampleY_real = new System.Windows.Forms.TextBox();
            this.txt_FOVratio = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_saveCCDdata = new System.Windows.Forms.Button();
            this.txt_pixelHeight = new System.Windows.Forms.TextBox();
            this.lbl_x_2 = new System.Windows.Forms.Label();
            this.txt_SampleX_real = new System.Windows.Forms.TextBox();
            this.txt_pixelWidth = new System.Windows.Forms.TextBox();
            this.txt_camaraName = new System.Windows.Forms.TextBox();
            this.lbl_SampleY_real = new System.Windows.Forms.Label();
            this.lbl_um = new System.Windows.Forms.Label();
            this.lbl_SampleX_real = new System.Windows.Forms.Label();
            this.lbl_CCDUnitSIZE = new System.Windows.Forms.Label();
            this.txt_pixelSensorSize = new System.Windows.Forms.TextBox();
            this.lbl_FOVY = new System.Windows.Forms.Label();
            this.lbl_PixelResolution = new System.Windows.Forms.Label();
            this.lbl_InspectionResolution = new System.Windows.Forms.Label();
            this.txt_FOVX = new System.Windows.Forms.TextBox();
            this.lbl_mmperpixel_1 = new System.Windows.Forms.Label();
            this.lbl_mmperpixel_2 = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.txt_FOVY = new System.Windows.Forms.TextBox();
            this.txt_MagOPT = new System.Windows.Forms.TextBox();
            this.lbl_FOVX = new System.Windows.Forms.Label();
            this.txt_PixelResolution = new System.Windows.Forms.TextBox();
            this.txt_InspectionResolution = new System.Windows.Forms.TextBox();
            this.lbl_MagOPT = new System.Windows.Forms.Label();
            this.lbl_FOV = new System.Windows.Forms.Label();
            this.grp_OutArea = new System.Windows.Forms.GroupBox();
            this.trb_lens_focalLength = new System.Windows.Forms.TrackBar();
            this.trb_lens_wd = new System.Windows.Forms.TrackBar();
            this.lbl_lens_focallength = new System.Windows.Forms.Label();
            this.lbl_lens_wd = new System.Windows.Forms.Label();
            this.txt_lens_focallength = new System.Windows.Forms.TextBox();
            this.txt_lens_wd = new System.Windows.Forms.TextBox();
            this.txt_FOVratio_real = new System.Windows.Forms.TextBox();
            this.txt_InspectionResolutionRatio = new System.Windows.Forms.TextBox();
            this.pic_Calc = new System.Windows.Forms.PictureBox();
            this.lbl_Mode = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.lbl_Copystate = new System.Windows.Forms.Label();
            this.timer_Date = new System.Windows.Forms.Timer(this.components);
            this.lbl_date = new System.Windows.Forms.Label();
            this.pic_notepad = new System.Windows.Forms.PictureBox();
            this.Paint_Green = new System.Windows.Forms.TextBox();
            this.Paint_Red = new System.Windows.Forms.TextBox();
            this.Paint_Grey = new System.Windows.Forms.TextBox();
            this.lbl_ImageInfo = new System.Windows.Forms.Label();
            this.lbl_autor = new System.Windows.Forms.Label();
            this.btn_tip = new System.Windows.Forms.Button();
            this.timer_LockTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_bomb = new System.Windows.Forms.Label();
            this.grp_InputArea.SuspendLayout();
            this.grp_OutArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_lens_focalLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_lens_wd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Calc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_notepad)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SampleSize
            // 
            this.lbl_SampleSize.AutoSize = true;
            this.lbl_SampleSize.Location = new System.Drawing.Point(6, 18);
            this.lbl_SampleSize.Name = "lbl_SampleSize";
            this.lbl_SampleSize.Size = new System.Drawing.Size(53, 12);
            this.lbl_SampleSize.TabIndex = 0;
            this.lbl_SampleSize.Text = "樣品尺寸";
            // 
            // lbl_SampleX
            // 
            this.lbl_SampleX.AutoSize = true;
            this.lbl_SampleX.Location = new System.Drawing.Point(18, 36);
            this.lbl_SampleX.Name = "lbl_SampleX";
            this.lbl_SampleX.Size = new System.Drawing.Size(29, 12);
            this.lbl_SampleX.TabIndex = 0;
            this.lbl_SampleX.Text = "長：";
            // 
            // lbl_mm_1
            // 
            this.lbl_mm_1.AutoSize = true;
            this.lbl_mm_1.Location = new System.Drawing.Point(88, 36);
            this.lbl_mm_1.Name = "lbl_mm_1";
            this.lbl_mm_1.Size = new System.Drawing.Size(23, 12);
            this.lbl_mm_1.TabIndex = 0;
            this.lbl_mm_1.Text = "mm";
            // 
            // lbl_mm_2
            // 
            this.lbl_mm_2.AutoSize = true;
            this.lbl_mm_2.Location = new System.Drawing.Point(185, 36);
            this.lbl_mm_2.Name = "lbl_mm_2";
            this.lbl_mm_2.Size = new System.Drawing.Size(23, 12);
            this.lbl_mm_2.TabIndex = 0;
            this.lbl_mm_2.Text = "mm";
            // 
            // lbl_mm_3
            // 
            this.lbl_mm_3.AutoSize = true;
            this.lbl_mm_3.Location = new System.Drawing.Point(86, 36);
            this.lbl_mm_3.Name = "lbl_mm_3";
            this.lbl_mm_3.Size = new System.Drawing.Size(23, 12);
            this.lbl_mm_3.TabIndex = 0;
            this.lbl_mm_3.Text = "mm";
            // 
            // lbl_mm_4
            // 
            this.lbl_mm_4.AutoSize = true;
            this.lbl_mm_4.Location = new System.Drawing.Point(185, 36);
            this.lbl_mm_4.Name = "lbl_mm_4";
            this.lbl_mm_4.Size = new System.Drawing.Size(23, 12);
            this.lbl_mm_4.TabIndex = 0;
            this.lbl_mm_4.Text = "mm";
            // 
            // lbl_mm_5
            // 
            this.lbl_mm_5.AutoSize = true;
            this.lbl_mm_5.Location = new System.Drawing.Point(88, 64);
            this.lbl_mm_5.Name = "lbl_mm_5";
            this.lbl_mm_5.Size = new System.Drawing.Size(23, 12);
            this.lbl_mm_5.TabIndex = 0;
            this.lbl_mm_5.Text = "mm";
            // 
            // lbl_mm_6
            // 
            this.lbl_mm_6.AutoSize = true;
            this.lbl_mm_6.Location = new System.Drawing.Point(185, 64);
            this.lbl_mm_6.Name = "lbl_mm_6";
            this.lbl_mm_6.Size = new System.Drawing.Size(23, 12);
            this.lbl_mm_6.TabIndex = 0;
            this.lbl_mm_6.Text = "mm";
            // 
            // lbl_mm_7
            // 
            this.lbl_mm_7.AutoSize = true;
            this.lbl_mm_7.Location = new System.Drawing.Point(247, 231);
            this.lbl_mm_7.Name = "lbl_mm_7";
            this.lbl_mm_7.Size = new System.Drawing.Size(23, 12);
            this.lbl_mm_7.TabIndex = 10;
            this.lbl_mm_7.Text = "mm";
            // 
            // lbl_mm_8
            // 
            this.lbl_mm_8.AutoSize = true;
            this.lbl_mm_8.Location = new System.Drawing.Point(247, 192);
            this.lbl_mm_8.Name = "lbl_mm_8";
            this.lbl_mm_8.Size = new System.Drawing.Size(23, 12);
            this.lbl_mm_8.TabIndex = 9;
            this.lbl_mm_8.Text = "mm";
            // 
            // lbl_SampleY
            // 
            this.lbl_SampleY.AutoSize = true;
            this.lbl_SampleY.Location = new System.Drawing.Point(114, 36);
            this.lbl_SampleY.Name = "lbl_SampleY";
            this.lbl_SampleY.Size = new System.Drawing.Size(29, 12);
            this.lbl_SampleY.TabIndex = 0;
            this.lbl_SampleY.Text = "寬：";
            // 
            // txt_SampleX
            // 
            this.txt_SampleX.Location = new System.Drawing.Point(47, 31);
            this.txt_SampleX.Name = "txt_SampleX";
            this.txt_SampleX.Size = new System.Drawing.Size(42, 22);
            this.txt_SampleX.TabIndex = 0;
            this.txt_SampleX.Text = "7.04";
            this.txt_SampleX.Click += new System.EventHandler(this.SampleSizeSet_Click);
            this.txt_SampleX.TextChanged += new System.EventHandler(this.SampleCalc_Click);
            this.txt_SampleX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataInput);
            // 
            // txt_SampleY
            // 
            this.txt_SampleY.Location = new System.Drawing.Point(143, 31);
            this.txt_SampleY.Name = "txt_SampleY";
            this.txt_SampleY.Size = new System.Drawing.Size(42, 22);
            this.txt_SampleY.TabIndex = 1;
            this.txt_SampleY.Text = "5.28";
            this.txt_SampleY.Click += new System.EventHandler(this.SampleSizeSet_Click);
            this.txt_SampleY.TextChanged += new System.EventHandler(this.SampleCalc_Click);
            this.txt_SampleY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataInput);
            // 
            // lbl_CCDList
            // 
            this.lbl_CCDList.AutoSize = true;
            this.lbl_CCDList.Location = new System.Drawing.Point(18, 92);
            this.lbl_CCDList.Name = "lbl_CCDList";
            this.lbl_CCDList.Size = new System.Drawing.Size(41, 12);
            this.lbl_CCDList.TabIndex = 0;
            this.lbl_CCDList.Text = "CCD：";
            // 
            // CCDList
            // 
            this.CCDList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CCDList.FormattingEnabled = true;
            this.CCDList.Items.AddRange(new object[] {
            "48萬\t(1/3\")",
            "200萬\t(1/1.8\")",
            "500萬\t(2/3\")",
            "2100萬\t(4/3\")",
            "自訂"});
            this.CCDList.Location = new System.Drawing.Point(57, 89);
            this.CCDList.Name = "CCDList";
            this.CCDList.Size = new System.Drawing.Size(121, 20);
            this.CCDList.TabIndex = 5;
            this.toolTip1.SetToolTip(this.CCDList, "選擇CCD畫素");
            this.CCDList.SelectedIndexChanged += new System.EventHandler(this.CCD_SelectedIndexChanged);
            // 
            // grp_InputArea
            // 
            this.grp_InputArea.BackColor = System.Drawing.SystemColors.Control;
            this.grp_InputArea.Controls.Add(this.lbl_SensorSize);
            this.grp_InputArea.Controls.Add(this.lbl_CCDPIXEL);
            this.grp_InputArea.Controls.Add(this.lbl_SensorSizeData);
            this.grp_InputArea.Controls.Add(this.lbl_CCDPixelData);
            this.grp_InputArea.Controls.Add(this.CCDList);
            this.grp_InputArea.Controls.Add(this.lbl_CCDList);
            this.grp_InputArea.Controls.Add(this.txt_SampleY_real);
            this.grp_InputArea.Controls.Add(this.txt_FOVratio);
            this.grp_InputArea.Controls.Add(this.btn_delete);
            this.grp_InputArea.Controls.Add(this.btn_saveCCDdata);
            this.grp_InputArea.Controls.Add(this.txt_pixelHeight);
            this.grp_InputArea.Controls.Add(this.lbl_x_2);
            this.grp_InputArea.Controls.Add(this.txt_SampleY);
            this.grp_InputArea.Controls.Add(this.txt_SampleX_real);
            this.grp_InputArea.Controls.Add(this.txt_pixelWidth);
            this.grp_InputArea.Controls.Add(this.txt_camaraName);
            this.grp_InputArea.Controls.Add(this.txt_SampleX);
            this.grp_InputArea.Controls.Add(this.lbl_SampleY_real);
            this.grp_InputArea.Controls.Add(this.lbl_SampleY);
            this.grp_InputArea.Controls.Add(this.lbl_um);
            this.grp_InputArea.Controls.Add(this.lbl_mm_6);
            this.grp_InputArea.Controls.Add(this.lbl_mm_2);
            this.grp_InputArea.Controls.Add(this.lbl_mm_5);
            this.grp_InputArea.Controls.Add(this.lbl_mm_1);
            this.grp_InputArea.Controls.Add(this.lbl_SampleX_real);
            this.grp_InputArea.Controls.Add(this.lbl_SampleX);
            this.grp_InputArea.Controls.Add(this.lbl_SampleSize);
            this.grp_InputArea.Controls.Add(this.lbl_CCDUnitSIZE);
            this.grp_InputArea.Controls.Add(this.txt_pixelSensorSize);
            this.grp_InputArea.Location = new System.Drawing.Point(12, 12);
            this.grp_InputArea.Name = "grp_InputArea";
            this.grp_InputArea.Size = new System.Drawing.Size(293, 181);
            this.grp_InputArea.TabIndex = 0;
            this.grp_InputArea.TabStop = false;
            this.grp_InputArea.Text = "輸入區";
            this.grp_InputArea.TextChanged += new System.EventHandler(this.SampleCalc_Click);
            // 
            // lbl_SensorSize
            // 
            this.lbl_SensorSize.AutoSize = true;
            this.lbl_SensorSize.Location = new System.Drawing.Point(79, 149);
            this.lbl_SensorSize.Name = "lbl_SensorSize";
            this.lbl_SensorSize.Size = new System.Drawing.Size(28, 12);
            this.lbl_SensorSize.TabIndex = 7;
            this.lbl_SensorSize.Text = "none";
            // 
            // lbl_CCDPIXEL
            // 
            this.lbl_CCDPIXEL.AutoSize = true;
            this.lbl_CCDPIXEL.Location = new System.Drawing.Point(58, 120);
            this.lbl_CCDPIXEL.Name = "lbl_CCDPIXEL";
            this.lbl_CCDPIXEL.Size = new System.Drawing.Size(28, 12);
            this.lbl_CCDPIXEL.TabIndex = 6;
            this.lbl_CCDPIXEL.Text = "none";
            // 
            // lbl_SensorSizeData
            // 
            this.lbl_SensorSizeData.AutoSize = true;
            this.lbl_SensorSizeData.Location = new System.Drawing.Point(18, 148);
            this.lbl_SensorSizeData.Name = "lbl_SensorSizeData";
            this.lbl_SensorSizeData.Size = new System.Drawing.Size(61, 12);
            this.lbl_SensorSizeData.TabIndex = 5;
            this.lbl_SensorSizeData.Text = "Sensor Size:";
            // 
            // lbl_CCDPixelData
            // 
            this.lbl_CCDPixelData.AutoSize = true;
            this.lbl_CCDPixelData.Location = new System.Drawing.Point(18, 120);
            this.lbl_CCDPixelData.Name = "lbl_CCDPixelData";
            this.lbl_CCDPixelData.Size = new System.Drawing.Size(31, 12);
            this.lbl_CCDPixelData.TabIndex = 4;
            this.lbl_CCDPixelData.Text = "Pixel:";
            // 
            // txt_SampleY_real
            // 
            this.txt_SampleY_real.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SampleY_real.Location = new System.Drawing.Point(146, 63);
            this.txt_SampleY_real.Name = "txt_SampleY_real";
            this.txt_SampleY_real.ReadOnly = true;
            this.txt_SampleY_real.Size = new System.Drawing.Size(36, 15);
            this.txt_SampleY_real.TabIndex = 4;
            this.txt_SampleY_real.TabStop = false;
            this.txt_SampleY_real.Text = "5.28";
            this.txt_SampleY_real.Click += new System.EventHandler(this.SampleSizeSet_Click);
            this.txt_SampleY_real.TextChanged += new System.EventHandler(this.SampleCalc_Click);
            // 
            // txt_FOVratio
            // 
            this.txt_FOVratio.Location = new System.Drawing.Point(214, 31);
            this.txt_FOVratio.Name = "txt_FOVratio";
            this.txt_FOVratio.Size = new System.Drawing.Size(42, 22);
            this.txt_FOVratio.TabIndex = 2;
            this.txt_FOVratio.Text = "1.3";
            this.txt_FOVratio.Click += new System.EventHandler(this.SampleSizeSet_Click);
            this.txt_FOVratio.TextChanged += new System.EventHandler(this.SampleCalc_Click);
            this.txt_FOVratio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataInput);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(187, 87);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(23, 23);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "刪";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_saveCCDdata
            // 
            this.btn_saveCCDdata.Location = new System.Drawing.Point(262, 87);
            this.btn_saveCCDdata.Name = "btn_saveCCDdata";
            this.btn_saveCCDdata.Size = new System.Drawing.Size(23, 23);
            this.btn_saveCCDdata.TabIndex = 7;
            this.btn_saveCCDdata.Text = "存";
            this.btn_saveCCDdata.UseVisualStyleBackColor = true;
            this.btn_saveCCDdata.Visible = false;
            this.btn_saveCCDdata.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_pixelHeight
            // 
            this.txt_pixelHeight.Location = new System.Drawing.Point(108, 117);
            this.txt_pixelHeight.Name = "txt_pixelHeight";
            this.txt_pixelHeight.Size = new System.Drawing.Size(38, 22);
            this.txt_pixelHeight.TabIndex = 8;
            this.txt_pixelHeight.Text = "1200";
            this.txt_pixelHeight.Visible = false;
            this.txt_pixelHeight.Click += new System.EventHandler(this.SampleSizeSet_Click);
            this.txt_pixelHeight.TextChanged += new System.EventHandler(this.SampleCalc_Click);
            this.txt_pixelHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataInput);
            // 
            // lbl_x_2
            // 
            this.lbl_x_2.AutoSize = true;
            this.lbl_x_2.Location = new System.Drawing.Point(97, 120);
            this.lbl_x_2.Name = "lbl_x_2";
            this.lbl_x_2.Size = new System.Drawing.Size(11, 12);
            this.lbl_x_2.TabIndex = 0;
            this.lbl_x_2.Text = "x";
            // 
            // txt_SampleX_real
            // 
            this.txt_SampleX_real.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SampleX_real.Location = new System.Drawing.Point(50, 63);
            this.txt_SampleX_real.Name = "txt_SampleX_real";
            this.txt_SampleX_real.ReadOnly = true;
            this.txt_SampleX_real.Size = new System.Drawing.Size(36, 15);
            this.txt_SampleX_real.TabIndex = 3;
            this.txt_SampleX_real.TabStop = false;
            this.txt_SampleX_real.Text = "7.04";
            this.txt_SampleX_real.Click += new System.EventHandler(this.SampleSizeSet_Click);
            this.txt_SampleX_real.TextChanged += new System.EventHandler(this.SampleCalc_Click);
            // 
            // txt_pixelWidth
            // 
            this.txt_pixelWidth.Location = new System.Drawing.Point(55, 117);
            this.txt_pixelWidth.Name = "txt_pixelWidth";
            this.txt_pixelWidth.Size = new System.Drawing.Size(38, 22);
            this.txt_pixelWidth.TabIndex = 7;
            this.txt_pixelWidth.Text = "1600";
            this.txt_pixelWidth.Visible = false;
            this.txt_pixelWidth.Click += new System.EventHandler(this.SampleSizeSet_Click);
            this.txt_pixelWidth.TextChanged += new System.EventHandler(this.SampleCalc_Click);
            this.txt_pixelWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataInput);
            // 
            // txt_camaraName
            // 
            this.txt_camaraName.Location = new System.Drawing.Point(187, 87);
            this.txt_camaraName.Name = "txt_camaraName";
            this.txt_camaraName.Size = new System.Drawing.Size(69, 22);
            this.txt_camaraName.TabIndex = 6;
            this.txt_camaraName.Visible = false;
            // 
            // lbl_SampleY_real
            // 
            this.lbl_SampleY_real.AutoSize = true;
            this.lbl_SampleY_real.Location = new System.Drawing.Point(114, 64);
            this.lbl_SampleY_real.Name = "lbl_SampleY_real";
            this.lbl_SampleY_real.Size = new System.Drawing.Size(29, 12);
            this.lbl_SampleY_real.TabIndex = 0;
            this.lbl_SampleY_real.Text = "寬：";
            // 
            // lbl_um
            // 
            this.lbl_um.AutoSize = true;
            this.lbl_um.Location = new System.Drawing.Point(212, 120);
            this.lbl_um.Name = "lbl_um";
            this.lbl_um.Size = new System.Drawing.Size(20, 12);
            this.lbl_um.TabIndex = 0;
            this.lbl_um.Text = "um";
            // 
            // lbl_SampleX_real
            // 
            this.lbl_SampleX_real.AutoSize = true;
            this.lbl_SampleX_real.Location = new System.Drawing.Point(18, 64);
            this.lbl_SampleX_real.Name = "lbl_SampleX_real";
            this.lbl_SampleX_real.Size = new System.Drawing.Size(29, 12);
            this.lbl_SampleX_real.TabIndex = 0;
            this.lbl_SampleX_real.Text = "長：";
            // 
            // lbl_CCDUnitSIZE
            // 
            this.lbl_CCDUnitSIZE.AutoSize = true;
            this.lbl_CCDUnitSIZE.Location = new System.Drawing.Point(185, 120);
            this.lbl_CCDUnitSIZE.Name = "lbl_CCDUnitSIZE";
            this.lbl_CCDUnitSIZE.Size = new System.Drawing.Size(28, 12);
            this.lbl_CCDUnitSIZE.TabIndex = 6;
            this.lbl_CCDUnitSIZE.Text = "none";
            // 
            // txt_pixelSensorSize
            // 
            this.txt_pixelSensorSize.Location = new System.Drawing.Point(183, 117);
            this.txt_pixelSensorSize.Name = "txt_pixelSensorSize";
            this.txt_pixelSensorSize.Size = new System.Drawing.Size(28, 22);
            this.txt_pixelSensorSize.TabIndex = 9;
            this.txt_pixelSensorSize.Text = "4.85";
            this.txt_pixelSensorSize.Visible = false;
            this.txt_pixelSensorSize.Click += new System.EventHandler(this.SampleSizeSet_Click);
            this.txt_pixelSensorSize.TextChanged += new System.EventHandler(this.SampleCalc_Click);
            this.txt_pixelSensorSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataInput);
            // 
            // lbl_FOVY
            // 
            this.lbl_FOVY.AutoSize = true;
            this.lbl_FOVY.Location = new System.Drawing.Point(117, 36);
            this.lbl_FOVY.Name = "lbl_FOVY";
            this.lbl_FOVY.Size = new System.Drawing.Size(29, 12);
            this.lbl_FOVY.TabIndex = 0;
            this.lbl_FOVY.Text = "寬：";
            // 
            // lbl_PixelResolution
            // 
            this.lbl_PixelResolution.AutoSize = true;
            this.lbl_PixelResolution.Location = new System.Drawing.Point(9, 75);
            this.lbl_PixelResolution.Name = "lbl_PixelResolution";
            this.lbl_PixelResolution.Size = new System.Drawing.Size(65, 12);
            this.lbl_PixelResolution.TabIndex = 0;
            this.lbl_PixelResolution.Text = "畫素精度：";
            // 
            // lbl_InspectionResolution
            // 
            this.lbl_InspectionResolution.AutoSize = true;
            this.lbl_InspectionResolution.Location = new System.Drawing.Point(9, 114);
            this.lbl_InspectionResolution.Name = "lbl_InspectionResolution";
            this.lbl_InspectionResolution.Size = new System.Drawing.Size(65, 12);
            this.lbl_InspectionResolution.TabIndex = 0;
            this.lbl_InspectionResolution.Text = "檢素精度：";
            this.lbl_InspectionResolution.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_FOVX
            // 
            this.txt_FOVX.Location = new System.Drawing.Point(44, 33);
            this.txt_FOVX.Name = "txt_FOVX";
            this.txt_FOVX.ReadOnly = true;
            this.txt_FOVX.Size = new System.Drawing.Size(42, 22);
            this.txt_FOVX.TabIndex = 0;
            this.txt_FOVX.TabStop = false;
            this.txt_FOVX.Text = "0";
            this.txt_FOVX.Click += new System.EventHandler(this.FOVXRangeSet_Click);
            this.txt_FOVX.TextChanged += new System.EventHandler(this.FOVXCalc_Click);
            this.txt_FOVX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataInput);
            // 
            // lbl_mmperpixel_1
            // 
            this.lbl_mmperpixel_1.AutoSize = true;
            this.lbl_mmperpixel_1.Location = new System.Drawing.Point(197, 75);
            this.lbl_mmperpixel_1.Name = "lbl_mmperpixel_1";
            this.lbl_mmperpixel_1.Size = new System.Drawing.Size(49, 12);
            this.lbl_mmperpixel_1.TabIndex = 0;
            this.lbl_mmperpixel_1.Text = "mm/pixel";
            // 
            // lbl_mmperpixel_2
            // 
            this.lbl_mmperpixel_2.AutoSize = true;
            this.lbl_mmperpixel_2.Location = new System.Drawing.Point(197, 116);
            this.lbl_mmperpixel_2.Name = "lbl_mmperpixel_2";
            this.lbl_mmperpixel_2.Size = new System.Drawing.Size(23, 12);
            this.lbl_mmperpixel_2.TabIndex = 0;
            this.lbl_mmperpixel_2.Text = "mm";
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(197, 153);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(11, 12);
            this.lbl_x.TabIndex = 0;
            this.lbl_x.Text = "x";
            // 
            // txt_FOVY
            // 
            this.txt_FOVY.Location = new System.Drawing.Point(143, 33);
            this.txt_FOVY.Name = "txt_FOVY";
            this.txt_FOVY.ReadOnly = true;
            this.txt_FOVY.Size = new System.Drawing.Size(42, 22);
            this.txt_FOVY.TabIndex = 1;
            this.txt_FOVY.TabStop = false;
            this.txt_FOVY.Text = "0";
            this.txt_FOVY.Click += new System.EventHandler(this.FOVYRangeSet_Click);
            this.txt_FOVY.TextChanged += new System.EventHandler(this.FOVYCalc_Click);
            this.txt_FOVY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataInput);
            // 
            // txt_MagOPT
            // 
            this.txt_MagOPT.Location = new System.Drawing.Point(88, 150);
            this.txt_MagOPT.MaxLength = 6;
            this.txt_MagOPT.Name = "txt_MagOPT";
            this.txt_MagOPT.ReadOnly = true;
            this.txt_MagOPT.Size = new System.Drawing.Size(105, 22);
            this.txt_MagOPT.TabIndex = 5;
            this.txt_MagOPT.Text = "0";
            this.txt_MagOPT.Click += new System.EventHandler(this.MagOPTSetMode_Click);
            this.txt_MagOPT.TextChanged += new System.EventHandler(this.MagOPTCalc_Click);
            this.txt_MagOPT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataInput);
            // 
            // lbl_FOVX
            // 
            this.lbl_FOVX.AutoSize = true;
            this.lbl_FOVX.Location = new System.Drawing.Point(9, 36);
            this.lbl_FOVX.Name = "lbl_FOVX";
            this.lbl_FOVX.Size = new System.Drawing.Size(29, 12);
            this.lbl_FOVX.TabIndex = 0;
            this.lbl_FOVX.Text = "長：";
            // 
            // txt_PixelResolution
            // 
            this.txt_PixelResolution.Location = new System.Drawing.Point(88, 70);
            this.txt_PixelResolution.Name = "txt_PixelResolution";
            this.txt_PixelResolution.ReadOnly = true;
            this.txt_PixelResolution.Size = new System.Drawing.Size(105, 22);
            this.txt_PixelResolution.TabIndex = 2;
            this.txt_PixelResolution.TabStop = false;
            this.txt_PixelResolution.Text = "0";
            this.txt_PixelResolution.Click += new System.EventHandler(this.PixelResoulutionSetMode_Click);
            this.txt_PixelResolution.TextChanged += new System.EventHandler(this.PixelResolutionCalc_Click);
            this.txt_PixelResolution.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataInput);
            // 
            // txt_InspectionResolution
            // 
            this.txt_InspectionResolution.Location = new System.Drawing.Point(88, 111);
            this.txt_InspectionResolution.Name = "txt_InspectionResolution";
            this.txt_InspectionResolution.ReadOnly = true;
            this.txt_InspectionResolution.Size = new System.Drawing.Size(105, 22);
            this.txt_InspectionResolution.TabIndex = 4;
            this.txt_InspectionResolution.TabStop = false;
            this.txt_InspectionResolution.Text = "0";
            this.txt_InspectionResolution.Click += new System.EventHandler(this.InspectionResoulutionSetMode_Click);
            this.txt_InspectionResolution.TextChanged += new System.EventHandler(this.InspectionResolutionCalc_Click);
            this.txt_InspectionResolution.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataInput);
            // 
            // lbl_MagOPT
            // 
            this.lbl_MagOPT.AutoSize = true;
            this.lbl_MagOPT.Location = new System.Drawing.Point(9, 153);
            this.lbl_MagOPT.Name = "lbl_MagOPT";
            this.lbl_MagOPT.Size = new System.Drawing.Size(62, 12);
            this.lbl_MagOPT.TabIndex = 0;
            this.lbl_MagOPT.Text = "Mag.OPT：";
            // 
            // lbl_FOV
            // 
            this.lbl_FOV.AutoSize = true;
            this.lbl_FOV.Location = new System.Drawing.Point(6, 18);
            this.lbl_FOV.Name = "lbl_FOV";
            this.lbl_FOV.Size = new System.Drawing.Size(27, 12);
            this.lbl_FOV.TabIndex = 0;
            this.lbl_FOV.Text = "FOV";
            // 
            // grp_OutArea
            // 
            this.grp_OutArea.Controls.Add(this.trb_lens_focalLength);
            this.grp_OutArea.Controls.Add(this.trb_lens_wd);
            this.grp_OutArea.Controls.Add(this.lbl_mm_8);
            this.grp_OutArea.Controls.Add(this.lbl_mm_7);
            this.grp_OutArea.Controls.Add(this.lbl_lens_focallength);
            this.grp_OutArea.Controls.Add(this.lbl_lens_wd);
            this.grp_OutArea.Controls.Add(this.txt_lens_focallength);
            this.grp_OutArea.Controls.Add(this.txt_lens_wd);
            this.grp_OutArea.Controls.Add(this.lbl_FOV);
            this.grp_OutArea.Controls.Add(this.lbl_MagOPT);
            this.grp_OutArea.Controls.Add(this.txt_InspectionResolution);
            this.grp_OutArea.Controls.Add(this.txt_PixelResolution);
            this.grp_OutArea.Controls.Add(this.lbl_FOVX);
            this.grp_OutArea.Controls.Add(this.txt_MagOPT);
            this.grp_OutArea.Controls.Add(this.txt_FOVratio_real);
            this.grp_OutArea.Controls.Add(this.txt_InspectionResolutionRatio);
            this.grp_OutArea.Controls.Add(this.txt_FOVY);
            this.grp_OutArea.Controls.Add(this.lbl_x);
            this.grp_OutArea.Controls.Add(this.lbl_mmperpixel_2);
            this.grp_OutArea.Controls.Add(this.lbl_mmperpixel_1);
            this.grp_OutArea.Controls.Add(this.txt_FOVX);
            this.grp_OutArea.Controls.Add(this.lbl_mm_3);
            this.grp_OutArea.Controls.Add(this.lbl_InspectionResolution);
            this.grp_OutArea.Controls.Add(this.lbl_PixelResolution);
            this.grp_OutArea.Controls.Add(this.lbl_mm_4);
            this.grp_OutArea.Controls.Add(this.lbl_FOVY);
            this.grp_OutArea.Location = new System.Drawing.Point(12, 199);
            this.grp_OutArea.Name = "grp_OutArea";
            this.grp_OutArea.Size = new System.Drawing.Size(293, 265);
            this.grp_OutArea.TabIndex = 1;
            this.grp_OutArea.TabStop = false;
            this.grp_OutArea.Text = "輸出";
            // 
            // trb_lens_focalLength
            // 
            this.trb_lens_focalLength.Location = new System.Drawing.Point(77, 181);
            this.trb_lens_focalLength.Maximum = 100;
            this.trb_lens_focalLength.Name = "trb_lens_focalLength";
            this.trb_lens_focalLength.Size = new System.Drawing.Size(116, 45);
            this.trb_lens_focalLength.TabIndex = 7;
            this.trb_lens_focalLength.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trb_lens_focalLength.Scroll += new System.EventHandler(this.lensCalc_focalLength);
            this.trb_lens_focalLength.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trb_lens_focallength_MouseDown);
            // 
            // trb_lens_wd
            // 
            this.trb_lens_wd.Location = new System.Drawing.Point(77, 226);
            this.trb_lens_wd.Maximum = 300;
            this.trb_lens_wd.Name = "trb_lens_wd";
            this.trb_lens_wd.Size = new System.Drawing.Size(116, 45);
            this.trb_lens_wd.TabIndex = 8;
            this.trb_lens_wd.Scroll += new System.EventHandler(this.lensCalc_wd);
            this.trb_lens_wd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trb_lens_wd_MouseDown);
            // 
            // lbl_lens_focallength
            // 
            this.lbl_lens_focallength.AutoSize = true;
            this.lbl_lens_focallength.Location = new System.Drawing.Point(8, 192);
            this.lbl_lens_focallength.Name = "lbl_lens_focallength";
            this.lbl_lens_focallength.Size = new System.Drawing.Size(65, 12);
            this.lbl_lens_focallength.TabIndex = 103;
            this.lbl_lens_focallength.Text = "鏡頭焦距：";
            // 
            // lbl_lens_wd
            // 
            this.lbl_lens_wd.AutoSize = true;
            this.lbl_lens_wd.Location = new System.Drawing.Point(8, 231);
            this.lbl_lens_wd.Name = "lbl_lens_wd";
            this.lbl_lens_wd.Size = new System.Drawing.Size(65, 12);
            this.lbl_lens_wd.TabIndex = 104;
            this.lbl_lens_wd.Text = "工作距離：";
            // 
            // txt_lens_focallength
            // 
            this.txt_lens_focallength.Location = new System.Drawing.Point(200, 189);
            this.txt_lens_focallength.Name = "txt_lens_focallength";
            this.txt_lens_focallength.Size = new System.Drawing.Size(42, 22);
            this.txt_lens_focallength.TabIndex = 101;
            this.txt_lens_focallength.Text = "0";
            this.txt_lens_focallength.TextChanged += new System.EventHandler(this.txt_lens_focallength_TextChanged);
            // 
            // txt_lens_wd
            // 
            this.txt_lens_wd.Location = new System.Drawing.Point(199, 228);
            this.txt_lens_wd.Name = "txt_lens_wd";
            this.txt_lens_wd.Size = new System.Drawing.Size(42, 22);
            this.txt_lens_wd.TabIndex = 102;
            this.txt_lens_wd.Text = "0";
            this.txt_lens_wd.TextChanged += new System.EventHandler(this.txt_lens_wd_TextChanged);
            // 
            // txt_FOVratio_real
            // 
            this.txt_FOVratio_real.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_FOVratio_real.Location = new System.Drawing.Point(220, 153);
            this.txt_FOVratio_real.Name = "txt_FOVratio_real";
            this.txt_FOVratio_real.ReadOnly = true;
            this.txt_FOVratio_real.Size = new System.Drawing.Size(60, 15);
            this.txt_FOVratio_real.TabIndex = 6;
            this.txt_FOVratio_real.Text = "0";
            // 
            // txt_InspectionResolutionRatio
            // 
            this.txt_InspectionResolutionRatio.Location = new System.Drawing.Point(249, 70);
            this.txt_InspectionResolutionRatio.Name = "txt_InspectionResolutionRatio";
            this.txt_InspectionResolutionRatio.Size = new System.Drawing.Size(22, 22);
            this.txt_InspectionResolutionRatio.TabIndex = 3;
            this.txt_InspectionResolutionRatio.TabStop = false;
            this.txt_InspectionResolutionRatio.Text = "3";
            this.txt_InspectionResolutionRatio.Click += new System.EventHandler(this.SampleSizeSet_Click);
            this.txt_InspectionResolutionRatio.TextChanged += new System.EventHandler(this.text_InspectionResolutionRatio_TextChanged);
            this.txt_InspectionResolutionRatio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataInput);
            // 
            // pic_Calc
            // 
            this.pic_Calc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Calc.Image = ((System.Drawing.Image)(resources.GetObject("pic_Calc.Image")));
            this.pic_Calc.Location = new System.Drawing.Point(587, 423);
            this.pic_Calc.Name = "pic_Calc";
            this.pic_Calc.Size = new System.Drawing.Size(34, 45);
            this.pic_Calc.TabIndex = 4;
            this.pic_Calc.TabStop = false;
            this.pic_Calc.Click += new System.EventHandler(this.CalcBox_Click);
            // 
            // lbl_Mode
            // 
            this.lbl_Mode.AutoSize = true;
            this.lbl_Mode.Location = new System.Drawing.Point(448, 387);
            this.lbl_Mode.Name = "lbl_Mode";
            this.lbl_Mode.Size = new System.Drawing.Size(53, 12);
            this.lbl_Mode.TabIndex = 0;
            this.lbl_Mode.Text = "檢測模式";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.UseAnimation = false;
            // 
            // txt_Data
            // 
            this.txt_Data.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Data.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Data.Location = new System.Drawing.Point(311, 21);
            this.txt_Data.Multiline = true;
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.Size = new System.Drawing.Size(307, 233);
            this.txt_Data.TabIndex = 6;
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(317, 288);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_copy.TabIndex = 7;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Visible = false;
            this.btn_copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // lbl_Copystate
            // 
            this.lbl_Copystate.AutoSize = true;
            this.lbl_Copystate.Font = new System.Drawing.Font("新細明體", 9F);
            this.lbl_Copystate.Location = new System.Drawing.Point(398, 293);
            this.lbl_Copystate.Name = "lbl_Copystate";
            this.lbl_Copystate.Size = new System.Drawing.Size(0, 12);
            this.lbl_Copystate.TabIndex = 9;
            // 
            // timer_Date
            // 
            this.timer_Date.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(501, 293);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(26, 12);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Date";
            // 
            // pic_notepad
            // 
            this.pic_notepad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_notepad.Image = ((System.Drawing.Image)(resources.GetObject("pic_notepad.Image")));
            this.pic_notepad.Location = new System.Drawing.Point(582, 369);
            this.pic_notepad.Name = "pic_notepad";
            this.pic_notepad.Size = new System.Drawing.Size(45, 45);
            this.pic_notepad.TabIndex = 8;
            this.pic_notepad.TabStop = false;
            this.pic_notepad.Click += new System.EventHandler(this.NotepadBox_Click);
            // 
            // Paint_Green
            // 
            this.Paint_Green.BackColor = System.Drawing.Color.Green;
            this.Paint_Green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Paint_Green.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Paint_Green.Enabled = false;
            this.Paint_Green.Location = new System.Drawing.Point(317, 323);
            this.Paint_Green.Multiline = true;
            this.Paint_Green.Name = "Paint_Green";
            this.Paint_Green.ReadOnly = true;
            this.Paint_Green.Size = new System.Drawing.Size(125, 94);
            this.Paint_Green.TabIndex = 10;
            // 
            // Paint_Red
            // 
            this.Paint_Red.BackColor = System.Drawing.Color.Red;
            this.Paint_Red.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Paint_Red.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Paint_Red.Enabled = false;
            this.Paint_Red.Location = new System.Drawing.Point(317, 323);
            this.Paint_Red.Multiline = true;
            this.Paint_Red.Name = "Paint_Red";
            this.Paint_Red.ReadOnly = true;
            this.Paint_Red.Size = new System.Drawing.Size(125, 94);
            this.Paint_Red.TabIndex = 10;
            // 
            // Paint_Grey
            // 
            this.Paint_Grey.BackColor = System.Drawing.Color.DimGray;
            this.Paint_Grey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Paint_Grey.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Paint_Grey.Enabled = false;
            this.Paint_Grey.Location = new System.Drawing.Point(317, 323);
            this.Paint_Grey.Multiline = true;
            this.Paint_Grey.Name = "Paint_Grey";
            this.Paint_Grey.ReadOnly = true;
            this.Paint_Grey.Size = new System.Drawing.Size(125, 94);
            this.Paint_Grey.TabIndex = 10;
            // 
            // lbl_ImageInfo
            // 
            this.lbl_ImageInfo.AutoSize = true;
            this.lbl_ImageInfo.Location = new System.Drawing.Point(448, 328);
            this.lbl_ImageInfo.Name = "lbl_ImageInfo";
            this.lbl_ImageInfo.Size = new System.Drawing.Size(89, 36);
            this.lbl_ImageInfo.TabIndex = 0;
            this.lbl_ImageInfo.Text = "綠色：視野範圍\r\n灰色：樣品範圍\r\n紅色：樣品";
            // 
            // lbl_autor
            // 
            this.lbl_autor.AutoSize = true;
            this.lbl_autor.Location = new System.Drawing.Point(517, 493);
            this.lbl_autor.Name = "lbl_autor";
            this.lbl_autor.Size = new System.Drawing.Size(107, 12);
            this.lbl_autor.TabIndex = 0;
            this.lbl_autor.Text = "製作人:林文凱 2015";
            // 
            // btn_tip
            // 
            this.btn_tip.Location = new System.Drawing.Point(317, 488);
            this.btn_tip.Name = "btn_tip";
            this.btn_tip.Size = new System.Drawing.Size(45, 23);
            this.btn_tip.TabIndex = 7;
            this.btn_tip.Text = "說明";
            this.btn_tip.UseVisualStyleBackColor = true;
            this.btn_tip.Click += new System.EventHandler(this.Btn_tip_Click);
            // 
            // timer_LockTimer
            // 
            this.timer_LockTimer.Tick += new System.EventHandler(this.LockTimer);
            // 
            // lbl_bomb
            // 
            this.lbl_bomb.AutoSize = true;
            this.lbl_bomb.Location = new System.Drawing.Point(448, 408);
            this.lbl_bomb.Name = "lbl_bomb";
            this.lbl_bomb.Size = new System.Drawing.Size(0, 12);
            this.lbl_bomb.TabIndex = 0;
            // 
            // CCD_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(633, 514);
            this.Controls.Add(this.grp_InputArea);
            this.Controls.Add(this.grp_OutArea);
            this.Controls.Add(this.Paint_Red);
            this.Controls.Add(this.Paint_Grey);
            this.Controls.Add(this.Paint_Green);
            this.Controls.Add(this.lbl_Copystate);
            this.Controls.Add(this.pic_notepad);
            this.Controls.Add(this.btn_tip);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.pic_Calc);
            this.Controls.Add(this.txt_Data);
            this.Controls.Add(this.lbl_ImageInfo);
            this.Controls.Add(this.lbl_bomb);
            this.Controls.Add(this.lbl_autor);
            this.Controls.Add(this.lbl_Mode);
            this.Controls.Add(this.lbl_date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CCD_Calc";
            this.Text = "CCD計算機";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_InputArea.ResumeLayout(false);
            this.grp_InputArea.PerformLayout();
            this.grp_OutArea.ResumeLayout(false);
            this.grp_OutArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_lens_focalLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_lens_wd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Calc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_notepad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SampleSize;
        private System.Windows.Forms.Label lbl_SampleX;
        private System.Windows.Forms.Label lbl_mm_1;
        private System.Windows.Forms.Label lbl_mm_2;
        private System.Windows.Forms.Label lbl_SampleY;
        private System.Windows.Forms.TextBox txt_SampleX;
        private System.Windows.Forms.TextBox txt_SampleY;
        private System.Windows.Forms.Label lbl_CCDList;
        private System.Windows.Forms.ComboBox CCDList;
        private System.Windows.Forms.GroupBox grp_InputArea;
        private System.Windows.Forms.Label lbl_FOVY;
        private System.Windows.Forms.Label lbl_mm_4;
        private System.Windows.Forms.Label lbl_PixelResolution;
        private System.Windows.Forms.Label lbl_InspectionResolution;
        private System.Windows.Forms.Label lbl_mm_3;
        private System.Windows.Forms.TextBox txt_FOVX;
        private System.Windows.Forms.Label lbl_mmperpixel_1;
        private System.Windows.Forms.Label lbl_mmperpixel_2;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.TextBox txt_FOVY;
        private System.Windows.Forms.TextBox txt_MagOPT;
        private System.Windows.Forms.Label lbl_FOVX;
        private System.Windows.Forms.TextBox txt_PixelResolution;
        private System.Windows.Forms.TextBox txt_InspectionResolution;
        private System.Windows.Forms.Label lbl_MagOPT;
        private System.Windows.Forms.Label lbl_FOV;
        private System.Windows.Forms.GroupBox grp_OutArea;
        private System.Windows.Forms.Label lbl_SensorSize;
        private System.Windows.Forms.Label lbl_CCDPIXEL;
        private System.Windows.Forms.Label lbl_SensorSizeData;
        private System.Windows.Forms.Label lbl_CCDPixelData;
        private System.Windows.Forms.PictureBox pic_Calc;
        private System.Windows.Forms.TextBox txt_SampleY_real;
        private System.Windows.Forms.TextBox txt_SampleX_real;
        private System.Windows.Forms.Label lbl_SampleY_real;
        private System.Windows.Forms.Label lbl_mm_6;
        private System.Windows.Forms.Label lbl_mm_5;
        private System.Windows.Forms.Label lbl_SampleX_real;
        private System.Windows.Forms.TextBox txt_InspectionResolutionRatio;
        private System.Windows.Forms.TextBox txt_FOVratio;
        private System.Windows.Forms.TextBox txt_FOVratio_real;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.PictureBox pic_notepad;
        private System.Windows.Forms.Label lbl_Copystate;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer_Date;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox Paint_Green;
        private System.Windows.Forms.TextBox Paint_Red;
        private System.Windows.Forms.TextBox Paint_Grey;
        private System.Windows.Forms.Label lbl_ImageInfo;
        private System.Windows.Forms.Label lbl_Mode;
        private System.Windows.Forms.Label lbl_autor;
        private System.Windows.Forms.Button btn_tip;
        private System.Windows.Forms.Timer timer_LockTimer;
        private System.Windows.Forms.TextBox txt_pixelSensorSize;
        private System.Windows.Forms.TextBox txt_pixelHeight;
        private System.Windows.Forms.TextBox txt_pixelWidth;
        private System.Windows.Forms.Label lbl_x_2;
        private System.Windows.Forms.Label lbl_um;
        private System.Windows.Forms.TrackBar trb_lens_focalLength;
        private System.Windows.Forms.TrackBar trb_lens_wd;
        private System.Windows.Forms.Label lbl_mm_8;
        private System.Windows.Forms.Label lbl_mm_7;
        private System.Windows.Forms.Label lbl_lens_focallength;
        private System.Windows.Forms.Label lbl_lens_wd;
        private System.Windows.Forms.TextBox txt_lens_focallength;
        private System.Windows.Forms.TextBox txt_lens_wd;
        private System.Windows.Forms.Label lbl_bomb;
        private System.Windows.Forms.TextBox txt_camaraName;
        private System.Windows.Forms.Button btn_saveCCDdata;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_CCDUnitSIZE;
    }
}

