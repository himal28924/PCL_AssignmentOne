module Library.Product.Fruit.PricingFruit
open Library.Product.Fruit.FruitType

// Calculate the price of a fruit
let computePriceForFruit (fruit: Fruit) =
    match fruit.FruitType with
    | Apple -> 5
    | Orange -> 3
    | Banana -> 6

