#pragma checksum "c:\Users\wongd\Documents\Bitbucket\seniorprojectfall2019team9\SightWordsProject\Views\Student\StudentStage1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a9006e33c50468c18b6a18b2743192bb3251dbe"
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
#line 1 "c:\Users\wongd\Documents\Bitbucket\seniorprojectfall2019team9\SightWordsProject\Views\_ViewImports.cshtml"
using SightWordsProject;

#line default
#line hidden
#line 2 "c:\Users\wongd\Documents\Bitbucket\seniorprojectfall2019team9\SightWordsProject\Views\_ViewImports.cshtml"
using SightWordsProject.Models;

#line default
#line hidden
#line 3 "c:\Users\wongd\Documents\Bitbucket\seniorprojectfall2019team9\SightWordsProject\Views\_ViewImports.cshtml"
using SightWordsProject.ViewModels;

#line default
#line hidden
#line 4 "c:\Users\wongd\Documents\Bitbucket\seniorprojectfall2019team9\SightWordsProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a9006e33c50468c18b6a18b2743192bb3251dbe", @"/Views/Student/StudentStage1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23c3ff965647b74ae8e3c23121d934ca27153c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_StudentStage1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "c:\Users\wongd\Documents\Bitbucket\seniorprojectfall2019team9\SightWordsProject\Views\Student\StudentStage1.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 15, true);
            WriteLiteral("\r\n<style>\r\n    ");
            EndContext();
            BeginContext(61, 1037, true);
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
  font-size: 14px;
  transition: .3s;
  font-weight: 500;
  color: rgba(0,0,0,.5);
  opacity: 0;
  visibility: hidden;
  pointer-events: none;
  transform: translateX(-50%) translateY(0) scale(.8);
  z-index");
            WriteLiteral(": -1;\r\n  \r\n  ");
            EndContext();
            BeginContext(1099, 14016, true);
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
  background-color");
            WriteLiteral(@": red;
  border-color: red;
  color: #fff;
  font-size: 12px;
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

</style>

<div class=""showcase"">
  <H1>Choose Cat</H1>
  <div class=""project"">
    <img class=""project-img""  src= ""data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxMTEhUTEhMVFhUXFxUVGBcVFRUVFRUVFRUXFxUVFxUYHSggGBolHRUVIjEhJSkrLi4uFx8zODMtNygtLisBCgoKDg0OGhAQGi0lHx0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tL");
            WriteLiteral(@"S0tLS0tLS0tLS0tLS0tLS0tLS0tLf/AABEIAKgBLAMBIgACEQEDEQH/xAAbAAACAgMBAAAAAAAAAAAAAAAEBQIDAAEGB//EADoQAAEDAwEGBAYBBAECBwAAAAEAAhEDBCExBRJBUWFxgZGh8AYTIrHB0eEUMkLxYhVyByMzUoKSsv/EABgBAAMBAQAAAAAAAAAAAAAAAAECAwAE/8QAIREBAQACAwEAAgMBAAAAAAAAAAECEQMhMRITIgRBUTL/2gAMAwEAAhEDEQA/APLGkLe8qaQlFNpqSsDVCosKvqsVYYjGsReq2BWOYSpMoFHZRNu9XueChvlwq3OhJYaVc+mqoU2VFZMrC02EXZbMqVXBoa4ToYMeaY/DOzN9+8dBwIwV6BRs4AgQOECFHPk11FcePfdc/wDD3w4ymZdl0TnnoffVdR/TwPpGODdPZUK1SIcQMcehwZ6foqZqg48unb1x/KT30/ixjiAfOPD6v2oCqNRr+R+1W9u8dTI1jUc8+/VUOEgtJ+rhwkjhHOCtWi8kuyNQPDn77LTGyHB3PHY4+8+ahvkTGv34jzB9VulUxprMcp1WFAtdugHoZ49VZaE57RPWYW21c9Pxy8CFZTxHL+7vof0tJ3trUrc7riSeGvIiBP58VRUugGgggQRPMZH2n0CnXqYccTBPfK56s8jeHuJH4QuWmmO3QMriM9Tjr18VXvT1J0jg3n9vRKajswdOPYa/rxTGlcCCT0mPtKEy2Pzpfvgc/HVTa8GZ49lR84c8ef6WvmE65HmfQYQ02ivb+ywWbwHQCPM4XD3X0kifyvTDUBw7Q4wMrmdubEpiSxrj1Oirx5yJ541xTsqp1NMX2sFVupLpiFmldrRlF/0oUaLoVj6yW+mmkXUwEHVpAlZVuVVTr5Rm2ujGyMJ1QYHBc3Trwm1heJbGlOmtgISrWysr3uEnr3WUptk7RCIah3tK21yp6TwUxivFqgaFxBTRtbCWjEGMCqqQqLi4I0QxquKaQlEuqBCPyiKVMnEK3");
            WriteLiteral(@"+gKO9NoI3CO2ZTNR4aGkg6wt0tm1HGGtJ8F3Pw1sL5A33gBx5Ex4hS5OSSdKYYW3sz2ZYBjAMaYOhRfzjIBI6cJ/lVXDyD/AHjtH5WOJ5AjqBB8VyuheDOMGcQYOvJZRbH0kHGvMc3AHhoY7qhtQDEATxAbJ6SBg+iytcQJBJI4E58COI/YVNyF1asaMzg5gxgkaiPDRX1aYcDMEjPIjOCPVJv+o5YQenvqITM3EweY/Mj30Q+pR+bFrWh06SND2GnqQojiRry5cytuz3ifHRQ+X9QI4+4Pqj6zTDr4eYk+MqxukdQRygx9lHeA58cx9+eii08Imc9pW22gtd+rTqdP5Sm+cROIgZB7QU1vLc6jn5YQD6W8I5e/fdTyimIWteAt3vZz/ARmyhLN52mdUiv6W6BM66dQr7/apo24LRL3Q2m3XJxoq8fF9dp8nJ8dGW09qsp4fUa3pOT4BLaPxGxxhhB8ISO0+G21muqVrgmpvOaW7pjeAJMOdG+MESMclTcfDD2S6mcgmOTgPtK6M+CYTtDHnuV6egWt5vNkHv71RjiCIIOeei4PYG0SBkxwIJ4jUELqbW7LonTy8pyuTLH5unR7Nk22dmmSWNnmQMBc+8L0Ko3fG64FcXtfZppOJIwThdHFlNac/JjfSeo5VOJRfy54KHylbaeqXVBKynQJTNtqCUbRtgELR+S0WkBREtOCmF1VASx5JMoTtr0ObVkKLqMoek9EZR1pthtyVj7VQs3SYThoEJPDeufqUSCiraphEXQCXB8FN7A8MPlAoijQbyQNOoUXbbxOiS3RvTW2txyTix2WHnIws2Ns1zs6LqKdHdEAKOWf+KYwNbbPp0xho9Fuu8Dt10VlV3vT1QleXaYHme56KKkY+qY07Z0HZRZUAOR4fn2Fm7giTGpJMei1ujUYHLH6TMKfXkZcCTwkZ8ylTqrt6DnrxHfn3RFbdIyGlKrq43DkxGnEeuiGR8cVtywNdJwCZ7Hn76IqlWx29eqU320mvaN2J6cfeFdZO");
            WriteLiteral(@"O6PL7R90vgzuH1tX/x6j2EwBJn7fwlVlBI7E+qb2zDr28v9SqxPJp5xBB9nK18rlnT1yr2s9MarYbjXsOKJQ1WlvdOY9EtuaG6ZjGidhoyeyor0N4IWGxychtihvD6R1zzC5+633VARI+Ww7sf4ucCA7vldjcU4dHA8Vzm2dh1BV+bQduu9D/xIOI/a6OG/rqdVDmx/bZJXr1AWhoDQIaABBgaCTyXX7Al1Mlxx4Dv9kssrapUxWtw0jG8xw3Sf+3+Sj76q9tL5VIBpOCTGnQD+EOT8uXVhMZjCG2pMqVntGDMiP8jJmeufRGm4NIw6R9vRVbE2O5j99xJzqeq6N9o2oS1wB8P2p811ZF+LzdRs7qWz9lbeFtWmQRMKNPZfy53dNCM68eyhVO6CZx04d1PzuHvfTk6lKCQEHWcQjrqsC490tuHErtx8cl6qdO4hEi7hKS0oqjTJGVri31WVHSZ4KLmqx7TKtp00fADMcrQ9WVbbkottigyiypxlEV7jdCpthiSoXQlDQ7UurEqoMkrcI6zoyjbqNrYixt072fayRCGtqK6TYlr/AJnQLnt2t5De3buNABWOqnmoSSq9MqVgypOqkZMnwVFa4ESR5zr9lurWxgZPMqppBdJxGnE+BOAgeNU6ucjrxx4ckNWv4JkY6Y9VO5duNJ8TzJXFbc2s4b0Ht+yjhj9XRrfmbdPcbbpt1eG9yhjtmhU+kPaSeBn8hcHTti8zUJAOSY3iMYx5Lo9o0LEvYxjAxjGBxeN7equMhuhMYBJ69F2Yfx8bNuXP+RlLpZdUvlVJA+k5TayuN7I8vDC5V5fTw1zqlOcbwyAE62LUBAI/tPFTz4pZuHw5bvVdjskzk64x04/dO6LogcP0uc2XWxEcU9pO0PuVHFXOdj8KLtFplTSe61UdJRpIxuVhEQqgtobEJcWQfMhAGgWGNRz4hNyVVWb4ojsofTgyPRbaxpyQPTzU6uphD3E459FrnlJrYzDGrKlYAQAI8EPZ1fq0iffvsgrpr40IH");
            WriteLiteral(@"KCRnst2TJIADiSevkEkxto3KSOjpQRJEzwMpbtu1hhd0JAjHmnVjQAEnxgz3APEqW0qe+CMAEERmT3jRX/F125/y9vJapJJVe6jrqjuOcDwKGd0wraJvaHyQjKbUGwGVcakLMm9gJWDCFbVhSDyStptjmNnRaOFKi4AKipUygOw4EKiu9U1KxVT3ymI0XZTbZyV06Up7sykkzvR8TWg1PbW4AZASXfAVNa83cKKuR8b8Bbp1y5c1Sui4wMk8l1lnagMmDpzQs6LOqErVoOesTOvZatagbmZPL7k/wAqN47IhD1qzQDG8Z8PRSXDbWvJmVxG0frcY5gSZhdDtGuDDfZ6KNPZ30ukajsq8VmN7LnLlNRKjYB9IObr7+yUiycHjDp5dtFKwuK9BxDRvNn+06eSf295UqkTTaw6yJJPadPVU+c5dTxD9f7Ldp0HboosEvdqeDWnUk8P5TnZmz/lMIkHqO3+kY23gYGTknjPOVdbtOAdZlbLL5nzDYY7/aj9k20NDimYeqGOxhTBwpK7FtqKxzsIRpV1J0oWgnvKWVJrJUtzkg21BPNQJRZoEqirSI0TQCu41JVDiOhKPdbuyYQu6Ac+Sa47gY5aDnZrX6tjkfc/hGWFi5rskHhgyY78E42ZQESRr6K+6oBvCZ4c+n8Lo4ePrbn5uTd0B3w0TIDRy0A5Dr1QxZ8zO8abepy7w/atr0y4y/HJvAeH7VFau0+HQN9DqrWJSuB29Q3azwAYnWDCXNq8E7+MAfmjdJILQY0AXPNpklSq2N6MrW3lWXVuAFdYMAGSfOPsq76q0cEm+z66KnURzV9FgCqfVC0LlORO4dGFQCtuqSVc2iOqwF4bKk2gt0KJGqvLklyPMUrahJwnVtSgIbZVLimhZKlldq4xu3pSUY6wa4ZCy0bCNwh4N7LrbZrGvBACeXtbdbCXteJnkhrq7kmSlzy602OPe1NetJiY1MpfdXDhDW/UeH+lZevERxJHgEZaUJIAEjjy7zwSQ9KNm7KeXb9Tv266p");
            WriteLiteral(@"zWoQ0H3nqE3ZZxoD2In7Z9ELeUTEAY7g/bRGxpkBoWrHGTrqjmNY0YA6YSgv3MTB5fjmsZdl2GyScf6HJLLkb9Taq8HA6SfwstjGefvVA0BoOB9SNT2RDqs41GndGetl4YUqqNpaJVTGAj6BJxCrYhta6qiqK1a2fEqvat4yk2SYSTC2jc5IYfMCAutrMZqVw178TvcTuJZUqVahkldOPBUbyR6VafElImCQnFrdU3kZBXjwscTvwe6nY7Yq0Hf3SE94ZCfk290FiCMBL9o7DDsjCr+ENuCtTE6p5d5GFWYRK5WVyNLanyHfLeJd/j/AMkfk/WTB66DoP2tbU2Vv/V/kNDyStl7u/8AqZcNJw0eeE0mui3vtu5Ou6I6u3pPUDilm8N76o7u/ARO1Lp7tDj/AIT/APo4Sum8TO4TnU7u96mUKaKPiwhwYY4YMHyyuZ3DyH3XS/E1y1zGiDvDodFzVJ/D8FRz9Xw8RqVo4n32Qpq7ztEzrUBH8FLmsh2EJBtbdbyEOaZGqbmqIQryEQLhIKKbcqL2ha+UiAyuxAObJRVWqqWuBKnIps5sNE3tmJfsqjKf29vCjfVZellNjYQ9zjRFuACFrFChPQhdxSy5fBynJp4S6+oJLDyggQTvHMJxsSnP1Tp5DxXPCqQY4Jt8O1C4vbwAnTPiUcYGd6dnaUnOEyD/ANhJHjErVxagjIJPPGEJQvA0BoIHOZGe86pk25Ef4/8A2iV2Y4SxyZZ2Vy9/sckyCD5x78UDb2BEgY66kjkB7/XaPogjQT5+phBfI3XTj1WvBGnNSuns/d0nTJP4Wq9DdPoE3BbPPTwUbim3M8uiS8B5z/6UUKji6F1WzKEifNcnsUipXLSRhd1aU90Qn4+LfqfJya8Su2btMnkF4/8AGO1jUqbgOAvV9rVv/LcOi8J264iq7uVS4SUuNtg+jcMYFXV2pyXPPrFSZVTfTfI+62i48UI28cdSqnZU7W2Lilt2aSR6J/4dbRfvAcJXrpqYBXkHwiwUy0Ben");
            WriteLiteral(@"0LoFuqfEmcGl8lKts2o3CREjORKlUug0aoSvWLmHKZNzr7kEx8xx6NEiemEI5zXH6XPPPX8qb3CTLnD0/2strfMk73IxJHh+lLK9K4zso2p1LvHP4SU1M4Pouk2lYHWZHf8pJ/TCVDHLboyxEscQ3I/KWPMO1TcuDW/v9rnr2tLk0LTIGQg6+CrLdxjKlUoogFaVewYUxTWbnJYCqpVKttpJURQPJG2luZ0Qpo6LY7TCesJS3ZVLCbEYXPpXatzlR8xbqPIUGOlJldGxibkNcRGUQSqXNS7Npz1/RMyAmHwjhxEySM4KIuGIWzcabxujU5Ov+lXjymycmNsdG2jHH33IRzKgAA9nuT+kHcOx6n8qArjUiB9z798F3SacVuzllURqO8fqFM0w4a+n45JKasQTnlOT4e/0jaFbEu+kctPMpiWJBoafpg59VK7cNwiOHFQNdrQXuLWgcSY7IOpfyDAJnSG4jnLkWU/Duzmkl+juYXXUDujWVzuzGEf2jB1ymzS49kcemy7q28bvNK8g+LNjkVSRxXq1zXMFcjthgfPNLmfB5i+ydxVJZCf7TpkEwkr6ZJU+lO1LTCLoVzwQ+5mEzs7YYK2206v4eaYErs7eoQBBlcXs26ATmltIAao4tlDurcxqhri+DmwEjuNq5jVY2qC0zjgD71R2TS+nVO9Dcgzh2QmFEfLwRg+O72PFv27aA7FYR/dqE3qVJ1CnyX9T4f9KLijIPsFc7tCgG5H+wnb6m79M44fpI9qknRc2F7dGXhbVfOEGbfKmZ48FunVnCuklSbCk/or6FGVbVtoS7NoAH81c1Y+kAtJitWzAdEY2iOCrtLYqx9HKS00ObB0I01ClVk8pg16nTxtaKmxwW3EKNUUbyiVJ5UWwlpog9p7oWr5dx7CMeeSGqglNK1WUtoFxh2gwAD6nmUR/UHljrj75jwQ9vaScmAiq9EtbvN/k/yu/iytnbh5JJemPuHDSATrMk9NYjsULVY45qPMcATujxIWW7jMuMCehPmcD");
            WriteLiteral(@"1VVxXaNB/8AImSSfYVExltVaT9LBj/IiIjUlxySeiAr38kuqHe/46DE8J++ig+5LfpmZxH47nkhL61Jy7J1jgOU8zP2W20jodi7ea4EcjGNPBNP+oeS8xoVqlF++OenDX0XS2fxExw+rB9EZk1xdBcXbjolN1UEmVA7VB0Qde9BzKFoyFt/Q3iklWjBKZXd+JVdtZuqZCmrIWVqeJ5Ii3aTG6CU6o/DpOqd7N2YymPqhNo8wI7XZtWJiAl9zdPDt2dDldTtbbTWgsp5K5ploXZOpKFbLQrZLZqDM80+qEEgAfToe40KV7LtjTJJCb0WgCQjjEMr2NtRP5/BTBuiAtHZlM5EJeSbg4XstvWD8julVcA5TW411Sq7wuXH103wru6YyqbG1krbqwmCUfZOCvZ0nvsfTtgGoG8qgac0wq1MLn7yrkpYap1GkhUfKciLO5GiOgJi6KqO04wi6dyHJVZWYKa06Ialowwt6itdVQVIotoSCIpVOiJB5oJtSFYx5KlVIsrBDyrKrkOH8YUqtiJDea05QY/mpAk6Y6/wjC5LLZsnVOqVEbufP8BKqVPd1/kosXPpoOq7uC6cfNNg9o2n/t0GvU8klq4OZnh359gusc0QZOnHrxKUXdnIJ0nA6DkuixCUgNWHSNANeOdTPMwi6VyI3j4Dnwk/YKN5Z+sD1/n0QtRkH32/aTuH6EXNAOBdq6M6Y6JZU2fMDQ6nvqiKjyFNt2Dk66eiGx0R1d9pgOPJCvrvmCU+rsaTIj7eKFrbPjIMhYSz5JKZWF++lpkK5lNpCqq0QsaUcfiZ4H9qVXe2KtTUwFhpqkU8obN9UVY5OU9tmxBhJ6EThMqVTidAsSjxciUVPEJfQcHEHgcHojWGIHBUidHUafEI+jJ0E/dAUjAkI6xqkyA3ekGQeWD+Ap5nxRvbQwCdSJAAJPWeUY80mvrJ2QCN4YIg6xMT556Iu+vajXOBg545AIdM4Ma+C5m8qVGu4iQ4ToSCM+jh5qEx7Wt6R/6S/wCYRvCRJ");
            WriteLiteral(@"PRomHZPGNPFV0hUzutLhJaHNGDHIq+0uahcYAe6Q+TMgtBAOCJOYgzwUd57PpBP0kyAeRyAfD8q1kTlqbK1V0AU3ZiMc9Psqq1rUcCdw8ccRH+j5FYdqPLC0jJdJdyG9IDRH0wY8gi6G0n7u5/lOXHUQZgCMEFLqQd0BV2e+mSToHbs8zE46Rx7KP8AUkJldhxaA4nEQD2EekJLVdlNuBqt2l1ARjLmVixLlDSrqVVFNqraxSMvtqg8UW160sUr6pPGOCpqrFiS+niLavRE0qi0sQx9HJMPk4RVIQPELFi6+NzcniLqpwDgTKpq3E5BJz7AWLF1xzWKbgwM/wB2o/lAl28eRgekrFi1aArgZMaIN7MSsWJLDRB7ceioNQzrotrEpl9KqPH7rKmVtYswZwlQFMkrFiwjKdAgE8kRZ1AcFYsRLvYu2lrsaJgyoPVYsTAMtXBHVbuGgNxG7xkfTnTqYJ7LFilaeQqq374gER9QjOjtePQe5Se+2nUk/wBud4HByHTI10z6DksWIQ1UUNrOaGtYCCN2c/Sd2dGiNSZPZMqV/ULRpgETBmDrmfcBYsWtNIU3e1KwJjdiSYgxJdvTE858yp2W3i1rt8EuyGxgAECczP8AjPdYsWxoWN1Pieoc4mZ0POefcdjHKFoO9mNStrExX//Z""/>
    <span class=""project-name"">The Catcher in the Rye</span>
  </div>
  <div class=""project"">
    <img class=""project-img"" src=""https://timesofindia.indiatimes.com/thumb/msid-67586673,width-800,height-600,resizemode-4/67586673.jpg"" />
    <span class=""project-name"">To Kill a Mockingbird </span>
  </div>
  <div class=""project"">
    <img cla");
            WriteLiteral(@"ss=""project-img"" src=""https://res.cloudinary.com/dk-find-out/image/upload/q_80,w_1440,f_auto/DCTM_Penguin_UK_DK_AL316928_wsfijk.jpg"" />
    <span class=""project-name"">The Great Gatsby</span>
  </div>
  <div class=""project"">
    <img class=""project-img"" src="""" />
    <span class=""project-name"">Animal Farm</span>
  </div>
  <div class=""project"">
    <img class=""project-img"" src=""https://source.unsplash.com/908x908"" />
    <span class=""project-name"">The Diary of a Young Girl</span>
  </div>
  <div class=""project"">
    <img class=""project-img"" src=""https://source.unsplash.com/912x912"" />
    <span class=""project-name"">Fahrenheit 451</span>
  </div>
  <div class=""project"">
    <img class=""project-img"" src=""https://source.unsplash.com/916x916"" />
    <span class=""project-name"">The Grapes of Wrath</span>
  </div>
  <div class=""drop"">DROP HERE</div>
</div>

<script>
    const projects = document.querySelectorAll("".project"");
const drop = document.querySelector("".drop"");
const showcase = docum");
            WriteLiteral(@"ent.querySelector("".showcase"");

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
    offsetY = target.offsetWidth / 2 + target.offsetTop;
    offsetX = target.offsetWidth / 2 + target");
            WriteLiteral(@".offsetLeft;
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
    clientY < drop.offsetTop + drop.offsetHeight &&
    clientX > drop");
            WriteLiteral(@".offsetLeft &&
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
