#pragma checksum "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a320d3de111ae8b0db96910a33605c96794ffbd"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/findoutquiz")]
    public partial class WhichAreYou : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .floating {
        animation-name: floatinganimation;
        animation-iteration-count: infinite;
        animation-duration: 3s;
        animation-timing-function: ease;
    }

    @keyframes floatinganimation {
        0% {
            margin-top: 20px;
        }

        50% {
            margin-top: 30px;
        }

        100% {
            margin-top: 20px;
        }
    }
</style>
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "text-align:center");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "display:" + (
#nullable restore
#line 27 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                          quizCompleted? "none":"inline-block"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "span");
            __builder.AddAttribute(8, "style", "font-size:30px;font-family:\'Century Gothic\',Tahoma");
            __builder.AddContent(9, "#");
            __builder.AddContent(10, 
#nullable restore
#line 28 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                                                                           Questions.ToArray()[currentQuestion-1].QNum

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " - ");
            __builder.AddContent(12, 
#nullable restore
#line 28 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                                                                                                                          Questions.ToArray()[currentQuestion-1].QText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        <br>\r\n        <br>\r\n\r\n\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                       (() => sendResults(Questions.ToArray()[currentQuestion-1].Option1.Type))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "style", "background-color:#f1f1f1;border-radius:8px;margin:10px;padding:40px;padding-right:100px;padding-left:100px;text-align:center;cursor:pointer;border-left:3px" + " solid" + " #f1f1f1;border-right:" + (
#nullable restore
#line 33 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                                                                                                                                                                                                                                                                                                 (Questions.ToArray()[currentQuestion-1].Option1.Type == Results[currentQuestion-1])? "3px solid dodgerblue":"3px solid #f1f1f1"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "class", "shadow");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddMarkupContent(19, "<span style=\"font-weight:800;color:dimgray;font-family:\'Century Gothic\',Tahoma;text-align:center;\">\r\n                Option A:\r\n            </span>\r\n            ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "style", "display:inline;z-index:2;text-wrap:normal;color:dimgray;font-family:\'Century Gothic\',Tahoma");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddContent(23, 
#nullable restore
#line 38 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                  Questions.ToArray()[currentQuestion-1].Option1.Text

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                       (() => sendResults(Questions.ToArray()[currentQuestion-1].Option2.Type))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "style", "background-color:#f1f1f1;border-radius:8px;margin:10px;padding:40px;padding-right:100px;padding-left:100px;text-align:center;cursor:pointer;border-left:3px" + " solid" + " #f1f1f1;border-right:" + (
#nullable restore
#line 41 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                                                                                                                                                                                                                                                                                                 (Questions.ToArray()[currentQuestion-1].Option2.Type == Results[currentQuestion-1])? "3px solid dodgerblue":"3px solid #f1f1f1"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "shadow");
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.AddMarkupContent(32, "<span style=\"font-weight:800;color:dimgray;font-family:\'Century Gothic\',Tahoma;text-align:center;\">\r\n                Option B:\r\n            </span>\r\n            ");
            __builder.OpenElement(33, "span");
            __builder.AddAttribute(34, "style", "display:inline;z-index:2;text-wrap:normal;color:dimgray;font-family:\'Century Gothic\',Tahoma");
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.AddContent(36, 
#nullable restore
#line 46 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                  Questions.ToArray()[currentQuestion-1].Option2.Text

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                       (() => sendResults(Questions.ToArray()[currentQuestion-1].Option3.Type))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "style", "background-color:#f1f1f1;border-radius:8px;margin:10px;padding:40px;padding-right:100px;padding-left:100px;text-align:center;cursor:pointer;border-left:3px" + " solid" + " #f1f1f1;border-right:" + (
#nullable restore
#line 49 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                                                                                                                                                                                                                                                                                                 (Questions.ToArray()[currentQuestion-1].Option3.Type == Results[currentQuestion-1])? "3px solid dodgerblue":"3px solid #f1f1f1"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "class", "shadow");
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.AddMarkupContent(45, "<span style=\"font-weight:800;color:dimgray;font-family:\'Century Gothic\',Tahoma;text-align:center;\">\r\n                Option C:\r\n            </span>\r\n            ");
            __builder.OpenElement(46, "span");
            __builder.AddAttribute(47, "style", "display:inline;z-index:2;text-wrap:normal;color:dimgray;font-family:\'Century Gothic\',Tahoma");
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.AddContent(49, 
#nullable restore
#line 54 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                  Questions.ToArray()[currentQuestion-1].Option3.Text

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                       (() => sendResults(Questions.ToArray()[currentQuestion-1].Option4.Type))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "style", "background-color:#f1f1f1;border-radius:8px;margin:10px;padding:40px;padding-right:100px;padding-left:100px;text-align:center;cursor:pointer;border-left:3px" + " solid" + " #f1f1f1;border-right:" + (
#nullable restore
#line 57 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                                                                                                                                                                                                                                                                                                 (Questions.ToArray()[currentQuestion-1].Option4.Type == Results[currentQuestion-1])? "3px solid dodgerblue":"3px solid #f1f1f1"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "class", "shadow");
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.AddMarkupContent(58, "<span style=\"font-weight:800;color:dimgray;font-family:\'Century Gothic\',Tahoma;text-align:center;\">\r\n                Option D:\r\n            </span>\r\n            ");
            __builder.OpenElement(59, "span");
            __builder.AddAttribute(60, "style", "display:inline;z-index:2;text-wrap:normal;color:dimgray;font-family:\'Century Gothic\',Tahoma");
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.AddContent(62, 
#nullable restore
#line 62 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                  Questions.ToArray()[currentQuestion-1].Option4.Text

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "style", "text-align:center");
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "style", "display:inline-block");
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.OpenElement(72, "input");
            __builder.AddAttribute(73, "class", "btn btn-primary");
            __builder.AddAttribute(74, "type", "button");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                                                                       prevQuestion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "value", "Prev Question");
            __builder.AddAttribute(77, "disabled", 
#nullable restore
#line 67 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                                                                                                                       (currentQuestion > 1)? false: true

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.OpenElement(79, "input");
            __builder.AddAttribute(80, "class", "btn btn-primary");
            __builder.AddAttribute(81, "type", "button");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                                                                       nextQuestion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "value", 
#nullable restore
#line 68 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                                                                                              (currentQuestion < (Questions.Count+1))? "Next Question":"Finish Quiz"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\r\n    ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "style", "background-color:#ffffff;width:80%;padding:30px;border-radius:8px;margin:20px;text-align:left;border-top:3px" + " solid" + " red;display:" + (
#nullable restore
#line 74 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                                                                                                                                                 quizCompleted? "inline-block":"none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "class", "shadow floating");
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.OpenElement(92, "span");
            __builder.AddAttribute(93, "style", "color:dimgray;font-size:30px;font-family:\'Century Gothic\',Tahoma;font-weight:700");
            __builder.AddMarkupContent(94, "\r\n            You are a ");
            __builder.AddContent(95, 
#nullable restore
#line 76 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
                        TopRated

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(96, "!\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    <br>\r\n    <input type=\"button\" class=\"btn btn-primary\" value=\"Back to Menu\" onclick=\"location.href=\'/menu\'\" style=\"display:inline-block;width:200px;margin-top:10px\">\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\WhichAreYou.razor"
       
    public int currentQuestion = 1;
    public string TopRated = "None";
    public bool quizCompleted = false;
    public void nextQuestion()
    {
        if(currentQuestion < Questions.Count)
        {
            currentQuestion++;
            this.StateHasChanged();
        }
        else
        {
            BFTypeSorts[] bFTypeSorts = new BFTypeSorts[4] { new BFTypeSorts() { Num = Results.Count(x => x == BearType.Black), Type = BearType.Black },new BFTypeSorts() { Num = Results.Count(x => x == BearType.Brown), Type = BearType.Brown },new BFTypeSorts() { Num = Results.Count(x => x == BearType.Panda), Type = BearType.Panda },new BFTypeSorts() { Num = Results.Count(x => x == BearType.Polar), Type = BearType.Polar } };
            switch(bFTypeSorts.OrderByDescending(x => x.Num).ToArray()[0].Type)
            {
                case BearType.Black:
                    TopRated = "Black Bear";
                    break;
                case BearType.Brown:
                    TopRated = "Brown Bear";
                    break;
                case BearType.Polar:
                    TopRated = "Polar Bear";
                    break;
                case BearType.Panda:
                    TopRated = "Panda Bear";
                    break;
            }
            quizCompleted = true;
            this.StateHasChanged();
            CompletedAddCookie();
        }

    }
    public void prevQuestion()
    {
        currentQuestion--;
        this.StateHasChanged();
    }
    public void sendResults(BearType type)
    {
        Results[currentQuestion - 1] = type;
    }
    public BearType[] Results = new BearType[7] { BearType.None, BearType.None, BearType.None, BearType.None, BearType.None, BearType.None, BearType.None };
    public List<BFQuestion> Questions = new List<BFQuestion>()
    {
        new BFQuestion()
        {
            QNum = 1,
            QText = "Do you like the cold?",
            Option1 = new BFAnswer() { Text = "I thrive in the cold", Type = BearType.Polar },
            Option2 = new BFAnswer() { Text = "I love the cold", Type = BearType.Panda },
            Option3 = new BFAnswer() { Text = "It's okay...", Type = BearType.Black },
            Option4 = new BFAnswer() { Text = "I don't like the cold", Type = BearType.Brown }
        },
        new BFQuestion()
        {
            QNum = 2,
            QText = "What are your opinions on sleeping?",
            Option1 = new BFAnswer() { Text = "I sleep 14hrs a day", Type = BearType.Panda },
            Option2 = new BFAnswer() { Text = "I barely sleep", Type = BearType.Polar },
            Option3 = new BFAnswer() { Text = "Sleep is okay in perfect amounts", Type = BearType.Black },
            Option4 = new BFAnswer() { Text = "Sleep is just eh", Type = BearType.Brown }
        },
        new BFQuestion()
        {
            QNum = 3,
            QText = "How well do you eat?",
            Option1 = new BFAnswer() { Text = "Junk food all the time", Type = BearType.Panda },
            Option2 = new BFAnswer() { Text = "I love eating, but only healthy foods", Type = BearType.Brown },
            Option3 = new BFAnswer() { Text = "I love fruits and veggies", Type = BearType.Black },
            Option4 = new BFAnswer() { Text = "I like everything", Type = BearType.Polar }
        },
        new BFQuestion()
        {
            QNum = 4,
            QText = "What pleases you the most?",
            Option1 = new BFAnswer() { Text = "Mountain slips", Type = BearType.Brown },
            Option2 = new BFAnswer() { Text = "Tundra", Type = BearType.Polar },
            Option3 = new BFAnswer() { Text = "Deciduous Forest", Type = BearType.Black },
            Option4 = new BFAnswer() { Text = "Coniferous Forest", Type = BearType.Panda }
        },
        new BFQuestion()
        {
            QNum = 5,
            QText = "What would your friends describe you as?",
            Option1 = new BFAnswer() { Text = "I don't have friends", Type = BearType.Polar },
            Option2 = new BFAnswer() { Text = "Laidback", Type = BearType.Panda },
            Option3 = new BFAnswer() { Text = "Responsible", Type = BearType.Black },
            Option4 = new BFAnswer() { Text = "Unique but kinda weird at the same time", Type = BearType.Brown }
        },
        new BFQuestion()
        {
            QNum = 6,
            QText = "Pick out a word that stands out to you.",
            Option1 = new BFAnswer() { Text = "Courage ", Type = BearType.Black },
            Option2 = new BFAnswer() { Text = "Curiosity ", Type = BearType.Panda },
            Option3 = new BFAnswer() { Text = "Adventure ", Type = BearType.Brown },
            Option4 = new BFAnswer() { Text = "Independence ", Type = BearType.Polar }
        },
        new BFQuestion()
        {
            QNum = 7,
            QText = "What’s your favorite drink?",
            Option1 = new BFAnswer() { Text = "Water", Type = BearType.Polar },
            Option2 = new BFAnswer() { Text = "Tea", Type = BearType.Panda },
            Option3 = new BFAnswer() { Text = "Milkshake ", Type = BearType.Black },
            Option4 = new BFAnswer() { Text = "Orange Juice", Type = BearType.Brown }
        },
    };
    public class BFQuestion
    {
        public int QNum { get; set; }
        public string QText { get; set; }
        public BFAnswer Option1 { get; set; }
        public BFAnswer Option2 { get; set; }
        public BFAnswer Option3 { get; set; }
        public BFAnswer Option4 { get; set; }
    }
    public class BFAnswer
    {
        public string Text { get; set; }
        public BearType Type { get; set; }
    }
    public class BFTypeSorts
    {
        public BearType Type { get; set; }
        public int Num { get; set; }
    }
    public enum BearType
    {
        None,
        Polar,
        Panda,
        Brown,
        Black
    }
    public async void CompletedAddCookie()
    {

        await JSRuntime.InvokeAsync<string>("blazorExtensions.WriteCookie", "activityCompleted-findout", "true", 100);
        this.StateHasChanged();
        EXPSystem();
    }
    public async void EXPSystem()
    {
        var result = await JSRuntime.InvokeAsync<string>("blazorExtensions.ReadCookie");
        var cookies = result.Split("; ");
        PolarHab.Data.RMessenger.OnChangeProgressBar((double)cookies.ToList().Where(x => x.Contains("quizCompleted") || x.Contains("activityCompleted")).ToList().Count / 15);
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
