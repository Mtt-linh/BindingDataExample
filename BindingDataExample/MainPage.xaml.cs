using BindingDataExample.Models;

using System.Collections.Generic;

using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BindingDataExample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Book> Books;
        public MainPage()
        {
            this.InitializeComponent();
            Books = BookManager.GetBooks();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var book = (Book)e.ClickedItem;
            ResultTextBlock.Text = "You selected" + book.Title;
        }
    }
}
