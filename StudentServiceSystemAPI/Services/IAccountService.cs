﻿using StudentServiceSystemAPI.DtoModels;

namespace StudentServiceSystemAPI.Services
{
    public interface IAccountService
    {
        void RegisterUser(RegisterUserDto dto);
        string GenerateJwt(LoginDto dto);
        Task ChangeRole(int userId, string role);
    }
}
