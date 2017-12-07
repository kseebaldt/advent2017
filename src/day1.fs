module Day1

let pairup numbers = 
    match numbers with
    | x :: xs -> List.zip numbers (xs @ [x])
    | _ -> []

let calculate (numbers: int list) = 
    pairup numbers
    |> List.filter (fun (a, b) -> a = b)
    |> List.fold (fun sum (a, _) -> sum + a) 0

let readInts filename =
    System.IO.File.ReadLines(filename)
    |> Seq.head
    |> Seq.map (string >> int)
    |> Seq.toList

let day1 filename = 
    readInts filename
    |> calculate
