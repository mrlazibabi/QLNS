﻿using QLNS.Models.QuanLiNhanSuModels;

namespace QLNS.Services
{
    public interface IUserServices
    {
        public Task<List<UserModel>> GetAllUserAsync();
        public Task<UserModel> GetUserByIdAsync(string id);
        public Task<string> AddUserAsync(UserModel model);
        public Task UpdateUserAsync(string id, UserModel model);
        public Task DeleteUserAsync(string id);
    }
}
