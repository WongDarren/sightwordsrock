#pragma checksum "/Users/movleafen/seniorprojectfall2019team9/SightWordsProject/Views/Student/Game/Stage1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5444df08f22912d5c581b7ee7149ddd9c56ecd45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Game_Stage1), @"mvc.1.0.view", @"/Views/Student/Game/Stage1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Game/Stage1.cshtml", typeof(AspNetCore.Views_Student_Game_Stage1))]
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
#line 1 "/Users/movleafen/seniorprojectfall2019team9/SightWordsProject/Views/_ViewImports.cshtml"
using SightWordsProject;

#line default
#line hidden
#line 2 "/Users/movleafen/seniorprojectfall2019team9/SightWordsProject/Views/_ViewImports.cshtml"
using SightWordsProject.Models;

#line default
#line hidden
#line 3 "/Users/movleafen/seniorprojectfall2019team9/SightWordsProject/Views/_ViewImports.cshtml"
using SightWordsProject.ViewModels;

#line default
#line hidden
#line 4 "/Users/movleafen/seniorprojectfall2019team9/SightWordsProject/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5444df08f22912d5c581b7ee7149ddd9c56ecd45", @"/Views/Student/Game/Stage1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a60f5c74b5fb0ccb9da513ed896571003f7584a", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Game_Stage1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/movleafen/seniorprojectfall2019team9/SightWordsProject/Views/Student/Game/Stage1.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 13, true);
            WriteLiteral("\n<style>\n    ");
            EndContext();
            BeginContext(56, 1236, true);
            WriteLiteral(@"@import url('https://fonts.googleapis.com/css?family=DM+Sans:400,500,700&display=swap');

* {
  box-sizing: border-box;
}

body {
  font-family: 'DM Sans', sans-serif;
  overflow: hidden;
}

.project-img {
  width: 100%;
  height: 100%;
  object-fit: cover;
  object-position: center;
  display: block;
  user-select: none;
  pointer-events: none;
  border-radius: 50%;
  text-align: center;
  transition: .5s;
}
.header-project {
  width: 200px;
  flex-shrink: 0;
  margin: 0 10px;
  height: 160px;
  border-radius: 50%;
  user-select: none;
  cursor: pointer;
  left: 0;
  transition: .4s;
  top: 0;
  position: relative;
  z-index: 1;
  transform-origin: center;
}

.project {
  width: 80px;
  flex-shrink: 0;
  margin: 0 10px;
  height: 80px;
  border-radius: 50%;
  user-select: none;
  cursor: pointer;
  left: 0;
  transition: .4s;
  top: 0;
  position: relative;
  z-index: 1;
  transform-origin: center;
}

.project-name {
  position: absolute;
  width: 140px;
  text-align: center;
  left: 50%;
  top: 100%;
  font");
            WriteLiteral("-size: 14px;\n  transition: .3s;\n  font-weight: 500;\n  color: rgba(0,0,0,.5);\n  opacity: 0;\n  visibility: hidden;\n  pointer-events: none;\n  transform: translateX(-50%) translateY(0) scale(.8);\n  z-index: -1;\n  \n  ");
            EndContext();
            BeginContext(1293, 5839, true);
            WriteLiteral(@"@media (max-width: 768px) { display: none; }
}

.project:hover { z-index: 2; }

.project:hover > .project-name {
  opacity: 1;
  visibility: visible;
  transform: translateX(-50%) translateY(10px) scale(1);
}

.project.is-selected { z-index: 2; }
.project.is-selected > .project-img { box-shadow: 0 0 0 6px red; }

.showcase.is-dragging .project {
  pointer-events: none;
  transition: none;
}

.showcase.is-dragging .drop {
  border-color: red;
  color: red;
}

.drop {
  position: fixed;
  bottom: 20px;
  left: calc(50% - 45px);
  width: 90px;
  height: 90px;
  border: 3px solid #ddd;
  color: darken(#ddd, 15%);
  border-radius: 50%;
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

.drop.is-ready {
  color: transparent;
  background-color: red;
  transform: scale(1.3);
}


.drop.is-dropped {
  z-index: 3;
  background-color: red;
  border-color: red;
  color: #fff;
  font-siz");
            WriteLiteral(@"e: 12px;
  width: 64px;
  height: 64px;
  left: calc(50% - 32px);
  cursor: pointer;
}

.project.is-expanded > .project-img { border-radius: 0; }
.project.is-expanded > .project-name { display: none; }

.showcase {
  height: 100vh;
  overflow: hidden;
  justify-content: space-evenly;
  align-items: center;
  display: flex;
}

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
  width: 100%;
  height: 100%;
  transform: none !important;
  z-index: 2;
}

.centered {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  width: 100%;
  height: 50%;
  object-fit: cover;
  object-position: center;
  display: block;
  user-select: none;
  pointer-events: none;
  border-radius: 50%;
  text-align: center;
  transition: .5s;

}

</style>

<div class=""showcase"">
  <div class=""header-project"">
    <h1>Hello world</h1>
  </div>
  <H1>Choos");
            WriteLiteral(@"e Cat</H1>
  <div class=""project"">
    <img class=""project-img"">
      <div class=""centered"">Centered</div>
    <span class=""project-name"">The Catcher in the Rye</span>
  </div>
  <div class=""project"">
    <img class=""project-img"" src=""https://timesofindia.indiatimes.com/thumb/msid-67586673,width-800,height-600,resizemode-4/67586673.jpg"" />
    <span class=""project-name"">To Kill a Mockingbird </span>
  </div>
  <div class=""project"">
    <img class=""project-img"" src=""https://res.cloudinary.com/dk-find-out/image/upload/q_80,w_1440,f_auto/DCTM_Penguin_UK_DK_AL316928_wsfijk.jpg"" />
    <span class=""project-name"">The Great Gatsby</span>
  </div>
  <div class=""project"">
    <img class=""project-img"" src=""https://source.unsplash.com/908x908"" />
    <span class=""project-name"">Animal Farm</span>
  </div>
  <div class=""project"">
    <img class=""project-img"" src=""https://source.unsplash.com/908x908"" />
    <span class=""project-name"">The Diary of a Young Girl</span>
  </div>
  <div class=""drop"">DROP HERE</div>
</div>

<sc");
            WriteLiteral(@"ript>
    const projects = document.querySelectorAll("".project"");
const drop = document.querySelector("".drop"");
const showcase = document.querySelector("".showcase"");

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
    showcase.classList.add(""is-preview"");
    target.classList.add(""is-expanded"");
    drop.classList.add(""is-dropped"");
    drop.textContent = ""CLOSE"";
    expanded = true;
  } else {
    drop.classList.remove(""is-dropped"");
    showcase.classList.remove(""is-preview"");
    target.classList.remove(""is-expanded"");
    drop.textContent = ""DROP HERE"";
    expanded = false;
  }
};

const started = (e, type) => {
  start = true;
  target = e.target;
  if (type === ""touch"") {
    console.log(e.touches[0]);
    off");
            WriteLiteral(@"setY = target.offsetWidth / 2 + target.offsetTop;
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
    clientY < drop.off");
            WriteLiteral(@"setTop + drop.offsetHeight &&
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

drop.addEventListener(""click"", () => {
  if (expanded) {
    dropped = false;
    target.style.transform = ""none"";
    stopped();
  }
});

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
