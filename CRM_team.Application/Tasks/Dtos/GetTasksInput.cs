using Abp.Application.Services.Dto;

namespace CRM_team.Tasks.Dtos
{
    public class GetTasksInput : IInputDto
    {
        public TaskState? State { get; set; }

        public int? AssignedPersonId { get; set; }
    }
}