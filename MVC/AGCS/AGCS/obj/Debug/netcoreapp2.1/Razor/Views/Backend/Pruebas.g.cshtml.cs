#pragma checksum "C:\Jony\Alex\MVC\AGCS\AGCS\Views\Backend\Pruebas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20788e829fcac1d1da7c0a66c030a57a9f067e97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Backend_Pruebas), @"mvc.1.0.view", @"/Views/Backend/Pruebas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Backend/Pruebas.cshtml", typeof(AspNetCore.Views_Backend_Pruebas))]
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
#line 1 "C:\Jony\Alex\MVC\AGCS\AGCS\Views\_ViewImports.cshtml"
using AGCS;

#line default
#line hidden
#line 2 "C:\Jony\Alex\MVC\AGCS\AGCS\Views\_ViewImports.cshtml"
using AGCS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20788e829fcac1d1da7c0a66c030a57a9f067e97", @"/Views/Backend/Pruebas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ed169cc9a14496388f19dc1ff8e92e5b7f2185", @"/Views/_ViewImports.cshtml")]
    public class Views_Backend_Pruebas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!doctype html>\r\n<html lang=\"es\">\r\n\r\n");
            EndContext();
            BeginContext(37, 1449, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b8b5003a98d46938690ee511937e443", async() => {
                BeginContext(43, 1436, true);
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T""
          crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""CSS/Index.css"">

    <title>AGCS</title>
    <style>
        * {
            box-sizing: border-box;
        }

        #myInput {
            background-image: url('/css/searchicon.png');
            background-position: 10px 10px;
            background-repeat: no-repeat;
            width: 100%;
            font-size: 16px;
            padding: 12px 20px 12px 40px;
            border: 1px solid #ddd;
            margin-bottom: 12px;
        }

        #myTable {
            border-collapse: collapse;
            width: 100%;
            border: 1p");
                WriteLiteral(@"x solid #ddd;
            font-size: 18px;
        }

            #myTable th, #myTable td {
                text-align: left;
                padding: 12px;
            }

            #myTable tr {
                border-bottom: 1px solid #ddd;
            }

                #myTable tr.header, #myTable tr:hover {
                    background-color: #f1f1f1;
                }
    </style>
");
                EndContext();
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
            EndContext();
            BeginContext(1486, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1490, 1220, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b9326775a14000b6afa021558aff12", async() => {
                BeginContext(1496, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1505, 21, false);
#line 55 "C:\Jony\Alex\MVC\AGCS\AGCS\Views\Backend\Pruebas.cshtml"
Write(ViewBag.ClientInfo.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1526, 19, true);
                WriteLiteral(";\r\n    <br />\r\n    ");
                EndContext();
                BeginContext(1546, 23, false);
#line 57 "C:\Jony\Alex\MVC\AGCS\AGCS\Views\Backend\Pruebas.cshtml"
Write(ViewBag.ClientInfo.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1569, 19, true);
                WriteLiteral(";\r\n    <br />\r\n    ");
                EndContext();
                BeginContext(1589, 26, false);
#line 59 "C:\Jony\Alex\MVC\AGCS\AGCS\Views\Backend\Pruebas.cshtml"
Write(ViewBag.ClientInfo.Surname);

#line default
#line hidden
                EndContext();
                BeginContext(1615, 19, true);
                WriteLiteral(";\r\n    <br />\r\n    ");
                EndContext();
                BeginContext(1635, 22, false);
#line 61 "C:\Jony\Alex\MVC\AGCS\AGCS\Views\Backend\Pruebas.cshtml"
Write(ViewBag.ClientInfo.Dni);

#line default
#line hidden
                EndContext();
                BeginContext(1657, 19, true);
                WriteLiteral(";\r\n    <br />\r\n    ");
                EndContext();
                BeginContext(1677, 24, false);
#line 63 "C:\Jony\Alex\MVC\AGCS\AGCS\Views\Backend\Pruebas.cshtml"
Write(ViewBag.ClientInfo.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1701, 19, true);
                WriteLiteral(";\r\n    <br />\r\n    ");
                EndContext();
                BeginContext(1721, 28, false);
#line 65 "C:\Jony\Alex\MVC\AGCS\AGCS\Views\Backend\Pruebas.cshtml"
Write(ViewBag.ClientInfo.Telephone);

#line default
#line hidden
                EndContext();
                BeginContext(1749, 377, true);
                WriteLiteral(@";


    <table id=""myTable"">
        <tr class=""header"">
            <th style=""width:20%;"">Apellido</th>
            <th style=""width:15%;"">Nombre</th>
            <th style=""width:15%;"">DNI/CUIT/CUIL</th>
            <th style=""width:10%;"">Celular</th>
            <th style=""width:25%;"">Email</th>
            <th style=""width:20%;"">Modificar</th>
        </tr>
");
                EndContext();
#line 77 "C:\Jony\Alex\MVC\AGCS\AGCS\Views\Backend\Pruebas.cshtml"
          
            for (int i = 0; i < ViewBag.Clients.Count; i++)
            {

#line default
#line hidden
                BeginContext(2214, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(2261, 26, false);
#line 81 "C:\Jony\Alex\MVC\AGCS\AGCS\Views\Backend\Pruebas.cshtml"
                   Write(ViewBag.Clients[i].Surname);

#line default
#line hidden
                EndContext();
                BeginContext(2287, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2319, 23, false);
#line 82 "C:\Jony\Alex\MVC\AGCS\AGCS\Views\Backend\Pruebas.cshtml"
                   Write(ViewBag.Clients[i].Name);

#line default
#line hidden
                EndContext();
                BeginContext(2342, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2374, 22, false);
#line 83 "C:\Jony\Alex\MVC\AGCS\AGCS\Views\Backend\Pruebas.cshtml"
                   Write(ViewBag.Clients[i].Dni);

#line default
#line hidden
                EndContext();
                BeginContext(2396, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2428, 28, false);
#line 84 "C:\Jony\Alex\MVC\AGCS\AGCS\Views\Backend\Pruebas.cshtml"
                   Write(ViewBag.Clients[i].Cellphone);

#line default
#line hidden
                EndContext();
                BeginContext(2456, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2488, 24, false);
#line 85 "C:\Jony\Alex\MVC\AGCS\AGCS\Views\Backend\Pruebas.cshtml"
                   Write(ViewBag.Clients[i].Email);

#line default
#line hidden
                EndContext();
                BeginContext(2512, 92, true);
                WriteLiteral("</td>\r\n                    <td><button type=\"button\" name=\"buttonId\" class=\"btn btn-primary\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2604, "\"", 2611, 1);
#line 86 "C:\Jony\Alex\MVC\AGCS\AGCS\Views\Backend\Pruebas.cshtml"
WriteAttributeValue("", 2609, i, 2609, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2612, 49, true);
                WriteLiteral(">Modificar</button></td>\r\n                </tr>\r\n");
                EndContext();
#line 88 "C:\Jony\Alex\MVC\AGCS\AGCS\Views\Backend\Pruebas.cshtml"
            }

        

#line default
#line hidden
                BeginContext(2689, 14, true);
                WriteLiteral("    </table>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2710, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
