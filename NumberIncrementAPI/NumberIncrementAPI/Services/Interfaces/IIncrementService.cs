<<<<<<< HEAD
﻿using NumberIncrementAPI.Models;
=======
﻿using Microsoft.AspNetCore.Mvc;
using NumberIncrementAPI.Models;
using NumberIncrementAPI.ViewModels;
>>>>>>> API_Develop

namespace NumberIncrementAPI.Services.Interfaces
{
    public interface IIncrementService
    {
        Task<List<Number>> GetAllNumbers();
        Task<Number> UpdateNumber(int id, int increment);
<<<<<<< HEAD
=======
        Task<Number> UpdateDate(int id, DateTime dateTime);
>>>>>>> API_Develop
    }
}
