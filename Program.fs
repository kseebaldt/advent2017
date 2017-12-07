open System
open Day1
open Day2

let runProblem (problem: string): unit =
    match problem with
    | "1-1" -> Console.WriteLine (day1_1 "input/day1-1.txt")
    | "1-2" -> Console.WriteLine (day1_2 "input/day1-1.txt")
    | "2-1" -> Console.WriteLine (day2_1 "input/day2-1.txt")
    | _ -> Console.WriteLine "¯\_(ツ)_/¯"

[<EntryPoint>]
let main argv =
    match argv with
    | [| problem|] -> runProblem problem
    | _ -> Console.WriteLine "Specify problem"
    0