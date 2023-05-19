using NajotEdu.Application.Abstraction;
using NajotEdu.Application.Models;

namespace NajotEdu.Application.Services
{
    public class GroupService : IGroupService
    {
        public async Task<string> Create(CreatGroupModel createModel)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GroupViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<GroupViewModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(UpdateViewModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
