let mutable x = 10
let mutable y = 20

let swap (x:byref<int>) (y:byref<int>) = 
    let temp = x
    x <- y
    y <- temp

swap &x &y
printf "%d %d" x y //this will print 20 10

let x2 = 10
let y2 = 20
swap &x2 &y2
printf "%d %d" x2 y2 //this will print 20 10