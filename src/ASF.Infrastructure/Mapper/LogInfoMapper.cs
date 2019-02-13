﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASF.Infrastructure.Mapper
{
    public class LogInfoMapper : Profile
    {
        public LogInfoMapper()
        {
            base.CreateMap<ASF.Infrastructure.Model.LogInfo, ASF.Domain.Entities.Logging>().ReverseMap();
        }
    }
}
