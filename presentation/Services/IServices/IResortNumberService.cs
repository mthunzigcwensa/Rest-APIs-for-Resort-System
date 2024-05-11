﻿using presentation.Models.Dto;

namespace presentation.Services.IServices
{
    public interface IResortNumberService
    {
        Task<T> GetAllAsync<T>(string token);
        Task<T> GetAsync<T>(int id, string token);
        Task<T> CreateAsync<T>(ResortNumberCreateDTO dto, string token);
        Task<T> UpdateAsync<T>(ResortNumberUpdateDTO dto, string token);
        Task<T> DeleteAsync<T>(int id, string token);
    }
}
