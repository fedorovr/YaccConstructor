//this file was generated by RACC
//source grammar:..\Tests\RACC\test_arithm_glr\\test_arithm_glr.yrd
//date:12/13/2010 17:14:43

module RACC.Actions_Aritm_glr

open Yard.Generators.RACCGenerator

let value x = x.value

let s0 expr = 
    let inner () = 
        match expr with
        | RESeq [x0] -> 
            let (res) =
                let yardElemAction expr = 
                    match expr with
                    | RELeaf te -> te :?> 'a
                    | x -> "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\nRELeaf was expected." |> failwith

                yardElemAction(x0)
            (res)
        | x -> "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\nRESeq was expected." |> failwith
    box (inner ())
let e1 expr = 
    let inner () = 
        match expr with
        | REAlt(Some(x), None) -> 
            let yardLAltAction expr = 
                match expr with
                | RESeq [x0] -> 
                    let (n) =
                        let yardElemAction expr = 
                            match expr with
                            | RELeaf tNUMBER -> tNUMBER :?> 'a
                            | x -> "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\nRELeaf was expected." |> failwith

                        yardElemAction(x0)
                    (value n |> int)
                | x -> "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\nRESeq was expected." |> failwith

            yardLAltAction x 
        | REAlt(None, Some(x)) -> 
            let yardRAltAction expr = 
                match expr with
                | RESeq [x0; x1; x2] -> 
                    let (l) =
                        let yardElemAction expr = 
                            match expr with
                            | RELeaf te -> te :?> 'a
                            | x -> "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\nRELeaf was expected." |> failwith

                        yardElemAction(x0)
                    let (op) =
                        let yardElemAction expr = 
                            match expr with
                            | REAlt(Some(x), None) -> 
                                let yardLAltAction expr = 
                                    match expr with
                                    | RESeq [_] -> 

                                        ( (+) )
                                    | x -> "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\nRESeq was expected." |> failwith

                                yardLAltAction x 
                            | REAlt(None, Some(x)) -> 
                                let yardRAltAction expr = 
                                    match expr with
                                    | REAlt(Some(x), None) -> 
                                        let yardLAltAction expr = 
                                            match expr with
                                            | RESeq [_] -> 

                                                ( ( * ) )
                                            | x -> "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\nRESeq was expected." |> failwith

                                        yardLAltAction x 
                                    | REAlt(None, Some(x)) -> 
                                        let yardRAltAction expr = 
                                            match expr with
                                            | RESeq [_] -> 

                                                ( (-) )
                                            | x -> "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\nRESeq was expected." |> failwith

                                        yardRAltAction x 
                                    | x -> "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\nREAlt was expected." |> failwith

                                yardRAltAction x 
                            | x -> "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\nREAlt was expected." |> failwith

                        yardElemAction(x1)
                    let (r) =
                        let yardElemAction expr = 
                            match expr with
                            | RELeaf te -> te :?> 'a
                            | x -> "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\nRELeaf was expected." |> failwith

                        yardElemAction(x2)
                    (op l r)
                | x -> "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\nRESeq was expected." |> failwith

            yardRAltAction x 
        | x -> "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\nREAlt was expected." |> failwith
    box (inner ())

let ruleToAction = dict [|("e",e1); ("s",s0)|]

