using System;
using NUnit.Framework;

namespace Sharpen.Test
{
	[TestFixture]
	public class FilePathTest
	{
		[Test]
		public void CombineTwoAbsolutes_Unix ()
		{
			Assert.AreEqual ("/Foo/Bar", new FilePath ("/Foo", "/Bar").GetAbsolutePath ());
		}

		[Test]
		public void CombineTwoAbsolutes_DoubleSeperator_Unix ()
		{
			Assert.AreEqual ("/Foo/Bar", new FilePath ("/Foo", "////Bar").GetAbsolutePath ());
		}

		[Test]
		public void CombineTwoAbsolutes_NullParentFilePath_Unix ()
		{
			Assert.AreEqual ("/Bar", new FilePath ((FilePath) null, "/Bar").GetAbsolutePath ());
		}

		[Test]
		public void CombineTwoAbsolutes_NullParentString_Unix ()
		{
			Assert.AreEqual ("/Bar", new FilePath ((string) null, "/Bar").GetAbsolutePath ());
		}

		[Test]
		public void CombineTwoAbsolutes_WindowsStyle_Unix ()
		{
			Assert.AreEqual (@"/Foo/\Bar", new FilePath ("/Foo", @"\Bar").GetAbsolutePath ());
		}
	}
}
