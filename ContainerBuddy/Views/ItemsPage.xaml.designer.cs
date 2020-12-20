//------------------------------------------------------------------------------
// <
//     
//     4.0.50524.0
//
//     
//     
// </
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("", "", typeof(global::ContainerBuddy.Views.ItemsPage))]

namespace ContainerBuddy.Views {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("/private/var/mobile/Containers/Shared/AppGroup/674FE21B-A808-4CAE-9714-FC3FD4AEA4" +
    "0C/File Provider Storage/Repositories/ContainerBuddy/ContainerBuddy/Views/ItemsP" +
    "age.xaml")]
    public partial class ItemsPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.ContentPage BrowseItemsPage;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.CollectionView ItemsCollectionView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(ItemsPage));
            BrowseItemsPage = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ContentPage>(this, "BrowseItemsPage");
            ItemsCollectionView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.CollectionView>(this, "ItemsCollectionView");
        }
    }
}
