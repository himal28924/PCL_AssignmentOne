namespace Library.Product
open Library.Product.DrinkTypes

type ProductType =
    | Drink of Drink
    // | Food
    // | Fruit
    
type Product = {
    Type : ProductType
}
