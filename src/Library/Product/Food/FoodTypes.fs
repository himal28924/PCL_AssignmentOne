namespace Library.Product.Food

type FoodTypes =
    | Rice
    | Chicken
    | Fish
    | Sandwich

type Food ={
    FoodType: FoodTypes
    Weight: double
}
           