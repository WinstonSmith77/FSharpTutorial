module Types

 type SquareType = {
        A : float
        } 

 type CircleType = {
        Radius : float
        } 

  type Shape = 
        | Square of SquareType
        | Circle of CircleType


 

