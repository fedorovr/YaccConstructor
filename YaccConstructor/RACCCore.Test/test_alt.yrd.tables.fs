//this tables was generated by RACC
//source grammar:..\Tests\RACC\test_alt\\test_alt.yrd
//date:12/15/2010 17:36:55

#light "off"
module Yard.Generators.RACCGenerator.Tables_Alt

open Yard.Generators.RACCGenerator

let autumataDict = 
dict [|("raccStart",{ 
   DIDToStateMap = dict [|(0,(State 0));(1,(State 1));(2,DummyState)|];
   DStartState   = 0;
   DFinaleStates = Set.ofArray [|1|];
   DRules        = Set.ofArray [|{ 
   FromStateID = 0;
   Symbol      = (DSymbol "s");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbS 0))|]|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 1;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 0))|]|];
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
   Symbol      = (DSymbol "MULT");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TAlt1S 5));(FATrace (TSeqS 2));(FATrace (TSmbS 1))|];List.ofArray [|(FATrace (TAlt2S 6));(FATrace (TSeqS 4));(FATrace (TSmbS 3))|]|];
   ToStateID   = 2;
}
;{ 
   FromStateID = 0;
   Symbol      = (DSymbol "PLUS");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TAlt1S 5));(FATrace (TSeqS 2));(FATrace (TSmbS 1))|];List.ofArray [|(FATrace (TAlt2S 6));(FATrace (TSeqS 4));(FATrace (TSmbS 3))|]|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 1;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 1));(FATrace (TSeqE 2));(FATrace (TAlt1E 5))|]|];
   ToStateID   = 3;
}
;{ 
   FromStateID = 2;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 3));(FATrace (TSeqE 4));(FATrace (TAlt2E 6))|]|];
   ToStateID   = 4;
}
|];
}
)|]

let items = 
List.ofArray [|("raccStart",0);("raccStart",1);("raccStart",2);("s",0);("s",1);("s",2);("s",3);("s",4)|]

let gotoSet = 
Set.ofArray [|(-1239003080,("raccStart",2));(-285614526,("s",2));(-635149922,("raccStart",1));(-946926030,("s",1));(1800920813,("s",3));(1800920910,("s",4));(452886823,("s",1));(864571735,("s",2))|]

