namespace Demo

open Types
open System

module Methods =

       let private  CircumferenceOfSquare a =
                4.0 * a.Side

       let private  AreaOfSquare a =
                a.Side * a.Side

       let private  AreaOfCircle a =
                a.Radius * a.Radius * Math.PI * 2.0

       let private  CircumferenceOfCircle a =
                Math.PI * 2.0 * a.Radius

       let private  FoldGroup callback group  =
                List.fold (fun acc shape -> acc + callback shape) 0.0 group

       let rec private Invoke circle square  a =

            match a with
                | Circle c -> circle c
                | Square sq -> square sq
                | Group list -> FoldGroup (fun a -> Invoke circle square a) list 

       let Area a = Invoke AreaOfCircle AreaOfSquare  a
       let Circumference a = Invoke CircumferenceOfCircle CircumferenceOfSquare  a
       
     