#pragma checksum "C:\Users\maksi\Desktop\Штучки\Проекты\Hakaton\InTouch2021\InTouch2021\InTouch2021\Views\FeedBackForm\feedBack.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ec8d4aae7d5ddfca725cadbb9abc36b3ddd9960"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FeedBackForm_feedBack), @"mvc.1.0.view", @"/Views/FeedBackForm/feedBack.cshtml")]
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
#line 1 "C:\Users\maksi\Desktop\Штучки\Проекты\Hakaton\InTouch2021\InTouch2021\InTouch2021\Views\_ViewImports.cshtml"
using InTouch2021;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maksi\Desktop\Штучки\Проекты\Hakaton\InTouch2021\InTouch2021\InTouch2021\Views\_ViewImports.cshtml"
using InTouch2021.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec8d4aae7d5ddfca725cadbb9abc36b3ddd9960", @"/Views/FeedBackForm/feedBack.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bedbc5d9591a2f9063b6b710dc5589d95277b8f0", @"/Views/_ViewImports.cshtml")]
    public class Views_FeedBackForm_feedBack : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\maksi\Desktop\Штучки\Проекты\Hakaton\InTouch2021\InTouch2021\InTouch2021\Views\FeedBackForm\feedBack.cshtml"
  
    ViewData["Title"] = "feedBack";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"display-3\">Обратная связь</h1>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec8d4aae7d5ddfca725cadbb9abc36b3ddd99604276", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n     \r\n        <input class=\"mdl-textfield__input\" type=\"text\" id=\"sample1\" placeholder=\"Ваше имя\">\r\n");
                WriteLiteral("\r\n        <input placeholder=\"Номер телефона\" class=\"mdl-textfield__input\" type=\"text\" pattern=\"\\+7\\s?[\\(]{0,1}9[0-9]{2}[\\)]{0,1}\\s?\\d{3}[-]{0,1}\\d{2}[-]{0,1}\\d{2}\" id=\"sample2\">\r\n");
                WriteLiteral("        <span class=\"mdl-textfield__error\">Некорректный ввод</span>\r\n\r\n        <input placeholder=\"email\" class=\"mdl-textfield__input\" type=\"email\" id=\"email\"");
                BeginWriteAttribute("pattern", " pattern=\"", 775, "\"", 827, 3);
                WriteAttributeValue("", 785, "[a-z0-9._%+-]+\\", 785, 15, true);
                WriteLiteral("@");
                WriteAttributeValue("", 802, "[a-z0-9.-]+\\.[a-z]{2,", 802, 21, true);
                WriteAttributeValue(" ", 823, "4}$", 824, 4, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("        <span class=\"mdl-textfield__error\">Некорректный ввод</span>\r\n\r\n        <textarea placeholder=\"Оставьте сообщение\" class=\"mdl-textfield__input\" type=\"text\" rows=\"3\" id=\"message_box\"></textarea>\r\n");
                WriteLiteral("        <button type=\"submit\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-button--colored\">\r\n           Отправить\r\n        </button>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
