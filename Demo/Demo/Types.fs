namespace Demo

module Types=

 type SquareType = {
        Side : float
        } 

 type CircleType = {
        Radius : float
        } 

  type ShapeType = 
        | Square of SquareType
        | Circle of CircleType
        | Group of ShapeType seq 


 

