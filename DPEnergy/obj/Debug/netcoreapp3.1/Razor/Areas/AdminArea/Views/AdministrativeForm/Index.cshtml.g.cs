#pragma checksum "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\AdminArea\Views\AdministrativeForm\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af865981bf474de10305453228fe97dfd16fdff0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_AdministrativeForm_Index), @"mvc.1.0.view", @"/Areas/AdminArea/Views/AdministrativeForm/Index.cshtml")]
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
#line 1 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\AdminArea\Views\_ViewImports.cshtml"
using DPEnergy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\AdminArea\Views\_ViewImports.cshtml"
using DPEnergy.DataModelLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\AdminArea\Views\AdministrativeForm\Index.cshtml"
using DPEnergy.CommonLayer.PublicClass;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af865981bf474de10305453228fe97dfd16fdff0", @"/Areas/AdminArea/Views/AdministrativeForm/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98c018f424486b0ff179ce3df326b42e33cc865e", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    public class Areas_AdminArea_Views_AdministrativeForm_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DPEnergy.DataModelLayer.Entities.Admin.A_AdministrativeForm>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn customGreen1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdministrativeForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddAdministrativeForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/modal/modal.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\AdminArea\Views\AdministrativeForm\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content\">\r\n\r\n    <nav aria-label=\"breadcrumb\">\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\"><a");
            BeginWriteAttribute("href", " href=\"", 298, "\"", 332, 1);
#nullable restore
#line 10 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\AdminArea\Views\AdministrativeForm\Index.cshtml"
WriteAttributeValue("", 305, Url.Action("Index","Home"), 305, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">خانه</a></li>
            <li class=""breadcrumb-item""><a href=""#"">عملیات</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page"">فرم های اداری</li>
        </ol>
    </nav>
    <div class=""panel panel-heading"" style=""box-shadow:3px 1px 1px 0 gray; border-radius:2px;"">
        <span style=""font-weight:bold;"">
            <i class=""glyphicon glyphicon-list""></i>
            لیست فرم های اداری
        </span>
    </div>
    <div style=""margin-bottom:5px;"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af865981bf474de10305453228fe97dfd16fdff07411", async() => {
                WriteLiteral("\r\n            <i class=\"glyphicon glyphicon-plus\"></i>\r\n            اضافه فرم اداری جدید\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>


    <div id=""dummyScrollWrapper"" style=""overflow-x: scroll; margin-right:17px; margin-left:2px;"">
        <div id=""dummyScroll"" style=""height: 20px;"">
        </div>
    </div>

    <div>
        <!--<div class=""table-responsive""></div> -->
        <div class=""k-rtl"">
            <div id=""grid""></div>
        </div>
    </div>

    <div class=""modal fade"" id=""myModaldeletor"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af865981bf474de10305453228fe97dfd16fdff09477", async() => {
                WriteLiteral(@"
                    <div class=""modal-header"" style=""background-color:darkred; color:white; border-radius:5px 5px 0 0;"">
                        <h4 class=""modal-title"">Delete User</h4>
                    </div>

                    <div class=""modal-body"" id=""DeleteModalBody"">

                    </div>

                    <div dir=""rtl"" class=""modal-footer"" style=""text-align:left;"">
                        <button class=""btn btn-default"" type=""button"" style=""width:80px;"" data-dismiss=""modal"">Reject</button>
                        <button type=""submit"" class=""btn"" style=""width:80px; color:white; background-color:darkred;"">
                            Accept
                        </button>
                    </div>

                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("AdminScripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af865981bf474de10305453228fe97dfd16fdff012280", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n           var myobj = \'");
#nullable restore
#line 71 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\AdminArea\Views\AdministrativeForm\Index.cshtml"
                   Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
            var dpjson = JSON.parse(myobj);
            console.log(dpjson);

            $(""#grid"").kendoGrid({
                dataSource: {
                    data: dpjson,
                    pageSize: 5
                },
                height: 550,
                filterable: true,
                groupable: true,
                sortable: true,
                toolbar: [""pdf"", ""search""],

                pageable: {
                    refresh: true,
                    pageSizes: true,
                    buttonCount: 5
                },
                dataBinding: function () {
                    record = (this.dataSource.page() - 1) * this.dataSource.pageSize();
                },
                columns:
                [
                     {
                         title: ""Item"",
                         template: ""#= ++record #"",
                          width: 50
                     },
                    {
                        field: ""administrativ");
                WriteLiteral(@"eFormID"",
                        title: ""AdministrativeFormID""
                    }, {
                        field: ""administrativeFormTitle"",
                        width: ""300px"",
                        title: ""AdministrativeFormTitle""
                    }, {
                        field: ""administrativeFormContent"",
                        width: ""500px"",
                        title: ""AdministrativeFormContent"",
                        template: function (dataItem) {
                            if (dataItem.administrativeFormContent.length >100) {
                                return dataItem.administrativeFormContent.substring(0,100 )+""(...ادامه دارد)"";
                            } else {
                                return dataItem.administrativeFormContent;
                            }
                        },
                    },

                     {
                        width : 200,
                        command: [
                            {
     ");
                WriteLiteral(@"                           name: ""del"",
                                text: ""حذف"",
                                width: 200,

                                click: function (e) {
                                    // command button click handler
                                    var item = this.dataItem($(e.currentTarget).closest(""tr""));
                                   
                                    url = ""/AdminArea/AdministrativeForm/DeleteAdministrativeForm"";
                                    $.ajax({
                                        url: url,
                                        data: { administrativeFormID: item.administrativeFormID },
                                        type: 'Get',
                                        success: function (result) {
                                            $('#DeleteModalBody').html(result);
                                            $(""#myModaldeletor"").modal(""show"");
                                        },
    ");
                WriteLiteral(@"                                    error: function (xhr, status) {
                                            alert(status);
                                        }
                                    });
                                }
                            },


                        ]
                    }

                ]



            });
            var grid = $(""#grid"").data(""kendoGrid"");
            //grid.hideColumn(""administrativeFormID"");

            //$(""#grid"").data(""kendoGrid"").wrapper.find("".k-grid-header-wrap"").off(""scroll.kendoGrid"");

        });


    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DPEnergy.DataModelLayer.Entities.Admin.A_AdministrativeForm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
