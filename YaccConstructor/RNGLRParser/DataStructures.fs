﻿module Yard.Generators.RNGLR.DataStructures

open System

type BlockResizeArray<'T> () =
    let initArraysCount = 1
    let mutable count = 0
    let shift = 15
    let blockSize = 1 <<< shift
    let smallPart = blockSize - 1
    let mutable arrays = Array.init initArraysCount (fun _ -> Array.zeroCreate blockSize)
    let mutable cap = blockSize * arrays.Length
    let mutable nextAllocate = cap
    member this.Add (x : 'T) =
        if count = nextAllocate then
            if count = cap then
                let oldArrays = arrays
                arrays <- Array.zeroCreate (arrays.Length * 2)
                for i = 0 to oldArrays.Length-1 do
                    arrays.[i] <- oldArrays.[i]
                for i = oldArrays.Length to oldArrays.Length-1 do
                    arrays.[i] <- Array.zeroCreate blockSize
                cap <- blockSize * arrays.Length
                //printfn "%A %A" count cap
            arrays.[count >>> shift] <- Array.zeroCreate blockSize
            nextAllocate <- nextAllocate + blockSize
        arrays.[count >>> shift].[count &&& smallPart] <- x
        count <- count + 1

    member this.Item i =
        if i >= count then raise <| System.ArgumentOutOfRangeException()
        else arrays.[i >>> shift].[i &&& smallPart]

    member this.Count = count

    member this.ToArray() =
        let res = Array.zeroCreate count
        for i = 0 to (count >>> shift) - 1 do
            Array.Copy(arrays.[i], 0, res, i <<< shift, blockSize)
        if (count &&& smallPart) <> 0 then
            let i = count >>> shift
            Array.Copy(arrays.[i], 0, res, i <<< shift, count &&& smallPart)
        res