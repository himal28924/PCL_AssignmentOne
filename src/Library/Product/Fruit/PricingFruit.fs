module Library.Product.Fruit.PricingFruit
open Library.Product.Fruit.FruitType

// Calculate the price of a fruit
let CalculatePrice (fruit: Fruit) =
    match fruit.Type with
    | Apple -> 5
    | Orange -> 3
    | Banana -> 6

