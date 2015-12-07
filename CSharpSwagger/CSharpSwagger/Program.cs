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
			ApiClient dan = new ApiClient("http://192.168.250.28:5003");
			DeedApi deed = new DeedApi(dan);
			IO.Swagger.Model.OperativeDeed testme = deed.DeedDeedReferenceGet("fdc6d6");
			Console.Write(testme.ToJson());

			Console.WriteLine ("Process Complete");
			Console.ReadLine();
		}
	}
}
