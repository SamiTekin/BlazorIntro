using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BlazorIntro.Components;

public partial class Pager:ComponentBase
{
    [Parameter]
    public int TotalItems { get; set; }

    [Parameter]
    public int ItemsPerPage { get; set; }

    [Parameter]
    public int CurrentPage { get; set; }

    [Parameter]
    public EventCallback<int> OnPageChange { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    public int TotalPages => (int)Math.Ceiling((double)TotalItems / ItemsPerPage);

    private async Task HandlePageChange(int page)
    {
        await OnPageChange.InvokeAsync(page);
    }
}
