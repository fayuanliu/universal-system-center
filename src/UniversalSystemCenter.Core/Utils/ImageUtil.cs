using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;

namespace UniversalSystemCenter.Core.Utils
{
    public class ImageUtil
    {

        /// <summary>
        /// 图片压缩
        /// </summary>
        /// <param name="img">图片对象</param>
        /// <param name="filePath">保存路径</param>
        private static void JpgImgZip(Image img, string filePath)
        {
            //以下代码为保存图片时，设置压缩质量
            EncoderParameters ep = new EncoderParameters();
            long[] qy = new long[1];
            qy[0] = 50;//设置压缩的比例1-100 
            EncoderParameter eParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qy);
            ep.Param[0] = eParam;
            try
            {
                ImageCodecInfo jpegICIinfo = GetEncoderInfo("JPG");
                if (jpegICIinfo != null)
                {
                    img.Save(filePath, jpegICIinfo, ep);//dFile是压缩后的新路径
                }
                else
                {
                    img.Save(filePath, ImageFormat.Jpeg);
                }
            }
            catch (Exception)
            {
                img.Save(filePath, ImageFormat.Jpeg);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileExtenUper"></param>
        /// <returns></returns>
        public static ImageCodecInfo GetEncoderInfo(String fileExtenUper)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].FilenameExtension.Contains(fileExtenUper))
                {
                    return encoders[j];
                }
            }
            return null;
        }


        /// <summary>
        /// 图片压缩并根据高和宽生成相应的规格
        /// </summary>
        /// <param name="img">图片对象</param>
        /// <param name="filePath">保存路径</param>
        /// <param name="isZoom">是否生成缩略图</param>
        public static void JpgImgZip(string formPath, string savePath, bool isZoom)
        {
            var img = Image.FromFile(formPath);
            try
            {
                if (!isZoom)
                {
                    JpgImgZip(img, savePath);
                }
                else
                {
                    img = Thumbnail(img);
                    img.Save(savePath, ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("压缩图片失败", ex);
            }
            finally
            {
                img.Dispose();
            }
        }



        /// <summary> 
        /// 按照指定的高和宽生成相应的规格的图片，采用此方法生成的缩略图片不会失真 
        /// </summary>
        /// /// <param name="width">指定宽度</param> 
        /// /// <param name="height">指定高度</param> 
        /// /// <param name="imageFrom">原图片</param> 
        /// /// <returns>返回新生成的图</returns> 
        private static Image Thumbnail(Image imageFrom, int width = 100, int height = 100)
        {
            // 源图宽度及高度
            int imageFromWidth = imageFrom.Width;
            int imageFromHeight = imageFrom.Height;

            //模版的宽高比例
            double templateRate = (double)width / height;

            //原图片的宽高比例
            double initRate = (double)imageFromWidth / imageFromHeight;

            # region 生成的缩略图实际宽度及高度.如果指定的高和宽比原图大，则返回原图；否则按照指定高宽生成图片
            if (width >= imageFromWidth && height >= imageFromHeight)
            {
                return imageFrom;
            }
            #endregion
            #region 原图与模版比例相等，直接缩放
            if (templateRate == initRate)
            {
                //按模版大小生成最终图片
                Image templateImg = new Bitmap(width, height);
                Graphics g = Graphics.FromImage(templateImg);
                g.InterpolationMode = InterpolationMode.High;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.Clear(Color.Transparent);
                g.DrawImage(imageFrom, new Rectangle(0, 0, width, height), new Rectangle(0, 0, imageFromWidth, imageFromHeight), GraphicsUnit.Pixel);
                g.Dispose();
                return templateImg;
            }
            #endregion

            #region 原图与模版比例不等，裁剪后缩放

            //裁剪对象
            Image pickedImage = null;
            Graphics pickedG = null;
            //定位
            Rectangle fromR = new Rectangle(0, 0, 0, 0);//原图裁剪定位
            Rectangle toR = new Rectangle(0, 0, 0, 0);//目标定位
            //宽为标准进行裁剪
            if (templateRate > initRate)
            {
                //裁剪对象实例化
                pickedImage = new Bitmap(imageFromWidth, (int)Math.Floor(imageFromWidth / templateRate));
                pickedG = Graphics.FromImage(pickedImage);

                //裁剪源定位
                fromR.X = 0;
                fromR.Y = (int)Math.Floor((imageFromHeight - imageFromWidth / templateRate) / 2);
                fromR.Width = imageFromWidth;
                fromR.Height = (int)Math.Floor(imageFromWidth / templateRate);
                //裁剪目标定位
                toR.X = 0;
                toR.Y = 0;
                toR.Width = imageFromWidth;
                toR.Height = (int)Math.Floor(imageFromWidth / templateRate);
            }
            //高为标准进行裁剪
            else
            {
                pickedImage = new Bitmap((int)Math.Floor(imageFromHeight * templateRate), imageFromHeight);
                pickedG = Graphics.FromImage(pickedImage);

                fromR.X = (int)Math.Floor((imageFromWidth - imageFromHeight * templateRate) / 2);
                fromR.Y = 0;
                fromR.Width = (int)Math.Floor(imageFromHeight * templateRate);
                fromR.Height = imageFromHeight;

                toR.X = 0;
                toR.Y = 0;
                toR.Width = (int)Math.Floor(imageFromHeight * templateRate);
                toR.Height = imageFromHeight;
            }
            //设置质量
            pickedG.InterpolationMode = InterpolationMode.HighQualityBicubic;
            pickedG.SmoothingMode = SmoothingMode.HighQuality;
            //裁剪
            pickedG.DrawImage(imageFrom, toR, fromR, GraphicsUnit.Pixel);
            //按模版大小生成最终图片
            Image templateImage = new Bitmap(width, height);
            Graphics templateG = Graphics.FromImage(templateImage);
            templateG.InterpolationMode = InterpolationMode.High;
            templateG.SmoothingMode = SmoothingMode.HighQuality;
            templateG.Clear(Color.Transparent);
            templateG.DrawImage(pickedImage, new Rectangle(0, 0, width, height), new Rectangle(0, 0, pickedImage.Width, pickedImage.Height), GraphicsUnit.Pixel);
            pickedImage.Dispose();
            pickedG.Dispose();
            templateG.Dispose();
            return templateImage;
            #endregion
        }

    }
}
