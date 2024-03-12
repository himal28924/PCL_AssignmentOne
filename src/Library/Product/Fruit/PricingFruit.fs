module Library.Product.Fruit.PricingFruit
open Library.Product.Fruit.FruitType

// Calculate the price of a fruit
let computePriceForFruit (fruit: Fruit) =
    match fruit.FruitType with
    | Apple -> 5.0
    | Orange -> 3.0
    | Banana -> 6.0

