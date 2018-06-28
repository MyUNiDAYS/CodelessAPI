using System.Collections;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace UNiDAYS.Testing.NUnit
{
	public static class CollectionExtensions
	{
		public static bool ContainsAny<T>(this IEnumerable<T> collection, IEnumerable<T> values)
		{
			foreach (T item in values)
			{
				if (collection.Contains<T>(item))
				{
					return true;
				}
			}
			return false;
		}

		public static ArrayList ToArrayList(this IEnumerable enumerable)
		{
			var arrayList = new ArrayList();

			foreach (var obj in enumerable)
				arrayList.Add(obj);

			return arrayList;
		}
	}
}