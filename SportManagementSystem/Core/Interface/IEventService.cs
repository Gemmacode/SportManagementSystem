using SportManagementSystem.Data.DTO;

namespace SportManagementSystem.Core.Interface
{
    public interface IEventService
    {
        Task<EventDTO> GetEventById(int eventId);
        Task<IEnumerable<EventDTO>> GetAllEvents();
        Task<EventDTO> CreateEvent(EventDTO eventDto);
        Task<EventDTO> UpdateEvent(int eventId, EventDTO eventDto);
        Task<bool> DeleteEvent(int eventId);
    }
}
