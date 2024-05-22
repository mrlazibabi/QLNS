using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QLNS.Entities;
using QLNS.Models.QuanLiNhanSuModels;

namespace QLNS.Services.Implements
{
    public class UserServices : IUserServices
    {
        private readonly IMapper _mapper;
        private readonly QLNSContext _context;

        public UserServices(IMapper mapper, QLNSContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<string> AddUserAsync(UserModel model)
        {
            try
            {
                var newUser = _mapper.Map<User>(model);
                _context.Users!.Add(newUser);
                await _context.SaveChangesAsync();

                return newUser.Id;
            }
            catch (Exception ex)
            {
                return ex.InnerException.Message;
            }
        }

        public Task DeleteUserAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserModel>> GetAllUserAsync()
        {
            var users = await _context.Users!.ToListAsync();
            return _mapper.Map<List<UserModel>>(users);
        }

        public async Task<UserModel> GetUserByIdAsync(string id)
        {
            var user = await _context.Users!.FindAsync(id);
            return _mapper.Map<UserModel>(user);
        }

        public async Task UpdateUserAsync(string id, UserModel model)
        {
            _context.UserModel.Update(model);
            await _context.SaveChangesAsync();
        }
    }
}
