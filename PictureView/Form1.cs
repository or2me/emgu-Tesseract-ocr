using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.OCR;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;


namespace 图片查看器
{


    public partial class Form1 : Form
    {

        // 保存打开图片的路径
        string imgPath = null;
        Image newbitmap = null;
       

        // 打开图片的目录
        string directory = null;

        // 目录下的图片集合
        List<string> imgArray = null;
        //bool isRotate = false;

        public Form1()
        {
            InitializeComponent();

            // 必须先打开图片，旋转按钮才可以用

            btnPre.Visible = false;
            btnNext.Visible = false;
        }

        // 打开图片
        public void btnOpen_Click(object sender, EventArgs e)
        {
            string imgPath = "";
           
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "图片文件(*.jpg;*.bmp;*.png;*.gif)|*.jpg;*.bmp;*.gif;*.png|(All file(*.*)|*.*";
                fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    imgPath = fileDialog.FileName;
                    // 初始化图片集合
                    directory = Path.GetDirectoryName(imgPath);
                    imgArray = ImageManager.GetImgCollection(directory);

                    newbitmap=Image.FromFile(imgPath);
                    Bitmap bmp = new Bitmap(newbitmap);
                    picBoxView.Image = bmp ;
                    pictureBox1.Image = Auto2bin(bmp);
                    OCR((Bitmap)pictureBox1.Image);
                }


                btnPre.Visible = true;
                btnNext.Visible = true;
            }
        }

 

        // 上一张图片
        private void btnPre_Click(object sender, EventArgs e)
        {
            int index = GetIndex(imgPath);
            // 释放上一张图片的资源，避免保存的时候出现ExternalException异常
            newbitmap.Dispose();
            
            if (index == 0)
            {
                SwitchImg(imgArray.Count - 1);
            }
            else
            {
                SwitchImg(index - 1);
            }
        }

        // 下一张图片
        private void btnNext_Click(object sender, EventArgs e)
        {
            int index = GetIndex(imgPath);
            // 释放上一张图片的资源，避免保存的时候出现ExternalException异常
            newbitmap.Dispose();
            
            if (index != imgArray.Count - 1)
            {
                SwitchImg(index + 1);
            }
            else
            {
                SwitchImg(0);
            }

        }

        // 获得打开图片在图片集合中的索引
        private int GetIndex(string imagepath)
        {
            int index = 0;    
            for (int i = 0; i < imgArray.Count; i++)
            {
                if (imgArray[i].Equals(imagepath))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        // 切换图片的方法
        private void SwitchImg(int index)
        {       
            newbitmap = Image.FromFile(imgArray[index]);
            picBoxView.Image = newbitmap;
            pictureBox1.Image = Auto2bin((Bitmap)newbitmap);

            OCR((Bitmap)pictureBox1.Image);
            imgPath = imgArray[index];
        }

        //二值化
        private Bitmap Auto2bin(Bitmap img)
        {
            var grayImage = new Image<Gray, Byte>(img);
            if (auto.Checked)
            {
                
                var threshImage = grayImage.ThresholdAdaptive(new Gray(255), AdaptiveThresholdType.MeanC, ThresholdType.Binary, 9, new Gray(5));
                //pictureBox1.Image = threshImage.ToBitmap();
                return threshImage.ToBitmap();
            }
            else if (otu.Checked)
            {
                var threshImge = grayImage.CopyBlank();
                CvInvoke.Threshold(grayImage, threshImge, 0, 255, ThresholdType.Otsu);
                //OCR(threshImge.ToBitmap());
                return threshImge.ToBitmap();
            }
            else if (perf.Checked)
            {
                var threshImage = grayImage.CopyBlank();
                CvInvoke.Threshold(grayImage, threshImage, System.Convert.ToDouble(numericUpDown2.Value.ToString()), 255, ThresholdType.Binary);
                return threshImage.ToBitmap();
            }
            else
                return img;
           
        }

        private static Tesseract _ocr;
        private void  OCR(Bitmap img)
        {
            //Tesseract _ocr;



            //var grayImage = new Image<Gray, Byte>(img);

            try
            {
                Image<Bgr, Byte> image = new Image<Bgr, byte>(img);
                using (Image<Gray, byte> gray = image.Convert<Gray, Byte>())
                {
                    _ocr = new Tesseract(Application.StartupPath + "\\tessdata/", "eng", OcrEngineMode.TesseractOnly);//实例化对象

                    _ocr.SetVariable("tessedit_pageseg_mode", "7");
                    _ocr.SetVariable("tessedit_char_whitelist", "0123456789");
                   // _ocr.SetVariable("tessedit_char_whitelist", "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");

                    _ocr.Recognize(gray);
                    String text = _ocr.GetText();
                    textBox1.Text = text;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


            //return result;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Auto2bin((Bitmap)picBoxView.Image);
        }

        private void mid_CheckedChanged(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(newbitmap);
            picBoxView.Image = bmp;
            pictureBox1.Image = Auto2bin(bmp);
            OCR((Bitmap)pictureBox1.Image);
        }
    }
}
