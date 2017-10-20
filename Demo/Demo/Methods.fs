namespace Demo

open Types

module Methods =
       open System

       let rec AreaOfShape a =

            let  AreaOfSquare a =
                a.A * a.A

            let  AreaOfCircle a =
                a.Radius * a.Radius * Math.PI * 2.0

            let AreaOfGroup group =
                List.fold (fun acc shape -> acc + AreaOfShape shape) 0.0 group

            match a with
                | Circle c -> AreaOfCircle c
                | Square sq -> AreaOfSquare sq
                | Group list -> AreaOfGroup list
       
     