//this file was generated by RACC
//source grammar:..\Tests\RACC\test_l_attr\test_l_attr.yrd
//date:3/20/2011 1:11:12 PM

module RACC.Actions_L_attr

open Yard.Generators.RACCGenerator

let getUnmatched x expectedType =
    "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\n" + expectedType + " was expected." |> failwith

let value x = (x:>Lexeme<string>).value         

let s0 expr = 
    let inner  = 
        match expr with
        | RESeq [x0] -> 
            let (res:int) =
                let yardElemAction expr = 
                    match expr with
                    | RELeaf e -> (e :?> _ )1 
                    | x -> getUnmatched x "RELeaf"

                yardElemAction(x0)
            (res)
        | x -> getUnmatched x "RESeq"
    box (inner)
let e1 expr = 
    let inner (i) = 
        match expr with
        | RESeq [x0] -> 
            let (n) =
                let yardElemAction expr = 
                    match expr with
                    | RELeaf tNUMBER -> tNUMBER :?> 'a
                    | x -> getUnmatched x "RELeaf"

                yardElemAction(x0)
            ((value n |> int) + i)
        | x -> getUnmatched x "RESeq"
    box (inner)

let ruleToAction = dict [|("e",e1); ("s",s0)|]

