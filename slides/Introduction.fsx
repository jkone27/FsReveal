(**
- title : Introduction 
- description : Introduction to F#
- author : Giacomo Parmigiani
- theme : night
- transition : default

***

### What is F#

- .NET (and .netcore) functional first programming language. F# derives most of his synthax from OCaml which is a language developed by Inria(FR) 
- OCAML: Object Categorical Abstract Metalanguage is also derived from CAML, which derives from stanford ML (meta language)
- ML is one of the oldest implementation of a strongly typed and type inferenced functional programming language
- other famous "old" functional programming langs like LISP or ERLANG are dynamically typed, we will see this makes quite a huge difference

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

### Why F#

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

#### More F#

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

*)