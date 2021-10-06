﻿using System.Threading.Tasks;
using Web.ViewModels;

namespace Web.Interfaces
{
    public interface IHomeViewModelService
    {
        Task<HomeViewModel> GetHomeViewModelAsync(int? categoryId, int? brandId, int page);
    }
}
