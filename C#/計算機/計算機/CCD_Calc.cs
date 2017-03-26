using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 計算機
{
    enum mode { SampleSizeSetMode = 1, MagOPTSetMode, InspectionResoulutionSetMode, PixelResoulutionSetMode, FOVXSetMode, FOVYSetMode, focalLengthSetMode, WDSetMode };

    public partial class CCD_Calc : Form
    {
        #region 變數宣告
        string cameraData=@"data.txt";
        string[,] readdata=new string[50,10];
        int dataIndex;
        const int size = 50;

        double SX, SY;//樣品尺寸*FOV比例
        double[] FX = new double[size];//符合sensor比例的SX
        double[] FY = new double[size];//符合sensor比例的SY
        double[] tempX = new double[size];//"符合sensor比例的SX"運算過程中的暫存參數
        double[] tempY = new double[size];//"符合sensor比例的SY"運算過程中的暫存參數
        double[,] CCDPixel = new double[size, 2] ;//CCD解析度
        double[,] CCDSIZE = new double[size, 2] ;//CCD晶片尺寸
        double[] CCDUnitSIZE = new double[size] ;//Pixel Size

        int SettingMode = (int)mode.SampleSizeSetMode;
        int TimeToClose = 0;

        #endregion

        public CCD_Calc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (object allGroupBox in this.Controls)
            {
                GroupBox g = allGroupBox as GroupBox;
                if (g != null)
                {
                    foreach (object c in g.Controls)
                    {
                        TextBox t = c as TextBox;
                        if (t != null)
                        {
                            //MessageBox.Show(t.Name);
                        }

                    }
                }
            }



            timer_Date.Start();
            btn_load_Click(sender, e);

            CCDList.SelectedIndex = 0;
        }
        #region 資料讀寫
        //讀
        private void btn_load_Click(object sender, EventArgs e)
        {
            CCDList.Items.Clear();
            if (File.Exists(cameraData))
            {
                StreamReader sr = File.OpenText(cameraData);
                int n = 0; // 記錄共有多少個字串

                while (sr.Peek() != -1) //判斷是否已經讀取最後
                {
                    string currentRow = sr.ReadLine();  //讀取一列 
                    string[] tempword = currentRow.Trim().Split(','); // 將字串以空白字元分解
                    int i = 0;
                    foreach (string w in tempword)
                    {
                        readdata[n, i] = tempword[i++];
                    }
                    n++;
                    dataIndex = n;
                }
                sr.Close();

                CCDList.Items.Clear();
                for (int i = 0; i < n; i++) // 將陣列讀入label顯示
                    CCDList.Items.Add(readdata[i, 0]);
                
                CCDList.Items.Add("自定義");
            }
            else
                File.Create(cameraData);
        }



        //存
        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否新增自定義CCD資料?", "新增", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (File.Exists(cameraData))
                {
                    FileStream myStream = new FileStream(cameraData, FileMode.Open, FileAccess.ReadWrite);
                    StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.Default);
                    StreamReader sr = new StreamReader(myStream, System.Text.Encoding.Default);

                    string st = string.Empty;
                    while (!sr.EndOfStream)
                        st = sr.ReadLine();

                    sw.Write(txt_camaraName.Text + "," + txt_pixelWidth.Text + "," + txt_pixelHeight.Text + "," + txt_pixelSensorSize.Text + "\r\n");
                    sw.Flush();
                    sw.Close();

                    myStream.Close();
                }
                btn_load_Click(sender, e);
                CCDList.SelectedIndex = dataIndex-1;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
            
        }

        //刪
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否刪除此CCD資料?", "刪除", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (File.Exists(cameraData))
                {
                    List<string> lines = new List<string>(File.ReadAllLines(cameraData));
                    lines.RemoveAt(CCDList.SelectedIndex);
                    File.WriteAllLines(cameraData, lines.ToArray());
                    btn_load_Click(null, null);
                    CCDList.SelectedIndex = 0;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        #endregion

        #region 設定模式選擇
        //樣品設定模式
        private void SampleSizeSet_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();

            SettingMode = (int)mode.SampleSizeSetMode;
            txt_SampleX.ReadOnly = false;
            txt_SampleY.ReadOnly = false;
            txt_FOVratio.ReadOnly = false;
            txt_FOVratio.Visible = true;
            CCDList.Enabled = true;
            txt_FOVX.ReadOnly = true;
            txt_FOVY.ReadOnly = true;
            txt_InspectionResolution.ReadOnly = true;
            txt_PixelResolution.ReadOnly = true;
            txt_MagOPT.ReadOnly = true;
            txt_SampleX.BackColor = SystemColors.Window;
            txt_SampleY.BackColor = SystemColors.Window;
            txt_InspectionResolution.BackColor = SystemColors.Control;
            txt_PixelResolution.BackColor = SystemColors.Control;
            SampleCalc_Click(sender, e);
            lbl_Mode.Text = "樣品尺寸設定模式";

        }
        //放大倍率設定模式
        private void MagOPTSetMode_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
            SettingMode = (int)mode.MagOPTSetMode;
            txt_SampleX.ReadOnly = true;
            txt_SampleY.ReadOnly = true;
            txt_FOVratio.ReadOnly = true;
            txt_FOVratio.Visible = false;
            CCDList.Enabled = true;
            txt_MagOPT.ReadOnly = false;
            txt_SampleX.BackColor = SystemColors.Control;
            txt_SampleY.BackColor = SystemColors.Control;
            txt_InspectionResolution.BackColor = SystemColors.Control;
            txt_PixelResolution.BackColor = SystemColors.Control;
            lbl_Mode.Text = "放大倍率設定模式";
            MagOPTCalc_Click(sender, e);

            lbl_Copystate.Text = "";
        }
        //檢測精度設定模式
        private void InspectionResoulutionSetMode_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
            SettingMode = (int)mode.InspectionResoulutionSetMode;
            txt_SampleX.ReadOnly = true;
            txt_SampleY.ReadOnly = true;
            txt_FOVratio.ReadOnly = true;
            txt_FOVratio.Visible = false;
            CCDList.Enabled = true;
            txt_MagOPT.ReadOnly = true;
            txt_InspectionResolution.ReadOnly = false;
            txt_PixelResolution.ReadOnly = true;
            txt_SampleX.BackColor = SystemColors.Control;
            txt_SampleY.BackColor = SystemColors.Control;
            txt_InspectionResolution.BackColor = SystemColors.Window;
            txt_PixelResolution.BackColor = SystemColors.Control;
            lbl_Copystate.Text = "";
            InspectionResolutionCalc_Click(sender, e);
            lbl_Mode.Text = "檢測精度設定模式";

        }
        //畫素精度設定模式
        private void PixelResoulutionSetMode_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
            SettingMode = (int)mode.PixelResoulutionSetMode;
            txt_SampleX.ReadOnly = true;
            txt_SampleY.ReadOnly = true;
            txt_FOVratio.ReadOnly = true;
            txt_FOVratio.Visible = false;
            CCDList.Enabled = true;
            txt_MagOPT.ReadOnly = true;
            txt_InspectionResolution.ReadOnly = true;
            txt_PixelResolution.ReadOnly = false;
            txt_SampleX.BackColor = SystemColors.Control;
            txt_SampleY.BackColor = SystemColors.Control;
            txt_InspectionResolution.BackColor = SystemColors.Control;
            txt_PixelResolution.BackColor = SystemColors.Window;
            lbl_Copystate.Text = "";
            PixelResolutionCalc_Click(sender, e);
            lbl_Mode.Text = "畫素精度設定模式";

        }
        //視野範圍設定模式
        private void FOVXRangeSet_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();

            SettingMode = (int)mode.FOVXSetMode;
            txt_SampleX.ReadOnly = true;
            txt_SampleY.ReadOnly = true;
            txt_FOVratio.ReadOnly = true;
            txt_FOVratio.Visible = true;
            CCDList.Enabled = true;
            txt_FOVX.ReadOnly = false;
            txt_FOVY.ReadOnly = false;
            txt_InspectionResolution.ReadOnly = true;
            txt_PixelResolution.ReadOnly = true;
            txt_MagOPT.ReadOnly = true;
            txt_SampleX.BackColor = SystemColors.Control;
            txt_SampleY.BackColor = SystemColors.Control;
            txt_InspectionResolution.BackColor = SystemColors.Control;
            txt_PixelResolution.BackColor = SystemColors.Control;
            FOVXCalc_Click(sender, e);
            lbl_Mode.Text = "視野範圍設定模式";
        }
        private void FOVYRangeSet_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();

            SettingMode = (int)mode.FOVYSetMode;
            txt_SampleX.ReadOnly = true;
            txt_SampleY.ReadOnly = true;
            txt_FOVratio.ReadOnly = true;
            txt_FOVratio.Visible = true;
            CCDList.Enabled = true;
            txt_FOVX.ReadOnly = false;
            txt_FOVY.ReadOnly = false;
            txt_InspectionResolution.ReadOnly = true;
            txt_PixelResolution.ReadOnly = true;
            txt_MagOPT.ReadOnly = true;
            txt_SampleX.BackColor = SystemColors.Control;
            txt_SampleY.BackColor = SystemColors.Control;
            txt_InspectionResolution.BackColor = SystemColors.Control;
            txt_PixelResolution.BackColor = SystemColors.Control;
            FOVYCalc_Click(sender, e);
            lbl_Mode.Text = "視野範圍設定模式";
        }
        //工作距離設定模式
        private void trb_lens_wd_MouseDown(object sender, MouseEventArgs e)
        {
            SettingMode = (int)mode.WDSetMode;
        }
        //鏡頭焦距設定模式
        private void trb_lens_focallength_MouseDown(object sender, MouseEventArgs e)
        {
            SettingMode = (int)mode.focalLengthSetMode;
        }
        #endregion

        #region 數值計算
        //選擇CCD
        private void CCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            read_data();
            if (CCDList.SelectedIndex < dataIndex)
            {
                txt_pixelWidth.Visible = false;
                txt_pixelHeight.Visible = false;
                txt_pixelSensorSize.Visible = false;
                lbl_x_2.Visible = false;
                lbl_CCDUnitSIZE.Visible = true;
                lbl_CCDPIXEL.Visible = true;
                txt_camaraName.Visible = false;
                btn_saveCCDdata.Visible = false;
                btn_delete.Visible = true;
            }
            else
            {
                txt_pixelWidth.Visible = true;
                txt_pixelHeight.Visible = true;
                txt_pixelSensorSize.Visible = true;
                lbl_x_2.Visible = true;
                lbl_CCDUnitSIZE.Visible = false;
                lbl_CCDPIXEL.Visible = false;
                txt_camaraName.Visible = true;
                btn_saveCCDdata.Visible = true;
                btn_delete.Visible = false;
            }

            switch (SettingMode)
            {
                case (int)mode.SampleSizeSetMode:
                    SampleCalc_Click(sender, e);
                    break;
                case (int)mode.MagOPTSetMode:
                    MagOPTCalc_Click(sender, e);
                    break;
                case (int)mode.PixelResoulutionSetMode:
                    PixelResolutionCalc_Click(sender, e);
                    break;
                case (int)mode.InspectionResoulutionSetMode:
                    InspectionResolutionCalc_Click(sender, e);
                    break;
            }

        }
        //設定自定義CCD(可刪)
        private void CCDCustomSetting(object sender, EventArgs e)
        {
            notVoidverification(txt_pixelSensorSize);
            notVoidverification(txt_pixelWidth);
            notVoidverification(txt_pixelHeight);
            CCDUnitSIZE[dataIndex] = Convert.ToDouble(txt_pixelSensorSize.Text) / 1000;
            CCDPixel[dataIndex, 0] = Convert.ToInt16(txt_pixelWidth.Text);
            CCDPixel[dataIndex, 1] = Convert.ToInt16(txt_pixelHeight.Text);
            CCDSIZE[dataIndex, 0] = Math.Round(CCDPixel[dataIndex, 0] * CCDUnitSIZE[dataIndex], 2);
            CCDSIZE[dataIndex, 1] = Math.Round(CCDPixel[dataIndex, 1] * CCDUnitSIZE[dataIndex], 2);
        }

        private void read_data()
        {
            for (int i = 0; i <= dataIndex; i++)
            {
                CCDPixel[i, 0] = Convert.ToDouble(readdata[i, 1]);
                CCDPixel[i, 1] = Convert.ToDouble(readdata[i, 2]);//CCD解析度

                CCDSIZE[i, 0] = CCDPixel[i, 0] * Convert.ToDouble(readdata[i, 3]) / 1000;
                CCDSIZE[i, 1] = CCDPixel[i, 1] * Convert.ToDouble(readdata[i, 3]) / 1000;//CCD晶片尺寸

                CCDUnitSIZE[i] = Convert.ToDouble(readdata[i, 3]);//Pixel Size
            }


            notVoidverification(txt_pixelSensorSize);
            notVoidverification(txt_pixelWidth);
            notVoidverification(txt_pixelHeight);
            CCDUnitSIZE[dataIndex] = Convert.ToDouble(txt_pixelSensorSize.Text) / 1000;
            CCDPixel[dataIndex, 0] = Convert.ToInt16(txt_pixelWidth.Text);
            CCDPixel[dataIndex, 1] = Convert.ToInt16(txt_pixelHeight.Text);
            CCDSIZE[dataIndex, 0] = Math.Round(CCDPixel[dataIndex, 0] * CCDUnitSIZE[dataIndex], 2);
            CCDSIZE[dataIndex, 1] = Math.Round(CCDPixel[dataIndex, 1] * CCDUnitSIZE[dataIndex], 2);

            lbl_CCDPIXEL.Text = (CCDPixel[CCDList.SelectedIndex, 0]).ToString() + "pixel" + "*" + (CCDPixel[CCDList.SelectedIndex, 1]).ToString() + "pixel";
            lbl_SensorSize.Text = (CCDSIZE[CCDList.SelectedIndex, 0]).ToString("f2") + "mm" + "*" + (CCDSIZE[CCDList.SelectedIndex, 1]).ToString("f2") + "mm";
            lbl_CCDUnitSIZE.Text =  CCDUnitSIZE[CCDList.SelectedIndex].ToString() ;
        }

        //依樣品尺寸計算
        private void SampleCalc_Click(object sender, EventArgs e)
        {
            //CCDCustomSetting( sender,  e);
            read_data();
            if (SettingMode == (int)mode.SampleSizeSetMode)
            {
                notVoidverification(txt_FOVratio);
                notVoidverification(txt_SampleX);
                notVoidverification(txt_SampleY);

                SX = Convert.ToDouble(txt_FOVratio.Text) * double.Parse(txt_SampleX.Text);
                SY = Convert.ToDouble(txt_FOVratio.Text) * Convert.ToDouble(txt_SampleY.Text);
                for (int i = 0; i <= dataIndex; i++)
                {
                    tempX[i] = SX * CCDPixel[i, 1];
                    tempY[i] = SY * CCDPixel[i, 0];

                    if (tempX[i] > tempY[i])
                    {
                        txt_SampleX.BackColor = Color.Red;
                        txt_SampleY.BackColor = SystemColors.Window;
                        FX[i] = SX;
                        FY[i] = SX * (CCDPixel[i, 1] / CCDPixel[i, 0]);

                    }
                    else if (tempX[i] < tempY[i])
                    {
                        txt_SampleX.BackColor = SystemColors.Window;
                        txt_SampleY.BackColor = Color.Red;
                        FX[i] = SY * (CCDPixel[i, 0] / CCDPixel[i, 1]);
                        FY[i] = SY;
                    }
                    else
                    {
                        txt_SampleX.BackColor = SystemColors.Window;
                        txt_SampleY.BackColor = SystemColors.Window;
                        FX[i] = SX;
                        FY[i] = SY;
                    }
                }
                
                txt_FOVX.Text = FX[CCDList.SelectedIndex].ToString("f2");
                txt_FOVY.Text = FY[CCDList.SelectedIndex].ToString("f2");
                txt_SampleX_real.Text = (FX[CCDList.SelectedIndex] / Convert.ToDouble(txt_FOVratio.Text)).ToString("f2");
                txt_SampleY_real.Text = (FY[CCDList.SelectedIndex] / Convert.ToDouble(txt_FOVratio.Text)).ToString("f2");
                txt_PixelResolution.Text = (Convert.ToDouble(txt_FOVY.Text) / CCDPixel[CCDList.SelectedIndex, 1]).ToString("f4");
                txt_InspectionResolution.Text = (Convert.ToDouble(txt_PixelResolution.Text) * Convert.ToDouble(txt_InspectionResolutionRatio.Text)).ToString("f4");
                txt_MagOPT.Text = (CCDSIZE[CCDList.SelectedIndex, 1] / FY[CCDList.SelectedIndex]).ToString("f3");

                show_data();


                if (txt_FOVX.Text != "0" && txt_FOVY.Text != "0")
                {
                    SHOWInspectionRange();
                }
               
            }
        }
        //依放大倍率計算
        private void MagOPTCalc_Click(object sender, EventArgs e)
        {
            if (SettingMode == (int)mode.MagOPTSetMode)
            {
                notVoidverification(sender);
                txt_FOVX.Text = (CCDSIZE[CCDList.SelectedIndex, 0] / Convert.ToDouble(txt_MagOPT.Text)).ToString("f2");
                txt_FOVY.Text = (CCDSIZE[CCDList.SelectedIndex, 1] / Convert.ToDouble(txt_MagOPT.Text)).ToString("f2");
                txt_PixelResolution.Text = (Convert.ToDouble(txt_FOVY.Text) / CCDPixel[CCDList.SelectedIndex, 1]).ToString("f2");
                txt_InspectionResolution.Text = (Convert.ToDouble(txt_PixelResolution.Text) * Convert.ToDouble(txt_InspectionResolutionRatio.Text)).ToString("f4");
                txt_FOVratio_real.Text = (Convert.ToDouble(txt_FOVY.Text) / Convert.ToDouble(txt_SampleY_real.Text)).ToString("f3");
                show_data();
                lbl_Copystate.Text = "";

                if (txt_FOVX.Text != "0" && txt_FOVY.Text != "0")
                {
                    SHOWInspectionRange();
                }
            }
        }
        //依檢測精度計算
        private void InspectionResolutionCalc_Click(object sender, EventArgs e)
        {
            if (SettingMode == (int)mode.InspectionResoulutionSetMode)
            {
                notVoidverification(sender);
                ///////計算內容///////
                txt_PixelResolution.Text = (Convert.ToDouble(txt_InspectionResolution.Text) / Convert.ToDouble(txt_InspectionResolutionRatio.Text)).ToString("f4");
                txt_FOVX.Text = (Convert.ToDouble(txt_PixelResolution.Text) * CCDPixel[CCDList.SelectedIndex, 0]).ToString("f2");
                txt_FOVY.Text = (Convert.ToDouble(txt_PixelResolution.Text) * CCDPixel[CCDList.SelectedIndex, 1]).ToString("f2");
                txt_MagOPT.Text = (CCDSIZE[CCDList.SelectedIndex, 1] / Convert.ToDouble(txt_FOVY.Text)).ToString("f4");
                //////////////////////

            }
        }
        //依畫素精度計算
        private void PixelResolutionCalc_Click(object sender, EventArgs e)
        {
            if (SettingMode == (int)mode.PixelResoulutionSetMode)
            {

                notVoidverification(sender);
                ///////計算內容///////
                txt_InspectionResolution.Text = (Convert.ToDouble(txt_PixelResolution.Text) * Convert.ToDouble(txt_InspectionResolutionRatio.Text)).ToString("f4");
                txt_FOVX.Text = (Convert.ToDouble(txt_PixelResolution.Text) * CCDPixel[CCDList.SelectedIndex, 0]).ToString("f2");
                txt_FOVY.Text = (Convert.ToDouble(txt_PixelResolution.Text) * CCDPixel[CCDList.SelectedIndex, 1]).ToString("f2");
                txt_MagOPT.Text = (CCDSIZE[CCDList.SelectedIndex, 1] / Convert.ToDouble(txt_FOVY.Text)).ToString("f4");
                //////////////////////


            }
        }
        //依視野範圍計算
        private void FOVXCalc_Click(object sender, EventArgs e)
        {
            if (SettingMode == (int)mode.FOVXSetMode)
            {
                notVoidverification(sender);

                for (int i = 0; i <= dataIndex; i++)
                {
                    FY[i] = Convert.ToDouble(txt_FOVX.Text) * (CCDPixel[i, 1] / CCDPixel[i, 0]);
                }
                txt_FOVY.Text = FY[CCDList.SelectedIndex].ToString("f2");

                ///////計算內容///////
                txt_PixelResolution.Text = (Convert.ToDouble(txt_FOVY.Text) / CCDPixel[CCDList.SelectedIndex, 1]).ToString("f4");
                txt_InspectionResolution.Text = (Convert.ToDouble(txt_PixelResolution.Text) * Convert.ToDouble(txt_InspectionResolutionRatio.Text)).ToString("f4");
                txt_MagOPT.Text = (CCDSIZE[CCDList.SelectedIndex, 1] / FY[CCDList.SelectedIndex]).ToString("f4");
                txt_FOVratio_real.Text = (Convert.ToDouble(txt_FOVY.Text) / Convert.ToDouble(txt_SampleY_real.Text)).ToString("f3");
                
                //////////////////////
                if (txt_FOVX.Text != "0" && txt_FOVY.Text != "0")
                {
                    SHOWInspectionRange();
                }

            }
        }
        private void FOVYCalc_Click(object sender, EventArgs e)
        {
            if (SettingMode == (int)mode.FOVYSetMode)
            {
                notVoidverification(sender);

                for (int i = 0; i <= dataIndex; i++)
                {
                    FX[i] =  Convert.ToDouble(txt_FOVY.Text) * (CCDPixel[i, 0] / CCDPixel[i, 1]);
                }
                
                txt_FOVX.Text = FX[CCDList.SelectedIndex].ToString("f2");
                         
                ///////計算內容///////
                txt_PixelResolution.Text = (Convert.ToDouble(txt_FOVY.Text) / CCDPixel[CCDList.SelectedIndex, 1]).ToString("f4");
                txt_InspectionResolution.Text = (Convert.ToDouble(txt_PixelResolution.Text) * Convert.ToDouble(txt_InspectionResolutionRatio.Text)).ToString("f4");
                txt_MagOPT.Text = (CCDSIZE[CCDList.SelectedIndex, 1] / FY[CCDList.SelectedIndex]).ToString("f4");
                txt_FOVratio_real.Text = (Convert.ToDouble(txt_FOVY.Text) / Convert.ToDouble(txt_SampleY_real.Text)).ToString("f3");
                //////////////////////
                if (txt_FOVX.Text != "0" && txt_FOVY.Text != "0")
                {
                    SHOWInspectionRange();
                }

            }
        }
        //依工作距離計算焦距
        private void lensCalc_wd(object sender, EventArgs e)
        {
            if (SettingMode == (int)mode.WDSetMode)
            {
                txt_lens_wd.Text = trb_lens_wd.Value.ToString();

                txt_lens_focallength.Text = (Convert.ToDouble(Convert.ToDouble(txt_lens_wd.Text) * Convert.ToDouble(txt_MagOPT.Text))).ToString();
                if (trb_lens_focalLength.Maximum > Convert.ToDouble(Convert.ToDouble(txt_lens_wd.Text) * Convert.ToDouble(txt_MagOPT.Text)))
                {
                    trb_lens_focalLength.Value = Convert.ToInt32((Convert.ToDouble(Convert.ToDouble(txt_lens_wd.Text) * Convert.ToDouble(txt_MagOPT.Text))).ToString("f0"));
                }
            }
        }

        private void txt_lens_wd_TextChanged(object sender, EventArgs e)
        {
            if (SettingMode == (int)mode.WDSetMode)
            {
                trb_lens_wd.Value=Convert.ToInt32(txt_lens_wd.Text);

                txt_lens_focallength.Text = (Convert.ToDouble(Convert.ToDouble(txt_lens_wd.Text) * Convert.ToDouble(txt_MagOPT.Text))).ToString();
                if (trb_lens_focalLength.Maximum > Convert.ToDouble(Convert.ToDouble(txt_lens_wd.Text) * Convert.ToDouble(txt_MagOPT.Text)))
                {
                    trb_lens_focalLength.Value = Convert.ToInt32((Convert.ToDouble(Convert.ToDouble(txt_lens_wd.Text) * Convert.ToDouble(txt_MagOPT.Text))).ToString("f0"));
                }
            }
        }
        //依焦距計算工作距離
        private void lensCalc_focalLength(object sender, EventArgs e)
        {
            if (SettingMode == (int)mode.focalLengthSetMode)
            {
                txt_lens_focallength.Text = trb_lens_focalLength.Value.ToString();

                txt_lens_wd.Text = (Convert.ToDouble(Convert.ToDouble(txt_lens_focallength.Text) / Convert.ToDouble(txt_MagOPT.Text))).ToString();
                if (trb_lens_focalLength.Maximum > Convert.ToDouble(Convert.ToDouble(txt_lens_focallength.Text) / Convert.ToDouble(txt_MagOPT.Text)))
                {
                    trb_lens_wd.Value = Convert.ToInt32((Convert.ToDouble(Convert.ToDouble(txt_lens_focallength.Text) / Convert.ToDouble(txt_MagOPT.Text))).ToString("f0"));   
                }
            }
        }
        private void txt_lens_focallength_TextChanged(object sender, EventArgs e)
        {
            if (SettingMode == (int)mode.focalLengthSetMode)
            {
                 trb_lens_focalLength.Value= Convert.ToInt32( txt_lens_focallength.Text) ;
            }
            txt_lens_wd.Text = (Convert.ToDouble(Convert.ToDouble(txt_lens_focallength.Text) / Convert.ToDouble(txt_MagOPT.Text))).ToString();
            if (trb_lens_focalLength.Maximum > Convert.ToDouble(Convert.ToDouble(txt_lens_focallength.Text) / Convert.ToDouble(txt_MagOPT.Text)))
            {
                trb_lens_wd.Value = Convert.ToInt32((Convert.ToDouble(Convert.ToDouble(txt_lens_focallength.Text) / Convert.ToDouble(txt_MagOPT.Text))).ToString("f0"));
            }

        }
        //選擇檢測精度參考倍率
        private void text_InspectionResolutionRatio_TextChanged(object sender, EventArgs e)
        {
            notVoidverification(sender);
            txt_InspectionResolution.Text = Convert.ToString(Convert.ToDouble(txt_PixelResolution.Text) * Convert.ToDouble(txt_InspectionResolutionRatio.Text));
        }


        //顯示計算結果
        private void show_data()
        {
            txt_Data.Clear();

            txt_Data.AppendText("CCD：");
            txt_Data.AppendText(CCDList.SelectedItem + "\r\n");
            
            txt_Data.AppendText("鏡頭：" + "\r\n");
            txt_Data.AppendText("鏡頭倍率：" + txt_MagOPT.Text + "x\r\n");
            txt_Data.AppendText("光源：" + "\r\n");
            txt_Data.AppendText("視野範圍：" + txt_FOVX.Text + "mm * " + txt_FOVY.Text + "mm\r\n");
            txt_Data.AppendText("畫素精度：" + txt_PixelResolution.Text + "mm/pixel" + "\r\n");
            txt_Data.AppendText("檢測精度：" + txt_InspectionResolution.Text + "mm\r\n");

        }
        private void SHOWInspectionRange()
        {
            int windowWidth = 125;
            int windowHeight = 94;

            windowHeight = (int)(windowWidth * (CCDPixel[CCDList.SelectedIndex, 1] / CCDPixel[CCDList.SelectedIndex, 0]));

            Paint_Green.Width = windowWidth;
            Paint_Green.Height = windowHeight;
            try
            {
                Paint_Red.Width = Convert.ToInt32(Convert.ToDouble(txt_SampleX.Text) / Convert.ToDouble(txt_FOVX.Text) * windowWidth);
                Paint_Red.Height = Convert.ToInt32(Convert.ToDouble(txt_SampleY.Text) / Convert.ToDouble(txt_FOVY.Text) * windowHeight);

                Paint_Grey.Width = Convert.ToInt32(Convert.ToDouble(txt_SampleX_real.Text) / Convert.ToDouble(txt_FOVX.Text) * windowWidth);
                Paint_Grey.Height = Convert.ToInt32(Convert.ToDouble(txt_SampleY_real.Text) / Convert.ToDouble(txt_FOVY.Text) * windowHeight);
            }
            catch { }
            Paint_Red.Width = Paint_Red.Width > windowWidth ? windowWidth : Paint_Red.Width;
            Paint_Red.Height = Paint_Red.Height > windowHeight ? windowHeight : Paint_Red.Height;
            Paint_Red.Location = new Point(Paint_Green.Location.X + (Paint_Green.Width - Paint_Red.Width) / 2, Paint_Green.Location.Y + (Paint_Green.Height - Paint_Red.Height) / 2);

            Paint_Grey.Width = Paint_Grey.Width > windowWidth ? windowWidth : Paint_Grey.Width;
            Paint_Grey.Height = Paint_Grey.Height > windowHeight ? windowHeight : Paint_Grey.Height;
            Paint_Grey.Location = new Point(Paint_Green.Location.X + (Paint_Green.Width - Paint_Grey.Width) / 2, Paint_Green.Location.Y + (Paint_Green.Height - Paint_Grey.Height) / 2);
            
        }
        
        #endregion

        #region 按鈕動作
        //說明鈕
        private void Btn_tip_Click(object sender, EventArgs e)
        {
            txt_Data.Text = "1.點選樣品尺寸的「長、寬」可輸入樣品尺寸。" +
                        "旁邊是樣品大小與視野範圍的倍率(預設1.3)。\r\n\r\n" +

                        "2.點選畫素精度/檢測精度可直接設定，獲得視野範圍大小，" +
                        "旁邊是畫素精度與檢測精度的倍率(預設3)。\r\n\r\n" +

                        "3.點選Mag.OPT可輸入鏡頭放大倍率。\r\n\r\n" +

                        "4.右下角區塊可顯示視野範圍、樣品範圍、樣品示意圖。\r\n";
        }
        //開啟計算機
        private void CalcBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
        //開啟記事本
        private void NotepadBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }
        //訊息複製
        private void copy_Click(object sender, EventArgs e)
        {
            txt_Data.SelectAll();
            txt_Data.Copy();
            lbl_Copystate.Text = "訊息已複製...";
        }
        #endregion
        #region 系統

        //日期時間顯示
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = System.DateTime.Now.ToString();
        }
        //模式顯示
        private void ShowMode()
        {
            switch ((int)SettingMode)
            {
                case (int)mode.SampleSizeSetMode:
                    lbl_Mode.Text = "樣品設定";
                    break;
                case (int)mode.MagOPTSetMode:
                    lbl_Mode.Text = "放大倍率設定";
                    break;
                case (int)mode.PixelResoulutionSetMode:
                    lbl_Mode.Text = "畫素精度設定";
                    break;
                case (int)mode.InspectionResoulutionSetMode:
                    lbl_Mode.Text = "檢測精度設定";
                    break;
            }
        }
        //試用版，自動關閉程式計時器
        private void LockTimer(object sender, EventArgs e)
        {
            TimeToClose++;
            if (TimeToClose > 60)
                this.Close();
            lbl_bomb.Text = "關閉倒數時間：" + (60 - TimeToClose).ToString();
        }
        //鍵盤輸入驗證
        private void DataInput(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (Char)48 || e.KeyChar == (Char)49 ||
                   e.KeyChar == (Char)50 || e.KeyChar == (Char)51 ||
                   e.KeyChar == (Char)52 || e.KeyChar == (Char)53 ||
                   e.KeyChar == (Char)54 || e.KeyChar == (Char)55 ||
                   e.KeyChar == (Char)56 || e.KeyChar == (Char)57 ||
                   e.KeyChar == (Char)13 || e.KeyChar == (Char)8 || e.KeyChar == (Char)46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }




        //數值非空白驗證
        private void notVoidverification(object sender)
        {
            TextBox tbx = sender as TextBox;
            if (tbx.Text == "" || tbx.Text == ".")
            {
                tbx.Text = "0";
                tbx.SelectionStart = 0;
                tbx.SelectionLength = 1;
                tbx.Select();
            }
        }
        #endregion







    }
}
