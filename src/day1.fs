module Day1

let rotate list n =
    (List.skip n list) @ (List.take n list)

let pairup n numbers = 
    match numbers with
    | x :: xs -> List.zip numbers (rotate numbers n)
    | _ -> []

let calculate (n: int) (numbers: int list) = 
    pairup n numbers
    |> List.filter (fun (a, b) -> a = b)
    |> List.fold (fun sum (a, _) -> sum + a) 0

let readInts filename =
    System.IO.File.ReadLines(filename)
    |> Seq.head
    |> Seq.map (string >> int)
    |> Seq.toList

let day1_1 filename = 
    readInts filename
    |> calculate 1

let day1_2 filename = 
    let numbers = readInts filename
    calculate (List.length numbers / 2) numbers