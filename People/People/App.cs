using Xamarin.Forms;
using Catalogue;

namespace People
{
	public class App : Application
	{
		public static ProductRepository PersonRepo { get; private set; }

		public App(string dbPath)
		{
			//set database path first, then retrieve main page
			PersonRepo = new ProductRepository(dbPath);

			this.MainPage = new MainPage();
		}
	}
}