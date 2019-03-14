using UniversalSystemCenter.Core.Upload.Param;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UniversalSystemCenter.Core.Upload
{
    public interface IUploadFile
    {
        /// <summary>
        /// 文件上传
        /// </summary>
        /// <param name="module"></param>
        /// <param name="files"></param>
        /// <returns></returns>
        Task<List<FileInfoParam>> Upload(string module, IFormCollection files,string [] attrIds);

        /// <summary>
        /// 全景上传
        /// </summary>
        /// <param name="resourceId"></param>
        /// <param name="files"></param>
        /// <returns></returns>
        Task<List<FileInfoParam>> UploadPanoImage(string resourceId, IFormCollection files, string[] attrIds);


        /// <summary>
        /// 图片上传
        /// </summary>
        /// <param name="module">所属模块</param>
        /// <param name="isZip">是否压缩</param>
        /// <param name="isZoom">是否生成缩略图</param>
        /// <param name="files">文件</param>
        /// <returns></returns>
        List<FileInfoParam> Upload(string module, bool isZip, bool isZoom, IFormCollection files, string[] attrIds);
    }
}
