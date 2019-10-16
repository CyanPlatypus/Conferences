﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConfService.Dto
{
    public class LectureDto
    {
        public int Id { get; set; }
        [StringLength(200)]
        [Required]
        public string Topic { get; set; }

        [StringLength(8000)]
        public string Info { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateTimeStart { get; set; }
        [Required]
        public int SectionId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateTimeOpenChat { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateTimeCloseChat { get; set; }
        
        //public ICollection<FileDto> Files { get; set; } = new List<FileDto>();

        public ICollection<UserInfoDto> Speakers { get; set; } = new List<UserInfoDto>();
    }
}