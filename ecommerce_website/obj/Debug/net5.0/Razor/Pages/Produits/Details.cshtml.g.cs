#pragma checksum "C:\Users\ouiss\Desktop\ecommerce_website\ecommerce_website\ecommerce_website\Pages\Produits\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "58b19d2374bc22bac6c6c2dc20f6c1fb7da5a4911762bfa1883294a68a05b287"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ecommerce_website.Pages.Produits.Pages_Produits_Details), @"mvc.1.0.razor-page", @"/Pages/Produits/Details.cshtml")]
namespace ecommerce_website.Pages.Produits
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ouiss\Desktop\ecommerce_website\ecommerce_website\ecommerce_website\Pages\_ViewImports.cshtml"
using ecommerce_website

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"58b19d2374bc22bac6c6c2dc20f6c1fb7da5a4911762bfa1883294a68a05b287", @"/Pages/Produits/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1a60f7190bdef5493f984c54d268be00496f874da309c0363c3a62a671d1d477", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Pages_Produits_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ouiss\Desktop\ecommerce_website\ecommerce_website\ecommerce_website\Pages\Produits\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Details</h1>\r\n<section id=\"product1\" class=\"section-p1\">\r\n    <div class=\"pro-container\">\r\n        <div class=\"pro\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 246, "\"", 275, 1);
            WriteAttributeValue("", 252, 
#nullable restore
#line 12 "C:\Users\ouiss\Desktop\ecommerce_website\ecommerce_website\ecommerce_website\Pages\Produits\Details.cshtml"
                       Model.produit.imageUrl

#line default
#line hidden
#nullable disable
            , 252, 23, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 276, "\"", 307, 1);
            WriteAttributeValue("", 282, 
#nullable restore
#line 12 "C:\Users\ouiss\Desktop\ecommerce_website\ecommerce_website\ecommerce_website\Pages\Produits\Details.cshtml"
                                                     Model.produit.nomProduit

#line default
#line hidden
#nullable disable
            , 282, 25, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid product-img\" />\r\n            <div class=\"des\">\r\n                <span class=\"product-name\">");
            Write(
#nullable restore
#line 14 "C:\Users\ouiss\Desktop\ecommerce_website\ecommerce_website\ecommerce_website\Pages\Produits\Details.cshtml"
                                            Model.produit.nomProduit

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n                <h5 class=\"product-desc\">");
            Write(
#nullable restore
#line 15 "C:\Users\ouiss\Desktop\ecommerce_website\ecommerce_website\ecommerce_website\Pages\Produits\Details.cshtml"
                                          Model.produit.description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n\r\n                <div class=\"product-details\">\r\n                    <p><strong>Catégorie :</strong> ");
            Write(
#nullable restore
#line 18 "C:\Users\ouiss\Desktop\ecommerce_website\ecommerce_website\ecommerce_website\Pages\Produits\Details.cshtml"
                                                     Model.produit.categorie.nomCategorie

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                    <p><strong>Quantité en stock :</strong> ");
            Write(
#nullable restore
#line 19 "C:\Users\ouiss\Desktop\ecommerce_website\ecommerce_website\ecommerce_website\Pages\Produits\Details.cshtml"
                                                             Model.produit.qteStock

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</p>
                </div>

                <div class=""star"">
                    <i class=""fas fa-star""></i>
                    <i class=""fas fa-star""></i>
                    <i class=""fas fa-star""></i>
                    <i class=""fas fa-star""></i>
                    <i class=""fas fa-star""></i>
                </div>

                <h4 class=""product-price"">");
            Write(
#nullable restore
#line 30 "C:\Users\ouiss\Desktop\ecommerce_website\ecommerce_website\ecommerce_website\Pages\Produits\Details.cshtml"
                                           Model.produit.prixProduit

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" Dh</h4>\r\n            </div>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58b19d2374bc22bac6c6c2dc20f6c1fb7da5a4911762bfa1883294a68a05b2878154", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"ProductId\"");
                BeginWriteAttribute("value", " value=\"", 1307, "\"", 1332, 1);
                WriteAttributeValue("", 1315, 
#nullable restore
#line 34 "C:\Users\ouiss\Desktop\ecommerce_website\ecommerce_website\ecommerce_website\Pages\Produits\Details.cshtml"
                                                              Model.produit.id

#line default
#line hidden
#nullable disable
                , 1315, 17, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"ProductName\"");
                BeginWriteAttribute("value", " value=\"", 1393, "\"", 1426, 1);
                WriteAttributeValue("", 1401, 
#nullable restore
#line 35 "C:\Users\ouiss\Desktop\ecommerce_website\ecommerce_website\ecommerce_website\Pages\Produits\Details.cshtml"
                                                                Model.produit.nomProduit

#line default
#line hidden
#nullable disable
                , 1401, 25, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"Price\"");
                BeginWriteAttribute("value", " value=\"", 1481, "\"", 1515, 1);
                WriteAttributeValue("", 1489, 
#nullable restore
#line 36 "C:\Users\ouiss\Desktop\ecommerce_website\ecommerce_website\ecommerce_website\Pages\Produits\Details.cshtml"
                                                          Model.produit.prixProduit

#line default
#line hidden
#nullable disable
                , 1489, 26, false);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                <div class=\"input-group\">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 1592, "\"", 1624, 2);
                WriteAttributeValue("", 1598, "quantity-", 1598, 9, true);
                WriteAttributeValue("", 1607, 
#nullable restore
#line 39 "C:\Users\ouiss\Desktop\ecommerce_website\ecommerce_website\ecommerce_website\Pages\Produits\Details.cshtml"
                                          Model.produit.id

#line default
#line hidden
#nullable disable
                , 1607, 17, false);
                EndWriteAttribute();
                WriteLiteral(">Quantité :</label>\r\n                    <input type=\"number\" name=\"Quantity\"");
                BeginWriteAttribute("id", " id=\"", 1702, "\"", 1733, 2);
                WriteAttributeValue("", 1707, "quantity-", 1707, 9, true);
                WriteAttributeValue("", 1716, 
#nullable restore
#line 40 "C:\Users\ouiss\Desktop\ecommerce_website\ecommerce_website\ecommerce_website\Pages\Produits\Details.cshtml"
                                                                       Model.produit.id

#line default
#line hidden
#nullable disable
                , 1716, 17, false);
                EndWriteAttribute();
                WriteLiteral(" value=\"1\" min=\"1\"");
                BeginWriteAttribute("max", " max=\"", 1752, "\"", 1781, 1);
                WriteAttributeValue("", 1758, 
#nullable restore
#line 40 "C:\Users\ouiss\Desktop\ecommerce_website\ecommerce_website\ecommerce_website\Pages\Produits\Details.cshtml"
                                                                                                                 Model.produit.qteStock

#line default
#line hidden
#nullable disable
                , 1758, 23, false);
                EndWriteAttribute();
                WriteLiteral(" class=\"input-quantity\" />\r\n                </div>\r\n\r\n                <button type=\"submit\" class=\"cart\">\r\n                    <i class=\"fas fa-shopping-cart\"></i>\r\n                </button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58b19d2374bc22bac6c6c2dc20f6c1fb7da5a4911762bfa1883294a68a05b28713714", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ecommerce_website.Pages.Produits.DetailsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ecommerce_website.Pages.Produits.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ecommerce_website.Pages.Produits.DetailsModel>)PageContext?.ViewData;
        public ecommerce_website.Pages.Produits.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591