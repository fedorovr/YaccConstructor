//this tables was generated by RACC
//source grammar:..\Tests\RACC\test_opt\test_opt.yrd
//date:3/20/2011 1:11:18 PM

#light "off"
module Yard.Generators.RACCGenerator.Tables_Opt

open Yard.Generators.RACCGenerator

type symbol =
    | T_PLUS
    | T_NUMBER
    | NT_s
let getTag smb =
    match smb with
    | T_PLUS -> 2
    | T_NUMBER -> 1
    | NT_s -> 0
let private autumataDict = 
dict [|("raccStart",{ 
   DIDToStateMap = dict [|(0,(State 0));(1,(State 1));(2,DummyState)|];
   DStartState   = 0;
   DFinaleStates = Set.ofArray [|1|];
   DRules        = Set.ofArray [|{ 
   FromStateID = 0;
   Symbol      = (DSymbol "s");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbS 0))|]
|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 1;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 0))|]
|];
   ToStateID   = 2;
}
|];
}
);("s",{ 
   DIDToStateMap = dict [|(0,(State 0));(1,(State 1));(2,(State 2));(3,DummyState);(4,DummyState)|];
   DStartState   = 0;
   DFinaleStates = Set.ofArray [|1;2|];
   DRules        = Set.ofArray [|{ 
   FromStateID = 0;
   Symbol      = (DSymbol "NUMBER");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSeqS 5));(FATrace (TSmbS 1))|]
|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 1;
   Symbol      = (DSymbol "PLUS");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 1));(FATrace (TOptS 2));(FATrace (TOptE 2));(FATrace (TSeqE 5))|]
;List.ofArray [|(FATrace (TSmbE 1));(FATrace (TOptS 2));(FATrace (TSeqS 4));(FATrace (TSmbS 3))|]
|];
   ToStateID   = 2;
}
;{ 
   FromStateID = 1;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 1));(FATrace (TOptS 2));(FATrace (TOptE 2));(FATrace (TSeqE 5))|]
;List.ofArray [|(FATrace (TSmbE 1));(FATrace (TOptS 2));(FATrace (TSeqS 4));(FATrace (TSmbS 3))|]
|];
   ToStateID   = 3;
}
;{ 
   FromStateID = 2;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 3));(FATrace (TSeqE 4));(FATrace (TOptE 2));(FATrace (TSeqE 5))|]
|];
   ToStateID   = 4;
}
|];
}
)|]

let private gotoSet = 
    Set.ofArray [|(("raccStart",0,"NUMBER"),Set.ofArray [|("s",1)|]);(("raccStart",0,"s"),Set.ofArray [|("raccStart",1)|]);(("raccStart",1,"Dummy"),Set.ofArray [|("raccStart",2)|]);(("s",0,"NUMBER"),Set.ofArray [|("s",1)|]);(("s",1,"Dummy"),Set.ofArray [|("s",3)|]);(("s",1,"PLUS"),Set.ofArray [|("s",2)|]);(("s",2,"Dummy"),Set.ofArray [|("s",4)|])|]
    |> dict
let tables = { gotoSet = gotoSet; automataDict = autumataDict }

