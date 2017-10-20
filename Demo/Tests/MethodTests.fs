namespace Tests


open NUnit.Framework
open Demo.Methods

[<TestFixture>]
type MethodTests() =
    
    [<TestCase(2, ExpectedResult=4)>]
    member x.SquareArea a =
        AreaOfSquare a