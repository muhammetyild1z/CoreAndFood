#pragma checksum "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\FoodEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4513473057e62caedd3a41f31b3f49651844860"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_FoodEkle), @"mvc.1.0.view", @"/Views/Food/FoodEkle.cshtml")]
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
#line 1 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\_ViewImports.cshtml"
using CoreAndFoot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\_ViewImports.cshtml"
using CoreAndFoot.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4513473057e62caedd3a41f31b3f49651844860", @"/Views/Food/FoodEkle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2404951fb3d3c24fc6ef8540fe126c299c7a950", @"/Views/_ViewImports.cshtml")]
    public class Views_Food_FoodEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFoot.Data.Models.UrunEkle>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Food", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FoodEkle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\FoodEkle.cshtml"
      
        ViewData["Title"] = "FoodEkle";
        Layout = "~/Views/Shared/_Layout_1.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>Ürün Ekle</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4513473057e62caedd3a41f31b3f496518448604925", async() => {
                WriteLiteral("\r\n   \r\n    <br />\r\n    <strong>Ürün Adı</strong>\r\n    ");
#nullable restore
#line 15 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\FoodEkle.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <strong>Fiyatı</strong>\r\n    ");
#nullable restore
#line 18 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\FoodEkle.cshtml"
Write(Html.TextBoxFor(x => x.price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <strong>Stok</strong>\r\n    ");
#nullable restore
#line 21 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\FoodEkle.cshtml"
Write(Html.TextBoxFor(x => x.Stock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <strong>Açıklama</strong>\r\n    ");
#nullable restore
#line 24 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\FoodEkle.cshtml"
Write(Html.TextAreaFor(x => x.ShortDesc, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <strong>Resim seçin</strong>\r\n    <input type=\"file\" name=\"ImageUrl\" />\r\n    <br />\r\n    <strong>Katagori</strong>\r\n    ");
#nullable restore
#line 30 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\FoodEkle.cshtml"
Write(Html.DropDownListFor(x => x.CatagoryID, (List<SelectListItem>)ViewBag.dgrr, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <br />\r\n    <button class=\"btn btn-primary\">\r\n        Ürün Ekle\r\n    </button>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFoot.Data.Models.UrunEkle> Html { get; private set; }
    }
}
#pragma warning restore 1591