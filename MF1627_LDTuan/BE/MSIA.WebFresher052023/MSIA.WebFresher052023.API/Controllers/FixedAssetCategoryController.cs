﻿using Application.DTO.FixedAssetCategoryy;
using Application.Interface;
using AutoMapper;
using Domain.Entity;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using MSIA.WebFresher052023.API.Controllers.Base;
using MSIA.WebFresher052023.Application.Interface.Base;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FixedAssetCategoryController : BaseSearchPagingController<FixedAssetCategory, FixedAssetCategoryModel, FixedAssetCategoryDto, FixedAssetCategoryCreateDto, FixedAssetCategoryUpdateDto, FixedAssetCategoryUpdateMultiDto>
    {
        public FixedAssetCategoryController(IFixedAssetCategoryService fixedAssetCategoryService, IMapper mapper) : base(fixedAssetCategoryService, mapper)
        {
        }
    }
}