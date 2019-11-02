
(**
- title : Type Providers 
- description : type providers slides
- author : Giacomo Parmigiani
- theme : night
- transition : default

***

# Type Providers

* F# has a smart and simple API to generate types at compile time! 

---

<iframe src="https://fsharp.github.io/FSharp.Data/index.html" width="800" height="400"></iframe>

---

* In Memory!!!

---

* Not a single file is generated in our repository

---

* No static "contracts" with external sources, to be mantained, versioned, upgraded

---

* Types are **alive** they change together with the source

---

* Fast Prototyping and Rapid Feedback!

---

* True Magic!

---

#### HTML - FSharp.Data

<iframe src="https://en.wikipedia.org/wiki/List_of_Doctor_Who_episodes_(1963%E2%80%931989)" width="800" height="400"></iframe>

* Let's say we want to read the second season's director of Doctor Who from 1964...

---

*)

#r "../packages/FSharp.Data/lib/netstandard2.0/FSharp.Data.dll"
#r "../packages/XPlot.GoogleCharts/lib/netstandard2.0/XPlot.GoogleCharts.dll"

open FSharp.Data

[<Literal>]
let DrWhoWikipediaPage = "https://en.wikipedia.org/wiki/List_of_Doctor_Who_episodes_(1963%E2%80%931989)" 

type DrWho = FSharp.Data.HtmlProvider<DrWhoWikipediaPage>

let who = DrWho.GetSample()

let directed = who.Tables.``Season 2 (1964-1965)``.Rows.[0].``Directed by``

printfn "%s" directed

(**

---

### CSV (comma separated values)

<iframe scr="https://people.sc.fsu.edu/~jburkardt/data/csv/csv.html" width="800" height="400"></iframe>

*)

[<Literal>]
let DeniroCsv = "https://people.sc.fsu.edu/~jburkardt/data/csv/deniro.csv" 

type Deniro = FSharp.Data.CsvProvider<DeniroCsv>

let rob = Deniro.GetSample()

let moviesFrom77 = 
    rob.Rows 
    |> Seq.filter (fun x -> x.Year = 1977) 
    |> Seq.map (fun x -> x.Title)

printfn "%A" moviesFrom77

(**


### Sources

* [Type providers in action - 2013](https://blogs.msdn.microsoft.com/dsyme/2013/01/30/twelve-f-type-providers-in-action/)


*)