//this tables was generated by RACC
//source grammar:..\Tests\RACC\test_seq\\test_seq.yrd
//date:12/13/2010 17:14:35

#light "off"
module Yard.Generators.RACCGenerator.Tables_Seq

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
   DIDToStateMap = dict [|(0,(State 0));(1,(State 1));(2,(State 2));(3,(State 3));(4,DummyState)|];
   DStartState   = 0;
   DFinaleStates = Set.ofArray [|3|];
   DRules        = Set.ofArray [|{ 
   FromStateID = 0;
   Symbol      = (DSymbol "NUMBER");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSeqS 4));(FATrace (TSmbS 1))|]|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 1;
   Symbol      = (DSymbol "PLUS");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 1));(FATrace (TSmbS 2))|]|];
   ToStateID   = 2;
}
;{ 
   FromStateID = 2;
   Symbol      = (DSymbol "NUMBER");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 2));(FATrace (TSmbS 3))|]|];
   ToStateID   = 3;
}
;{ 
   FromStateID = 3;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 3));(FATrace (TSeqE 4))|]|];
   ToStateID   = 4;
}
|];
}
)|]

let items = 
List.ofArray [|("raccStart",0);("raccStart",1);("raccStart",2);("s",0);("s",1);("s",2);("s",3);("s",4)|]

let gotoSet = 
Set.ofArray [|(-1239003080,("raccStart",2));(-1408241699,("s",1));(-635149922,("raccStart",1));(1800920879,("s",4));(1904107658,("s",3));(1904107720,("s",1));(452886726,("s",2))|]

