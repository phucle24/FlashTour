﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using AspNetCoreSpa.Core.Entities;
using AspNetCoreSpa.Core.ViewModels;
using AspNetCoreSpa.Infrastructure;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace AspNetCoreSpa.Web.Controllers.api
{
    public class BannerController : BaseController
    {
        private readonly IUnitOfWork _uow;

        private readonly IMapper _mapper;

        public BannerController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        // GET: api/Banner
        [HttpGet]
        public IActionResult Get()
        {
            var allBanner = _uow.Banners.GetAll().Where(x => x.Censorship);
            return Ok(_mapper.Map<IEnumerable<BannerVM>>(allBanner));
        }

        // GET: api/Banner/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var banner = _uow.Banners.Get(id);
            return Ok(_mapper.Map<BannerVM>(banner));
        }

        // POST: api/Banner
        [HttpPost]
        public void Post([FromBody] BannerVM banner)
        {
            _uow.Banners.Add(_mapper.Map<Banner>(banner));
            _uow.SaveChanges();
        }

        // PUT: api/Banner/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] BannerVM banner)
        {
            var b = _uow.Banners.Get(id);
            b.Name = banner.Name;
            b.Image = banner.Image;
            b.Description = banner.Description;
            b.PostId = banner.PostId;
            _uow.Banners.Update(b);
            var result = _uow.SaveChanges();
            
        }

        // DELETE: api/Banner/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _uow.Banners.Remove(_uow.Banners.Get(id));
            _uow.SaveChanges();
        }
        // Danh sach banner chua kiem duyet
        // GET: 
        [HttpGet("censorship")]
        public IActionResult GetStatusBanner()
        {
            var allBanner =
                from banner in _uow.Banners
                where banner.Censorship == false
                select new
                    BannerVM()
                    {
                        Id = banner.Id,
                        Name = banner.Name,
                        Description = banner.Description,
                        Image = banner.Image,
                        PostId = banner.PostId,
                    };
            return Ok(allBanner);
        }
        // PUT: api/banner/acceptbanner/{id}
        [HttpPut("acceptbanner/{id}")]
        public void PutAcceptBanner(Guid id)
        {
            var b = _uow.Banners.Get(id);
            b.Censorship = true;
            _uow.Banners.Update(b);
            var result = _uow.SaveChanges();
        }
        // PUT: api/tour/uploadImage
        [HttpPost("UploadImage")]
        [DisableRequestSizeLimit]
        [Authorize(Roles = ("admin,Admin,staff,Staff"))]
        public IActionResult UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("ClientApp", "src","assets","images","banners");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
 
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
 
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
 
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}