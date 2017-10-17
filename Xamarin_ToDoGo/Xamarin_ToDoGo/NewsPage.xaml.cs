using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_ToDoGo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewsPage : ContentPage
	{
        int bkm = 0;

		public NewsPage ()
		{
			InitializeComponent ();
            userID.Text = "userandrei";
            bookmarkCount.Text = bkm.ToString();
        }


        private void BtnBookmarkClicked(object sender, EventArgs e)
        {
            bkm++;
            bookmarkCount.Text = bkm.ToString();
        }

        private void BtnPrevClicked(object sender, EventArgs e)
        {
            userID.Text = "BtnPrevClicked";
        }

        private void BtnNextClicked(object sender, EventArgs e)
        {
            userID.Text = "BtnNextClicked";
        }
    }
}