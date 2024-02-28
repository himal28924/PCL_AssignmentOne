module Library.Order.Order

open Library.Product.Product


// Order list

type OrderProduct = {
    ProductsToOrders: Product list
}

// calculate the total price of an order
let calculateTotalPrice (order: OrderProduct) =
     match order.ProductsToOrders with 
        | [] -> 0.0
        | _ -> order.ProductsToOrders |> List.sumBy getPriceOfProduct
        