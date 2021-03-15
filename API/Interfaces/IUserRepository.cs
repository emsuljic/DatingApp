using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Helpers;

namespace API.Interfaces
{
    public interface IUserRepository
    {

        //allow user to update
        void Update(AppUser user);

        //save all changes
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task <AppUser> GetUserByIdAsync(int id);
        Task <AppUser> GetUserByUsernameAsync(string username);
        Task <PagedList<MemberDto>> GetMembersAsync(UserParams userParams);
        Task <MemberDto> GetMemberAsync(string username);
    }
}