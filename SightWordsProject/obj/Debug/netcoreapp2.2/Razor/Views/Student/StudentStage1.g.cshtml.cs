#pragma checksum "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/Student/StudentStage1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87bb50c625ed926413335071b84f009351c8f8b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_StudentStage1), @"mvc.1.0.view", @"/Views/Student/StudentStage1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/StudentStage1.cshtml", typeof(AspNetCore.Views_Student_StudentStage1))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87bb50c625ed926413335071b84f009351c8f8b4", @"/Views/Student/StudentStage1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a60f5c74b5fb0ccb9da513ed896571003f7584a", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_StudentStage1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/trevormullaney/Documents/CS472/repo/seniorprojectfall2019team9/SightWordsProject/Views/Student/StudentStage1.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 13, true);
            WriteLiteral("\n<style>\n    ");
            EndContext();
            BeginContext(56, 1333, true);
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
  font-size: 15px;
  font-weight: 500;
  padding: 10px;
  user-select: none;
}

.project-na");
            WriteLiteral(@"me {
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
            BeginContext(1390, 6994, true);
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
  width: 110px;
  height: 110px;
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
  background-image: url(""/img/field.png"");
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
  pointer-events:");
            WriteLiteral(@" none;
  text-align: center;
  transition: .5s;

}

.speaker{
  height: 100%;
  cursor: pointer;
}

</style>

<div class=""showcase"">
  <div class=""header-project"">
    <img class=""speaker"" src=""/img/rock.png"">
    <!--Make .speaker able to say word when clicked-->
  </div>
  <div class=""score-project"">
    <h2 id=""myScore"">My score: 0</h2>
  </div>
  <div class=""project"">
    <img class=""project-img"">
      <div class=""centered""><h4 id = ""box1"">1st word<h4></div>
    <span class=""project-name"">The Catcher in the Rye </span>
  </div>
  <div class=""project"">
    <img class=""project-img"">
      <div class=""centered""><h4 id = ""box2"">2nd word<h4></div>
    <span class=""project-name"">The Catcher in the Rye</span>
  </div>
  <div class=""project"">
    <img class=""project-img"">
      <div class=""centered""><h4 id = ""box3"">3rd word<h4></div>
    <span class=""project-name"">The Catcher in the Rye</span>
  </div>
  <div class=""project"">
    <img class=""project-img"">
      <div class=""centered""><h4 id = ""box4"">4th word<h4><");
            WriteLiteral(@"/div>
    <span class=""project-name"">The Catcher in the Rye</span>
  </div>
  
  <div class=""drop"">
    <img style=""height:100%"" src=""/img/basket.png"">
  </div>
  
</div>

<script>
const projects = document.querySelectorAll("".project"");
const drop = document.querySelector("".drop"");
const showcase = document.querySelector("".showcase"");

// The array of words should be passed here
var j = 0;
var words = [""a"", ""b"", ""c"", ""d"", ""e"", ""f"", ""g"", ""h"",];
var chosen = [""a, c, g""];
shuffle(words);
wordGenerator();

// wordGenerator() change words from id=box1 to box4

var i = 0;
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
    drop.classList.add");
            WriteLiteral(@"(""is-dropped"");
    expanded = true;
    wordGenerator();
    //validatedWord();
    score();
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
});

const docUp = () => {
  if (!expanded && target) {
    stopped();
  }
};

document.addEventL");
            WriteLiteral(@"istener(""mouseup"", () => {
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
document.addEventListener(""touchmove"", e => {
  docMove(e, ""touch"");
});

drop.addEventListener(""mouseout"", () => {
  if (expanded");
            WriteLiteral(@") {
    dropped = false;
    target.style.transform = ""none"";
    stopped();
  }
});

function score(){
  document.getElementById(""myScore"").innerHTML = ""My score: "" + i;
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
    document.getElementById(""box1"").innerHTML = words[j];
    document.getElementById(""box2"").innerHTML = words[j+1];
    document.getElementById(""box3"").innerHTML = words[j+2];
    document.getElementById(""box4"").innerHTML = words[j+3];
    j=j+4;
    if(j > words.length){
      alert(""Run out of words!"");
    }
}
function validatedWord(dbWord, chosen){
  if (dbword === chosen){
    return true;
  }else{
    return false
  }
}


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591