#pragma checksum "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b80d05f6a2e635fae2e4858a354ffafdc8282102"
// <auto-generated/>
#pragma warning disable 1591
namespace PolarHab.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .addedprogress{
        margin-right:-80px;
        animation-name:progressstep;
        animation-duration:6s;
        animation-iteration-count: 1;
        animation-timing-function:ease-in-out;
    }
    .noaddedprogress {
        margin-right: -80px;
    }

    @keyframes progressstep {
        0% {
            margin-right: -80px;
            opacity: 0;
        }

        10% {
            margin-right: 10px;
            opacity: 1;
        }

        90% {
            margin-right: 10px;
            opacity: 1;
        }

        100% {
            margin-right: -80px;
            opacity: 0;
        }
    }
</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "main");
            __builder.AddAttribute(3, "style", "user-select:none");
            __builder.AddMarkupContent(4, "\r\n    <img src=\"images/PolarHabLogoVert.png\" onclick=\"location.href=\'/\'\" style=\"width:48px;height:48px;position:absolute;top:6px;left:5px;z-index:3\">\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "top-row px-4");
            __builder.AddAttribute(7, "style", "background-color:#dedede;z-index:2");
            __builder.AddMarkupContent(8, "\r\n        \r\n        ");
            __builder.OpenElement(9, "span");
            __builder.AddAttribute(10, "class", 
#nullable restore
#line 42 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Shared\MainLayout.razor"
                      addedProgessClasses

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "style", "z-index:-1;background-color:lightseagreen;color:white;padding:5px;font-weight:600;font-family:\'Century Gothic\', Tahoma;border-radius:6px");
            __builder.AddContent(12, "+7.5%");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "class", "shadow");
            __builder.AddAttribute(16, "style", "background-color:mediumseagreen;color:white;padding:5px;padding-left:10px;padding-right:10px;border-radius:6px;font-weight:600;font-family:\'Century Gothic\',Tahoma");
            __builder.AddContent(17, 
#nullable restore
#line 43 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Shared\MainLayout.razor"
                                                                                                                                                                                                          (Math.Round(progress*100)).ToString()+"% a Polar Bear Wiz"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "span");
            __builder.AddAttribute(20, "onclick", "location.href=\'/certificate\'");
            __builder.AddAttribute(21, "style", "z-index:-1;background-color:mediumseagreen;color:white;padding:5px;font-weight:600;border-radius:6px;margin-left:10px;display:" + (
#nullable restore
#line 44 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Shared\MainLayout.razor"
                                                                                                                                                                                            allCompleted? "inline":"none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "!!");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "content px-4");
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.AddContent(28, 
#nullable restore
#line 48 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __builder.AddMarkupContent(32, "<audio id=\"player\">\r\n    <source id=\"playerSource\" src>\r\n</audio>");
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Shared\MainLayout.razor"
      
    public double progress = 0;
    public bool allCompleted = false;
    public string addedProgessClasses = "noaddedprogress";
    public async void TransferData()
    {
        var db1 = new PolarHab.DbAssets.OldActivityContext();
        var db2 = new PolarHab.DbAssets.ActivityContext();
        var allentries = db2.Questions.ToList();
        foreach(var entry in allentries)
        {
            if (!db1.Questions.Contains(entry))
            {
                db1.Questions.Add(entry);
            }
            
        }
        db1.SaveChanges();
    }
    public async void EXPSystem()
    {
        var result = await JSRuntime.InvokeAsync<string>("blazorExtensions.ReadCookie");
        var cookies = result.Split("; ");
        progress = (double)cookies.ToList().Where(x => x.Contains("quizCompleted") || x.Contains("activityCompleted")).ToList().Count / 15;
        if(progress >= 1)
        {
            allCompleted = true;
        }
        this.StateHasChanged();
    }
    protected override async Task OnInitializedAsync()
    {
        EXPSystem();
        PolarHab.Data.RMessenger.ChangeProgressBar += async (double progressPassed) =>
        {
            await InvokeAsync(async() =>
            {
                if(progress != progressPassed)
                {
                    JSRuntime.InvokeVoidAsync("PlayAudioFile", "images/progressgained.wav");
                    progress = progressPassed;
                    addedProgessClasses = "addedprogress";
                    this.StateHasChanged();
                    await Task.Delay(6000);
                    addedProgessClasses = "noaddedprogress";
                    if(progress >= 1)
                    {
                        allCompleted = true;
                        JSRuntime.InvokeVoidAsync("PlayAudioFile", "images/progress100percent.wav");
                    }
                    this.StateHasChanged();
                }

            });


        };

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
