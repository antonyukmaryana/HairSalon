#pragma checksum "/Users/maryanaantonyuk/projects/HairSalon.Solution/HairSalon/Views/Stylists/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2490c06ebe8305d293eed944dc93b05c9b1d2d98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_New), @"mvc.1.0.view", @"/Views/Stylists/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/New.cshtml", typeof(AspNetCore.Views_Stylists_New))]
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
#line 1 "/Users/maryanaantonyuk/projects/HairSalon.Solution/HairSalon/Views/Stylists/New.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2490c06ebe8305d293eed944dc93b05c9b1d2d98", @"/Views/Stylists/New.cshtml")]
    public class Views_Stylists_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 489, true);
            WriteLiteral(@"<h1> We are happy to welcome you at our Hair Salon</h1>
<h2>Please enter information.</h2>

<form action='/stylists/new' method='post'>

  <label for='stylistName'>Enter Stylist name:</label>
  <input id='stylistName' name='stylistName' type='text'>
  <label for='stylistDescription'>Enter Stylist desctiprion:</label>
  <input id='stylistDescription' name='StylistDescription' type='text'>

  <button type='submit'>Add stylist</button>
</form>

<p><a href='/'>Return to Main Page</a></p>
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
