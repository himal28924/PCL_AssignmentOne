namespace Library.Product.Drink.DrinkType

type CoffeeType =
    | Espresso
    | Americano
    | Latte
    
type TeaType =
    | Green
    | Black
    | White
    
type JuiceType =
    | OrangeJuice
    | AppleJuice
    | MangoJuice

type DrinkTypes =
    | Coffee of CoffeeType
    | Tea of TeaType 
    | Juice of JuiceType
    
type Size =
    | Small
    | Medium
    | Large
    
type Drink = {
    DrinkType : DrinkTypes
    Size : Size
}

