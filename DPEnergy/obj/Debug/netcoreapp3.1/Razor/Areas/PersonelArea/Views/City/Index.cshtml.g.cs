#pragma checksum "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\PersonelArea\Views\City\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14ecce7cc2eccf5a78e49e510740a55208b721cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PersonelArea_Views_City_Index), @"mvc.1.0.view", @"/Areas/PersonelArea/Views/City/Index.cshtml")]
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
#line 1 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\PersonelArea\Views\_ViewImports.cshtml"
using DPEnergy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\PersonelArea\Views\_ViewImports.cshtml"
using DPEnergy.DataModelLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\PersonelArea\Views\_ViewImports.cshtml"
using DPEnergy.DataModelLayer.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\PersonelArea\Views\City\Index.cshtml"
using DPEnergy.CommonLayer.PublicClass;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14ecce7cc2eccf5a78e49e510740a55208b721cd", @"/Areas/PersonelArea/Views/City/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579f56c00dc340a553c0771e4a33f48a1764dd93", @"/Areas/PersonelArea/Views/_ViewImports.cshtml")]
    public class Areas_PersonelArea_Views_City_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DPEnergy.DataModelLayer.Entities.P_City>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn customGreen1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "City", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCityPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/modal/modal.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\PersonelArea\Views\City\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"content\">\r\n\r\n        <ul class=\"breadcrumb\">\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14ecce7cc2eccf5a78e49e510740a55208b721cd7147", async() => {
                WriteLiteral("<i class=\"icon-home2 position-left\"></i> صفحه اصلی");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
            <li><a href=""#""><i class=""position-left""></i> اطلاعات اولیه</a></li>
            <li class=""active"">لیست شهرها</li>
        </ul>
        <div class=""panel panel-heading"" style=""box-shadow:3px 1px 1px 0 gray; border-radius:2px;"">
            <span style=""font-weight:bold;"">
                <i class=""glyphicon glyphicon-list""></i>
                لیست شهر ها
            </span>
        </div>
        <div style=""margin-bottom:5px;"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14ecce7cc2eccf5a78e49e510740a55208b721cd9044", async() => {
                WriteLiteral("\r\n                <i class=\"glyphicon glyphicon-plus\"></i>\r\n                افزودن شهر جدید\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <div>
            <div class=""k-rtl"">
                <div id=""grid""></div>
            </div>
        </div>

     
        <div class=""modal fade"" id=""myModaldeletor"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14ecce7cc2eccf5a78e49e510740a55208b721cd10915", async() => {
                WriteLiteral(@"
                        <div class=""modal-header"" style=""background-color:darkred; color:white; border-radius:5px 5px 0 0;"" dir=""rtl"">
                            <h4 class=""modal-title"">حذف شهر</h4>
                        </div>

                        <div class=""modal-body"" id=""DeleteModalBody"">

                        </div>

                        <div dir=""rtl"" class=""modal-footer"" style=""text-align:left;"">
                            <button class=""btn btn-default"" type=""button"" style=""width:80px;"" data-dismiss=""modal"" >بازگشت</button>
                            <button type=""submit"" class=""btn"" style=""width:80px; color:white; background-color:darkred;"">
                                تایید
                            </button>
                        </div>

                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n       \r\n        \r\n\r\n\r\n        ");
#nullable restore
#line 63 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\PersonelArea\Views\City\Index.cshtml"
   Write(Html.Partial("_Modal", new BootstrapModel { ID = "modal-action", Size = BootstrapModel.ModalSize.Large }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("PersonelScripts", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14ecce7cc2eccf5a78e49e510740a55208b721cd14186", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <script>\r\n\r\n        $(document).ready(function () {\r\n           var myobj = \'");
#nullable restore
#line 70 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\PersonelArea\Views\City\Index.cshtml"
                   Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
           var dpjson = JSON.parse(myobj);

           console.log(myobj);
           console.log('-------------');
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
                columns: [{
                    field: ""id"",
                    title: ""id""
                }, {
                    field: ""cityName"",
                    title: ""شهر""
                },



                    {
                        command: [
                            {
                                name: ""del"",
                   ");
                WriteLiteral(@"             text: ""حذف"",
                                click: function (e) {
                                    // command button click handler
                                   var item = this.dataItem($(e.currentTarget).closest(""tr""));
                                    url = ""/PersonelArea/City/DeleteCity"";
                                    $.ajax({
                                        url: url,
                                        data: { id : item.id},
                                        type: 'Get',
                                        success: function (result) {
                                            $('#DeleteModalBody').html(result);
                                            $(""#myModaldeletor"").modal(""show"");
                                        },
                                        error: function (xhr, status) {
                                            alert(status);
                                        }
                                  ");
                WriteLiteral(@"  });
                                    //$('#partial').load(route);

                                }
                            },

                            {
                                name: ""edit"",
                                text: ""ویرایش"",
                                click: function (e) {
                                    // command button click handler
                                    var item = this.dataItem($(e.currentTarget).closest(""tr""));
                                    window.location.href = '");
#nullable restore
#line 135 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\PersonelArea\Views\City\Index.cshtml"
                                                       Write(Url.Action("EditCity", "City"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/' + item.id;

                                }
                            },

                        ]
                    }
                ]
              //  edit: function (e) { alert(""adsadasdas""); }
            });
            var grid = $(""#grid"").data(""kendoGrid"");
            grid.hideColumn(""id"");
        });


            </script>
        ");
            }
            );
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DPEnergy.DataModelLayer.Entities.P_City>> Html { get; private set; }
    }
}
#pragma warning restore 1591
