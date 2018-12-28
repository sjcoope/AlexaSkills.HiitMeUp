using Alexa.NET;
using Alexa.NET.RequestHandlers;
using Alexa.NET.RequestHandlers.Handlers;
using Alexa.NET.Response;
using Alexa.NET.Response.Ssml;

namespace SJCNet.AlexaSkills.HiitMeUp.RequestHandler
{
    public class Launch : LaunchSynchronousRequestHandler
    {
        public override SkillResponse HandleSyncRequest(AlexaRequestInformation information)
        {
            var speech = new Speech(new PlainText("Welcome to Hit Me Up"));
            return ResponseBuilder.Tell(speech);
        }
    }
}