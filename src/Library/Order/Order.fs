module Library.Order.Order

open Library.Product
open Library.Product.Product
    
// Order list

type OrderProduct = {
    ProductsToOrders: Product list
}

// // calculate the total price of an order
// let calculateTotalPrice (order: OrderProduct) =
//      match order.ProductsToOrders with 
//         | [] -> 0.0
//         | _ -> order.ProductsToOrders |> List.sumBy getPriceOfProduct  
        
// VAT
let gtgVAT price VAT =
    price * (1.0 + VAT/100.0)
        
type OrderDrinkMsg =
    | OrderProduct of Product * int
    | LeaveComment of string
    
let getAgent = MailboxProcessor.Start(fun inbox ->
    let rec messageLoop() = async {
        // Receive a message
        printfn "Waiting for a message"
        let! msg = inbox.Receive()
        match msg with
            |OrderProduct(product, qty) -> 
                let totalPrice = getPriceOfProduct product qty 
                printfn "The total price of the order is: %f for your %A products" totalPrice product.ProductType
            | LeaveComment(comment) ->
                printfn "Thanks for your comment: %s" comment
        return! messageLoop()
    }
    messageLoop()
)
        
