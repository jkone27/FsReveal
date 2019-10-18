(**
- title : Introduction 
- description : Introduction to F#
- author : Giacomo Parmigiani
- theme : night
- transition : default

***
- data-background : ./images/wow-f-sharp.jpg
- data-background-repeat : repeat
- data-background-size : 800px
- body-color : blue

<h1 id="first-slide-title">F#</h1>

slides done with:
![FsReveal](https://fsprojects.github.io/FsReveal/formatting.html) (F# jsReveal)

' my spearker notes

***

### F# Intro

1. **What** is F# : open source functional first .net language
2. **Why** learning F# among all functional first languages
3. **language features** (similarities and differences with other langs)
4. A simple console application using **FSharp.Data**, what is a type provider?

<aside class="notes">
my spearker notes
</aside>

***

### F#

  - **let** - expression bindings (everything is a function)
  - automatic type inference
  - higher order functions (functions accepting functions as parameters) - HOF
  - currying and partial application
  - lists, arrays, sequences (IEnumerable)
  - tuples : product types
  - the **type** keyword (defining custom types)
  - records (~ super-powered C# poco classes) : product types with names
  - union types (discriminated union - or sum types)
  - pattern matching over list, tuples, unions, records and so on

***

### What? (Wikipedia)

* F# (pronounced F sharp) is a general purpose, strongly typed, multi-paradigm programming language that encompasses functional, 
imperative, and object-oriented programming methods.

<aside class="notes">
is most often used as a cross-platform Common Language Infrastructure (CLI) language, 
but it can also generate JavaScript and graphics processing unit (GPU) code.

Is developed by the F# Software Foundation, Microsoft and open contributors. 
An open source, cross-platform compiler for F# is available from the F# Software Foundation. 

F# is also a fully supported language in Visual Studio and Xamarin Studio. 

Other tools supporting F# development include Mono, MonoDevelop, SharpDevelop, MBrace, and WebSharper.

Plug-ins supporting F# exist for many widely used editors, most notably the Ionide extension for Atom and Visual Studio Code, 
and integrations for other editors such as Vim, Emacs, Sublime Text, and Rider.

Is a member of the ML language family and originated as a .NET Framework implementation 
of a core of the programming language OCaml. 

It has also been influenced by C#, Python, Haskell, Scala, and Erlang.
</aside>

***

#### F# (with tooltips via FSharp.Formatting library)

*)
let a = 5
let factorial x = [1..x] |> List.reduce (*)
let c = factorial a
(** 
`c` is evaluated for you
*)
(*** include-value: c ***)
(**

*** 

### Why Should I Care?

- Re-use all .net and .netcore framework and libraries. aspnet inlcuded (ALL)
- ML family language synthax is broad and can be useful to understand and reason about many different languages
- Facebook reason comes from OCaml and also has an ML like synthax
- Elm also is strongly inspired from ML synthax (and there is an F# impementation of elm architecture called Elmish)


***

- can transpile to JS with the awesome Fable.js (so it can be used as a full stack lang)
- It's beautiful, elegant and simple
- TypeProviders enable fast prototyping and "automatic integration testing" towards data sources
- computation expressions provide an elegant way to write monads to be used in a simple way

***

- easilly interop with C# in the same solution
- with Blazor fullstack .net development is possible thanks to webassembly
- xamarin allows mobile app development with sharing of most common code
- Visual Studio is great and has plenty of support for F#

***

- vscode works great on mac and linux and has amazing support for F# via ionide extension
- it's open source and with a very active community
- microsoft quantum lang is developed from F#
- for data science and visualizations can be easy to shift from python, many libraries for ML, computervision and so on
- strong type inference and domain modeling via ADT typesystem means less unit test to write since there is more compile time encoding

***

### What about Haskell?

    [lang=haskell]
    factorial n = product [1..n]

- Haskell is the only widely used pure, lazy functional programming language. 
- Like Standard ML and OCaml, Haskell uses an extension of Hindley-Milner-style type inference, 
which means that the programmer doesn't have to write down (most) types, because the compiler can infer them.
- https://www.quora.com/What-are-the-pros-and-cons-of-F-versus-Haskell-as-a-functional-programming-language-Which-would-you-recommend-for-newbies-and-why

***

### And Why Not Scala

    [lang=scala]
    Object Factorial {
        def factorial(x: BigInt): BigInt =
            if (x == 0)
              1
            else
              x * factorial(x - 1)
    }

- scala is OO first, and mostly a C-like lang for its essential aspect, though inheriting a lot from other functional ML langs
- scala has curly braces, used to identify scoping, making it closer to java or C# to look at
- scala has very limited type inference (https://mikhail.io/2016/08/comparing-scala-to-fsharp/)
- scala has higher-kinds like haskell (but it's a quite advanced feature), ML fam langs dont have (they have module signatures though)
- https://www.quora.com/Is-F-F-Sharp-better-than-Scala-If-so-why

***

#### Units of Measure

*)
[<Measure>] type sqft
[<Measure>] type dollar
let sizes = [|1700<sqft>;2100<sqft>;1900<sqft>;1300<sqft>|]
let prices = [|53000<dollar>;44000<dollar>;59000<dollar>;82000<dollar>|] 
let pricePerSize = prices.[0]/sizes.[0]
(**

#### `prices.[0]/sizes.[0]`

*)
(*** include-value: prices.[0]/sizes.[0] ***)
(**

***

### Sources

- rosetta code
- fs-snip

***

### F# Leggends

- Don Syme (creator)
- Tomas Petricel (Type providers)
- Alfonso Garcia Caro (Fable)
- Scott Wlaschin (Domain Driven Design and F# expert)
- Mark Seeman (also author of Dependency Injection in .NET)
- Rachel Reese (ex-Jet CTO, 100% F# e-commerce company)
- Alena Hall (microsoft cloud advocate)

*)