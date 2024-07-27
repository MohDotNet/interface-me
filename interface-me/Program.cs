using interface_me.models;
using System.Net.Http.Headers;

namespace interface_me
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var resp = new Response();
            resp.activation = "156405450";
            resp.pin = "40654085406";
            resp.Code = 200;
            
            // first mask before logging.

            var mask = new Masker();
            mask.Mask(resp);

            // log to a text file.

            Console.WriteLine($"the result : {resp.activation} and pin : {resp.pin}");


            Console.WriteLine("Try masking another object");

            var digiResponse = new responseActivation();
            digiResponse.activation = "156405450";
            digiResponse.Code = 200;

            // first mask before logging.
            var masker2 = new Masker();
            masker2.Mask(digiResponse);

            Console.WriteLine($"the result : {digiResponse.activation} no pin");

        }
    }

}
