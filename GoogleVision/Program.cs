using Google.Cloud.Vision.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleVision
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates a client
            var client = ImageAnnotatorClient.Create();
            // Load the image file into memory
            var image = Image.FromFile(@"D:\Work\Learning\Cloud\Google\GoogleVision\Data\wf.jpg");
            // Performs label detection on the image file
            var response = client.DetectLogos(image);
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    Console.WriteLine(annotation.Description);
            }
            response = client.DetectText(image);
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    Console.WriteLine(annotation.Description);
            }
            Console.Write("complete");
            Console.Read();
        }
    }
}
