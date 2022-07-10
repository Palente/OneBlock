using OpenAPI.Events;
using OpenAPI.Events.Player;

namespace OneBlock.Managers
{
    internal class EventsManager : IEventHandler
    {
        private readonly Plugin _caller;
        public EventsManager(Plugin caller)
        {
            _caller = caller;
        }


        [EventHandler]
        public void OnJoin(PlayerJoinEvent ev)
        {
            
        }

    }
}
