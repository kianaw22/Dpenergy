﻿using DPEnergy.CommonLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Linq;

namespace DPEnergy.CommonLayer.PublicClass
{
    public class UploadFiles : IUploadFiles
    {

        private readonly IHostingEnvironment _appEnvironment;

        public UploadFiles(IHostingEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }
        public string  UploadAttachmentByPersonelCode(IEnumerable<IFormFile> files, string upload,string personelcode ,  string filename)
        {
            var fulluploadpath = Path.Combine(_appEnvironment.WebRootPath, upload, personelcode );
            if (!Directory.Exists(fulluploadpath))
            {
                Directory.CreateDirectory(fulluploadpath);
            }
            fulluploadpath = Path.Combine(fulluploadpath, filename);
            if (File.Exists(fulluploadpath))
            {
                return "duplicate";
            }
            foreach (var item in files)
            {

                using (var fs = new FileStream(fulluploadpath, FileMode.Create))
                {
                    item.CopyTo(fs);
                }

            }
            return Path.Combine(upload,personelcode, filename);

        }
        public bool DeleteAttachmentByPersonelCode(string uploadPath, string projectcode, string name)
        {
            var upload = Path.Combine(_appEnvironment.WebRootPath, uploadPath);
            var filePath = Path.Combine(upload, projectcode, name);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                return true;
            }

            return false;
        }
        public Tuple<bool, string> UploadNezamvazife(IEnumerable<IFormFile> files, string uploadPath, string name)
        {
            var result = false;
            var upload = Path.Combine(_appEnvironment.WebRootPath, uploadPath , name);


            if (File.Exists(upload))
            {
                result = true;
                return Tuple.Create(result, Path.Combine("wwwroot", uploadPath));
            }

            foreach (var item in files)
            {

                using (var fs = new FileStream  (upload, FileMode.Create))
                {
                    item.CopyTo(fs);
                }

            }
            return Tuple.Create(result, Path.Combine(uploadPath, name)) ;
        }
        public bool DeleteNezamVazife(string uploadPath, string name)
        {
            var upload = Path.Combine(_appEnvironment.WebRootPath, uploadPath);
            var filePath = Path.Combine(upload, name);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                return true;
            }

            return false;
        }
        public string UploadFileFunc(IEnumerable<IFormFile> files, string uploadPath)
        {
            var upload = Path.Combine(_appEnvironment.WebRootPath, uploadPath);
            var filename = "";
            foreach (var item in files)
            {
                filename = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(item.FileName);
                using (var fs = new FileStream(Path.Combine(upload, filename), FileMode.Create))
                {
                    item.CopyTo(fs);
                }

            }
            return filename;
        }


        public string UploadAttachamentFunc(IEnumerable<IFormFile> files, string uploadPath, string username)
        {
            var upload = Path.Combine(_appEnvironment.WebRootPath, uploadPath);

            if (!Directory.Exists(upload + username))
            {
                Directory.CreateDirectory(upload + username);
            }
            upload = upload + username;

            var filename = "";
            foreach (var item in files)
            {
                filename = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(item.FileName);
                using (var fs = new FileStream(Path.Combine(upload, filename), FileMode.Create))
                {
                    item.CopyTo(fs);
                }

            }
            return filename;
        }
        public List<string> UploadMultiAttachment(IEnumerable<IFormFile> files, string uploadpath, string username)
        {
            var upload = Path.Combine(_appEnvironment.WebRootPath, uploadpath);

            if (!Directory.Exists(upload + username))
            {
                Directory.CreateDirectory(upload + username);
            }
            upload = upload + username;
            List<string> filenames = new List<string>();
            foreach ( IFormFile file in files)
            {
               var name = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                using (var fs = new FileStream(Path.Combine(upload, name), FileMode.Create))
                {
                    file.CopyTo(fs);
                }
                filenames.Add(name);
               
            }
            return filenames;
        }
        public string UploadReport(IEnumerable<IFormFile> files, string uploadPath, string projectcode)
        {
            var filename = "";
            var upload = Path.Combine(_appEnvironment.WebRootPath, uploadPath);

            if (!Directory.Exists(upload + projectcode))
            {
                Directory.CreateDirectory(upload + projectcode);
            }
            
            upload = upload + projectcode;
            var f=Path.Combine( upload , files.First().FileName);

            if (System.IO.File.Exists(f))
            {
                filename = "-1";
                return filename;
            }

            foreach (var item in files)
            {
                filename = item.FileName;
                using (var fs = new FileStream(Path.Combine(upload, filename), FileMode.Create))
                {
                    item.CopyTo(fs);
                }

            }
            return Path.Combine(upload , filename);
        }
        public Tuple<bool, string> UploadRevAttchment(IEnumerable<IFormFile> files, string uploadPath, string projectcode , string name )
        {
            var result = false;
            var upload = Path.Combine(_appEnvironment.WebRootPath, uploadPath);

            if (!Directory.Exists(upload + projectcode))
            {
                Directory.CreateDirectory(upload + projectcode);
            }

            upload = upload + projectcode;
            var f = Path.Combine(upload, name);

            if (File.Exists(f))
            {
                result = true;
                return Tuple.Create(result, Path.Combine("wwwroot" , uploadPath + projectcode , name ) );
            }

            foreach (var item in files)
            {
   
                using (var fs = new FileStream(Path.Combine(upload, name), FileMode.Create))
                {
                    item.CopyTo(fs);
                }

            }
            return Tuple.Create(result, Path.Combine( uploadPath + projectcode, name));
        }
        public bool DeleteFile(string uploadPath, string projectcode, string name)
        {
            var upload = Path.Combine(_appEnvironment.WebRootPath, uploadPath);
            var filePath = Path.Combine(upload, projectcode, name);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                return true;
            }

            return false;
        }

    }


}
