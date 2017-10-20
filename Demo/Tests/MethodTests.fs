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

        [<Test>]
        member x.GroupArea ()  =
            let c = Circle {Radius = 2.0}
            let square = Square {A = 2.0}
            let group = Group [c; square]
            let area = AreaOfShape  group
            Assert.AreEqual(area, 4.0 + areaOfTestCircle)

        [<Test>]
        member x.GroupArea2 ()  =
            let square = Square {A = 2.0}
            let group = Group [Group [Group [square; square]; square]; square]
            let area = AreaOfShape (group)
            Assert.AreEqual(area , 4.0 * 4.0)