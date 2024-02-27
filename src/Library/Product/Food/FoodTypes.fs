namespace Library.Product.Food

type FoodTypes =
    | Rice
    | Chicken
    | Fish
    | Sandwich

type Food ={
    Type: FoodTypes
    Weight: double
}
           