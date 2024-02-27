module Library.Product.Drink.PricingDrink
open Library.Product.Drink.DrinkTypes

// Define the types of drinks and their sizes , using Pattern Matching to compute the price of each drink based on its type and size 
let computePriceForDrink (product: Drink) =
    match product.Type, product.Size with

    // For Coffee
    | Coffee coffeeType, Small-> 
        match coffeeType with
        | Espresso -> 12.0
        | Americano -> 18.0
        | Latte -> 20.5

    | Coffee coffeeType, Medium ->
        match coffeeType with
        | Espresso -> 14.0
        | Americano -> 20.5
        | Latte -> 22.0

    | Coffee coffeeType, Large ->
        match coffeeType with
        | Espresso -> 16.0
        | Americano -> 21.0
        | Latte -> 23.0
    
    // For Tea
    | Tea teaType, Small ->
        match teaType with
        | Green -> 10.0
        | Black -> 11.5
        | White -> 20.0
    
    | Tea teaType, Medium ->
        match teaType with
        | Green -> 11.5
        | Black -> 13.0
        | White -> 22.5
        
    | Tea teaType, Large ->
        match teaType with
        | Green -> 12.0
        | Black -> 15.5
        | White -> 23.0
        
    // For Juice
    | Juice juiceType, Small ->
        match juiceType with
        | Orange -> 19.0
        | Apple -> 18.5
        | Mango -> 20.0
    
    | Juice juiceType, Medium ->
        match juiceType with
        | Orange -> 19.5
        | Apple -> 20.0
        | Mango -> 22.5
    
    | Juice juiceType, Large ->
        match juiceType with
        | Orange -> 20.0
        | Apple -> 22.5
        | Mango -> 26.0
    
    | _ -> failwith "Invalid product type or size"
    




