using System;
using IO.Swagger.Api;
using IO.Swagger.Client;

namespace CSharpSwagger
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("Hello World");
			ApiClient client = new ApiClient("http://192.168.250.28:5003");
			DeedApi deed = new DeedApi(client);
			Console.WriteLine ("Client created");
			Console.WriteLine(" ");
			Console.WriteLine ("Posting to Client:");


			IO.Swagger.Model.OperativeDeed real_deed = deed.DeedDeedReferenceGet("5983b3");
			Console.Write(real_deed.ToJson());

			Console.WriteLine ("Process Complete");
			Console.ReadLine();
		}
	}
}
