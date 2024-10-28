using tessting.Model;
using tessting.Service;

namespace tessting.ViewModels;

public partial class MainViewModel(TurbinesService turbinesService) : BaseViewModel {
    private readonly TurbinesService service = turbinesService;

    public ObservableCollection<TurbinePin> Turbines { get; set; } = [];
}
