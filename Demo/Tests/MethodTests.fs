namespace Tests

open NUnit.Framework
open Demo.Methods
open Types

[<TestFixture>]
type MethodTests() =
    
    [<TestCase(2, ExpectedResult=4)>]
    member x.SquareArea a =
        AreaOfSquare {A = 2.0}