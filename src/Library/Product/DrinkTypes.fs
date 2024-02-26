namespace Library.Product.DrinkTypes

type CoffeeType =
    | Espresso
    | Americano
    | Latte
    
type TeaType =
    | Green
    | Black
    | White
    
type JuiceType =
    | Orange
    | Apple
    | Mango

type DrinkType =
    | Coffee of CoffeeType
    | Tea of TeaType 
    | Juice of JuiceType
    
type Size =
    | Small
    | Medium
    | Large
    
type Drink = {
    Type : DrinkType
    Size : Size
}

