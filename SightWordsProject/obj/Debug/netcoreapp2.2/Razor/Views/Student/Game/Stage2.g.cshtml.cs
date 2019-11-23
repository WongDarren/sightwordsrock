#pragma checksum "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/Student/Game/Stage2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d773265e882bd74530c8fd801d2007b928a8437a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Game_Stage2), @"mvc.1.0.view", @"/Views/Student/Game/Stage2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Game/Stage2.cshtml", typeof(AspNetCore.Views_Student_Game_Stage2))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d773265e882bd74530c8fd801d2007b928a8437a", @"/Views/Student/Game/Stage2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a60f5c74b5fb0ccb9da513ed896571003f7584a", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Game_Stage2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 297, true);
            WriteLiteral(@"<header>
  <h1>Matching Game</h1>
  <nav>
    <button id=""reset-game"">Reset Game</button>
  </nav>
</header>

<section class=""cards""></section>

<style>
* { box-sizing: border-box }

body {
  padding: 1em;
}

header {
  display: flex;
  justify-content: space-between;
  align-items: baseline;
}

");
            EndContext();
            BeginContext(298, 2017, true);
            WriteLiteral(@"@media (max-width: 400px) {
  header {
    flex-direction: column;
  }
}

button {
  padding: 0.8em;

  background-color: rgb(79, 201, 217);
  border: none;
  box-shadow: 0 1px 1px rgba(0, 0, 0, 0.5);
  color: white;
  outline: none;
  text-shadow: 0 1px 1px rgba(0, 0, 0, 0.5);
  
  transition: all 0.4s;
}

button:hover {
  background-color: rgb(60, 216, 238);
}

button:active {
  background-color: rgb(25, 136, 153);
  box-shadow: none;
  
  transform: translate(1px, 1px);
}

.cards {
  margin-top: 1em;
  
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  perspective: 800px;
}

.card {
  width: 150px;
  height: 200px;
  margin: 10px;
  position: relative;
  
  transition: transform 0.5s;
}

.card:nth-child(odd) {
  transform: rotate(3deg);
}

.card:nth-child(even) {
  transform: rotate(-3deg);
}

.card:nth-child(3n) {
  transform: rotate(1deg);
}

.card:nth-child(4n) {
  transform: rotate(1deg);
}

.card:nth-child(3n+1) {
  transform: rotate(-1deg);
}

.card:not(.matched):hover {
  transform: r");
            WriteLiteral(@"otate(0deg) scale(1.02);
}

.front, .back {
  width: 100%;
  height: 100%;
  
  position: absolute;
  top: 0;
  right: 0;
  
  box-shadow: 0 2px 2px rgba(0, 0, 0, 0.5);
  
  perspective: 800px;
  transition: transform 0.5s;
  transform-style: preserve-3d;
  backface-visibility: hidden;
}

.front {
  font-size: 4em;
  display: flex;
  justify-content: center;
  align-items: center;
  transform: rotateY(180deg);
  background-color: #b8f4fa;
  background-image: linear-gradient(left top, rgb(187, 241, 246), rgb(181, 247, 255));
}

.back {
  background-color: #29d6e8;
  background-image: url(""https://cdn.xl.thumbs.canstockphoto.com/cartoon-rock-with-face-clip-art-vector_csp14882164.jpg"");
}

.flipped .front {
  transform: rotateY(0deg);
}

.flipped .back {
  transform: rotateY(180deg);
}

.matched {
  opacity: 0.4;
}

.matched .front {
  transform: rotateY(0deg);
}

.matched .back {
  transform: rotateY(180deg);
}
</style>
<!-- Import underscore.js --> 
<script type=""text/javascript""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2315, "\"", 2375, 1);
#line 147 "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/Student/Game/Stage2.cshtml"
WriteAttributeValue("", 2321, Url.Content("https://underscorejs.org/underscore.js"), 2321, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2376, 1156, true);
            WriteLiteral(@"></script>

<script>

const $cards = $('.cards');
const cards = ['Hello','💩', '👹', '🙈', '⛄️', '🐰'];


function setupGame() {
  $cards.html('');
  const doubleCards = cards.concat(cards);
  
  _(doubleCards).shuffle().map(createCardElement).forEach(card => card.appendTo($cards));
}

function createCardElement(value) {
  return $(`
    <article class=""card ${value}"" data-value=${value}>
      <div class=""front"">${value}</div>
      <div class=""back""></div>
    </article>
  `);
}

const isFlipped = ($card) => $card.hasClass('flipped');
const flip = ($card) => $card.toggleClass('flipped');
const twoCardsAreFlipped = () => $('.flipped').length >= 2;
const cardsMatch = ([a, b]) => $(a).data('value') === $(b).data('value');

function checkForMatch($cards = $('.flipped')) {
  if (cardsMatch($cards)) { $cards.addClass('matched'); }
  setTimeout(() => $cards.removeClass('flipped'), 700);
}

$cards.on('click', '.card:not(.matched)', function () {
  const $card = $(this);

  flip($card);
  
  if (!isFlipped($card)) {");
            WriteLiteral(" return; }\n  if (twoCardsAreFlipped()) { checkForMatch(); }\n});\n\n$(\'#reset-game\').on(\'click\', setupGame);\n\nsetupGame();\n\n\n</script>\n");
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