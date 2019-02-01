using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Races.Utilities
{
   public static class EmbeddedFeeds
    {
	    public static string GetFeed(string fileName)
	    {
		    var asm = Assembly.GetExecutingAssembly();

		    var resource = $"Races.Utilities.FeedData.{fileName}";

		    using (var stream = asm.GetManifestResourceStream(resource))
		    {
			    if (stream == null) return string.Empty;

			    var reader = new StreamReader(stream);

			    return reader.ReadToEnd();
		    }
		}
    }
}
