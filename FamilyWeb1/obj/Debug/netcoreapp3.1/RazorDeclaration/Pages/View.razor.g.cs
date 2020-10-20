#pragma checksum "C:\Users\aans\RiderProjects\Own projects\Assignment1.2\FamilyWeb1\Pages\View.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffc329af69041f563318cad65eee6c361fd00568"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FamilyWeb1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\aans\RiderProjects\Own projects\Assignment1.2\FamilyWeb1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aans\RiderProjects\Own projects\Assignment1.2\FamilyWeb1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aans\RiderProjects\Own projects\Assignment1.2\FamilyWeb1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aans\RiderProjects\Own projects\Assignment1.2\FamilyWeb1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aans\RiderProjects\Own projects\Assignment1.2\FamilyWeb1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aans\RiderProjects\Own projects\Assignment1.2\FamilyWeb1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aans\RiderProjects\Own projects\Assignment1.2\FamilyWeb1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\aans\RiderProjects\Own projects\Assignment1.2\FamilyWeb1\_Imports.razor"
using FamilyWeb1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\aans\RiderProjects\Own projects\Assignment1.2\FamilyWeb1\_Imports.razor"
using FamilyWeb1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aans\RiderProjects\Own projects\Assignment1.2\FamilyWeb1\Pages\View.razor"
using FamilyWeb1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aans\RiderProjects\Own projects\Assignment1.2\FamilyWeb1\Pages\View.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/View")]
    public partial class View : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\aans\RiderProjects\Own projects\Assignment1.2\FamilyWeb1\Pages\View.razor"
       
    private IList<Adult> adultsToShow;
    private IList<Adult> allAdults;

    private int? filterById;
    
    private void FilterById(ChangeEventArgs changeEventArgs)
    {
        filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch
        {
            adultsToShow = allAdults;
        }

        if (filterById != null)
        {
            ExcecuteFilterById();
        }
    }

    private void ExcecuteFilterById()
    {
        adultsToShow = allAdults.Where(t => filterById != null && t.Id == filterById || filterById == null).ToList();
    }
    
    protected override async Task OnInitializedAsync()
    {
        allAdults = AdultService.getAdults();
        adultsToShow = allAdults;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
#pragma warning restore 1591
