#pragma checksum "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\ProjectBudget\_deleteProjectBudget.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "589b4f37b9bee084f5c7537e8506ede1eec9320d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DMSArea_Views_ProjectBudget__deleteProjectBudget), @"mvc.1.0.view", @"/Areas/DMSArea/Views/ProjectBudget/_deleteProjectBudget.cshtml")]
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
#line 1 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\_ViewImports.cshtml"
using DPEnergy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\_ViewImports.cshtml"
using DPEnergy.DataModelLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\_ViewImports.cshtml"
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"589b4f37b9bee084f5c7537e8506ede1eec9320d", @"/Areas/DMSArea/Views/ProjectBudget/_deleteProjectBudget.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1074cfed2314384a410d7a41fb59b4db07738e52", @"/Areas/DMSArea/Views/_ViewImports.cshtml")]
    public class Areas_DMSArea_Views_ProjectBudget__deleteProjectBudget : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DPEnergy.DataModelLayer.Entities.DMS.BasicInformation.D_ProjectBudget>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\ProjectBudget\_deleteProjectBudget.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"modal-body form-horizontal\">\r\n    Are you sure you want to delete budget for project\r\n    <span style=\"font-weight:bold;\">");
#nullable restore
#line 8 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\ProjectBudget\_deleteProjectBudget.cshtml"
                               Write(Model.ProjectCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    and deparment\r\n    <span style=\"font-weight:bold;\">");
#nullable restore
#line 10 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\ProjectBudget\_deleteProjectBudget.cshtml"
                               Write(Model.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    ?\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "589b4f37b9bee084f5c7537e8506ede1eec9320d5123", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 13 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\ProjectBudget\_deleteProjectBudget.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DPEnergy.DataModelLayer.Entities.DMS.BasicInformation.D_ProjectBudget> Html { get; private set; }
    }
}
#pragma warning restore 1591
