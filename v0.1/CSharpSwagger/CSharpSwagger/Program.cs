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
			IO.Swagger.Model.OperativeDeed real_deed = deed.DeedDeedReferenceGet("fdc6d6");
			Console.Write(real_deed.ToJson());

			Console.WriteLine ("Process Complete");
			Console.ReadLine();
		}
	}
}
