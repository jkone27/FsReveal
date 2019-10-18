- title : Introuduction to F#
- description : Introduction to F#
- author : Giacomo Parmigiani
- theme : night
- transition : default

***

### F#

c#

```csharp
var x = "hello"; //type inference only at declaration level

```

f#

```fsharp
let x = "Hello!" //type inference at declaration level

let y = (+) //but also at function level!

let z = fun x -> "hello " + x

let plus1 = y 1

let result = plus1 1

```

***

### Inheritance

C#
```csharp

public interface IAnimal { string MakeSound(); }

public class Dog : IAnimal {

    string MakeSound(){
        return "woff wof!";
    }
}

public class Cat : IAnimal {

    string MakeSound(){
        return "Meooowwww..";
    }
}
```

F#

```fsharp
let x = "Hello!" //type inference at declaration level

let y = (+) //but also at function level!

let z = fun x -> "hello " + x

let plus1 = y 1

let result = plus1 1
```

***

### My Third

```fsharp
let x = "Hello!"

type Dog(name: string) = 
    member __.Woff() = "wof wof!"
```