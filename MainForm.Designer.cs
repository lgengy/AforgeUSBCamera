
namespace AforgeUSBCamera
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.cmb_camera = new System.Windows.Forms.ComboBox();
            this.pb_Picture = new System.Windows.Forms.PictureBox();
            this.btn_picture = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.cmb_VideoCapabilities = new System.Windows.Forms.ComboBox();
            this.pb_Frame = new System.Windows.Forms.PictureBox();
            this.btn_Capture = new System.Windows.Forms.Button();
            this.pb_PictureCap = new System.Windows.Forms.PictureBox();
            this.btn_SaveCap = new System.Windows.Forms.Button();
            this.cmb_SnapshotCapabilities = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PictureCap)).BeginInit();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(47, 137);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(392, 259);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // cmb_camera
            // 
            this.cmb_camera.FormattingEnabled = true;
            this.cmb_camera.Location = new System.Drawing.Point(47, 43);
            this.cmb_camera.Name = "cmb_camera";
            this.cmb_camera.Size = new System.Drawing.Size(189, 20);
            this.cmb_camera.TabIndex = 1;
            this.cmb_camera.SelectedIndexChanged += new System.EventHandler(this.cmb_camera_SelectedIndexChanged);
            // 
            // pb_Picture
            // 
            this.pb_Picture.Location = new System.Drawing.Point(483, 137);
            this.pb_Picture.Name = "pb_Picture";
            this.pb_Picture.Size = new System.Drawing.Size(305, 259);
            this.pb_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Picture.TabIndex = 2;
            this.pb_Picture.TabStop = false;
            // 
            // btn_picture
            // 
            this.btn_picture.Enabled = false;
            this.btn_picture.Location = new System.Drawing.Point(635, 43);
            this.btn_picture.Name = "btn_picture";
            this.btn_picture.Size = new System.Drawing.Size(75, 23);
            this.btn_picture.TabIndex = 4;
            this.btn_picture.Text = "拍摄";
            this.btn_picture.UseVisualStyleBackColor = true;
            this.btn_picture.Click += new System.EventHandler(this.btn_picture_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(731, 44);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Enabled = false;
            this.btn_Close.Location = new System.Drawing.Point(542, 43);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "关闭";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // cmb_VideoCapabilities
            // 
            this.cmb_VideoCapabilities.FormattingEnabled = true;
            this.cmb_VideoCapabilities.Location = new System.Drawing.Point(262, 44);
            this.cmb_VideoCapabilities.Name = "cmb_VideoCapabilities";
            this.cmb_VideoCapabilities.Size = new System.Drawing.Size(121, 20);
            this.cmb_VideoCapabilities.TabIndex = 7;
            this.cmb_VideoCapabilities.SelectedIndexChanged += new System.EventHandler(this.cmb_VideoCapabilities_SelectedIndexChanged);
            // 
            // pb_Frame
            // 
            this.pb_Frame.Location = new System.Drawing.Point(914, 137);
            this.pb_Frame.Name = "pb_Frame";
            this.pb_Frame.Size = new System.Drawing.Size(317, 259);
            this.pb_Frame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Frame.TabIndex = 8;
            this.pb_Frame.TabStop = false;
            // 
            // btn_Capture
            // 
            this.btn_Capture.Enabled = false;
            this.btn_Capture.Location = new System.Drawing.Point(1019, 46);
            this.btn_Capture.Name = "btn_Capture";
            this.btn_Capture.Size = new System.Drawing.Size(75, 23);
            this.btn_Capture.TabIndex = 9;
            this.btn_Capture.Text = "捕获";
            this.btn_Capture.UseVisualStyleBackColor = true;
            this.btn_Capture.Click += new System.EventHandler(this.btn_Capture_Click);
            // 
            // pb_PictureCap
            // 
            this.pb_PictureCap.Location = new System.Drawing.Point(1287, 137);
            this.pb_PictureCap.Name = "pb_PictureCap";
            this.pb_PictureCap.Size = new System.Drawing.Size(317, 259);
            this.pb_PictureCap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PictureCap.TabIndex = 10;
            this.pb_PictureCap.TabStop = false;
            // 
            // btn_SaveCap
            // 
            this.btn_SaveCap.Enabled = false;
            this.btn_SaveCap.Location = new System.Drawing.Point(1111, 47);
            this.btn_SaveCap.Name = "btn_SaveCap";
            this.btn_SaveCap.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveCap.TabIndex = 11;
            this.btn_SaveCap.Text = "捕获保存";
            this.btn_SaveCap.UseVisualStyleBackColor = true;
            this.btn_SaveCap.Click += new System.EventHandler(this.btn_SaveCap_Click);
            // 
            // cmb_SnapshotCapabilities
            // 
            this.cmb_SnapshotCapabilities.FormattingEnabled = true;
            this.cmb_SnapshotCapabilities.Location = new System.Drawing.Point(403, 44);
            this.cmb_SnapshotCapabilities.Name = "cmb_SnapshotCapabilities";
            this.cmb_SnapshotCapabilities.Size = new System.Drawing.Size(121, 20);
            this.cmb_SnapshotCapabilities.TabIndex = 12;
            this.cmb_SnapshotCapabilities.SelectedIndexChanged += new System.EventHandler(this.cmb_SnapshotCapabilities_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(274, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "视频分辨率";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(415, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "照片分辨率";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1715, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_SnapshotCapabilities);
            this.Controls.Add(this.btn_SaveCap);
            this.Controls.Add(this.pb_PictureCap);
            this.Controls.Add(this.btn_Capture);
            this.Controls.Add(this.pb_Frame);
            this.Controls.Add(this.cmb_VideoCapabilities);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_picture);
            this.Controls.Add(this.pb_Picture);
            this.Controls.Add(this.cmb_camera);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PictureCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.ComboBox cmb_camera;
        private System.Windows.Forms.PictureBox pb_Picture;
        private System.Windows.Forms.Button btn_picture;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ComboBox cmb_VideoCapabilities;
        private System.Windows.Forms.PictureBox pb_Frame;
        private System.Windows.Forms.Button btn_Capture;
        private System.Windows.Forms.PictureBox pb_PictureCap;
        private System.Windows.Forms.Button btn_SaveCap;
        private System.Windows.Forms.ComboBox cmb_SnapshotCapabilities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

