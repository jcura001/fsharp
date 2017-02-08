//homework 1

//problem 1
//C. int and float types not compatible 

//problem2
//C. t1 -> (t2 -> t3)

//problem3
//
let p3 (x:float) (y:float )= x < y;;


//problem4
//B. Their built-in functions are polymorphic.

//problem5
//C. 1::2::3::[]

//problem6
//List.map List.head foo @ baz
//D.??

//problem7
//D. int*bool -> string list

let p7 (10, "cat") = snd::[];;

//problem8
//D.
let rec foo = function
    |(xs , []) -> xs
    |(xs , y::ys) -> foo(xs@[y], ys)
foo ([1..5],[6..9]);;

//problem9
//C.
fun f -> f 17;;

//problem10
//D.
fun x -> x::[5];;

//problem11
//A.

//problem12
//A.
fun x y -> x+y+".";;

//problem 13
//D. ?why? ask
fun xs -> List.map (+) xs;;

//problem14
//A.
fun x -> fun y -> x + y + ".";;


//problem15
//C.
fun f -> f (f "cat");;

//problem16

let rec gcd = function 
    | (a,0) -> a
    | (a,b) -> gcd (b, a % b)

let add a b = a+b

let (.+) (a,b) (c,d) = 
    if b = d then (a,b)
    
    
//problem17
let revlists List.map(fun xs -> )