module Tests


open Xunit
open ToyFactory.Say

[<Fact>]
let ``SayMyName`` () =
    let actual = hello "Batman"
    Assert.Equal(actual, "Hello Batman")
    
    
[<Fact>]
let ``DontSayMyName`` () =
    let actual = hello ""
    Assert.Equal(actual, "Hello ")