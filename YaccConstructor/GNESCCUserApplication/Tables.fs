//this tables was generated by GNESCC
//source grammar:../../Tests/GNESCC/test_seq\test_seq.yrd
//date:8/2/2011 12:36:18

module Yard.Generators.GNESCCGenerator.Tables

open Yard.Generators.GNESCCGenerator
open Yard.Generators.GNESCCGenerator.CommonTypes

type symbol =
    | T_PLUS
    | T_NUMBER
    | NT_b
    | NT_a
    | NT_s
    | NT_gnesccStart
let getTag smb =
    match smb with
    | T_PLUS -> 8
    | T_NUMBER -> 7
    | NT_b -> 6
    | NT_a -> 5
    | NT_s -> 4
    | NT_gnesccStart -> 2
let getName tag =
    match tag with
    | 8 -> T_PLUS
    | 7 -> T_NUMBER
    | 6 -> NT_b
    | 5 -> NT_a
    | 4 -> NT_s
    | 2 -> NT_gnesccStart
    | _ -> failwith "getName: bad tag."
let prodToNTerm = 
  [| 3; 2; 1; 0 |];
let symbolIdx = 
  [| 2; 3; 3; 3; 2; 1; 0; 1; 0 |];
let startKernelIdxs =  [0]
let isStart =
  [| [| true; true; true; true |];
     [| false; false; false; false |];
     [| false; false; false; false |];
     [| false; false; false; false |];
     [| false; false; false; false |];
     [| false; false; false; false |];
     [| false; false; false; false |]; |]
let gotoTable =
  [| [| Some 3; Some 2; Some 1; None |];
     [| None; None; None; None |];
     [| None; None; None; None |];
     [| None; None; None; None |];
     [| None; None; None; None |];
     [| None; None; None; None |];
     [| None; None; None; None |]; |]
let actionTable = 
  [| [| [Error]; [Shift 4]; [Error]; [Error] |];
     [| [Error]; [Error]; [Error]; [Accept] |];
     [| [Error]; [Error]; [Error]; [Reduce 1] |];
     [| [Error]; [Error]; [Error]; [Reduce 1] |];
     [| [Shift 5]; [Error]; [Error]; [Error] |];
     [| [Error]; [Shift 6]; [Error]; [Error] |];
     [| [Error]; [Error]; [Error]; [Reduce 2; Reduce 3] |]; |]
let tables = 
  {StartIdx=startKernelIdxs
   SymbolIdx=symbolIdx
   GotoTable=gotoTable
   ActionTable=actionTable
   IsStart=isStart
   ProdToNTerm=prodToNTerm}
