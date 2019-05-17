#pragma checksum "Z:\AProyecto\Alex\MVC\AGCS\AGCS\Views\Backend\ABMClientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5864df35f3e248bfd7faef494c41dd9eb4e90eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Backend_ABMClientes), @"mvc.1.0.view", @"/Views/Backend/ABMClientes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Backend/ABMClientes.cshtml", typeof(AspNetCore.Views_Backend_ABMClientes))]
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
#line 1 "Z:\AProyecto\Alex\MVC\AGCS\AGCS\Views\_ViewImports.cshtml"
using AGCS;

#line default
#line hidden
#line 2 "Z:\AProyecto\Alex\MVC\AGCS\AGCS\Views\_ViewImports.cshtml"
using AGCS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5864df35f3e248bfd7faef494c41dd9eb4e90eb", @"/Views/Backend/ABMClientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ed169cc9a14496388f19dc1ff8e92e5b7f2185", @"/Views/_ViewImports.cshtml")]
    public class Views_Backend_ABMClientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cbaa2daa6644dd0b14cc601edb36808", async() => {
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
            BeginContext(1490, 8031, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36094344c5c642d4a9fbe17d03d49039", async() => {
                BeginContext(1496, 8018, true);
                WriteLiteral(@"

    <div class=""content mt-3"">
        <div class=""animated fadeIn"">
            <div class=""card"">
                <div class=""card-header"">
                    <strong class=""card-title"">Clientes</strong>
                </div>
                <div class=""card-body"">
                    <input type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Buscar Cliente""
                           title=""Type in a name"">
                    <table id=""myTable"">
                        <tr class=""header"">
                            <th style=""width:20%;"">Apellido</th>
                            <th style=""width:20%;"">Nombre</th>
                            <th style=""width:15%;"">DNI/CUIT/CUIL</th>
                            <th style=""width:15%;"">Teléfono</th>
                            <th style=""width:30%;"">Email</th>
                        </tr>
                        <tr>
                            <td>Liu</td>
                            <td>Chino</td>
                      ");
                WriteLiteral(@"      <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Margossian</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Lombardi</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Arru</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
");
                WriteLiteral(@"                        </tr>
                        <tr>
                            <td>Caputo</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Bruno</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Gibaut</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Lerner</td>
                         ");
                WriteLiteral(@"   <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Kemensky</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Washi</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Ramos</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                 ");
                WriteLiteral(@"           <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Binker</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Macri</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>XD</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Jojo<");
                WriteLiteral(@"/td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Lisa Lisa</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Speedwagon</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Patricio Amigo Satanico Del Chino</td>
                            <td>Chino</td>
                            <td>43994080</td>");
                WriteLiteral(@"
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Gabo</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Saidman</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>
                        <tr>
                            <td>Santos</td>
                            <td>Chino</td>
                            <td>43994080</td>
                            <td>44325567</td>
                            <td>Chino@gmail.com</td>
                        </tr>");
                WriteLiteral(@"
                    </table>
                </div>
            </div>
        </div>
    </div>



    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo""
            crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1""
            crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM""
            crossorigin=""anonymous""></script>
");
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
            BeginContext(9521, 11, true);
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
