let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y

printfn "%d" z

x <- 30
y <- 40

printfn "%d" (add x y)