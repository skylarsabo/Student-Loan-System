#pragma checksum "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "563e4f0e8e6d6b7d9015d1d91afee767c1c87c3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StudentLoanSystem.Pages.UserPages.Pages_UserPages_StudentView), @"mvc.1.0.razor-page", @"/Pages/UserPages/StudentView.cshtml")]
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
#line 1 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\_ViewImports.cshtml"
using StudentLoanSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{handler?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"563e4f0e8e6d6b7d9015d1d91afee767c1c87c3a", @"/Pages/UserPages/StudentView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e79b79a89d56235d416760a6fc2ef4a7f223da7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UserPages_StudentView : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "SelectLoan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "SelectCurrent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "SelectApplied", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
  
    ViewData["Title"] = "Student";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "563e4f0e8e6d6b7d9015d1d91afee767c1c87c3a6755", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "563e4f0e8e6d6b7d9015d1d91afee767c1c87c3a7786", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-10\">\r\n                <h2>\r\n                    Hi ");
#nullable restore
#line 75 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                  Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.FirstName, StudentLoanSystem.Data.AccountData.CurrentStudent.FirstName, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 75 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                                                                                                                                                                        Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.LastName, StudentLoanSystem.Data.AccountData.CurrentStudent.LastName, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" welcome back!
                </h2>
                <div class=""row"">
                    <div class=""col-md-4"">
                        <!--Profile Information-->
                        <div class=""card"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">Profile Information for</h5>
                                <h6 class=""card-subtitle mb-2 text-muted"">");
#nullable restore
#line 83 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                                                     Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.FirstName, StudentLoanSystem.Data.AccountData.CurrentStudent.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 83 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                                                                                                                                                                                           Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.LastName, StudentLoanSystem.Data.AccountData.CurrentStudent.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                <p class=\"card-text\">\r\n                                    Username: ");
#nullable restore
#line 85 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                         Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.Username, StudentLoanSystem.Data.AccountData.CurrentStudent.Username, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                                    UserType: ");
#nullable restore
#line 86 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                         Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.Id.ToString(), StudentLoanSystem.Data.AccountData.CurrentStudent.Id.ToString(), new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                                    Credit Score: ");
#nullable restore
#line 87 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                             Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.creditScore.ToString(), StudentLoanSystem.Data.AccountData.CurrentStudent.creditScore.ToString(), new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                                    Student ID: ");
#nullable restore
#line 88 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                           Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.StudentID.ToString(), StudentLoanSystem.Data.AccountData.CurrentStudent.StudentID.ToString(), new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                                    Student Email: ");
#nullable restore
#line 89 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                              Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.email, StudentLoanSystem.Data.AccountData.CurrentStudent.email, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" <br />
                                </p>
                            </div>
                        </div>
                        <br />
                        <!--Apply for Loans-->
                        <div class=""card"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">Apply for loan?</h5>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "563e4f0e8e6d6b7d9015d1d91afee767c1c87c3a13841", async() => {
                    WriteLiteral("\r\n                                    <div class=\"input-group\">\r\n                                        ");
#nullable restore
#line 100 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                   Write(Html.DropDownList(StudentLoanSystem.Data.AccountData.LoanListItems.ToString(), StudentLoanSystem.Data.AccountData.LoanListItems, "Loans Available", new { @class = "form-control", @onChange = "ApplyForLoan(this)" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"<br />
                                        <span class=""input-group-btn"">
                                            <Button class=""input-group-addon btn btn-default"">Apply For Loan</Button>
                                        </span>
                                        <input type=""hidden"" name=""selectedLoanValue"" id=""selectedLoanValue"" runat=""server"" />
                                        <script>
                                            function ApplyForLoan(ddlObject) {
                                                var selectedValue = ddlObject.value;
                                                var selectedText = ddlObject.options[ddlObject.selectedIndex].innerHTML;
                                                var hiddenField = document.getElementById('selectedLoanValue');
                                                hiddenField.value = selectedValue;
                                            }
                                        </script>
               ");
                    WriteLiteral("                     </div>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                    <div class=""col-md-6"">
                        <!--Loan Student Already Has-->
                        <div class=""card"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">Loans Currently</h5>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "563e4f0e8e6d6b7d9015d1d91afee767c1c87c3a17810", async() => {
                    WriteLiteral("\r\n                                    <div class=\"input-group\">\r\n                                        ");
#nullable restore
#line 125 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                   Write(Html.DropDownList(StudentLoanSystem.Data.AccountData.CurrentStudentLoanItems.ToString(), StudentLoanSystem.Data.AccountData.CurrentStudentLoanItems, "Your Loans", new { @class = "form-control", @onChange = "CurrentLoanListSelectedValue(this)" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"<br />
                                        <span class=""input-group-btn"">
                                            <Button class=""input-group-addon btn btn-default"">See Loan Details</Button>
                                        </span>
                                        <input type=""hidden"" name=""selectedCurrentLoan"" id=""selectedCurrentLoan"" runat=""server"" />
                                        <script>
                                            function CurrentLoanListSelectedValue(ddlObject) {
                                                var selectedIndex = ddlObject.selectedIndex
                                                var hiddenField = document.getElementById('selectedCurrentLoan');
                                                hiddenField.value = selectedIndex;
                                            }
                                        </script>
                                    </div>
                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <br />\r\n                                <div class=\"card\">\r\n                                    <div class=\"card-body\">\r\n                                        ");
#nullable restore
#line 142 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                   Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.currentStudentLoans[j].loanName, StudentLoanSystem.Data.AccountData.CurrentStudent.currentStudentLoans[j].loanName, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                                        Principle: ");
#nullable restore
#line 143 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                              Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.currentStudentLoans[j].principle.ToString(), StudentLoanSystem.Data.AccountData.CurrentStudent.currentStudentLoans[j].principle.ToString(), new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                                        Start Date: ");
#nullable restore
#line 144 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                               Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.currentStudentLoans[j].start.ToString(), StudentLoanSystem.Data.AccountData.CurrentStudent.currentStudentLoans[j].start.ToString(), new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                                        Date Posted: ");
#nullable restore
#line 145 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                                Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.currentStudentLoans[j].postTime.ToString(), StudentLoanSystem.Data.AccountData.CurrentStudent.currentStudentLoans[j].postTime.ToString(), new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" <br />
                                        Pay Amount / Due Date: <br />
                                    </div>
                                </div>
                                <br />
                                <button type=""button"" class=""btn btn-success"">Pay Loan</button>

                            </div>
                        </div>
                        <br />
                        <!--Loan applied for-->
                        <div class=""card"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">Loan Applying for</h5>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "563e4f0e8e6d6b7d9015d1d91afee767c1c87c3a24425", async() => {
                    WriteLiteral("\r\n                                    <div class=\"input-group\">\r\n                                        ");
#nullable restore
#line 161 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                   Write(Html.DropDownList(StudentLoanSystem.Data.AccountData.ApplyLoanListItems.ToString(), StudentLoanSystem.Data.AccountData.ApplyLoanListItems, "Your Loans", new { @class = "form-control", @onChange = "LoanListSelectedValue(this)" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"<br />
                                        <span class=""input-group-btn"">
                                            <Button class=""input-group-addon btn btn-default"">See Loan Details</Button>
                                        </span>
                                        <input type=""hidden"" name=""selectedAppliedforLoan"" id=""selectedAppliedforLoan"" runat=""server"" />
                                        <script>
                                            function LoanListSelectedValue(ddlObject) {
                                                var selectedIndex = ddlObject.selectedIndex
                                                var hiddenField = document.getElementById('selectedAppliedforLoan');
                                                hiddenField.value = selectedIndex;
                                            }
                                        </script>
                                    </div>
                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <br />\r\n                                <div class=\"card\">\r\n                                    <div class=\"card-body\">\r\n                                        ");
#nullable restore
#line 178 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                   Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.ApplyForLoansList[i].loanName, StudentLoanSystem.Data.AccountData.CurrentStudent.ApplyForLoansList[i].loanName, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                                        Principle: ");
#nullable restore
#line 179 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                              Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.ApplyForLoansList[i].principle.ToString(), StudentLoanSystem.Data.AccountData.CurrentStudent.ApplyForLoansList[i].principle.ToString(), new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                                        Start Date: ");
#nullable restore
#line 180 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                               Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.ApplyForLoansList[i].start.ToString(), StudentLoanSystem.Data.AccountData.CurrentStudent.ApplyForLoansList[i].start.ToString(), new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                                        Date Posted: ");
#nullable restore
#line 181 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                                Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.ApplyForLoansList[i].postTime.ToString(), StudentLoanSystem.Data.AccountData.CurrentStudent.ApplyForLoansList[i].postTime.ToString(), new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                                        Approved? [1=yes,0=no]: ");
#nullable restore
#line 182 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
                                                           Write(Html.Label(StudentLoanSystem.Data.AccountData.CurrentStudent.ApplyForLoansList[i].approved.ToString(), StudentLoanSystem.Data.AccountData.CurrentStudent.ApplyForLoansList[i].approved.ToString(), new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" <br />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-2"">
                <div class=""row"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "563e4f0e8e6d6b7d9015d1d91afee767c1c87c3a31283", async() => {
                    WriteLiteral("<button type=\"button\" class=\"btn btn-danger\">Logout?</button>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\skyla\Documents\Kettering\Spring 2021\CS 471\Lab\StudentLoanSystem\StudentLoanSystem\Pages\UserPages\StudentView.cshtml"
               
        int i = 0;
        int j = 0;
        public void OnGet(Data.Users.Student student)
        {
            //System.Diagnostics.Debug.WriteLine(student.Username);
            //DropDownList1.Items.Insert(0, new ListItem("Add New", ""));
            //@Html.DropDownList(StudentLoanSystem.Data.AccountData.)

        }
        public async Task OnPostSelectLoanAsync()
        {
            Data.Users.Student student = Data.AccountData.CurrentStudent;
            String selectedValue = Request.Form["selectedLoanValue"];
            List<Data.Loan> loanList = Data.AccountData.LoanList;
            Data.Loan tempLoan = new Data.Loan();

            foreach (Data.Loan loan in loanList)
            {
                if (loan.principle.ToString().Equals(selectedValue))
                {
                    tempLoan = loan;
                }
            }
            student.loanApplyingFor = tempLoan;
            Data.AccountData.ApplyForLoan(student);
            //System.Diagnostics.Debug.WriteLine("TEST " + student.FirstName + " " + student.loanApplyingFor.loanName);
        }
        public async Task OnPostSelectAppliedAsync()
        {
            Data.Users.Student student = Data.AccountData.CurrentStudent;
            String selectedValue = Request.Form["selectedAppliedforLoan"];
            try
            {
                i = Int32.Parse(selectedValue) - 1;
            }
            catch(Exception e)
            {

            }


        }
        public async Task OnPostSelectCurrentAsync()
        {
            Data.Users.Student student = Data.AccountData.CurrentStudent;
            String selectedValue = Request.Form["selectedCurrentLoan"];
            try
            {
                j = Int32.Parse(selectedValue) - 1;
            }
            catch (Exception e)
            {

            }
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentLoanSystem.Data.AccountData> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentLoanSystem.Data.AccountData> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentLoanSystem.Data.AccountData>)PageContext?.ViewData;
        public StudentLoanSystem.Data.AccountData Model => ViewData.Model;
    }
}
#pragma warning restore 1591
