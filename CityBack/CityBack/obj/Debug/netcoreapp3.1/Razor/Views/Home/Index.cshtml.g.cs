#pragma checksum "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a15c427e0d55edfaf1fc9ee641be910ce5f44106"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a15c427e0d55edfaf1fc9ee641be910ce5f44106", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03726fc993f660a72688bd5b67a28bb722955cbc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LocationCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/gallery/home_blog1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/gallery/home_blog2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/gallery/home_blog3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- MAIN AREA START -->
<main>

    <!-- INTRO SECTION START -->
    <section id=""intro"">
        <div class=""container"">
            <div class=""row"">
                <div class=""slogan col-lg-11 col-11 col-sm-11 col-md-11"" style=""padding:250px 0px "";>
                    <h4>");
#nullable restore
#line 13 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                   Write(Model.Intro.HeadTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h1> ");
#nullable restore
#line 14 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                    Write(Model.Intro.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                   
                </div>
            </div>
            </div>
    </section>
    <!-- INTRO SECTION END -->


    <!-- POPULAR LOCATIONS START -->
    <section id=""popular"">
        <div class=""container mt-5"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-12 col-sm-12 col-12"">
                    <div class=""title text-center"">
                        <span>Explore the city</span>
                        <h1>Discover Great Places</h1>
                    </div>
                </div>
            </div>
            <div class=""row mt-5"">
");
#nullable restore
#line 35 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                 foreach (PopularLocation popular in Model.PopularLocations.Take(6))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 col-sm-12 col-12 mt-3\">\r\n                        <div class=\"single-card\">\r\n                            <div class=\"image-card\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a15c427e0d55edfaf1fc9ee641be910ce5f441067626", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1361, "~/assets/img/gallery/", 1361, 21, true);
#nullable restore
#line 40 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1382, popular.Image, 1382, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"location-country\">\r\n                                <h1>");
#nullable restore
#line 43 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                               Write(popular.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                                <div class=\"location-city-count\">\r\n                                    <a href=\"#\">");
#nullable restore
#line 45 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                                           Write(popular.CityCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fal fa-plus\"></i> <span>Location</span></a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 50 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"button\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a15c427e0d55edfaf1fc9ee641be910ce5f4410610529", async() => {
                WriteLiteral("\r\n                        VIEW ALL PLACES\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            </div>
        </div>
    </section>
    <!-- POPULAR LOCATIONS END -->

    <!-- Easy to explore START -->
    <section id=""explore"">
        <div class=""container"">
            <div class=""d-flex row flex-wrap mt-5"">
                ");
#nullable restore
#line 66 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("Explore"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </div>\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 75 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                 foreach (Explore explore in Model.Explores)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-4 col-md-6 col-sm-12 col-12 justify-content-between mt-5"">
                        <div class=""services text-center mb-50"">
                            <div class=""spinner"">
                                <div class=""circle"">
                                </div>
                                <div class=""services-icon mr-5"">
                                    <i");
            BeginWriteAttribute("class", " class=\"", 3261, "\"", 3282, 1);
#nullable restore
#line 83 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 3269, explore.Icon, 3269, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"services-text text-center\">\r\n                                <h5><a href=\"#\">");
#nullable restore
#line 87 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                                           Write(explore.ChooseCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                <p>");
#nullable restore
#line 88 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                              Write(Html.Raw(explore.CategoryTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 93 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
        </div>
    </section>
    <!-- Easy to explore END -->

    <!-- FEATURED CATEGORIES START -->
    <section id=""featured"">
        <div class=""container"">
            <div class=""row mt-5"">
                <div class=""col-lg-12"">
                    <div class=""title text-center"">
                        <span>");
#nullable restore
#line 105 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                         Write(Model.FeaturedCategory.HeadTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <h1>");
#nullable restore
#line 106 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                       Write(Model.FeaturedCategory.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row mt-5\">\r\n");
#nullable restore
#line 111 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                 foreach (FeaturedCategory featuredcatg in Model.FeaturedCategories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-3 col-md-6 col-sm-12 col-12"">
                        <div class=""card section-card text-center"">
                            <div class=""move-up"">
                            </div>
                            <div class=""card-icon mt-5"">
                                <i");
            BeginWriteAttribute("class", " class=\"", 4698, "\"", 4728, 1);
#nullable restore
#line 118 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 4706, featuredcatg.CatgIcon, 4706, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                            </div>\r\n                            <div class=\"card-title\">\r\n                                <h5>\r\n                                    <a href=\"#\">");
#nullable restore
#line 122 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                                           Write(featuredcatg.CatgTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h5>\r\n                            </div>\r\n                            <div class=\"card-body\">\r\n                                <p>");
#nullable restore
#line 126 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                              Write(featuredcatg.CatgDdescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <a href=\"#\">View Details</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 131 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </section>
    <!-- FEATURED CATEGORIES END -->

    <!-- We are offering for you START -->
    <section id=""offering"">
        <div class="" mt-5"">
            <div class=""d-flex flex-wrap"">
                <div class=""col-lg-4"">
                    <div class=""single-img"">
                        <div class=""image"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a15c427e0d55edfaf1fc9ee641be910ce5f4410618592", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5724, "~/assets/img/gallery/", 5724, 21, true);
#nullable restore
#line 144 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5745, Model.Offering.Image, 5745, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                            <span>");
#nullable restore
#line 151 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                             Write(Model.Offering.HeadTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                            <h3>");
#nullable restore
#line 153 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                           Write(Model.Offering.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                            <p>\r\n                                ");
#nullable restore
#line 156 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                           Write(Model.Offering.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n\r\n");
#nullable restore
#line 160 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                         foreach (Offering offering in Model.Offerings)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"travel-categories d-flex\">\r\n                                <div class=\"travel-icon\">\r\n                                    <i");
            BeginWriteAttribute("class", " class=\"", 6576, "\"", 6598, 1);
#nullable restore
#line 164 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 6584, offering.Icon, 6584, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                </div>\r\n                                <div class=\"travel-about\">\r\n                                    <h4>");
#nullable restore
#line 167 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                                   Write(offering.OfferingTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <p>");
#nullable restore
#line 168 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                                  Write(offering.OfferingDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 171 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>

                </div>
            </div>
        </div>
    </section>
    <!-- We are offering for you END -->

    <!-- OUR CLIENT TESTIMONIALS START -->
    <section id=""testimonials"">
        <div class=""container"">
            <div class=""row mt-5"">
                <div class=""col-lg-12"">
                    <div class=""title text-center"">
                        <span>");
#nullable restore
#line 186 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                         Write(Model.ClientTestimonial.HeadTtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <h1>");
#nullable restore
#line 187 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                       Write(Model.ClientTestimonial.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-12 col-md-12 one-time\">\r\n");
#nullable restore
#line 193 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                     foreach (var testimonial in Model.ClientTestimonials)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"testimonial text-center mt-5\">\r\n                            <div class=\"testimonial-review\">\r\n                                <p>\r\n                                    ");
#nullable restore
#line 199 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                               Write(testimonial.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                            <div class=\"testimonial-founder\">\r\n                                <div class=\"founder-image mr-5\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a15c427e0d55edfaf1fc9ee641be910ce5f4410625696", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8224, "~/assets/img/blog/", 8224, 18, true);
#nullable restore
#line 204 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 8242, testimonial.WorkerImage, 8242, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"founder-about\">\r\n                                    <h5>");
#nullable restore
#line 207 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                                   Write(testimonial.WorkerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <span>");
#nullable restore
#line 208 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                                     Write(testimonial.WorkerJob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 212 "C:\Users\HP\Desktop\Backend Lessons\Projects\CityBack\CityBack\CityBack\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!-- OUR CLIENT TESTIMONIALS END -->\r\n\r\n    <!-- SUBSCRIBE  OUR NEWSLATTER START -->\r\n");
            WriteLiteral(@"
    <!-- SUBSCRIBE  OUR NEWSLATTER END -->

    <!-- OUR BLOG SECTION START -->
    <section id=""ourblog"">
        <div class=""container"">
            <div class=""row mt-3"">
                <div class=""col-lg-12 col-12 col-md-12 col-sm-12"">
                    <div class=""title text-center"">
                        <span>Our Blog</span>
                        <h1>News and tips</h1>
                    </div>
                </div>
            </div>
            <div class=""row mt-3"">
                <div class=""col-lg-4 col-12"">
                    <div class=""card-blog "">
                        <div class=""card-image"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a15c427e0d55edfaf1fc9ee641be910ce5f4410629315", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""card-title"">
                            <span>HEALTH & CARE </span>
                            <h3> <a href=""#"">The Best SPA Salons For Your Relaxation</a></h3>
                            <p> October 6, 2020by Steve</p>
                        </div>
                    </div>
                </div>


                <div class=""col-lg-4 col-12"">
                    <div class=""card-blog"">
                        <div class=""card-image"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a15c427e0d55edfaf1fc9ee641be910ce5f4410630992", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""card-title"">
                            <span>HEALTH & CARE </span>
                            <h3> <a href=""#"">The Best SPA Salons For Your Relaxation</a></h3>
                            <p> October 6, 2020by Steve</p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4 col-12"">
                    <div class=""card-blog"">
                        <div class=""card-image"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a15c427e0d55edfaf1fc9ee641be910ce5f4410632665", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""card-title"">
                            <span>HEALTH & CARE </span>
                            <h3> <a href=""#"">The Best SPA Salons For Your Relaxation</a></h3>
                            <p> October 6, 2020by Steve</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- OUR BLOG SECTION END -->
</main>
<!-- MAIN AREA END -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591