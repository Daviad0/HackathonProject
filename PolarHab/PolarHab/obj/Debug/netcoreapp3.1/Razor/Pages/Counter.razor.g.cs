#pragma checksum "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82916a6a88e9fed32df0de10c6e4a3f9a22bf768"
// <auto-generated/>
#pragma warning disable 1591
namespace PolarHab.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using PolarHab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using PolarHab.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/certificate")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .centered {
        position: absolute;
        top: 49%;
        left: 50%;
        transform: translate(-50%, -50%);
    }
    .date {
        position: absolute;
        top: 57.5%;
        left: 39%;
        transform: translate(-50%, -50%);
    }

    .container {
        position: relative;
        text-align: center;
        color: black;
    }
</style>
");
            __builder.OpenElement(1, "body");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "input-group mb-3");
            __builder.AddMarkupContent(5, "\r\n      ");
            __builder.AddMarkupContent(6, "<div class=\"input-group-prepend\">\r\n        <span class=\"input-group-text\" id=\"basic-addon1\">Your Name</span>\r\n      </div>\r\n      ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "placeholder", "John Doe");
            __builder.AddAttribute(11, "aria-label", "Name");
            __builder.AddAttribute(12, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Counter.razor"
                                                     StudentName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => StudentName = __value, StudentName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.AddMarkupContent(17, "<div>\r\n\r\n    </div>\r\n    ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-primary");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Counter.razor"
                                              CanvasUwu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Download Certificate");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "style", "text-align:center;padding:0;margin:0");
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "container");
            __builder.AddAttribute(28, "style", "display:inline-block;padding:0px;margin:0px");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "id", "capture");
            __builder.AddMarkupContent(32, "\r\n                <img src=\"images/Certificate.png\" style=\"display:inline-block;width:1000px\">\r\n                ");
            __builder.AddMarkupContent(33, "<span class=\"centered\" style=\"font-size:40px;width:800px;font-family:\'Century Gothic\'\">David Reeves</span>\r\n                ");
            __builder.OpenElement(34, "span");
            __builder.AddAttribute(35, "class", "date");
            __builder.AddAttribute(36, "style", "font-size:20px;width:800px;font-family:\'Century Gothic\'");
            __builder.AddContent(37, 
#nullable restore
#line 39 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Counter.razor"
                                                                                                    DateTime.Now.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Counter.razor"
       
    public string StudentName { get; set; }
    private async void CanvasUwu()
    {
        Console.WriteLine("uwu");
        await JSRuntime.InvokeVoidAsync("AddCanvas");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
