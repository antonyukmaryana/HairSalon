#pragma checksum "/Users/maryanaantonyuk/projects/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e73f316d7f4e55718ca2fa94d39f70ab3f72c3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Index), @"mvc.1.0.view", @"/Views/Clients/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Index.cshtml", typeof(AspNetCore.Views_Clients_Index))]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/maryanaantonyuk/projects/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
using HairSalon.Models;

#line default
#line hidden
#line 2 "/Users/maryanaantonyuk/projects/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
using System;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e73f316d7f4e55718ca2fa94d39f70ab3f72c3f", @"/Views/Clients/Index.cshtml")]
    public class Views_Clients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 19, true);
            WriteLiteral("\n<h1>Clients</h1>\n\n");
            EndContext();
#line 6 "/Users/maryanaantonyuk/projects/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(84, 23, true);
            WriteLiteral("  <h3>No clients.</h3>\n");
            EndContext();
#line 9 "/Users/maryanaantonyuk/projects/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
}

#line default
#line hidden
#line 10 "/Users/maryanaantonyuk/projects/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
 foreach(var client in Model)
{

#line default
#line hidden
            BeginContext(141, 15, true);
            WriteLiteral("  <ul>\n    <li>");
            EndContext();
            BeginContext(157, 14, false);
#line 13 "/Users/maryanaantonyuk/projects/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
   Write(client.GetInfo);

#line default
#line hidden
            EndContext();
            BeginContext(171, 14, true);
            WriteLiteral("</li>\n  </ul>\n");
            EndContext();
#line 15 "/Users/maryanaantonyuk/projects/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
}

#line default
#line hidden
            BeginContext(187, 5, true);
            WriteLiteral("<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 192, "\'", 256, 2);
            WriteAttributeValue("", 199, "clients/new?stylistId=", 199, 22, true);
#line 16 "/Users/maryanaantonyuk/projects/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
WriteAttributeValue("", 221, Context.Request.Query["stylistId"], 221, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(257, 70, true);
            WriteLiteral(">add a new clients</a></p>\n<p><a href=\'/\'>Return to Main Page</a></p>\n");
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