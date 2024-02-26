module Library.Product.Pricing
open Library.Product.DrinkTypes

// Define the types of drinks and their sizes , using Pattern Matching to compute the price of each drink based on its type and size 
let computePriceForDrink (product: Drink) =
    match product.Type, product.Size with

    // For Coffee
    | Coffee coffeeType, Small-> 
        match coffeeType with
        | Espresso -> 1.5
        | Americano -> 2.0
        | Latte -> 2.5

    | Coffee coffeeType, Medium ->
        match coffeeType with
        | Espresso -> 2.0
        | Americano -> 2.5
        | Latte -> 3.0

    | Coffee coffeeType, Large ->
        match coffeeType with
        | Espresso -> 2.5
        | Americano -> 3.0
        | Latte -> 3.5
    
    // For Tea
    | Tea teaType, Small ->
        match teaType with
        | Green -> 1.0
        | Black -> 1.5
        | White -> 2.0
    
    | Tea teaType, Medium ->
        match teaType with
        | Green -> 1.5
        | Black -> 2.0
        | White -> 2.5
        
    | Tea teaType, Large ->
        match teaType with
        | Green -> 2.0
        | Black -> 2.5
        | White -> 3.0
        
    // For Juice
    | Juice juiceType, Small ->
        match juiceType with
        | Orange -> 1.0
        | Apple -> 1.5
        | Mango -> 2.0
    
    | Juice juiceType, Medium ->
        match juiceType with
        | Orange -> 1.5
        | Apple -> 2.0
        | Mango -> 2.5
    
    | Juice juiceType, Large ->
        match juiceType with
        | Orange -> 2.0
        | Apple -> 2.5
        | Mango -> 3.0
    
    | _ -> failwith "Invalid product type or size"
    

           


