//this file was generated by GNESCC
//source grammar:../../../Tests/GNESCC/test_alt_in_cls/test_alt_in_cls.yrd
//date:8/5/2011 14:48:51

module GNESCC.Actions_alt_in_cls

open Yard.Generators.GNESCCGenerator

let getUnmatched x expectedType =
    "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\n" + expectedType + " was expected." |> failwith

let value x = (x:>Lexer_alt_in_cls.MyLexeme).MValue

let s0 expr = 
    let inner  = 
        match expr with
        | RESeq [x0] -> 
            let (res) =
                let yardElemAction expr = 
                    match expr with
                    | REClosure(lst) -> 
                        let yardClsAction expr = 
                            match expr with
                            | REAlt(Some(x), None) -> 
                                let yardLAltAction expr = 
                                    match expr with
                                    | RESeq [x0] -> 
                                        let (m) =
                                            let yardElemAction expr = 
                                                match expr with
                                                | RELeaf tMINUS -> tMINUS :?> 'a
                                                | x -> getUnmatched x "RELeaf"

                                            yardElemAction(x0)
                                        (m)
                                    | x -> getUnmatched x "RESeq"

                                yardLAltAction x 
                            | REAlt(None, Some(x)) -> 
                                let yardRAltAction expr = 
                                    match expr with
                                    | RESeq [x0] -> 
                                        let (p) =
                                            let yardElemAction expr = 
                                                match expr with
                                                | RELeaf tPLUS -> tPLUS :?> 'a
                                                | x -> getUnmatched x "RELeaf"

                                            yardElemAction(x0)
                                        (p)
                                    | x -> getUnmatched x "RESeq"

                                yardRAltAction x 
                            | x -> getUnmatched x "REAlt"

                        List.map yardClsAction lst 
                    | x -> getUnmatched x "REClosure"

                yardElemAction(x0)
            (List.map value res|> String.concat ";")
        | x -> getUnmatched x "RESeq"
    box (inner)

let ruleToAction = dict [|(4,s0)|]

