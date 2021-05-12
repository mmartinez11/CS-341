module Project02

// Function 1

let rec max L =
   
    match L with 
    | [] -> raise(System.ArgumentException("List Is Empty"))
    | head::[] -> head
    | head::tail -> let other = max tail
                    if head > other then head else other
    

// Function 2

let rec min L =

    match L with
    | [] -> raise(System.ArgumentException("List Is Empty"))
    | head::[] -> head
    | head::tail -> let other = min tail
                    if head < other then head else other


// Function 3

let rec nth L n =
    
    match L with 
    | [] -> raise(System.IndexOutOfRangeException("Index Not Found"))
    | head::_ when n < 0 -> raise(System.IndexOutOfRangeException("Index Not Found"))
    | head::rest when n > 0 -> nth rest (n-1)
    | head::_ -> head


// Function 4

let rec find L item =
    match L with
    | [] -> raise(System.ArgumentException("Index Not Found"))
    | head::_ when head <= item && head >=item -> 0
    | head::rest -> 1 + find rest item


// Function 5

let rec count L item =
    match L with
    | [] -> 0
    | head::rest when head <= item && head >= item -> 1 + count rest item
    | head::rest -> 0 + count rest item


// Function 6

let rec map F L =
    match L with
    | [] -> []
    | head::rest -> F head::map F rest


// Function 7

let iter F L =
   for i in L do F i


// Function 8

let rec reduce F L =
    
    match L with
    | [] -> raise(System.ArgumentException("Error"))
    | head::[] -> head 
    | head::rest -> let holder = (F head rest.Head)::rest.Tail
                    reduce F holder


// Function 9

let rec fold F start L =
    
    match L with
    | [] -> start
    | head::[] -> F start head
    | head::rest -> fold F (F start head) rest


// Function 10

let rec flatten L =
    match L with 
    |[] -> []
    |head::[] -> head
    |head::rest -> head@rest.Head@flatten rest.Tail


// Function 11

let rec zip L1 L2 =
   
      if  L1 = [] && L2 = [] then []
      else ((List.head L1), (List.head L2))::(zip (List.tail L1) (List.tail L2))


// Function 12

let rec unzip L =
    match L with
    | [] -> ([],[])
    | (a,b)::[] -> ([a],[b])
    | (a,b)::tl -> let (c,d) =  (unzip tl)
                   (a::c,b::d)


// Function 13

let rec GCD A B =

    let rec helper a b =
        match a with
        | 0 -> b
        | _ when b=0 -> a
        | _ when a>b -> helper (a-b) b
        | _ -> helper a (b-a)

    helper A B


// Function 14

let GCDList L =
    
    let valu = 0

    let rec gcd a b =
        match a with
        | 0 -> b
        | _ when b=0 -> a
        | _ when a>b -> gcd (a-b) b
        | _ -> gcd a (b-a)

    let rec helper2 list v =

        let value = v

        match list with
        | [] -> value
        | head::[] -> let holder = gcd v head
                      helper2 [] holder                           
        | head::rest when valu <> 0 -> let holder = gcd v head
                                       helper2 rest holder
        | head::rest -> let holder = gcd head rest.Head
                        helper2 rest.Tail holder

    helper2 L valu 


// Function 15

let isPrime i =

    let counter = 2;

    let rec m t c = 
        let result = t % c
        match result with
        | _ when c=t -> true
        | 0 -> false
        | _ -> m t (c+1)

    if i=1 then false 
    elif i=2 then true
    else m i counter


// Function 16

let rec Primes t =

    let isPrime i =

        let counter = 2;

        let rec helper a c = 
            let result = a % c
            match result with
            | _ when c=a -> true
            | 0 -> false
            | _ -> helper a (c+1)

        if i=1 then false 
        elif i=2 then true
        else helper i counter

    
    let rec blist m =
        let mark = m;
        let result = isPrime mark
    
        match result with
        | false when mark=t -> []
        | true when mark=t -> [t]
        | false -> blist (mark+1)
        | true -> mark::blist (mark+1)

    blist 0


// Function 17

let isMatch str =
    false         //   TO BE IMPLEMENTED


// Function 18

let firstMatch s =
    ""          //   TO BE IMPLEMENTED


// Function 19

let allMatches s = 
    []             //   TO BE IMPLEMENTED


// Function 20

let rec RegEx s pattern =
    true         //    TO BE IMPLEMENTED




















