module Library.Product.Food.PricingFood
open Library.Product.Food

// Calculate the price of a food product
let computePriceForFood (product: Food) =
    match product.FoodType with
    | Chicken -> product.Weight * 45.0
    | Rice -> product.Weight * 20.0
    | Fish -> product.Weight * 35.0
    | Sandwich -> product.Weight * 25.0
    | _ -> failwith "Unknown food type"
