using OneBlock.Managers;

using OpenAPI;
using OpenAPI.Plugins;

namespace OneBlock
{
    [OpenPluginInfo(Name = "OneBlock",Description = "You dreamed about it, here it is", Author = "Palente", Version = "", Website = "https://github.com/Palente")]
    public class Plugin : OpenPlugin
    {
        public OpenApi API;
        public override void Disabled(OpenApi api)
        {
            //Destroy game?
        }

        public override void Enabled(OpenApi api)
        {
            API = api;
            api.EventDispatcher.RegisterEvents(new EventsManager(this));
        }
    }
}