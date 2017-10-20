namespace Demo

open Types

module Methods =
       open System
       
       let AreaOfSquare a =
            a.A * a.A

       let AreaOfCircle a =
            a.Radius * a.Radius * Math.PI * 2.0