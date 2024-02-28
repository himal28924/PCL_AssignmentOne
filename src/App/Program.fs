open System
open Library
open Library.Product.Drink.DrinkType
open Library.Product.Food
open Library.Product.Fruit.FruitType
open Library.Product.Product

open Library.Order.Order

[<EntryPoint>]
let main args =

    // Declaring drinks 
    let drink1 = {DrinkType = Coffee (Espresso) ; Size = Small }
    let drink2 = {DrinkType = Tea (White) ; Size = Medium }
    let drink3 = {DrinkType = Juice (MangoJuice) ; Size = Large }
    
    // Declaring food
    let food1 = {FoodType =  Rice ; Weight = 0.5}
    let food2 = {FoodType = Sandwich ; Weight = 1}    
    let food3 = {FoodType = Chicken ; Weight = 1.5}
    
    // Declaring fruits
    let fruit1 = {FruitType = Apple ;}
    let fruit2 = {FruitType = Banana ;}
    let fruit3 = {FruitType = Orange ;}
    
    // Declaring products
    let drinkProduct1 = { ProductType = Drink drink1 }
    let drinkProduct2 = { ProductType = Drink drink2 }
    let drinkProduct3 = { ProductType = Drink drink3 }
    
    let foodProduct1 = { ProductType = Food food1 }
    let foodProduct2 = { ProductType = Food food2 }
    let foodProduct3 = { ProductType = Food food3 }
    
    let fruitProduct1 = { ProductType = Fruit fruit1 }
    let fruitProduct2 = { ProductType = Fruit fruit2 }
    let fruitProduct3 = { ProductType = Fruit fruit3 }
    
    
    let orderFromCustomer = {
        ProductsToOrders = [
            drinkProduct1 ; drinkProduct2 ; drinkProduct3
            foodProduct1 ; foodProduct2 ; foodProduct3
            fruitProduct1 ; fruitProduct2 ; fruitProduct3
        ]
    }
    
    let totalPrice = calculateTotalPrice orderFromCustomer
    
    printfn "Total price is %f" totalPrice 
    
    // Declaring orders
    
    
    0 //
    