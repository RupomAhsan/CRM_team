using System.Threading.Tasks;
using Abp.Application.Services;
using CRM_team.People.Dtos;

namespace CRM_team.People
{
    public interface IPersonAppService : IApplicationService
    {
        Task<GetAllPeopleOutput> GetAllPeople();
    }
}
