#pragma checksum "C:\Users\andal\OneDrive\Documents\Code\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\WebApplication3\WebApplication3\Views\Home\ViewPlayer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fccbd4c32f33ec664fc68938b21fd75afdc74015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewPlayer), @"mvc.1.0.view", @"/Views/Home/ViewPlayer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewPlayer.cshtml", typeof(AspNetCore.Views_Home_ViewPlayer))]
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
#line 1 "C:\Users\andal\OneDrive\Documents\Code\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#line 2 "C:\Users\andal\OneDrive\Documents\Code\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fccbd4c32f33ec664fc68938b21fd75afdc74015", @"/Views/Home/ViewPlayer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewPlayer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\andal\OneDrive\Documents\Code\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\WebApplication3\WebApplication3\Views\Home\ViewPlayer.cshtml"
  
    ViewData["Title"] = "ViewPlayer";

#line default
#line hidden
            BeginContext(48, 323, true);
            WriteLiteral(@"
<h2>ViewPlayer</h2>

<div id=""banner"">Player List</div>
<ul data-bind=""foreach: countries"">
    <li>
        <span data-bind=""text: name""></span>
        <ul data-bind=""foreach: players"">
            <li>
                <span data-bind=""text: name""></span>
            </li>
        </ul>
    </li>
</ul>

");
            EndContext();
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
