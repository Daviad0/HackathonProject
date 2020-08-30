#pragma checksum "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Buzzfeed.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de35586b2dbaccc5de0de7935e4c62f2a98a6461"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class Buzzfeed : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Buzzfeed.razor"
       
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
        PolarHab.Data.RMessenger.OnChangeProgressBar((double)cookies.ToList().Where(x => x.Contains("quizCompleted") || x.Contains("activityCompleted")).ToList().Count / 12);
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
