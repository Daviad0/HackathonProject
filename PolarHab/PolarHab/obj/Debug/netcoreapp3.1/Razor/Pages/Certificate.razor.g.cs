#pragma checksum "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Certificate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a62e90c6a23ca54929b72630f879d354f3e32b6"
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
    public partial class Certificate : Microsoft.AspNetCore.Components.ComponentBase
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
        left: 38.5%;
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
            __builder.AddMarkupContent(2, "\r\n    \r\n    ");
            __builder.AddMarkupContent(3, "<div>\r\n\r\n    </div>\r\n    \r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "text-align:center;padding:0;margin:0");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container");
            __builder.AddAttribute(9, "style", "display:inline-block;padding:0px;margin:0px");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "id", "capture");
            __builder.AddAttribute(13, "style", "background-color:black;width:1000px;display:inline-block");
            __builder.AddMarkupContent(14, "\r\n                <img src=\"images/Certificate.png\" style=\"display:inline-block;width:1000px\">\r\n                ");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "class", "centered");
            __builder.AddAttribute(17, "style", "font-size:40px;width:800px;font-family:\'Century Gothic\'");
            __builder.AddContent(18, 
#nullable restore
#line 33 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Certificate.razor"
                                                                                                        StudentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "class", "date");
            __builder.AddAttribute(22, "style", "font-size:20px;width:800px;font-family:\'Century Gothic\'");
            __builder.AddContent(23, 
#nullable restore
#line 34 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Certificate.razor"
                                                                                                    DateTime.Now.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "style", "text-align:center;margin-top:10px");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "input-group mb-3");
            __builder.AddAttribute(32, "style", "text-align:center;width:1000px;display:inline-block");
            __builder.AddMarkupContent(33, "\r\n              ");
            __builder.AddMarkupContent(34, "<div class=\"input-group-prepend\" style=\"display:inline-block\">\r\n                <span class=\"input-group-text\" id=\"basic-addon1\" style=\"width:120px;text-align:center\">Your Name</span>\r\n              </div>\r\n              ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "maxlength", "17");
            __builder.AddAttribute(37, "type", "text");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Certificate.razor"
                                                                                                      InputChange

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "placeholder", "John Doe");
            __builder.AddAttribute(41, "aria-label", "Name");
            __builder.AddAttribute(42, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(43, "style", "display:inline-block;width:870px");
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Certificate.razor"
                                                                            StudentName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => StudentName = __value, StudentName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        \r\n        \r\n        ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "class", "btn btn-primary");
            __builder.AddAttribute(51, "style", "display:inline-block;width:1000px");
            __builder.AddAttribute(52, "disabled", 
#nullable restore
#line 48 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Certificate.razor"
                                                                                              StudentName != null? (StudentName.Length>0? false:true):true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Certificate.razor"
                                                                                                                                                                       CanvasUwu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Download Certificate");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Certificate.razor"
       
    public string StudentName { get; set; }
    private async void CanvasUwu()
    {
        await JSRuntime.InvokeVoidAsync("AddCanvas");
    }
    private async void InputChange(KeyboardEventArgs e)
    {
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591