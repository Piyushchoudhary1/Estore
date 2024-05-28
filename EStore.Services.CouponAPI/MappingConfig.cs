﻿using AutoMapper;
using EStore.Services.CouponAPI.Models;
using EStore.Services.CouponAPI.Models.Dto;

namespace EStore.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
