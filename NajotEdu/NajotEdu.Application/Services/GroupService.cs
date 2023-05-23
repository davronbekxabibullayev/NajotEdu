 using Microsoft.EntityFrameworkCore;
using NajotEdu.Application.Abstraction;
using NajotEdu.Application.Models;
using NajotEdu.Domain.Entities;

namespace NajotEdu.Application.Services
{
    public class GroupService : IGroupService
    {
        private readonly IApplicationDbContext _dbContext;
        public GroupService(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<string> Create(CreateGroupModel createModel)
        {
            var group = await _dbContext.Groups.FirstOrDefaultAsync(a => a.Name == createModel.Name
            && a.EndDate == createModel.EndDate && a.StartDate == createModel.StartDate
            && a.TeacherId == createModel.TeacherId);

            if (group != null)
            {
                throw new Exception("This group is already exist!");
            }

            var newGroup = new Group()
            {
                Name = createModel.Name,
                EndDate = createModel.EndDate,
                StartDate = createModel.StartDate,
                TeacherId = createModel.TeacherId
            };

            _dbContext.Groups.Add(newGroup);
            await _dbContext.SaveChangesAsync();

            return "New group is saved";

        }

        public async Task<int> Delete(int Id)
        {
            var group = await _dbContext.Groups.FirstOrDefaultAsync(a => a.Id == Id);

            if (group != null)
            {
                throw new Exception("not found");
            }

            _dbContext.Groups.Remove(group);
            await _dbContext.SaveChangesAsync();

            return Id;
        }

        public async Task<IEnumerable<GroupViewModel>> GetAll()
        {
            var groups = await _dbContext.Groups.Select(a => new GroupViewModel()
            {
                EndDate = a.EndDate,
                StartDate = a.StartDate,
                Name = a.Name
            }).ToListAsync();

            if (groups.Count == 0)
            {
                throw new Exception("Sorry, There isn't any groups.");
            }

            return groups;
        }

        public async Task<GroupViewModel> GetById(int id)
        {
            var group = await _dbContext.Groups.FirstOrDefaultAsync(a => a.Id == id);

            if (group != null)
            {
                throw new Exception("not found");
            }

            return new GroupViewModel()
            {
                EndDate = group.EndDate,
                StartDate = group.StartDate,
                Name = group.Name
            };
        }

        public async Task<int> Update(UpdateGroupViewModel updateModel)
        {
            var group = await _dbContext.Groups.FirstOrDefaultAsync(a => a.Id == updateModel.Id);

            if (group != null)
            {
                throw new Exception("Not found");
            }

            group.StartDate = updateModel.StartDate;
            group.EndDate = updateModel.EndDate;
            group.Name = updateModel.Name;
            group.TeacherId = updateModel.TeacherId;

            _dbContext.Groups.Update(group);
            await _dbContext.SaveChangesAsync();
            return group.Id;
        }
    }
}
