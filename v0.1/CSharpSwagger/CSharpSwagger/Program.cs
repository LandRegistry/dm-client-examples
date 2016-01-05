using System;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using Newtonsoft.Json;

namespace CSharpSwagger
{
	class MainClass
	{
		static ApiClient client = new ApiClient("http://10.10.10.10:9020/");

		public static void Main (string[] args)
		{
			// Give the deed a Title Number and MdRef
			string titleNumber = "DT567568";
			string mdRef = "e-MD123G";

			// create at least one borrower
			PrivateIndividualName borrower = new PrivateIndividualName ();
			borrower.Forename = "Paul";
			borrower.Surname = "Smythe";
			borrower.Gender = "Male";
			borrower.Address = "2 The Street, Plymouth, PL1 2PP";
			borrower.Dob = "01/10/1976";
			borrower.PhoneNumber = "07502154062";

			// add the borrower(s) to a list of borrowers (min 1)
			Borrowers borrowerList = new Borrowers();
			borrowerList.Add(borrower);

			string deedToken = PostDeed (titleNumber, mdRef, borrowerList);

			GetDeed(deedToken);

			//Starting change of DATA for PUT

			// Give the deed a new Title Number and MdRef
			string titleNumberNew = "DT567567";
			string mdRefNew = "e-MD123H";

			// create at least one borrower
			PrivateIndividualName borrowerNew = new PrivateIndividualName ();
			borrowerNew.Forename = "Paul";
			borrowerNew.MiddleName = "FRANKO";
			borrowerNew.Surname = "Smythe";
			borrowerNew.Gender = "Male";
			borrowerNew.Address = "2 The Street, Plymouth, PL1 2PP";
			borrowerNew.Dob = "01/10/1976";
			borrowerNew.PhoneNumber = "07502154062";

			// add the borrower(s) to a list of borrowers (min 1)
			Borrowers borrowerListNew = new Borrowers();
			borrowerListNew.Add(borrowerNew);

			UpdateDeed(deedToken, titleNumberNew ,mdRefNew ,borrowerListNew);

			Console.WriteLine("Process Complete");
			Console.ReadLine();
		}

		private static OperativeDeed GetDeed(string token){
			DeedApi deedGet = new DeedApi(client);

			Console.WriteLine("Retrieving Newly Posted Deed");
			OperativeDeed operativeDeed = deedGet.DeedDeedReferenceGet(token);
			Console.Write(operativeDeed.ToJson());

			return operativeDeed;
		}

		private static string PostDeed(string titleNumber, string mdRef, Borrowers borrowerList) {
			DefaultApi deedPost = new DefaultApi(client);
			DeedApplication deedApp = new DeedApplication();

			deedApp.TitleNumber = titleNumber;
			deedApp.MdRef = mdRef;

			deedApp.Borrowers = borrowerList;

			Console.WriteLine ("Sending POST to API");
			string result = deedPost.AddDeed(deedApp);
			Console.WriteLine ("New Deed created and accessible at : " + result);

			string token = result.Substring (result.Length-6);
			Console.WriteLine("Token for new deed is " + token);

			return token;
		}
		private static OperativeDeed UpdateDeed(string token, string titleNumber, string mdRef, Borrowers borrowerList){
			DeedApi deedPut = new DeedApi (client);
			DeedApplication deedApp = new DeedApplication ();
			// Setting new DeedApp to called in Vars
			deedApp.TitleNumber = titleNumber;
			deedApp.MdRef = mdRef;
			deedApp.Borrowers = borrowerList;
			//Adding in PUT on the same deed
			Console.WriteLine("Compiling Updates");
			Console.WriteLine ("NEW Deed is = " + deedApp);
			Console.WriteLine ("Sending update request to this deed");

			deedPut.DeedDeedReferencePut (token, deedApp);

			OperativeDeed opertativeNewDeed = GetDeed (token);

			return opertativeNewDeed;
		}
	}
}
