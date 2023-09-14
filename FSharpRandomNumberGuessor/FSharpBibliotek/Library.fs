namespace FSharpBibliotek

open System

module Say =
    let hello name =
        sprintf "Hello %s" name


module RandomNumber =
    
    let rnd = new Random()

    let random = rnd.Next(1, 100)