#pragma checksum "C:\Users\Dagi's pc\Documents\3rd Year 1st Semester\OOP II\Final Project\gazeta\web_frontend\Gazeta\Views\Dashboard\posts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca6d7b84383ae681a01d80562f90193c9e28a7cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_posts), @"mvc.1.0.view", @"/Views/Dashboard/posts.cshtml")]
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
#line 1 "C:\Users\Dagi's pc\Documents\3rd Year 1st Semester\OOP II\Final Project\gazeta\web_frontend\Gazeta\Views\_ViewImports.cshtml"
using Gazeta;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dagi's pc\Documents\3rd Year 1st Semester\OOP II\Final Project\gazeta\web_frontend\Gazeta\Views\_ViewImports.cshtml"
using Gazeta.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca6d7b84383ae681a01d80562f90193c9e28a7cb", @"/Views/Dashboard/posts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1da603159ad51393413985ce99485f504512b618", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_posts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/fontawesome-free/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/admin-2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" fixed-bottom d-flex justify-content-end my-5 mr-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca6d7b84383ae681a01d80562f90193c9e28a7cb6606", async() => {
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
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca6d7b84383ae681a01d80562f90193c9e28a7cb7788", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ca6d7b84383ae681a01d80562f90193c9e28a7cb8966", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link href=\"https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i\"\r\n          rel=\"stylesheet\">\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ca6d7b84383ae681a01d80562f90193c9e28a7cb10401", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Dagi's pc\Documents\3rd Year 1st Semester\OOP II\Final Project\gazeta\web_frontend\Gazeta\Views\Dashboard\posts.cshtml"
  
    ViewData["Title"] = "Company Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\Dagi's pc\Documents\3rd Year 1st Semester\OOP II\Final Project\gazeta\web_frontend\Gazeta\Views\Dashboard\posts.cshtml"
  Layout="../Shared/companyLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div id=""page-top"">

    <div id=""wrapper"">
         <div id=""content-wrapper"" class=""d-flex flex-column"">

            
               
                <div class=""container"">
                   
                    <div class=""my-5"">
                        <h1 class=""text-center"">Posts</h1>
                    </div>

                    <div class=""card ml-3 my-5""  style=""width: 1100px; "">
                        <div class=""row g-0"">
                            <div class=""col-md-4"">
                                <img src=""https://media.istockphoto.com/photos/breaking-news-world-news-with-map-backgorund-picture-id1182477852?k=6&m=1182477852&s=612x612&w=0&h=X-UipiiX5xcMw9dBhzKZWG7UcWjEOARl2s_oTVV8rtE="" alt=""...""
                                    class=""img-fluid "" style=""width: 300px; height:300px;"" />
                            </div>
                            <div class=""col-md-6 pl-0 no-gutters "">
                                <div class=""card-body"">
                  ");
            WriteLiteral(@"                  <h5 class=""card-title"">200 mln-birr bus terminal starts operation</h5>
                                    <p class=""card-text"">
                                        The new Mercato Bus Terminal built with an outlay of 200 million birr begins operations as of today, according to the Addis Ababa City Administration Transport Bureau.
                                    </p>
                                    <p class=""card-text"">
                                        The unique bus terminal named after Mercato ??? the largest open market in the country ??? is said to be the most convenient bus terminal only hosting Anbessa and Sheger city buses.

                                    </p>
                                  
                                    <p class=""card-text"">
                                        <small class=""text-muted"">Last updated 3 mins ago</small>
                                    </p>
                                </div>
                          ");
            WriteLiteral(@"  </div>
                            <div class=""col-md-2 py-5 "">
                              
                               <button type=""button"" class=""btn btn-outline-primary   waves-effect mr-3 my-5 ""><i class=""fas fa-edit ""
                                aria-hidden=""true""></i></button>
                               <button type=""button"" class=""btn btn-outline-danger  waves-effect ""><i class=""fas fa-trash ""
                                aria-hidden=""true""></i></button>

 
                            </div>
                        </div>
                    </div>
                    <div class=""card ml-3 my-5""  style=""width: 1100px; "">
                        <div class=""row g-0"">
                            <div class=""col-md-4"">
                                <img src=""https://media.istockphoto.com/photos/breaking-news-world-news-with-map-backgorund-picture-id1182477852?k=6&m=1182477852&s=612x612&w=0&h=X-UipiiX5xcMw9dBhzKZWG7UcWjEOARl2s_oTVV8rtE="" alt=""...""
                     ");
            WriteLiteral(@"               class=""img-fluid "" style=""width: 300px; height:300px;"" />
                            </div>
                            <div class=""col-md-6 pl-0 no-gutters "">
                                <div class=""card-body"">
                                    <h5 class=""card-title"">200 mln-birr bus terminal starts operation</h5>
                                    <p class=""card-text"">
                                        The new Mercato Bus Terminal built with an outlay of 200 million birr begins operations as of today, according to the Addis Ababa City Administration Transport Bureau.
                                    </p>
                                    <p class=""card-text"">
                                        The unique bus terminal named after Mercato ??? the largest open market in the country ??? is said to be the most convenient bus terminal only hosting Anbessa and Sheger city buses.

                                    </p>
                                  
            ");
            WriteLiteral(@"                        <p class=""card-text"">
                                        <small class=""text-muted"">Last updated 3 mins ago</small>
                                    </p>
                                </div>
                            </div>
                            <div class=""col-md-2 py-5 "">
                              
                               <button type=""button"" class=""btn btn-outline-primary   waves-effect mr-3 my-5 ""><i class=""fas fa-edit ""
                                aria-hidden=""true""></i></button>
                               <button type=""button"" class=""btn btn-outline-danger  waves-effect ""><i class=""fas fa-trash ""
                                aria-hidden=""true""></i></button>

 
                            </div>
                        </div>
                    </div>
                    <div class=""card ml-3 my-5""  style=""width: 1100px; "">
                        <div class=""row g-0"">
                            <div class=""col-md-4"">
  ");
            WriteLiteral(@"                              <img src=""https://media.istockphoto.com/photos/breaking-news-world-news-with-map-backgorund-picture-id1182477852?k=6&m=1182477852&s=612x612&w=0&h=X-UipiiX5xcMw9dBhzKZWG7UcWjEOARl2s_oTVV8rtE="" alt=""...""
                                    class=""img-fluid "" style=""width: 300px; height:300px;"" />
                            </div>
                            <div class=""col-md-6 pl-0 no-gutters "">
                                <div class=""card-body"">
                                    <h5 class=""card-title"">200 mln-birr bus terminal starts operation</h5>
                                    <p class=""card-text"">
                                        The new Mercato Bus Terminal built with an outlay of 200 million birr begins operations as of today, according to the Addis Ababa City Administration Transport Bureau.

                                    </p>
                                    <p class=""card-text"">
                                        The unique bus ");
            WriteLiteral(@"terminal named after Mercato ??? the largest open market in the country ??? is said to be the most convenient bus terminal only hosting Anbessa and Sheger city buses.

                                    </p>
                                  
                                    <p class=""card-text"">
                                        <small class=""text-muted"">Last updated 3 mins ago</small>
                                    </p>
                                </div>
                            </div>
                            <div class=""col-md-2 py-5 "">
                              
                               <button type=""button"" class=""btn btn-outline-primary   waves-effect mr-3 my-5 ""><i class=""fas fa-edit ""
                                aria-hidden=""true""></i></button>
                               <button type=""button"" class=""btn btn-outline-danger  waves-effect ""><i class=""fas fa-trash ""
                                aria-hidden=""true""></i></button>

 
                ");
            WriteLiteral("            </div>\r\n                        </div>\r\n                    </div>\r\n                       \r\n                    </div>\r\n                    <div class=\"container  \">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca6d7b84383ae681a01d80562f90193c9e28a7cb19985", async() => {
                WriteLiteral(" <i class=\"fas fa-plus-circle fa-4x\" ></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                     </div>\r\n\r\n                </div>\r\n             </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
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
