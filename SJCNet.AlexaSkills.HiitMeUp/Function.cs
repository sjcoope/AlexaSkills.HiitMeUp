using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alexa.NET.Request;
using Alexa.NET.RequestHandlers;
using Alexa.NET.Response;
using Amazon.Lambda.Core;
using SJCNet.AlexaSkills.HiitMeUp.RequestHandler;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace SJCNet.AlexaSkills.HiitMeUp
{
    public class Function
    {
        private readonly AlexaRequestPipeline Pipeline;

        private readonly IAlexaRequestHandler[] Requests = new IAlexaRequestHandler[]
        {
            new Launch(),
            new SessionEnded(),
            new HitMeUp()
        };

        public Function() 
        {
            Pipeline = new AlexaRequestPipeline(Requests);
        }

        public Task<SkillResponse> FunctionHandler(SkillRequest input, ILambdaContext context)
        {
            return Pipeline.Process(input);
        }
    }
}
