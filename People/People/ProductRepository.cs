using System;
using System.Collections.Generic;
using System.Linq;
using Catalogue.Models;
using Categories.Models;
using Enseignes.Models;
using SQLite;

namespace Catalogue
{
	public class ProductRepository
	{
		private readonly SQLiteConnection conn;

		public string StatusMessage { get; set; }

		public ProductRepository(string dbPath)
		{
            conn = new SQLiteConnection(dbPath);

            conn.CreateTable<Enseigne>();
            if (conn.Table<Enseigne>().Count() == 0)
            {
                // only insert the data if it doesn't already exist
                var newEns = new Enseigne();
                newEns.Lib = "McDonald's";
                conn.Insert(newEns);
                newEns = new Enseigne();
                newEns.Lib = "Quick";
                conn.Insert(newEns);
            }

            conn.CreateTable<Categorie>();
            if (conn.Table<Categorie>().Count() == 0)
            {
                // only insert the data if it doesn't already exist
                var newCat = new Categorie();
                newCat.Lib = "TestCat1";
                conn.Insert(newCat);
                newCat = new Categorie();
                newCat.Lib = "TestCat2";
                conn.Insert(newCat);
            }

            conn.CreateTable<Produit>();
            if (conn.Table<Produit>().Count() == 0)
            {
                // only insert the data if it doesn't already exist
                var newProduct = new Produit();
                newProduct.Lib = "TestLib1";
                newProduct.Cat = 1;
                newProduct.Glu_lents = 12;
                newProduct.Glu_rapides = 24;
                newProduct.Ens = 1;
                conn.Insert(newProduct);
                newProduct = new Produit();
                newProduct.Lib = "TestLib2";
                newProduct.Cat = 2;
                newProduct.Glu_lents = 12;
                newProduct.Glu_rapides = 24;
                newProduct.Ens = 2;
                conn.Insert(newProduct);
            }
		}

		public void AddNewPerson(string name)
		{
		    try
			{
				//basic validation to ensure a name was entered
				if (string.IsNullOrEmpty(name))
					throw new Exception("Valid name required");

				//insert a new person into the Person table
				var result = conn.Insert(new Produit { Lib = name });
				StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
			}
			catch (Exception ex)
			{
				StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
			}

		}

		public List<Produit> GetAllPeople()
		{
			//return a list of people saved to the Person table in the database
			return conn.Table<Produit>().ToList();
		}
	}
}