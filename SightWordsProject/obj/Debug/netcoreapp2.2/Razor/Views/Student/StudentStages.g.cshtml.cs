#pragma checksum "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/Student/StudentStages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "848418256447d70c7df46b248da3d89ef8314106"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_StudentStages), @"mvc.1.0.view", @"/Views/Student/StudentStages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/StudentStages.cshtml", typeof(AspNetCore.Views_Student_StudentStages))]
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
#line 1 "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/_ViewImports.cshtml"
using SightWordsProject;

#line default
#line hidden
#line 2 "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/_ViewImports.cshtml"
using SightWordsProject.Models;

#line default
#line hidden
#line 3 "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/_ViewImports.cshtml"
using SightWordsProject.ViewModels;

#line default
#line hidden
#line 4 "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"848418256447d70c7df46b248da3d89ef8314106", @"/Views/Student/StudentStages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a60f5c74b5fb0ccb9da513ed896571003f7584a", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_StudentStages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Module>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StudentDashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Stage1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/Student/StudentStages.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(57, 2131, true);
            WriteLiteral(@"<!--
<section id=""cover"">
      <div id=""cover-caption"">
        <div id=""container"" class=""container"">
            <div class=""row"">
                    <div class=""col-sm-5 col-sm-push-5"" style=""background: color 222;"">.
                            <div class=""list-group"">
                                    <a onclick=""selectStage1()"" class=""list-group-item list-group-item-action"">Stage 1</a>
                                    <a onclick=""selectStage2()"" class=""list-group-item list-group-item-action"">Stage 2</a>
                                    <a onclick=""selectStage3()"" class=""list-group-item list-group-item-action"">Stage 3</a>
                                    <a onclick=""selectStage4()"" class=""list-group-item list-group-item-action"">Stage 4</a>
                                </div>
                            </div>
                    <div class=""col-sm-5 col-sm-pull-5"" style=""background-color:222;""><font color=""white""> 
                        <h3>Please Select your Stage
                     ");
            WriteLiteral(@"   <h4 id=""stageinfo""> </h4>
                        </h3></font>
                    </div>
            </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  <script>
    // to manipulate DOM under 'stageinfo' 
    function selectStage1(){
      document.getElementById(""stageinfo"").innerHTML = ""Stage 1"";
    }
    function selectStage2(){
      document.getElementById(""stageinfo"").innerHTML = ""Stage 2"";
    }
    function selectStage3(){
      document.getElementById(""stageinfo"").innerHTML = ""Stage 3"";
    }
    function selectStage4(){
      document.getElementById(""stageinfo"").innerHTML = ""Stage 4"";
    }
  </script>
  -->


<div class=""container"" style=""margin-top: 30px;"">
  <div class=""d-flex justify-content-between"">
      <div>
         <h1>My Dashboard</h1>
      </div>
      <div>
         <a href=""""><h4>Sign out</h4></a>
      </div>
  </div>
  <br>
  <div class=""row"">
    <div class=""col-md-4 text-center"">
      <img src=""https://via.placeholder.com/300x300"" alt=""C");
            WriteLiteral("ard image cap\">\n    </div>\n    <div class=\"col-md-4 text-center\">\n      <h3>Module ");
            EndContext();
            BeginContext(2189, 18, false);
#line 63 "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/Student/StudentStages.cshtml"
            Write(Model.moduleNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2207, 274, true);
            WriteLiteral(@"</h3>
      <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt 
        ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation
        ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
      ");
            EndContext();
            BeginContext(2481, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "848418256447d70c7df46b248da3d89ef83141069160", async() => {
                BeginContext(2582, 7, true);
                WriteLiteral("Go back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2593, 141, true);
            WriteLiteral("\n    </div>\n    <div class=\"col-md-4 text-center\">\n      <h3>Select a Stage</h3>\n      <div class=\"list-group\" id=\"list-tab\" role=\"tablist\">\n");
            EndContext();
#line 72 "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/Student/StudentStages.cshtml"
         for(int i = 0; i < 4; i++) {

#line default
#line hidden
            BeginContext(2772, 159, true);
            WriteLiteral("          <a class=\"list-group-item list-group-item-action d-flex justify-content-between align-items-center\" data-toggle=\"list\" role=\"tab\">\n            Stage ");
            EndContext();
            BeginContext(2933, 3, false);
#line 74 "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/Student/StudentStages.cshtml"
              Write(i+1);

#line default
#line hidden
            EndContext();
            BeginContext(2937, 157, true);
            WriteLiteral("\n            <span class=\"badge badge-primary badge-pill\">0/5 rounds</span>\n            <i class=\"fas fa-star\" style=\"color:orange;\">0/20</i>\n          </a>\n");
            EndContext();
#line 78 "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/Student/StudentStages.cshtml"
        }

#line default
#line hidden
            BeginContext(3104, 19, true);
            WriteLiteral("      </div>\n      ");
            EndContext();
            BeginContext(3123, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "848418256447d70c7df46b248da3d89ef831410612425", async() => {
                BeginContext(3286, 20, true);
                WriteLiteral("\n        Play\n      ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/Student/StudentStages.cshtml"
                                                                                                          WriteLiteral(Model.moduleNumber);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3310, 30, true);
            WriteLiteral(" \n    </div>\n  </div>\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Module> Html { get; private set; }
    }
}
#pragma warning restore 1591
