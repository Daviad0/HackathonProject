#pragma checksum "C:\Users\djree\source\repos\HackathonProject\PolarHab\PolarHab\Pages\Videos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "459e81abdb45c4cf4b048137cc5a3d8777965b43"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/videos")]
    public partial class Videos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<html lang=\"en\">\r\n<head>\r\n<title>Page Title</title>\r\n<meta charset=\"UTF-8\">\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n<style>\r\n* {\r\n  box-sizing: border-box;\r\n}\r\n\r\n/* Style the body */\r\nbody {\r\n  font-family: \'Century Gothic\',Tahoma;\r\n  margin: 0;\r\n}\r\n\r\n/* Header/logo Title */\r\n.header {\r\n  padding: 80px;\r\n  text-align: center;\r\n  background: #86a3c3;\r\n  color: white;\r\n  border-radius: 15px 15px 0px 0px;\r\n}\r\n\r\n/* Increase the font size of the heading */\r\n.header h1 {\r\n  font-size: 40px;\r\n}\r\n\r\n\r\n/* Column container */\r\n.row {  \r\n  display: -ms-flexbox; /* IE10 */\r\n  display: flex;\r\n  -ms-flex-wrap: wrap; /* IE10 */\r\n  flex-wrap: wrap;\r\n}\r\n\r\n/* Main column */\r\n.main {   \r\n  -ms-flex: 70%; /* IE10 */\r\n  flex: 70%;\r\n  background-color: white;\r\n}\r\n/* nav bar */\r\n    nav {\r\n        background-color: #333;\r\n        border-radius: 0px 0px 15px 15px;\r\n    }\r\n/* list of pages */\r\n        nav ul {\r\n            margin: 0;\r\n            padding: 0;\r\n            list-style: none;\r\n            text-align: center;\r\n        }\r\n/* nav list items */\r\n        nav li {\r\n            display: inline-block;\r\n            margin-left: 70px;\r\n            padding-top: 20px;\r\n            padding-bottom: 20px;\r\n            position: relative;\r\n            transition: letter-spacing 0.5s;\r\n            font-family:\'Century Gothic\',Tahoma\r\n        }\r\n/* nav text */\r\n        nav a {\r\n            color: white;\r\n            text-decoration: none;\r\n            font-family: \'Century Gothic\',Tahoma;\r\n            font-size: 20px;\r\n            transition: letter-spacing 0.5s;\r\n        }\r\n /* nav active */\r\n            nav a:hover {\r\n                letter-spacing: 1px;\r\n                transition: all ease-in-out 250ms;\r\n                color: white;\r\n                text-decoration: none;\r\n            }\r\n/* nav top line */\r\n            nav a::before {\r\n                content: \'\';\r\n                display: block;\r\n                height: 5px;\r\n                background-color: white;\r\n                position: absolute;\r\n                width: 0%;\r\n                top: 0;\r\n                transition: all ease-in-out 250ms;\r\n            }\r\n/* nav top line active */\r\n            nav a:hover::before {\r\n                width: 95%;\r\n            }\r\n\r\n</style>\r\n</head>\r\n<body>\r\n\r\n<div class=\"header\">\r\n  <h1>Educational Videos</h1>\r\n</div>\r\n\r\n<nav>\r\n    <ul>\r\n         <li><a href=\"/\">Home</a></li>\r\n            <li><a href=\"/menu\">Activities</a></li>\r\n            <li><a href=\"/climate\">About Climate Change</a></li>\r\n            <li><a href=\"/videos\">More Videos</a></li>\r\n            <li><a href=\"/timeline\">Timeline</a></li>\r\n            <li><a href=\"/bearnames\">The Bears</a></li>\r\n            <li><a href=\"/about\">About</a></li>\r\n    </ul>\r\n</nav>\r\n  \r\n  <div class=\"main\">\r\n    <br>\r\n    <h2>Video One</h2>\r\n    <h5>This is a short 4 minute video talking about some fun facts about polar bears.</h5>\r\n   <iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/1zRGzlWqce4\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n    <br>\r\n    <hr>\r\n    <br>\r\n    <h2>Video Two</h2>\r\n    <h5> Another, even shorter video (~1 minute) also talking about a couple fun facts. There are many unique facts that you can learn about Polar Bears through this!</h5>\r\n   <iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/XdCaBF8NJ00\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n<br>\r\n<hr>\r\n<br>\r\n    <h2>Video Three</h2>\r\n    <h5>A 10 minute short film about 2 male polar bears. This video covers the importance of winter and the first big freeze and how global warming is affecting the ice that grows over the Arctic Ocean every year. It also covers a little bit of a bear\'s yearly schedule.</h5>\r\n    <iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/QHaJdznlRBg\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n  </div>\r\n\r\n\r\n    <br>\r\n    <br>\r\n    <br>\r\n\r\n    \r\n    <br>\r\n    <br>\r\n\r\n</body>\r\n</html>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
