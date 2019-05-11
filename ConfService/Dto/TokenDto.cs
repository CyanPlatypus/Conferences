﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConfService.Dto
{
    public class TokenDto
    {
        public string Token { get; set; }
        public DateTime ExpirationTime { get; set; }

        public bool IsGlobalAdmin { get; set; }
        public ICollection<int> PresentedLectures { get; set; }
        public ICollection<int> SubscribedLectures { get; set; }
        public ICollection<int> AdminnedConferences { get; set; }
    }
}
