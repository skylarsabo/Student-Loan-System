#pragma checksum "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b21e32ab7c1190b6dc0302e55a78a8b0a3639178"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StudentLoanSystem.Pages.UserPages.Pages_UserPages_LoanOfficerMainView), @"mvc.1.0.razor-page", @"/Pages/UserPages/LoanOfficerMainView.cshtml")]
namespace StudentLoanSystem.Pages.UserPages
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
#line 1 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\_ViewImports.cshtml"
using StudentLoanSystem;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b21e32ab7c1190b6dc0302e55a78a8b0a3639178", @"/Pages/UserPages/LoanOfficerMainView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e79b79a89d56235d416760a6fc2ef4a7f223da7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UserPages_LoanOfficerMainView : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
  
    ViewData["Title"] = "LoanOfficerMainView";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Loans For Review</h1>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b21e32ab7c1190b6dc0302e55a78a8b0a36391783753", async() => {
                WriteLiteral("\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 15 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Student ID"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 18 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("First Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 21 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Last Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 24 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Post Time"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 27 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Principle"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 30 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Interest Rate"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 33 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Start Date"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 36 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Length"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 39 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Approve"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n                <div class=\"form-check-inline\">\r\n");
#nullable restore
#line 45 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                      
                        var count = 0; 
                        foreach(var item in Model.unapproved)
                        {
                            //var approve = Model.AboutToApprove[item.Id - 1];

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 52 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.StudentId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 55 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 58 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 61 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.PostTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 64 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Principle));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 67 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Rate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 70 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Start));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 73 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Length));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <input type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 2996, "\"", 3039, 1);
#nullable restore
#line 76 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
WriteAttributeValue("", 3004, Model.unapproved[count].IsApproved, 3004, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"ApproveArray\" />\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 80 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                            count++;
                        }
                     

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n        <input type=\"submit\" value=\"submit\" />\r\n     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n        <h1>Approved Loans</h1>\r\n\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 95 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Student ID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 98 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("First Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 101 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Last Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 104 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Post Time"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 107 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Principle"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 110 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Interest Rate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 113 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Start Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 116 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Length"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 121 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                 foreach (var item in Model.approved)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 125 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 128 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 131 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 134 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PostTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 137 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Principle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 140 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 143 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 146 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Length));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 149 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n\r\n        <h1>Students</h1>\r\n\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 160 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Student ID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 163 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("First Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 166 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Last Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 169 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Credit Score"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 172 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Phone Number"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 175 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                   Write(Html.DisplayName("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 181 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                 foreach (var item in Model.StudentDatabase)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 185 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StudentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 188 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 191 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 194 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CreditScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 197 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 200 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 203 "C:\Users\ngran\source\repos\Student-Loan-System\Pages\UserPages\LoanOfficerMainView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentLoanSystem.Pages.UserPages.LoanOfficerMainViewModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentLoanSystem.Pages.UserPages.LoanOfficerMainViewModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentLoanSystem.Pages.UserPages.LoanOfficerMainViewModel>)PageContext?.ViewData;
        public StudentLoanSystem.Pages.UserPages.LoanOfficerMainViewModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
