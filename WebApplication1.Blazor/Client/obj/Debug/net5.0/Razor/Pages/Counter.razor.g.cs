#pragma checksum "D:\Projects\SCoCS\WebApplication1.Blazor\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c3df45e4c78bd26b32c4b34e91fec8fb13213b"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Blazor.Client.Pages
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
#nullable restore
#line 2 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\Pages\Counter.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\Pages\Counter.razor"
                 formModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\Pages\Counter.razor"
                                           SetCounter

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n ");
                __Blazor.WebApplication1.Blazor.Client.Pages.Counter.TypeInference.CreateInputNumber_0(__builder2, 9, 10, 
#nullable restore
#line 9 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\Pages\Counter.razor"
                           formModel.NewValue

#line default
#line hidden
#nullable disable
                , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => formModel.NewValue = __value, formModel.NewValue)), 12, () => formModel.NewValue);
                __builder2.AddMarkupContent(13, "\r\n <input type=\"submit\" class=\"btn btn-outline-info mt-2 mb-2\" value=\"Set counter\">");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(15, "p");
            __builder.AddContent(16, "Current count: ");
#nullable restore
#line 17 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\Pages\Counter.razor"
__builder.AddContent(17, currentCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-primary");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "D:\Projects\SCoCS\WebApplication1.Blazor\Client\Pages\Counter.razor"
       
    private int currentCount = 0;
    private FormModel formModel;
    protected override void OnInitialized()
    {
        formModel = new();
    }
    private void IncrementCount()
    {
        currentCount++;
    }

    class FormModel
    {
        [DataType("int")]
        [Range(0, int.MaxValue)]
        public int NewValue { get; set; }
    }

    private void SetCounter()
    {
        currentCount = formModel.NewValue;
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.WebApplication1.Blazor.Client.Pages.Counter
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
