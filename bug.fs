let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //this will print 20 20 as expected

let swap2 x y = 
    let temp = x
    x <- y
    y <- temp

let x2 = 10
let y2 = 20
swap2 x2 y2
printf "%d %d" x2 y2  //this will print 10 20 not 20 10 as expected. 