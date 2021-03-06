﻿using System;
using System.Collections.Generic;
using System.Text;
using ConfModel.Model;
using ConfRepository.Interface;

namespace ConfRepository.Repository
{
    public class SectionRepository : BaseRepository<Section>, ISectionRepository
    {
        public SectionRepository(ConfContext confContext) : base(confContext)
        { }
    }
}
