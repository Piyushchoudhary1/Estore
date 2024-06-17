﻿using EStore.Web.Models;
//using EStore.Web.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStore.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto> GetCouponAsync(string couponCode);
        Task<ResponseDto> GetAllCouponsAsync();
        Task<ResponseDto> GetCouponByIdAsync(int id);
        Task<ResponseDto> CreateCouponsAsync(CouponDto couponDto);
        Task<ResponseDto> UpdateCouponAsync(CouponDto couponDto);
        Task<ResponseDto> DeleteCouponAsync(int id);
    }
}
