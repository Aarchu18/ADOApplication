#pragma checksum "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5deea4d1f3ba046682e949bbdb8fed382eeed402"
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
#line 1 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\_ViewImports.cshtml"
using ADOApplication;

#line default
#line hidden
#line 2 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\_ViewImports.cshtml"
using ADOApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5deea4d1f3ba046682e949bbdb8fed382eeed402", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c308d0e9e4b411907a57f547cc3338d079982140", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ADOModel.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Product/SearchProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "AddProduct";

#line default
#line hidden
            BeginContext(86, 37, true);
            WriteLiteral("\r\n<h4>products List</h4>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(124, 48, false);
#line 10 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\Index.cshtml"
Write(Html.ActionLink("Add New Product", "AddProduct"));

#line default
#line hidden
            EndContext();
            BeginContext(172, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
            BeginContext(180, 743, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce34b8cd2a64af9a76fe3871be60303", async() => {
                BeginContext(251, 201, true);
                WriteLiteral("\r\n\r\n    <input type=\"text\" name=\"SearchText\" class=\"form-control\" placeholder=\"Product Name\" />\r\n    <span>Search Category :</span>\r\n    <select name=\"ProductCategoryId\" class=\"form-control\">\r\n        ");
                EndContext();
                BeginContext(452, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ab73ed26ab34e52a7b5e9a0b3e06c79", async() => {
                    BeginContext(469, 6, true);
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
                BeginContext(484, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(494, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03cf78c774bf44a485438aad7c1dbb37", async() => {
                    BeginContext(512, 5, true);
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
                BeginContext(526, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(536, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03966c89d59149a08628925767047061", async() => {
                    BeginContext(554, 8, true);
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
                BeginContext(571, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(581, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37a06e43a644495c879c6d01d10b530f", async() => {
                    BeginContext(599, 10, true);
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
                BeginContext(618, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(628, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3bea3091e1d43bba15fa8ec5c547c11", async() => {
                    BeginContext(646, 5, true);
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
                BeginContext(660, 256, true);
                WriteLiteral(@"
    </select>
    <span>Price From :</span>
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
            BeginContext(923, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
#line 30 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(957, 421, true);
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
                Product CategoryId
            </th>
            <th>
                Date Created
            </th>
            <th></th>
        </tr>

");
            EndContext();
#line 52 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1427, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1488, 44, false);
#line 56 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(1532, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1600, 46, false);
#line 59 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1646, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1714, 47, false);
#line 62 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1761, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1829, 52, false);
#line 65 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductCategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(1881, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1949, 46, false);
#line 68 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(1995, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2063, 74, false);
#line 71 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\Index.cshtml"
               Write(Html.ActionLink("EditProduct", "EditProduct", new { id = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(2137, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2162, 78, false);
#line 72 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\Index.cshtml"
               Write(Html.ActionLink("DetailProduct", "DetailProduct", new { id = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(2240, 23, true);
            WriteLiteral("|\r\n                    ");
            EndContext();
            BeginContext(2264, 78, false);
#line 73 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\Index.cshtml"
               Write(Html.ActionLink("DeleteProduct", "DeleteProduct", new { id = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(2342, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 76 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2397, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
            EndContext();
#line 79 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\Index.cshtml"

}
else
{

#line default
#line hidden
            BeginContext(2427, 36, true);
            WriteLiteral("    <h3>No records were found</h3>\r\n");
            EndContext();
#line 84 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\ADOApplication\ADOApplication\Views\Product\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2466, 2, true);
            WriteLiteral("\r\n");
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
