namespace Demo

open Types

module Methods =
       open System

       let private AreaOfSquare a =
            a.A * a.A

       let private AreaOfCircle a =
            a.Radius * a.Radius * Math.PI * 2.0

       let AreaOfShape a =
            match a with
                | Circle c -> AreaOfCircle c
                | Square sq -> AreaOfSquare sq
       
     