#pragma checksum "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab1a45558d0743e7a6ecd32b736b736d37006fd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Gener), @"mvc.1.0.view", @"/Views/Home/Gener.cshtml")]
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
#line 1 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\_ViewImports.cshtml"
using GazetaCompanies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\_ViewImports.cshtml"
using GazetaCompanies.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab1a45558d0743e7a6ecd32b736b736d37006fd2", @"/Views/Home/Gener.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40ed0fa1d792786fc244e3baa2fb29e016a76a1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Gener : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Gazeta.Models.News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ab1a45558d0743e7a6ecd32b736b736d37006fd24852", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ab1a45558d0743e7a6ecd32b736b736d37006fd26034", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml"
  
    ViewData["Title"] = ViewBag.topic;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 12 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<section class=\"row mx-2\">\r\n");
#nullable restore
#line 15 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml"
     foreach (var news in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card col-md-3\">\r\n\r\n            <div class=\"card-body\">\r\n");
#nullable restore
#line 20 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml"
                 if (news.ImageURL != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ab1a45558d0743e7a6ecd32b736b736d37006fd28344", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml"
                   WriteLiteral("~/image/" + news.ImageURL);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 22 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""mt-3"">
                    <div id=""headline"">
                        <img src=""data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxEQEBUSERIWEBAQFRcXFRUXEhUVEhcWFRYXFhUVFhUYHSggGBolGxUYITEiJSkrLi4uFx8zODMtNygtLisBCgoKDg0OGhAQGy0mICYvLTAtLS8tLzI1Ly0tLS0tLS01LS0tLS0tLTUtLS0tLS0tLS0tLS0tLS0tLS0tLS0tLf/AABEIAOEA4QMBIgACEQEDEQH/xAAbAAEAAgMBAQAAAAAAAAAAAAAAAQUDBAYCB//EAEgQAAIBAgEGCgYHBgMJAAAAAAABAgMRBAUSITFBUQYVIlRhcYGRk9ETMkJSobEjM1NygpLBFmKi0uHwNLLCFCRDY3ODo8Pi/8QAGwEBAAIDAQEAAAAAAAAAAAAAAAQFAQMGBwL/xAA8EQABAgMEBwYEBQMFAQAAAAABAAIDBBEFITFRBhITQWFxkVKBobHB0SIy4fAUM0KC8WKSwiM0Q3KiFf/aAAwDAQACEQMRAD8AruOMTzir4s/MccYnnFXxZ+ZpA6jZM7I6Ljtq/M9St3jjE84q+LPzHHGJ5xV8WfmaQGyZ2R0TavzPUrd44xPOKviz8xxxiecVfFn5mkBsmdkdE2r8z1K3eOMTzir4s/MccYnnFXxZ+ZpAbJnZHRNq/M9St3jjE84q+LPzHHGJ5xV8WfmaQGyZ2R0TavzPUrd44xPOKviz8xxxiecVfFn5mkBsmdkdE2r8z1K3eOMTzir4s/MccYnnFXxZ+ZpAbJnZHRNq/M9St3jjE84q+LPzHHGJ5xV8WfmaQGyZ2R0TavzPUrd44xPOKviz8xxxiecVfFn5mkBsmdkdE2r8z1K3eOMTzir4s/MccYnnFXxZ+ZpAbJnZHRNq/M9St3jjE8");
            WriteLiteral(@"4q+LPzHHGJ5xV8WfmaQGyZ2R0TavzPUrd44xPOKviz8xxxiecVfFn5mkBsmdkdE2r8z1K3eOMTzir4s/MccYnnFXxZ+ZpAbJnZHRNq/M9St3jjE84q+LPzHHGJ5xV8WfmaQGyZ2R0TavzPUrd44xPOKviz8waQGyZ2R0TavzPUoAD7WtAAEQABEAARAAEQABEAARAAEQABEAARAAEQABEAARAAEQABEAARAAEQABEAARAAEQAgIpBAbM0Q3KQQDCypAAWEAARAAEQABEAARAAEQABEAARAAEQABEAICISQdBk3g5ePpcTL0FJbHom+/wBX5kWbnYMqzXimlcBiScgBeTyUiXlokd2qwc8hxJ3KkoUJTebCLnJ7Em38C/wPBCrLTVkqS3etLt2LvMtbhHSoR9Hg6SS9+Senptrb62UWMylWrP6So5dF7R/KtBVmJak3+WBBbm74nn9uAU7Ukpf5yYjshc3rie5dMsnZNofWVFOS3zcv4aZ7jlzJ8PUguuNFJ97szjEg4NbLfA1O0eZF/wBxHiPP/anhf5r7FruZ+TCY0cq+JXarhbhvcqfkh/MU/CTLFHERgqcHFxd3JqKdrWzVZvr7ChIN8ro9JysZsaHrVGFXHyWqYtiZjwzDfq0PBSCAXiq1INqhk2tP1aUmt+Y7d70Gwsg4n7J98fMjPnZZho+I0c3BSGSsd4q1jj+0+yrSC0/Z/FfZS/NHzM9HgviJPlJQXTJP4RuaX2rJMFXRm9fZbWWdNPNBDd096KmUW9S1Hk7Gtk2nhcNVd86c4uLk9F3LQklsV3fsOOPmzrRZPB74Q+EGgOd15WZ6RdKFrXn4iKkZXqQAWKgoAAiAAIgACIAAiAEBEPUIttJK7bsktLbehJI8nRUEsDTVSSTxdRXhF6qUX7Uul/3tIk3NbFoDRrPdc1uZ45AC8ncpEvA2pJcaNGJy7t5O4LLRw9LAJTrWq4lq8KeyG5yf6928pMoZRq4iWdUlfctUV1L+2YK1WU5OUm5Sk7tvW2bTox");
            WriteLiteral(@"o/WLOq7KeyP/U6f3V2taiLBlWwH7WMdeMd+XBo/S3jjmSVJiR3RW6kMasMfdSd5+6LBSw8ms7RGGq8tEb7l7z6FcZ0I6lnvfLRH8qd+99h4rVpTd5O71LcluS1JdCMZYBjnfMe4fdT4clDLmj5ev3cvcq0tV7LclZdyMZs4fBVKmmMG1v1R73oLSjwZqv1pRj3yZFj2jJy10SI0HL+KqTAkJuYvhsJ4/zRURJ0i4KP7X+D/wCjDieDThFy9KrRTbvFrQupsis0gs97g1sS88HeykusOeaCSzDiPdU2HoyqSUILOlLQkdrkfIVOik5JVKu9rQvur9TSyTClgqXpKztVqq6ja883Ykvn/Qx1eF+nkUbrfKdn3JP5lJase0LRcYMk07MXF1aax5ml3LvVlZ8KTkgIk04a5vDaE6uV1DfzXU2Gacj+2FX7KHfIw1eFld6lGPVFt/F2KFmilonFrR+4eitXaQyQwJPcV2ljTx2UKVFfSTSfu65PqicTiMtYip61VpPZfNX8NiuLaV0NdUGYi3ZNHqfQKvmNJrv9Fl+bj6D3VrlvLEsQ0rZtOPqx233y6fkVQJO1lpaFLQxChCjRuXLx48SO8xIhqSgAN60oAAiAAIgACIAAiAHuhSc5RjFXlJpLrZhzg0EnALIBJoFZZHpRgniaivCk7Qj79TYupa2V+JxEqk5Tm86U3dv+9ht5WrxvGlB3pUFmx/eftz7ZfCxOTaahF4iavGm7U4vVKprV98Y632IroZ1azLx8TrmjgT8Le/F3sFOcNYiA03NvJ40vPdgFNv8AZkm/8RJXS+yi9Tf/ADHs3LTr1VrZ7q1HKTlJ50pO7b1tsyYLCyqzUI63rexLa2SWAQWGLEN+LjuHLgMB1Wg1jPEOGOAH3vKjC4adWWbCOc33Jb29iOpyZwfhCzqfSS6VyV1Lb2lhkzJ0KMc2K63tb3s31E4C19JIswTDlzqsz3n27l21m2HClgHxgHP8B6V4rHGirWsrbtltxQ5FyjmVZYao75snGn");
            WriteLiteral(@"J6XoeiLfy7tx0dj59lqX+81WtFqj09T1mvR6UbPbaXiYFoIOTgbj94i5ZtubfK7KMzEEgjMUqR94L6BmlJwjx8aebB6fbcfezXyIvoztL6I9JZ5LxXpqMKj1yjyvvLRL4pnCZVxfpq057H6v3Voj8EZ0esoxp17YuEOteeHofNfFs2js5Vphn56U5Y+yx1qs61S8nn1JtLrb0K25HTw4L0lFZzk520tOyv0KxWcEsJn189+rSV/wAT0R/V9h2lix0jtaLLRmy0s7VDQCaXY4DkBu4qFYVnwo0N0eO3Wqbq+J7yuEypkWdHlLlw320r7y/Uqj6bUp3OPy/kb0d6lNch+svd6V0fImWHpH+IcIEz82458Dxyzyrjptewtk0xpf5d7cuI4cN3LCiJDB1y5ZAAEQABEAARAAEQABEAARDeyfL0anV2wVofeqXV+yKm+uxoG1XdqcIb86T65PNj/DFP8RomG67RDzN/LE9Rd3rdBOqS/LzwHjf3LDRpuUlGKu5NJLpbsjey1USmqMHenQWYumeupLrcr9yMuQFmynWerDwcluz3yYLvd+wqm769pp/OmiN0Mf8Ap3s27k5bSNSBxcfBv18l5O2yBk70ULtcuTTl0bo9nmc3wfwvpKyv6sNL7NS7/kd3TjZHK6W2gRqyjDuq70Hr0XTaNSQo6adjg31PovUUegiTgyV1K8VqqhGUperBNvqSuz5pVm5Scnrldvrbudbwvx+bBUU+VU0y6Eno72vgzjrnouiMk6FLuju/WbuQ+tVxOkc0IkdsEfpx5n2FF1WTa7p5NlLbnOMfxWX6tnKnTZaoOjgKFN6HKedJdLjKVn1Z3wOZbLOxQx4jR2friO8Lh5FV9qOc3ZQnfpY3xFV3PBTCZmHUnrqty7NUflftLg84SKVOCj6uZG3VZWPbR5jPTBmJmJFdvcfp0wXeycJsKAyG3cB/K8sxV6akrNXTMx5kiO00KlBfP8r4D0NVx9l6Y9W7s1GidlwlwmfScl61PlLq9r4aew4w9Z");
            WriteLiteral(@"sK0DOyge75hceY394XnVtSQlZkhvym8d+7uUgAuFUoAAiAAIgACIAAiAAIhlxMry6I2j+VJfpftMJ6buYpU1X0DdRW0ORgJv7Wso9lOOd8ynLrFq2Aw/706r7m4r5FKQLP+IRH5xH+B1f8VJm7iwZMb43+q6ngjR5Ep73bsir/AOo6aKKPgsvoI9Ll82XsTzS3YhfPxSe0R0u9F6FZbAyShAdkHrepRgx+NhQpuc9mpbZPYke8RWjTg5zdoxV2/wC9bOCyvlOWInnPRBepHcvNmyw7HfaEWrroY+Y5/wBI4nwHcotq2m2Th0b85wHqeXiVrYvESqzlUnplJ3fRuS6EWfBfJbr1s6S+ip2ztzfsx6d76Osp106jqcFwno0Kap06Es1b5q7e1vRrZ31rmahyuxkoZLiKClAGjvOVw71x0hsXRtpMvoBfzP8AOJVhw3w7eHUl7FRN9Uk182jhD6Jk/LeHxqlQmnTlUi1mvVL7sltWuztqOMyxkmphZuM1eN+TP2ZLffY+gqdF475dhs+ZGpEBqAd7TlnQ1+7lMtlrYzxMwjrNNxI3EZrLk7hBXoRzItSgtSavbqadzdpcLqt+VThJdF4vv0nOEXLyNYsjGcXvhNJOJw8qKBDtSbhgBkQ0HL1XdTyw5UvT0YqpCP1lN6Jx6U1f5GfJ2WKVfRF5s/clr7NjOa4KVrV8x+rWTi1sdk2vhfvKqtHMm0m04Oye28Xa99+g506Nyz4kSWHwltHNd/Sa3EYGhFKgA3q7Ftx2MZHxBqHDiKXjeKg8RcvoWKpqUWnqaafU9DPndWOa2nrjo7tB2OQspuvSal9ZT19K2S8zlMpq1aov3pfM+tGIUWVmY8tFxFD6V6EL60giw5iWgzDMCSPWncQtYAHZrk0AARAAEQABEAARAAEQgkBFdYvTk/Dv3KtSL/E5SKQvsIvSZOrR9qjOM11Oyf8AqKIrbNNNtDP6Yjuh+Ieamzo/LdmxvhVvouw4Kzvh0vdlJfr+pfROT4JYiznDqkvk/w");
            WriteLiteral(@"BDq4M850ggGHaEQZmo7713tkRREkYRG4U6XLkuFuUXOp6GL5NP1umX9E+9soUrvr1CrUc25PXPlPrbuXHBPCKpiM56qSzu3VHz7D0KG2HZVn8GNqeJ+pXDvc+0Jzi40HAfQLBxBivsn3x8zWxuAq0belg4Z17aU72tfU+lH0qLOV4d66P/AHP/AFnP2RpNMzk6yXe1oDq4VrcCc+CtrRsSDLSzozXOJFMabzTJcvTquElOLtKElJPpTuj6vVtUjyoqUZJXTV1p6GfJJ6mfWKT5K6l8jRpu0DYOFx+K/wDt9VnRoaxig4fD6rQlkTC3v6CF+23dexswoQirRhGK3KKSMzZjkzjHTUeIAHvcRxcfddUyXhM+VoHcFT1skxjiaVanFR5UlNJWjphK0rbNOjtOMx8r1aj3yk+9tn0LKGI9FSnP3Ytrr2LvsfNTv9E4kWO18WIa6oDATzLvCoXJaRMhwi2GwYkuPgPGiuOC9S2IS2SUk+xZ36FflCedVm98pfM3cgTzJTqbKUG+18lIqi/gwgZ+LFHZa3vvPkQquLEIkYUM9px7sPdSACyVagACIAAiAAIgACIAAiEEkBFfcEqq9LKjL1MRB0+2za+Gd3lNiaDpzlCXrQbi+xkUqrhKMou0otNdad0X3CagqsYYumuRVSU7bJrRp7s3sW8qHu/DWgCfliin724dW3dysWjbSlBjDNf2nHob1T5PxXoqkZ7E9PbrPoGHqJpNaU/kfNjpODOVP+DJ6V6j6Pd8iq0psx0aGJmGL248s87shuVvo5PiG8y7zc7DnhTv81S5Twbo1ZQa0Jtx6YvU+4jB42pRlnU5Zras9TuulM7jHYCniI2mtK1SXrrqf6FHPgjK/Jqq3TB3+DMyOkcnHlxDmyAaUIIJDvA45Gi1zdhzUCNrS4qN1CAR5dQtD9o8V76/JHyNTKGUqtfN9LLOzL20Jeta+rqRcrgjP7aP5H5lRlfJzw81ByUm4qV0mtbatp6idIx7JiRgJUM17zc2h436oUKbg2");
            WriteLiteral(@"jDh1mNbV4mo8ytEsaeW8THVWlo3u/zNCKu7bzpnwQl9v8Awf1JVozcjA1RN0vrSra89xUeSlpuLX8MDdjQ09RxWPAcK6idq0c+O+KzZrs1P4HV0K0akVKLvGSumcx+yEvtl+T+pd5FwDw9P0bnn8p20WsnbRr3pvtOFtwWTEYIsm4B9bwAQCM8BSnBdZZX/wBBj9SZHw0uJIu4Y71VcMsZaMaS1yedLqWr46ew5I3ctYn0tec9ns/djoXn2mpG19OradxY0n+DkmQ6X0qeZvPsFytpzJmZpz91aDkLvr3rdrP0dBQ9qs86XQl6i7dZoM916rnJyet9yWpJdCWg8E6XhGG2/Emp5n0GAUWYi67hTACg5D7qgAN60IAAiAAIgACIAAiAAIgACKDoODGNhysNW+pr6FfZJ6Ney+jtSKAgizkq2agmE66uB3gjAjiPpvW+WmHQIge3vGY3g8Ct/KuTZ4eq4S64y2SW9fJ9Jop20rQ0dVk7Fwx1L/Z67tWj9XU2vR8XvW1HP5QwE6E8yorPY9klvT2ohyE857jLTN0VuOTh2m5g7wMD1Uqblg0CNBvhnwPZP3eF0OQ8uqVoVHaepPUpeTOhjM+ZFvk3LtSlZS+khub5S6n5lBa+i+uTFlO9uHQ+hu4q9s3SEBohzP8Ad7j1Heu5TON4Zf4iP3F/mkXeCy5Rqe1mvdLkvyZR8LpXrxa1Zi/zSK3RyVjS9phsVpadV2I4Kbb0WHFkC6G4EVbgeKpaetH1CWs+XU9f97z6ZOork3TMXwf3f4qJoveIvd6r1cw4ytm05yWuMZPuTMWJx1On68lHrensW05/KnCFSjKFOOcpJpyehWejQjm7PsuZmojdmwkVFTgKcyr6dnYEtDO0eAaXDf0XNIAk9eK8xGCgkAIgACIAAiAAIgACIAAiAAIgACIQSAilO2rQ13nT4DLdLEQ9BjEn7tTVp3t+y+k5YEKekIU40B9Q4XtcLi05g+e4qVKzb5dxLbwcQcCOP3cr7KvBirS5VL6anr");
            WriteLiteral(@"uvXS6UtfWvgURZZKy3Ww+iLzoe5LTHs93sL3jHA4v66Hoaj9p6P/JHX+IrfxU/JfDMM2rO2z5v3N9rlN2EpM3wX6juy7Dud7rkCDrK3BCMlnUKylF6s7SvzR8jRq8E8StSjPql/Mkb4Vv2dF/5QDk74T40WqJZE4z9BPEX+SokzPPH1Za6kn+Jm9+zeL+xfiQ/mNHGYOpRlmVIuErXtdPQ9TTTsyYyZlJh2qxzHEZEEqO6FMwGklrmg8CB6LXAJJiioAAiAAIgACIAAiAAIgACIAAiAAIgACIAAiAAIoBIMoslGtKDvCTg/wB2Tj8jfpcIcVHVWb61GXzRWAjxZWBF/MY08wD5rbDjxYfyOI5EjyV2uFWJ3rw0VuPx1SvPPqO8rW1JJJbEkawNUCzpSXdrwobWnMAArZFnI8VurEeSMiUABMUZAAEQABEAARAAEQABEAARAQBVFIIAqikEAVRSCAKopBAFUUggCqKQQBVFIIAqikEAVRSCAKopBAFUUggCqKQQBVFIIAqikEEiqLqQARlaIAAiAAIgACIAAiAAIgACIAAiAAIgACIAAiAAIgACIAAiAAIv/9k="" alt=""fana tv"" />

");
#nullable restore
#line 28 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml"
                          
                            var textArray = @news.Headline.Split(" ");
                            if (textArray.Length > 6)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span> ");
#nullable restore
#line 32 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml"
                                  Write(string.Join(" ", textArray.Take(6)));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</span>\r\n");
#nullable restore
#line 33 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>");
#nullable restore
#line 36 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml"
                                 Write(news.Headline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 37 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div id=\"post-info\">\r\n                        <span id=\"company\">");
#nullable restore
#line 41 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml"
                                      Write(news.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span>");
#nullable restore
#line 42 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml"
                         Write(news.PublishDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n\r\n                </div>\r\n                <p class=\"card-text\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1a45558d0743e7a6ecd32b736b736d37006fd220877", async() => {
                WriteLiteral("Read More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml"
                                              WriteLiteral(news.NewsId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            \r\n        </div>\r\n");
#nullable restore
#line 53 "C:\Users\hp\source\C# project\web_frontend\Gazeta\Views\Home\Gener.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Gazeta.Models.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
