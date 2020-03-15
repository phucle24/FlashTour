﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AspNetCoreSpa.Core.Entities
{
    public class Post : AuditableEntity, IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string Name { get; set; }
        [Column(TypeName = "NVARCHAR(200)")]
        public string PostContent { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string Description { get; set; }
        [Column(TypeName = "NVARCHAR(255)")]
        public string Image { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string MetaDescription { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string MetaKeyWord { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string Alias { get; set; }
        public bool Status { get; set; }
        public bool Censorship { get; set; }
        public bool Deleted { get; set; }
        public int PostCategoryId { get; set; }
        public PostCategory PostCategory { get; set; }
    }
}
