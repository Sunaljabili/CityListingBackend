#pragma checksum "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9543df0bb4ebb64f81b8d985e5d4096a2ce4772d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\_ViewImports.cshtml"
using CityBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\_ViewImports.cshtml"
using CityBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9543df0bb4ebb64f81b8d985e5d4096a2ce4772d", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03726fc993f660a72688bd5b67a28bb722955cbc", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/gallery/section_bg03.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/blog/founder.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- INTRO-PAGE AREA START -->
<section id=""intro-page"">
    <div class=""container"">
        <div class=""row "">
            <div class=""title-page text-center  "">
                <h2>
                    About
                </h2>
            </div>
        </div>
    </div>
</section>
<!-- INTRO-PAGE AREA START -->


<!--  About our company START -->
<section id=""ourcompany"">
    <div class=""container"">
        <div class=""row d-flex flex-wrap mt-5"">
            <div class=""col-lg-10 col-md-10 col-sm-12"">
                <div class=""company-about"">
                    <div class=""company-title"">
                        <h3>");
#nullable restore
#line 28 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\About\Index.cshtml"
                       Write(Model.AboutCompany.AboutTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </div>\r\n                    <div class=\"company-text\">\r\n                        <p>\r\n                         ");
#nullable restore
#line 32 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\About\Index.cshtml"
                    Write(Model.AboutCompany.AboutDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row justify-content-between  mt-5\">\r\n");
#nullable restore
#line 39 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\About\Index.cshtml"
             foreach (AboutCompany aboutcompany in Model.AboutCompanies)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 col-sm-12\">\r\n                    <div class=\"company-mission\">\r\n                        <h5>");
#nullable restore
#line 43 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\About\Index.cshtml"
                       Write(aboutcompany.MissionTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p>\r\n                         ");
#nullable restore
#line 45 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\About\Index.cshtml"
                    Write(aboutcompany.MissionTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 50 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\About\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>
<!--  About our company END -->


<!-- We are offering for you START -->
<section id=""offering"">
    <div class="" mt-5"">
        <div class=""d-flex flex-wrap"">
            <div class=""col-lg-4"">
                <div class=""single-img"">
                    <div class=""image"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9543df0bb4ebb64f81b8d985e5d4096a2ce4772d7730", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""col-lg-7 mt-5"">
                <div class=""travel"">
                    <div class=""travel-about d-flex flex-wrap"">
                        <span>We are offering for you</span>
                        <h3>Every Month, Millions of People visit this site We’ve Built.</h3>
                        <p>
                            Unlike what its name implies, dry cleaning is not actually a 'dry' process. Clothes
                            are soaked in a
                            different solvent.
                        </p>
                    </div>
                    <div class=""travel-categories d-flex"">
                        <div class=""travel-icon"">
                            <i class=""fal fa-route""></i>
                        </div>
                        <div class=""travel-about"">
                            <h4>Great places in the world</h4>
                            <p>
      ");
            WriteLiteral(@"                          Unlike what its name implies, dry cleaning is not actu process. Clothes soaked
                                differentent.
                            </p>
                        </div>
                    </div>
                    <div class=""travel-categories d-flex"">
                        <div class=""travel-icon"">
                            <i class=""fal fa-clipboard-list-check""></i>
                        </div>
                        <div class=""travel-about"">
                            <h4>Biggest category listing</h4>
                            <p>
                                Unlike what its name implies, dry cleaning is not actu process. Clothes soaked
                                differentent.
                            </p>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</section>
<!-- We are offering for you END -->

<!-- OUR CLIENT TESTIMONIALS START");
            WriteLiteral(@" -->
<section id=""testimonials"">
    <div class=""container"">
        <div class=""row mt-5"">
            <div class=""col-lg-12"">
                <div class=""title text-center"">
                    <span>Our client testimonials</span>
                    <h1>What our client say</h1>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 one-time"">
                <div class=""testimonial text-center mt-5"">
                    <div class=""testimonial-review"">
                        <p>
                            Consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore
                            magna aliqua. Quis
                            ipsum suspendisse ultrices gravida. Risus commodo viverra maecenas accumsan lacus
                            vel facilisis por
                            incididunt ut labore et dolore mas.
                        </p>
                    </div>
        ");
            WriteLiteral("            <div class=\"testimonial-founder\">\r\n                        <div class=\"founder-image mr-5\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9543df0bb4ebb64f81b8d985e5d4096a2ce4772d12189", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""founder-about"">
                            <h5>Oliva Jems</h5>
                            <span>UIX Designer</span>
                        </div>
                    </div>
                </div>
                <div class=""testimonial text-center mt-5"">
                    <div class=""testimonial-review"">
                        <p>
                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Corrupti voluptatem a, odio
                            facilis
                            nihil ut blanditiis tempore aperiam sint deleniti ab qui ducimus dignissimos
                            voluptatum officia. Sint
                            vero sit ullam!
                        </p>
                    </div>
                    <div class=""testimonial-founder"">
                        <div class=""founder-image mr-5"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9543df0bb4ebb64f81b8d985e5d4096a2ce4772d14284", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""founder-about"">
                            <h5>Sunal Jabiyev</h5>
                            <span>Developer</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- OUR CLIENT TESTIMONIALS END -->

<!-- Easy to explore START -->
<section id=""explore"">
    <div class=""container  "">
        <div class=""d-flex row flex-wrap mt-5"">
            <div class=""col-lg-12"">
                <div class=""title text-center mt-5"">
                    <span>Easy to explore</span>
                    <h1>How It Works</h1>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 justify-content-between mt-5"">
                <div class=""services text-center mb-50"">
                    <div class=""spinner"">
                        <div class=""circle"">
                        </div>");
            WriteLiteral(@"
                        <div class=""services-icon mr-5"">
                            <i class=""far fa-user-chart ""></i>
                        </div>
                    </div>
                    <div class=""services-text text-center"">
                        <h5><a href=""#"">1. Choose a Category</a></h5>
                        <p>incidid labore lore magna aliqua <br> uisipsum suspendis loris.</p>
                    </div>
                    <!-- <img class=""ml-5"" src=""~/assets/img/icon/serices1.png"" alt=""""> -->
                </div>
            </div>
            <div class=""col-lg-4 justify-content-between mt-5"">
                <div class=""services text-center mb-50"">
                    <div class=""spinner"">
                        <div class=""circle"">
                        </div>
                        <div class=""services-icon mr-5"">
                            <i class=""far fa-hand-holding-heart""></i>
                        </div>
                    </div>
              ");
            WriteLiteral(@"      <div class=""services-text text-center"">
                        <h5><a href=""#"">2. what you want</a></h5>
                        <p>incidid labore lore magna aliqua <br> uisipsum suspendis loris.</p>
                    </div>
                    <!-- <img class=""ml-5"" src=""~/assets/img/icon/serices2.png"" alt=""""> -->
                </div>
            </div>
            <div class=""col-lg-4 justify-content-between mt-5"">
                <div class=""services text-center mb-50"">
                    <div class=""spinner"">
                        <div class=""circle"">
                        </div>
                        <div class=""services-icon mr-5"">
                            <i class=""fas fa-handshake-alt""></i>
                        </div>
                    </div>
                    <div class=""services-text text-center"">
                        <h5><a href=""#"">3. Go out & Explore</a></h5>
                        <p>incidid labore lore magna aliqua <br> uisipsum suspendis loris.");
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Easy to explore END -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
