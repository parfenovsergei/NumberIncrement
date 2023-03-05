﻿using Microsoft.AspNetCore.Mvc;
using NumberIncrementAPI.Models;
using NumberIncrementAPI.ViewModels;

namespace NumberIncrementAPI.Services.Interfaces
{
    public interface IIncrementService
    {
        Task<List<Number>> GetAllNumbersAsync();
        Task<Number> UpdateNumberAsync(int id, int increment);
        Task<Number> UpdateDateAsync(int id, DateTime dateTime);
    }
}
