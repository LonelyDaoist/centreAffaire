#pragma checksum "/home/LonelyDaoist/Documents/selfStudy/projects/CentreAffaire/Views/ChargeAffaire/ListCharge.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b17a0caa7ccf8690b597461e1a08a385f9622a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChargeAffaire_ListCharge), @"mvc.1.0.view", @"/Views/ChargeAffaire/ListCharge.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ChargeAffaire/ListCharge.cshtml", typeof(AspNetCore.Views_ChargeAffaire_ListCharge))]
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
#line 1 "/home/LonelyDaoist/Documents/selfStudy/projects/CentreAffaire/Views/_ViewImports.cshtml"
using CentreAffaire;

#line default
#line hidden
#line 2 "/home/LonelyDaoist/Documents/selfStudy/projects/CentreAffaire/Views/_ViewImports.cshtml"
using CentreAffaire.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b17a0caa7ccf8690b597461e1a08a385f9622a5", @"/Views/ChargeAffaire/ListCharge.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eab26b4fa991501cef75f7d059ec96106868bd5f", @"/Views/_ViewImports.cshtml")]
    public class Views_ChargeAffaire_ListCharge : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<CentreAffaire.Models.ChargeAffaire>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Ajouter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/LonelyDaoist/Documents/selfStudy/projects/CentreAffaire/Views/ChargeAffaire/ListCharge.cshtml"
  
    ViewBag.Title = "ListCharge";

#line default
#line hidden
            BeginContext(88, 951, true);
            WriteLiteral(@"<script src=""//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>

<link href=""https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css"" rel=""stylesheet"" />
<link href=""https://cdn.datatables.net/responsive/2.1.1/css/responsive.bootstrap.min.css"" rel=""stylesheet"" />

<script src=""https://cdn.datatables.net/1.10.15/js/jquery.dataTables.min.js""></script>
<script src=""https://cdn.datatables.net/1.10.15/js/dataTables.bootstrap4.min.js ""></script>
<table id=""demoGrid"" class=""table  table table-hover dt-responsive nowrap"" width=""100%"" cellspacing=""0"">

    <thead>
        <tr>
            <th class=""th-sm"">
                Matricule
            </th>
            <th class=""th-sm"">
                Intitulé
            </th>
            <th class=""th-sm"">
                Nombre de compte
            </th>
            <th class=""th-sm"">
                Action
            </th>
            

        </tr>
    </thead>
");
            EndContext();
#line 32 "/home/LonelyDaoist/Documents/selfStudy/projects/CentreAffaire/Views/ChargeAffaire/ListCharge.cshtml"
     foreach (var obj in Model)
    {

#line default
#line hidden
            BeginContext(1077, 21, true);
            WriteLiteral("    <tr>\n        <td>");
            EndContext();
            BeginContext(1099, 13, false);
#line 35 "/home/LonelyDaoist/Documents/selfStudy/projects/CentreAffaire/Views/ChargeAffaire/ListCharge.cshtml"
       Write(obj.matricule);

#line default
#line hidden
            EndContext();
            BeginContext(1112, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(1131, 12, false);
#line 36 "/home/LonelyDaoist/Documents/selfStudy/projects/CentreAffaire/Views/ChargeAffaire/ListCharge.cshtml"
       Write(obj.Intitule);

#line default
#line hidden
            EndContext();
            BeginContext(1143, 66, true);
            WriteLiteral("</td>\n        <td> 59</td>\n        <td>\n            <a id=\"detail\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1209, "\"", 1250, 3);
            WriteAttributeValue("", 1219, "update_url(\'consulter/", 1219, 22, true);
#line 39 "/home/LonelyDaoist/Documents/selfStudy/projects/CentreAffaire/Views/ChargeAffaire/ListCharge.cshtml"
WriteAttributeValue("", 1241, obj.id, 1241, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 1248, "\')", 1248, 2, true);
            EndWriteAttribute();
            BeginContext(1251, 229, true);
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#exampleModal\">consulter</a>\n            <br/>\n            <a id=\"interim\"  data-toggle=\"modal\" data-target=\"#interimeModal\">Ajouter un intérimaire</a>\n            <br/>\n            <a id=\"ajout\"");
            EndContext();
            BeginWriteAttribute("onclick", "  onclick=\"", 1480, "\"", 1512, 3);
            WriteAttributeValue("", 1491, "updateAction(", 1491, 13, true);
#line 43 "/home/LonelyDaoist/Documents/selfStudy/projects/CentreAffaire/Views/ChargeAffaire/ListCharge.cshtml"
WriteAttributeValue("", 1504, obj.id, 1504, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 1511, ")", 1511, 1, true);
            EndWriteAttribute();
            BeginContext(1513, 94, true);
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#ajoutModal\">Ajouter un compte</a>\n        </td> \n    </tr>\n");
            EndContext();
#line 46 "/home/LonelyDaoist/Documents/selfStudy/projects/CentreAffaire/Views/ChargeAffaire/ListCharge.cshtml"
    }

#line default
#line hidden
            BeginContext(1613, 2050, true);
            WriteLiteral(@"
</table>
<div class=""modal fade modalStyle"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">

                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"" onclick=""update_urlClose()"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h3 class=""modal-title"" id=""exampleModalLabel"">Liste des comptes du chargé <span id=""name""></span></h3>
            </div>
            <div class=""modal-body"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th scope=""col"">code agence</th>
                            <th scope=""col"">Numéro de compte</th>
                            <th scope=""col"">Intitulé</th>
                            <th scope=""col"">Intérimaire</th>
                  ");
            WriteLiteral(@"          <th scope=""col"">Action</th>
                        </tr>
                    </thead>
                    <tbody id=""rowHolder"">
                    </tbody>
                </table>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Retour</button>

            </div>
        </div>
    </div>
</div>

<div class=""modal fade modalStyle"" id=""ajoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""ajoutModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">

                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"" onclick=""update_urlClose()"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h3 class=""modal-title"" id=""ajoutModalLabel"">Ajouter un compte</h3>
            </div>
            <div class=""modal-body"">
              ");
            WriteLiteral("  ");
            EndContext();
            BeginContext(3663, 581, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b17a0caa7ccf8690b597461e1a08a385f9622a510182", async() => {
                BeginContext(3700, 537, true);
                WriteLiteral(@"
                    <label for=""codeAgence"">Code Agence</label>
                    <input type=""text"" id=""codeAgence"" name=""codeAgence""><br/>

                    <label for=""numCompte"">Numéro de Compte</label>
                    <input type=""text"" id=""numCompte"" name=""numCompte""><br/>

                    <label for=""intitule"">Intitule</label>
                    <input type=""text"" id=""intitule"" name=""intitule""><br/>
                    <input class=""btn btn-primary"" type=""submit"" value=""Ajouter"" onclick=""f()"">
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4244, 1951, true);
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Cancel</button>

            </div>
        </div>
    </div>
</div>


<script>

    $('#demoGrid').dataTable({
    });
</script>
<script>
    function getData() { 
        var pathArray = window.location.pathname.split('/');
        var secondLevelLocation = pathArray[3];
        
        $.ajax({
            
            url: ""/ChargeAffaire/consulter/"" + secondLevelLocation,
            method: 'post',
            dataType: 'json',
            error: (res) => console.log(res),
            success: function (csResponse) {

                //$(""#name"").text(csResponse[0].charge.intitule);

                let s = """";
                for (let i=0;i<csResponse.length;i++){
                            s += ""<tr>""
                            +""<td>""+csResponse[i].codeAgence+""</td>""
                            +""<td>""+csResponse[i].numeroCompte+""</td>""
                      ");
            WriteLiteral(@"      +""<td>""+csResponse[i].intitule+""</td>""
                            +""<td>""+csResponse[i].interimaire.intitule+""</td>""
                            +""<td>""
                                +""<a href='#'>Supprimer compte</a>""
                                +""<br/>""
                                + ""<a href='#'>Changer affectation</a>""
                            +""</td>"";
                            +""</tr>""
                }
                document.getElementById(""rowHolder"").innerHTML = s;
            }
        
            
        });
    }
    function update_url(url) {
        history.pushState(null, null, url);
        getData();
    }
    function update_urlClose()
    {
        history.pushState(null, null, ""/ChargeAffaire/ListCharge"");
    }
    $(""#exampleModal"").click(update_urlClose);
    function updateAction(id) {
        $(""form"").get(0).setAttribute(""action"",""Ajouter/""+id);
    }

</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<CentreAffaire.Models.ChargeAffaire>> Html { get; private set; }
    }
}
#pragma warning restore 1591