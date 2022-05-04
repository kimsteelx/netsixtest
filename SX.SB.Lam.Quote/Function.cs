
 
using System.Threading.Tasks; 
using Amazon.Lambda.Core; 


[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace SX.SB.Lam.Quote
{ 
    public class Function 
    {
      
        public string  Post(string request, ILambdaContext context)
        {
            var _status = false;
            var _message = string.Empty;
 
            return  request;

        } 
    }
}