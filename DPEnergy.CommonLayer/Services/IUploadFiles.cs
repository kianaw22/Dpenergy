using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPEnergy.CommonLayer.Services
{

    public interface IUploadFiles
    {
        string UploadFileFunc(IEnumerable<IFormFile> files, string uploadPath);
        public string UploadAttachamentFunc(IEnumerable<IFormFile> files, string uploadPath, string username);
        public List<string> UploadMultiAttachment(IEnumerable<IFormFile> files, string uploadpath, string username);
        public string UploadReport(IEnumerable<IFormFile> files, string uploadPath, string projectcode);
        public Tuple<bool, string> UploadRevAttchment(IEnumerable<IFormFile> files, string uploadPath, string projectcode, string name);
        public bool DeleteFile(string uploadPath, string projectcode, string name);
        public Tuple<bool, string> UploadNezamvazife(IEnumerable<IFormFile> files, string uploadPath, string name);
        public bool DeleteNezamVazife(string uploadPath, string name);
        public string UploadAttachmentByPersonelCode(IEnumerable<IFormFile> files, string upload, string personelcode, string filename);
        public bool DeleteAttachmentByPersonelCode(string uploadPath, string projectcode, string name);
    }
}
