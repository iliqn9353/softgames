#pragma checksum "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7271c42e98101337dd3437cace1b16493a3c5a4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_ById), @"mvc.1.0.view", @"/Views/Games/ById.cshtml")]
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
#line 1 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\_ViewImports.cshtml"
using SoftGamesShop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\_ViewImports.cshtml"
using SoftGamesShop.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\_ViewImports.cshtml"
using SoftGamesShop.Web.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7271c42e98101337dd3437cace1b16493a3c5a4f", @"/Views/Games/ById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9262a2bde2120653c4566c4d616dcc84154a3d1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_ById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SoftGamesShop.Web.ViewModels.Game.SingleGameViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("220"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("158"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("votesForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AddCommentForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
   this.ViewData["Title"] = Model.Name;


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7271c42e98101337dd3437cace1b16493a3c5a4f7047", async() => {
                WriteLiteral("\n    <style>\n        body {\n            background-image: url(\'https://cdn.wallpapersafari.com/82/19/F9ielj.jpg\');\n        }\r\n        #removeFavourite {\r\n            display: none;\r\n        }\n    </style>\n");
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
            WriteLiteral("\n");
#nullable restore
#line 14 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
 void DisplayComments(int? parentId)
{
    var comments = this.Model.Comments.Where(x => x.ParentId == parentId);
    if (!comments.Any())
    {
        return;
    }


#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
 foreach (var comment in comments)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid mt-100"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card border-primary"">
                <div class=""card-header"">
                    <div class=""media flex-wrap w-100 align-items-center"">
                        <img src=""/images/User/user.png"" class=""d-block ui-w-40 rounded-circle""");
            BeginWriteAttribute("alt", " alt=\"", 875, "\"", 881, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <div class=\"media-body ml-3\">\n                            ");
#nullable restore
#line 32 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                       Write(comment.UserUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <div class=\"text-muted small\">\n                                <i class=\"far fa-clock\"></i>\n                                <time");
            BeginWriteAttribute("datetime", " datetime=\"", 1145, "\"", 1188, 1);
#nullable restore
#line 35 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
WriteAttributeValue("", 1156, comment.CreatedOn.ToString("O"), 1156, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></time>\n\n                            </div>\n                        </div>\n                        <div class=\"text-muted small ml-3\">\n");
#nullable restore
#line 40 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                             if (this.User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"px-4 pt-3\"> <button type=\"button\" class=\"btn btn-secondary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1503, "\"", 1544, 3);
            WriteAttributeValue("", 1513, "showAddCommentForm(", 1513, 19, true);
#nullable restore
#line 42 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
WriteAttributeValue("", 1532, comment.Id, 1532, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1543, ")", 1543, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-reply\"></i>&nbsp; Reply</button> </div>");
#nullable restore
#line 42 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                                                                                                                                                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\n                    </div>\n                </div>\n                <div class=\"card-body\">\n                    <article>\n                        ");
#nullable restore
#line 48 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                   Write(Html.Raw(comment.SanitizedContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </article>\n");
#nullable restore
#line 50 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                       DisplayComments(comment.Id); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</div>");
#nullable restore
#line 55 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
        } 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""row"">
    <div class=""col-12 col-md-3 col-lg-2"" style=""padding-bottom:10px; text-align: center;"">
        <div class=""row"">
            <div class=""col"">
                <div class=""card border-primary"">

                    <a class=""fancybox-thumb"" data-fancybox=""cover"" data-caption=""Front Cover""");
            BeginWriteAttribute("href", " href=\"", 2293, "\"", 2315, 1);
#nullable restore
#line 65 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
WriteAttributeValue("", 2300, Model.ImageUrl, 2300, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7271c42e98101337dd3437cace1b16493a3c5a4f13869", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~");
#nullable restore
#line 66 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                       WriteLiteral(Model.ImageUrl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 69 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </a>\n\n                    <div class=\"card-body\">\n\n");
#nullable restore
#line 74 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"button\" id=\"1\" value=\"ONN\" style=\"color:blue\" onclick=\"javascript:toggle(this);\">\n");
            WriteLiteral("                    <button name=\"nameButton\" id=\"idButton\" title=\"your title\" class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2904, "\"", 3021, 5);
            WriteAttributeValue("", 2914, "location.href=\'", 2914, 15, true);
#nullable restore
#line 80 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
WriteAttributeValue("", 2929, Url.Action( "AddToCollection","UserCollection", new {  gameId = Model.Id }), 2929, 76, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3005, "\';", 3005, 2, true);
            WriteAttributeValue(" ", 3007, "return", 3008, 7, true);
            WriteAttributeValue(" ", 3014, "false;", 3015, 7, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-heart\"></i>Add To Collection</button>");
#nullable restore
#line 80 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                                                                                                                                                                                                                                                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    </div>\n                    <div class=\"card-body\">\n\n                        <p>Platform: ");
#nullable restore
#line 86 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                                Write(Model.PlatformsType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                        <p>Developer(s): ");
#nullable restore
#line 88 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                                    Write(Model.Developer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <p>ReleaseDate: ");
#nullable restore
#line 89 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                                   Write(Model.ReleaseDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p>Players: ");
#nullable restore
#line 90 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                               Write(Model.PlayersCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p>Co-op:");
#nullable restore
#line 91 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                                   var isAttachmentA = (Model.CoOp ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 91 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                                                                                Write(Html.DisplayFor(modelItem => isAttachmentA));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n    <div class=\"text-muted small ml-3\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7271c42e98101337dd3437cace1b16493a3c5a4f20439", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <div>\n            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3777, "\"", 3812, 4);
            WriteAttributeValue("", 3787, "sendVote(", 3787, 9, true);
#nullable restore
#line 101 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
WriteAttributeValue("", 3796, Model.Id, 3796, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3805, ",", 3805, 1, true);
            WriteAttributeValue(" ", 3806, "true)", 3807, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\n                <i class=\"fa fa-thumbs-up\"></i>\n            </a>\n        </div>\n        <div id=\"votesCount\">");
#nullable restore
#line 105 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                        Write(Model.VotesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div>\n            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3985, "\"", 4021, 4);
            WriteAttributeValue("", 3995, "sendVote(", 3995, 9, true);
#nullable restore
#line 107 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
WriteAttributeValue("", 4004, Model.Id, 4004, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4013, ",", 4013, 1, true);
            WriteAttributeValue(" ", 4014, "false)", 4015, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">
                <i class=""fa fa-thumbs-down""></i>
            </a>
        </div>
    </div>


    <div class=""col-12 col-md-9 col-lg-8"">
        <div class=""row"" style=""padding-bottom:10px"">
            <div class=""col"">
                <div class=""card border-primary"">
                    <div class=""card-header"">
                        <h1>");
#nullable restore
#line 119 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                        <p>Added by: ");
#nullable restore
#line 120 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                                Write(Model.CreatedByEmail.Split('@')[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                    <div class=\"card-body\">\n\n                        <p class=\"game-overview\">\n                            ");
#nullable restore
#line 125 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </p>\n");
#nullable restore
#line 127 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                         if (Model.Trailer.Contains('&'))
                            Model.Trailer = Model.Trailer.Split('&')[0];

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"text-center\">Trailer</p>\n                        <div class=\"embed-responsive embed-responsive-16by9\">\n                            <iframe class=\"embed-responsive-item\"");
            BeginWriteAttribute("src", " src=\"", 4995, "\"", 5044, 1);
#nullable restore
#line 131 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
WriteAttributeValue("", 5001, Model.Trailer.Replace("watch?v=","embed/"), 5001, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></iframe>\n                        </div>\n\n                        <p>ESRB Rating: ");
#nullable restore
#line 134 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                                   Write(Model.RatingName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                        <p>Genre: ");
#nullable restore
#line 136 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                             Write(Model.GenresName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                    </div>
                </div>
            </div>
        </div>

    </div>
</div>
<script src=""/lib/tinymce/tinymce.min.js"" type=""text/javascript""></script>
<script type=""text/javascript"">
    tinymce.init({
        selector: ""textarea"",
        plugins: [""image paste table link code media""]
    });
</script>
<div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7271c42e98101337dd3437cace1b16493a3c5a4f27053", async() => {
                WriteLiteral("\n        <input type=\"hidden\" name=\"GameId\"");
                BeginWriteAttribute("value", " value=\"", 5701, "\"", 5723, 1);
#nullable restore
#line 154 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
WriteAttributeValue("", 5709, this.Model.Id, 5709, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
        <input type=""hidden"" name=""ParentId"" value=""0"" />
        <div>
            <label for=""Content""></label>
            <textarea name=""Content"" id=""Content"" class=""form-control""></textarea>
        </div>
        <div>
            <input type=""submit"" class=""btn btn-primary"" value=""Add comment"" />
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n\n\n\n\n<article>\n    ");
#nullable restore
#line 171 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
Write(Html.Raw(Model.SanitizedContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</article>\n\n");
#nullable restore
#line 174 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
 if (this.User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"px-4 pt-3\"> <button type=\"button\" class=\"btn btn-primary float-right\" onclick=\"showAddCommentForm(0)\"><i class=\"fa fa-comment\"></i>&nbsp; Comment</button> </div>\n                <div class=\"clearfix\"></div>");
#nullable restore
#line 177 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 178 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
   DisplayComments(null); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function showAddCommentForm(parentId) {
            $(""#AddCommentForm input[name='ParentId']"").val(parentId);
            $(""#AddCommentForm"").show();
            $([document.documentElement, document.body]).animate({
                scrollTop: $(""#AddCommentForm"").offset().top
            }, 1000);
        }

        function sendVote(gameId, isUpVote) {
            var token = $(""#votesForm input[name=__RequestVerificationToken]"").val();
            var json = { gameId: gameId, isUpVote: isUpVote };
            $.ajax({
                url: ""/api/votes"",
                type: ""POST"",
                data: JSON.stringify(json),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                headers: { 'X-CSRF-TOKEN': token },
                success: function (data) {
                    $(""#votesCount"").html(data.votesCounter);
                }
            });
        }
        function toggle(button) {
            switch (button.valu");
                WriteLiteral("e) {\n                case \"ONN\":\n                    button.href =  ");
#nullable restore
#line 212 "C:\Users\Ico\Desktop\SoftGamesShop-newest-down-main-main-main\Web\SoftGamesShop.Web\Views\Games\ById.cshtml"
                              Write(Url.Action("AddToCollection", "UserCollection", new { gameId = Model.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("; return false;\n                    break;\n                case \"OFF\":\n                    button.value = \"ONN\";\n                    break;\n            }\n        }\n\n\n\n    </script>\n  \n");
            }
            );
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SoftGamesShop.Web.ViewModels.Game.SingleGameViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
