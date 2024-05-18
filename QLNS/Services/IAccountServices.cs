using QLNS.Models.AuthenModels;
using static QLNS.Models.AuthenModels.ServiceResponses;

namespace QLNS.Services
{
    public interface IAccountServices
    {
        public Task<GeneralResponse> SignUpAsync(SignUpModel model);
        public Task<LoginResponse> SignInAsync(SignInModel model);
    }
}
