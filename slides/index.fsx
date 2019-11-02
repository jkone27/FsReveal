(**
- title : Introduction 
- description : Introduction to F#
- author : Giacomo Parmigiani
- theme : night
- transition : default

***
- data-background: ./images/wowfsharp.jpg
- data-background-repeat: repeat
- data-background-size: 800px

<div id="zoom">
  <h1 id="first-slide-title">F#</h1>
</div>

slides done with
[FsReveal](https://fsprojects.github.io/FsReveal/formatting.html) (F# JsReveal)

***
- data-background : ./images/seabed01.jpg
- data-background-size : cover

' is most often used as a cross-platform Common Language Infrastructure (CLI) language, 
' but it can also generate JavaScript and graphics processing unit (GPU) code.
' Is developed by the F# Software Foundation, Microsoft and open contributors. 
' An open source, cross-platform compiler for F# is available from the F# Software Foundation.
' F# is also a fully supported language in Visual Studio and Xamarin Studio.
' Other tools supporting F# development include Mono, MonoDevelop, SharpDevelop, MBrace, and WebSharper.
' Plug-ins supporting F# exist for many widely used editors, most notably the Ionide extension for Atom and Visual Studio Code, 
' and integrations for other editors such as Vim, Emacs, Sublime Text, and Rider.
' Is a member of the ML language family and originated as a .NET Framework implementation 
' of a core of the programming language OCaml.
' It has also been influenced by C#, Python, Haskell, Scala, and Erlang.

### What will be talking about

<iframe src="https://fsharp.org/" width="800" height="400"></iframe>

---

### Tell me more!

![cartesian-map](./images/languages-map.png)

---

* general purpose, **strongly typed**, **multi-paradigm** 
* **cross-platform** (.NET/.netcore)
* can also generate **JavaScript** and **GPU code**

---

* makes it easy to write **correct** and **maintainable** code
* expressions are **type-inferred and generalized automatically**
* a data-rich experience with **type providers**
* also a **scripting language**

---
- data-background : ./images/batman.jpg
- data-background-size: 500px

***

***

#### example, declaring a Factorial function

*)

let factorial x = [1..x] |> List.reduce (*)

let c = factorial 5
(** 
`c` is evaluated for you
*)
(*** include-value: c ***)
(**

---
- data-background : ./images/underwater01.jpg

### [Try F#!](https://try.fsharp.org/)


***
- data-background : ./images/underwater02.jpg

## Foundamentals

* Let
* Default Types
* Type aka Custom Types

---

### Let

* binds an expression to a name (in scope)

*)

let x = 5
let sum = (+)
let mysum a b = a + b

let myComplexSum a b =
    let mySum x y = x + y + 42
    mySum a b

(**

---

### default types ADTs

*)

let tuple = (1,2,3,"hole",System.DateTime.Now)
let lista = [1;2;3;4;5;6]
let arr = [|1;2;3;4;5;6|]
let enumerable = seq { 1 .. 5 }

(**

and some common operations (HOFs)

*)

let higherOrderFunctions = 
    lista 
    |> Seq.filter (fun x -> x > 2) //where
    |> Seq.map (fun x -> x.ToString()) //select
    |> Seq.reduce (+) //aggregate ~ foldl

(**

---

### Type

* define complex types 
    * dynamic types: classes, interfaces
    * structs, union types

---

*)

type Person = { Name: string; Age: int}

type ICustomer =
    abstract member Name : string

type AnonymousCustomer() =
    interface ICustomer with
        member this.Name = "Unknown"

type Customer( name: string ) =
    interface ICustomer with
        member this.Name = name
    override this.ToString() = sprintf "Customer: %s" name

type VertebratedAnimal = 
    | Mammal of string //union case constructor
    | Reptile of string*string 
    | Aphibian of System.DateTime
    | Fish of int
    | Bird of decimal

(**

---

### A Brief Note from Category Theory

<svg xmlns="http://www.w3.org/2000/svg" version="1.1" height="40%" width="40%" viewBox="0 0 100 100" xmlns:xlink="http://www.w3.org/1999/xlink">
  <defs>
    <style type="text/css">
      path {
        fill: transparent;
        stroke: red;
        stroke-width: 0.5;
      }
      path:hover {
        fill: red;
      }
    </style>
  </defs>
  <path d="M 50 8 A 30 30 0 1 0 21 59 30 30 0 0 1 41 36 30 30 0 0 1 50 8" />
  <path d="M 50 8 A 30 30 0 0 0 41 36 30 30 0 0 1 59 36 30 30 0 0 0 50 8" />
  <path d="M 50 8 A 30 30 0 1 1 79 59 30 30 0 0 0 59 36 30 30 0 0 0 50 8" />
  <path d="M 50 52 A 30 30 0 0 1 21 59 30 30 0 0 1 41 36 30 30 0 0 0 50 52" />
  <path d="M 50 52 A 30 30 0 0 1 41 36 30 30 0 0 1 59 36 30 30 0 0 1 50 52" />
  <path d="M 50 52 A 30 30 0 0 0 79 59 30 30 0 0 0 59 36 30 30 0 0 1 50 52" />
  <path d="M 21 59 A 30 30 0 1 0 79 59 30 30 0 0 1 50 52 30 30 0 0 1 21 59" />
</svg>

* **Sum types (+)** : set sum (e.g. sql union)
* **Product types (*)** set cartesian product (e.g. sql join)
* All the types you know <mark> in any language </mark> are either one or the other!

---

### SUM (+) Types

* an instance always has <mark> all of the included types </mark>

*)

//this is ALWAYS int * string
let myTuple = (1,"hello")
//always a Person (which is string * int)
let johnPerson = { Name = "john"; Age = 13 }

(**

---

### PRODUCT (*) Types

* an instance can be <mark>any of the individual subtypes</mark>
* for an abstract **class** or **interface**, inheritance provides **dynamic** subtyping
* for a **union**, each "case" provides a **static** subtyping for the Union type

*)

//Classes:
//each class inheriting from ICustomer is a subtype of this interface
let johnCustomer = new Customer("john") :> ICustomer
let mrNobody = new AnonymousCustomer() :> ICustomer

//Unions:
//each case is a constructor of a subtype
let myBirdie = Bird(12.5m)
let myFishy = Fish(35)

(**

***

### Some more useful stuff

* **namespace** - fsharp uses namespaces like C#
* <mark>open</mark> is the using;import keyword
* **module** : fsharp default component is a module == static class (under the hood)
* F# anc C# projects can happily live together in the same solution, and be cross-referenced

*)

open System

//namespace Test.Cool
    //module MyModule =
let CoolFunction =
    printfn "hello from my module" //from C# using Test.Cool; MyModule.CoolFunction();
            

(** 

---

### Pattern Matching

*)
let patternMatchings =

    //tuple deconstruction
    let x,_ = (1,2) 
    //list deconstruction
    let z::zs = [1;2;3;4;5;6;7]
    let [oneElementList] = [1]
    let x::[] = [1]

    //record deconstruction
    let { Name = test } = { Name = "john"; Age = 21 }

    let printHelloIfFish animal =
        match animal with
        |Fish(value) -> printfn "%i" value
        |_ -> () //all other cases

    ()
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

---

### Recursive Types
  
*)
type MyNode = Leaf of string | Parent of MyNode

let rec printAllLeafs mynode =
    match mynode with
    |Leaf(value) -> printfn "%s" value
    |Parent(child) -> printAllLeafs child
(**

---
- data-background : ./images/tailRecursive.png

***
- data-background : ./images/turtleOpenMouth.jpg
- data-background-size : cover

### Bored? Let's talk [Type Providers!](http://localhost:8083/TypeProviders.html#/)

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

---
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

// types are inferred at first usage
let derived = new DerivedClass(1,"hello")
(** 
`derived.Param2` is evaluated for you
*)
(*** include-value: derived.Param2 ***)

(**

</div>
</section>

***
- data-background : ./images/unclebob.jpg

<div class="opaque">
<section data=markdown>

#### Class with equality in C#

    [lang=csharp]
    public class Foo : IEquatable<Foo>{
	    public int MyNum {get; set;}
	    public string MyStr {get; set;}
	    public DateTime Time {get; set;}

	    public bool Equals(Foo other){
	    	if(other == null) return false;
	    	return MyNum == other.MyNum &&
	    		Time == other.Time &&
	    		string.Equals(MyStr, other.MyStr);
	    }

	    public override bool Equals(object obj){
	    	if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
	    	return Equals(obj as Foo);
	    }

	    public override int GetHashCode(){
	    	//...
      }
    }

</div>
</section>

---
- data-background: ./images/donsyme.png

<div class="opaque">
<section data=markdown>

#### Class with equality in F# 

not needed: Record! already implements standard equatable, plus is immutable by default

*)
type Foo = { MyNum: int; MyString : string; Time: System.DateTime }
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
let size = 1700<sqft>
let price = 53000<dollar>
let pricePerSize = price/size
(**

#### `pricePerSize`

*)
(*** include-value: pricePerSize ***)
(**

* [6-unit-conversion-disasters](http://mentalfloss.com/article/25845/quick-6-six-unit-conversion-disasters)

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

##### Sources
* [microsoft](https://en.wikipedia.org/wiki/F_Sharp_(programming_language))
* [wikipedia](https://docs.microsoft.com/en-us/dotnet/fsharp/what-is-fsharp)
* [type providers](https://docs.microsoft.com/en-us/dotnet/fsharp/tutorials/fsharp-interactive/)
* [scripting language](https://docs.microsoft.com/en-us/dotnet/fsharp/tutorials/type-providers/)

*)