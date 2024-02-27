open System
open Library
open Library.Product.PricingDrink
open Library.Product.DrinkTypes

[<EntryPoint>]
let main args =
    // drink instance
    let myDrink = { Type = Coffee Espresso; Size = Small }

    // Compute the price for the drink
    let price = computePriceForDrink myDrink
    
    printfn "The price of the drink is: %f" price

    let mySecondDrink = { Type = Juice Mango; Size = Large }
    let price = computePriceForDrink mySecondDrink

    // Print out the price
    printfn "The price of the drink is: %f" price

    0 // return an integer exit code
