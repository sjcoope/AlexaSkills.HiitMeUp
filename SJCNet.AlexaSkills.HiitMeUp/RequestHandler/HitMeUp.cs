using Alexa.NET;
using Alexa.NET.Request.Type;
using Alexa.NET.RequestHandlers;
using Alexa.NET.RequestHandlers.Handlers;
using Alexa.NET.Response;
using Alexa.NET.Response.Ssml;

namespace SJCNet.AlexaSkills.HiitMeUp.RequestHandler
{
    public class HitMeUp : SynchronousRequestHandler
    {
        public override bool CanHandle(AlexaRequestInformation information)
        {
            return information.SkillRequest.Request is IntentRequest;
        }

        public override SkillResponse HandleSyncRequest(AlexaRequestInformation information)
        {
            var intent = information.SkillRequest.Request as IntentRequest;
            var speech = new Speech(new PlainText("You've just actived the Hit Me Up Intent"));
            return ResponseBuilder.Tell(speech);
        }
    }
}