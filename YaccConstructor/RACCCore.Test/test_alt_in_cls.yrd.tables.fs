//this tables was generated by RACC
//source grammar:..\Tests\RACC\test_alt_in_cls\test_alt_in_cls.yrd
//date:3/20/2011 1:11:06 PM

#light "off"
module Yard.Generators.RACCGenerator.Tables_alt_in_cls

open Yard.Generators.RACCGenerator

type symbol =
    | T_PLUS
    | T_MINUS
    | NT_s
let getTag smb =
    match smb with
    | T_PLUS -> 2
    | T_MINUS -> 1
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
   DIDToStateMap = dict [|(0,(State 0));(1,(State 1));(2,(State 2));(3,DummyState);(4,DummyState);(5,DummyState)|];
   DStartState   = 2;
   DFinaleStates = Set.ofArray [|0;1;2|];
   DRules        = Set.ofArray [|{ 
   FromStateID = 0;
   Symbol      = (DSymbol "MINUS");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 2));(FATrace (TSeqE 3));(FATrace (TAlt1E 6));(FATrace (TAlt1S 6));(FATrace (TSeqS 3));(FATrace (TSmbS 2))|]
;List.ofArray [|(FATrace (TSmbE 2));(FATrace (TSeqE 3));(FATrace (TAlt1E 6));(FATrace (TAlt2S 7));(FATrace (TSeqS 5));(FATrace (TSmbS 4))|]
;List.ofArray [|(FATrace (TSmbE 2));(FATrace (TSeqE 3));(FATrace (TAlt1E 6));(FATrace (TClsE 1));(FATrace (TSeqE 8))|]
|];
   ToStateID   = 0;
}
;{ 
   FromStateID = 0;
   Symbol      = (DSymbol "PLUS");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 2));(FATrace (TSeqE 3));(FATrace (TAlt1E 6));(FATrace (TAlt1S 6));(FATrace (TSeqS 3));(FATrace (TSmbS 2))|]
;List.ofArray [|(FATrace (TSmbE 2));(FATrace (TSeqE 3));(FATrace (TAlt1E 6));(FATrace (TAlt2S 7));(FATrace (TSeqS 5));(FATrace (TSmbS 4))|]
;List.ofArray [|(FATrace (TSmbE 2));(FATrace (TSeqE 3));(FATrace (TAlt1E 6));(FATrace (TClsE 1));(FATrace (TSeqE 8))|]
|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 0;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 2));(FATrace (TSeqE 3));(FATrace (TAlt1E 6));(FATrace (TAlt1S 6));(FATrace (TSeqS 3));(FATrace (TSmbS 2))|]
;List.ofArray [|(FATrace (TSmbE 2));(FATrace (TSeqE 3));(FATrace (TAlt1E 6));(FATrace (TAlt2S 7));(FATrace (TSeqS 5));(FATrace (TSmbS 4))|]
;List.ofArray [|(FATrace (TSmbE 2));(FATrace (TSeqE 3));(FATrace (TAlt1E 6));(FATrace (TClsE 1));(FATrace (TSeqE 8))|]
|];
   ToStateID   = 3;
}
;{ 
   FromStateID = 1;
   Symbol      = (DSymbol "MINUS");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 4));(FATrace (TSeqE 5));(FATrace (TAlt2E 7));(FATrace (TAlt1S 6));(FATrace (TSeqS 3));(FATrace (TSmbS 2))|]
;List.ofArray [|(FATrace (TSmbE 4));(FATrace (TSeqE 5));(FATrace (TAlt2E 7));(FATrace (TAlt2S 7));(FATrace (TSeqS 5));(FATrace (TSmbS 4))|]
;List.ofArray [|(FATrace (TSmbE 4));(FATrace (TSeqE 5));(FATrace (TAlt2E 7));(FATrace (TClsE 1));(FATrace (TSeqE 8))|]
|];
   ToStateID   = 0;
}
;{ 
   FromStateID = 1;
   Symbol      = (DSymbol "PLUS");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 4));(FATrace (TSeqE 5));(FATrace (TAlt2E 7));(FATrace (TAlt1S 6));(FATrace (TSeqS 3));(FATrace (TSmbS 2))|]
;List.ofArray [|(FATrace (TSmbE 4));(FATrace (TSeqE 5));(FATrace (TAlt2E 7));(FATrace (TAlt2S 7));(FATrace (TSeqS 5));(FATrace (TSmbS 4))|]
;List.ofArray [|(FATrace (TSmbE 4));(FATrace (TSeqE 5));(FATrace (TAlt2E 7));(FATrace (TClsE 1));(FATrace (TSeqE 8))|]
|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 1;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 4));(FATrace (TSeqE 5));(FATrace (TAlt2E 7));(FATrace (TAlt1S 6));(FATrace (TSeqS 3));(FATrace (TSmbS 2))|]
;List.ofArray [|(FATrace (TSmbE 4));(FATrace (TSeqE 5));(FATrace (TAlt2E 7));(FATrace (TAlt2S 7));(FATrace (TSeqS 5));(FATrace (TSmbS 4))|]
;List.ofArray [|(FATrace (TSmbE 4));(FATrace (TSeqE 5));(FATrace (TAlt2E 7));(FATrace (TClsE 1));(FATrace (TSeqE 8))|]
|];
   ToStateID   = 4;
}
;{ 
   FromStateID = 2;
   Symbol      = (DSymbol "MINUS");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSeqS 8));(FATrace (TClsS 1));(FATrace (TAlt1S 6));(FATrace (TSeqS 3));(FATrace (TSmbS 2))|]
;List.ofArray [|(FATrace (TSeqS 8));(FATrace (TClsS 1));(FATrace (TAlt2S 7));(FATrace (TSeqS 5));(FATrace (TSmbS 4))|]
;List.ofArray [|(FATrace (TSeqS 8));(FATrace (TClsS 1));(FATrace (TClsE 1));(FATrace (TSeqE 8))|]
|];
   ToStateID   = 0;
}
;{ 
   FromStateID = 2;
   Symbol      = (DSymbol "PLUS");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSeqS 8));(FATrace (TClsS 1));(FATrace (TAlt1S 6));(FATrace (TSeqS 3));(FATrace (TSmbS 2))|]
;List.ofArray [|(FATrace (TSeqS 8));(FATrace (TClsS 1));(FATrace (TAlt2S 7));(FATrace (TSeqS 5));(FATrace (TSmbS 4))|]
;List.ofArray [|(FATrace (TSeqS 8));(FATrace (TClsS 1));(FATrace (TClsE 1));(FATrace (TSeqE 8))|]
|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 2;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSeqS 8));(FATrace (TClsS 1));(FATrace (TAlt1S 6));(FATrace (TSeqS 3));(FATrace (TSmbS 2))|]
;List.ofArray [|(FATrace (TSeqS 8));(FATrace (TClsS 1));(FATrace (TAlt2S 7));(FATrace (TSeqS 5));(FATrace (TSmbS 4))|]
;List.ofArray [|(FATrace (TSeqS 8));(FATrace (TClsS 1));(FATrace (TClsE 1));(FATrace (TSeqE 8))|]
|];
   ToStateID   = 5;
}
|];
}
)|]

let private gotoSet = 
    Set.ofArray [|(("raccStart",0,"Dummy"),Set.ofArray [|("s",3)|]);(("raccStart",0,"MINUS"),Set.ofArray [|("s",0)|]);(("raccStart",0,"PLUS"),Set.ofArray [|("s",1)|]);(("raccStart",0,"s"),Set.ofArray [|("raccStart",1)|]);(("raccStart",1,"Dummy"),Set.ofArray [|("raccStart",2)|]);(("s",0,"Dummy"),Set.ofArray [|("s",3)|]);(("s",0,"MINUS"),Set.ofArray [|("s",0)|]);(("s",0,"PLUS"),Set.ofArray [|("s",1)|]);(("s",1,"Dummy"),Set.ofArray [|("s",4)|]);(("s",1,"MINUS"),Set.ofArray [|("s",0)|]);(("s",1,"PLUS"),Set.ofArray [|("s",1)|]);(("s",2,"Dummy"),Set.ofArray [|("s",5)|]);(("s",2,"MINUS"),Set.ofArray [|("s",0)|]);(("s",2,"PLUS"),Set.ofArray [|("s",1)|])|]
    |> dict
let tables = { gotoSet = gotoSet; automataDict = autumataDict }

