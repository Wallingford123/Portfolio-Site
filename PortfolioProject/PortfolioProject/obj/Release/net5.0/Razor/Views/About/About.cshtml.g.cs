#pragma checksum "C:\Users\Wallu\source\repos\PortfolioProject\PortfolioProject\Views\About\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcf4b09612714dc133a5e0ca40957ebd820daf9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_About), @"mvc.1.0.view", @"/Views/About/About.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Wallu\source\repos\PortfolioProject\PortfolioProject\Views\_ViewImports.cshtml"
using PortfolioProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wallu\source\repos\PortfolioProject\PortfolioProject\Views\_ViewImports.cshtml"
using PortfolioProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcf4b09612714dc133a5e0ca40957ebd820daf9a", @"/Views/About/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3d93066ccd4e3926c4f4e7d88efb4a6f620ef94", @"/Views/_ViewImports.cshtml")]
    public class Views_About_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:512px; height:312px; max-width:100%; height:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid align-content-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/kitty.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Wallu\source\repos\PortfolioProject\PortfolioProject\Views\About\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h3 class=\"fw-bold py-2 \">Callum Kent - Unity Developer (PLACEHOLDER IMAGE)</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fcf4b09612714dc133a5e0ca40957ebd820daf9a4610", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

</div>
<div class=""container"" style=""font-size:15px;"">
    <div class=""row py-5"">
        <div class=""mx-auto img-fluid col-lg pb-5 px-5"">
            <h3 class=""text-color-nice text-center"">Programming and Me</h3>
            <p class=""text-center p-0 m-0"">
                <span style=""font-weight:600"">I've been programming for a while now.</span><br /><br />
                </p>
            <p class=""p-0 m-0"">
                I started almost 10 years ago in computing class where I thought more lines of code meant it was better, smugly handing in my assignment with over a thousand lines, printed on over 30 pages of A4.<br /><br />
                I dabbled with Unity for the next 4 years without much direction other than make things I thought were cool at the time... terribly.<br /><br />
            </p>
            Then I went to the University of Portsmouth, studying Computer Games Technology, where I:
            <ul>
                <li class=""py-1"">
                    Became very s");
            WriteLiteral(@"killed with Unity and C# programming (as the majority of my time has been spent using them)
                </li>
                <li class=""py-1"">
                    Discovered how cool VR is; learning the potential uses of the technology and the design considerations that must be made, resulting in two very cool projects that can be found on my projects page (And how unreasonably fun Beat Saber is!).
                </li>
                <li class=""py-1"">
                    Competed in multiple game jams (Some I have showcased in my Projects page).
                </li>
                <li class=""py-1"">Learned how to effectively work within a multi-disciplinary team, demonstrated in my final year group project for the Royal Navy, that was presented at DSET.</li>
                <li class=""py-1"">
                    Graduated with Upper Second-Class Honours(2:1).
                </li>
            </ul>
            <br />
            <p>
                After University came the first job hun");
            WriteLiteral(@"t. After months of applying for everything and not being successful, I eventually decided to inquire about an offer I had previously declined while I was still finishing my course.<br />
                Thankfully the position had not been filled and I was given an interview, and within a few weeks I had moved to the area and had my first programming job!
            </p><br />
            <p class=""text-center fw-bolder"" style=""font-size:18px"">
                Media Developer for Babcock International Group, creating training media for the Royal Navy.<br />
                (December 2019 - March 2021)
            </p> <br />
            Unfortunately, due to the nature of the job, I am not able to share specifics or provide demos of my work, but I can give a brief overview of my contributions:
            <ul>
                <li>
                    Worked with a small team to create a training application in Unity, targeted for WebGL, to assist in the demonstration and practice of diving maneuver");
            WriteLiteral(@"s.
                </li>
                <li>
                    Provided consultancy to other developers to deduce logical or mathematical errors that arose during development.
                </li>
                <li>
                    Learned and assisted with web-development tasks under guidance of the technical lead.
                </li>
            </ul>
            <br />
            <p>
                <br />
                I left Babcock in March due to financial issues related to covid, and moved back home.<br />
                I've spent the last 6 months looking for work to no avail, while trying to bolster my portfolio and become a better programmer.<br />
                In this time I:
            </p>
            <ul>
                <li>
                    Participated in a game jam (Ludum Dare - Diggy diggy mole).
                </li>
                <li>
                    Made a crude demo for a base defence game (has a cool, easily expandable enemy wave gene");
            WriteLiteral(@"rating and spawning system).
                </li>
                <li>
                    Learned web development to make this portfolio website (ASP.NET Core, Razor, Bootstrap)!
                </li>
            </ul>
            <br />
            <p class=""text-center fw-bolder"" style=""font-size:18px"">
                And that brings us to now.
                I'm currently looking for any Unity Developer jobs, or junior C# ASP.NET Core jobs where I can learn from more senior developers.<br />
                Please contact me via email using the button on the navbar! <br />
                In the meantime I'll be working on my next project!
            </p>
        </div>
        <div class=""mx-auto img-fluid col-lg pb-5 px-5"">

            <h3 class=""text-color-nice text-center"">A little about me</h3>
            <p class=""text-center p-0 m-0"">
                <span style=""font-weight:600"">Plays games far too much.</span><br />
            </p>
            <p>
                <h4 c");
            WriteLiteral(@"lass=""text-center"">Games</h4>
                I am very heavily indexed into a vew small number of games, ocasionally testing the waters elsewhere but always coming back. <br /><br />
                Those games are:
                <ul>
                    <li>
                        League of Legends (Cassiopeia One trick, D2 peak, P2 current, Very into the eSports scene, big C9 fan. IGN - A Wild Ekans).
                    </li>
                    <li>
                        Old School Runescape (Main and Ironman, IGN - A Wild Ekans).
                    </li>
                    <li>
                        Path of Exile (More recent, started in Ritual league, likely to lose at least 2 weeks every new league).
                    </li>
                    <li>
                        Minecraft for a few weeks with friends every new update.
                    </li>
                    </ul>
            </p>
            <p>
                <h4 class=""text-center"">Music</h4>
         ");
            WriteLiteral(@"       My
                <a href=""https://open.spotify.com/playlist/1GzxfCq0HQRMDpCsNukSHY?si=d2e12ed4b1214b82"">playlist</a>
                pretty much sums up my music taste, and it is all over the place.
            </p>
            <p>
                <h4 class=""text-center"">Movies/TV</h4>
                When it comes to movies and tv, only paranormal horror is off the table. I'll watch and enjoy anything as long as it's a good movie and doesn't scare me half to death!
            </p>
            <p>
                <h4 class=""text-center"">Everything Else</h4>
                <ul>
                    <li>
                        I am a cat person, but I am extremely partial towards a pomsky (pomeranian + husky breed). It's just a husky that stays tiny!
                    </li>
                    <li>
                        If you're not hurting anyone, you do you ¯\_(ツ)_/¯
                    </li>
                    <li>
                        Follow football loosely, Chelsea su");
            WriteLiteral(@"pporter, mostly just watch big games.
                    </li>
                    <li>
                        Really like to show off playing beat saber, even though I can't do the most difficult songs.
                    </li>
                    <li>
                        Knows almost all of the words to Les Miserables.
                    </li>
                </ul>
            </p>
        </div>
    </div>
</div>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
