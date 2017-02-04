using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AK.Xamarin.Utils
{
	/// <summary>
	/// Utililty methods for lists.
	/// </summary>
	public static class ListUtils
	{
		/// <summary>
		/// Handles list item selection to prevent highlighting by setting selected item as null. 
		/// This should typically be called from listview item seleciton event handler.
		/// </summary>
		/// <param name="listView">List view.</param>
		/// <param name="e">Selected item event arguments.</param>
		/// <param name="useListItemAction">Action for handling selected item.</param>
		public static void HandleListItemSelection(ListView listView, SelectedItemChangedEventArgs e, Action<object> useListItemAction)
		{
			if (e.SelectedItem == null)
				return;

			var item = e.SelectedItem;
			listView.SelectedItem = null;

			useListItemAction?.Invoke(item);
		}
	}
}
