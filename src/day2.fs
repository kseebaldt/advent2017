module Day2

let checksum numbers =
    (Seq.max numbers) - (Seq.min numbers)

let rec findDivisible (numbers: int list) = 
    match numbers with
    | [] -> (0, 0)
    | x :: xs ->
        let divisible = Seq.filter (fun num -> x % num = 0) xs
        if Seq.length divisible > 0 then (x, Seq.head divisible) else findDivisible xs

let checksum2 numbers =
    let (x, y) = findDivisible ((Seq.sort >> Seq.rev >> Seq.toList) numbers)
    x / y

let parseLine (str: string) =
    str.Split('\t') 
    |> Seq.map int

let calculate f filename =
    System.IO.File.ReadLines(filename)
    |> Seq.sumBy (parseLine >> f)

let day2_1 filename = 
    calculate checksum filename

let day2_2 filename = 
    calculate checksum2 filename
