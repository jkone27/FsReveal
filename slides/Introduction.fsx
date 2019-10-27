(**
- title : Introduction 
- description : Introduction to F#
- author : Giacomo Parmigiani
- theme : night
- transition : default

***

- data-background : ./images/wowfsharp.jpg
- data-background-repeat : repeat
- data-background-size : 800px

<div id="zoom">
  <h1 id="first-slide-title">F#</h1>
</div>

slides done with
[FsReveal](https://fsprojects.github.io/FsReveal/formatting.html) (F# JsReveal)

***
- data-background : ./images/fsharplogo.png
- data-background-size : 400px

### What will be talking about

<section data-markdown>
  <script type="text/template">
    1. What is that? <!-- .element: class="fragment" data-fragment-index="0" -->
    2. Why learning it <!-- .element: class="fragment" data-fragment-index="1" -->
    3. Language features via examples <!-- .element: class="fragment" data-fragment-index="2" -->
    4. Fsharp.Data = type providers <!-- .element: class="fragment" data-fragment-index="3" -->
  </script>
</section>

***
- data-background : ./images/batman.jpg
- data-background-size : 900px
- data-background-repeat: repeat-x


<div id="what-is-it">
<section data=markdown>

### Tell me more!
* general purpose, **strongly typed**, **multi-paradigm** 
* **cross-platform** (.NET/.netcore)
* can also generate **JavaScript** and **GPU code**
* makes it easy to write **correct** and **maintainable** code
* expressions are **type-inferred and generalized automatically**
* a data-rich experience with **type providers**
* also a **scripting language**

</br>
</br>

##### Sources
* [microsoft](https://en.wikipedia.org/wiki/F_Sharp_(programming_language))
* [wikipedia](https://docs.microsoft.com/en-us/dotnet/fsharp/what-is-fsharp)
* [type providers](https://docs.microsoft.com/en-us/dotnet/fsharp/tutorials/fsharp-interactive/)
* [scripting language](https://docs.microsoft.com/en-us/dotnet/fsharp/tutorials/type-providers/)

</section>
</div>

<section>
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
</section>

***
- data-background : ./images/underwater02.jpg

#### example, declaring a Factorial function

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
- data-background : ./images/stackoverflow.png
- data-background-repeat: repeat
- data-background-size: 300px

#### RECURSION

*)
let rec summ mylist acc =
  match mylist with
  |[] -> acc //the last operation performed is returning the value (tail recursion!)
  |x::xs -> summ xs (acc + x)

let result = summ [1;2;3;4;5] 0
(** 
`result` is evaluated for you
*)
(*** include-value: result ***)
(**

***
- data-background : ./images/unclebob.jpg


<div class="opaque">
<section data=markdown>

#### Classes in C#

    [lang=csharp]
    public class MyBaseClass
    {
        public MyBaseClass(int param1)
        {
            this.Param1 = param1;
        }
        public int Param1 { get; private set; }
    }

    public class MyDerivedClass: MyBaseClass
    {
        public MyDerivedClass(int param1, int param2): base(param1)
        {
            this.Param2 = param2;
        }
        public int Param2 { get; private set; }
    }

</div>
</section>

*** 
- data-background: ./images/donsyme.png

<div class="opaque">
<section data=markdown>

#### Classes in F#

*)
type BaseClass(param1) =
   member this.Param1 = param1

type DerivedClass(param1, param2) =
   inherit BaseClass(param1)
   member this.Param2 = param2

// type is derived at first usage
let derived = new DerivedClass(1,"hello")
(** 
`derived.Param2` is evaluated for you
*)
(*** include-value: derived.Param2 ***)

//for POCOs we just use immutable records
type Person = { Name : string }

(**

</div>
</section>

***
- data-background : ./images/marsOrbiter.jpg
- data-background-repeat : repeat
- data-background-size : 300px

#### Avoding Disasters (Unit of measures)

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

* [6-unit-conversion-disasters](http://mentalfloss.com/article/25845/quick-6-six-unit-conversion-disasters)

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

### And Scala?

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

### F# Leggends

- Don Syme (creator)
- Tomas Petricel (Type providers)
- Alfonso Garcia Caro (Fable)
- Scott Wlaschin (Domain Driven Design and F# expert)
- Mark Seeman (also author of Dependency Injection in .NET)
- Rachel Reese (ex-Jet CTO, 100% F# e-commerce company)
- Alena Hall (microsoft cloud advocate)

***

### Type Providers

- FSharp.Data (XML, XSD, JSON, CSV)
- Excel type provider
- Swagger type provider
- OpenApi type provider
- SqlProvider
- Froto.TypeProvider (protocol buffers)
- HTML type provider
- FileSystem type provider

*)