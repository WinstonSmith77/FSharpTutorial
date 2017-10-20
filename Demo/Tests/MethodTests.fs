namespace Tests

open NUnit.Framework
open Demo.Methods
open Demo.Types

module MethodTests=

    let areaOfTestCircle = System.Math.PI * 2.0 * 2.0 * 2.0
    let circumferenceOfTestCircle = System.Math.PI * 2.0 

    [<TestFixture>]
    type MethodTests() =
    
        [<TestCase(2, ExpectedResult=4)>]
        member x.AreaSquare a =
            let square = Square {Side = a}
            Area square

        [<TestCase(2, ExpectedResult=8)>]
        member x.CircumferenceSquare a =
            let square = Square {Side = a}
            Circumference square

        [<Test>]
        member x.CircleArea ()  =
            let circle = Circle {Radius = 2.0}
            let area = Area circle
            Assert.AreEqual(area, areaOfTestCircle)

        member x.CircleCircumferencea ()  =
            let circle = Circle {Radius = 2.0}
            let circ = Circumference circle
            Assert.AreEqual(circ, circumferenceOfTestCircle)

        [<Test>]
        member x.GroupArea ()  =
            let c = Circle {Radius = 2.0}
            let square = Square {Side = 2.0}
            let group = Group [|c; square|]
            let area = Area group
            Assert.AreEqual(area, 4.0 + areaOfTestCircle)

        [<Test>]
        member x.CircumferenceGroup ()  =
            let square = Square {Side = 2.0}
            let group = Group [Group [Group [square; square]; square]; square]
            let area = Circumference group
            Assert.AreEqual(area , 4.0 * 8.0)