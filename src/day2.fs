module Day2

let checksum numbers =
    (Seq.max numbers) - (Seq.min numbers)

let parseLine (str: string) =
    str.Split('\t') 
    |> Seq.map int

let calculate filename =
    System.IO.File.ReadLines(filename)
    |> Seq.sumBy (parseLine >> checksum)

let day2_1 filename = 
    calculate filename
