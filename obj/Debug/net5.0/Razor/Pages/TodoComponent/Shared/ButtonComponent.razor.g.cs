#pragma checksum "C:\Users\pro7\dev\BlazorApp\Pages\TodoComponent\Shared\ButtonComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdb0cbaf5b5894dc713017a796640d4fbde26ffb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages.TodoComponent.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pro7\dev\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pro7\dev\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pro7\dev\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pro7\dev\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pro7\dev\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pro7\dev\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pro7\dev\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pro7\dev\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pro7\dev\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\pro7\dev\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\pro7\dev\BlazorApp\Pages\TodoComponent\_Imports.razor"
using BlazorApp.Pages.TodoComponent.Shared;

#line default
#line hidden
#nullable disable
    public partial class ButtonComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddContent(1, 
#nullable restore
#line 1 "C:\Users\pro7\dev\BlazorApp\Pages\TodoComponent\Shared\ButtonComponent.razor"
         buttonName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\pro7\dev\BlazorApp\Pages\TodoComponent\Shared\ButtonComponent.razor"
       



  [Parameter]



  public string buttonName { get; set; } = "test button";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
