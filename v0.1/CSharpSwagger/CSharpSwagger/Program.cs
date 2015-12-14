using System;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using Newtonsoft.Json;

namespace CSharpSwagger
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("Hello World");
			ApiClient client = new ApiClient("http://192.168.250.28:5003");
			DeedApi deed_get = new DeedApi(client);
			DefaultApi deed_post = new DefaultApi (client);
			Console.WriteLine ("Client created");
			Console.WriteLine(" ");
			Console.WriteLine ("Creating Post to Client:");

			IO.Swagger.Model.DeedApplication deed_app = new DeedApplication ();

			deed_app.TitleNumber = "DT567568";
			deed_app.MdRef = "e-MD123G";

			Console.WriteLine ("Creating Borrower");

//			{
//				"forename": "Paul",
//				"middle_name": "",
//				"surname": "Smythe",
//				"gender": "Male",
//				"address": "2 The Street, Plymouth, PL1 2PP",
//				"dob": "01/10/1976",
//				"phone_number": "07502154062"
//			}


			IO.Swagger.Model.PrivateIndividualName borrower = new PrivateIndividualName ();
			borrower.Forename = "Paul";
			borrower.MiddleName = "";
			borrower.Surname = "Smythe";
			borrower.Gender = "Male";
			borrower.Address = "2 The Street, Plymouth, PL1 2PP";
			borrower.Dob = "01/10/1976";
			borrower.PhoneNumber = "07502154062";

			Borrowers borrowerlist = new Borrowers();

			borrowerlist.Add(borrower);

			deed_app.Borrowers = borrowerlist;

			Console.WriteLine ("Sending POST to API");

			string result = deed_post.AddDeed(deed_app);

			Console.WriteLine ("New Deed created and accessible at : " + result);

			string token = result.Substring (res.Length-6);

			Console.WriteLine("Token for new deed is " + token);


			Console.WriteLine ("Retrieving Newly Posted Deed");
			IO.Swagger.Model.OperativeDeed real_deed = deed_get.DeedDeedReferenceGet(token);
			Console.Write(real_deed.ToJson());

			Console.WriteLine ("Process Complete");
			Console.ReadLine();
		}
	}
}
