#pragma checksum "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\SearchProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "713fecd4c16e6ef27c10aa050673e6e99d963439"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_SearchProduct), @"mvc.1.0.view", @"/Views/Product/SearchProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/SearchProduct.cshtml", typeof(AspNetCore.Views_Product_SearchProduct))]
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
#line 1 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\_ViewImports.cshtml"
using ADOApplication;

#line default
#line hidden
#line 2 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\_ViewImports.cshtml"
using ADOApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"713fecd4c16e6ef27c10aa050673e6e99d963439", @"/Views/Product/SearchProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c308d0e9e4b411907a57f547cc3338d079982140", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_SearchProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ADOModel.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("SearchProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\SearchProduct.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
            BeginContext(82, 36, true);
            WriteLiteral("\r\n<h4>Product List</h4>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(119, 48, false);
#line 10 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\SearchProduct.cshtml"
Write(Html.ActionLink("Add New Product", "AddProduct"));

#line default
#line hidden
            EndContext();
            BeginContext(167, 10, true);
            WriteLiteral("\r\n</p>\r\n\r\n");
            EndContext();
            BeginContext(177, 735, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98ff49fd6e3b450b9da23a4f8d1c1386", async() => {
                BeginContext(240, 201, true);
                WriteLiteral("\r\n\r\n    <input type=\"text\" name=\"SearchText\" class=\"form-control\" placeholder=\"Product Name\" />\r\n    <span>Search Category :</span>\r\n    <select name=\"ProductCategoryId\" class=\"form-control\">\r\n        ");
                EndContext();
                BeginContext(441, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2630fb725f82415cad19e7a7bae86238", async() => {
                    BeginContext(457, 6, true);
                    WriteLiteral("Select");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(472, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(482, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58143b8773044e46aed1a8c38af6e9af", async() => {
                    BeginContext(500, 5, true);
                    WriteLiteral("Dairy");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(514, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(524, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8807b6a0b40a475fb0e752e1bf377d0e", async() => {
                    BeginContext(542, 8, true);
                    WriteLiteral("Vehicles");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(559, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(569, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "455090ae6cfd4a1e9a177cd4a0b64f3f", async() => {
                    BeginContext(587, 10, true);
                    WriteLiteral("Electonics");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(606, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(616, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe6df7e1321144949be367cbd55565fc", async() => {
                    BeginContext(634, 5, true);
                    WriteLiteral("Books");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(648, 257, true);
                WriteLiteral(@"
    </select>
    <span>Cost Form :</span>
    <input type=""number"" name=""MinRange"" class=""form-control"" />
    <span> To </span>
    <input type=""number"" name=""MaxRange"" class=""form-control"" />
    <input type=""submit"" class=""btn btn-success"" />

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(912, 12, true);
            WriteLiteral("\r\n<br />\r\n\r\n");
            EndContext();
#line 33 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\SearchProduct.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(948, 348, true);
            WriteLiteral(@"    <table class=""table"">
        <tr>
            <th>
                Product Id
            </th>
            <th>
                Product Name
            </th>
            <th>
                Product Price
            </th>
            <th>
                Date Created
            </th>
            <th></th>
        </tr>

");
            EndContext();
#line 52 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\SearchProduct.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1345, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1406, 44, false);
#line 56 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\SearchProduct.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(1450, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1518, 46, false);
#line 59 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\SearchProduct.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1632, 47, false);
#line 62 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\SearchProduct.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1679, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1747, 46, false);
#line 65 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\SearchProduct.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(1793, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1861, 74, false);
#line 68 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\SearchProduct.cshtml"
               Write(Html.ActionLink("EditProduct", "EditProduct", new { id = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(1935, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1960, 78, false);
#line 69 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\SearchProduct.cshtml"
               Write(Html.ActionLink("DetailProduct", "DetailProduct", new { id = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(2038, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2063, 78, false);
#line 70 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\SearchProduct.cshtml"
               Write(Html.ActionLink("DeleteProduct", "DeleteProduct", new { id = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(2141, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 73 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\SearchProduct.cshtml"
        }

#line default
#line hidden
            BeginContext(2196, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
            EndContext();
#line 76 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\SearchProduct.cshtml"

}

else
{

#line default
#line hidden
            BeginContext(2228, 37, true);
            WriteLiteral("    <h3>No records where found</h3>\r\n");
            EndContext();
#line 82 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\SearchProduct.cshtml"
}

#line default
#line hidden
            BeginContext(2268, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ADOModel.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
