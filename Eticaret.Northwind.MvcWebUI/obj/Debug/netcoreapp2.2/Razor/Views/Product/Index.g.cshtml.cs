#pragma checksum "C:\Users\Mahmud\source\repos\Eticaret\Eticaret.Northwind.MvcWebUI\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "845f3ab079e77c6118c3c72fc57d4c06231968d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"845f3ab079e77c6118c3c72fc57d4c06231968d9", @"/Views/Product/Index.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eticaret.Northwind.MvcWebUI.Models.ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Mahmud\source\repos\Eticaret\Eticaret.Northwind.MvcWebUI\Views\Product\Index.cshtml"
  
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(111, 162, true);
            WriteLiteral("\r\n<div>\r\n\r\n    <table>\r\n        <tr>\r\n            <td>Product Name</td>\r\n            <td>Unit Price</td>\r\n            <td>Units In Stock</td>\r\n\r\n        </tr>\r\n\r\n");
            EndContext();
#line 16 "C:\Users\Mahmud\source\repos\Eticaret\Eticaret.Northwind.MvcWebUI\Views\Product\Index.cshtml"
         foreach (var product in Model.Products)
        {

#line default
#line hidden
            BeginContext(334, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(373, 19, false);
#line 19 "C:\Users\Mahmud\source\repos\Eticaret\Eticaret.Northwind.MvcWebUI\Views\Product\Index.cshtml"
               Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(392, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(420, 17, false);
#line 20 "C:\Users\Mahmud\source\repos\Eticaret\Eticaret.Northwind.MvcWebUI\Views\Product\Index.cshtml"
               Write(product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(437, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(465, 20, false);
#line 21 "C:\Users\Mahmud\source\repos\Eticaret\Eticaret.Northwind.MvcWebUI\Views\Product\Index.cshtml"
               Write(product.UnitsInStock);

#line default
#line hidden
            EndContext();
            BeginContext(485, 28, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 24 "C:\Users\Mahmud\source\repos\Eticaret\Eticaret.Northwind.MvcWebUI\Views\Product\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(524, 28, true);
            WriteLiteral("\r\n\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eticaret.Northwind.MvcWebUI.Models.ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591