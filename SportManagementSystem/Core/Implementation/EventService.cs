using SportManagementSystem.Core.Interface;
using SportManagementSystem.Data.DTO;
using SportManagementSystem.Model.APIResponse;
using SportManagementSystem.Model.Enum;

namespace SportManagementSystem.Core.Implementation
{
    public class EventService : IEventService
    {
        public Task<EventDTO> CreateEvent(EventDTO eventDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEvent(int eventId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EventDTO>> GetAllEvents()
        {
            throw new NotImplementedException();
        }

        public Task<EventDTO> GetEventById(int eventId)
        {
            throw new NotImplementedException();
        }

        public Task<EventDTO> UpdateEvent(int eventId, EventDTO eventDto)
        {
            throw new NotImplementedException();
        }
    }
}

