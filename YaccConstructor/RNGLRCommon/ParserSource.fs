﻿//  Parser.fs contains type, describing information, written to file as result of generation
//     and used by Parser and Translator.
//
//  Copyright 2011-2012 Avdyukhin Dmitry
//
//  This file is part of YaccConctructor.
//
//  YaccConstructor is free software:you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace Yard.Generators.RNGLR

type ParserSource<'TokenType> (gotos : int option[][]
                               , reduces : list<int * int>[][]
                               , zeroReduces : list<int>[][]
                               , accStates : bool[]
                               , rules : int[]
                               , rulesStart : int[]
                               , leftSide : int[]
                               , startRule : int
                               , eofIndex : int
                               , tokenToNumber : 'TokenType -> int) =
    let length =
        let res = Array.zeroCreate <| (rulesStart.Length - 1)
        for i=0 to res.Length-1 do
            res.[i] <- rulesStart.[i+1] - rulesStart.[i]
        res
    member this.Reduces = reduces
    member this.ZeroReduces = zeroReduces
    member this.Gotos = gotos
    member this.AccStates = accStates
    member this.Rules = rules
    member this.RulesStart = rulesStart
    member this.Length = length
    member this.LeftSide = leftSide
    member this.StartRule = startRule
    member this.EofIndex = eofIndex
    member this.TokenToNumber = tokenToNumber