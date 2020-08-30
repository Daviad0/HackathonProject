#pragma checksum "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityEating.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "613491c868257cc3414568305508e75303de0db6"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/guided-exploration/{dbKey}")]
    public partial class ActivityEating : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 204 "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\ActivityEating.razor"
       
    [Parameter]
    public string dbKey { get; set; }
    public PolarHab.DbAssets.Question selectedQuestion = new DbAssets.Question();
    protected override async Task OnInitializedAsync()
    {
        using(var db = new PolarHab.DbAssets.ActivityContext())
        {
            selectedQuestion = db.Questions.Find(int.Parse(dbKey));
            var qarray = new string[4] { "A", "B", "C", "D" };
            var numiterations = new Random().Next(3, 10);
            var randomnumgen = new Random();
            for(int i = numiterations; i > 0; i--)
            {
                var pos1 = randomnumgen.Next(0, 4);
                var pos2 = randomnumgen.Next(0, 4);
                var pos1value = qarray[pos1];
                var pos2value = qarray[pos2];
                qarray[pos1] = pos2value;
                qarray[pos2] = pos1value;
            }
            questionName = selectedQuestion.QuestionName;
            questionDesc = selectedQuestion.QuestionDescription;
            quizAnswers = new Dictionary<string, QuizAnswer>() {
                { qarray[0], JsonConvert.DeserializeObject<QuizAnswer>(selectedQuestion.Answer1ModelJson) },
                { qarray[1], JsonConvert.DeserializeObject<QuizAnswer>(selectedQuestion.Answer2ModelJson) },
                { qarray[2], JsonConvert.DeserializeObject<QuizAnswer>(selectedQuestion.Answer3ModelJson) },
                { qarray[3], JsonConvert.DeserializeObject<QuizAnswer>(selectedQuestion.Answer4ModelJson) },

            };
            FindCookies();
            isLoading = false;
            this.StateHasChanged();
        }

    }
    private Dictionary<string, QuizAnswer> quizAnswers = new Dictionary<string, QuizAnswer>() {
        { "A", new QuizAnswer() { isCorrect = false, answerText = "A1", answerDialogue = 1 } },
        { "B", new QuizAnswer() { isCorrect = false, answerText = "A2", answerDialogue = 2 } },
        { "C", new QuizAnswer() { isCorrect = true, answerText = "A3", answerDialogue = 4 } },
        { "D", new QuizAnswer() { isCorrect = false, answerText = "A4", answerDialogue = 3 } },
    };
    private bool answerDialogue1 = false;
    private bool isLoading = true;
    private bool answerDialogue2 = false;
    private bool answerDialogue3 = false;
    private bool answerDialogue4 = false;
    private bool alreadyCompleted = false;
    private string questionName = "";
    private string questionDesc = "";
    public string answerDialogueClass = "shadow";

    private async void ShowDialogueA()
    {
        if (!answerDialogueClass.Contains("incorrect"))
        {
            switch (quizAnswers.GetValueOrDefault("A").answerDialogue)
            {
                case 1:
                    answerDialogue2 = false;
                    answerDialogue3 = false;
                    answerDialogue4 = false;
                    answerDialogue1 = true;
                    break;
                case 2:
                    answerDialogue1 = false;
                    answerDialogue3 = false;
                    answerDialogue4 = false;
                    answerDialogue2 = true;
                    break;
                case 3:
                    answerDialogue1 = false;
                    answerDialogue2 = false;
                    answerDialogue4 = false;
                    answerDialogue3 = true;
                    break;
                case 4:
                    answerDialogue1 = false;
                    answerDialogue2 = false;
                    answerDialogue3 = false;
                    answerDialogue4 = true;
                    break;
            }
            quizAnswers.GetValueOrDefault("B").currentlyAnswered = false;
            quizAnswers.GetValueOrDefault("C").currentlyAnswered = false;
            quizAnswers.GetValueOrDefault("D").currentlyAnswered = false;
            quizAnswers.GetValueOrDefault("A").currentlyAnswered = true;
            if (!quizAnswers.GetValueOrDefault("A").isCorrect)
            {
                PlayAudio(false);
                answerDialogueClass = "shadow floating incorrectfloating";
                await Task.Delay(500);
                answerDialogueClass = "shadow floating";
            }
            else
            {
                PlayAudio(true);
                CompletedAddCookie();
            }
        }

    }
    private async void ShowDialogueB()
    {
        if (!answerDialogueClass.Contains("incorrect"))
        {
            switch (quizAnswers.GetValueOrDefault("B").answerDialogue)
            {
                case 1:
                    answerDialogue2 = false;
                    answerDialogue3 = false;
                    answerDialogue4 = false;
                    answerDialogue1 = true;
                    break;
                case 2:
                    answerDialogue1 = false;
                    answerDialogue3 = false;
                    answerDialogue4 = false;
                    answerDialogue2 = true;
                    break;
                case 3:
                    answerDialogue1 = false;
                    answerDialogue2 = false;
                    answerDialogue4 = false;
                    answerDialogue3 = true;
                    break;
                case 4:
                    answerDialogue1 = false;
                    answerDialogue2 = false;
                    answerDialogue3 = false;
                    answerDialogue4 = true;
                    break;
            }
            quizAnswers.GetValueOrDefault("A").currentlyAnswered = false;
            quizAnswers.GetValueOrDefault("C").currentlyAnswered = false;
            quizAnswers.GetValueOrDefault("D").currentlyAnswered = false;
            quizAnswers.GetValueOrDefault("B").currentlyAnswered = true;
            if (!quizAnswers.GetValueOrDefault("B").isCorrect)
            {
                PlayAudio(false);
                answerDialogueClass = "shadow floating incorrectfloating";
                await Task.Delay(500);
                answerDialogueClass = "shadow floating";
            }
            else
            {
                PlayAudio(true);
                CompletedAddCookie();
            }
        }

    }
    private async void ShowDialogueC()
    {
        if (!answerDialogueClass.Contains("incorrect"))
        {
            switch (quizAnswers.GetValueOrDefault("C").answerDialogue)
            {
                case 1:
                    answerDialogue2 = false;
                    answerDialogue3 = false;
                    answerDialogue4 = false;
                    answerDialogue1 = true;
                    break;
                case 2:
                    answerDialogue1 = false;
                    answerDialogue3 = false;
                    answerDialogue4 = false;
                    answerDialogue2 = true;
                    break;
                case 3:
                    answerDialogue1 = false;
                    answerDialogue2 = false;
                    answerDialogue4 = false;
                    answerDialogue3 = true;
                    break;
                case 4:
                    answerDialogue1 = false;
                    answerDialogue2 = false;
                    answerDialogue3 = false;
                    answerDialogue4 = true;
                    break;
            }
            quizAnswers.GetValueOrDefault("A").currentlyAnswered = false;
            quizAnswers.GetValueOrDefault("B").currentlyAnswered = false;
            quizAnswers.GetValueOrDefault("D").currentlyAnswered = false;
            quizAnswers.GetValueOrDefault("C").currentlyAnswered = true;
            if (!quizAnswers.GetValueOrDefault("C").isCorrect)
            {
                PlayAudio(false);
                answerDialogueClass = "shadow floating incorrectfloating";
                await Task.Delay(500);
                answerDialogueClass = "shadow floating";
            }
            else
            {
                PlayAudio(true);
                CompletedAddCookie();
            }
        }

    }
    private async void ShowDialogueD()
    {
        if (!answerDialogueClass.Contains("incorrect"))
        {
            switch (quizAnswers.GetValueOrDefault("D").answerDialogue)
            {
                case 1:
                    answerDialogue2 = false;
                    answerDialogue3 = false;
                    answerDialogue4 = false;
                    answerDialogue1 = true;
                    break;
                case 2:
                    answerDialogue1 = false;
                    answerDialogue3 = false;
                    answerDialogue4 = false;
                    answerDialogue2 = true;
                    break;
                case 3:
                    answerDialogue1 = false;
                    answerDialogue2 = false;
                    answerDialogue4 = false;
                    answerDialogue3 = true;
                    break;
                case 4:
                    answerDialogue1 = false;
                    answerDialogue2 = false;
                    answerDialogue3 = false;
                    answerDialogue4 = true;
                    break;
            }
            quizAnswers.GetValueOrDefault("A").currentlyAnswered = false;
            quizAnswers.GetValueOrDefault("B").currentlyAnswered = false;
            quizAnswers.GetValueOrDefault("C").currentlyAnswered = false;
            quizAnswers.GetValueOrDefault("D").currentlyAnswered = true;
            if (!quizAnswers.GetValueOrDefault("D").isCorrect)
            {
                PlayAudio(false);
                answerDialogueClass = "shadow floating incorrectfloating";
                await Task.Delay(500);
                answerDialogueClass = "shadow floating";

            }
            else
            {
                PlayAudio(true);
                CompletedAddCookie();

            }
        }

    }
    public async void CompletedAddCookie()
    {
        alreadyCompleted = true;
        this.StateHasChanged();
        await JSRuntime.InvokeAsync<string>("blazorExtensions.WriteCookie", "quizCompleted-"+selectedQuestion.CookieTag, "true", 100);
        EXPSystem();

    }
    public async void PlayAudio(bool correct)
    {
        if (correct)
        {
            await JSRuntime.InvokeVoidAsync("PlayAudioFile", "images/rightanswer.wav");
        }
        else
        {
            await JSRuntime.InvokeVoidAsync("PlayAudioFile", "images/wronganswer.wav");
        }


    }
    public async void FindCookies()
    {
        var result = await JSRuntime.InvokeAsync<string>("blazorExtensions.ReadCookie");
        var cookies = result.Split("; ");
        if(cookies.Contains("quizCompleted-" + selectedQuestion.CookieTag + "=true"))
        {
            alreadyCompleted = true;
            this.StateHasChanged();
        }

    }
    public async void toJson()
    {
        var result = JsonConvert.SerializeObject(quizAnswers.GetValueOrDefault("A"));
        Console.WriteLine(result);
    }
    public class QuizAnswer
    {
        public bool isCorrect { get; set; }
        public string answerText { get; set; }
        public int answerDialogue { get; set; }
        public bool currentlyAnswered { get; set; }
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
