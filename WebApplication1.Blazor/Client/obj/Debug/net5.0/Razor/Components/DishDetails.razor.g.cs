#pragma checksum "D:\Projects\SCoCS\WebApplication1.Blazor\Client\Components\DishDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f84535dec01a09862622435835edfe224ee5a148"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Blazor.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\_Imports.razor"
using WebApplication1.Blazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\_Imports.razor"
using WebApplication1.Blazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\_Imports.razor"
using WebApplication1.Blazor.Client.Models;

#line default
#line hidden
#nullable disable
    public partial class DishDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\Components\DishDetails.razor"
 if (Dish != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "img");
            __builder.AddAttribute(1, "src", 
#nullable restore
#line 3 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\Components\DishDetails.razor"
               imageSrc

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "class", "img-thumbnail");
            __builder.AddAttribute(3, "width", "150");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.OpenElement(6, "p");
#nullable restore
#line 5 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\Components\DishDetails.razor"
__builder.AddContent(7, Dish.DishName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, " - ");
#nullable restore
#line 5 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\Components\DishDetails.razor"
__builder.AddContent(9, Dish.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "badge badge-info ");
#nullable restore
#line 7 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\Components\DishDetails.razor"
__builder.AddContent(13, Dish.Calories);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "\r\n            калорий\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 11 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\Components\DishDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\Components\DishDetails.razor"
       
    [Parameter]
    public DetailsViewModel Dish { get; set; }
    [Parameter]
    public EventCallback<DetailsViewModel> DishChanged { get; set; }
    string imageSrc
    {
        get
        {
            return $"images/{Dish.Image}";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591