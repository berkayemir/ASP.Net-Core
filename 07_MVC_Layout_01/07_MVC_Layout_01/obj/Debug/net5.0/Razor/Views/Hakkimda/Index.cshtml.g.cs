#pragma checksum "C:\Users\Web ve Mobil Prog\Desktop\ASP.Net-Core\07_MVC_Layout_01\07_MVC_Layout_01\Views\Hakkimda\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2ad10a10350301d4867137dc627bd5485b45332"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hakkimda_Index), @"mvc.1.0.razor-page", @"/Views/Hakkimda/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2ad10a10350301d4867137dc627bd5485b45332", @"/Views/Hakkimda/Index.cshtml")]
    public class Views_Hakkimda_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Web ve Mobil Prog\Desktop\ASP.Net-Core\07_MVC_Layout_01\07_MVC_Layout_01\Views\Hakkimda\Index.cshtml"
  
    Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Web ve Mobil Prog\Desktop\ASP.Net-Core\07_MVC_Layout_01\07_MVC_Layout_01\Views\Hakkimda\Index.cshtml"
  
    Html.RenderPartial("header");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--Content Başlangıcı-->\r\n<section>\r\n    <p>HAKKIMDA</p>\r\n</section>\r\n<!--Content Bitişi-->\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Web ve Mobil Prog\Desktop\ASP.Net-Core\07_MVC_Layout_01\07_MVC_Layout_01\Views\Hakkimda\Index.cshtml"
   Html.RenderPartial("footer");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_Hakkimda_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Hakkimda_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Hakkimda_Index>)PageContext?.ViewData;
        public Views_Hakkimda_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
