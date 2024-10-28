namespace tessting.Views;

public partial class CollectionPage : ContentPage {
    public CollectionPage(CollectionPageViewModel collectionPageViewModel) {
        InitializeComponent();
        BindingContext = collectionPageViewModel;
    }
}