#pragma checksum "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\Transmittal\DeleteTransmittal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "949e9df500046d81cd708bf017785f9a9ac53f86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DMSArea_Views_Transmittal_DeleteTransmittal), @"mvc.1.0.view", @"/Areas/DMSArea/Views/Transmittal/DeleteTransmittal.cshtml")]
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
#nullable restore
#line 2 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\Transmittal\DeleteTransmittal.cshtml"
using DPEnergy.DataModelLayer.Entities.DMS;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"949e9df500046d81cd708bf017785f9a9ac53f86", @"/Areas/DMSArea/Views/Transmittal/DeleteTransmittal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1074cfed2314384a410d7a41fb59b4db07738e52", @"/Areas/DMSArea/Views/_ViewImports.cshtml")]
    public class Areas_DMSArea_Views_Transmittal_DeleteTransmittal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DPEnergy.DataModelLayer.ViewModels.DMS.D_RevisionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label col-md-2 col-xs-12 text-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:8px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("direction: ltr"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("projectfilter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("client-number"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control selectpicker custominput"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-live-search", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label col-md-3 col-xs-12 text-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("transfilter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transmittal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteTransmittal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\Transmittal\DeleteTransmittal.cshtml"
  
    ViewData["Title"] = "DeleteTransmittal";
    List<D_Project> ListProject = ViewBag.projectlist;
    List<D_Revision> ListTrans = ViewBag.translist;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content\">\r\n\r\n    <nav aria-label=\"breadcrumb\">\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\"><a");
            BeginWriteAttribute("href", " href=\"", 411, "\"", 445, 1);
#nullable restore
#line 13 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\Transmittal\DeleteTransmittal.cshtml"
WriteAttributeValue("", 418, Url.Action("Index","Home"), 418, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a></li>\r\n            <li class=\"breadcrumb-item\"><a");
            BeginWriteAttribute("href", " href=\"", 504, "\"", 548, 2);
#nullable restore
#line 14 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\Transmittal\DeleteTransmittal.cshtml"
WriteAttributeValue(" ", 511, Url.Action("Index", "Transmittal"), 512, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 547, "", 548, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Transmittal</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Add Transmittal</li>
        </ol>
    </nav>
    <div class=""panel panel-heading"" style=""box-shadow:3px 1px 1px 0 gray; border-radius:2px;"">
        <span style=""font-weight:bold;"">
            <i class=""glyphicon glyphicon-list""></i>
            Add New Transmittal
        </span>
    </div>


    <div class=""panel panel-body container-fluid"" style=""border-radius:2px; box-shadow:3px 1px 1px 0 gray; background-color:  #dae7f4 ;"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "949e9df500046d81cd708bf017785f9a9ac53f8611775", async() => {
                WriteLiteral(@"

            <div class=""row"">
                <div class=""panel-group"">
                    <div class=""panel panel-default"" style=""border: 2px solid #ccc; background-color: ;"">

                        <div class=""panel-body"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "949e9df500046d81cd708bf017785f9a9ac53f8612422", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 36 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\Transmittal\DeleteTransmittal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProjectCode);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <div class=\"col-md-10 col-xs-12\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "949e9df500046d81cd708bf017785f9a9ac53f8614267", async() => {
                    WriteLiteral("\r\n                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "949e9df500046d81cd708bf017785f9a9ac53f8614580", async() => {
                        WriteLiteral("Select ProjectCode");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 38 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\Transmittal\DeleteTransmittal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProjectCode);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 38 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\Transmittal\DeleteTransmittal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(from x in ListProject select new { Value = x.ProjectCode ,Text = x.ProjectCode + "-" + x.Title}, "Value","Text"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">Outgoing Transmittal Queue</div>
                        <div class=""panel-body"">
                            <div class=""row"">
                                <div class=""col-md-8"">
                                    <div class=""form-group"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "949e9df500046d81cd708bf017785f9a9ac53f8619924", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 52 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\Transmittal\DeleteTransmittal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TransmittalNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        <div class=\"col-md-9 col-xs-12\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "949e9df500046d81cd708bf017785f9a9ac53f8621695", async() => {
                    WriteLiteral("\r\n                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
#nullable restore
#line 54 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\Transmittal\DeleteTransmittal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TransmittalNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            <div>   </div>
                                        </div>


                                    </div>
                                </div>
                            </div>
                            <input type=""hidden"" name=""griddata"" id=""griddata"" />
                            <div id=""dummyScrollWrapper"" style=""overflow-x: scroll; margin-right:17px; margin-left:2px;"">
                                <div id=""dummyScroll""></div>
                            </div>
                            <div id=""grid""></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xs-12 form-group"" style=""margin-top:15px; text-align:right "">
                <input type=""submit"" name=""buttonId"" value=""Delete"" id=""btn1"" class=""btn btn-primary btn"" />
                <input type=""submit"" name=""buttonId"" value=""Cancle"" id=""btn2"" class=""btn btn-primary btn"" />

            </div>");
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("DMSScripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n       $(document).ready(function () {\r\n           var myobj = \'");
#nullable restore
#line 85 "C:\Users\hosseini.k\Desktop\Dpenergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\DPEnergy\Areas\DMSArea\Views\Transmittal\DeleteTransmittal.cshtml"
                   Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
           var dpjson = JSON.parse(myobj);
           console.log('model' , dpjson);

           var grid =  $(""#grid"").kendoGrid({
                dataSource: {
                    data: dpjson,
                    pageSize: 5
                },

                height: 550,
                filterable: true,
                groupable: true,
                reorderable: true,
                columnMenu: true,
                sortable: true,
                resizable: true,
                filterable: true,
                toolbar: [ ""search""],
                excel: {
                    allPages: true
                },
                pageable: {
                    refresh: true,
                    pageSizes: true,
                    buttonCount:5
                },
                height: 350,
                dataBound: function (e) {
                    var dataElement = $(e.sender.element).find("".k-grid-content"");
                    var fakeScroll = document.getElemen");
                WriteLiteral(@"tById(""dummyScroll"");
                    fakeScroll.style.width = dataElement.children(0).width() + ""px"";

                    dataElement.scroll(function () {
                        $(""#dummyScrollWrapper"").scrollLeft(dataElement.scrollLeft());
                    });
                    $(""#dummyScrollWrapper"").scroll(function () {
                        dataElement.scrollLeft($(""#dummyScrollWrapper"").scrollLeft());
                    });
                },
                columns: [
                
                {

                    field: ""clientNumber "",
                    width: 150,
                    title: ""Client Number ""
                }, {
                    field: ""revision"",
                    width: 150,
                    title: ""Revision""
                }, {
                    field: ""stageName"",
                    width: 150,
                    title: ""Stage Name""
                }, {
                    field: ""dpDicipline"",
                    ");
                WriteLiteral(@"width: 150,
                    title: ""Dp Dicipline""

                }, {
                     field: ""clientDicipline"",
                     width: 150,
                     title: ""Client Dicipline""

                },
                ]

           }).data(""kendoGrid"");

          // var panelHeight = $("".panel-body"").height();
          // $(""#grid"").height(panelHeight);
            grid.hideColumn(""id"");
           grid.hideColumn(""order"");


            //$(""#grid"").data(""kendoGrid"").wrapper.find("".k-grid-header-wrap"").off(""scroll.kendoGrid"");
           $(""#transfilter"").on(""change"", function () {
               var transnumber = $(""#transfilter"").val();

              
               // Use AJAX to retrieve the filtered data from the controller
               $.ajax({
                   url: ""/DMSArea/Transmittal/FilterTransGrid"",
                   data: { transnumber: transnumber },
                   dataType: ""json"",
                   success: function (filteredData)");
                WriteLiteral(@" {


                       grid.dataSource.data(filteredData);

                       // Update the total count of the data source
                       grid.dataSource.total(filteredData.length);

                       // Refresh the grid to display the first page of data
                       grid.refresh();
                   }
               });
        
           });
        });



    </script>
    <script>
        $(""#projectfilter"").on(""change"", function () {
            var projectcode = $(""#projectfilter"").val();
            $.ajax({
                url: ""/DMSArea/Transmittal/GetTransCombo"",
                data: { projectcode: projectcode },
                success: function (data) {
                    console.log(data);
                    $(""#transfilter"").empty();
                    $(""#transfilter"").append(""<option value='' selected disabled hidden>Select TransmittalNumber</option>"");
                    $.each(data, function (index, item) {
               ");
                WriteLiteral(@"         console.log(""item trans "", item.transnumber);
                        $(""#transfilter"").append(""<option value='"" + item.transnumber + ""'>"" + item.transnumber + ""</option>"");
                        console.log($(""#transfilter"").val());
                    });
                    $(""#transfilter"").selectpicker(""refresh"");
                },
                error: function () {
                    console.log('Error retrieving data');
                }
            })
        });
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DPEnergy.DataModelLayer.ViewModels.DMS.D_RevisionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
