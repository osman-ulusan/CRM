#pragma checksum "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58f465c0316f6eec0d731080060d8734336ccb74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Satis_Edit), @"mvc.1.0.view", @"/Views/Satis/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Satis/Edit.cshtml", typeof(AspNetCore.Views_Satis_Edit))]
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
#line 1 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\_ViewImports.cshtml"
using MixCRM;

#line default
#line hidden
#line 2 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\_ViewImports.cshtml"
using MixCRM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58f465c0316f6eec0d731080060d8734336ccb74", @"/Views/Satis/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4d003a1e69c72c5ad002022581ea7097e0e5d14", @"/Views/_ViewImports.cshtml")]
    public class Views_Satis_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Satis>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
  
    ViewData["Title"] = ViewBag.ActionMode; ;

#line default
#line hidden
            BeginContext(68, 121, true);
            WriteLiteral("\r\n<div class=\"m-4\">\r\n    <div class=\"bg-success text-white p-4\">\r\n        <h2>Satış Ekle / Düzenle</h2>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(189, 3160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de336acdbbbc470fb84816a9a12b9462", async() => {
                BeginContext(244, 49, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"original.Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 293, "\"", 310, 1);
#line 11 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
WriteAttributeValue("", 301, Model.Id, 301, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(311, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 365, "\"", 388, 1);
#line 12 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
WriteAttributeValue("", 373, Model.SatisAdi, 373, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(389, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 443, "\"", 469, 1);
#line 13 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
WriteAttributeValue("", 451, Model.SatisTarihi, 451, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(470, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 524, "\"", 546, 1);
#line 14 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
WriteAttributeValue("", 532, Model.Musteri, 532, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(547, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 601, "\"", 624, 1);
#line 15 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
WriteAttributeValue("", 609, Model.Personel, 609, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(625, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 679, "\"", 698, 1);
#line 16 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
WriteAttributeValue("", 687, Model.Urun, 687, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(699, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 753, "\"", 778, 1);
#line 17 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
WriteAttributeValue("", 761, Model.SatisAdeti, 761, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(779, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 833, "\"", 856, 1);
#line 18 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
WriteAttributeValue("", 841, Model.Aciklama, 841, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(857, 300, true);
                WriteLiteral(@" />


        <div class=""row"">
            <div class=""col-6"">
                <div class=""bg-primary text-white p-2 mt-3"">
                    Satış Bilgileri
                </div>
                <div class=""form-group"">
                    <label>Satış Adı</label>
                    ");
                EndContext();
                BeginContext(1157, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "de619e848287406d9c9d14d7ec478948", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 28 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SatisAdi);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1206, 137, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Satış Tarihi</label>\r\n                    ");
                EndContext();
                BeginContext(1343, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "af949faa65c349b9b004ca39febc41d1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 32 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SatisTarihi);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1395, 160, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Müşteri</label>\r\n                    <br />\r\n                    ");
                EndContext();
                BeginContext(1556, 141, false);
#line 37 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
               Write(Html.DropDownListFor(x => x.MusteriId, new SelectList(ViewBag.Musteriler, "Id", "Ad"), "Müşteri Seçiniz...", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1697, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(1774, 159, true);
                WriteLiteral("                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Personel</label>\r\n                    <br />\r\n                    ");
                EndContext();
                BeginContext(1934, 144, false);
#line 43 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
               Write(Html.DropDownListFor(x => x.PersonelId, new SelectList(ViewBag.Personeller, "Id", "Ad"), "Personel Seçiniz...", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2078, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2155, 155, true);
                WriteLiteral("                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Ürün</label>\r\n                    <br />\r\n                    ");
                EndContext();
                BeginContext(2311, 191, false);
#line 49 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
               Write(Html.DropDownListFor(x => x.UrunId, new SelectList(ViewBag.Urunler, "Id", "UrunAdi"), "Ürün Seçiniz...", new { @class = "form-control", @onChange = "SelectedValue(this)", @id = "SecilenId" }));

#line default
#line hidden
                EndContext();
                BeginContext(2502, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2579, 134, true);
                WriteLiteral("                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Satış Adedi</label>\r\n                    ");
                EndContext();
                BeginContext(2713, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "53df1c8fc6c14e138d32eb510b1810b3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 54 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SatisAdeti);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2764, 133, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Açıklama</label>\r\n                    ");
                EndContext();
                BeginContext(2897, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3761cad99653421b9abce2a7b290a71a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 58 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Aciklama);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2946, 117, true);
                WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label id=\"stok\"></label>\r\n");
                EndContext();
#line 63 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
                         foreach (var item in ViewBag.Stoklar)
                        {
                        }

#line default
#line hidden
                BeginContext(3181, 161, true);
                WriteLiteral("                    \r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <button type=\"submit\" class=\"btn btn-primary\">Kaydet</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Satis\Edit.cshtml"
           WriteLiteral(ViewBag.ActionMode);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3349, 396, true);
            WriteLiteral(@"
</div>
<script>

    //To get selected value an text of dropdownlist
    function SelectedValue(ddlObject) {
        //Selected value of dropdownlist
        var selectedValue = ddlObject.value;
        //Selected text of dropdownlist
        document.getElementById('stok').innerHTML = selectedValue;

        //alert popup with detail of seleceted value and text
    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Satis> Html { get; private set; }
    }
}
#pragma warning restore 1591