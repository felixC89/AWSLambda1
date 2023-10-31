using Amazon.Lambda.Core;
using AWSLambda1.RequestModel;
using AWSLambda1.ResponseModel;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambda1
{
    public class Function
    {

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task<ResponseSaludo> FunctionSaludo(RequestSaludo input, ILambdaContext context)
        {
            var response = new ResponseSaludo();

            try
            {
                response.ErrorCode = 0;
                response.ErrorMessage = $"Hola {input.key1} {input.key2} {input.key3} {input.key4}, version:{context.FunctionVersion}";
            }
            catch (Exception e) 
            {
                response.ErrorCode = -1;
                response.ErrorMessage = $"Ocurrió un error {e.Message}";
            }

            return response;
        }
    }
}