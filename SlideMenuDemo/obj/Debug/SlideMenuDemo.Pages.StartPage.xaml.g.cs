// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace SlideMenuDemo.Pages {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("/Users/mac/GITVS/SlideMenuDemo/SlideMenuDemo/Pages/StartPage.xaml")]
    public partial class StartPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Grid controlGrid;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.RowDefinition gridRow0;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.RowDefinition gridRow1;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.RowDefinition gridRow2;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::CarouselView.FormsPlugin.Abstractions.CarouselViewControl myCarousel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.BoxView contentOverlay;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.StackLayout slideUpMenu_Animated;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.StackLayout slideUpMenu_Interactive;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(StartPage));
            controlGrid = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Grid>(this, "controlGrid");
            gridRow0 = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.RowDefinition>(this, "gridRow0");
            gridRow1 = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.RowDefinition>(this, "gridRow1");
            gridRow2 = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.RowDefinition>(this, "gridRow2");
            myCarousel = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::CarouselView.FormsPlugin.Abstractions.CarouselViewControl>(this, "myCarousel");
            contentOverlay = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.BoxView>(this, "contentOverlay");
            slideUpMenu_Animated = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.StackLayout>(this, "slideUpMenu_Animated");
            slideUpMenu_Interactive = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.StackLayout>(this, "slideUpMenu_Interactive");
        }
    }
}