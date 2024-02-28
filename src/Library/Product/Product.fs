module Library.Product.Product

open Library.Product.Drink.DrinkType
open Library.Product.Food
open Library.Product.Fruit.FruitType

open Library.Product.Drink.PricingDrink
open Library.Product.Food.PricingFood
open Library.Product.Fruit.PricingFruit


type ProductTypes =
    | Drink of Drink
    | Food of Food
    | Fruit of Fruit
    
type Product = {
        ProductType: ProductTypes
}

// Calculate the price of a product

let getPriceOfProduct (product: Product) =
    match product.ProductType with
    | Drink drink ->
        computePriceForDrink drink
    | Food food ->
        computePriceForFood food
    | Fruit fruit ->
        computePriceForFruit fruit
    
