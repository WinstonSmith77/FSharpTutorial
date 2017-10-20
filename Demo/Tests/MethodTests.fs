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
            let square = Square {A = a}
            AreaOfShape square

        [<Test>]
        member x.CircleArea ()  =
            let circle = Circle {Radius = 2.0}
            let area = AreaOfShape circle
            Assert.AreEqual(area, areaOfTestCircle)