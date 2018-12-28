using Alexa.NET;
using Alexa.NET.Request.Type;
using Alexa.NET.RequestHandlers;
using Alexa.NET.RequestHandlers.Handlers;
using Alexa.NET.Response;
using Alexa.NET.Response.Ssml;

namespace SJCNet.AlexaSkills.HiitMeUp.RequestHandler
{
    public class SessionEnded : SynchronousRequestHandler
    {
        public override bool CanHandle(AlexaRequestInformation information)
        {
            return information.SkillRequest.Request is SessionEndedRequest;
        }

        public override SkillResponse HandleSyncRequest(AlexaRequestInformation information)
        {
            var speech = new Speech(new PlainText("Thanks for using hit me up"));
            return ResponseBuilder.Tell(speech);
        }
    }
}