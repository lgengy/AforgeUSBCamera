using AForge.Video;
using AForge.Video.DirectShow;
using log4net;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AforgeUSBCamera
{
    public partial class MainForm : Form
    {
        private FilterInfoCollection videoDevices;//摄像头设备集合
        private VideoCaptureDevice videoSource;//捕获设备源
        private Bitmap img;
        private static readonly ILog logger = LogManager.GetLogger("AforgeUSBCamera");

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //先检测电脑所有的摄像头
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            logger.Info($"检测到了{videoDevices.Count}个摄像头！");

            foreach (FilterInfo el in videoDevices)
            {
                cmb_camera.Items.Add(el.Name);
            }
            cmb_camera.SelectedItem = null;
        }

        private void cmb_camera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_camera.SelectedIndex != -1)
            {
                ShutCamera();

                videoSource = new VideoCaptureDevice(videoDevices[cmb_camera.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);

                //列出视频流分辨率
                cmb_VideoCapabilities.Items.Clear();
                foreach(VideoCapabilities videoCapabilities in videoSource.VideoCapabilities)
                {
                    cmb_VideoCapabilities.Items.Add($"{videoCapabilities.FrameSize.Width}*{videoCapabilities.FrameSize.Height}");
                }

                //videoSource.ProvideSnapshots = true;//按下摄像头上的拍照按钮时可触发snapshotframe事件,默认false
                //列出快照分辨率，有的有，有的没有
                cmb_SnapshotCapabilities.Items.Clear();
                foreach (VideoCapabilities videoCapabilities in videoSource.SnapshotCapabilities)
                {
                    cmb_SnapshotCapabilities.Items.Add($"{videoCapabilities.FrameSize.Width}*{videoCapabilities.FrameSize.Height}");
                }

                videoSourcePlayer1.VideoSource = videoSource;
                videoSourcePlayer1.Start();
                logger.Info($"open {videoDevices[cmb_camera.SelectedIndex].Name} succesfully");

                btn_picture.Enabled = true;//开启“拍摄功能”
                btn_Close.Enabled = true;
                btn_Capture.Enabled = true;
            }
        }

        /// <summary>
        /// 切换视频分辨率
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_VideoCapabilities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(videoSource != null && cmb_VideoCapabilities.SelectedIndex != -1)
            {
                videoSource.Stop();
                videoSource.VideoResolution = videoSource.VideoCapabilities[cmb_VideoCapabilities.SelectedIndex];
                logger.Info($"change video resolution to {videoSource.VideoResolution.FrameSize.Width}*{videoSource.VideoResolution.FrameSize.Height}");
                videoSource.Start();
            }
        }

        /// <summary>
        /// 切换快照分辨率
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_SnapshotCapabilities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoSource != null && cmb_SnapshotCapabilities.SelectedIndex != -1)
            {
                videoSource.Stop();
                //罗技webcam600有这个分辨率，然而看起来没有什么用，还是通过VideoResolution设置分别率效果明显
                videoSource.SnapshotResolution = videoSource.SnapshotCapabilities[cmb_SnapshotCapabilities.SelectedIndex];
                logger.Info($"change snapshot resolution to {videoSource.SnapshotResolution.FrameSize.Width}*{videoSource.SnapshotResolution.FrameSize.Height}");
                videoSource.Start();
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bm = (Bitmap)eventArgs.Frame.Clone();
            pb_Frame.Image = bm;
            GC.Collect();
        }

        /// <summary>
        /// 直接从视频框拍摄照片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_picture_Click(object sender, EventArgs e)
        {
            try
            {
                img = videoSourcePlayer1.GetCurrentVideoFrame();//拍摄
                pb_Picture.Image = img;
                btn_save.Enabled = true;//开启“保存”功能
            }
            catch (Exception ex)
            {
                logger.Warn("拍照失败");
                logger.Error("拍照失败", ex);
            }
        }

        /// <summary>
        /// 从帧框获取图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Capture_Click(object sender, EventArgs e)
        {
            pb_PictureCap.Image = pb_Frame.Image;
            img = new Bitmap(pb_PictureCap.Image);
            btn_SaveCap.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                //以当前时间为文件名，保存为jpg格式
                //图片路径在程序bin目录下的Debug下
                TimeSpan tss = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
                long a = Convert.ToInt64(tss.TotalMilliseconds) / 1000;  //以秒为单位
                img.Save(string.Format("{0}.jpg", a.ToString()));
                logger.Info($"图像保存至{string.Format("{0}.jpg", a.ToString())}");
                btn_save.Enabled = false;
            }
            catch(Exception ex)
            {
                logger.Warn("保存失败");
                logger.Error("保存失败", ex);
            }
            
        }

        private void btn_SaveCap_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan tss = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
                string a = "cap" + Convert.ToInt64(tss.TotalMilliseconds) / 1000;  //以秒为单位
                img.Save(string.Format("{0}.jpg", a.ToString()));
                logger.Info($"图像保存至{string.Format("{0}.jpg", a.ToString())}");
                btn_save.Enabled = false;
            }
            catch(Exception ex)
            {
                logger.Warn("保存失败");
                logger.Error("保存失败", ex);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            ShutCamera();
            cmb_camera.SelectedItem = null;
            cmb_VideoCapabilities.Items.Clear();
            cmb_SnapshotCapabilities.Items.Clear();
            btn_picture.Enabled = false;
            btn_save.Enabled = false;
            btn_SaveCap.Enabled = false;
            btn_Capture.Enabled = false;
            btn_SaveCap.Enabled = false;

            pb_Frame.Image = null;
            pb_Picture.Image = null;
            pb_PictureCap.Image = null;
        }

        // 关闭并释放摄像头
        private void ShutCamera()
        {
            if (videoSourcePlayer1.VideoSource != null)
            {
                logger.Info("关闭摄像头");
                videoSourcePlayer1.SignalToStop();
                videoSourcePlayer1.WaitForStop();
                videoSourcePlayer1.VideoSource = null;
                videoSource = null;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShutCamera();
        }
    }
}
