using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace Tecumseh
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			Thread.Sleep(20000);
			app.Tap(x => x.Css("#espGuidebookBtn"));
			app.Screenshot("Let's start by Tapping 'Esp Guidebook");

			Thread.Sleep(20000);
			app.Tap(x => x.Css("#homeBtn"));
			app.Screenshot("We Tapped on the 'Home' Button");

			Thread.Sleep(20000);
			app.Tap(x => x.Css("#crossReferenceBtn"));
			app.Screenshot("Then, We Tapped on the 'Cross Reference' Button");

			Thread.Sleep(20000);
			app.Tap(x => x.Css(".roundBtn"));
			app.Screenshot("We Tapped on the 'Home' Button");

			Thread.Sleep(20000);
			app.Tap(x => x.Css("#dataSyncBtn"));
			app.Screenshot("Next, we Tapped on the 'Data Sync' Button");

			Thread.Sleep(20000);
			app.Tap(x => x.Css(".roundBtn"));
			app.Screenshot("We Tapped on the 'Home' Button");

			Thread.Sleep(20000);
			app.Tap(x => x.Css("#region"));
			app.Screenshot("Then, We Tapped on the 'Region' Button");

			Thread.Sleep(20000);
			app.Tap("Europe");
			app.Screenshot("We Tapped on 'Europe'");

			Thread.Sleep(20000);
			app.Tap(x => x.Css("#region"));
			app.Screenshot("We Tapped on the 'Region' Button");

			Thread.Sleep(20000);
			app.Tap("Asia-Pacific");
			app.Screenshot("We Tapped on 'Asia-Pacific'");

			Thread.Sleep(20000);
			app.Tap(x => x.Css("#region"));
			app.Screenshot("Next, we Tapped on the 'Region' Button");

			Thread.Sleep(20000);
			app.Tap("South America");
			app.Screenshot("We Tapped on 'South America'");

			Thread.Sleep(20000);
			app.Tap(x => x.Css("#region"));
			app.Screenshot("This is the last time we Tapon the 'Region' Button");

			Thread.Sleep(20000);
			app.Tap("North America");
			app.Screenshot("We Tapped on 'North America'");
		}

	}
}
