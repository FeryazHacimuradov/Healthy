#pragma checksum "/Users/faryaz/Desktop/One-HealthyV2.0/One-HealthyV2.0/Views/News/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e9023432a6e2c984a1bb57765965521b0975588"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
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
#line 1 "/Users/faryaz/Desktop/One-HealthyV2.0/One-HealthyV2.0/Views/_ViewImports.cshtml"
using One_HealthyV2._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/faryaz/Desktop/One-HealthyV2.0/One-HealthyV2.0/Views/_ViewImports.cshtml"
using One_HealthyV2._0.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/faryaz/Desktop/One-HealthyV2.0/One-HealthyV2.0/Views/_ViewImports.cshtml"
using One_HealthyV2._0.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e9023432a6e2c984a1bb57765965521b0975588", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98e33c2a5e1948aadb8f7b4ec15aef2ec5cfbf88", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "/Users/faryaz/Desktop/One-HealthyV2.0/One-HealthyV2.0/Views/News/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""page-banner overlay-dark bg-image"" style=""background-image: url(../assets/img/bg_image_1.jpg);"">
    <div class=""banner-section"">
        <div class=""container text-center wow fadeInUp"">
            <nav aria-label=""Breadcrumb"">
                <ol class=""breadcrumb breadcrumb-dark bg-transparent justify-content-center py-0 mb-2"">
                    <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">Blog</li>
                </ol>
            </nav>
            <h1 class=""font-weight-normal"">News</h1>
        </div> <!-- .container -->
    </div> <!-- .banner-section -->
</div> <!-- .page-banner -->

<div class=""page-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""row"">
                    <div class=""col-sm-6 py-3"">
                        <div class=""card-blog"">
                            <div class=""header"">
                   ");
            WriteLiteral(@"             <div class=""post-category"">
                                    <a href=""#"">Covid19</a>
                                </div>
                                <a href=""blog-details"" class=""post-thumb"">
                                    <img src=""../assets/img/blog/blog_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1357, "\"", 1363, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""body"">
                                <h5 class=""post-title""><a href=""blog-details.html"">List of Countries without Coronavirus case</a></h5>
                                <div class=""site-info"">
                                    <div class=""avatar mr-2"">
                                        <div class=""avatar-img"">
                                            <img src=""../assets/img/person/person_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1891, "\"", 1897, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <span>Roger Adams</span>
                                    </div>
                                    <span class=""mai-time""></span> 1 week ago
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""col-sm-6 py-3"">
                        <div class=""card-blog"">
                            <div class=""header"">
                                <div class=""post-category"">
                                    <a href=""#"">Dental</a>
                                </div>
                                <a href=""blog-details"" class=""post-thumb"">
                                    <img src=""../assets/img/blog/blog_3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2720, "\"", 2726, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""body"">
                                <h5 class=""post-title""><a href=""blog-details.html"">What is the impact of eating too much sugar?</a></h5>
                                <div class=""site-info"">
                                    <div class=""avatar mr-2"">
                                        <div class=""avatar-img"">
                                            <img src=""../assets/img/person/person_4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3256, "\"", 3262, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <span>Wizdom Jack</span>
                                    </div>
                                    <span class=""mai-time""></span> 2 weeks ago
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""col-sm-6 py-3"">
                        <div class=""card-blog"">
                            <div class=""header"">
                                <div class=""post-category"">
                                    <a href=""#"">Covid19</a>
                                </div>
                                <a href=""blog-details"" class=""post-thumb"">
                                    <img src=""../assets/img/blog/blog_3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4087, "\"", 4093, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""body"">
                                <h5 class=""post-title""><a href=""blog-details.html"">Shifting goalposts: Research in the time of the coronavirus</a></h5>
                                <div class=""site-info"">
                                    <div class=""avatar mr-2"">
                                        <div class=""avatar-img"">
                                            <img src=""../assets/img/person/person_3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4638, "\"", 4644, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <span>Adams Collier</span>
                                    </div>
                                    <span class=""mai-time""></span> 4 weeks ago
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6 py-3"">
                        <div class=""card-blog"">
                            <div class=""header"">
                                <div class=""post-category"">
                                    <a href=""#"">Neurology</a>
                                </div>
                                <a href=""blog-details"" class=""post-thumb"">
                                    <img src=""../assets/img/blog/blog_4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5472, "\"", 5478, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""body"">
                                <h5 class=""post-title""><a href=""blog-details.html"">What are the nonmedical factors most closely linked to death risk?</a></h5>
                                <div class=""site-info"">
                                    <div class=""avatar mr-2"">
                                        <div class=""avatar-img"">
                                            <img src=""../assets/img/person/person_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6030, "\"", 6036, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <span>Roger Adams</span>
                                    </div>
                                    <span class=""mai-time""></span> 4 weeks ago
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6 py-3"">
                        <div class=""card-blog"">
                            <div class=""header"">
                                <div class=""post-category"">
                                    <a href=""#"">Cardiology</a>
                                </div>
                                <a href=""blog-details"" class=""post-thumb"">
                                    <img src=""../assets/img/blog/blog_5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6863, "\"", 6869, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""body"">
                                <h5 class=""post-title""><a href=""blog-details.html"">Do gut bacteria contribute to ethnic health disparities</a></h5>
                                <div class=""site-info"">
                                    <div class=""avatar mr-2"">
                                        <div class=""avatar-img"">
                                            <img src=""../assets/img/person/person_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7410, "\"", 7416, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <span>Roger Adams</span>
                                    </div>
                                    <span class=""mai-time""></span> 4 weeks ago
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6 py-3"">
                        <div class=""card-blog"">
                            <div class=""header"">
                                <div class=""post-category"">
                                    <a href=""#"">Patient Services</a>
                                </div>
                                <a href=""blog-details"" class=""post-thumb"">
                                    <img src=""../assets/img/blog/blog_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8249, "\"", 8255, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""body"">
                                <h5 class=""post-title""><a href=""blog-details.html"">The Recovery Room: News beyond the pandemic</a></h5>
                                <div class=""site-info"">
                                    <div class=""avatar mr-2"">
                                        <div class=""avatar-img"">
                                            <img src=""../assets/img/person/person_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8784, "\"", 8790, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <span>Roger Adams</span>
                                    </div>
                                    <span class=""mai-time""></span> 1 month ago
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6 py-3"">
                        <div class=""card-blog"">
                            <div class=""header"">
                                <div class=""post-category"">
                                    <a href=""#"">General Health</a>
                                </div>
                                <a href=""blog-details"" class=""post-thumb"">
                                    <img src=""../assets/img/blog/blog_2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9621, "\"", 9627, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""body"">
                                <h5 class=""post-title""><a href=""blog-details.html"">Racism in mental healthcare: An invisible barrier</a></h5>
                                <div class=""site-info"">
                                    <div class=""avatar mr-2"">
                                        <div class=""avatar-img"">
                                            <img src=""../assets/img/person/person_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10162, "\"", 10168, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <span>Roger Adams</span>
                                    </div>
                                    <span class=""mai-time""></span> 2 months ago
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""col-sm-6 py-3"">
                        <div class=""card-blog"">
                            <div class=""header"">
                                <div class=""post-category"">
                                    <a href=""#"">Covid19</a>
                                </div>
                                <a href=""blog-details"" class=""post-thumb"">
                                    <img src=""../assets/img/blog/blog_2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10994, "\"", 11000, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""body"">
                                <h5 class=""post-title""><a href=""blog-details.html"">COVID-19 live updates: Total number of cases passes 11.6 million</a></h5>
                                <div class=""site-info"">
                                    <div class=""avatar mr-2"">
                                        <div class=""avatar-img"">
                                            <img src=""../assets/img/person/person_2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11550, "\"", 11556, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <span>Diego Simmons</span>
                                    </div>
                                    <span class=""mai-time""></span> 4 weeks ago
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""col-12 my-5"">
                        <nav aria-label=""Page Navigation"">
                            <ul class=""pagination justify-content-center"">
                                <li class=""page-item disabled"">
                                    <a class=""page-link"" href=""#"" tabindex=""-1"" aria-disabled=""true"">Previous</a>
                                </li>
                                <li class=""page-item active"" aria-current=""page"">
                                    <a class=""page-link"" href=""#"">1 <span class=""sr-only"">(current)</span></a>
                                </li>
                          ");
            WriteLiteral(@"      <li class=""page-item"">
                                    <a class=""page-link"" href=""#"">2</a>
                                </li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                                <li class=""page-item"">
                                    <a class=""page-link"" href=""#"">Next</a>
                                </li>
                            </ul>
                        </nav>
                    </div>
                </div> <!-- .row -->
            </div>
            <div class=""col-lg-4"">
                <div class=""sidebar"">
                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Search</h3>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e9023432a6e2c984a1bb57765965521b097558820002", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" placeholder=""Type a keyword and hit enter"">
                                <button type=""submit"" class=""btn""><span class=""icon mai-search""></span></button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Categories</h3>
                        <ul class=""categories"">
                            <li><a href=""#"">Food <span>12</span></a></li>
                            <li><a href=""#"">Dish <span>22</span></a></li>
                            <li><a href=""#"">Desserts <span>37</span></a></li>
                            <li><a href=""#"">Drinks <span>42</span></a></li>
                            <li><a href=""#"">Ocassion <span>14</span></a></li>
                        </ul>
                    </div>

                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Recent Blog</h3>
                        <div class=""blog-item"">
                            <a class=""post-thumb""");
            BeginWriteAttribute("href", " href=\"", 14564, "\"", 14571, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                <img src=\"../assets/img/blog/blog_1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 14646, "\"", 14652, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""content"">
                                <h5 class=""post-title""><a href=""#"">Even the all-powerful Pointing has no control</a></h5>
                                <div class=""meta"">
                                    <a href=""#""><span class=""mai-calendar""></span> July 12, 2018</a>
                                    <a href=""#""><span class=""mai-person""></span> Admin</a>
                                    <a href=""#""><span class=""mai-chatbubbles""></span> 19</a>
                                </div>
                            </div>
                        </div>
                        <div class=""blog-item"">
                            <a class=""post-thumb""");
            BeginWriteAttribute("href", " href=\"", 15398, "\"", 15405, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                <img src=\"../assets/img/blog/blog_2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 15480, "\"", 15486, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""content"">
                                <h5 class=""post-title""><a href=""#"">Even the all-powerful Pointing has no control</a></h5>
                                <div class=""meta"">
                                    <a href=""#""><span class=""mai-calendar""></span> July 12, 2018</a>
                                    <a href=""#""><span class=""mai-person""></span> Admin</a>
                                    <a href=""#""><span class=""mai-chatbubbles""></span> 19</a>
                                </div>
                            </div>
                        </div>
                        <div class=""blog-item"">
                            <a class=""post-thumb""");
            BeginWriteAttribute("href", " href=\"", 16232, "\"", 16239, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                <img src=\"../assets/img/blog/blog_3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 16314, "\"", 16320, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""content"">
                                <h5 class=""post-title""><a href=""#"">Even the all-powerful Pointing has no control</a></h5>
                                <div class=""meta"">
                                    <a href=""#""><span class=""mai-calendar""></span> July 12, 2018</a>
                                    <a href=""#""><span class=""mai-person""></span> Admin</a>
                                    <a href=""#""><span class=""mai-chatbubbles""></span> 19</a>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Tag Cloud</h3>
                        <div class=""tagcloud"">
                            <a href=""#"" class=""tag-cloud-link"">dish</a>
                            <a href=""#"" class=""tag-cloud-link"">menu</a>
                            <a href=""#"" clas");
            WriteLiteral(@"s=""tag-cloud-link"">food</a>
                            <a href=""#"" class=""tag-cloud-link"">sweet</a>
                            <a href=""#"" class=""tag-cloud-link"">tasty</a>
                            <a href=""#"" class=""tag-cloud-link"">delicious</a>
                            <a href=""#"" class=""tag-cloud-link"">desserts</a>
                            <a href=""#"" class=""tag-cloud-link"">drinks</a>
                        </div>
                    </div>

                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Paragraph</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ducimus itaque, autem necessitatibus voluptate quod mollitia delectus aut, sunt placeat nam vero culpa sapiente consectetur similique, inventore eos fugit cupiditate numquam!</p>
                    </div>
                </div>
            </div>
        </div> <!-- .row -->
    </div> <!-- .container -->
</div> <!-- .page-section -->");
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
