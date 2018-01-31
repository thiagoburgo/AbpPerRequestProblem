﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PerRequestProblemSite.MultiTenancy.Dto;

namespace PerRequestProblemSite.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
