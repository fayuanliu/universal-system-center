using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UniversalSystemCenter.Core.Upload.Param;
using UniversalSystemCenter.Core.Utils;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace UniversalSystemCenter.Core.Upload
{
    public class UploadFile : IUploadFile
    {
        private IHostingEnvironment _hostingEnv;
        public UploadFile(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnv = hostingEnvironment;
        }

        /// <summary>
        /// 普通上传
        /// </summary>
        /// <param name="module"></param>
        /// <param name="files"></param>
        /// <returns></returns>
        public async Task<List<FileInfoParam>> Upload(string module, IFormCollection files, string[] attrIds)
        {
            List<FileInfoParam> listFileInfo = new List<FileInfoParam>();
            string relativePath = string.Format(@"/upload/{0}/{1}", module, DateTime.Now.ToString("yyyyMMdd"));
            string path = string.Format("{0}{1}", _hostingEnv.WebRootPath, relativePath);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            int i = 0;
            foreach (var item in files.Files)
            {
                FileInfoParam fileInfo = new FileInfoParam()
                {
                    AttachmentId = attrIds[i],
                    FileName = item.FileName,
                    Size = item.Length,
                    Module = module
                };
                var fileExtion = Path.GetExtension(item.FileName);
                var fileName = string.Format(@"{0}/{1}{2}", path, fileInfo.AttachmentId, fileExtion);
                await Task.Run(() =>
                {
                    FileStream fs = new FileStream(fileName, FileMode.Create);
                    item.CopyTo(fs);
                    fs.Close();
                });
                fileInfo.FileType = fileInfo.FileType = GetFileType(fileExtion);
                fileInfo.LocalUrl = string.Format(@"{0}/{1}{2}", relativePath, fileInfo.AttachmentId, fileExtion);
                listFileInfo.Add(fileInfo);
            }
            return listFileInfo;
        }

        /// <summary>
        /// 图片上传
        /// </summary>
        /// <param name="module">所属模块</param>
        /// <param name="isZip">是否压缩</param>
        /// <param name="isZoom">是否生成缩略图</param>
        /// <param name="files">文件</param>
        /// <returns></returns>
        public List<FileInfoParam> Upload(string module, bool isZip, bool isZoom, IFormCollection files, string[] attrIds)
        {
            List<FileInfoParam> listFileInfo = new List<FileInfoParam>();
            string relativePath = string.Format(@"/upload/{0}/{1}", module, DateTime.Now.ToString("yyyyMMdd"));
            string path = string.Format("{0}{1}", _hostingEnv.WebRootPath, relativePath);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            int i = 0;
            foreach (var item in files.Files)
            {
                FileInfoParam fileInfo = new FileInfoParam()
                {
                    AttachmentId = attrIds[i],
                    FileName = item.FileName,
                    Size = item.Length,
                    Module = module
                };
                var fileExtion = Path.GetExtension(item.FileName);
                var fileName = string.Format(@"{0}/{1}{2}", path, fileInfo.AttachmentId, fileExtion);
                Task.Run(() =>
                {
                    FileStream fs = new FileStream(fileName, FileMode.Create);
                    item.CopyTo(fs);
                    fs.Close();
                    fs.Dispose();
                }).GetAwaiter().GetResult();
                var saveFileName = string.Format(@"{0}/{1}{2}", path, fileInfo.AttachmentId, fileExtion);
                ImageUtil.JpgImgZip(fileName, saveFileName, isZoom);
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                fileInfo.FileType = fileInfo.FileType = GetFileType(fileExtion);
                fileInfo.LocalUrl = string.Format(@"{0}/{1}{2}", relativePath, fileInfo.AttachmentId, fileExtion);
                listFileInfo.Add(fileInfo);
                i++;
            }
            return listFileInfo;
        }

      

        /// <summary>
        /// 全景上传
        /// </summary>
        /// <param name="resourceId"></param>
        /// <param name="files"></param>
        /// <returns></returns>
        public async Task<List<FileInfoParam>> UploadPanoImage(string resourceId, IFormCollection files, string[] attrIds)
        {
            List<FileInfoParam> listFileInfo = new List<FileInfoParam>();
            string relativePath = string.Format(@"/upload/Pano/{0}/", resourceId);
            string path = string.Format("{0}{1}", _hostingEnv.WebRootPath, relativePath);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            int i = 0;
            foreach (var item in files.Files)
            {
                FileInfoParam fileInfo = new FileInfoParam()
                {
                    AttachmentId = attrIds[i],
                    FileName = item.FileName,
                    Size = item.Length,
                    Module = resourceId
                };
                var fileExtion = Path.GetExtension(item.FileName);
                var fileName = string.Format(@"{0}{1}{2}", path, fileInfo.AttachmentId, fileExtion);
                await Task.Run(() =>
                {
                    FileStream fs = new FileStream(fileName, FileMode.Create);
                    item.CopyTo(fs);
                    fs.Close();
                });
                var type = fileInfo.FileType = GetFileType(fileExtion);
                fileInfo.FileType = type;
                if (type != FileType.Image)
                {
                    throw new Exception("全景只能上传图片");
                }
                fileInfo.LocalUrl = string.Format(@"{0}{1}{2}", relativePath, fileInfo.AttachmentId, fileExtion);
                listFileInfo.Add(fileInfo);
                i++;
            }
            return listFileInfo;
        }

        private FileType GetFileType(string extion)
        {
            switch (extion.ToLower())
            {
                case ".jpg":
                case ".jpeg":
                case ".png":
                case ".gif":
                    return FileType.Image;
                case ".zip":
                case ".rar":
                    return FileType.Zip;
                case ".mp3":
                case ".waw":
                    return FileType.Audio;
                case ".xls":
                case ".xlsx":
                    return FileType.Excel;
                case ".pdf":
                    return FileType.PDF;
                case ".ppt":
                case ".pptx":
                    return FileType.PPT;
                case ".txt":
                    return FileType.Text;
                case ".mp4":
                case ".avi":
                case ".rm":
                    return FileType.Video;
                case "doc":
                case "docx":
                    return FileType.Word;
                case ".exe":
                case ".mis":
                    return FileType.Executable;
                default:
                    return FileType.UnKnow;
            }
        }
    }
}
