namespace Tests

open NUnit.Framework
open Demo.Methods
open Types

module MethodTests=

    let areaOfTestCircle = System.Math.PI * 2.0 * 2.0 * 2.0

    [<TestFixture>]
    type MethodTests() =
    
        [<TestCase(2, ExpectedResult=4)>]
        member x.SquareArea a =
            AreaOfSquare {A = a}

        [<Test>]
        member x.CircleArea ()  =
            let area = AreaOfCircle {Radius = 2.0}
            Assert.AreEqual(area, areaOfTestCircle)