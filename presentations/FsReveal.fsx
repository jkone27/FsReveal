﻿(**
- title : FsReveal 
- description : Introduction to FsReveal
- author : Karlkim Suwanmongkol
- theme : Sky
- transition : default

***

### What is FsReveal?

- Generates [reveal.js](http://lab.hakim.se/reveal-js/#/) presentation from [markdown](http://daringfireball.net/projects/markdown/)
- Utilizes [FSharp.Formatting](https://github.com/tpetricek/FSharp.Formatting) for markdown parsing

***

### Reveal.js

- A framework for easily creating beautiful presentations using HTML.  
  

> **Atwood's Law**: any application that can be written in JavaScript, will eventually be written in JavaScript.

***

### FSharp.Formatting

- F# tools for generating documentation (Markdown processor and F# code formatter).
- It parses a literate F# script file (markdown & F# code) and generate HTML or PDF.
- Code syntax highlighting support.
- It also evaluates your F# code and produce tooltips.

***

### Syntax Highlighting

#### F# (with tooltips)

*)

let a = 5
let factorial x = [1..x] |> List.reduce (*)
let c = factorial a
(*** include-value: c ***)
(**

---

#### C#

    [lang=cs]
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, world!");
        }
    }

---

#### JavaScript

    [lang=js]
    function copyWithEvaluation(iElem, elem) {
      return function (obj) {
          var newObj = {};
          for (var p in obj) {
              var v = obj[p];
              if (typeof v === "function") {
                  v = v(iElem, elem);
              }
              newObj[p] = v;
          }
          if (!newObj.exactTiming) {
              newObj.delay += exports._libraryDelay;
          }
          return newObj;
      };
    }


***

**Bayes' Rule in LaTeX**
  
$ \Pr(A|B)=\frac{\Pr(B|A)\Pr(A)}{\Pr(B|A)\Pr(A)+\Pr(B|\neg A)\Pr(\neg A)} $

*)