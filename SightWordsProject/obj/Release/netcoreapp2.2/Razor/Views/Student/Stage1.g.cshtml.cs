#pragma checksum "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/Student/Stage1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b79f838165916c41dea6241fa97082ebc4d8cd69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Stage1), @"mvc.1.0.view", @"/Views/Student/Stage1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Stage1.cshtml", typeof(AspNetCore.Views_Student_Stage1))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b79f838165916c41dea6241fa97082ebc4d8cd69", @"/Views/Student/Stage1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a60f5c74b5fb0ccb9da513ed896571003f7584a", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Stage1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Game>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:0 auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StudentDashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(19, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/Student/Stage1.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(62, 13, true);
            WriteLiteral("\n<style>\n    ");
            EndContext();
            BeginContext(76, 1561, true);
            WriteLiteral(@"@import url('https://fonts.googleapis.com/css?family=DM+Sans:400,500,700&display=swap');

* {
  box-sizing: border-box;
}

body {
  font-family: 'DM Sans', sans-serif;
  overflow: hidden;
}

.project {
  height: 120px;
  width: 120px;
  flex-shrink: 0;
  background-color: white;
  border-radius: 50%;
  border-style: solid;
  border-width: thick;
  user-select: none;
  cursor: pointer;

  position: relative;
  z-index: 1;
  transform-origin: center;
}

.project-img {
  object-fit: contain;
  display: block;
  user-select: none;
  pointer-events: none;
  width: 100%;
  height: 100%;
  border-radius: 50%;
  transition: .5s;
}

.header-project {
  position: fixed;
  top: 20px;
  height: 150px;
  user-select: none;
}

.header-project:hover {
  transform: scale(1.1);
}

.score-project {
  position: fixed;
  right: 10%;
  top: 20px;
  width: 200px;
  height: 90px;
  color: darken(#ddd, 15%);
  transition: .5s;
  text-align: center;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 15px;");
            WriteLiteral(@"
  font-weight: 500;
  padding: 10px;
  user-select: none;
}

#gameProgress {
  position: fixed;
  color: white;
  transition: .5s;
  text-align: left;
  display: flex;
  font-size: 40px;
  bottom: 1%;
  left: 1%;
}

.project-name {
  position: absolute;
  width: 140px;
  text-align: center;
  left: 50%;
  top: 100%;
  font-size: 14px;
  transition: .3s;
  font-weight: 500;
  color: rgba(0,0,0,.5);
  opacity: 0;
  visibility: hidden;
  pointer-events: none;
  transform: translateX(-50%) translateY(0) scale(.8);
  z-index: -1;
  
  ");
            EndContext();
            BeginContext(1638, 4645, true);
            WriteLiteral(@"@media (max-width: 768px) { display: none; }
}

.project:hover { z-index: 2; }

.project:hover > .project-name {
  opacity: 1;
  visibility: visible;
  transform: translateX(-50%) translateY(10px) scale(1);
}

.project.is-selected { z-index: 2; }
.project.is-selected > .project-img { box-shadow: 0 0 0 6px #1089ff; }

.showcase.is-dragging .project {
  pointer-events: none;
  transition: none;
}

.showcase.is-dragging .drop {
  border-color: #1089ff;
  color: #1089ff;
}

.drop {
  position: fixed;
  bottom: 20px;
  left: calc(50% - 45px);
  width: 150px;
  height: 150px;
  color: darken(#ddd, 15%);
  border-radius: 50%;
  transition: .5s;
  text-align: center;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 15px;
  font-weight: 500;
  user-select: none;
}

.drop.is-ready {
  transform: scale(1.3);
}


.drop.is-dropped {
  z-index: 3;
  color: #fff;
  font-size: 12px;
  width: 64px;
  height: 64px;
  left: calc(50% - 32px);
  cursor: pointer;
}

.project.is-expanded > .project-im");
            WriteLiteral(@"g { border-radius: 50%; }
.project.is-expanded > .project-name { display: none; }

.showcase {
  height: 100vh;
  overflow: hidden;
  justify-content: space-evenly;
  align-items: center;
  display: flex;
  background-image: url(""/img/evening.png"");
  background-position: center; /* Center the image */
  background-repeat: no-repeat; /* Do not repeat the image */
  background-size: cover; /* Resize the background image to cover the entire container */
}

/*
expanding css
.showcase.is-preview > .project {
  pointer-events: none;
  opacity: 0;
  width: 0;
  height: 0;
  margin: 0;
}

.showcase.is-preview > .project.is-expanded {
  opacity: 1;
  transition: .7s;
  z-index: 2;
  width: 50%;
  height: 50%;
  transform: none !important;
  z-index: 2;
}
*/


.centered {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  /*
  width: 100%;
  height: 50%;
  border-radius: 50%;
  display: block;
  */
  object-fit: cover;
  object-position: center;
  
  user-select: none;
  pointer-event");
            WriteLiteral(@"s: none;
  text-align: center;
  transition: .5s;

}

.speaker{
  height: 100%;
  cursor: pointer;
}

/* The Modal (background) A.K.A POP UP*/
.modal {
  display: none; /* Hidden by default */
  position: fixed; /* Stay in place */
  z-index: 1; /* Sit on top */
  padding-top: 100px; /* Location of the box */
  left: 0;
  top: 0;
  width: 100%; /* Full width */
  height: 100%; /* Full height */
  overflow: auto; /* Enable scroll if needed */
  background-color: rgb(0,0,0); /* Fallback color */
  background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
}

/* Modal Content */
.modal-content {
  background-color: #fefefe;
  margin: auto;
  padding: 20px;
  border: 1px solid #888;
  width: 80%;
}

.rockGrad {
  height: 100px;
}

/* The Close Button */
.close {
  color: #aaaaaa;
  float: right;
  font-size: 28px;
  font-weight: bold;
}

.close:hover,
.close:focus {
  color: #000;
  text-decoration: none;
  cursor: pointer;
}



</style>

<div class=""showcase"">
  <div class=""header-project"">
    <img class=""speake");
            WriteLiteral(@"r"" src=""/img/rockHappy.png"" onclick=window.speechSynthesis.speak(msg2)>
    

  </div>
  <div class=""score-project"">
    <h2 id=""myScore"">My Score: 0</h2>
  </div>
  <div style=""height: 200px;"" class=""score-project"">
    <h2 id=""myIncorrect"">Incorrect: 0</h2>
  </div>
  <div class=""project"">
    <img class=""project-img"">
      <div class=""centered""><h4 id = ""box1"">1st word</h4></div>
    <span class=""project-name"">Drag to the Basket!</span>
  </div>
  <div class=""project"">
    <img class=""project-img"">
      <div class=""centered""><h4 id = ""box2"">2nd word</h4></div>
    <span class=""project-name"">Drag to the Basket!</span>
  </div>
  <div class=""project"">
    <img class=""project-img"">
      <div class=""centered""><h4 id = ""box3"">3rd word</h4></div>
    <span class=""project-name"">Drag to the Basket!</span>
  </div>
  <div class=""project"">
    <img class=""project-img"">
      <div class=""centered""><h4 id = ""box4"">4th word</h4></div>
    <span class=""project-name"">Drag to the Basket!</span>
  </div>
  
  <div class");
            WriteLiteral(@"=""drop"">
    <img style=""height:100%"" src=""/img/basket.png"">
  </div>


  <div>
    <p id=""gameProgress"">Progress: 0/10</p>
  </div>
  <!-- The Modal -->
<div id=""myModal"" class=""modal"">

  <!-- Modal content -->
  <div class=""modal-content text-center"">
    <div class=""modal-header"" style=""margin:0 auto"">
      <h2>Congratulations!</h2>
    </div>
    <div class=""modal-body"">
      <img class=""rockGrad mb-2"" src=""/img/rockGrad.png"">
      <p>You made it!</p>
      <p id=""finalScore"">Score:</p>
    </div>
    <div class=""modal-footer"">

      ");
            EndContext();
            BeginContext(6283, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b79f838165916c41dea6241fa97082ebc4d8cd6912255", async() => {
                BeginContext(6401, 19, true);
                WriteLiteral("Return to Dashboard");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6424, 417, true);
            WriteLiteral(@"
    </div>
  </div>

</div>
  
</div>


<script>
var msg = new SpeechSynthesisUtterance('Hello World');
var msg2 = new SpeechSynthesisUtterance('I am a rock');

const projects = document.querySelectorAll("".project"");
const drop = document.querySelector("".drop"");
const showcase = document.querySelector("".showcase"");

// The array of words should be passed here
// j for array only
var x = 0;
var j = 0;
var model = ");
            EndContext();
            BeginContext(6842, 31, false);
#line 346 "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/Student/Stage1.cshtml"
       Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
            EndContext();
            BeginContext(6873, 5973, true);
            WriteLiteral(@";
var words = [];
for (i=0;i<model.length;i++) {
  words.push(model[i].words);
}
var tmpWords = words;
var answer;
shuffle(words);
wordGenerator();
// initial audio playback of current word
window.speechSynthesis.speak(msg2);

// wordGenerator() change words from id=box1 to box4
// i for graphical container
let progress = 0;
let score = 0;
let incorrect = 0;
let start,
  offsetY,
  offsetX,
  targetRect,
  target,
  dropped = false,
  expanded = false;

const stopped = () => {
  start = false;
  if (target) {
    showcase.classList.remove(""is-dragging"");
    target.classList.remove(""is-selected"");
    drop.classList.remove(""is-active"");
    drop.classList.remove(""is-ready"");
  }
  if (dropped) {
    //showcase.classList.add(""is-preview"");
    target.classList.add(""is-expanded"");
    drop.classList.add(""is-dropped"");
    expanded = true;

    console.log(getProjectName(target));
    console.log(""projectName"", getProjectName(target));
    console.log(answer);

    getProjectName(target) === answer ? score_f() :");
            WriteLiteral(@" incorrect_f();
    incrementProgress();
    wordGenerator();
    // initial audio playback of current word
    if(score + incorrect < 10){
      window.speechSynthesis.speak(msg2);
    }
  } else {
    drop.classList.remove(""is-dropped"");
    showcase.classList.remove(""is-preview"");
    target.classList.remove(""is-expanded"");
    expanded = false;
  }
};

const started = (e, type) => {
  start = true;
  target = e.target;
  if (type === ""touch"") {
    console.log(e.touches[0]);
    offsetY = target.offsetWidth / 2 + target.offsetTop;
    offsetX = target.offsetWidth / 2 + target.offsetLeft;
  } else {
    offsetY = e.offsetY + target.offsetTop;
    offsetX = e.offsetX + target.offsetLeft;
  }
  targetRect = target.getBoundingClientRect();
  target.classList.add(""is-selected"");
  showcase.classList.add(""is-dragging"");
};

projects.forEach(project => {
  project.addEventListener(""mousedown"", e => {
    started(e, ""mouse"");
  });
  project.addEventListener(""touchstart"", e => {
    started(e, ""touch"");
  });
});");
            WriteLiteral(@"

const docUp = () => {
  if (!expanded && target) {
    stopped();
  }
};

document.addEventListener(""mouseup"", () => {
  docUp();
});
document.addEventListener(""touchend"", () => {
  docUp();
});

const docMove = (e, type) => {
  let clientX = 0,
    clientY = 0;

  if (type === ""touch"") {
    clientX = e.touches[0].clientX;
    clientY = e.touches[0].clientY;
  } else {
    clientX = e.clientX;
    clientY = e.clientY;
  }

  if (
    clientY > drop.offsetTop &&
    clientY < drop.offsetTop + drop.offsetHeight &&
    clientX > drop.offsetLeft &&
    clientX < drop.offsetLeft + drop.offsetWidth &&
    start &&
    !expanded
  ) {
    drop.classList.add(""is-ready"");
    dropped = true;
  } else {
    drop.classList.remove(""is-ready"");
    dropped = false;
  }

  if (start && !expanded) {
    target.style.transform = `translateY(${clientY -
      offsetY}px) translateX(${clientX - offsetX}px)`;
  }
};

document.addEventListener(""mousemove"", e => {
  docMove(e, ""mouse"");
});
document.addEventListener(""touchmove");
            WriteLiteral(@""", e => {
  docMove(e, ""touch"");
});

drop.addEventListener(""mouseout"", () => {
  if (expanded) {
    //window.speechSynthesis.speak(msg);
    dropped = false;
    target.style.transform = ""none"";
    stopped();
  }
});

function score_f(){
  score = score + 1;
  document.getElementById(""myScore"").innerHTML = ""My Score: "" + score;
}

function incorrect_f(){
  incorrect++;
  document.getElementById(""myIncorrect"").innerHTML = ""Incorrect: "" + incorrect;
}

function shuffle(a) {
    var j, x, i;
    for (i = a.length - 1; i > 0; i--) {
        j = Math.floor(Math.random() * (i + 1));
        x = a[i];
        a[i] = a[j];
        a[j] = x;
    }
    return a;
}
function wordGenerator(){

    answer = tmpWords[x];
    var arr= [];
    for (i=0;i < words.length; i++)
    {
      if (answer != words[i])
      {
        arr.push(words[i]);
        //arr = words[i];
      }
    }
    var result = getRandom(arr,3);
    result.push(answer);
    shuffle(result);
    //var arrTmp = [words[j], words[j+1], words[j+2], words");
            WriteLiteral(@"[j+3]];
    //answer = arrTmp[Math.floor(Math.random()*arrTmp.length)];
    msg2 = new SpeechSynthesisUtterance(answer);

    document.getElementById(""box1"").innerHTML = result[0];
    document.getElementById(""box2"").innerHTML = result[1];
    document.getElementById(""box3"").innerHTML = result[2];
    document.getElementById(""box4"").innerHTML = result[3];
    x=x+1;
    //j=j+4;
    if(x > words.length){
      getModal();
    }
}

function getModal() {
  modal.style.display = ""block"";
  document.getElementById(""finalScore"").innerHTML = ""Score: "" + score + ""0%"";
}

function incrementProgress() {
  progress++;
  document.getElementById(""gameProgress"").innerHTML = ""Progress: "" + progress + ""/10"";
}

function getRandom(arr, n) {
    var result = new Array(n),
        len = arr.length,
        taken = new Array(len);
    if (n > len)
        throw new RangeError(""getRandom: more elements taken than available"");
    while (n--) {
        var x = Math.floor(Math.random() * len);
        result[n] = arr[x in taken ? ");
            WriteLiteral(@"taken[x] : x];
        taken[x] = --len in taken ? taken[len] : len;
    }
    return result;
}

getProjectName = target => target.querySelector('h4').textContent;

// pop up part
// Get the modal
var modal = document.getElementById(""myModal"");

// Get the button that opens the modal
var btn = document.getElementById(""myBtn"");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName(""close"")[0];

// When the user clicks the button, open the modal 
btn.onclick = function() {
  modal.style.display = ""block"";
}

// When the user clicks on <span> (x), close the modal
span.onclick = function() {
  modal.style.display = ""none"";
}

// When the user clicks anywhere outside of the modal, close it
/*
window.onclick = function(event) {
  if (event.target == modal) {
    modal.style.display = ""none"";
  }
}
*/
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Game>> Html { get; private set; }
    }
}
#pragma warning restore 1591
